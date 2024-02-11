Public Class Sorties_Analogiques
    Private Sub Sorties_Analogiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If h >= 0 Then Timer1.Enabled = True
    End Sub

    Private Sub VScrollBar1_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar1.Scroll
        Dim Value As Integer = 255 - VScrollBar1.Value
        LblValue1.Text = CStr(Value)
        OutputAnalogChannel(1, Value)
    End Sub

    Private Sub VScrollBar2_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles VScrollBar2.Scroll
        Dim Value As Integer = 255 - VScrollBar2.Value
        LblValue2.Text = CStr(Value)
        OutputAnalogChannel(2, Value)
    End Sub

    Private Sub BtnRevenir_Click(sender As Object, e As EventArgs) Handles BtnRevenir.Click
        Me.Hide()
        FormSelectChoice.Show()
    End Sub
End Class