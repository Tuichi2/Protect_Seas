Public Class Form14


    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet5.Proveedor' Puede moverla o quitarla según sea necesario.
        Me.ProveedorTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet5.Proveedor)

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

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If TextBox12.Text <> "" Then
            Me.ProveedorTableAdapter.DeleteQuery(TextBox12.Text)
            Me.ProveedorTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet5.Proveedor)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim id As Integer
        Dim proveedor, direccion, producto As String
        Dim telefono As Integer
        If TextBox14.Text <> "" And TextBox16.Text <> "" And TextBox17.Text <> "" And TextBox15.Text <> "" And TextBox13.Text <> "" Then
            id = TextBox14.Text
            proveedor = TextBox16.Text
            telefono = TextBox17.Text
            direccion = TextBox15.Text
            producto = TextBox13.Text
            Me.ProveedorTableAdapter.UpdateQuery1(proveedor, telefono, direccion, producto, id)
            Me.ProveedorTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet5.Proveedor)
        Else
            MsgBox("Rellene todos los campos con la informacion", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        Dim proveedor, direccion, producto As String
        Dim telefono As Integer
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            id = TextBox1.Text
            proveedor = TextBox2.Text
            telefono = TextBox3.Text
            direccion = TextBox4.Text
            producto = TextBox5.Text
            Me.ProveedorTableAdapter.InsertQuery1(id, proveedor, telefono, direccion, producto)
            Me.ProveedorTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet5.Proveedor)
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
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox12.Clear()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox13.Clear()
        TextBox14.Clear()
        TextBox15.Clear()
        TextBox16.Clear()
        TextBox17.Clear()
    End Sub

    Private Sub TextBox14_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox17.KeyPress, TextBox14.KeyPress, TextBox3.KeyPress, TextBox12.KeyPress, TextBox1.KeyPress
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