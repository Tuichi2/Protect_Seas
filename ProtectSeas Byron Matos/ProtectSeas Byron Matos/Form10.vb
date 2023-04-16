Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet2.Voluntarios' Puede moverla o quitarla según sea necesario.
        Me.VoluntariosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet2.Voluntarios)
        Label7.Text = DateTime.Now.ToShortDateString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre, apellido, direccio, correo As String
        Dim telefono As Integer
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            nombre = TextBox1.Text
            apellido = TextBox2.Text
            direccio = TextBox3.Text
            correo = TextBox4.Text
            telefono = TextBox5.Text
            Me.VoluntariosTableAdapter.InsertQuery7(nombre, apellido, Module1.fecha, direccio, correo, telefono)
            Me.VoluntariosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet2.Voluntarios)
            MsgBox("Gracias por aplicar en el voluntariado, se le llamara o enviara un correo para hablar sobre más detalles", MsgBoxStyle.Information)
        Else
            MsgBox("Error, Marque las opciones y complete los campos", MsgBoxStyle.Critical)
        End If

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()

    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form4.Show()
    End Sub
End Class