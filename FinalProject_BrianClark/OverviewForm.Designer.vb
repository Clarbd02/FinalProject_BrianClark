<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OverviewForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCDRareTotal = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblCDCurrentValue = New System.Windows.Forms.Label()
        Me.lblCDInitialValue = New System.Windows.Forms.Label()
        Me.lblCDTotalCount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblRareVGValue = New System.Windows.Forms.Label()
        Me.lblVGCurrentValue = New System.Windows.Forms.Label()
        Me.lblVGTotalCount = New System.Windows.Forms.Label()
        Me.lblVGInitialValue = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblDVDTotalCount = New System.Windows.Forms.Label()
        Me.lblDVDCurrentValue = New System.Windows.Forms.Label()
        Me.lblDVDInitialValue = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblRareCollectionValue = New System.Windows.Forms.Label()
        Me.lblTotalMediaCount = New System.Windows.Forms.Label()
        Me.lblTotalCurrentValue = New System.Windows.Forms.Label()
        Me.lblTotalInitialValue = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lblCDRareTotal)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblCDCurrentValue)
        Me.GroupBox1.Controls.Add(Me.lblCDInitialValue)
        Me.GroupBox1.Controls.Add(Me.lblCDTotalCount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(25, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(257, 168)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CD Totals"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Total CD Count:"
        '
        'lblCDRareTotal
        '
        Me.lblCDRareTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCDRareTotal.Location = New System.Drawing.Point(151, 118)
        Me.lblCDRareTotal.Name = "lblCDRareTotal"
        Me.lblCDRareTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblCDRareTotal.TabIndex = 19
        Me.lblCDRareTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Rare CDs Value:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(129, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "(Estimated) Current Value:"
        '
        'lblCDCurrentValue
        '
        Me.lblCDCurrentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCDCurrentValue.Location = New System.Drawing.Point(151, 88)
        Me.lblCDCurrentValue.Name = "lblCDCurrentValue"
        Me.lblCDCurrentValue.Size = New System.Drawing.Size(100, 23)
        Me.lblCDCurrentValue.TabIndex = 16
        Me.lblCDCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCDInitialValue
        '
        Me.lblCDInitialValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCDInitialValue.Location = New System.Drawing.Point(151, 58)
        Me.lblCDInitialValue.Name = "lblCDInitialValue"
        Me.lblCDInitialValue.Size = New System.Drawing.Size(100, 23)
        Me.lblCDInitialValue.TabIndex = 15
        Me.lblCDInitialValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCDTotalCount
        '
        Me.lblCDTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCDTotalCount.Location = New System.Drawing.Point(151, 28)
        Me.lblCDTotalCount.Name = "lblCDTotalCount"
        Me.lblCDTotalCount.Size = New System.Drawing.Size(100, 23)
        Me.lblCDTotalCount.TabIndex = 14
        Me.lblCDTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "(Estimated) Initial Value:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblRareVGValue)
        Me.GroupBox2.Controls.Add(Me.lblVGCurrentValue)
        Me.GroupBox2.Controls.Add(Me.lblVGTotalCount)
        Me.GroupBox2.Controls.Add(Me.lblVGInitialValue)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(25, 228)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(257, 168)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Video Game Totals"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Total Video Game Count:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Rare Video Games Value:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 95)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "(Estimated) Current Value:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "(Estimated) Initial Value:"
        '
        'lblRareVGValue
        '
        Me.lblRareVGValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRareVGValue.Location = New System.Drawing.Point(151, 120)
        Me.lblRareVGValue.Name = "lblRareVGValue"
        Me.lblRareVGValue.Size = New System.Drawing.Size(100, 23)
        Me.lblRareVGValue.TabIndex = 35
        Me.lblRareVGValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVGCurrentValue
        '
        Me.lblVGCurrentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVGCurrentValue.Location = New System.Drawing.Point(151, 90)
        Me.lblVGCurrentValue.Name = "lblVGCurrentValue"
        Me.lblVGCurrentValue.Size = New System.Drawing.Size(100, 23)
        Me.lblVGCurrentValue.TabIndex = 32
        Me.lblVGCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVGTotalCount
        '
        Me.lblVGTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVGTotalCount.Location = New System.Drawing.Point(151, 30)
        Me.lblVGTotalCount.Name = "lblVGTotalCount"
        Me.lblVGTotalCount.Size = New System.Drawing.Size(100, 23)
        Me.lblVGTotalCount.TabIndex = 30
        Me.lblVGTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVGInitialValue
        '
        Me.lblVGInitialValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblVGInitialValue.Location = New System.Drawing.Point(151, 60)
        Me.lblVGInitialValue.Name = "lblVGInitialValue"
        Me.lblVGInitialValue.Size = New System.Drawing.Size(100, 23)
        Me.lblVGInitialValue.TabIndex = 31
        Me.lblVGInitialValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblDVDTotalCount)
        Me.GroupBox3.Controls.Add(Me.lblDVDCurrentValue)
        Me.GroupBox3.Controls.Add(Me.lblDVDInitialValue)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(302, 39)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 168)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "DVD Totals"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(151, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 27
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 13)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "(Estimated) Initial Value:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(94, 13)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Rare DVDs Value:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 33)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Total DVD Count"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 93)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(129, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "(Estimated) Current Value:"
        '
        'lblDVDTotalCount
        '
        Me.lblDVDTotalCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDVDTotalCount.Location = New System.Drawing.Point(151, 28)
        Me.lblDVDTotalCount.Name = "lblDVDTotalCount"
        Me.lblDVDTotalCount.Size = New System.Drawing.Size(100, 23)
        Me.lblDVDTotalCount.TabIndex = 22
        Me.lblDVDTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDVDCurrentValue
        '
        Me.lblDVDCurrentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDVDCurrentValue.Location = New System.Drawing.Point(151, 88)
        Me.lblDVDCurrentValue.Name = "lblDVDCurrentValue"
        Me.lblDVDCurrentValue.Size = New System.Drawing.Size(100, 23)
        Me.lblDVDCurrentValue.TabIndex = 24
        Me.lblDVDCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDVDInitialValue
        '
        Me.lblDVDInitialValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDVDInitialValue.Location = New System.Drawing.Point(151, 58)
        Me.lblDVDInitialValue.Name = "lblDVDInitialValue"
        Me.lblDVDInitialValue.Size = New System.Drawing.Size(100, 23)
        Me.lblDVDInitialValue.TabIndex = 23
        Me.lblDVDInitialValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.lblRareCollectionValue)
        Me.GroupBox4.Controls.Add(Me.lblTotalMediaCount)
        Me.GroupBox4.Controls.Add(Me.lblTotalCurrentValue)
        Me.GroupBox4.Controls.Add(Me.lblTotalInitialValue)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(302, 228)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(257, 168)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Overall Totals"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Total Media Count:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 13)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "Rare Collection Value:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(6, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(129, 13)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "(Estimated) Current Value:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 65)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(119, 13)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "(Estimated) Initial Value:"
        '
        'lblRareCollectionValue
        '
        Me.lblRareCollectionValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRareCollectionValue.Location = New System.Drawing.Point(151, 120)
        Me.lblRareCollectionValue.Name = "lblRareCollectionValue"
        Me.lblRareCollectionValue.Size = New System.Drawing.Size(100, 23)
        Me.lblRareCollectionValue.TabIndex = 43
        Me.lblRareCollectionValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalMediaCount
        '
        Me.lblTotalMediaCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalMediaCount.Location = New System.Drawing.Point(151, 30)
        Me.lblTotalMediaCount.Name = "lblTotalMediaCount"
        Me.lblTotalMediaCount.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalMediaCount.TabIndex = 38
        Me.lblTotalMediaCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalCurrentValue
        '
        Me.lblTotalCurrentValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalCurrentValue.Location = New System.Drawing.Point(151, 90)
        Me.lblTotalCurrentValue.Name = "lblTotalCurrentValue"
        Me.lblTotalCurrentValue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalCurrentValue.TabIndex = 40
        Me.lblTotalCurrentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTotalInitialValue
        '
        Me.lblTotalInitialValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalInitialValue.Location = New System.Drawing.Point(151, 60)
        Me.lblTotalInitialValue.Name = "lblTotalInitialValue"
        Me.lblTotalInitialValue.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalInitialValue.TabIndex = 39
        Me.lblTotalInitialValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OverviewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 411)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "OverviewForm"
        Me.Text = "Collection Overview!"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCDRareTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblCDCurrentValue As Label
    Friend WithEvents lblCDInitialValue As Label
    Friend WithEvents lblCDTotalCount As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRareVGValue As Label
    Friend WithEvents lblVGCurrentValue As Label
    Friend WithEvents lblVGTotalCount As Label
    Friend WithEvents lblVGInitialValue As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblDVDTotalCount As Label
    Friend WithEvents lblDVDCurrentValue As Label
    Friend WithEvents lblDVDInitialValue As Label
    Friend WithEvents lblRareCollectionValue As Label
    Friend WithEvents lblTotalMediaCount As Label
    Friend WithEvents lblTotalCurrentValue As Label
    Friend WithEvents lblTotalInitialValue As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
End Class
