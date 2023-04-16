Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Plan_de_base_de_datos_Byron_MatosDataSet7.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet7.Clientes)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nombre, direccion, correo, pago As String
        Dim nit, telefono As Integer
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And TextBox5.Text <> "" Then
            nombre = TextBox1.Text
            nit = TextBox2.Text
            direccion = TextBox3.Text
            correo = TextBox4.Text
            telefono = TextBox5.Text
            Dim total, nose, subtotal, totalm As Double
            If RadioButton1.Checked = True Then
                total = Module1.nototal
                'estamos jalando la informacion del modulo1 que se ingreso en el anterior formulario 
                TextBox6.Text = "Q." & total
                pago = "efectivo"
                MsgBox("Deposite el dinero a la cuenta No.859, nombre SEAS, en Banrural o llevelo al cajero", MsgBoxStyle.Information, "Verificacion")
                Me.ClientesTableAdapter.InsertQuery1(nombre, telefono, nit, direccion, correo, pago)
                Me.ClientesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet7.Clientes)
            ElseIf RadioButton2.Checked = True Then
                nose = Module1.nototal
                subtotal = nose * 0.05
                totalm = subtotal + nose
                TextBox6.Text = "Q." & totalm
                Form8.Show()
                pago = "tarjeta"
                Me.ClientesTableAdapter.InsertQuery1(nombre, telefono, nit, direccion, correo, pago)
                Me.ClientesTableAdapter.Fill(Me.Plan_de_base_de_datos_Byron_MatosDataSet7.Clientes)
            Else
                MsgBox("Error, Marque las opciones y complete los campos", MsgBoxStyle.Critical)
            End If
        Else
            MsgBox("Error, Marque las opciones y complete los campos", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form6.Show()
    End Sub

    Private Sub TextBox6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox6.KeyPress, TextBox2.KeyPress
        'este codigo de aquí sirve para que solo se puedan escribir numeros en vez de letras
        'es util para evitar el error de compilacion con las variables int, double y decimal ya que cuando se escriben
        'cosas que no son numeros lanzan error. 
        'creditos a IT HOME

        Dim Ch As Char = e.KeyChar
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "1234567890"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class