<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MainPanel = New System.Windows.Forms.Panel()
        SuspendLayout()
        ' 
        ' MainPanel
        ' 
        MainPanel.Location = New Point(0, 0)
        MainPanel.Name = "MainPanel"
        MainPanel.Size = New Size(800, 450)
        MainPanel.TabIndex = 0
        ' 
        ' Panel
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(MainPanel)
        Name = "Panel"
        Text = "App"
        ResumeLayout(False)
    End Sub

    Friend WithEvents MainPanel As System.Windows.Forms.Panel
End Class
