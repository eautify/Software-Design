Imports System.ComponentModel.Design
Imports System.Data.OleDb
Imports System.Text
Imports System.Threading
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class AdminForm
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim commList As OleDbCommand

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
        LogIn_Form.Show()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If txtUsernameCreate.Text = "" Or dtpBday.Text = "" Or txtFirstName.Text = "" Or txtLastName.Text = "" Then
            MessageBox.Show("Username and password can not be empty.", "Create Account Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cbAccountType.Text = "Employee" Then
                Try
                    da = New OleDbDataAdapter("Select * from employeeLogin where USERNAME='" & txtUsernameCreate.Text & "'", conn)
                    dset = New DataSet
                    da.Fill(dset, "employeeLogin")

                    If dset.Tables("employeeLogin").Rows.Count > 0 Then
                        MessageBox.Show("Username already taken.", "Create Account Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        connect()
                        commList = New OleDbCommand
                        commList.Connection = conn
                        commList.CommandText = "Insert into employeeLogin values('" & txtUsernameCreate.Text & "','" & tempPass & "', '" & dtpBday.Text & "','" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & "Active" & "')"
                        commList.ExecuteNonQuery()

                        conn.Close()

                        MessageBox.Show("Employee account created successfully." & vbCrLf & vbCrLf & "Username: " & txtUsernameCreate.Text & vbCrLf & "Password: " & tempPass, "Account created successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsernameCreate.Clear()
                    End If
                Catch ex As Exception
                    dbFailed()
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                Try
                    da = New OleDbDataAdapter("Select * from managerLogin where USERNAME='" & txtUsernameCreate.Text & "'", conn)
                    dset = New DataSet
                    da.Fill(dset, "managerLogin")

                    If dset.Tables("managerLogin").Rows.Count > 0 Then
                        MessageBox.Show("Username already taken.", "Create Account Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        connect()

                        commList = New OleDbCommand
                        commList.Connection = conn
                        commList.CommandText = "Insert into managerLogin values('" & txtUsernameCreate.Text & "','" & tempPass & "', '" & dtpBday.Text & "','" & txtFirstName.Text & "', '" & txtLastName.Text & "', '" & "Active" & "')"
                        commList.ExecuteNonQuery()

                        conn.Close()

                        MessageBox.Show("Manager account created successfully." & vbCrLf & vbCrLf & "Username: " & txtUsernameCreate.Text & vbCrLf & "Password: " & tempPass, "Account created successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsernameCreate.Clear()
                        txtFirstNameReset.Clear()
                        txtLastNameReset.Clear()
                    End If
                Catch ex As Exception
                    dbFailed()
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtUsernameCreate.Clear()
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click
        If txtUsernameReset.Text = Nothing Then
            MessageBox.Show("Information can not be incomplete!", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If MessageBox.Show("Confirm password reset?", "Reset Password", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
                If cbAccountTypeReset.SelectedIndex = 0 Then
                    Try
                        da = New OleDbDataAdapter("Select * from employeeLogin where USERNAME='" & txtUsernameReset.Text & "' AND FirstName= '" & txtFirstNameReset.Text & "' AND LastName='" & txtLastNameReset.Text & "' AND BDAY='" & dtpBdayReset.Text & "'", conn)
                        dset = New DataSet
                        da.Fill(dset, "employeeLogin")

                        If dset.Tables("employeeLogin").Rows.Count = 1 Then
                            Dim sql As String = "UPDATE employeeLogin SET [PASSWORD]=@PASSWORD WHERE [USERNAME]=@USERNAME"

                            Dim cmd As New OleDbCommand(sql, conn)
                            cmd.Parameters.Add("@PASSWORD", OleDbType.VarChar).Value = "tempPass123!"
                            cmd.Parameters.Add("@USERNAME", OleDbType.VarChar).Value = txtUsernameReset.Text

                            connect()
                            cmd.ExecuteNonQuery()
                            updateSuccessReset()

                            Dim cmdRemove As New OleDbCommand("Delete from passwordRequest where Username=@Username", conn)
                            cmdRemove.Parameters.Add("@Username", OleDbType.VarChar).Value = ListBoxRequest.GetItemText(ListBoxRequest.SelectedValue)
                            cmdRemove.ExecuteNonQuery()
                            loadData()

                        Else
                            noRecords()
                        End If
                    Catch ex As Exception
                        dbFailed()
                        MessageBox.Show("An error occurred: " & ex.Message)
                    Finally
                        conn.Close()
                        txtUsernameReset.Clear()
                        cbAccountTypeReset.SelectedIndex = 0
                    End Try
                Else
                    Try
                        da = New OleDbDataAdapter("Select * from managerLogin where USERNAME='" & txtUsernameReset.Text & "' AND FirstName= '" & txtFirstNameReset.Text & "' AND LastName='" & txtLastNameReset.Text & "' AND BDAY='" & dtpBdayReset.Text & "'", conn)
                        dset = New DataSet
                        da.Fill(dset, "managerLogin")

                        If dset.Tables("managerLogin").Rows.Count = 1 Then
                            Dim sql As String = "UPDATE managerLogin SET [PASSWORD]=@PASSWORD WHERE [USERNAME]=@USERNAME"

                            Dim cmd As New OleDbCommand(sql, conn)
                            cmd.Parameters.Add("@PASSWORD", OleDbType.VarChar).Value = "tempPass123!"
                            cmd.Parameters.Add("@USERNAME", OleDbType.VarChar).Value = txtUsernameReset.Text

                            connect()
                            cmd.ExecuteNonQuery()
                            updateSuccessReset()

                            Dim cmdRemove As New OleDbCommand("Delete from passwordRequest where Username=@Username", conn)
                            cmdRemove.Parameters.Add("@Username", OleDbType.VarChar).Value = ListBoxRequest.GetItemText(ListBoxRequest.SelectedValue)
                            cmdRemove.ExecuteNonQuery()
                            loadData()
                        Else
                            noRecords()
                        End If
                    Catch ex As Exception
                        dbFailed()
                        MessageBox.Show("An error occurred: " & ex.Message)
                    Finally
                        conn.Close()
                        txtUsernameReset.Clear()
                        txtFirstNameReset.Clear()
                        txtLastNameReset.Clear()
                        cbAccountTypeReset.SelectedIndex = 0
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If InputBox("To confirm the deletion of the account, please provide the password for the administrator account.", "Delete Account") = "Admiiin123!" Then
            If cbAccountTypeDelete.SelectedIndex = 0 Then
                Try
                    da = New OleDbDataAdapter("Select * from employeeLogin where Status='" & "Active" & "' and USERNAME='" & txtUsernameDelete.Text & "' and BDAY='" & dtpBDAYDelete.Text & "'", conn)
                    dset = New DataSet
                    da.Fill(dset, "employeeLogin")
                    If dset.Tables("employeeLogin").Rows.Count = 1 Then
                        connect()
                        Dim sql As String = "UPDATE employeeLogin SET [Status]=@Status WHERE [USERNAME]=@USERNAME"
                        Dim cmd As New OleDbCommand(sql, conn)
                        cmd.Parameters.AddWithValue("@Status", "Inactive")
                        cmd.Parameters.AddWithValue("@USERNAME", txtUsernameReset.Text)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("The account " & txtUsernameDelete.Text & " has been deleted successfully.", "Account deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsernameDelete.Clear()
                        cbAccountTypeDelete.SelectedIndex = 0
                    Else
                        noRecords()
                    End If
                Catch ex As Exception
                    dbFailed()
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            Else
                Try
                    da = New OleDbDataAdapter("Select * from managerLogin where Status='" & "Active" & "' and USERNAME='" & txtUsernameDelete.Text & "' and BDAY='" & dtpBDAYDelete.Text & "'", conn)
                    dset = New DataSet
                    da.Fill(dset, "managerLogin")
                    If dset.Tables("managerLogin").Rows.Count = 1 Then
                        connect()
                        Dim sql As String = "UPDATE managerLogin SET [Status]=@Status WHERE [USERNAME]=@USERNAME"
                        Dim cmd As New OleDbCommand(sql, conn)
                        cmd.Parameters.Add("@Status", OleDbType.VarChar).Value = "Inactive!"
                        cmd.Parameters.Add("@USERNAME", OleDbType.VarChar).Value = txtUsernameReset.Text
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("The account " & txtUsernameDelete.Text & " has been deleted successfully.", "Account deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtUsernameDelete.Clear()
                        cbAccountTypeDelete.SelectedIndex = 0
                    Else
                        noRecords()
                    End If
                Catch ex As Exception
                    dbFailed()
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnCancelDelete_Click(sender As Object, e As EventArgs) Handles btnCancelDelete.Click
        txtUsernameDelete.Clear()
        cbAccountTypeDelete.SelectedIndex = 0
    End Sub

    Private Sub btnCancel2_Click(sender As Object, e As EventArgs) Handles btnCancel2.Click
        txtUsernameReset.Clear()
        cbAccountTypeReset.SelectedIndex = 0
    End Sub

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        loadData()
    End Sub

    Private Sub loadData()
        'ListBoxRequest.Items.Clear()
        Try
            Dim da As New OleDbDataAdapter("SELECT Username FROM passwordRequest", conn)
            Dim dt As New DataTable
            da.Fill(dt)
            ListBoxRequest.DataSource = dt
            ListBoxRequest.DisplayMember = "Username"
            ListBoxRequest.ClearSelected()
        Catch ex As Exception
            dbFailed()
            MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnDecline_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        If MessageBox.Show("Decline " & ListBoxRequest.GetItemText(ListBoxRequest.SelectedValue) & "'s password reset request?", "Password Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbYes Then
            Try
                Dim cmd As New OleDbCommand("Delete from passwordRequest where Username=@Username ", conn)
                cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = ListBoxRequest.GetItemText(ListBoxRequest.SelectedValue)
                connect()
                cmd.ExecuteNonQuery()
                loadData()
            Catch ex As Exception
                dbFailed()
                MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                conn.Close()
                txtUsernameReset.Clear()
            End Try
        End If
    End Sub

    Private Sub ListBoxRequest_Click(sender As Object, e As EventArgs) Handles ListBoxRequest.Click
        If ListBoxRequest.SelectedIndex <> -1 Then ' Check if an item is selected
            txtUsernameReset.Text = ListBoxRequest.GetItemText(ListBoxRequest.SelectedValue) ' Display the selected item in the TextBox
        End If
    End Sub
End Class