Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Drawing.Printing
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ManagerForm
    Dim WithEvents PrintDocument1 As New PrintDocument
    Dim PrintPreviewDialog1 As New PrintPreviewDialog
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        LogIn_Form.Show()
    End Sub

    Private Sub btnUPDATE2Wheels_Click_1(sender As Object, e As EventArgs) Handles btnUPDATE2Wheels.Click
        If txtEDIT2Wheels.Text = Nothing Then
            MsgBox("Input value is invalid.", vbInformation, "Invalid input")
        Else
            vehicle2Wheels = Double.Parse(txtEDIT2Wheels.Text)
            MsgBox("Fee updated successfully.", vbInformation, "SUCCESS!")
        End If
    End Sub

    Private Sub btnUPDATE4Wheels_Click_1(sender As Object, e As EventArgs) Handles btnUPDATE4Wheels.Click
        If txtEDIT4Wheels.Text = Nothing Then
            MsgBox("Input value is invalid.", vbInformation, "Invalid input")
        Else
            vehicle4Wheels = Double.Parse(txtEDIT4Wheels.Text)
            MsgBox("Fee updated successfully.", vbInformation, "SUCCESS!")
        End If
    End Sub

    Private Sub btnUPDATERate_Click(sender As Object, e As EventArgs) Handles btnUPDATERate.Click
        If txtRatePerHour.Text = Nothing Then
            MsgBox("Input value is invalid.", vbInformation, "Invalid input")
        Else
            feesPerHours = Double.Parse(txtRatePerHour.Text)
            MsgBox("Fee updated successfully.", vbInformation, "SUCCESS!")
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnFreeHours.Click
        If txtFreeHours.Text = Nothing Then
            MsgBox("Input value is invalid.", vbInformation, "Invalid input")
        Else
            freeHours = Double.Parse(txtFreeHours.Text)
            MsgBox("Free hours has been updated successfully.", vbInformation, "SUCCESS!")
        End If
    End Sub

    Private Sub btnUPDATEStudent_Click_1(sender As Object, e As EventArgs) Handles btnUPDATEStudent.Click
        If txtEDITStudent.Text = Nothing Then
            MsgBox("Input value is invalid.", vbInformation, "Invalid input")
        ElseIf Double.Parse(txtEDITStudent.Text) > 100 Then
            MsgBox("Enter a valid number in percent.", vbInformation, "Invalid input")
        Else
            studentDisc = Double.Parse(txtEDITStudent.Text) / 100
            Dim mainForm As New MainForm()
            mainForm.cbDiscount.Items.Clear()
            mainForm.cbDiscount.Items.AddRange(New Object() {"Regular (0.00%)", "Student (" & FormatPercent(studentDisc) & ")", "PWD and Senior Citizen (" & FormatPercent(pwdNseniorDisc) & ")"})
            MsgBox("Discount updated successfully.", vbInformation, "SUCCESS!")
        End If
    End Sub

    Private Sub btnUPDATEPWDnSC_Click_1(sender As Object, e As EventArgs) Handles btnUPDATEPWDnSC.Click
        If txtEDITPWDnSC.Text = Nothing Then
            MsgBox("Input value is invalid.", vbInformation, "Invalid input")
        ElseIf Double.Parse(txtEDITPWDnSC.Text) > 100 Then
            MsgBox("Enter a valid number in percent.", vbInformation, "Invalid input")
        Else
            pwdNseniorDisc = Double.Parse(txtEDITPWDnSC.Text) / 100
            Dim mainForm As New MainForm()
            mainForm.cbDiscount.Items.Clear()
            mainForm.cbDiscount.Items.AddRange(New Object() {"Regular (0.00%)", "Student (" & FormatPercent(studentDisc) & ")", "PWD and Senior Citizen (" & FormatPercent(pwdNseniorDisc) & ")"})
            MsgBox("Discount updated successfully.", vbInformation, "SUCCESS!")
        End If
    End Sub

    Private Sub ManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loginSuccess()
        Try
            Dim cmd As New OleDbCommand("Select TicketNumber from tblTransactionHistory", conn)
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataSet
            da.Fill(dt)
            Dim coloumn1 As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To dt.Tables(0).Rows.Count - 1
                coloumn1.Add(dt.Tables(0).Rows(i)("TicketNumber").ToString())

            Next
            txtSearchTicketNumber.AutoCompleteSource = AutoCompleteSource.CustomSource
            txtSearchTicketNumber.AutoCompleteCustomSource = coloumn1
            txtSearchTicketNumber.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

        lblUser.Text = FullName

        txtEDIT2Wheels.Text = vehicle2Wheels
        txtEDIT4Wheels.Text = vehicle4Wheels
        txtEDITStudent.Text = studentDisc * 100
        txtEDITPWDnSC.Text = pwdNseniorDisc * 100
        txtRatePerHour.Text = feesPerHours
        txtFreeHours.Text = freeHours

        loadDetailss()

    End Sub

    Private Sub txtEDIT2Wheels_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEDIT2Wheels.KeyPress, txtEDIT4Wheels.KeyPress, txtEDITStudent.KeyPress, txtEDITPWDnSC.KeyPress, txtRatePerHour.KeyPress, txtFreeHours.KeyPress
        If Not IsNumeric(e.KeyChar) And Not e.KeyChar = ChrW(Keys.Back) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Panel8_Scroll(sender As Object, e As ScrollEventArgs) Handles Panel8.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            Panel8.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            connect()
            Dim cmd As New OleDbCommand("Select * from tblTransactionHistory where TicketNumber=@TicketNumber", conn)
            cmd.Parameters.AddWithValue("TicketNumber", txtSearchTicketNumber.Text.Trim)
            Dim myreader As OleDbDataReader
            myreader = cmd.ExecuteReader
            If myreader.Read() Then
                txtVehicleType.Text = myreader("VehicleType")
                txtPlateNumber.Text = myreader("PlateNumber")
                txtParkingLocation.Text = myreader("ParkingLocation")
                txtParkingFloor.Text = myreader("Floor")
                txtTimeIn.Text = myreader("TimeIn")
                txtTimeOut.Text = myreader("TimeOut")
                txtParkingDuration.Text = myreader("Duration") & " Hour/s"
                txtSubTotal.Text = "P " & myreader("SubTotal")
                txtDiscount.Text = "P " & myreader("Discount")
                txtAmountToPay.Text = "P " & myreader("Total")
                txtAmountPaid.Text = "P " & myreader("AmountTendered")
                txtChange.Text = "P " & myreader("Change")
                txtDateofTransaction.Text = myreader("TimeStamp")
            Else
                MessageBox.Show("No ticket number found.", "Invalid Input")
                txtSearchTicketNumber.Clear()
                txtPlateNumber.Clear()
                txtVehicleType.Clear()
                txtParkingLocation.Clear()
                txtParkingFloor.Clear()
                txtTimeIn.Clear()
                txtTimeOut.Clear()
                txtParkingDuration.Clear()
                txtSubTotal.Clear()
                txtDiscount.Clear()
                txtAmountToPay.Clear()
                txtAmountPaid.Clear()
                txtChange.Clear()
                txtDateofTransaction.Clear()
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub txtSearchTicketNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSearchTicketNumber.TextChanged
        txtPlateNumber.Clear()
        txtVehicleType.Clear()
        txtParkingLocation.Clear()
        txtParkingFloor.Clear()
        txtTimeIn.Clear()
        txtTimeOut.Clear()
        txtParkingDuration.Clear()
        txtSubTotal.Clear()
        txtDiscount.Clear()
        txtAmountToPay.Clear()
        txtAmountPaid.Clear()
        txtChange.Clear()
        txtDateofTransaction.Clear()
    End Sub

    Private Sub btnPrintquery_Click(sender As Object, e As EventArgs) Handles btnPrintquery.Click
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PrintDocument1.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 800, 700)
        PrintDocument1.DefaultPageSettings = pagesetup
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontArial15 As New Font("Arial", 15, FontStyle.Regular)
        Dim fontArial15b As New Font("Arial", 15, FontStyle.Bold)
        e.Graphics.DrawString("PARKINGS", fontArial15b, Brushes.Black, New Point(345, 20))
        e.Graphics.DrawString("Rizal Technology University - Pasig Campus", fontArial15, Brushes.Black, New Point(245, 50))
        e.Graphics.DrawString("M. Eusebio Avenue, Maybunga, San Miguel, Pasig City", fontArial15, Brushes.Black, New Point(180, 75))
        e.Graphics.DrawString("+63 9123456789 | parkings.customerservice@parkings.com", fontArial15, Brushes.Black, New Point(160, 100))

        e.Graphics.DrawString("Vehicle Information", fontArial15b, Brushes.Black, New Point(310, 160))

        e.Graphics.DrawString("Ticket Number: " + txtSearchTicketNumber.Text, fontArial15, Brushes.Black, New Point(30, 200))
        e.Graphics.DrawString("Reference Number: ", fontArial15, Brushes.Black, New Point(30, 230))
        e.Graphics.DrawString("Plate Number: " + txtPlateNumber.Text, fontArial15, Brushes.Black, New Point(30, 260))
        e.Graphics.DrawString("Vehicle Type: " + txtVehicleType.Text, fontArial15, Brushes.Black, New Point(30, 290))

        e.Graphics.DrawString("Parking Floor: " + txtParkingFloor.Text, fontArial15, Brushes.Black, New Point(30, 330))
        e.Graphics.DrawString("Parking Location: " + txtParkingLocation.Text, fontArial15, Brushes.Black, New Point(30, 360))
        e.Graphics.DrawString("Time-In: " + txtTimeIn.Text, fontArial15, Brushes.Black, New Point(30, 390))
        e.Graphics.DrawString("Time-Out: " + txtTimeOut.Text, fontArial15, Brushes.Black, New Point(330, 390))
        e.Graphics.DrawString("Duration: " + txtParkingDuration.Text, fontArial15, Brushes.Black, New Point(30, 420))

        e.Graphics.DrawString("Date of Transaction: " + txtDateofTransaction.Text, fontArial15, Brushes.Black, New Point(30, 460))
        e.Graphics.DrawString("Subtotal: " + txtSubTotal.Text, fontArial15, Brushes.Black, New Point(30, 490))
        e.Graphics.DrawString("Discount: " + txtDiscount.Text, fontArial15, Brushes.Black, New Point(30, 520))

        e.Graphics.DrawString("Amount to Pay: " + txtAmountToPay.Text, fontArial15, Brushes.Black, New Point(30, 560))
        e.Graphics.DrawString("Amount Paid: " + txtAmountPaid.Text, fontArial15, Brushes.Black, New Point(30, 590))
        e.Graphics.DrawString("Change: " + txtChange.Text, fontArial15, Brushes.Black, New Point(30, 620))
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        loadDetailss()
    End Sub

    Public Sub loadDetailss()
        Try
            connect()
            Dim query2WString As String = "SELECT COUNT(*) FROM tblParkingActivity WHERE VehicleType LIKE '%2 Wheels%'"
            Dim command2 As New OleDb.OleDbCommand(query2WString, conn)
            count2 = command2.ExecuteScalar()
            txtTotal2Wheels.Text = count2.ToString()

            Dim query4WString As String = "SELECT COUNT(*) FROM tblParkingActivity WHERE VehicleType LIKE '%3/4 Wheels%'"
            Dim command4 As New OleDb.OleDbCommand(query4WString, conn)
            count4 = command4.ExecuteScalar()
            txtTotal4Wheels.Text = count4.ToString()

            Dim queryString As String = "SELECT COUNT(*) FROM tblParkingActivity WHERE VehicleType"
            Dim command As New OleDb.OleDbCommand(queryString, conn)
            Dim count As Integer = command.ExecuteScalar()
            txtTotalWheels.Text = count.ToString()

            Dim cmd As New OleDbCommand("SELECT SUM(Total) FROM tblTransactionHistory", conn)
            Dim sum As Object = cmd.ExecuteScalar()
            Dim totalEarnings As Double
            If Not IsDBNull(sum) Then
                totalEarnings = sum.ToString()
            End If
            txtTotalRevenue.Text = "P" & Format(totalEarnings, "0.00")

            Dim queryOccupied As String = "SELECT COUNT(*) FROM tblVehicleList WHERE TicketNumber"
            Dim commandOccupied As New OleDb.OleDbCommand(queryOccupied, conn)
            Dim countOccupied As Integer = commandOccupied.ExecuteScalar()
            txtOccupied.Text = countOccupied.ToString()
            txtVacant.Text = 139 - countOccupied
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub
End Class