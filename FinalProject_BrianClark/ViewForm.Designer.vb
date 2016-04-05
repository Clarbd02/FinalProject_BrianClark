<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
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
        Me.radCD = New System.Windows.Forms.RadioButton()
        Me.radDVD = New System.Windows.Forms.RadioButton()
        Me.radVG = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvFormat = New System.Windows.Forms.DataGridView()
        Me.btnView = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCategory = New System.Windows.Forms.ComboBox()
        Me.errProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.MediaDataSet = New FinalProject_BrianClark.MediaDataSet()
        Me.MediaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MediaTableAdapter = New FinalProject_BrianClark.MediaDataSetTableAdapters.MediaTableAdapter()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FormatDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InitialValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReleaseDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MediaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvFormat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MediaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radCD
        '
        Me.radCD.AutoSize = True
        Me.radCD.Location = New System.Drawing.Point(6, 23)
        Me.radCD.Name = "radCD"
        Me.radCD.Size = New System.Drawing.Size(40, 17)
        Me.radCD.TabIndex = 1
        Me.radCD.TabStop = True
        Me.radCD.Text = "CD"
        Me.radCD.UseVisualStyleBackColor = True
        '
        'radDVD
        '
        Me.radDVD.AutoSize = True
        Me.radDVD.Location = New System.Drawing.Point(6, 47)
        Me.radDVD.Name = "radDVD"
        Me.radDVD.Size = New System.Drawing.Size(48, 17)
        Me.radDVD.TabIndex = 2
        Me.radDVD.TabStop = True
        Me.radDVD.Text = "DVD"
        Me.radDVD.UseVisualStyleBackColor = True
        '
        'radVG
        '
        Me.radVG.AutoSize = True
        Me.radVG.Location = New System.Drawing.Point(6, 71)
        Me.radVG.Name = "radVG"
        Me.radVG.Size = New System.Drawing.Size(83, 17)
        Me.radVG.TabIndex = 3
        Me.radVG.TabStop = True
        Me.radVG.Text = "Video Game"
        Me.radVG.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radDVD)
        Me.GroupBox1.Controls.Add(Me.radVG)
        Me.GroupBox1.Controls.Add(Me.radCD)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(145, 100)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "1. Select Format"
        '
        'dgvFormat
        '
        Me.dgvFormat.AutoGenerateColumns = False
        Me.dgvFormat.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvFormat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvFormat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFormat.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TitleDataGridViewTextBoxColumn, Me.FormatDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.InitialValueDataGridViewTextBoxColumn, Me.CurrentValueDataGridViewTextBoxColumn, Me.ReleaseDateDataGridViewTextBoxColumn})
        Me.dgvFormat.DataSource = Me.MediaBindingSource1
        Me.dgvFormat.Location = New System.Drawing.Point(24, 149)
        Me.dgvFormat.Name = "dgvFormat"
        Me.dgvFormat.Size = New System.Drawing.Size(537, 250)
        Me.dgvFormat.TabIndex = 5
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(381, 65)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(156, 40)
        Me.btnView.TabIndex = 20
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbCategory)
        Me.GroupBox2.Location = New System.Drawing.Point(206, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2. Select Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Location = New System.Drawing.Point(5, 43)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategory.TabIndex = 0
        '
        'errProvider
        '
        Me.errProvider.ContainerControl = Me
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
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        '
        'FormatDataGridViewTextBoxColumn
        '
        Me.FormatDataGridViewTextBoxColumn.DataPropertyName = "Format"
        Me.FormatDataGridViewTextBoxColumn.HeaderText = "Format"
        Me.FormatDataGridViewTextBoxColumn.Name = "FormatDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'InitialValueDataGridViewTextBoxColumn
        '
        Me.InitialValueDataGridViewTextBoxColumn.DataPropertyName = "InitialValue"
        Me.InitialValueDataGridViewTextBoxColumn.HeaderText = "InitialValue"
        Me.InitialValueDataGridViewTextBoxColumn.Name = "InitialValueDataGridViewTextBoxColumn"
        '
        'CurrentValueDataGridViewTextBoxColumn
        '
        Me.CurrentValueDataGridViewTextBoxColumn.DataPropertyName = "CurrentValue"
        Me.CurrentValueDataGridViewTextBoxColumn.HeaderText = "CurrentValue"
        Me.CurrentValueDataGridViewTextBoxColumn.Name = "CurrentValueDataGridViewTextBoxColumn"
        '
        'ReleaseDateDataGridViewTextBoxColumn
        '
        Me.ReleaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate"
        Me.ReleaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate"
        Me.ReleaseDateDataGridViewTextBoxColumn.Name = "ReleaseDateDataGridViewTextBoxColumn"
        '
        'MediaBindingSource1
        '
        Me.MediaBindingSource1.DataMember = "Media"
        Me.MediaBindingSource1.DataSource = Me.MediaDataSet
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.dgvFormat)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ViewForm"
        Me.Text = "View Collection!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvFormat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.errProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MediaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radCD As RadioButton
    Friend WithEvents radDVD As RadioButton
    Friend WithEvents radVG As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvFormat As DataGridView
    Friend WithEvents btnView As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cmbCategory As ComboBox
    Friend WithEvents errProvider As ErrorProvider
    Friend WithEvents MediaDataSet As MediaDataSet
    Friend WithEvents MediaBindingSource As BindingSource
    Friend WithEvents MediaTableAdapter As MediaDataSetTableAdapters.MediaTableAdapter
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormatDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InitialValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CurrentValueDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReleaseDateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MediaBindingSource1 As BindingSource
End Class
