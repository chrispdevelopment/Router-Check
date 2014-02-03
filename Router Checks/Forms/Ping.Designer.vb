<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ping
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ping))
        Me.cmdPing = New System.Windows.Forms.Button
        Me.comboSites = New System.Windows.Forms.ComboBox
        Me.DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SiteDetailsDataSet = New Router_Checks.SiteDetailsDataSet
        Me.Label1 = New System.Windows.Forms.Label
        Me.DetailsTableAdapter = New Router_Checks.SiteDetailsDataSetTableAdapters.DetailsTableAdapter
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SiteDetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPing
        '
        Me.cmdPing.Location = New System.Drawing.Point(77, 78)
        Me.cmdPing.Name = "cmdPing"
        Me.cmdPing.Size = New System.Drawing.Size(75, 23)
        Me.cmdPing.TabIndex = 0
        Me.cmdPing.Text = "Ping"
        Me.cmdPing.UseVisualStyleBackColor = True
        '
        'comboSites
        '
        Me.comboSites.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.DetailsBindingSource, "Location", True))
        Me.comboSites.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DetailsBindingSource, "Location", True))
        Me.comboSites.DataSource = Me.DetailsBindingSource
        Me.comboSites.DisplayMember = "Location"
        Me.comboSites.FormattingEnabled = True
        Me.comboSites.Location = New System.Drawing.Point(59, 39)
        Me.comboSites.Name = "comboSites"
        Me.comboSites.Size = New System.Drawing.Size(121, 21)
        Me.comboSites.TabIndex = 1
        Me.comboSites.ValueMember = "IP"
        '
        'DetailsBindingSource
        '
        Me.DetailsBindingSource.DataMember = "Details"
        Me.DetailsBindingSource.DataSource = Me.SiteDetailsDataSet
        '
        'SiteDetailsDataSet
        '
        Me.SiteDetailsDataSet.DataSetName = "SiteDetailsDataSet"
        Me.SiteDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Which Router do you want to ping ?"
        '
        'DetailsTableAdapter
        '
        Me.DetailsTableAdapter.ClearBeforeFill = True
        '
        'Ping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 121)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comboSites)
        Me.Controls.Add(Me.cmdPing)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Ping"
        Me.Text = "Ping"
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SiteDetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdPing As System.Windows.Forms.Button
    Friend WithEvents comboSites As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SiteDetailsDataSet As Router_Checks.SiteDetailsDataSet
    Friend WithEvents DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetailsTableAdapter As Router_Checks.SiteDetailsDataSetTableAdapters.DetailsTableAdapter
End Class
