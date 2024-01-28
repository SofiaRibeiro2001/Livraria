Public Class Fantasia
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        BaladaPassaros.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        ContodeFadas.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        LivrodaNoite.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        OReino.Show()
    End Sub

    Private Sub Cmd_voltar_Click(sender As Object, e As EventArgs) Handles Cmd_voltar.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class