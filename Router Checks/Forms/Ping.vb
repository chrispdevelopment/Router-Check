Public Class Ping

    Private Sub Ping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiteDetailsDataSet.Details' table. You can move, or remove it, as needed.
        Me.DetailsTableAdapter.Fill(Me.SiteDetailsDataSet.Details)

    End Sub

    Private Sub cmdPing_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPing.Click
        Dim command As String
        command = "Ping " + comboSites.SelectedValue + " -t"
        Shell("cmd.exe /c" & command, AppWinStyle.NormalFocus)
    End Sub
End Class