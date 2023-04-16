Public Class Form5
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim a As String
        a = MsgBox("Desea regresar al menu principal", vbYesNo)
        If a = vbYes Then
            Me.Close()
            Form1.Show()
        Else
            'no se pone nada aquí
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form12.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form13.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form14.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form15.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Form16.Show()
        Me.Close()
    End Sub
End Class