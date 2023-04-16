Public Class Form4

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form9.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form10.Show()
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form11.Show()
        Me.Close()

    End Sub
End Class