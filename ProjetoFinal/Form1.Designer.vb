<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        Cmd_comprar = New Button()
        Cmd_login = New Button()
        Label1 = New Label()
        Cmd_sair = New Button()
        Cmd_Policial = New Button()
        Cmd_comedia = New Button()
        Cmd_romance = New Button()
        Cmd_Fantasia = New Button()
        PictureBox1 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PeachPuff
        Panel1.Controls.Add(Cmd_comprar)
        Panel1.Controls.Add(Cmd_login)
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 74)
        Panel1.TabIndex = 0
        ' 
        ' Cmd_comprar
        ' 
        Cmd_comprar.BackgroundImage = CType(resources.GetObject("Cmd_comprar.BackgroundImage"), Image)
        Cmd_comprar.BackgroundImageLayout = ImageLayout.Stretch
        Cmd_comprar.FlatAppearance.BorderSize = 0
        Cmd_comprar.FlatStyle = FlatStyle.Flat
        Cmd_comprar.Location = New Point(832, 37)
        Cmd_comprar.Name = "Cmd_comprar"
        Cmd_comprar.Size = New Size(38, 33)
        Cmd_comprar.TabIndex = 2
        Cmd_comprar.UseVisualStyleBackColor = True
        ' 
        ' Cmd_login
        ' 
        Cmd_login.BackgroundImage = CType(resources.GetObject("Cmd_login.BackgroundImage"), Image)
        Cmd_login.BackgroundImageLayout = ImageLayout.Stretch
        Cmd_login.FlatAppearance.BorderSize = 0
        Cmd_login.FlatStyle = FlatStyle.Flat
        Cmd_login.Location = New Point(780, 36)
        Cmd_login.Name = "Cmd_login"
        Cmd_login.Size = New Size(39, 33)
        Cmd_login.TabIndex = 1
        Cmd_login.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SWRomnc", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(192, 42)
        Label1.TabIndex = 1
        Label1.Text = "LIVRARIA"
        ' 
        ' Cmd_sair
        ' 
        Cmd_sair.BackColor = Color.PeachPuff
        Cmd_sair.FlatAppearance.BorderSize = 0
        Cmd_sair.FlatStyle = FlatStyle.Flat
        Cmd_sair.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Cmd_sair.Location = New Point(818, 421)
        Cmd_sair.Name = "Cmd_sair"
        Cmd_sair.Size = New Size(64, 32)
        Cmd_sair.TabIndex = 5
        Cmd_sair.Text = "Sair"
        Cmd_sair.UseVisualStyleBackColor = False
        ' 
        ' Cmd_Policial
        ' 
        Cmd_Policial.BackColor = Color.PeachPuff
        Cmd_Policial.FlatStyle = FlatStyle.Flat
        Cmd_Policial.Font = New Font("SWRomnc", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Cmd_Policial.Location = New Point(40, 118)
        Cmd_Policial.Name = "Cmd_Policial"
        Cmd_Policial.Size = New Size(137, 87)
        Cmd_Policial.TabIndex = 1
        Cmd_Policial.Text = "Policial"
        Cmd_Policial.UseVisualStyleBackColor = False
        ' 
        ' Cmd_comedia
        ' 
        Cmd_comedia.BackColor = Color.PeachPuff
        Cmd_comedia.FlatStyle = FlatStyle.Flat
        Cmd_comedia.Font = New Font("SWRomnc", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Cmd_comedia.Location = New Point(266, 118)
        Cmd_comedia.Name = "Cmd_comedia"
        Cmd_comedia.Size = New Size(137, 87)
        Cmd_comedia.TabIndex = 2
        Cmd_comedia.Text = "Comédia"
        Cmd_comedia.UseVisualStyleBackColor = False
        ' 
        ' Cmd_romance
        ' 
        Cmd_romance.BackColor = Color.PeachPuff
        Cmd_romance.FlatStyle = FlatStyle.Flat
        Cmd_romance.Font = New Font("SWRomnc", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Cmd_romance.Location = New Point(40, 280)
        Cmd_romance.Name = "Cmd_romance"
        Cmd_romance.Size = New Size(137, 87)
        Cmd_romance.TabIndex = 3
        Cmd_romance.Text = "Romance"
        Cmd_romance.UseVisualStyleBackColor = False
        ' 
        ' Cmd_Fantasia
        ' 
        Cmd_Fantasia.BackColor = Color.PeachPuff
        Cmd_Fantasia.FlatStyle = FlatStyle.Flat
        Cmd_Fantasia.Font = New Font("SWRomnc", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Cmd_Fantasia.Location = New Point(266, 270)
        Cmd_Fantasia.Name = "Cmd_Fantasia"
        Cmd_Fantasia.Size = New Size(137, 87)
        Cmd_Fantasia.TabIndex = 4
        Cmd_Fantasia.Text = "Fantasia"
        Cmd_Fantasia.UseVisualStyleBackColor = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-10, 69)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(926, 617)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 453)
        Controls.Add(Cmd_sair)
        Controls.Add(Cmd_Fantasia)
        Controls.Add(Cmd_romance)
        Controls.Add(Cmd_comedia)
        Controls.Add(Cmd_Policial)
        Controls.Add(Panel1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Form1"
        Text = "Livraria"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmd_login As Button
    Friend WithEvents Cmd_Policial As Button
    Friend WithEvents Cmd_comedia As Button
    Friend WithEvents Cmd_romance As Button
    Friend WithEvents Cmd_Fantasia As Button
    Friend WithEvents Cmd_sair As Button
    Friend WithEvents Cmd_comprar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
