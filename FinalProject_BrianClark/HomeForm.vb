'Name:      Brian Clark
'Project:   Final - Check 1
'Date:      4/3/2016
'Purpose:   To create an application will be used to collect, organize, and list data on the user’s media collection.


Public Class HomeForm

    Public listMedia As New List(Of Media)
    Private Sub mnuAddItem_Click_1(sender As Object, e As EventArgs) Handles mnuAddItem.Click
        AddRemoveForm.ShowDialog()

    End Sub

    Private Sub mnuViewCollection_Click_1(sender As Object, e As EventArgs) Handles mnuViewCollection.Click
        ViewForm.ShowDialog()
    End Sub

    Private Sub mnuOverview_Click_1(sender As Object, e As EventArgs) Handles mnuOverview.Click
        OverviewForm.ShowDialog()
    End Sub
End Class
