Imports MySql.Data.MySqlClient
Public Class Comprar
    Dim conn As MySqlConnection
    Dim command As MySqlCommand
    Dim numero As Decimal = 0.0
    Dim numeroTotal As Decimal = 0.0
    Sub Adicionar()
        Dim entrada As Decimal = Val(TextBox1.Text)
        Dim numeroD As Decimal = Val(entrada)
        If numeroD <> 0 Then
            Dim novoItem As New ListViewItem(numeroD.ToString())
            ListView1.Items.Add(novoItem)
            numeroTotal += numeroD
            lbl_contagem.Text = "Quantidade de Livros: " & ListView1.Items.Count
            lbl_total.Text = "Preço Total a Pagar: " & numeroTotal
        Else
            MessageBox.Show("Por favor, insira um número válido", "Livraria", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        TextBox1.Clear()
    End Sub
    Sub MostrarLivros()
        conn = New MySqlConnection With {
            .ConnectionString = "server=localhost; userid=root; password='';database=pessoal"
        }
        Try
            conn.Open()

            Dim table As New DataTable
            Dim adappter As New MySqlDataAdapter("SELECT * FROM tab_livros", conn)
            adappter.Fill(table)
            DataGridView1.DataSource = table
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            conn.Close()
        End Try
        DataGridView1.Columns("id_livros").Visible = False
    End Sub
    Sub Selecionar()
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).SelectAll()
        End If
    End Sub
    Sub Copiar()
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Copy()
        End If
    End Sub
    Sub Colar()
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Paste()
        End If
    End Sub
    Sub Curtar()
        If TypeOf Me.ActiveControl Is TextBox Then
            CType(Me.ActiveControl, TextBox).Cut()
        End If
    End Sub
    Sub Formatar()
        FontDialog1.ShowColor = True
        If FontDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            ListView1.Font = FontDialog1.Font
            ListView1.ForeColor = FontDialog1.Color
        End If
    End Sub
    Sub Imprimir()
        PrintDialog1.Document = PrintDocument1
        If PrintDialog1.ShowDialog = DialogResult.OK Then
            Dim printPreviewDialog As New PrintPreviewDialog With {
                .Document = PrintDocument1
            }
            printPreviewDialog.ShowDialog()
        End If
    End Sub
    Sub Sair()
        End
    End Sub
    Private Sub Cmd_produtos_Click(sender As Object, e As EventArgs) Handles Cmd_produtos.Click
        MostrarLivros()
    End Sub
    Private Sub Cmd_adicionar_Click(sender As Object, e As EventArgs) Handles Cmd_adicionar.Click
        Adicionar()
    End Sub
    Private Sub AdicionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarToolStripMenuItem.Click
        Adicionar()
    End Sub
    Private Sub ApresentarLivrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApresentarLivrosToolStripMenuItem.Click
        MostrarLivros()
    End Sub
    Private Sub VoltarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoltarToolStripMenuItem.Click
        Me.Hide()
        Form1.Show()
    End Sub
    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        Sair()
    End Sub
    Private Sub SelecionarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelecionarToolStripMenuItem.Click
        Selecionar()
    End Sub
    Private Sub CopiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopiarToolStripMenuItem.Click
        Copiar()
    End Sub
    Private Sub ColarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColarToolStripMenuItem.Click
        Colar()
    End Sub
    Private Sub CurtarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CortarToolStripMenuItem.Click
        Curtar()
    End Sub
    Private Sub FormatarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatarToolStripMenuItem.Click
        Formatar()
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Imprimir()
    End Sub
    Private Sub Cmd_sair_Click(sender As Object, e As EventArgs) Handles Cmd_sair.Click
        Sair()
    End Sub
    Private Sub Cmd_voltar_Click(sender As Object, e As EventArgs) Handles cmd_voltar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font As New Font("Arial", 12)
        Dim rect As New Rectangle(100, 100, 500, 500)

        e.Graphics.DrawString(text, font, Brushes.Black, rect)
    End Sub
End Class