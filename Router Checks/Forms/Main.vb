Imports Router_Checks.SiteDetailsDataSet
Imports System.Data
Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing

Public Class Main

    'Initiate Varibles
    Dim siteDetails As New SiteDetailsDataSet.DetailsDataTable
    Dim countSiteDetails As New SiteDetailsDataSet.rowCountDataTable
    Dim recordNo As Integer
    Dim arrayIP(,) As String 'Array IP 0 = IP, Array IP 1 = Location, Array IP 2 = Down or Up and Array IP 3 = Logged Yes/No
    Dim counter As Integer

    'Ping command used to find state of sites router
    Public Function Ping(ByVal IP As String, ByVal Site As String) As Boolean
        Dim r As Boolean
        Try
            If My.Computer.Network.Ping(IP, 1000) Then
                r = True
            Else
                r = False
            End If
        Catch ex As Exception
            MessageBox.Show("There was a problem trying to ping " + Site, "Ping Error")
        End Try
        Return r

    End Function

    'Call to database for table information that is then passed into table adapter
    Public Sub dataBpull()

        Try 'Connect to database and pass information into data table
            siteDetails = DetailsTableAdapter.GetData()
            countSiteDetails = RowCountTableAdapter.GetData()
        Catch ex As Exception
            MessageBox.Show(ex, "Database Error")
        End Try

        Dim countDetailsRow As SiteDetailsDataSet.rowCountRow

        Try 'Loop to count amount of rows in database
            For Each countDetailsRow In countSiteDetails
                recordNo = countDetailsRow.rowCount
            Next
        Catch ex As Exception
            MessageBox.Show(ex, "Record Count Error")
        End Try

    End Sub

    Public Sub ArrayFill() 'Sub to fill array with data for use in the FormLayout Sub


        Dim detailsRow As SiteDetailsDataSet.DetailsRow

        counter = 1

        'Initializes the arrayIP array
        arrayIP = New String(3, recordNo) {}

        'Passes the IP and Location from the database into the array
        Try
            For Each detailsRow In siteDetails
                arrayIP(0, counter) = detailsRow.IP
                arrayIP(1, counter) = detailsRow.Location
                arrayIP(3, counter) = "Fine" 'Used in the logging process
                counter = counter + 1
            Next
        Catch ex As Exception
            MessageBox.Show(ex, "Array Fill Error")
        End Try

    End Sub

    'Pings sites by IP and returns true or false, then passes this back into the array
    Public Sub IPCheck()

        Dim detailsRow As SiteDetailsDataSet.DetailsRow

        counter = 1

        Try
            For Each detailsRow In siteDetails
                'If to pass each IP through the IP function and passes result into array
                If Ping(arrayIP(0, counter), arrayIP(1, counter)) = True Then
                    arrayIP(2, counter) = True
                Else
                    arrayIP(2, counter) = False
                End If

                '
                If arrayIP(2, counter) = True And arrayIP(3, counter) = "Logged" Then
                    arrayIP(3, counter) = "Stop"
                ElseIf arrayIP(2, counter) = False And arrayIP(3, counter) = "Fine" Then
                    arrayIP(3, counter) = "Log"
                End If
                Log()
                counter = counter + 1
            Next

        Catch ex As Exception
            MessageBox.Show(ex, "IP Check Error")
        End Try

    End Sub

    'Sub for logging when routers are down
    Public Sub Log()

        'Initiate Varibles
        Dim TimeStamp As System.DateTime

        TimeStamp = Now 'Sets time stamp to todays date and time

        If arrayIP(2, counter) = True And arrayIP(3, counter) = "Stop" Then
            Using objWriter As New System.IO.StreamWriter("Log.txt", True)
                objWriter.WriteLine(TimeStamp & (" - ") & arrayIP(1, counter) & (" - Site Back Up"))
            End Using
            arrayIP(3, counter) = "Fine"
        ElseIf arrayIP(2, counter) = False And arrayIP(3, counter) = "Log" Then
            Using objWriter As New System.IO.StreamWriter("Log.txt", True)
                objWriter.WriteLine(TimeStamp & (" - ") & arrayIP(1, counter) & (" - Site Down"))
            End Using
            arrayIP(3, counter) = "Logged"
        End If

    End Sub

    'Sub that for each row in the DB creates a new conatiner, label, pictuer box and
    'context menu. Site information is then inputted into these.
    Public Sub FormLayout()

        counter = 1

        Dim detailsRow As SiteDetailsDataSet.DetailsRow

        Try
            'For statment to loop through data table
            For Each detailsRow In siteDetails

                'Varibles for Database pulls
                Dim ID As String = detailsRow.ID
                Dim site As String = detailsRow.Location
                Dim IP As String = detailsRow.IP
                Dim phone As String = detailsRow.Phone
                Dim tag As String = detailsRow.AssetTag
                Dim siteID As String = detailsRow.SiteNo

                'Varibles for form creation
                Dim table As New TableLayoutPanel
                Dim title As New Label
                Dim pictuer As New PictureBox
                Dim hidden As New Label
                Dim menu As New ContextMenuStrip(Me.components)
                Dim menuTitle As New ToolStripTextBox
                Dim menuSep As New ToolStripSeparator
                Dim menuSite As New ToolStripTextBox
                Dim menuCI As New ToolStripTextBox
                Dim menuNo As New ToolStripTextBox
                Dim menuIP As New ToolStripTextBox

                'Table Container for Contents
                table.AutoSize = True
                table.AutoSizeMode = AutoSizeMode.GrowAndShrink
                table.CellBorderStyle = TableLayoutPanelCellBorderStyle.Inset
                table.ColumnCount = 1
                table.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
                table.ContextMenuStrip = menu
                table.Controls.Add(hidden, 0, 1)
                table.Controls.Add(pictuer, 0, 1)
                table.Controls.Add(title, 0, 0)
                table.Location = New Drawing.Point(3, 3)
                table.Name = "tblContent" + ID
                table.RowCount = 2
                table.RowStyles.Add(New RowStyle)
                table.RowStyles.Add(New RowStyle)
                table.TabIndex = 1

                'Label for Site Name
                title.AutoSize = True
                title.Name = "lbl" + ID
                title.Text = site
                title.MaximumSize = New Drawing.Size(120, 0)
                title.Font = New Font("Microsoft Sans Serif", 9.75!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
                title.TabIndex = 1

                'Pictuer Box for Status Image
                If arrayIP(2, counter) = True Then
                    pictuer.Image = My.Resources.up
                Else
                    pictuer.Image = My.Resources.down
                    Me.Activate()
                    WindowState = FormWindowState.Normal
                End If
                pictuer.Name = "pic" + ID
                pictuer.Size = New Size(60, 60)
                pictuer.Anchor = AnchorStyles.Top
                pictuer.TabIndex = 2

                'Right Click Menu Container
                menu.Items.AddRange(New ToolStripItem() {menuTitle, menuSep, menuSite, menuCI, menuNo, menuIP})
                menu.Name = "ContextMenuStrip" + ID
                menu.Size = New Size(120, 26)

                'Right Click Menu Title Text Box
                menuTitle.Font = New Font("Tahoma", 8.25!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
                menuTitle.Name = "toolTitle" + ID
                menuTitle.Size = New Size(115, 21)
                menuTitle.Text = "Details"
                menuTitle.ReadOnly = True
                menuTitle.BackColor = Color.White

                'Right Click Menu Seperator
                menuSep.Name = "toolSeperator" + ID
                menuSep.Size = New Size(115, 6)

                'Right Click Menu Site ID Text Box
                menuSite.Name = "toolSite" + ID
                menuSite.Size = New Size(115, 21)
                menuSite.Text = "SiteID: " + siteID
                menuSite.ReadOnly = True

                'Right Click Menu CI Tag Text Box
                menuCI.Name = "toolCI" + ID
                menuCI.Size = New Size(115, 21)
                menuCI.Text = "CI: " + tag
                menuCI.ReadOnly = True

                'Right Click Menu Phone Number Text Box
                menuNo.Name = "toolNo" + ID
                menuNo.Size = New Size(115, 21)
                menuNo.Text = "Tel No: " + phone
                menuNo.ReadOnly = True

                'Right Click Menu IP Address Text Box
                menuIP.Name = "toolIP" + ID
                menuIP.Size = New Size(115, 21)
                menuIP.Text = "IP: " + IP
                menuIP.ReadOnly = True

                'Hidden Field for DB ID Field
                hidden.Name = "txtHidden" + ID
                hidden.Text = ID
                hidden.Visible = False
                hidden.TabIndex = 3


                'Adds the table and all of its contents to the flow layout box
                Me.FlowLayoutPanel1.Controls.Add(table)

                counter = counter + 1

            Next
        Catch ex As Exception
            MessageBox.Show(ex, "Problem Creating Form")
        End Try

    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'All functions called on first load of program
        dataBpull() 'DB pulled into data tables
        ArrayFill() 'Array filled from data tables
        IPCheck() 'IP's in array checked
        FormLayout() 'Form generated
        Timer1.Start() 'Start of 5min timer for refresh

    End Sub

    Private Sub ForcePingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForcePingToolStripMenuItem.Click
        'Manual refresh of program
        Timer1.Stop() 'Stop timer
        Me.Cursor = Cursors.WaitCursor 'Change cursor to a egg timer
        IPCheck() 'Check IP's from array
        Me.FlowLayoutPanel1.Controls.Clear() 'Clear current form
        FormLayout() 'Re-generate form
        Me.Cursor = Cursors.Default 'Change cursor back to normal
        Timer1.Start() 'Start timer again

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'Action taken on tick of 5min timer
        IPCheck() 'Check IP's from array
        Me.FlowLayoutPanel1.Controls.Clear() 'Clear current form
        FormLayout() 'Re-generate form

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        'Shows about page
        Dim about As New About
        about.Show()
    End Sub

    Private Sub AddRemoveSiteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRemoveSiteToolStripMenuItem.Click
        'Shows modify page
        Dim modify As New Modify
        modify.Show()
    End Sub


    Private Sub CMDPingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPingToolStripMenuItem.Click
        'Shows ping page
        Dim ping As New Ping
        ping.Show()
    End Sub

    Private Sub LogToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogToolStripMenuItem.Click
        'Shows log page
        Dim log As New Log
        log.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End 'Ends the program on click
    End Sub

End Class