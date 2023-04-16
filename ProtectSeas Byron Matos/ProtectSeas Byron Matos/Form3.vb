Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario, contraseña, pin As String
        usuario = TextBox1.Text
        contraseña = TextBox2.Text
        pin = TextBox3.Text

        If usuario = "ADMSEAS" And contraseña = "AD123" And pin = "123" Then
            MsgBox("Bienvenido al menu")
            Form5.Show()
            Me.Close()


        Else
            MsgBox("Error de usuario, contraseña y/o pin, verifique que los datos que ingreso sean correctos, si sigue teniendo problemas dar clic en boton de ayuda")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim correo, numero As String
        correo = InputBox("Ingrese su correo electronico")
        numero = InputBox("Ingrese su numero de telefono celular")
        MsgBox("Gracias, se mandara informacion en breve")
        Me.SOPORTETableAdapter.InsertQuery1(correo, numero)
        Me.SOPORTETableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet.SOPORTE)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet.SOPORTE' Puede moverla o quitarla según sea necesario.
        Me.SOPORTETableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet.SOPORTE)

    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Form5.ShowDialog()

    End Sub
End Class