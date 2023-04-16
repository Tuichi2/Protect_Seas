Public Class Form9


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet1.Donantes' Puede moverla o quitarla según sea necesario.
        Me.DonantesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet1.Donantes)

    End Sub
    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre, direccion, correo As String
        Dim a, b As String
        Dim telefono As Integer
        Dim cantidad As Double
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            nombre = TextBox1.Text
            direccion = TextBox2.Text
            telefono = TextBox3.Text
            correo = TextBox4.Text
            cantidad = TextBox5.Text

            If RadioButton1.Checked = True Then
                a = MsgBox("Esta seguro que desea donar esta cantidad", vbYesNo)
                If a = vbYes Then
                    MsgBox("Deposite el dinero a la cuenta No.859, nombre SEAS, en Banrural o llevelo al cajero")
                    Me.DonantesTableAdapter.InsertQuery3(nombre, cantidad, direccion, correo, telefono)
                    Me.DonantesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet1.Donantes)
                Else
                    'noseponenadaaquí
                End If
            ElseIf RadioButton2.Checked = True Then
                b = MsgBox("Esta seguro que desea donar esta cantidad", vbYesNo)
                If b = vbYes Then
                    MsgBox("Ingrese los datos de su tarjeta")
                    Me.DonantesTableAdapter.InsertQuery3(nombre, cantidad, direccion, correo, telefono)
                    Me.DonantesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet1.Donantes)
                    Form8.Show()
                Else
                    'noseponenadaaquí
                End If
            Else
                MsgBox("Error, Marque las opciones y complete los campos", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox5.KeyPress, TextBox3.KeyPress
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