Public Class Form13
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet4.Donantes' Puede moverla o quitarla según sea necesario.
        Me.DonantesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet4.Donantes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        Dim nombre, direccion, correo As String
        Dim telefono As Integer
        Dim cantidad As Double
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" And TextBox13.Text <> "" Then
            id = TextBox13.Text
            nombre = TextBox1.Text
            cantidad = TextBox2.Text
            direccion = TextBox3.Text
            correo = TextBox4.Text
            telefono = TextBox5.Text
            Me.DonantesTableAdapter.InsertQuery2(id, nombre, cantidad, direccion, correo, telefono)
            Me.DonantesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet4.Donantes)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id As Integer
        Dim nombre, direccion, correo As String
        Dim telefono As Integer
        Dim cantidad As Double
        If TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" And TextBox9.Text <> "" And TextBox10.Text <> "" And TextBox11.Text <> "" Then
            id = TextBox6.Text
            nombre = TextBox7.Text
            cantidad = TextBox8.Text
            direccion = TextBox9.Text
            correo = TextBox10.Text
            telefono = TextBox11.Text
            Me.DonantesTableAdapter.UpdateQuery1(nombre, cantidad, direccion, correo, telefono, id)
            Me.DonantesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet4.Donantes)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress, TextBox2.KeyPress, TextBox8.KeyPress, TextBox6.KeyPress, TextBox11.KeyPress, TextBox13.KeyPress, TextBox12.KeyPress
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
        If TextBox12.Text <> "" Then
            Me.DonantesTableAdapter.DeleteQuery1(TextBox12.Text)
            Me.DonantesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet4.Donantes)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub



    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton4_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Dim a As String
        a = MsgBox("¿Desea regresar?", vbYesNo)
        If a = vbYes Then
            Form5.Show()
            Me.Close()
        Else
            'nada
        End If
    End Sub
End Class