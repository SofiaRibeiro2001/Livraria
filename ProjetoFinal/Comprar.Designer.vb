<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comprar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Comprar))
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Cmd_sair = New Button()
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        DataGridView1 = New DataGridView()
        Cmd_produtos = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Cmd_adicionar = New Button()
        ListView1 = New ListView()
        lbl_contagem = New Label()
        lbl_total = New Label()
        MenuStrip1 = New MenuStrip()
        FicheiroToolStripMenuItem = New ToolStripMenuItem()
        AdicionarToolStripMenuItem = New ToolStripMenuItem()
        ApresentarLivrosToolStripMenuItem = New ToolStripMenuItem()
        VoltarToolStripMenuItem = New ToolStripMenuItem()
        SairToolStripMenuItem = New ToolStripMenuItem()
        EditarToolStripMenuItem = New ToolStripMenuItem()
        SelecionarToolStripMenuItem = New ToolStripMenuItem()
        CopiarToolStripMenuItem = New ToolStripMenuItem()
        ColarToolStripMenuItem = New ToolStripMenuItem()
        CortarToolStripMenuItem = New ToolStripMenuItem()
        VerToolStripMenuItem = New ToolStripMenuItem()
        FormatarToolStripMenuItem = New ToolStripMenuItem()
        ImprimirToolStripMenuItem = New ToolStripMenuItem()
        FontDialog1 = New FontDialog()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        cmd_voltar = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Cmd_sair
        ' 
        Cmd_sair.BackColor = Color.PeachPuff
        Cmd_sair.FlatAppearance.BorderSize = 0
        Cmd_sair.FlatStyle = FlatStyle.Flat
        Cmd_sair.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Cmd_sair.Location = New Point(818, 566)
        Cmd_sair.Name = "Cmd_sair"
        Cmd_sair.Size = New Size(64, 32)
        Cmd_sair.TabIndex = 12
        Cmd_sair.Text = "Sair"
        Cmd_sair.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PeachPuff
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 28)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 74)
        Panel1.TabIndex = 7
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(228, 18)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(43, 42)
        PictureBox1.TabIndex = 13
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SWRomnc", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(30, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 42)
        Label1.TabIndex = 1
        Label1.Text = "LIVRARIA"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DataGridView1.BackgroundColor = SystemColors.ControlLightLight
        DataGridView1.ColumnHeadersHeight = 29
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Window
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Color.PeachPuff
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.Location = New Point(0, 102)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(396, 496)
        DataGridView1.TabIndex = 21
        ' 
        ' Cmd_produtos
        ' 
        Cmd_produtos.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Cmd_produtos.Location = New Point(398, 564)
        Cmd_produtos.Name = "Cmd_produtos"
        Cmd_produtos.Size = New Size(268, 37)
        Cmd_produtos.TabIndex = 22
        Cmd_produtos.Text = "Apresentar Lista de Livros"
        Cmd_produtos.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SWRomnc", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(513, 129)
        Label2.Name = "Label2"
        Label2.Size = New Size(269, 30)
        Label2.TabIndex = 23
        Label2.Text = "Preço dos Livros"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlLightLight
        TextBox1.Location = New Point(493, 208)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(198, 27)
        TextBox1.TabIndex = 24
        ' 
        ' Cmd_adicionar
        ' 
        Cmd_adicionar.FlatStyle = FlatStyle.Flat
        Cmd_adicionar.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Cmd_adicionar.Location = New Point(711, 210)
        Cmd_adicionar.Name = "Cmd_adicionar"
        Cmd_adicionar.Size = New Size(112, 28)
        Cmd_adicionar.TabIndex = 25
        Cmd_adicionar.Text = "Adicionar"
        Cmd_adicionar.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.BackColor = SystemColors.ControlLightLight
        ListView1.Location = New Point(493, 255)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(330, 128)
        ListView1.TabIndex = 26
        ListView1.UseCompatibleStateImageBehavior = False
        ' 
        ' lbl_contagem
        ' 
        lbl_contagem.AutoSize = True
        lbl_contagem.Font = New Font("SWRomnc", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_contagem.Location = New Point(493, 398)
        lbl_contagem.Name = "lbl_contagem"
        lbl_contagem.Size = New Size(298, 22)
        lbl_contagem.TabIndex = 27
        lbl_contagem.Text = "Quantidade de Livros  : "
        ' 
        ' lbl_total
        ' 
        lbl_total.AutoSize = True
        lbl_total.Font = New Font("SWRomnc", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbl_total.Location = New Point(493, 437)
        lbl_total.Name = "lbl_total"
        lbl_total.Size = New Size(276, 22)
        lbl_total.TabIndex = 28
        lbl_total.Text = "Preço Total a Pagar  :"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ControlLightLight
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FicheiroToolStripMenuItem, EditarToolStripMenuItem, VerToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(882, 28)
        MenuStrip1.TabIndex = 29
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FicheiroToolStripMenuItem
        ' 
        FicheiroToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AdicionarToolStripMenuItem, ApresentarLivrosToolStripMenuItem, VoltarToolStripMenuItem, SairToolStripMenuItem})
        FicheiroToolStripMenuItem.Name = "FicheiroToolStripMenuItem"
        FicheiroToolStripMenuItem.Size = New Size(75, 24)
        FicheiroToolStripMenuItem.Text = "Ficheiro"
        ' 
        ' AdicionarToolStripMenuItem
        ' 
        AdicionarToolStripMenuItem.Name = "AdicionarToolStripMenuItem"
        AdicionarToolStripMenuItem.Size = New Size(206, 26)
        AdicionarToolStripMenuItem.Text = "Adicionar"
        ' 
        ' ApresentarLivrosToolStripMenuItem
        ' 
        ApresentarLivrosToolStripMenuItem.Name = "ApresentarLivrosToolStripMenuItem"
        ApresentarLivrosToolStripMenuItem.Size = New Size(206, 26)
        ApresentarLivrosToolStripMenuItem.Text = "Apresentar Livros"
        ' 
        ' VoltarToolStripMenuItem
        ' 
        VoltarToolStripMenuItem.Name = "VoltarToolStripMenuItem"
        VoltarToolStripMenuItem.Size = New Size(206, 26)
        VoltarToolStripMenuItem.Text = "Voltar"
        ' 
        ' SairToolStripMenuItem
        ' 
        SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        SairToolStripMenuItem.Size = New Size(206, 26)
        SairToolStripMenuItem.Text = "Sair"
        ' 
        ' EditarToolStripMenuItem
        ' 
        EditarToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {SelecionarToolStripMenuItem, CopiarToolStripMenuItem, ColarToolStripMenuItem, CortarToolStripMenuItem})
        EditarToolStripMenuItem.Name = "EditarToolStripMenuItem"
        EditarToolStripMenuItem.Size = New Size(62, 24)
        EditarToolStripMenuItem.Text = "Editar"
        ' 
        ' SelecionarToolStripMenuItem
        ' 
        SelecionarToolStripMenuItem.Name = "SelecionarToolStripMenuItem"
        SelecionarToolStripMenuItem.Size = New Size(161, 26)
        SelecionarToolStripMenuItem.Text = "Selecionar"
        ' 
        ' CopiarToolStripMenuItem
        ' 
        CopiarToolStripMenuItem.Name = "CopiarToolStripMenuItem"
        CopiarToolStripMenuItem.Size = New Size(161, 26)
        CopiarToolStripMenuItem.Text = "Copiar"
        ' 
        ' ColarToolStripMenuItem
        ' 
        ColarToolStripMenuItem.Name = "ColarToolStripMenuItem"
        ColarToolStripMenuItem.Size = New Size(161, 26)
        ColarToolStripMenuItem.Text = "Colar"
        ' 
        ' CortarToolStripMenuItem
        ' 
        CortarToolStripMenuItem.Name = "CortarToolStripMenuItem"
        CortarToolStripMenuItem.Size = New Size(161, 26)
        CortarToolStripMenuItem.Text = "Curtar"
        ' 
        ' VerToolStripMenuItem
        ' 
        VerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FormatarToolStripMenuItem, ImprimirToolStripMenuItem})
        VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        VerToolStripMenuItem.Size = New Size(44, 24)
        VerToolStripMenuItem.Text = "Ver"
        ' 
        ' FormatarToolStripMenuItem
        ' 
        FormatarToolStripMenuItem.Name = "FormatarToolStripMenuItem"
        FormatarToolStripMenuItem.Size = New Size(152, 26)
        FormatarToolStripMenuItem.Text = "Formatar"
        ' 
        ' ImprimirToolStripMenuItem
        ' 
        ImprimirToolStripMenuItem.Name = "ImprimirToolStripMenuItem"
        ImprimirToolStripMenuItem.Size = New Size(152, 26)
        ImprimirToolStripMenuItem.Text = "Imprimir"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' cmd_voltar
        ' 
        cmd_voltar.BackColor = Color.PeachPuff
        cmd_voltar.FlatAppearance.BorderSize = 0
        cmd_voltar.FlatStyle = FlatStyle.Flat
        cmd_voltar.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        cmd_voltar.Location = New Point(744, 566)
        cmd_voltar.Name = "cmd_voltar"
        cmd_voltar.Size = New Size(64, 32)
        cmd_voltar.TabIndex = 30
        cmd_voltar.Text = "Voltar"
        cmd_voltar.UseVisualStyleBackColor = False
        ' 
        ' Comprar
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 598)
        Controls.Add(cmd_voltar)
        Controls.Add(lbl_total)
        Controls.Add(lbl_contagem)
        Controls.Add(ListView1)
        Controls.Add(Cmd_adicionar)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Cmd_sair)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        Controls.Add(Cmd_produtos)
        Controls.Add(MenuStrip1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MainMenuStrip = MenuStrip1
        Name = "Comprar"
        Text = "Comprar"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cmd_sair As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Cmd_produtos As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Cmd_adicionar As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents lbl_contagem As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FicheiroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdicionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApresentarLivrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VoltarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelecionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopiarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CortarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImprimirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents cmd_voltar As Button
End Class
