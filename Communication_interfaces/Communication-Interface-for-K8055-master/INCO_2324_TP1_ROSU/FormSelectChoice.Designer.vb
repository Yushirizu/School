<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelectChoice
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
        Me.LblTitre = New System.Windows.Forms.Label()
        Me.rbtEntreeNum = New System.Windows.Forms.RadioButton()
        Me.rbtEntreeAna = New System.Windows.Forms.RadioButton()
        Me.rbtSortieNum = New System.Windows.Forms.RadioButton()
        Me.rbtSortieAna = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnContinuer = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblTitre
        '
        Me.LblTitre.AutoSize = True
        Me.LblTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblTitre.Location = New System.Drawing.Point(64, 9)
        Me.LblTitre.Name = "LblTitre"
        Me.LblTitre.Size = New System.Drawing.Size(426, 31)
        Me.LblTitre.TabIndex = 0
        Me.LblTitre.Text = "Quatre parties de communications"
        '
        'rbtEntreeNum
        '
        Me.rbtEntreeNum.AutoSize = True
        Me.rbtEntreeNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.rbtEntreeNum.Location = New System.Drawing.Point(215, 102)
        Me.rbtEntreeNum.Name = "rbtEntreeNum"
        Me.rbtEntreeNum.Size = New System.Drawing.Size(118, 17)
        Me.rbtEntreeNum.TabIndex = 1
        Me.rbtEntreeNum.TabStop = True
        Me.rbtEntreeNum.Text = "Entrées numériques"
        Me.rbtEntreeNum.UseVisualStyleBackColor = True
        '
        'rbtEntreeAna
        '
        Me.rbtEntreeAna.AutoSize = True
        Me.rbtEntreeAna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.rbtEntreeAna.Location = New System.Drawing.Point(215, 144)
        Me.rbtEntreeAna.Name = "rbtEntreeAna"
        Me.rbtEntreeAna.Size = New System.Drawing.Size(121, 17)
        Me.rbtEntreeAna.TabIndex = 2
        Me.rbtEntreeAna.TabStop = True
        Me.rbtEntreeAna.Text = "Entrées analogiques"
        Me.rbtEntreeAna.UseVisualStyleBackColor = True
        '
        'rbtSortieNum
        '
        Me.rbtSortieNum.AutoSize = True
        Me.rbtSortieNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.rbtSortieNum.Location = New System.Drawing.Point(215, 190)
        Me.rbtSortieNum.Name = "rbtSortieNum"
        Me.rbtSortieNum.Size = New System.Drawing.Size(114, 17)
        Me.rbtSortieNum.TabIndex = 3
        Me.rbtSortieNum.TabStop = True
        Me.rbtSortieNum.Text = "Sorties numériques"
        Me.rbtSortieNum.UseVisualStyleBackColor = True
        '
        'rbtSortieAna
        '
        Me.rbtSortieAna.AutoSize = True
        Me.rbtSortieAna.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.rbtSortieAna.Location = New System.Drawing.Point(215, 232)
        Me.rbtSortieAna.Name = "rbtSortieAna"
        Me.rbtSortieAna.Size = New System.Drawing.Size(117, 17)
        Me.rbtSortieAna.TabIndex = 4
        Me.rbtSortieAna.TabStop = True
        Me.rbtSortieAna.Text = "Sorties analogiques"
        Me.rbtSortieAna.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 44)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Card Address"
        '
        'CheckBox2
        '
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(56, 20)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "SK6"
        '
        'CheckBox1
        '
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(8, 20)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "SK5"
        '
        'BtnConnect
        '
        Me.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConnect.Location = New System.Drawing.Point(35, 125)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(108, 24)
        Me.BtnConnect.TabIndex = 23
        Me.BtnConnect.Text = "Connect"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(35, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "- - -"
        '
        'BtnContinuer
        '
        Me.BtnContinuer.BackColor = System.Drawing.Color.White
        Me.BtnContinuer.Location = New System.Drawing.Point(88, 280)
        Me.BtnContinuer.Name = "BtnContinuer"
        Me.BtnContinuer.Size = New System.Drawing.Size(75, 23)
        Me.BtnContinuer.TabIndex = 25
        Me.BtnContinuer.Text = "Continuer"
        Me.BtnContinuer.UseVisualStyleBackColor = False
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(373, 286)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitter.TabIndex = 26
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'FormSelectChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(525, 362)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnContinuer)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.rbtSortieAna)
        Me.Controls.Add(Me.rbtSortieNum)
        Me.Controls.Add(Me.rbtEntreeAna)
        Me.Controls.Add(Me.rbtEntreeNum)
        Me.Controls.Add(Me.LblTitre)
        Me.Name = "FormSelectChoice"
        Me.Text = "Selection de la partie de communication"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitre As Label
    Friend WithEvents rbtEntreeNum As RadioButton
    Friend WithEvents rbtEntreeAna As RadioButton
    Friend WithEvents rbtSortieNum As RadioButton
    Friend WithEvents rbtSortieAna As RadioButton
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtnConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnContinuer As Button
    Friend WithEvents BtnQuitter As Button
End Class
