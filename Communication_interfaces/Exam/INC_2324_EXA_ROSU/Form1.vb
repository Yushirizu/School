Public Class FrmHome
    Dim mdp As Integer
    Dim j As Integer
    Dim k As Integer
    Dim l As Integer
    Dim start As Boolean
    Dim verif As Integer

    'Importations des librairies
    Public Declare Function OpenDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Public Declare Sub CloseDevice Lib "k8055d.dll" ()
    Public Declare Function Version Lib "k8055d.dll" () As Integer
    Public Declare Function SearchDevices Lib "k8055d.dll" () As Integer
    Public Declare Function SetCurrentDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Public Declare Sub WriteAllDigital Lib "k8055d.dll" (ByVal Data As Integer)
    Public Declare Sub ClearDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Public Declare Sub ClearAllDigital Lib "k8055d.dll" ()
    Public Declare Sub SetDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Public Declare Sub SetAllDigital Lib "k8055d.dll" ()
    Public Declare Function ReadDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Boolean
    Public Declare Function ReadAllDigital Lib "k8055d.dll" () As Integer
    Public Declare Function ReadCounter Lib "k8055d.dll" (ByVal CounterNr As Integer) As Integer
    Public Declare Sub ResetCounter Lib "k8055d.dll" (ByVal CounterNr As Integer)
    Public Declare Sub SetCounterDebounceTime Lib "k8055d.dll" (ByVal CounterNr As Integer, ByVal DebounceTime As Integer)

    'Empêche les charactères autre que lettre et delete de passé (code trouvé de stackoverflow)
    Private Sub TxtBoxLogin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxLogin.KeyPress
        If Char.IsLetter(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Empêche tous les characyères qui ne sont pas des chiffres
    Private Sub TxtBoxMdp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtBoxMdp.KeyPress
        If Char.IsDigit(e.KeyChar) Or e.KeyChar = vbBack Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub FrmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        j = 0
        start = False
        Timer2.Enabled = True
        CmbBoxChiffre1.Visible = False
        CmbBoxChiffre2.Visible = False
        CmbBoxChiffre3.Visible = False
        BtnValidation.Visible = False
    End Sub

    Private Sub FrmHome_Close(sender As Object, e As EventArgs) Handles MyBase.Closed
        ClearAllDigital()
        CloseDevice()
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        ClearAllDigital()
        CloseDevice()
        End
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer
        Timer1.Enabled = False
        i = ReadAllDigital
        CheckBox4.Checked = i And 1
        CheckBox5.Checked = (i >> 1) And 1
        CheckBox6.Checked = (i >> 2) And 1
        CheckBox7.Checked = (i >> 3) And 1
        CheckBox8.Checked = (i >> 4) And 1
        Timer1.Enabled = True
    End Sub

    Private Sub BtnConnexion_Click(sender As Object, e As EventArgs) Handles BtnConnexion.Click
        Dim h As Integer
        Dim CardAddress As Integer
        h = OpenDevice(0)
        'Si la carte est connectée je met le bouton en vert et le focus sur le login
        Select Case h
            Case 0, 1, 2, 3
                Label1.Text = "Card " + Str(h) + " connected"
                BtnConnexion.BackColor = Color.Green
                BtnConnexion.ForeColor = Color.White
                TxtBoxLogin.Focus()
            Case -1
                Label1.Text = "Card " + Str(CardAddress) + " not found"
        End Select
        If h >= 0 Then Timer1.Enabled = True
        ClearAllDigital()
    End Sub

    'J'assigne la selection du chiffre au label au dessus
    Private Sub CmbBoxChiffre1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxChiffre1.SelectedIndexChanged
        LblChiffre1.Text = CmbBoxChiffre1.SelectedItem
    End Sub

    Private Sub CmbBoxChiffre2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxChiffre2.SelectedIndexChanged
        LblChiffre2.Text = CmbBoxChiffre2.SelectedItem
    End Sub

    Private Sub CmbBoxChiffre3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbBoxChiffre3.SelectedIndexChanged
        LblChiffre3.Text = CmbBoxChiffre3.SelectedItem
    End Sub

    'Si le LOGIN est LOGIN et que le mdp est 12345 j'affiche les listes et les chiffres sinon msg box d'erreur
    Private Sub BtnCodeSecret_Click(sender As Object, e As EventArgs) Handles BtnCodeSecret.Click
        If TxtBoxLogin.Text = "LOGIN" And TxtBoxMdp.Text = "12345" Then
            CmbBoxChiffre1.Visible = True
            CmbBoxChiffre2.Visible = True
            CmbBoxChiffre3.Visible = True
            BtnValidation.Visible = True
        Else
            MsgBox("Login ou Mot de passe incorrect", vbCritical, "Erreur")
        End If

    End Sub

    'mon mdp sera un nombre entre 0 et 999
    Private Sub BtnValidation_Click(sender As Object, e As EventArgs) Handles BtnValidation.Click
        mdp = CmbBoxChiffre1.SelectedIndex * 100 + CmbBoxChiffre2.SelectedIndex * 10 + CmbBoxChiffre3.SelectedIndex
        CmbBoxChiffre1.Visible = False
        CmbBoxChiffre2.Visible = False
        CmbBoxChiffre3.Visible = False
        GrpBoxChiffre1.Visible = False
        GrpBoxChiffre2.Visible = False
        GrpBoxChiffre3.Visible = False
        BtnValidation.Visible = False
        LblChiffre1.Text = ""
        LblChiffre2.Text = ""
        LblChiffre3.Text = ""
    End Sub

    'Si j'ai appuyez sur le bouton start j'affiche les chiffres avec 0
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            GrpBoxChiffre1.Visible = True
            GrpBoxChiffre2.Visible = True
            GrpBoxChiffre3.Visible = True
            LblChiffre1.Text = "0"
            LblChiffre2.Text = "0"
            LblChiffre3.Text = "0"
            start = True
        End If
    End Sub

    'Utilisation d'un timer avec un délai plus long pour pouvoir maintenir le bouton
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        'Si j'ai appuyé sur le bouton 1
        If start = True Then
            If ReadDigitalChannel(2) Then
                j += 1
            End If
            If j = 10 Then
                j = 0
            End If
            LblChiffre1.Text = Str(j)

            If ReadDigitalChannel(3) Then
                k += 1
            End If
            If k = 10 Then
                k = 0
            End If
            LblChiffre2.Text = Str(k)

            If ReadDigitalChannel(4) Then
                l += 1
            End If
            If l = 10 Then
                l = 0
            End If
            LblChiffre3.Text = Str(l)
        End If
    End Sub

    'Si le mot de passe est le même que celui entrez par l'utilsateur la LED s'allume en vert et la sortie 1 est activée
    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked = True Then
            verif = LblChiffre1.Text * 100 + LblChiffre2.Text * 10 + LblChiffre3.Text
            If verif = mdp Then
                LED.FillColor = Color.Green
                SetDigitalChannel(1)
            Else
                LED.FillColor = Color.Red
                ClearDigitalChannel(1)
            End If
        End If
    End Sub
End Class
