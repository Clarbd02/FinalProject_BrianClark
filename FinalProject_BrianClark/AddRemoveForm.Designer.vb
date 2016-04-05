<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRemoveForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtInitialValue = New System.Windows.Forms.TextBox()
        Me.txtCurrentValue = New System.Windows.Forms.TextBox()
        Me.cmbFormat = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpRelease = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lstTitle = New System.Windows.Forms.ListBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MediaDataSet = New FinalProject_BrianClark.MediaDataSet()
        Me.MediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaTableAdapter = New FinalProject_BrianClark.MediaDataSetTableAdapters.MediaTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Format:  (Changes Title List)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 153)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "(Estimated) Current Value:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "(Estimated) Initial Value:"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(153, 67)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(121, 20)
        Me.txtTitle.TabIndex = 2
        '
        'txtInitialValue
        '
        Me.txtInitialValue.Location = New System.Drawing.Point(154, 192)
        Me.txtInitialValue.Name = "txtInitialValue"
        Me.txtInitialValue.Size = New System.Drawing.Size(120, 20)
        Me.txtInitialValue.TabIndex = 5
        '
        'txtCurrentValue
        '
        Me.txtCurrentValue.Location = New System.Drawing.Point(154, 150)
        Me.txtCurrentValue.Name = "txtCurrentValue"
        Me.txtCurrentValue.Size = New System.Drawing.Size(121, 20)
        Me.txtCurrentValue.TabIndex = 4
        '
        'cmbFormat
        '
        Me.cmbFormat.FormattingEnabled = True
        Me.cmbFormat.Location = New System.Drawing.Point(153, 28)
        Me.cmbFormat.Name = "cmbFormat"
        Me.cmbFormat.Size = New System.Drawing.Size(121, 21)
        Me.cmbFormat.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Release Date:"
        '
        'dtpRelease
        '
        Me.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRelease.Location = New System.Drawing.Point(153, 232)
        Me.dtpRelease.Name = "dtpRelease"
        Me.dtpRelease.Size = New System.Drawing.Size(122, 20)
        Me.dtpRelease.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbCategory)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnAdd)
        Me.GroupBox1.Controls.Add(Me.dtpRelease)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbFormat)
        Me.GroupBox1.Controls.Add(Me.txtCurrentValue)
        Me.GroupBox1.Controls.Add(Me.txtInitialValue)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 349)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Information"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(153, 109)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategory.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Category:"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(83, 281)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(135, 40)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Add Item"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lstTitle
        '
        Me.lstTitle.DataSource = Me.MediaBindingSource
        Me.lstTitle.DisplayMember = "Title"
        Me.lstTitle.FormattingEnabled = True
        Me.lstTitle.Location = New System.Drawing.Point(349, 43)
        Me.lstTitle.Name = "lstTitle"
        Me.lstTitle.Size = New System.Drawing.Size(210, 251)
        Me.lstTitle.TabIndex = 20
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 40)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Remove Item"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MediaDataSet
        '
        Me.MediaDataSet.DataSetName = "MediaDataSet"
        Me.MediaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MediaBindingSource
        '
        Me.MediaBindingSource.DataMember = "Media"
        Me.MediaBindingSource.DataSource = Me.MediaDataSet
        '
        'MediaTableAdapter
        '
        Me.MediaTableAdapter.ClearBeforeFill = True
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lstTitle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AddForm"
        Me.Text = "Add or Remove an Item!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtInitialValue As TextBox
    Friend WithEvents txtCurrentValue As TextBox
    Friend WithEvents cmbFormat As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dtpRelease As DateTimePicker
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstTitle As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents MediaDataSet As MediaDataSet
    Friend WithEvents MediaBindingSource As BindingSource
    Friend WithEvents MediaTableAdapter As MediaDataSetTableAdapters.MediaTableAdapter
End Class
