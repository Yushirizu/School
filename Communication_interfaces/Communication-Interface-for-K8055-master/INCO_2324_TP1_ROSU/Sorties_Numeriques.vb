Public Class Sorties_Numeriques
    Private checkBoxes As New List(Of CheckBox)

    Private Sub Sorties_Numeriques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkBoxes.Add(Me.CheckBox1)
        checkBoxes.Add(Me.CheckBox2)
        checkBoxes.Add(Me.CheckBox3)
        checkBoxes.Add(Me.CheckBox4)
        checkBoxes.Add(Me.CheckBox5)
        checkBoxes.Add(Me.CheckBox6)
        checkBoxes.Add(Me.CheckBox7)
        checkBoxes.Add(Me.CheckBox8)

        For Each checkBox In checkBoxes
            AddHandler checkBox.CheckedChanged, AddressOf ChangeOutputState
        Next

        If h >= 0 Then Timer1.Enabled = True
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

    Private Sub BtnRevenir_Click(sender As Object, e As EventArgs) Handles BtnRevenir.Click
        Me.Hide()
        FormSelectChoice.Show()
    End Sub
End Class