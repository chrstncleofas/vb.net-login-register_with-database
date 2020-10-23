Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MyCon As MySqlConnection
    Dim Comm As MySqlCommand

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Connection()
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MsgBox("Do you want to close this window", vbQuestion + vbYesNo, "Register Form") = vbYes Then
            Me.Close()
            Form2.Close()
            Form3.Close()
        Else
            Me.Focus()
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        MyCon = New MySqlConnection
        MyCon.ConnectionString = ("server=localhost; database=db_login_register; username=root; password=;")
        Dim read As MySqlDataReader

        Try
            MyCon.Open()
            Dim qry As String

            qry = "select * from table_database where Username = '" & txtUser.Text & "' and Password = '" & txtPass.Text & "' "

            Comm = New MySqlCommand(qry, MyCon)
            read = Comm.ExecuteReader
            Dim row As Integer

            While read.Read
                row = row + 1
            End While

            If row = 1 Then
                MsgBox("Login Success", vbInformation, "Login Form")

                Me.Hide()
                Form3.Show()

            ElseIf txtUser.Text = "" And txtPass.Text = "" Then
                MsgBox("Please enter your username and password", vbCritical, "Login Form")
            Else
                MsgBox("Incorrect username and password", vbCritical, "Login Form")
                txtUser.Clear()
                txtUser.Focus()
                txtPass.Clear()
            End If

            MyCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Login Form")

        Finally
            MyCon.Dispose()
        End Try
    End Sub
End Class