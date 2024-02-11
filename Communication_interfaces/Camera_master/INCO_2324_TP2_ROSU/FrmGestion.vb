Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class FrmGestion
    Private checkBoxes As New List(Of CheckBox)
    Private Sub FrmGestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkBoxes.Add(Me.CheckBox1)
        checkBoxes.Add(Me.CheckBox2)
        checkBoxes.Add(Me.CheckBox3)
        checkBoxes.Add(Me.CheckBox4)
        For Each checkBox In checkBoxes
            AddHandler checkBox.CheckedChanged, AddressOf ChangeOutputState
        Next

        If h >= 0 Then Timer1.Enabled = True
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        Dim CardAddress As Integer
        Dim h As Integer
        CardAddress = 3
        If CheckBox5.Checked Then CardAddress = CardAddress - 1
        If CheckBox6.Checked Then CardAddress = CardAddress - 2
        h = OpenDevice(CardAddress)
        Select Case h
            Case 0, 1, 2, 3
                Label1.Text = "Card " + Str(h) + " connected"
            Case -1
                Label1.Text = "Card " + Str(CardAddress) + " not found"
        End Select
        If h >= 0 Then Timer1.Enabled = True
        Module1.h = h
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim ValSelecteur As Integer
        ValSelecteur = ReadAnalogChannel(1) / 64
        LblSelecteur.Text = ValSelecteur
        Select Case ValSelecteur
            Case 0
                PictureBox1.Image = My.Resources.gate
            Case 1
                PictureBox1.Image = My.Resources.lobby
            Case 2
                PictureBox1.Image = My.Resources.commercialexitw
            Case 3
                PictureBox1.Image = My.Resources.parkingexit
        End Select

        'Detecteur de presence avec les boutons
        Dim labels As Label() = {LblDetecteurPresence1, LblDetecteurPresence2, LblDetecteurPresence3, LblDetecteurPresence4}
        Dim images As Image() = {My.Resources.gate, My.Resources.lobby, My.Resources.commercialexitw, My.Resources.parkingexit}

        For i As Integer = 0 To 3
            If ReadDigitalChannel(i + 1) Then
                labels(i).Text = "Presence"
                PictureBox1.Image = images(i)
            Else
                labels(i).Text = "Pas de presence"
            End If
        Next
    End Sub

    Private Sub ChangeOutputState(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim checkBox As CheckBox = CType(sender, CheckBox)
        Dim channel As Integer = checkBoxes.IndexOf(checkBox) + 1

        If checkBox.Checked Then
            SetDigitalChannel(channel)
        Else
            ClearDigitalChannel(channel)
        End If
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        CloseDevice()
        End
    End Sub
End Class
