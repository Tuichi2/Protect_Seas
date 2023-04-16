Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As String
        a = MsgBox("¿Desea salir de la aplicación?", vbYesNo)
        If a = vbYes Then
            Me.Close()
        Else
            'nada
        End If
    End Sub
End Class
