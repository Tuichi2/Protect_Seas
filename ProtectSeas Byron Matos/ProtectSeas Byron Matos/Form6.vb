Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim precio As Double
        If CheckBox1.Checked = True Then
            precio += 25
        End If
        If CheckBox2.Checked = True Then
            precio += 24
        End If
        If CheckBox3.Checked = True Then
            precio += 20
        End If
        If CheckBox4.Checked = True Then
            precio += 20
        End If
        If CheckBox5.Checked = True Then
            precio += 50
        End If
        If CheckBox6.Checked = True Then
            precio += 50
        End If
        If CheckBox7.Checked = True Then
            precio += 45
        End If
        If CheckBox8.Checked = True Then
            precio += 15
        End If
        If CheckBox9.Checked = True Then
            precio += 15
        End If
        If CheckBox10.Checked = True Then
            precio += 20
        End If
        Module1.nototal = precio
        'Podemos ver que se esta llamando a la variable del modulo 1 la cual va guardarnos la suma total 
        'de todos los checbox 

        Me.Close()
        Form7.Show()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form4.Show()

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(0)
    End Sub

    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(1)
    End Sub

    Private Sub RadioButton3_CheckedChanged_1(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        TabControl1.SelectedTab = TabControl1.TabPages.Item(2)
    End Sub
End Class