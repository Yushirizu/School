<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmGestion
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
        Me.LblSelecteur = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox6 = New System.Windows.Forms.CheckBox()
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.BtnConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblDetecteurPresence1 = New System.Windows.Forms.Label()
        Me.LblDetecteurPresence2 = New System.Windows.Forms.Label()
        Me.LblDetecteurPresence3 = New System.Windows.Forms.Label()
        Me.LblDetecteurPresence4 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LblGarage = New System.Windows.Forms.Label()
        Me.LblLobby = New System.Windows.Forms.Label()
        Me.LblPorteComW = New System.Windows.Forms.Label()
        Me.LblParkingExit = New System.Windows.Forms.Label()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblSelecteur
        '
        Me.LblSelecteur.AutoSize = True
        Me.LblSelecteur.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblSelecteur.Location = New System.Drawing.Point(9, 68)
        Me.LblSelecteur.Name = "LblSelecteur"
        Me.LblSelecteur.Size = New System.Drawing.Size(66, 13)
        Me.LblSelecteur.TabIndex = 0
        Me.LblSelecteur.Text = "LblSelecteur"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox6)
        Me.GroupBox1.Controls.Add(Me.CheckBox5)
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(108, 44)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Card Address"
        '
        'CheckBox6
        '
        Me.CheckBox6.Checked = True
        Me.CheckBox6.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox6.Location = New System.Drawing.Point(56, 20)
        Me.CheckBox6.Name = "CheckBox6"
        Me.CheckBox6.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox6.TabIndex = 1
        Me.CheckBox6.Text = "SK6"
        '
        'CheckBox5
        '
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Cursor = System.Windows.Forms.Cursors.Default
        Me.CheckBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox5.Location = New System.Drawing.Point(8, 20)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(48, 16)
        Me.CheckBox5.TabIndex = 0
        Me.CheckBox5.Text = "SK5"
        '
        'BtnConnect
        '
        Me.BtnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConnect.Location = New System.Drawing.Point(44, 86)
        Me.BtnConnect.Name = "BtnConnect"
        Me.BtnConnect.Size = New System.Drawing.Size(108, 24)
        Me.BtnConnect.TabIndex = 26
        Me.BtnConnect.Text = "Connect"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(44, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "- - -"
        '
        'Timer1
        '
        Me.Timer1.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(189, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(416, 306)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'LblDetecteurPresence1
        '
        Me.LblDetecteurPresence1.AutoSize = True
        Me.LblDetecteurPresence1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblDetecteurPresence1.Location = New System.Drawing.Point(24, 28)
        Me.LblDetecteurPresence1.Name = "LblDetecteurPresence1"
        Me.LblDetecteurPresence1.Size = New System.Drawing.Size(0, 13)
        Me.LblDetecteurPresence1.TabIndex = 30
        '
        'LblDetecteurPresence2
        '
        Me.LblDetecteurPresence2.AutoSize = True
        Me.LblDetecteurPresence2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblDetecteurPresence2.Location = New System.Drawing.Point(121, 28)
        Me.LblDetecteurPresence2.Name = "LblDetecteurPresence2"
        Me.LblDetecteurPresence2.Size = New System.Drawing.Size(0, 13)
        Me.LblDetecteurPresence2.TabIndex = 31
        '
        'LblDetecteurPresence3
        '
        Me.LblDetecteurPresence3.AutoSize = True
        Me.LblDetecteurPresence3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblDetecteurPresence3.Location = New System.Drawing.Point(218, 28)
        Me.LblDetecteurPresence3.Name = "LblDetecteurPresence3"
        Me.LblDetecteurPresence3.Size = New System.Drawing.Size(0, 13)
        Me.LblDetecteurPresence3.TabIndex = 32
        '
        'LblDetecteurPresence4
        '
        Me.LblDetecteurPresence4.AutoSize = True
        Me.LblDetecteurPresence4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblDetecteurPresence4.Location = New System.Drawing.Point(315, 28)
        Me.LblDetecteurPresence4.Name = "LblDetecteurPresence4"
        Me.LblDetecteurPresence4.Size = New System.Drawing.Size(0, 13)
        Me.LblDetecteurPresence4.TabIndex = 33
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(19, 40)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(87, 17)
        Me.CheckBox1.TabIndex = 34
        Me.CheckBox1.Text = "Porte garage"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox2.Location = New System.Drawing.Point(19, 76)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(79, 17)
        Me.CheckBox2.TabIndex = 35
        Me.CheckBox2.Text = "Porte lobby"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox3.Location = New System.Drawing.Point(19, 112)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(137, 17)
        Me.CheckBox3.TabIndex = 36
        Me.CheckBox3.Text = "Porte commercial exit w"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.CheckBox4.Location = New System.Drawing.Point(19, 148)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(108, 17)
        Me.CheckBox4.TabIndex = 37
        Me.CheckBox4.Text = "Porte parking exit"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckBox4)
        Me.GroupBox2.Controls.Add(Me.CheckBox3)
        Me.GroupBox2.Controls.Add(Me.CheckBox2)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(625, 113)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(163, 181)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fermeture des portes"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LblDetecteurPresence4)
        Me.GroupBox3.Controls.Add(Me.LblDetecteurPresence3)
        Me.GroupBox3.Controls.Add(Me.LblDetecteurPresence2)
        Me.GroupBox3.Controls.Add(Me.LblDetecteurPresence1)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(189, 366)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 62)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Capteur de présence"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LblSelecteur)
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(40, 167)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(89, 133)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selection de la caméra"
        '
        'LblGarage
        '
        Me.LblGarage.AutoSize = True
        Me.LblGarage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblGarage.Location = New System.Drawing.Point(213, 350)
        Me.LblGarage.Name = "LblGarage"
        Me.LblGarage.Size = New System.Drawing.Size(42, 13)
        Me.LblGarage.TabIndex = 41
        Me.LblGarage.Text = "Garage"
        '
        'LblLobby
        '
        Me.LblLobby.AutoSize = True
        Me.LblLobby.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblLobby.Location = New System.Drawing.Point(310, 350)
        Me.LblLobby.Name = "LblLobby"
        Me.LblLobby.Size = New System.Drawing.Size(36, 13)
        Me.LblLobby.TabIndex = 42
        Me.LblLobby.Text = "Lobby"
        '
        'LblPorteComW
        '
        Me.LblPorteComW.AutoSize = True
        Me.LblPorteComW.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblPorteComW.Location = New System.Drawing.Point(380, 350)
        Me.LblPorteComW.Name = "LblPorteComW"
        Me.LblPorteComW.Size = New System.Drawing.Size(103, 13)
        Me.LblPorteComW.TabIndex = 43
        Me.LblPorteComW.Text = "Porte Commercial W"
        '
        'LblParkingExit
        '
        Me.LblParkingExit.AutoSize = True
        Me.LblParkingExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(211, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.LblParkingExit.Location = New System.Drawing.Point(504, 350)
        Me.LblParkingExit.Name = "LblParkingExit"
        Me.LblParkingExit.Size = New System.Drawing.Size(63, 13)
        Me.LblParkingExit.TabIndex = 44
        Me.LblParkingExit.Text = "Parking Exit"
        '
        'BtnQuitter
        '
        Me.BtnQuitter.Location = New System.Drawing.Point(668, 389)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(75, 23)
        Me.BtnQuitter.TabIndex = 45
        Me.BtnQuitter.Text = "Quitter"
        Me.BtnQuitter.UseVisualStyleBackColor = True
        '
        'FrmGestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.LblParkingExit)
        Me.Controls.Add(Me.LblPorteComW)
        Me.Controls.Add(Me.LblLobby)
        Me.Controls.Add(Me.LblGarage)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnConnect)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmGestion"
        Me.Text = "Gestion de caméra"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblSelecteur As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents BtnConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblDetecteurPresence1 As Label
    Friend WithEvents LblDetecteurPresence2 As Label
    Friend WithEvents LblDetecteurPresence3 As Label
    Friend WithEvents LblDetecteurPresence4 As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents LblGarage As Label
    Friend WithEvents LblLobby As Label
    Friend WithEvents LblPorteComW As Label
    Friend WithEvents LblParkingExit As Label
    Friend WithEvents BtnQuitter As Button
End Class
