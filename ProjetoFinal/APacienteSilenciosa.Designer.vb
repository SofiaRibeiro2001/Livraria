﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APacienteSilenciosa
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(APacienteSilenciosa))
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        PictureBox5 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Cmd_voltar = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        Panel1.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("SWRomnc", 19.7999973F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(29, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(191, 42)
        Label1.TabIndex = 1
        Label1.Text = "POLICIAL"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(655, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(186, 25)
        Label2.TabIndex = 7
        Label2.Text = "A Paciente Silenciosa"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(29, 102)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(191, 287)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 6
        PictureBox5.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ControlLight
        Label3.Location = New Point(276, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(565, 187)
        Label3.TabIndex = 8
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlLight
        Label4.Location = New Point(676, 314)
        Label4.Name = "Label4"
        Label4.Size = New Size(165, 20)
        Label4.TabIndex = 9
        Label4.Text = "Autor: Alex Michaelides"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlLight
        Label5.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(226, 358)
        Label5.Name = "Label5"
        Label5.Size = New Size(80, 31)
        Label5.TabIndex = 10
        Label5.Text = "17,90€"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ControlLight
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(276, 102)
        Label6.Name = "Label6"
        Label6.Size = New Size(83, 25)
        Label6.TabIndex = 12
        Label6.Text = "Sinopse:"
        ' 
        ' Cmd_voltar
        ' 
        Cmd_voltar.BackColor = Color.PeachPuff
        Cmd_voltar.FlatAppearance.BorderSize = 0
        Cmd_voltar.FlatStyle = FlatStyle.Flat
        Cmd_voltar.Location = New Point(809, 427)
        Cmd_voltar.Name = "Cmd_voltar"
        Cmd_voltar.Size = New Size(73, 28)
        Cmd_voltar.TabIndex = 8
        Cmd_voltar.Text = "Voltar"
        Cmd_voltar.UseVisualStyleBackColor = False
        ' 
        ' APacienteSilenciosa
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
        Name = "APacienteSilenciosa"
        Text = "A Paciente Silenciosa"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Cmd_voltar As Button
End Class
