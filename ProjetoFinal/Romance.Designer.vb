<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Romance
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Romance))
        Button6 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        Cmd_voltar = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button6
        ' 
        Button6.BackgroundImage = CType(resources.GetObject("Button6.BackgroundImage"), Image)
        Button6.BackgroundImageLayout = ImageLayout.Stretch
        Button6.FlatStyle = FlatStyle.Popup
        Button6.Location = New Point(457, 258)
        Button6.Name = "Button6"
        Button6.Size = New Size(116, 180)
        Button6.TabIndex = 27
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), Image)
        Button3.BackgroundImageLayout = ImageLayout.Stretch
        Button3.FlatStyle = FlatStyle.Popup
        Button3.Location = New Point(313, 260)
        Button3.Name = "Button3"
        Button3.Size = New Size(116, 180)
        Button3.TabIndex = 26
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.BackgroundImageLayout = ImageLayout.Stretch
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Location = New Point(457, 74)
        Button2.Name = "Button2"
        Button2.Size = New Size(116, 180)
        Button2.TabIndex = 25
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.BackgroundImageLayout = ImageLayout.Stretch
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Location = New Point(313, 74)
        Button1.Name = "Button1"
        Button1.Size = New Size(116, 180)
        Button1.TabIndex = 24
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Cmd_voltar
        ' 
        Cmd_voltar.BackColor = Color.PeachPuff
        Cmd_voltar.FlatAppearance.BorderSize = 0
        Cmd_voltar.FlatStyle = FlatStyle.Flat
        Cmd_voltar.Font = New Font("SWRomnc", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Cmd_voltar.Location = New Point(0, 425)
        Cmd_voltar.Name = "Cmd_voltar"
        Cmd_voltar.Size = New Size(73, 28)
        Cmd_voltar.TabIndex = 23
        Cmd_voltar.Text = "Voltar"
        Cmd_voltar.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.PeachPuff
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(882, 57)
        Panel1.TabIndex = 22
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SWRomnc", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(29, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(202, 42)
        Label1.TabIndex = 1
        Label1.Text = "ROMANCE"
        ' 
        ' Romance
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(882, 453)
        Controls.Add(Button6)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Cmd_voltar)
        Controls.Add(Panel1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Romance"
        Text = "Romance"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Cmd_voltar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
