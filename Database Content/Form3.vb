Public Class Form3

    Private Sub btnOkay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOkay.Click
        If MsgBox("Do you want to close this window", vbQuestion + vbYesNo, "Register Form") = vbYes Then
            Me.Close()
            Form1.Close()
            Form2.Close()
        Else
            Me.Focus()
        End If
    End Sub
End Class