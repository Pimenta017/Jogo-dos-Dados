﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormJogodosDados
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
        Me.components = New System.ComponentModel.Container()
        Me.prgProgressBar = New System.Windows.Forms.ProgressBar()
        Me.btnRoda = New System.Windows.Forms.Button()
        Me.picDado1 = New System.Windows.Forms.PictureBox()
        Me.picDado2 = New System.Windows.Forms.PictureBox()
        Me.tmrTempo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picDado1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDado2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'prgProgressBar
        '
        Me.prgProgressBar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.prgProgressBar.Location = New System.Drawing.Point(0, 402)
        Me.prgProgressBar.Name = "prgProgressBar"
        Me.prgProgressBar.Size = New System.Drawing.Size(602, 39)
        Me.prgProgressBar.TabIndex = 0
        '
        'btnRoda
        '
        Me.btnRoda.Location = New System.Drawing.Point(194, 288)
        Me.btnRoda.Name = "btnRoda"
        Me.btnRoda.Size = New System.Drawing.Size(197, 87)
        Me.btnRoda.TabIndex = 1
        Me.btnRoda.Text = "Roda"
        Me.btnRoda.UseVisualStyleBackColor = True
        '
        'picDado1
        '
        Me.picDado1.Location = New System.Drawing.Point(69, 79)
        Me.picDado1.Name = "picDado1"
        Me.picDado1.Size = New System.Drawing.Size(150, 150)
        Me.picDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDado1.TabIndex = 2
        Me.picDado1.TabStop = False
        '
        'picDado2
        '
        Me.picDado2.Location = New System.Drawing.Point(369, 79)
        Me.picDado2.Name = "picDado2"
        Me.picDado2.Size = New System.Drawing.Size(150, 150)
        Me.picDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picDado2.TabIndex = 3
        Me.picDado2.TabStop = False
        '
        'tmrTempo
        '
        '
        'FormJogodosDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 441)
        Me.Controls.Add(Me.picDado2)
        Me.Controls.Add(Me.picDado1)
        Me.Controls.Add(Me.btnRoda)
        Me.Controls.Add(Me.prgProgressBar)
        Me.Name = "FormJogodosDados"
        Me.Text = "Jogo dos Dados"
        CType(Me.picDado1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDado2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents prgProgressBar As ProgressBar
    Friend WithEvents btnRoda As Button
    Friend WithEvents picDado1 As PictureBox
    Friend WithEvents picDado2 As PictureBox
    Friend WithEvents tmrTempo As Timer
End Class