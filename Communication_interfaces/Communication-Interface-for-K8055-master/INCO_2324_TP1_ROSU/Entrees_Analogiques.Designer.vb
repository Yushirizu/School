<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrees_Analogiques
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LblValue2 = New System.Windows.Forms.Label()
        Me.VScrollBar2 = New System.Windows.Forms.VScrollBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblValue1 = New System.Windows.Forms.Label()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.BtnRevenir = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblValue2)
        Me.GroupBox2.Controls.Add(Me.VScrollBar2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(255, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(44, 300)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "AD2"
        '
        'LblValue2
        '
        Me.LblValue2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblValue2.Location = New System.Drawing.Point(12, 276)
        Me.LblValue2.Name = "LblValue2"
        Me.LblValue2.Size = New System.Drawing.Size(28, 16)
        Me.LblValue2.TabIndex = 14
        Me.LblValue2.Text = " 00"
        '
        'VScrollBar2
        '
        Me.VScrollBar2.LargeChange = 1
        Me.VScrollBar2.Location = New System.Drawing.Point(14, 20)
        Me.VScrollBar2.Maximum = 255
        Me.VScrollBar2.Name = "VScrollBar2"
        Me.VScrollBar2.Size = New System.Drawing.Size(16, 252)
        Me.VScrollBar2.TabIndex = 13
        Me.VScrollBar2.Value = 255
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblValue1)
        Me.GroupBox1.Controls.Add(Me.VScrollBar1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(207, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(44, 300)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "AD1"
        '
        'LblValue1
        '
        Me.LblValue1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblValue1.Location = New System.Drawing.Point(12, 276)
        Me.LblValue1.Name = "LblValue1"
        Me.LblValue1.Size = New System.Drawing.Size(28, 16)
        Me.LblValue1.TabIndex = 14
        Me.LblValue1.Text = " 00"
        '
        'VScrollBar1
        '
        Me.VScrollBar1.LargeChange = 1
        Me.VScrollBar1.Location = New System.Drawing.Point(14, 20)
        Me.VScrollBar1.Maximum = 255
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(16, 252)
        Me.VScrollBar1.TabIndex = 13
        Me.VScrollBar1.Value = 255
        '
        'BtnRevenir
        '
        Me.BtnRevenir.Location = New System.Drawing.Point(339, 329)
        Me.BtnRevenir.Name = "BtnRevenir"
        Me.BtnRevenir.Size = New System.Drawing.Size(137, 23)
        Me.BtnRevenir.TabIndex = 35
        Me.BtnRevenir.Text = "Revenir à la selection"
        Me.BtnRevenir.UseVisualStyleBackColor = True
        '
        'Entrees_Analogiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 405)
        Me.Controls.Add(Me.BtnRevenir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Entrees_Analogiques"
        Me.Text = "Entrees_Analogiques"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents LblValue2 As Label
    Friend WithEvents VScrollBar2 As VScrollBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblValue1 As Label
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents BtnRevenir As Button
End Class
