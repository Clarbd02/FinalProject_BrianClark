Public Class ViewForm
    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MediaTableAdapter.Fill(Me.MediaDataSet.Media)
        PopulateComboBox()

    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        'Checks to make sure an item in the Combo box is selected
        If cmbCategory.SelectedItem = Nothing Then
            errProvider.SetError(cmbCategory, "Select a Category")
            Return
        End If
    End Sub

    Private Function PopulateComboBox()
        cmbCategory.Items.Add("Action")
        cmbCategory.Items.Add("Adventure")
        cmbCategory.Items.Add("Survival Horror")
    End Function

End Class