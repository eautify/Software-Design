Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Threading
Imports System.Web.UI.WebControls

Public Class MainForm
    Dim plateNumberPlaceholder As String
    Dim Type As String
    Dim TimeIn As String
    Dim TimeOut As String
    Dim hourDiff As Double
    Dim parkingLocation As String
    Dim parkingFloor As String
    Dim amountTopay As Double
    Dim ParkingFee As Double
    Dim SubTotal As Double
    Dim discount As Double
    Dim TotalDiscount As Double
    Dim change As Double
    Dim exitPL As String
    Dim daList As New OleDbDataAdapter
    Dim daLog As New OleDbDataAdapter
    Dim daTrans As New OleDbDataAdapter
    Dim da As New OleDbDataAdapter
    Dim dset As New DataSet
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim WithEvents VD As New PrintDocument
    Dim VVD As New PrintPreviewDialog
    Dim longpaper As Integer
    Dim rate As Double
    Dim y As Double
    Dim noParkingLocation As String
    Dim noFloor As String = "ERROR"

    Dim rand As New Random()
    Dim combinedArray As String()

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        LogIn_Form.Show()
        Me.Hide()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginSuccess()
        Try
            connect()
            Dim query As String = "SELECT MAX(ID) FROM ticketNumbers"
            Using command As New OleDbCommand(query, conn)
                ' Execute the SQL query and retrieve the highest value
                Dim highestValue As Object = command.ExecuteScalar()

                ' Check if the highest value is not null
                If highestValue IsNot DBNull.Value Then
                    ' Display the highest value in a message box
                    Serial = CInt(highestValue)
                Else
                    Serial = 0
                End If
            End Using
        Catch ex As Exception
            dbFailed()
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        tabMainNew.Appearance = TabAppearance.FlatButtons
        tabMainNew.ItemSize = New Size(0, 1)
        tabMainNew.SizeMode = TabSizeMode.Fixed

        TabParkingView.Appearance = TabAppearance.FlatButtons
        TabParkingView.ItemSize = New Size(0, 1)
        TabParkingView.SizeMode = TabSizeMode.Fixed

        lblUser.Text = FullName

        btnPrintTicket.Enabled = False
        'btnNextVehicle.Enabled = False
        txtAmountTendered.Enabled = False
        btnPay.Enabled = False
        btnPrintReceipt.Enabled = False
        btnNextExit.Enabled = False

        populate()
        GetAvailability()
        loadDetails()
        PopulateComboBox()
    End Sub

    Function populate()
        Try
            Dim da As New OleDbDataAdapter("SELECT ParkingLocation FROM tblVehicleList", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            listVehicle.DataSource = dt
            listVehicle.DisplayMember = "ParkingLocation"
            listVehicle.ClearSelected()
        Catch ex As Exception
            dbFailed()
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        Return True
    End Function

    Sub createTicket()
        If noParkingLocation.Contains("1F") Then
            noFloor = "1st Level"
        ElseIf noParkingLocation.Contains("2F") Then
            noFloor = "2nd Level"
        ElseIf noParkingLocation.Contains("3F") Then
            noFloor = "3rd Level"
        End If

        For Each c As Control In {cbVehicleType, txtPlateNumber}
            c.Enabled = False
        Next

        btnCreateTicket.Enabled = False
        'btnPrintTicket.Enabled = True
        btnReset.Enabled = False

        connect()
        Try
            Dim cmd As New OleDbCommand("Insert into tblVehicleList values(@floor, @location, @ticket, @plate, @type, @datetime)", conn)
            cmd.Parameters.AddWithValue("@floor", noFloor)
            cmd.Parameters.AddWithValue("@location", noParkingLocation)
            cmd.Parameters.AddWithValue("@ticket", txtTicketNumber.Text)
            cmd.Parameters.AddWithValue("@plate", txtPlateNumber.Text)
            cmd.Parameters.AddWithValue("@type", cbVehicleType.Text)
            cmd.Parameters.AddWithValue("@datetime", Format(Now, "MM/dd/yy hh:mm tt"))
            cmd.ExecuteNonQuery()

            cmd = New OleDbCommand("Insert into tblParkingActivity values(@ticket, @plate, @type, @location, @datetime, @entry)", conn)
            cmd.Parameters.AddWithValue("@ticket", txtTicketNumber.Text)
            cmd.Parameters.AddWithValue("@plate", txtPlateNumber.Text)
            cmd.Parameters.AddWithValue("@type", cbVehicleType.Text)
            cmd.Parameters.AddWithValue("@location", noParkingLocation)
            cmd.Parameters.AddWithValue("@datetime", Format(Now, "MM/dd/yy hh:mm tt"))
            cmd.Parameters.AddWithValue("@entry", "Vehicle entered.")
            cmd.ExecuteNonQuery()

            cmd = New OleDbCommand("Insert into ticketNumbers values(@serial, @ticket)", conn)
            cmd.Parameters.AddWithValue("@serial", Serial.ToString("00"))
            cmd.Parameters.AddWithValue("@ticket", txtTicketNumber.Text)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
        populate()
    End Sub


    Private Sub btnCreateTicket_Click(sender As Object, e As EventArgs) Handles btnCreateTicket.Click
        If String.IsNullOrEmpty(txtPlateNumber.Text) OrElse String.IsNullOrEmpty(cbVehicleType.Text) Then
            MsgBox("Vehicle information can't be incomplete.", vbInformation, "Invalid Entry")
            Exit Sub
        End If

        If (txtPlateNumber.TextLength < 4) Then
            MsgBox("That is an invalid plate number.", vbInformation, "Invalid Plate Number")
            txtPlateNumber.Clear()
            txtPlateNumber.Focus()
            Exit Sub
        End If

        If MsgBox("Confrim parking?", vbYesNo + vbQuestion, "Confirm") = vbYes Then
            Try
                connect()
                If cbVehicleType.SelectedIndex = 0 Then
                    If count2Slots = 42 Then
                        MsgBox("Parking lots for 2 wheels vehicle are full.", vbInformation, "Parking lot full")
                        Exit Sub
                    Else
                        Serial += 1
                        rate = vehicle2Wheels

                        Dim array1FA As String() = {"1FA-01", "1FA-02", "1FA-03", "1FA-04", "1FA-05", "1FA-06", "1FA-07", "1FA-08", "1FA-09", "1FA-10"}
                        Dim array2FA As String() = {"2FA-01", "2FA-02", "2FA-03", "2FA-04", "2FA-05", "2FA-06", "2FA-07", "2FA-08", "2FA-09", "2FA-10", "2FA-11", "2FA-12", "2FA-13", "2FA-14", "2FA-15", "2FA-16", "2FA-17", "2FA-18"}
                        Dim array23FA As String() = {"3FA-01", "3FA-02", "3FA-03", "3FA-04", "3FA-05", "3FA-06", "3FA-07", "3FA-08", "3FA-09", "3FA-10", "3FA-11", "3FA-12", "3FA-13", "3FA-14"}

                        Dim list As New List(Of String)
                        list.AddRange(array1FA)
                        list.AddRange(array2FA)
                        list.AddRange(array23FA)

                        combinedArray = list.ToArray()
                        noParkingLocation = combinedArray(rand.Next(0, combinedArray.Length))
                        Dim query As String = "SELECT COUNT(*) FROM tblVehicleList WHERE ParkingLocation=@Location"
                        Dim cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Location", noParkingLocation)
                        Dim count As Integer = CInt(cmd.ExecuteScalar())
                        While count > 0
                            noParkingLocation = combinedArray(rand.Next(0, combinedArray.Length))
                            cmd.Parameters("@Location").Value = noParkingLocation
                            count = CInt(cmd.ExecuteScalar())
                        End While

                        txtTicketNumber.Text = "TK-" & Serial.ToString("00000")
                        createTicket()
                    End If
                Else
                    If count4Slots = 97 Then
                        MsgBox("Parking lots for 4 wheels vehicle are full.", vbInformation, "Parking lot full")
                        Exit Sub
                    Else
                        Serial += 1
                        rate = vehicle4Wheels

                        Dim array1FB As String() = {"1FB-01", "1FB-02", "1FB-03", "1FB-04", "1FB-05", "1FB-06", "1FB-07", "1FB-08", "1FB-09", "1FB-10", "1FB-11"}
                        Dim array1FC As String() = {"1FC-01", "1FC-02", "1FC-03", "1FC-04", "1FC-05", "1FC-06", "1FC-07", "1FC-08", "1FC-09", "1FC-10", "1FC-11"}
                        Dim array1FD As String() = {"1FD-01", "1FD-02", "1FD-03", "1FD-04", "1FD-05", "1FD-06", "1FD-07", "1FD-08", "1FD-09", "1FD-10", "1FD-11", "1FD-12"}
                        Dim array2FB As String() = {"2FB-01", "2FB-02", "2FB-03", "2FB-04", "2FB-05", "2FB-06", "2FB-07", "2FB-08", "2FB-09", "2FB-10", "2FB-11"}
                        Dim array2FC As String() = {"2FC-01", "2FC-02", "2FC-03", "2FC-04", "2FC-05", "2FC-06", "2FC-07", "2FC-08", "2FC-09", "2FC-10", "2FC-11"}
                        Dim array2FD As String() = {"2FD-01", "2FD-02", "2FD-03", "2FD-04", "2FD-05", "2FD-06", "2FD-07"}
                        Dim array3FB As String() = {"3FB-01", "3FB-02", "3FB-03", "3FB-04", "3FB-05", "3FB-06", "3FB-07", "3FB-08", "3FB-09", "3FB-10", "3FB-11"}
                        Dim array3FC As String() = {"3FC-01", "3FC-02", "3FC-03", "3FC-04", "3FC-05", "3FC-06", "3FC-07", "3FC-08", "3FC-09", "3FC-10", "3FC-11"}
                        Dim array3FD As String() = {"3FD-01", "3FD-02", "3FD-03", "3FD-04", "3FD-05", "3FD-06", "3FD-07", "3FD-08", "3FD-09", "3FD-10", "3FD-11", "3FD-12"}

                        Dim list As New List(Of String)
                        list.AddRange(array1FB)
                        list.AddRange(array1FC)
                        list.AddRange(array1FD)
                        list.AddRange(array2FB)
                        list.AddRange(array2FC)
                        list.AddRange(array2FD)
                        list.AddRange(array3FB)
                        list.AddRange(array3FC)
                        list.AddRange(array3FD)

                        combinedArray = list.ToArray()
                        noParkingLocation = combinedArray(rand.Next(0, combinedArray.Length))
                        Dim query As String = "SELECT COUNT(*) FROM tblVehicleList WHERE ParkingLocation=@Location"
                        Dim cmd As New OleDbCommand(query, conn)
                        cmd.Parameters.AddWithValue("@Location", noParkingLocation)
                        Dim count As Integer = CInt(cmd.ExecuteScalar())
                        While count > 0
                            noParkingLocation = combinedArray(rand.Next(0, combinedArray.Length))
                            cmd.Parameters("@Location").Value = noParkingLocation
                            count = CInt(cmd.ExecuteScalar())
                        End While

                        txtTicketNumber.Text = "TK-" & Serial.ToString("00000")
                        createTicket()
                    End If
                End If
                loadDetails()
                GetAvailability()
            Catch ex As Exception
                dbFailed()
                MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
            End Try
        End If
    End Sub



    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        cbVehicleType.SelectedIndex = -1
        txtPlateNumber.Clear()
        txtTicketNumber.Clear()
        cbVehicleType.Enabled = True
        txtPlateNumber.Enabled = True
        btnCreateTicket.Enabled = True
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 350)
        PD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f5 As New Font("Helvetica", 5, FontStyle.Regular)
        Dim f5b As New Font("Helvetica", 5, FontStyle.Bold)
        Dim f8 As New Font("Helvetica", 8, FontStyle.Regular)


        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        e.Graphics.DrawString("PARKINGS", f5b, Brushes.Black, centermargin, 10, center)
        e.Graphics.DrawString("Rizal Technology University - Pasig Campus", f5, Brushes.Black, centermargin, 20, center)
        e.Graphics.DrawString("M. Eusebio Avenue, Maybunga, San Miguel, Pasig City", f5, Brushes.Black, centermargin, 30, center)
        e.Graphics.DrawString("+63-9123456789 | customerservice@parkings.com", f5, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("--------------------------------------------------------------------", f5, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("PARKING PASS", f5b, Brushes.Black, centermargin, 70, center)


        e.Graphics.DrawString("Ticket Number: " + txtTicketNumber.Text, f5b, Brushes.Black, centermargin, 85, center)
        e.Graphics.DrawString("Vehicle Type: " + cbVehicleType.Text, f5, Brushes.Black, centermargin, 100, center)
        'e.Graphics.DrawString("Plate Number: " + txtPlateNumber.Text, f5, Brushes.Black, centermargin, 110, center)
        'e.Graphics.DrawString("Floor: " + cbFloor.SelectedItem, f5, Brushes.Black, centermargin, 120, center)
        'e.Graphics.DrawString("Park Location: " + cbParkingLocation.Text, f5, Brushes.Black, centermargin, 130, center)
        e.Graphics.DrawString("Time In: " + Format(Now, "MM/dd/yy hh:mm tt"), f5, Brushes.Black, centermargin, 140, center)

        e.Graphics.DrawString("Base rate of P" + rate.ToString + " for " + cbVehicleType.SelectedItem + " type of vehicle", f5, Brushes.Black, centermargin, 156, center)
        e.Graphics.DrawString("Additional fee of P" + feesPerHours.ToString + " every hour after the first " + freeHours.ToString + " hour/s", f5, Brushes.Black, centermargin, 163, center)
        e.Graphics.DrawString("(A fraction of an hour is considered as 1 hour)", f5, Brushes.Black, centermargin, 170, center)

        e.Graphics.DrawString("--------------------------------------------------------------------", f5, Brushes.Black, centermargin, 185, center)

        e.Graphics.DrawString("TERMS AND CONDITION", f5b, Brushes.Black, centermargin, 200, center)


        e.Graphics.DrawString("- This ticket is non-transferable and may only be used for the vehicle
listed on the ticket.
- This ticket only guarantees a parking space as indicated by the
parking location written above.
- The ticket issuer reserves the right to revoke the ticket at any time
and for any reason.
- The ticket holder is responsible for any damage caused by the
vehicle while parked.
- Upon accepting this ticket, the holder is deemed to have agreed to
the terms and conditions and is obligated to abide by the rules
and regulations of the parking area.", f5, Brushes.Black, 20, 215)

    End Sub



    Private Sub btnPrintTicket_Click(sender As Object, e As EventArgs) Handles btnPrintTicket.Click
        btnNextVehicle.Enabled = True
        btnReset.Enabled = False
        PPD.Document = PD
        PPD.ShowDialog()
    End Sub

    Private Sub btnNextVehicle_Click(sender As Object, e As EventArgs) Handles btnNextVehicle.Click
        If MsgBox("Create new ticket?", vbYesNo + vbQuestion, "New ticket") = vbYes Then
            'cbVehicleType.SelectedIndex = -1
            txtPlateNumber.Clear()
            txtTicketNumber.Clear()

            cbVehicleType.Enabled = True
            txtPlateNumber.Enabled = True

            btnPrintTicket.Enabled = False
            btnCreateTicket.Enabled = True
            'btnNextVehicle.Enabled = False

            cbVehicleType.SelectedIndex = 1
            txtPlateNumber.Text = "TK " + Serial.ToString

            btnReset.Enabled = True
            Exit Sub
        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        Try
            connect()
            LoadTicketInfo()
        Catch ex As Exception
            dbFailed()
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub LoadTicketInfo()
        Dim cmd As New OleDbCommand("Select * from tblVehicleList where TicketNumber=@TicketNumber", conn)
        cmd.Parameters.AddWithValue("TicketNumber", cmbMyField.Text.Trim)
        Dim myreader As OleDbDataReader
        myreader = cmd.ExecuteReader
        If myreader.Read() Then
            Type = myreader("VehicleType")
            plateNumberPlaceholder = myreader("PlateNumber")
            exitPL = myreader("ParkingLocation")
            TimeIn = myreader("TimeIn")
            parkingLocation = myreader("ParkingLocation")
            parkingFloor = myreader("Floor")

            Dim formatTime As String = "MM/dd/yy hh:mm tt"
            Dim startDate As Date = Date.ParseExact(TimeIn, formatTime, Nothing)
            Dim endDate As Date = Date.ParseExact(Format(Now, "MM/dd/yy hh:mm tt"), formatTime, Nothing)
            Dim timeDiff As TimeSpan = endDate - startDate

            hourDiff = Math.Ceiling(timeDiff.TotalHours)
            txtDuration.Text = hourDiff.ToString() & " Hour/s."

            Dim x As Double
            If hourDiff < freeHours Then
                x = 0
            Else
                x = hourDiff - freeHours
            End If

            If Type = "2 Wheels" Then
                ParkingFee = vehicle2Wheels
            Else
                ParkingFee = vehicle4Wheels
            End If
            txtParkingFee.Text = "P " & Format(ParkingFee, "0.00")

            y = x * feesPerHours

            txtComputed.Text = "P " & Format(y, "0.00")

            SubTotal = ParkingFee + y


            txtSubTotal.Text = "P " & Format(SubTotal, "0.00")

            If cbDiscount.Text = "Student (" & FormatPercent(studentDisc) & ")" Then
                discount = studentDisc
            ElseIf cbDiscount.Text = "PWD and Senior Citizen (" & FormatPercent(pwdNseniorDisc) & ")" Then
                discount = pwdNseniorDisc
            Else
                discount = 0
            End If
            TotalDiscount = ParkingFee * discount
            txtDiscount.Text = "-P " & Format(TotalDiscount, "0.00")
            amountTopay = SubTotal - TotalDiscount
            txtTotal.Text = "P " & Format(amountTopay, "0.00")

            txtAmountTendered.Enabled = True
            btnPay.Enabled = True
        Else
            MessageBox.Show("No ticket number found.", "Invalid Input")
            txtTicketNumber.Clear()
        End If
    End Sub


    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        If String.IsNullOrEmpty(txtAmountTendered.Text) Then
            MsgBox("Payment can not be empty.", vbInformation, "Invalid payment")
            txtAmountTendered.Focus()
            Return
        End If

        Dim amountTendered As Double
        If Not Double.TryParse(txtAmountTendered.Text, amountTendered) Then
            MsgBox("Invalid payment amount.", vbInformation, "Invalid payment")
            txtAmountTendered.Focus()
            Return
        End If

        If amountTopay > amountTendered Then
            MsgBox("Insuficient payment.", vbInformation, "Invalid Payment")
            Return
        End If

        change = amountTendered - amountTopay
        txtChange.Text = "P " & Format(change, "0.00")

        txtAmountTendered.ReadOnly = True
        btnPay.Enabled = False
        btnPrintReceipt.Enabled = True
        btnValidate.Enabled = False

        HideVehicle()

        Try
            connect()
            Using commTrans As New OleDbCommand("Insert into tblTransactionHistory values(@TicketNumber, @ParkingLocation, @ParkingFloor, @Type, @PlateNumber, @TimeIn, @TimeOut, @HourDiff, @ParkingFee, @SubTotal, @TotalDiscount, @AmountToPay, @AmountTendered, @Change, @TransactionDate)", conn)
                commTrans.Parameters.AddWithValue("@TicketNumber", cmbMyField.Text)
                commTrans.Parameters.AddWithValue("@ParkingLocation", parkingLocation)
                commTrans.Parameters.AddWithValue("@ParkingFloor", parkingFloor)
                commTrans.Parameters.AddWithValue("@Type", Type)
                commTrans.Parameters.AddWithValue("@PlateNumber", plateNumberPlaceholder)
                commTrans.Parameters.AddWithValue("@TimeIn", TimeIn)
                commTrans.Parameters.AddWithValue("@TimeOut", Format(Now, "MM/dd/yy hh:mm tt"))
                commTrans.Parameters.AddWithValue("@HourDiff", hourDiff)
                commTrans.Parameters.AddWithValue("@ParkingFee", ParkingFee)
                commTrans.Parameters.AddWithValue("@SubTotal", SubTotal)
                commTrans.Parameters.AddWithValue("@TotalDiscount", TotalDiscount)
                commTrans.Parameters.AddWithValue("@AmountToPay", amountTopay)
                commTrans.Parameters.AddWithValue("@AmountTendered", amountTendered)
                commTrans.Parameters.AddWithValue("@Change", change)
                commTrans.Parameters.AddWithValue("@TransactionDate", Format(Now, "MM/dd/yy hh:mm tt"))
                commTrans.ExecuteNonQuery()
            End Using

            Using commDelete As New OleDbCommand("Delete from tblVehicleList where TicketNumber=@TicketNumber", conn)
                commDelete.Parameters.AddWithValue("@TicketNumber", cmbMyField.Text)
                commDelete.ExecuteNonQuery()
            End Using

            MsgBox("Payment success", vbInformation, "Payment success")
        Catch ex As Exception
            dbFailed()
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try

        populate()
    End Sub


    Sub loadDetails()
        Try
            connect()
            Dim queryOccupied As String = "SELECT COUNT(*) FROM tblVehicleList WHERE TicketNumber"
            Dim commandOccupied As New OleDb.OleDbCommand(queryOccupied, conn)
            Dim countOccupied As Integer = commandOccupied.ExecuteScalar()
            lblTOccupied.Text = countOccupied.ToString()
            lblTVacant.Text = 139 - countOccupied

            Dim query2WString As String = "SELECT COUNT(*) FROM tblVehicleList WHERE VehicleType LIKE '%2 Wheels%'"
            Dim command2 As New OleDb.OleDbCommand(query2WString, conn)
            count2Slots = command2.ExecuteScalar()
            lbl2Occupied.Text = count2Slots.ToString
            lbl2Vacant.Text = 42 - count2Slots


            Dim query4WString As String = "SELECT COUNT(*) FROM tblVehicleList WHERE VehicleType LIKE '%3/4 Wheels%'"
            Dim command4 As New OleDb.OleDbCommand(query4WString, conn)
            count4Slots = command4.ExecuteScalar()
            lbl4Occupied.Text = count4Slots.ToString
            lbl4Vacant.Text = 97 - count4Slots
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub VD_BeginPrint(sender As Object, e As PrintEventArgs) Handles VD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, 300)
        VD.DefaultPageSettings = pagesetup
    End Sub

    Private Sub VD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles VD.PrintPage
        Dim f5 As New Font("Helvetica", 5, FontStyle.Regular)
        Dim f5b As New Font("Helvetica", 5, FontStyle.Regular)


        Dim leftmargin As Integer = VD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = VD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = VD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat

        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center

        e.Graphics.DrawString("PARKINGS", f5b, Brushes.Black, centermargin, 10, center)
        e.Graphics.DrawString("Rizal Technology University - Pasig Campus", f5, Brushes.Black, centermargin, 20, center)
        e.Graphics.DrawString("M. Eusebio Avenue, Maybunga, San Miguel, Pasig City", f5, Brushes.Black, centermargin, 30, center)
        e.Graphics.DrawString("+63-9123456789 | customerservice@parkings.com", f5, Brushes.Black, centermargin, 40, center)

        e.Graphics.DrawString("--------------------------------------------------------------------", f5, Brushes.Black, centermargin, 55, center)


        e.Graphics.DrawString("Customer's Receipt", f5, Brushes.Black, centermargin, 70, center)

        e.Graphics.DrawString("Date: " + Format(Now, "MM/dd/yy"), f5, Brushes.Black, 20, 85)

        e.Graphics.DrawString("Vehicle Type: " + Type, f5, Brushes.Black, 20, 100)
        e.Graphics.DrawString("Entry Time: " + TimeIn, f5, Brushes.Black, 20, 110)
        e.Graphics.DrawString("Exit Time: " + Format(Now, "MM/dd/yy hh:mm tt"), f5, Brushes.Black, 20, 120)
        e.Graphics.DrawString("Duration: " + txtDuration.Text, f5, Brushes.Black, 20, 130)
        e.Graphics.DrawString("Ticket Number: " + cmbMyField.Text, f5, Brushes.Black, 20, 140)

        e.Graphics.DrawString("Base Rate: " + txtParkingFee.Text, f5, Brushes.Black, 20, 155)
        e.Graphics.DrawString("Additional fees per hour: P " + feesPerHours.ToString(), f5, Brushes.Black, 20, 165)
        e.Graphics.DrawString("Computed fees per hour (Duration x Fees per hour): P " + y.ToString, f5, Brushes.Black, 20, 175)
        e.Graphics.DrawString("Subtotal: " + txtSubTotal.Text, f5, Brushes.Black, 20, 185)
        e.Graphics.DrawString("Discount: " + txtDiscount.Text, f5, Brushes.Black, 20, 195)
        e.Graphics.DrawString("Total: " + txtTotal.Text, f5, Brushes.Black, 20, 205)
        e.Graphics.DrawString("Paid: " + "P " + txtAmountTendered.Text, f5, Brushes.Black, 20, 215)
        e.Graphics.DrawString("Change: " + txtChange.Text, f5, Brushes.Black, 20, 225)

        e.Graphics.DrawString("--------------------------------------------------------------------", f5, Brushes.Black, centermargin, 240, center)

        e.Graphics.DrawString("Thank you for using our parking lot!", f5, Brushes.Black, centermargin, 255, center)
        e.Graphics.DrawString("Come again!", f5, Brushes.Black, centermargin, 265, center)
        e.Graphics.DrawString("© 2022 - 2023 PARKINGS. All rights reserved.", New Font("Arial", 3, FontStyle.Regular), Brushes.Black, centermargin, 280, center)

    End Sub

    Private Sub btnPrintReceipt_Click(sender As Object, e As EventArgs) Handles btnPrintReceipt.Click

        VVD.Document = VD
        VVD.ShowDialog()

        btnNextExit.Enabled = True

    End Sub

    Private Sub btnNextExit_Click(sender As Object, e As EventArgs) Handles btnNextExit.Click
        MsgBox("Vehicle excited successfully. Ready to entertain next vehicle", vbInformation, "Exit Gate")

        cmbMyField.SelectedIndex = -1
        txtDiscount.Clear()
        txtParkingFee.Clear()
        txtDuration.Clear()
        txtComputed.Clear()
        txtSubTotal.Clear()
        txtDiscount.Clear()
        txtTotal.Clear()
        txtAmountTendered.Clear()
        txtChange.Clear()
        cbDiscount.SelectedIndex = -1

        txtAmountTendered.Enabled = False
        btnPrintReceipt.Enabled = False
        btnNextExit.Enabled = False
        btnValidate.Enabled = True
        txtAmountTendered.ReadOnly = False
    End Sub

    Private Sub txtPlateNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPlateNumber.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub
    Private Sub txtAmountTendered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountTendered.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn1stFloor_Click_1(sender As Object, e As EventArgs) Handles btn1stFloor.Click
        TabParkingView.SelectedTab = tab1stLevel
        btn1stFloor.BackColor = Color.FromArgb(224, 168, 93)
        btn2ndFloor.BackColor = Color.FromArgb(185, 116, 73)
        btn3rdFloor.BackColor = Color.FromArgb(185, 116, 73)
    End Sub

    Private Sub btn2ndFloor_Click_1(sender As Object, e As EventArgs) Handles btn2ndFloor.Click
        TabParkingView.SelectedTab = tab2ndLevel
        btn1stFloor.BackColor = Color.FromArgb(185, 116, 73)
        btn2ndFloor.BackColor = Color.FromArgb(224, 168, 93)
        btn3rdFloor.BackColor = Color.FromArgb(185, 116, 73)
    End Sub

    Private Sub btn3rdFloor_Click_1(sender As Object, e As EventArgs) Handles btn3rdFloor.Click
        TabParkingView.SelectedTab = tab3rdLevel
        btn1stFloor.BackColor = Color.FromArgb(185, 116, 73)
        btn2ndFloor.BackColor = Color.FromArgb(185, 116, 73)
        btn3rdFloor.BackColor = Color.FromArgb(224, 168, 93)
    End Sub

    Private Sub Panel2_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel2.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel2.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub listVehicle_Click(sender As Object, e As EventArgs) Handles listVehicle.Click
        populate()
    End Sub

    Sub HideVehicle()
        Select Case (parkingLocation)
            Case "1FA-01"
                vehicle1FA01.Visible = False
            Case "1FA-02"
                vehicle1FA02.Visible = False
            Case "1FA-03"
                vehicle1FA03.Visible = False
            Case "1FA-04"
                vehicle1FA04.Visible = False
            Case "1FA-05"
                vehicle1FA05.Visible = False
            Case "1FA-06"
                vehicle1FA06.Visible = False
            Case "1FA-07"
                vehicle1FA07.Visible = False
            Case "1FA-08"
                vehicle1FA08.Visible = False
            Case "1FA-09"
                vehicle1FA09.Visible = False
            Case "1FA-10"
                vehicle1FA10.Visible = False
            Case "1FB-01"
                vehicle1FB01.Visible = False
            Case "1FB-02"
                vehicle1FB02.Visible = False
            Case "1FB-03"
                vehicle1FB03.Visible = False
            Case "1FB-04"
                vehicle1FB04.Visible = False
            Case "1FB-05"
                vehicle1FB05.Visible = False
            Case "1FB-06"
                vehicle1FB06.Visible = False
            Case "1FB-07"
                vehicle1FB07.Visible = False
            Case "1FB-08"
                vehicle1FB08.Visible = False
            Case "1FB-09"
                vehicle1FB09.Visible = False
            Case "1FB-10"
                vehicle1FB10.Visible = False
            Case "1FB-11"
                vehicle1FB11.Visible = False
            Case "1FC-01"
                vehicle1FC01.Visible = False
            Case "1FC-02"
                vehicle1FC02.Visible = False
            Case "1FC-03"
                vehicle1FC03.Visible = False
            Case "1FC-04"
                vehicle1FC04.Visible = False
            Case "1FC-05"
                vehicle1FC05.Visible = False
            Case "1FC-06"
                vehicle1FC06.Visible = False
            Case "1FC-07"
                vehicle1FC07.Visible = False
            Case "1FC-08"
                vehicle1FC08.Visible = False
            Case "1FC-09"
                vehicle1FC09.Visible = False
            Case "1FC-10"
                vehicle1FC10.Visible = False
            Case "1FC-11"
                vehicle1FC11.Visible = False
            Case "1FD-01"
                vehicle1FD01.Visible = False
            Case "1FD-02"
                vehicle1FD02.Visible = False
            Case "1FD-03"
                vehicle1FD03.Visible = False
            Case "1FD-04"
                vehicle1FD04.Visible = False
            Case "1FD-05"
                vehicle1FD05.Visible = False
            Case "1FD-06"
                vehicle1FD06.Visible = False
            Case "1FD-07"
                vehicle1FD07.Visible = False
            Case "1FD-08"
                vehicle1FD08.Visible = False
            Case "1FD-09"
                vehicle1FD09.Visible = False
            Case "1FD-10"
                vehicle1FD10.Visible = False
            Case "1FD-11"
                vehicle1FD11.Visible = False
            Case "1FD-12"
                vehicle1FD12.Visible = False
            Case "2FA-01"
                vehicle2FA01.Visible = False
            Case "2FA-02"
                vehicle2FA02.Visible = False
            Case "2FA-03"
                vehicle2FA03.Visible = False
            Case "2FA-04"
                vehicle2FA04.Visible = False
            Case "2FA-05"
                vehicle2FA05.Visible = False
            Case "2FA-06"
                vehicle2FA06.Visible = False
            Case "2FA-07"
                vehicle2FA07.Visible = False
            Case "2FA-08"
                vehicle2FA08.Visible = False
            Case "2FA-09"
                vehicle2FA09.Visible = False
            Case "2FA-10"
                vehicle2FA10.Visible = False
            Case "2FA-11"
                vehicle2FA11.Visible = False
            Case "2FA-12"
                vehicle2FA12.Visible = False
            Case "2FA-13"
                vehicle2FA03.Visible = False
            Case "2FA-14"
                vehicle2FA14.Visible = False
            Case "2FA-15"
                vehicle2FA15.Visible = False
            Case "2FA-16"
                vehicle2FA16.Visible = False
            Case "2FA-17"
                vehicle2FA17.Visible = False
            Case "2FA-18"
                vehicle2FA18.Visible = False
            Case "2FB-01"
                vehicle2FB01.Visible = False
            Case "2FB-02"
                vehicle2FB02.Visible = False
            Case "2FB-03"
                vehicle2FB03.Visible = False
            Case "2FB-04"
                vehicle2FB04.Visible = False
            Case "2FB-05"
                vehicle2FB05.Visible = False
            Case "2FB-06"
                vehicle2FB06.Visible = False
            Case "2FB-07"
                vehicle2FB07.Visible = False
            Case "2FB-08"
                vehicle2FB08.Visible = False
            Case "2FB-09"
                vehicle2FB09.Visible = False
            Case "2FB-10"
                vehicle2FB10.Visible = False
            Case "2FB-11"
                vehicle2FB11.Visible = False
            Case "2FC-01"
                vehicle2FC01.Visible = False
            Case "2FC-02"
                vehicle2FC02.Visible = False
            Case "2FC-03"
                vehicle2FC03.Visible = False
            Case "2FC-04"
                vehicle2FC04.Visible = False
            Case "2FC-05"
                vehicle2FC05.Visible = False
            Case "2FC-06"
                vehicle2FC06.Visible = False
            Case "2FC-07"
                vehicle2FC07.Visible = False
            Case "2FC-08"
                vehicle2FC08.Visible = False
            Case "2FC-09"
                vehicle2FC09.Visible = False
            Case "2FC-10"
                vehicle2FC10.Visible = False
            Case "2FC-11"
                vehicle2FC11.Visible = False
            Case "2FD-01"
                vehicle2FD01.Visible = False
            Case "2FD-02"
                vehicle2FD02.Visible = False
            Case "2FD-03"
                vehicle2FD03.Visible = False
            Case "2FD-04"
                vehicle2FD04.Visible = False
            Case "2FD-05"
                vehicle2FD05.Visible = False
            Case "2FD-06"
                vehicle2FD06.Visible = False
            Case "2FD-07"
                vehicle2FD07.Visible = False
            Case "3FA-01"
                vehicle3FA01.Visible = False
            Case "3FA-02"
                vehicle3FA02.Visible = False
            Case "3FA-03"
                vehicle3FA03.Visible = False
            Case "3FA-04"
                vehicle3FA04.Visible = False
            Case "3FA-05"
                vehicle3FA05.Visible = False
            Case "3FA-06"
                vehicle3FA06.Visible = False
            Case "3FA-07"
                vehicle3FA07.Visible = False
            Case "3FA-08"
                vehicle3FA08.Visible = False
            Case "3FA-09"
                vehicle3FA09.Visible = False
            Case "3FA-10"
                vehicle3FA10.Visible = False
            Case "3FA-11"
                vehicle3FA11.Visible = False
            Case "3FA-12"
                vehicle3FA02.Visible = False
            Case "3FA-13"
                vehicle3FA13.Visible = False
            Case "3FA-14"
                vehicle3FA14.Visible = False
            Case "3FB-01"
                vehicle3FB01.Visible = False
            Case "3FB-02"
                vehicle3FB02.Visible = False
            Case "3FB-03"
                vehicle3FB03.Visible = False
            Case "3FB-04"
                vehicle3FB04.Visible = False
            Case "3FB-05"
                vehicle3FB05.Visible = False
            Case "3FB-06"
                vehicle3FB06.Visible = False
            Case "3FB-07"
                vehicle3FB07.Visible = False
            Case "3FB-08"
                vehicle3FB08.Visible = False
            Case "3FB-09"
                vehicle3FB09.Visible = False
            Case "3FB-10"
                vehicle3FB10.Visible = False
            Case "3FB-11"
                vehicle3FB11.Visible = False
            Case "3FC-01"
                vehicle3FC01.Visible = False
            Case "3FC-02"
                vehicle3FC02.Visible = False
            Case "3FC-03"
                vehicle3FC03.Visible = False
            Case "3FC-04"
                vehicle3FC04.Visible = False
            Case "3FC-05"
                vehicle3FC05.Visible = False
            Case "3FC-06"
                vehicle3FC06.Visible = False
            Case "3FC-07"
                vehicle3FC07.Visible = False
            Case "3FC-08"
                vehicle3FC08.Visible = False
            Case "3FC-09"
                vehicle3FC09.Visible = False
            Case "3FC-10"
                vehicle3FC10.Visible = False
            Case "3FC-11"
                vehicle3FC11.Visible = False
            Case "3FD-01"
                vehicle3FD01.Visible = False
            Case "3FD-02"
                vehicle3FD02.Visible = False
            Case "3FD-03"
                vehicle3FD03.Visible = False
            Case "3FD-04"
                vehicle3FD04.Visible = False
            Case "3FD-05"
                vehicle3FD05.Visible = False
            Case "3FD-06"
                vehicle3FD06.Visible = False
            Case "3FD-07"
                vehicle3FD07.Visible = False
            Case "3FD-08"
                vehicle3FD08.Visible = False
            Case "3FD-09"
                vehicle3FD09.Visible = False
            Case "3FD-10"
                vehicle3FD10.Visible = False
            Case "3FD-11"
                vehicle3FD11.Visible = False
            Case "3FD-12"
                vehicle3FD12.Visible = False
        End Select
    End Sub

    Sub GetAvailability()
        Try
            Dim query As String = "SELECT ParkingLocation FROM tblVehicleList"
            Dim command As New OleDb.OleDbCommand(query, conn)

            Dim reader As OleDb.OleDbDataReader
            connect()
            reader = command.ExecuteReader()
            While reader.Read()
                Dim value As String = reader("ParkingLocation").ToString()
                Select Case (value)
                    Case "1FA-01"
                        vehicle1FA01.Visible = True
                    Case "1FA-02"
                        vehicle1FA02.Visible = True
                    Case "1FA-03"
                        vehicle1FA03.Visible = True
                    Case "1FA-04"
                        vehicle1FA04.Visible = True
                    Case "1FA-05"
                        vehicle1FA05.Visible = True
                    Case "1FA-06"
                        vehicle1FA06.Visible = True
                    Case "1FA-07"
                        vehicle1FA07.Visible = True
                    Case "1FA-08"
                        vehicle1FA08.Visible = True
                    Case "1FA-09"
                        vehicle1FA09.Visible = True
                    Case "1FA-10"
                        vehicle1FA10.Visible = True
                    Case "1FB-01"
                        vehicle1FB01.Visible = True
                    Case "1FB-02"
                        vehicle1FB02.Visible = True
                    Case "1FB-03"
                        vehicle1FB03.Visible = True
                    Case "1FB-04"
                        vehicle1FB04.Visible = True
                    Case "1FB-05"
                        vehicle1FB05.Visible = True
                    Case "1FB-06"
                        vehicle1FB06.Visible = True
                    Case "1FB-07"
                        vehicle1FB07.Visible = True
                    Case "1FB-08"
                        vehicle1FB08.Visible = True
                    Case "1FB-09"
                        vehicle1FB09.Visible = True
                    Case "1FB-10"
                        vehicle1FB10.Visible = True
                    Case "1FB-11"
                        vehicle1FB11.Visible = True
                    Case "1FC-01"
                        vehicle1FC01.Visible = True
                    Case "1FC-02"
                        vehicle1FC02.Visible = True
                    Case "1FC-03"
                        vehicle1FC03.Visible = True
                    Case "1FC-04"
                        vehicle1FC04.Visible = True
                    Case "1FC-05"
                        vehicle1FC05.Visible = True
                    Case "1FC-06"
                        vehicle1FC06.Visible = True
                    Case "1FC-07"
                        vehicle1FC07.Visible = True
                    Case "1FC-08"
                        vehicle1FC08.Visible = True
                    Case "1FC-09"
                        vehicle1FC09.Visible = True
                    Case "1FC-10"
                        vehicle1FC10.Visible = True
                    Case "1FC-11"
                        vehicle1FC11.Visible = True
                    Case "1FD-01"
                        vehicle1FD01.Visible = True
                    Case "1FD-02"
                        vehicle1FD02.Visible = True
                    Case "1FD-03"
                        vehicle1FD03.Visible = True
                    Case "1FD-04"
                        vehicle1FD04.Visible = True
                    Case "1FD-05"
                        vehicle1FD05.Visible = True
                    Case "1FD-06"
                        vehicle1FD06.Visible = True
                    Case "1FD-07"
                        vehicle1FD07.Visible = True
                    Case "1FD-08"
                        vehicle1FD08.Visible = True
                    Case "1FD-09"
                        vehicle1FD09.Visible = True
                    Case "1FD-10"
                        vehicle1FD10.Visible = True
                    Case "1FD-11"
                        vehicle1FD11.Visible = True
                    Case "1FD-12"
                        vehicle1FD12.Visible = True
                    Case "2FA-01"
                        vehicle2FA01.Visible = True
                    Case "2FA-02"
                        vehicle2FA02.Visible = True
                    Case "2FA-03"
                        vehicle2FA03.Visible = True
                    Case "2FA-04"
                        vehicle2FA04.Visible = True
                    Case "2FA-05"
                        vehicle2FA05.Visible = True
                    Case "2FA-06"
                        vehicle2FA06.Visible = True
                    Case "2FA-07"
                        vehicle2FA07.Visible = True
                    Case "2FA-08"
                        vehicle2FA08.Visible = True
                    Case "2FA-09"
                        vehicle2FA09.Visible = True
                    Case "2FA-10"
                        vehicle2FA10.Visible = True
                    Case "2FA-11"
                        vehicle2FA11.Visible = True
                    Case "2FA-12"
                        vehicle2FA12.Visible = True
                    Case "2FA-13"
                        vehicle2FA13.Visible = True
                    Case "2FA-14"
                        vehicle2FA14.Visible = True
                    Case "2FA-15"
                        vehicle2FA15.Visible = True
                    Case "2FA-16"
                        vehicle2FA16.Visible = True
                    Case "2FA-17"
                        vehicle2FA17.Visible = True
                    Case "2FA-18"
                        vehicle2FA18.Visible = True
                    Case "2FB-01"
                        vehicle2FB01.Visible = True
                    Case "2FB-02"
                        vehicle2FB02.Visible = True
                    Case "2FB-03"
                        vehicle2FB03.Visible = True
                    Case "2FB-04"
                        vehicle2FB04.Visible = True
                    Case "2FB-05"
                        vehicle2FB05.Visible = True
                    Case "2FB-06"
                        vehicle2FB06.Visible = True
                    Case "2FB-07"
                        vehicle2FB07.Visible = True
                    Case "2FB-08"
                        vehicle2FB08.Visible = True
                    Case "2FB-09"
                        vehicle2FB09.Visible = True
                    Case "2FB-10"
                        vehicle2FB10.Visible = True
                    Case "2FB-11"
                        vehicle2FB11.Visible = True
                    Case "2FC-01"
                        vehicle2FC01.Visible = True
                    Case "2FC-02"
                        vehicle2FC02.Visible = True
                    Case "2FC-03"
                        vehicle2FC03.Visible = True
                    Case "2FC-04"
                        vehicle2FC04.Visible = True
                    Case "2FC-05"
                        vehicle2FC05.Visible = True
                    Case "2FC-06"
                        vehicle2FC06.Visible = True
                    Case "2FC-07"
                        vehicle2FC07.Visible = True
                    Case "2FC-08"
                        vehicle2FC08.Visible = True
                    Case "2FC-09"
                        vehicle2FC09.Visible = True
                    Case "2FC-10"
                        vehicle2FC10.Visible = True
                    Case "2FC-11"
                        vehicle2FC11.Visible = True
                    Case "2FD-01"
                        vehicle2FD01.Visible = True
                    Case "2FD-02"
                        vehicle2FD02.Visible = True
                    Case "2FD-03"
                        vehicle2FD03.Visible = True
                    Case "2FD-04"
                        vehicle2FD04.Visible = True
                    Case "2FD-05"
                        vehicle2FD05.Visible = True
                    Case "2FD-06"
                        vehicle2FD06.Visible = True
                    Case "2FD-07"
                        vehicle2FD07.Visible = True
                    Case "3FA-01"
                        vehicle3FA01.Visible = True
                    Case "3FA-02"
                        vehicle3FA02.Visible = True
                    Case "3FA-03"
                        vehicle3FA03.Visible = True
                    Case "3FA-04"
                        vehicle3FA04.Visible = True
                    Case "3FA-05"
                        vehicle3FA05.Visible = True
                    Case "3FA-06"
                        vehicle3FA06.Visible = True
                    Case "3FA-07"
                        vehicle3FA07.Visible = True
                    Case "3FA-08"
                        vehicle3FA08.Visible = True
                    Case "3FA-09"
                        vehicle3FA09.Visible = True
                    Case "3FA-10"
                        vehicle3FA10.Visible = True
                    Case "3FA-11"
                        vehicle3FA11.Visible = True
                    Case "3FA-12"
                        vehicle3FA12.Visible = True
                    Case "3FA-13"
                        vehicle3FA13.Visible = True
                    Case "3FA-14"
                        vehicle3FA14.Visible = True
                    Case "3FB-01"
                        vehicle3FB01.Visible = True
                    Case "3FB-02"
                        vehicle3FB02.Visible = True
                    Case "3FB-03"
                        vehicle3FB03.Visible = True
                    Case "3FB-04"
                        vehicle3FB04.Visible = True
                    Case "3FB-05"
                        vehicle3FB05.Visible = True
                    Case "3FB-06"
                        vehicle3FB06.Visible = True
                    Case "3FB-07"
                        vehicle3FB07.Visible = True
                    Case "3FB-08"
                        vehicle3FB08.Visible = True
                    Case "3FB-09"
                        vehicle3FB09.Visible = True
                    Case "3FB-10"
                        vehicle3FB10.Visible = True
                    Case "3FB-11"
                        vehicle3FB11.Visible = True
                    Case "3FC-01"
                        vehicle3FC01.Visible = True
                    Case "3FC-02"
                        vehicle3FC02.Visible = True
                    Case "3FC-03"
                        vehicle3FC03.Visible = True
                    Case "3FC-04"
                        vehicle3FC04.Visible = True
                    Case "3FC-05"
                        vehicle3FC05.Visible = True
                    Case "3FC-06"
                        vehicle3FC06.Visible = True
                    Case "3FC-07"
                        vehicle3FC07.Visible = True
                    Case "3FC-08"
                        vehicle3FC08.Visible = True
                    Case "3FC-09"
                        vehicle3FC09.Visible = True
                    Case "3FC-10"
                        vehicle3FC10.Visible = True
                    Case "3FC-11"
                        vehicle3FC11.Visible = True
                    Case "3FD-01"
                        vehicle3FD01.Visible = True
                    Case "3FD-02"
                        vehicle3FD02.Visible = True
                    Case "3FD-03"
                        vehicle3FD03.Visible = True
                    Case "3FD-04"
                        vehicle3FD04.Visible = True
                    Case "3FD-05"
                        vehicle3FD05.Visible = True
                    Case "3FD-06"
                        vehicle3FD06.Visible = True
                    Case "3FD-07"
                        vehicle3FD07.Visible = True
                    Case "3FD-08"
                        vehicle3FD08.Visible = True
                    Case "3FD-09"
                        vehicle3FD09.Visible = True
                    Case "3FD-10"
                        vehicle3FD10.Visible = True
                    Case "3FD-11"
                        vehicle3FD11.Visible = True
                    Case "3FD-12"
                        vehicle3FD12.Visible = True
                End Select
            End While
            reader.Close()
        Catch ex As Exception
            dbFailed()
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub PopulateComboBox()
        Try
            connect()
            Dim sql As String = "SELECT TicketNumber FROM tblVehicleList"
            Dim cmd As New OleDbCommand(sql, conn)
            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            cmbMyField.Items.Clear()
            While reader.Read()
                cmbMyField.Items.Add(reader("TicketNumber").ToString())
            End While
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub cmbMyField_Click_1(sender As Object, e As EventArgs) Handles cmbMyField.Click
        PopulateComboBox()
    End Sub
End Class