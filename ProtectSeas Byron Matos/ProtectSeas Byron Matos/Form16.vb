Public Class Form16
    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet8.Voluntarios' Puede moverla o quitarla según sea necesario.
        Me.VoluntariosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet8.Voluntarios)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, telefono As Integer
        Dim nombre, apellido, direccion, correo, fecha As String
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" Then
            id = TextBox1.Text
            nombre = TextBox2.Text
            apellido = TextBox3.Text
            direccion = TextBox4.Text
            telefono = TextBox5.Text
            correo = TextBox6.Text
            fecha = TextBox7.Text

            Me.VoluntariosTableAdapter.InsertQuery1(id, nombre, apellido, fecha, direccion, correo, telefono)
            Me.VoluntariosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet8.Voluntarios)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id, telefono As Integer
        Dim nombre, apellido, direccion, correo, fecha As String
        If TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox10.Text <> "" And TextBox11.Text <> "" And TextBox12.Text <> "" And TextBox13.Text <> "" And TextBox14.Text <> "" Then
            id = TextBox8.Text
            nombre = TextBox9.Text
            apellido = TextBox10.Text
            direccion = TextBox11.Text
            telefono = TextBox12.Text
            correo = TextBox13.Text
            fecha = TextBox14.Text
            Me.VoluntariosTableAdapter.UpdateQuery1(nombre, apellido, fecha, direccion, correo, telefono, id)
            Me.VoluntariosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet8.Voluntarios)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox8.Clear()
        TextBox9.Clear()
        TextBox10.Clear()
        TextBox11.Clear()
        TextBox12.Clear()
        TextBox13.Clear()
        TextBox14.Clear()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox15.Text <> "" Then
            Me.VoluntariosTableAdapter.DeleteQuery1(TextBox15.Text)
            Me.VoluntariosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet8.Voluntarios)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox15.Clear()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim a As String
        a = MsgBox("¿Desea regresar?", vbYesNo)
        If a = vbYes Then
            Form5.Show()
            Me.Close()
        Else
            'nada
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress, TextBox1.KeyPress, TextBox8.KeyPress, TextBox15.KeyPress, TextBox12.KeyPress
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