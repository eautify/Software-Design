Imports System.Collections.ObjectModel
Imports System.Data.Common
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls

Module Module1
    Public connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\ParkingSystemDB.accdb"
    Public conn As New OleDbConnection(connString)

    Public vehicle2Wheels As Double = 50
    Public vehicle4Wheels As Double = 100
    Public studentDisc As Double = 0.1
    Public pwdNseniorDisc As Double = 0.2
    Public feesPerHours As Double = 30
    Public userEmployee As String
    Public freeHours As Double = 2

    Public FName As String
    Public LName As String
    Public FullName As String

    Public Serial As Integer = 0
    Public count2 As Integer
    Public count4 As Integer
    Public count2Slots As Integer
    Public count4Slots As Integer

    Public tempPass As String = "tempPass123!"

    Sub loginSuccess()
        MessageBox.Show("Login Successful.", "Login  Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LogIn_Form.txtPassword1.Clear()
        LogIn_Form.txtUserNameLogin.Clear()
    End Sub
    Sub loginFailed()
        MessageBox.Show("Opps, Invalid Credentials", "Authentication Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        LogIn_Form.txtPassword1.Text = ""
        LogIn_Form.txtUserNameLogin.Text = ""
    End Sub

    Sub updateSuccess()
        MessageBox.Show("Click OK to login again.", "Update Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LogIn_Form.txtAccountType.Clear()
        LogIn_Form.txtPassword2.Clear()
        LogIn_Form.txtPassword3.Clear()
        LogIn_Form.txtUsernameCreate.Clear()
    End Sub

    Sub updateSuccessReset()
        MessageBox.Show("Password has been successfully updated to '" & tempPass & "'.", "Update Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        AdminForm.txtUsernameReset.Clear()
    End Sub

    Sub updateFailed()
        MessageBox.Show("Invalid password.", "Password Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        LogIn_Form.txtPassword2.Text = ""
        LogIn_Form.txtPassword3.Text = ""
    End Sub

    Sub dbFailed()
        MessageBox.Show("Database error.", "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Sub noRecords()
        MessageBox.Show("No records found.", "No records!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Function connect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function

    Function ValidatePassword(ByVal Password) As Boolean
        Dim regEx
        regEx = CreateObject("vbScript.regexp")
        regEx.Pattern = "^.*(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}.*$"
        ValidatePassword = regEx.Test(Password)
        regEx = Nothing
    End Function


End Module