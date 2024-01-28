<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Login
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
    Friend WithEvents LogoPictureBox As PictureBox
    Friend WithEvents OK As Button
    Friend WithEvents Cancel As Button

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Login))
        LogoPictureBox = New PictureBox()
        OK = New Button()
        Cancel = New Button()
        Panel1 = New Panel()
        txt_Senha = New TextBox()
        txt_Usuario = New TextBox()
        PasswordLabel = New Label()
        UsernameLabel = New Label()
        Label1 = New Label()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(-9, 0)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(193, 281)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' OK
        ' 
        OK.Cursor = Cursors.Hand
        OK.FlatStyle = FlatStyle.Flat
        OK.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        OK.Location = New Point(311, 254)
        OK.Name = "OK"
        OK.Size = New Size(108, 27)
        OK.TabIndex = 4
        OK.Text = "&OK"
        ' 
        ' Cancel
        ' 
        Cancel.Cursor = Cursors.Hand
        Cancel.DialogResult = DialogResult.Cancel
        Cancel.FlatStyle = FlatStyle.Flat
        Cancel.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Cancel.Location = New Point(425, 254)
        Cancel.Name = "Cancel"
        Cancel.Size = New Size(108, 27)
        Cancel.TabIndex = 5
        Cancel.Text = "&Cancelar"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(txt_Senha)
        Panel1.Controls.Add(txt_Usuario)
        Panel1.Controls.Add(PasswordLabel)
        Panel1.Controls.Add(UsernameLabel)
        Panel1.Location = New Point(187, 48)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(346, 176)
        Panel1.TabIndex = 7
        ' 
        ' txt_Senha
        ' 
        txt_Senha.BackColor = Color.Tan
        txt_Senha.BorderStyle = BorderStyle.FixedSingle
        txt_Senha.Cursor = Cursors.Hand
        txt_Senha.Location = New Point(84, 103)
        txt_Senha.Name = "txt_Senha"
        txt_Senha.PasswordChar = "*"c
        txt_Senha.Size = New Size(249, 27)
        txt_Senha.TabIndex = 3
        ' 
        ' txt_Usuario
        ' 
        txt_Usuario.BackColor = Color.Tan
        txt_Usuario.BorderStyle = BorderStyle.FixedSingle
        txt_Usuario.Cursor = Cursors.Hand
        txt_Usuario.Location = New Point(84, 32)
        txt_Usuario.Name = "txt_Usuario"
        txt_Usuario.Size = New Size(249, 27)
        txt_Usuario.TabIndex = 1
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.Font = New Font("Swis721 BT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordLabel.Location = New Point(4, 103)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(80, 27)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "Password"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.Font = New Font("Swis721 BT", 9F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameLabel.Location = New Point(6, 32)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(72, 27)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "Usuário"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SWRomnt", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(463, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(70, 22)
        Label1.TabIndex = 8
        Label1.Text = "Login"
        ' 
        ' Login
        ' 
        AcceptButton = OK
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Tan
        CancelButton = Cancel
        ClientSize = New Size(546, 280)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        Controls.Add(Cancel)
        Controls.Add(OK)
        Controls.Add(LogoPictureBox)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Login"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "Login"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Senha As TextBox
    Friend WithEvents txt_Usuario As TextBox
    Friend WithEvents PasswordLabel As Label
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents Label1 As Label
End Class
