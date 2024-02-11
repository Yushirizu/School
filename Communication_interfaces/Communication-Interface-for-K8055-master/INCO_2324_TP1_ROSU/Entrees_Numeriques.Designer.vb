<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Entrees_Numeriques
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnRevenir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox3)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(147, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(172, 40)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inputs"
        '
        'CheckBox5
        '
        Me.CheckBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox5.Location = New System.Drawing.Point(134, 17)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(26, 15)
        Me.CheckBox5.TabIndex = 4
        Me.CheckBox5.Text = "5"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox4.Location = New System.Drawing.Point(102, 17)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(26, 15)
        Me.CheckBox4.TabIndex = 3
        Me.CheckBox4.Text = "4"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox3.Location = New System.Drawing.Point(70, 17)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(26, 15)
        Me.CheckBox3.TabIndex = 2
        Me.CheckBox3.Text = "3"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(38, 17)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(26, 15)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "2"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(6, 17)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(26, 15)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'BtnRevenir
        '
        Me.BtnRevenir.Location = New System.Drawing.Point(331, 161)
        Me.BtnRevenir.Name = "BtnRevenir"
        Me.BtnRevenir.Size = New System.Drawing.Size(137, 23)
        Me.BtnRevenir.TabIndex = 19
        Me.BtnRevenir.Text = "Revenir à la selection"
        Me.BtnRevenir.UseVisualStyleBackColor = True
        '
        'Entrees_Numeriques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(512, 235)
        Me.Controls.Add(Me.BtnRevenir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Entrees_Numeriques"
        Me.Text = "Entrees_Numeriques"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnRevenir As Button
End Class
