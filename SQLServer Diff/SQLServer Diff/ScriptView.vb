Public Class ScriptView
    Private script As String

    Public Sub New(ByVal script As String)
        InitializeComponent()

        Me.script = script

    End Sub

    Private Sub ScriptView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtScript.Text = script
    End Sub
End Class