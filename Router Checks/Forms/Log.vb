Public Class Log

    'Initiate Varibles
    Dim fileReader As String

    Private Sub Log_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Read all text out of the log file and display on page when it loads.
        fileReader = My.Computer.FileSystem.ReadAllText("Log.txt")
        txtLog.Text = fileReader

    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click

        'Clear all text in log file then reload log file.
        My.Computer.FileSystem.WriteAllText("Log.txt", "", False)
        fileReader = My.Computer.FileSystem.ReadAllText("Log.txt")
        txtLog.Text = fileReader

    End Sub
End Class