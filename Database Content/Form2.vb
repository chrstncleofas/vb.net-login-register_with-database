Imports MySql.Data.MySqlClient
Public Class Form2
    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        If MsgBox("Do you want to close this window", vbQuestion + vbYesNo, "Register Form") = vbYes Then
            Me.Close()
            Form1.Close()
            Form3.Close()
        Else
            Me.Focus()
        End If
    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click
        Try
            If txtFname.Text = "" And txtLname.Text = "" And txtUsername.Text = "" And txtPassword.Text = "" Then
                MsgBox("Please input your detail", vbCritical, "Register Form")
                txtFname.Focus()

            Else
                Connection()
                com = New MySqlCommand("insert into table_database (Firstname, Lastname, Username, Password) values('" & txtFname.Text & "','" & txtLname.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')", cnstr)
                com.ExecuteNonQuery()

                MsgBox("Register Successfull", vbInformation, "Register Form")

                txtFname.Clear()
                txtFname.Focus()
                txtUsername.Clear()
                txtPassword.Clear()
                Form1.Show()
                Me.Hide()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")

        End Try
    End Sub
End Class