<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ContodeFadas
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(ContodeFadas))
        Cmd_voltar = New Button()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        PictureBox5 = New PictureBox()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Cmd_voltar
        ' 
        Cmd_voltar.BackColor = Color.PeachPuff
        Cmd_voltar.FlatAppearance.BorderSize = 0
        Cmd_voltar.FlatStyle = FlatStyle.Flat
        Cmd_voltar.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Cmd_voltar.Location = New Point(809, 426)
        Cmd_voltar.Name = "Cmd_voltar"
        Cmd_voltar.Size = New Size(73, 28)
        Cmd_voltar.TabIndex = 29
        Cmd_voltar.Text = "Voltar"
        Cmd_voltar.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLight
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(276, 113)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 25)
        Label6.TabIndex = 33
        Label6.Text = "Sinopse:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(226, 369)
        Label5.Name = "Label5"
        Label5.Size = New Size(85, 31)
        Label5.TabIndex = 32
        Label5.Text = "22,20€"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Location = New Point(696, 367)
        Label4.Name = "Label4"
        Label4.Size = New Size(145, 20)
        Label4.TabIndex = 31
        Label4.Text = "Autor: Stephen King "
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ControlLight
        Label3.Location = New Point(276, 138)
        Label3.Name = "Label3"
        Label3.Size = New Size(565, 229)
        Label3.TabIndex = 30
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(29, 113)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(191, 287)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 28
        PictureBox5.TabStop = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PeachPuff
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 57)
        Panel1.TabIndex = 27
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SWRomnc", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(29, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(203, 42)
        Label1.TabIndex = 1
        Label1.Text = "FANTASIA"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("SWRomnc", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(641, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(200, 23)
        Label2.TabIndex = 7
        Label2.Text = "Conto de Fadas"
        ' 
        ' ContodeFadas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 453)
        Controls.Add(Cmd_voltar)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox5)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "ContodeFadas"
        Text = "Conto de Fadas"
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Cmd_voltar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
