Public Class Form11
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre, telefono, correo, comentario As String
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            nombre = TextBox1.Text
            telefono = TextBox4.Text
            correo = TextBox5.Text
            comentario = TextBox2.Text
            Me.COMENTARIOSTableAdapter.InsertQuery45(nombre, telefono, correo, comentario)
            Me.COMENTARIOSTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet3.COMENTARIOS)
            MsgBox("Datos enviados correctamente", MsgBoxStyle.Information)
        Else
            MsgBox("Error, Marque las opciones y complete los campos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet3.COMENTARIOS' Puede moverla o quitarla según sea necesario.
        Me.COMENTARIOSTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet3.COMENTARIOS)

    End Sub

    Private Sub TextBox4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub
End Class