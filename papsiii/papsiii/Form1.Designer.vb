﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(190, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Purcashing"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(36, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(190, 65)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Marketing"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(36, 378)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(190, 65)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Warehouse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(568, 176)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(190, 65)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Planning"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(568, 272)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(190, 65)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Production"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(568, 378)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(190, 65)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Warehouse Finishing Good"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(576, 104)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(182, 33)
        Me.ComboBox1.TabIndex = 6
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(114, 84)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(112, 34)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Button7"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 524)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button7 As Button
End Class
