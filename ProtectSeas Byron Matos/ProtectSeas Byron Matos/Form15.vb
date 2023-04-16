Public Class Form15
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id, cantidad As Integer
        Dim producto As String
        Dim precio As Double
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            id = TextBox1.Text
            producto = TextBox2.Text
            precio = TextBox3.Text
            cantidad = TextBox4.Text
            Me.ProductosTableAdapter.InsertQuery1(id, producto, precio, cantidad)
            Me.ProductosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet6.Productos)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim id, cantidad As Integer
        Dim producto As String
        Dim precio As Double
        If TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" Then
            id = TextBox5.Text
            producto = TextBox6.Text
            precio = TextBox7.Text
            cantidad = TextBox8.Text
            Me.ProductosTableAdapter.UpdateQuery1(producto, precio, cantidad, id)
            Me.ProductosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet6.Productos)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox9.Text <> "" Then
            Me.ProductosTableAdapter.DeleteQuery1(TextBox9.Text)
            Me.ProductosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet6.Productos)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox9.Clear()

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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox4.KeyPress, TextBox3.KeyPress, TextBox1.KeyPress, TextBox9.KeyPress, TextBox8.KeyPress, TextBox7.KeyPress, TextBox5.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet6.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet6.Productos)

    End Sub
End Class