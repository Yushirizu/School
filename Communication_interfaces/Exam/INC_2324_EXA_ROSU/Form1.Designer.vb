<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtBoxLogin = New System.Windows.Forms.TextBox()
        Me.TxtBoxMdp = New System.Windows.Forms.TextBox()
        Me.LblLogin = New System.Windows.Forms.Label()
        Me.LblMdp = New System.Windows.Forms.Label()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox7 = New System.Windows.Forms.CheckBox()
        Me.CheckBox8 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CmbBoxChiffre1 = New System.Windows.Forms.ComboBox()
        Me.CmbBoxChiffre2 = New System.Windows.Forms.ComboBox()
        Me.CmbBoxChiffre3 = New System.Windows.Forms.ComboBox()
        Me.LblChiffre1 = New System.Windows.Forms.Label()
        Me.GrpBoxChiffre1 = New System.Windows.Forms.GroupBox()
        Me.GrpBoxChiffre2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LblChiffre2 = New System.Windows.Forms.Label()
        Me.GrpBoxChiffre3 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblChiffre3 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LED = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.BtnValidation = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnConnexion = New System.Windows.Forms.Button()
        Me.BtnCodeSecret = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxChiffre1.SuspendLayout()
        Me.GrpBoxChiffre2.SuspendLayout()
        Me.GrpBoxChiffre3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 24
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(153, 37)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(118, 26)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        '
        'TxtBoxLogin
        '
        Me.TxtBoxLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBoxLogin.Location = New System.Drawing.Point(558, 40)
        Me.TxtBoxLogin.MaxLength = 5
        Me.TxtBoxLogin.Name = "TxtBoxLogin"
        Me.TxtBoxLogin.Size = New System.Drawing.Size(107, 20)
        Me.TxtBoxLogin.TabIndex = 27
        '
        'TxtBoxMdp
        '
        Me.TxtBoxMdp.Location = New System.Drawing.Point(558, 81)
        Me.TxtBoxMdp.MaxLength = 5
        Me.TxtBoxMdp.Name = "TxtBoxMdp"
        Me.TxtBoxMdp.Size = New System.Drawing.Size(107, 20)
        Me.TxtBoxMdp.TabIndex = 28
        Me.TxtBoxMdp.UseSystemPasswordChar = True
        '
        'LblLogin
        '
        Me.LblLogin.AutoSize = True
        Me.LblLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLogin.Location = New System.Drawing.Point(488, 38)
        Me.LblLogin.Name = "LblLogin"
        Me.LblLogin.Size = New System.Drawing.Size(53, 20)
        Me.LblLogin.TabIndex = 29
        Me.LblLogin.Text = "Login"
        '
        'LblMdp
        '
        Me.LblMdp.AutoSize = True
        Me.LblMdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMdp.Location = New System.Drawing.Point(424, 79)
        Me.LblMdp.Name = "LblMdp"
        Me.LblMdp.Size = New System.Drawing.Size(117, 20)
        Me.LblMdp.TabIndex = 30
        Me.LblMdp.Text = "Mot de passe"
        '
        'CheckBox4
        '
        Me.CheckBox4.Location = New System.Drawing.Point(6, 65)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(71, 20)
        Me.CheckBox4.TabIndex = 0
        Me.CheckBox4.Text = "START"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.Location = New System.Drawing.Point(6, 91)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(71, 20)
        Me.CheckBox5.TabIndex = 1
        Me.CheckBox5.Text = "Chiffre 1"
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'CheckBox6
        '
        Me.CheckBox6.Location = New System.Drawing.Point(6, 117)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(71, 20)
        Me.CheckBox6.TabIndex = 2
        Me.CheckBox6.Text = "Chiffre 2"
        Me.CheckBox6.UseVisualStyleBackColor = True
        '
        'CheckBox7
        '
        Me.CheckBox7.Location = New System.Drawing.Point(6, 143)
        Me.CheckBox7.Name = "CheckBox7"
        Me.CheckBox7.Size = New System.Drawing.Size(71, 20)
        Me.CheckBox7.TabIndex = 3
        Me.CheckBox7.Text = "Chiffre 3"
        Me.CheckBox7.UseVisualStyleBackColor = True
        '
        'CheckBox8
        '
        Me.CheckBox8.Location = New System.Drawing.Point(6, 169)
        Me.CheckBox8.Name = "CheckBox8"
        Me.CheckBox8.Size = New System.Drawing.Size(96, 18)
        Me.CheckBox8.TabIndex = 4
        Me.CheckBox8.Text = "Vérification"
        Me.CheckBox8.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox8)
        Me.GroupBox1.Controls.Add(Me.CheckBox4)
        Me.GroupBox1.Controls.Add(Me.CheckBox7)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 84)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 216)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Entrées Numériques"
        '
        'CmbBoxChiffre1
        '
        Me.CmbBoxChiffre1.FormattingEnabled = True
        Me.CmbBoxChiffre1.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CmbBoxChiffre1.Location = New System.Drawing.Point(177, 271)
        Me.CmbBoxChiffre1.Name = "CmbBoxChiffre1"
        Me.CmbBoxChiffre1.Size = New System.Drawing.Size(80, 21)
        Me.CmbBoxChiffre1.TabIndex = 31
        '
        'CmbBoxChiffre2
        '
        Me.CmbBoxChiffre2.FormattingEnabled = True
        Me.CmbBoxChiffre2.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CmbBoxChiffre2.Location = New System.Drawing.Point(297, 271)
        Me.CmbBoxChiffre2.Name = "CmbBoxChiffre2"
        Me.CmbBoxChiffre2.Size = New System.Drawing.Size(80, 21)
        Me.CmbBoxChiffre2.TabIndex = 32
        '
        'CmbBoxChiffre3
        '
        Me.CmbBoxChiffre3.FormattingEnabled = True
        Me.CmbBoxChiffre3.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"})
        Me.CmbBoxChiffre3.Location = New System.Drawing.Point(417, 271)
        Me.CmbBoxChiffre3.Name = "CmbBoxChiffre3"
        Me.CmbBoxChiffre3.Size = New System.Drawing.Size(80, 21)
        Me.CmbBoxChiffre3.TabIndex = 33
        '
        'LblChiffre1
        '
        Me.LblChiffre1.AutoSize = True
        Me.LblChiffre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChiffre1.Location = New System.Drawing.Point(23, 42)
        Me.LblChiffre1.Name = "LblChiffre1"
        Me.LblChiffre1.Size = New System.Drawing.Size(0, 39)
        Me.LblChiffre1.TabIndex = 34
        '
        'GrpBoxChiffre1
        '
        Me.GrpBoxChiffre1.Controls.Add(Me.LblChiffre1)
        Me.GrpBoxChiffre1.Location = New System.Drawing.Point(177, 135)
        Me.GrpBoxChiffre1.Name = "GrpBoxChiffre1"
        Me.GrpBoxChiffre1.Size = New System.Drawing.Size(80, 112)
        Me.GrpBoxChiffre1.TabIndex = 35
        Me.GrpBoxChiffre1.TabStop = False
        '
        'GrpBoxChiffre2
        '
        Me.GrpBoxChiffre2.Controls.Add(Me.Label4)
        Me.GrpBoxChiffre2.Controls.Add(Me.LblChiffre2)
        Me.GrpBoxChiffre2.Location = New System.Drawing.Point(297, 135)
        Me.GrpBoxChiffre2.Name = "GrpBoxChiffre2"
        Me.GrpBoxChiffre2.Size = New System.Drawing.Size(80, 112)
        Me.GrpBoxChiffre2.TabIndex = 36
        Me.GrpBoxChiffre2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 39)
        Me.Label4.TabIndex = 35
        '
        'LblChiffre2
        '
        Me.LblChiffre2.AutoSize = True
        Me.LblChiffre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChiffre2.Location = New System.Drawing.Point(23, 42)
        Me.LblChiffre2.Name = "LblChiffre2"
        Me.LblChiffre2.Size = New System.Drawing.Size(0, 39)
        Me.LblChiffre2.TabIndex = 34
        '
        'GrpBoxChiffre3
        '
        Me.GrpBoxChiffre3.Controls.Add(Me.Label5)
        Me.GrpBoxChiffre3.Controls.Add(Me.LblChiffre3)
        Me.GrpBoxChiffre3.Location = New System.Drawing.Point(417, 135)
        Me.GrpBoxChiffre3.Name = "GrpBoxChiffre3"
        Me.GrpBoxChiffre3.Size = New System.Drawing.Size(80, 112)
        Me.GrpBoxChiffre3.TabIndex = 37
        Me.GrpBoxChiffre3.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 39)
        Me.Label5.TabIndex = 36
        '
        'LblChiffre3
        '
        Me.LblChiffre3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LblChiffre3.AutoSize = True
        Me.LblChiffre3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChiffre3.Location = New System.Drawing.Point(23, 42)
        Me.LblChiffre3.Name = "LblChiffre3"
        Me.LblChiffre3.Size = New System.Drawing.Size(0, 39)
        Me.LblChiffre3.TabIndex = 34
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LED})
        Me.ShapeContainer1.Size = New System.Drawing.Size(690, 311)
        Me.ShapeContainer1.TabIndex = 39
        Me.ShapeContainer1.TabStop = False
        '
        'LED
        '
        Me.LED.FillColor = System.Drawing.Color.White
        Me.LED.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
        Me.LED.Location = New System.Drawing.Point(585, 169)
        Me.LED.Name = "LED"
        Me.LED.Size = New System.Drawing.Size(48, 48)
        '
        'BtnValidation
        '
        Me.BtnValidation.Location = New System.Drawing.Point(569, 239)
        Me.BtnValidation.Name = "BtnValidation"
        Me.BtnValidation.Size = New System.Drawing.Size(83, 19)
        Me.BtnValidation.TabIndex = 40
        Me.BtnValidation.Text = "Validation"
        Me.BtnValidation.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        Me.Timer2.Interval = 200
        '
        'BtnConnexion
        '
        Me.BtnConnexion.Location = New System.Drawing.Point(30, 40)
        Me.BtnConnexion.Name = "BtnConnexion"
        Me.BtnConnexion.Size = New System.Drawing.Size(96, 23)
        Me.BtnConnexion.TabIndex = 42
        Me.BtnConnexion.Text = "Connexion"
        Me.BtnConnexion.UseVisualStyleBackColor = True
        '
        'BtnCodeSecret
        '
        Me.BtnCodeSecret.Location = New System.Drawing.Point(558, 117)
        Me.BtnCodeSecret.Name = "BtnCodeSecret"
        Me.BtnCodeSecret.Size = New System.Drawing.Size(107, 23)
        Me.BtnCodeSecret.TabIndex = 43
        Me.BtnCodeSecret.Text = "Code secret"
        Me.BtnCodeSecret.UseVisualStyleBackColor = True
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(569, 279)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(83, 21)
        Me.BtnQuitter.TabIndex = 44
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 311)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnCodeSecret)
        Me.Controls.Add(Me.BtnConnexion)
        Me.Controls.Add(Me.BtnValidation)
        Me.Controls.Add(Me.GrpBoxChiffre3)
        Me.Controls.Add(Me.GrpBoxChiffre2)
        Me.Controls.Add(Me.GrpBoxChiffre1)
        Me.Controls.Add(Me.CmbBoxChiffre3)
        Me.Controls.Add(Me.CmbBoxChiffre2)
        Me.Controls.Add(Me.CmbBoxChiffre1)
        Me.Controls.Add(Me.LblMdp)
        Me.Controls.Add(Me.LblLogin)
        Me.Controls.Add(Me.TxtBoxMdp)
        Me.Controls.Add(Me.TxtBoxLogin)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Le coffre-fort"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpBoxChiffre1.ResumeLayout(False)
        Me.GrpBoxChiffre1.PerformLayout()
        Me.GrpBoxChiffre2.ResumeLayout(False)
        Me.GrpBoxChiffre2.PerformLayout()
        Me.GrpBoxChiffre3.ResumeLayout(False)
        Me.GrpBoxChiffre3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TxtBoxLogin As TextBox
    Friend WithEvents TxtBoxMdp As TextBox
    Friend WithEvents LblLogin As Label
    Friend WithEvents LblMdp As Label
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CmbBoxChiffre1 As ComboBox
    Friend WithEvents CmbBoxChiffre2 As ComboBox
    Friend WithEvents CmbBoxChiffre3 As ComboBox
    Friend WithEvents LblChiffre1 As Label
    Friend WithEvents GrpBoxChiffre1 As GroupBox
    Friend WithEvents GrpBoxChiffre2 As GroupBox
    Friend WithEvents LblChiffre2 As Label
    Friend WithEvents GrpBoxChiffre3 As GroupBox
    Friend WithEvents LblChiffre3 As Label
    Friend WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents LED As PowerPacks.OvalShape
    Friend WithEvents BtnValidation As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Timer2 As Timer
    Friend WithEvents BtnConnexion As Button
    Friend WithEvents BtnCodeSecret As Button
    Friend WithEvents BtnQuitter As Button
End Class
