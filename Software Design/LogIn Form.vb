Imports System.Collections.ObjectModel
Imports System.Data.OleDb
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class LogIn_Form
    Dim da As OleDbDataAdapter
    Dim dset As New DataSet
    Dim daTrap As OleDbDataAdapter
    Dim dsetTrap As New DataSet


    Private Sub LogIn_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TabControl.Appearance = TabAppearance.FlatButtons
        TabControl.ItemSize = New Size(0, 1)
        TabControl.SizeMode = TabSizeMode.Fixed
        txtPassword1.UseSystemPasswordChar = True
        txtPassword2.UseSystemPasswordChar = True
        txtPassword3.UseSystemPasswordChar = True
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim accType As String
        If cbLoginType.SelectedIndex = 0 Then
            accType = "employeeLogin"
        ElseIf cbLoginType.SelectedIndex = 1 Then
            accType = "admin"
        Else
            accType = "managerLogin"
        End If

        If cbLoginType.Text = "" Or txtUserNameLogin.Text = "" Or txtPassword1.Text = Nothing Then
            loginFailed()
        Else
            connect()
            If cbLoginType.SelectedIndex = 0 Or cbLoginType.SelectedIndex = 2 Then
                Try
                    da = New OleDbDataAdapter("Select * from " & accType & " where Status='" & "Active" & "' and USERNAME='" & txtUserNameLogin.Text & "' and PASSWORD='" & txtPassword1.Text & "'", conn)
                    dset = New DataSet
                    da.Fill(dset, accType)
                    If dset.Tables(accType).Rows.Count = 1 Then
                        Dim cmd As New OleDbCommand("Select * from " & accType & " where USERNAME=@USERNAME", conn)
                        cmd.Parameters.AddWithValue("USERNAME", txtUserNameLogin.Text.Trim)
                        Dim myreader As OleDbDataReader
                        myreader = cmd.ExecuteReader
                        If myreader.Read() Then
                            FName = myreader("FirstName").ToString
                            LName = myreader("LastName").ToString
                        Else
                            MessageBox.Show("No records found.", "ERROR")
                        End If
                        If txtPassword1.Text = "tempPass123!" Then
                            TabControl.SelectedTab = tabSetNewPass
                            txtUsernameCreate.Text = txtUserNameLogin.Text
                            txtAccountType.Text = cbLoginType.Text
                        Else
                            If accType = "employeeLogin" Then
                                TabControl.SelectedTab = EmployeeChoice
                            Else
                                ManagerForm.Show()
                                Me.Hide()
                            End If
                        End If
                        loginSuccess()
                    Else
                        loginFailed()
                    End If
                Catch ex As Exception
                    dbFailed()
                    MessageBox.Show("An error occurred: " & ex.Message)
                Finally
                    conn.Close()
                End Try
            Else
                If txtUserNameLogin.Text = "Admin" And txtPassword1.Text = "Admiiin123!" Then
                    loginSuccess()
                    AdminForm.Show()
                    Me.Hide()
                Else
                    loginFailed()
                End If
            End If
        End If
        FullName = FName & " " & LName
    End Sub

    Private Sub btnShowPass1_Click(sender As Object, e As EventArgs) Handles btnPassword1.Click
        If txtPassword1.UseSystemPasswordChar = True Then
            txtPassword1.UseSystemPasswordChar = False
            btnPassword1.BackgroundImage = Global.Software_Design.My.Resources.Resources.show
        Else
            txtPassword1.UseSystemPasswordChar = True
            btnPassword1.BackgroundImage = Global.Software_Design.My.Resources.Resources.hide
        End If
    End Sub
    Private Sub btnShowPass2_Click(sender As Object, e As EventArgs) Handles btnPassword2.Click
        If txtPassword2.UseSystemPasswordChar = True Then
            txtPassword2.UseSystemPasswordChar = False
            btnPassword2.BackgroundImage = Global.Software_Design.My.Resources.Resources.show
        Else
            txtPassword2.UseSystemPasswordChar = True
            btnPassword2.BackgroundImage = Global.Software_Design.My.Resources.Resources.hide
        End If
    End Sub
    Private Sub btnShowPass3_Click(sender As Object, e As EventArgs) Handles btnPassword3.Click
        If txtPassword3.UseSystemPasswordChar = True Then
            txtPassword3.UseSystemPasswordChar = False
            btnPassword3.BackgroundImage = Global.Software_Design.My.Resources.Resources.show
        Else
            txtPassword3.UseSystemPasswordChar = True
            btnPassword3.BackgroundImage = Global.Software_Design.My.Resources.Resources.hide
        End If
    End Sub


    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles btnBackToLogin.Click
        TabControl.SelectedTab = LogInForm
    End Sub

    Private Sub btnEntranceGate_Click(sender As Object, e As EventArgs) Handles btnEntranceGate.Click
        Dim mainForm As New MainForm()
        Dim mainDashBoard As TabControl = mainForm.tabMainNew
        mainDashBoard.SelectedTab = mainDashBoard.TabPages(0)
        mainForm.lblHeading.Text = "Entrance Gate"
        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExitGate_Click(sender As Object, e As EventArgs) Handles btnExitGate.Click
        Dim mainForm As New MainForm()
        Dim mainDashBoard As TabControl = mainForm.tabMainNew
        mainDashBoard.SelectedTab = mainDashBoard.TabPages(1)
        mainForm.lblHeading.Text = "Exit Gate"

        mainForm.cbDiscount.Items.Clear()
        mainForm.cbDiscount.Items.AddRange(New Object() {"Regular (0.00%)", "Student (" & FormatPercent(studentDisc) & ")", "PWD and Senior Citizen (" & FormatPercent(pwdNseniorDisc) & ")"})

        mainForm.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click_2(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        TabControl.SelectedTab = LogInForm
    End Sub

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        If txtPassword2.Text = Nothing Or txtPassword3.Text = Nothing Then
            updateFailed()
        Else
            If txtPassword2.Text <> txtPassword3.Text Then
                MessageBox.Show("Password mismatch.", "Create Account Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                If (ValidatePassword(txtPassword2.Text) = False) Or (txtPassword2.Text.Length < 8) Then
                    MessageBox.Show("Password must contain" & vbCrLf & vbCrLf & "- Upper and lowercase letters" & vbCrLf & "- Numbers" & vbCrLf & "- Symbols/SpecialCharacters" & vbCrLf & "- With minimum 8 characters", "Password Requiremetns", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Try
                        If txtAccountType.Text = "Employee" Then
                            Dim sql As String = "UPDATE employeeLogin SET [PASSWORD]=@PASSWORD WHERE [USERNAME]=@USERNAME"

                            Dim cmd As New OleDbCommand(sql, conn)
                            cmd.Parameters.Add("@PASSWORD", OleDbType.VarChar).Value = txtPassword2.Text
                            cmd.Parameters.Add("@USERNAME", OleDbType.VarChar).Value = txtUsernameCreate.Text

                            connect()
                            cmd.ExecuteNonQuery()
                            conn.Close()
                            updateSuccess()
                            TabControl.SelectedTab = LogInForm
                        Else
                            Dim sql As String = "UPDATE managerLogin SET [PASSWORD]=@PASSWORD WHERE [USERNAME]=@USERNAME"

                            Dim cmd As New OleDbCommand(sql, conn)
                            cmd.Parameters.Add("@PASSWORD", OleDbType.VarChar).Value = txtPassword2.Text
                            cmd.Parameters.Add("@USERNAME", OleDbType.VarChar).Value = txtUsernameCreate.Text

                            connect()
                            cmd.ExecuteNonQuery()
                            conn.Close()
                            updateSuccess()
                            TabControl.SelectedTab = LogInForm
                        End If
                    Catch ex As Exception
                        dbFailed()
                        MessageBox.Show("An error occurred: " & ex.Message)
                    Finally
                        conn.Close()
                    End Try
                End If
            End If
        End If
    End Sub

    Private Sub linkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkForgotPassword.LinkClicked
        TabControl.SelectedTab = requestPassword
    End Sub

    Private Sub Guna2Button2_Click_2(sender As Object, e As EventArgs) Handles btnCancenRequest.Click
        TabControl.SelectedTab = LogInForm
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles btnRequest.Click
        If txtUsernameRequest.Text = Nothing Then
            MessageBox.Show("Required information can not be empty.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            MessageBox.Show("If we find any account matching the information you provided a request will be sent to the admin. You may also contact admin for direct assistance.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If cbAccountTypeRequest.SelectedIndex = 0 Then
                Try
                    da = New OleDbDataAdapter("Select * from employeeLogin where USERNAME='" & txtUsernameRequest.Text & "' and BDAY='" & dtpBdayRequest.Text & "'", conn)
                    dset = New DataSet
                    da.Fill(dset, "employeeLogin")
                    If dset.Tables("employeeLogin").Rows.Count = 1 Then
                        daTrap = New OleDbDataAdapter("Select * from passwordRequest where USERNAME='" & txtUsernameRequest.Text & "'", conn)
                        dsetTrap = New DataSet
                        daTrap.Fill(dsetTrap, "passwordRequest")
                        If dsetTrap.Tables("passwordRequest").Rows.Count > 0 Then
                            MessageBox.Show("A request is already sent.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            connect()
                            Dim comm As OleDbCommand
                            comm = New OleDbCommand
                            comm.Connection = conn
                            comm.CommandText = "Insert into passwordRequest values('" & cbAccountTypeRequest.Text & "', '" & txtUsernameRequest.Text & "', '" & dtpBdayRequest.Text & "')"
                            comm.ExecuteNonQuery()
                        End If
                    End If
                Catch ex As Exception
                    dbFailed()
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                    txtUsernameRequest.Clear()
                    cbAccountTypeRequest.SelectedIndex = 0
                End Try
            Else
                Try
                    da = New OleDbDataAdapter("Select * from managerLogin where USERNAME='" & txtUsernameRequest.Text & "' and BDAY='" & dtpBdayRequest.Text & "'", conn)
                    dset = New DataSet
                    da.Fill(dset, "managerLogin")
                    If dset.Tables("managerLogin").Rows.Count = 1 Then
                        daTrap = New OleDbDataAdapter("Select * from passwordRequest where USERNAME='" & txtUsernameRequest.Text & "'", conn)
                        dsetTrap = New DataSet
                        daTrap.Fill(dsetTrap, "passwordRequest")
                        If dsetTrap.Tables("passwordRequest").Rows.Count > 0 Then
                            MessageBox.Show("A request is already sent.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            connect()
                            Dim comm As OleDbCommand
                            comm = New OleDbCommand
                            comm.Connection = conn
                            comm.CommandText = "Insert into passwordRequest values('" & cbAccountTypeRequest.Text & "', '" & txtUsernameRequest.Text & "', '" & dtpBdayRequest.Text & "')"
                            comm.ExecuteNonQuery()
                        End If
                    End If
                Catch ex As Exception
                    dbFailed()
                    MessageBox.Show("An error occurred: " & ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                    txtUsernameRequest.Clear()
                    cbAccountTypeRequest.SelectedIndex = 0
                End Try
            End If
        End If
    End Sub
End Class