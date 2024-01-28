Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Login
    Dim MAXtentativas As Integer = 3
    Dim tentativas As Integer

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim user As String = txt_Usuario.Text
        Dim passe As String = txt_Senha.Text

        If user <> "livraria" Or passe <> "1234" Then
            tentativas += 1
            If tentativas >= MAXtentativas Then
                MessageBox.Show("Excedeu o máximo de tentativas possiveis", "Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
            Else
                Dim restantes As Integer = MAXtentativas - tentativas
                MessageBox.Show("O nome do utilizador ou a password está incorreta", "Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error)

                txt_Usuario.Text = ""
                txt_Senha.Text = ""
            End If
        Else
            tentativas = 0
            Me.Hide()
            Form1.Show()
            MessageBox.Show("Bem vindo", "Livraria", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
