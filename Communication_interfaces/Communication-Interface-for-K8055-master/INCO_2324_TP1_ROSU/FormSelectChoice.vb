Public Class FormSelectChoice
    Private Sub FormSelectChoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbtEntreeAna.Checked = False
        rbtEntreeNum.Checked = False
        rbtSortieAna.Checked = False
        rbtSortieNum.Checked = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConnect.Click
        Dim CardAddress As Integer
        Dim h As Integer
        CardAddress = 3
        If CheckBox1.Checked Then CardAddress = CardAddress - 1
        If CheckBox2.Checked Then CardAddress = CardAddress - 2
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

    Private Sub BtnContinuer_Click(sender As Object, e As EventArgs) Handles BtnContinuer.Click
        If rbtEntreeAna.Checked = False And rbtEntreeNum.Checked = False And rbtSortieAna.Checked = False And rbtSortieNum.Checked = False Then
            MsgBox("Vous devez sélectionner une option", vbCritical, "Erreur!")
        ElseIf (rbtEntreeAna.Checked = True) Then
            Entrees_Analogiques.Show()
            Me.Hide()
        ElseIf (rbtEntreeNum.Checked = True) Then
            Entrees_Numeriques.Show()
            Me.Hide()
        ElseIf (rbtSortieAna.Checked = True) Then
            Sorties_Analogiques.Show()
            Me.Hide()
        ElseIf (rbtSortieNum.Checked = True) Then
            Sorties_Numeriques.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub BtnQuitter_Click(sender As Object, e As EventArgs) Handles BtnQuitter.Click
        CloseDevice()
        End
    End Sub

End Class
