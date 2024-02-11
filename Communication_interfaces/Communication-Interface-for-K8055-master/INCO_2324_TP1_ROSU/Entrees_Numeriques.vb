Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Entrees_Numeriques
    Private Sub Entrees_Numeriques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If h >= 0 Then Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i As Integer
        i = ReadAllDigital
        CheckBox1.Checked = i And 1
        CheckBox2.Checked = (i >> 1) And 1
        CheckBox3.Checked = (i >> 2) And 1
        CheckBox4.Checked = (i >> 3) And 1
        CheckBox5.Checked = (i >> 4) And 1
    End Sub

    Private Sub BtnRevenir_Click(sender As Object, e As EventArgs) Handles BtnRevenir.Click
        Me.Hide()
        FormSelectChoice.Show()
    End Sub
End Class