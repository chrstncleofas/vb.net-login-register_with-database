Imports MySql.Data.MySqlClient
Module Module1
    Public cnstr As MySqlConnection
    Public com As MySqlCommand


    Sub Connection()
        Try
            cnstr = New MySqlConnection("server=localhost; database=db_login_register; username=root; password=;")
            cnstr.Open()
            'MsgBox("Connected to Database", vbInformation, "Database")
        Catch ex As Exception
            MsgBox("Connection Failed", vbCritical, "Error")
        End Try
        
    End Sub

End Module
