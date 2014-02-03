Public Class Modify

    Private Sub UpdateBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateBindingNavigatorSaveItem.Click
        Me.Cursor = Cursors.WaitCursor
        Me.Validate()
        Me.UpdateBindingSource.EndEdit()
        Me.UpdateTableAdapter.Update(Me.SiteDetailsDataSet.Update)
        Main.dataBpull()
        Main.ArrayFill()
        Main.IPCheck()
        Main.FlowLayoutPanel1.Controls.Clear()
        Main.FormLayout()
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub Modify_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SiteDetailsDataSet.Update' table. You can move, or remove it, as needed.
        Me.UpdateTableAdapter.FillUpdate(Me.SiteDetailsDataSet.Update)

    End Sub
End Class