Public Class Panel
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load LoginCtrl by default
        LoadControl(New RegisterCtrl())
    End Sub

    Public Sub LoadControl(ctrl As UserControl)
        MainPanel.Controls.Clear()
        ctrl.Dock = DockStyle.Fill
        MainPanel.Controls.Add(ctrl)
    End Sub
End Class