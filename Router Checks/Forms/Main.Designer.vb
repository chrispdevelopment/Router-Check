<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.innerPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripTextBox3 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox4 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripTextBox5 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddRemoveSiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForcePingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMDPingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SiteDetailsDataSet = New Router_Checks.SiteDetailsDataSet()
        Me.DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailsTableAdapter = New Router_Checks.SiteDetailsDataSetTableAdapters.DetailsTableAdapter()
        Me.TableAdapterManager = New Router_Checks.SiteDetailsDataSetTableAdapters.TableAdapterManager()
        Me.RowCountBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RowCountTableAdapter = New Router_Checks.SiteDetailsDataSetTableAdapters.rowCountTableAdapter()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.innerPanel.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SiteDetailsDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RowCountBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.FlowLayoutPanel1.Controls.Add(Me.innerPanel)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(15, 55)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(10, 0, 10, 10)
        Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(960, 800)
        Me.FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(200, 200)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 200)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'innerPanel
        '
        Me.innerPanel.AutoSize = True
        Me.innerPanel.Controls.Add(Me.TableLayoutPanel1)
        Me.innerPanel.Location = New System.Drawing.Point(3, 3)
        Me.innerPanel.Name = "innerPanel"
        Me.innerPanel.Size = New System.Drawing.Size(120, 88)
        Me.innerPanel.TabIndex = 7
        Me.innerPanel.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(114, 82)
        Me.TableLayoutPanel1.TabIndex = 1
        Me.TableLayoutPanel1.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox3, Me.ToolStripSeparator1, Me.ToolStripTextBox4, Me.ToolStripTextBox1, Me.ToolStripTextBox2, Me.ToolStripTextBox5, Me.ToolStripSeparator2, Me.ToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(161, 153)
        '
        'ToolStripTextBox3
        '
        Me.ToolStripTextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox3.Name = "ToolStripTextBox3"
        Me.ToolStripTextBox3.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox3.Text = "Details"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(157, 6)
        '
        'ToolStripTextBox4
        '
        Me.ToolStripTextBox4.Name = "ToolStripTextBox4"
        Me.ToolStripTextBox4.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox4.Text = "SiteID: "
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox1.Text = "CI: D/Centre"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox2.Text = "Tel No: 01752 827500"
        '
        'ToolStripTextBox5
        '
        Me.ToolStripTextBox5.Name = "ToolStripTextBox5"
        Me.ToolStripTextBox5.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox5.Text = "IP: 255.255.255.252"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(157, 6)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(160, 22)
        Me.ToolStripMenuItem1.Text = "Ping"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBox2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.PictureBox2.Image = Global.Router_Checks.My.Resources.Resources.down
        Me.PictureBox2.Location = New System.Drawing.Point(27, 20)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 2)
        Me.Label6.MaximumSize = New System.Drawing.Size(120, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "test test test test"
        '
        'Timer1
        '
        Me.Timer1.Interval = 300000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AddRemoveSiteToolStripMenuItem, Me.ForcePingToolStripMenuItem, Me.CMDPingToolStripMenuItem, Me.LogToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(980, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AddRemoveSiteToolStripMenuItem
        '
        Me.AddRemoveSiteToolStripMenuItem.Name = "AddRemoveSiteToolStripMenuItem"
        Me.AddRemoveSiteToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AddRemoveSiteToolStripMenuItem.Text = "Modify Sites"
        '
        'ForcePingToolStripMenuItem
        '
        Me.ForcePingToolStripMenuItem.Name = "ForcePingToolStripMenuItem"
        Me.ForcePingToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ForcePingToolStripMenuItem.Text = "Refresh"
        '
        'CMDPingToolStripMenuItem
        '
        Me.CMDPingToolStripMenuItem.Name = "CMDPingToolStripMenuItem"
        Me.CMDPingToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.CMDPingToolStripMenuItem.Text = "CMD Ping"
        '
        'LogToolStripMenuItem
        '
        Me.LogToolStripMenuItem.Name = "LogToolStripMenuItem"
        Me.LogToolStripMenuItem.Size = New System.Drawing.Size(36, 20)
        Me.LogToolStripMenuItem.Text = "Log"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Right click boxes for more info"
        '
        'SiteDetailsDataSet
        '
        Me.SiteDetailsDataSet.DataSetName = "SiteDetailsDataSet"
        Me.SiteDetailsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DetailsBindingSource
        '
        Me.DetailsBindingSource.DataMember = "Details"
        Me.DetailsBindingSource.DataSource = Me.SiteDetailsDataSet
        '
        'DetailsTableAdapter
        '
        Me.DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DetailsTableAdapter = Me.DetailsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Router_Checks.SiteDetailsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UpdateTableAdapter = Nothing
        '
        'RowCountBindingSource
        '
        Me.RowCountBindingSource.DataMember = "rowCount"
        Me.RowCountBindingSource.DataSource = Me.SiteDetailsDataSet
        '
        'RowCountTableAdapter
        '
        Me.RowCountTableAdapter.ClearBeforeFill = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(980, 474)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximumSize = New System.Drawing.Size(988, 810)
        Me.Name = "Main"
        Me.Text = "Router Status"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.innerPanel.ResumeLayout(False)
        Me.innerPanel.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ContextMenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.SiteDetailsDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RowCountBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddRemoveSiteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ForcePingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SiteDetailsDataSet As Router_Checks.SiteDetailsDataSet
    Friend WithEvents DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetailsTableAdapter As Router_Checks.SiteDetailsDataSetTableAdapters.DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Router_Checks.SiteDetailsDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox3 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripTextBox4 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripTextBox5 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CMDPingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RowCountBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RowCountTableAdapter As Router_Checks.SiteDetailsDataSetTableAdapters.rowCountTableAdapter
    Friend WithEvents innerPanel As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LogToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
