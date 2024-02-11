Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Entrees_Analogiques
    Private Sub Entrees_Analogiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If h >= 0 Then Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim Data1 As Integer
        Dim Data2 As Integer
        ReadAllAnalog(Data1, Data2)
        VScrollBar1.Value = 255 - Data1
        VScrollBar2.Value = 255 - Data2
        LblValue1.Text = CStr(Data1)
        LblValue2.Text = CStr(Data2)
    End Sub

    Private Sub BtnRevenir_Click(sender As Object, e As EventArgs) Handles BtnRevenir.Click
        Me.Hide()
        FormSelectChoice.Show()
    End Sub
End Class