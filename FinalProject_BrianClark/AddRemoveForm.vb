Public Class AddRemoveForm

    Private Sub AddRemoveForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MediaTableAdapter.Fill(Me.MediaDataSet.Media)
        Me.MediaBindingSource.AddNew()
        PopulateComboBox()

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        errProvider.Clear()

        'Checks to make sure an item in the Combo box is selected
        If cmbFormat.SelectedItem = Nothing Then
            errProvider.SetError(cmbFormat, "Select a Format")
            Return
        End If
        'Checks to make sure the Title text box is not blank
        If txtTitle.Text = Nothing Then
            errProvider.SetError(txtTitle, "Enter a Title")
            Return
        End If
        'Checks to make sure an item in the Combo box is selected
        If cmbCategory.SelectedItem = Nothing Then
            errProvider.SetError(cmbCategory, "Select a Category")
            Return
        End If
        'Checks for numeric values in the Current Value and  text boxes.
        Dim number As Integer
        If Not Integer.TryParse(txtCurrentValue.Text, number) Then
            errProvider.SetError(txtCurrentValue, "Enter a Number")
            Return
        End If
        If Not Integer.TryParse(txtInitialValue.Text, number) Then
            errProvider.SetError(txtInitialValue, "Enter a Number")
            Return
        End If
        'Inserts a new media item.
        Dim currItem As New Media(txtTitle.Text, cmbFormat.SelectedItem, cmbCategory.SelectedItem, CDbl(txtInitialValue.Text), CDbl(txtCurrentValue.Text), CDate(dtpRelease.Text))
        HomeForm.listMedia.Add(currItem)
        'Try
        'MediaTableAdapter.Insert(txtTitle.Text, cmbFormat.SelectedItem, cmbCategory.SelectedItem, CDbl(txtInitialValue.Text), CDbl(txtCurrentValue.Text), CDate(dtpRelease.Text))
        'Me.MediaTableAdapter.Fill(Me.MediaDataSet.NewMedia)
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "Database Error")
        'End Try
        txtTitle.Text = ""
        txtCurrentValue.Text = ""
        txtInitialValue.Text = ""
        cmbCategory.SelectedItem = Nothing
        cmbFormat.SelectedItem = Nothing
    End Sub

    Private Function PopulateComboBox()

        cmbFormat.Items.Add("CD")
        cmbFormat.Items.Add("DVD")
        cmbFormat.Items.Add("Video Game")

        cmbCategory.Items.Add("Action")
        cmbCategory.Items.Add("Adventure")
        cmbCategory.Items.Add("Survival Horror")

    End Function

End Class