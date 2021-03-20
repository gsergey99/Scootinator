<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Initial
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Home = New System.Windows.Forms.TabPage()
        Me.ButtonProfit = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SCOOTERID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DESCRIPTION = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BRAND = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ButtonScooterHistory = New System.Windows.Forms.Button()
        Me.ButtonClientHistory = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBoxDBPath = New System.Windows.Forms.TextBox()
        Me.ButtonScooterType = New System.Windows.Forms.Button()
        Me.ButtonScooter = New System.Windows.Forms.Button()
        Me.ButtonClient = New System.Windows.Forms.Button()
        Me.ButtonConnectDB = New System.Windows.Forms.Button()
        Me.ButtonPath = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Bookings = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ListBoxScootersBooked = New System.Windows.Forms.ListBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.NumericUpDownBDMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.NumericUpDownBDHours = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DateTimePickerBookingDate = New System.Windows.Forms.DateTimePicker()
        Me.NumericUpDownETMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.NumericUpDownETHour = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DateTimePickerEndTime = New System.Windows.Forms.DateTimePicker()
        Me.NumericUpDownBTMinutes = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumericUpDownBTHours = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DateTimePickerBeginTime = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxTotalPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxClient = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxBookingID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonAddScooters = New System.Windows.Forms.Button()
        Me.ListBoxScooters = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.ListBoxDesiredScooters = New System.Windows.Forms.ListBox()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ListBoxClients = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBoxBookings = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.Home.SuspendLayout()
        Me.Bookings.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownBDMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBDHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownETMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownETHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBTMinutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBTHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Home)
        Me.TabControl1.Controls.Add(Me.Bookings)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(8, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1135, 498)
        Me.TabControl1.TabIndex = 25
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Home.Controls.Add(Me.ButtonProfit)
        Me.Home.Controls.Add(Me.ListView1)
        Me.Home.Controls.Add(Me.ButtonScooterHistory)
        Me.Home.Controls.Add(Me.ButtonClientHistory)
        Me.Home.Controls.Add(Me.Label12)
        Me.Home.Controls.Add(Me.TextBoxDBPath)
        Me.Home.Controls.Add(Me.ButtonScooterType)
        Me.Home.Controls.Add(Me.ButtonScooter)
        Me.Home.Controls.Add(Me.ButtonClient)
        Me.Home.Controls.Add(Me.ButtonConnectDB)
        Me.Home.Controls.Add(Me.ButtonPath)
        Me.Home.Controls.Add(Me.Label11)
        Me.Home.Location = New System.Drawing.Point(4, 27)
        Me.Home.Name = "Home"
        Me.Home.Padding = New System.Windows.Forms.Padding(3)
        Me.Home.Size = New System.Drawing.Size(1127, 467)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        '
        'ButtonProfit
        '
        Me.ButtonProfit.Enabled = False
        Me.ButtonProfit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProfit.Location = New System.Drawing.Point(885, 364)
        Me.ButtonProfit.Name = "ButtonProfit"
        Me.ButtonProfit.Size = New System.Drawing.Size(211, 62)
        Me.ButtonProfit.TabIndex = 30
        Me.ButtonProfit.Text = "PROFIT RANKING"
        Me.ButtonProfit.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SCOOTERID, Me.DESCRIPTION, Me.BRAND})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.Location = New System.Drawing.Point(309, 173)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(544, 175)
        Me.ListView1.TabIndex = 19
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'SCOOTERID
        '
        Me.SCOOTERID.Text = "SCOOTER ID"
        Me.SCOOTERID.Width = 101
        '
        'DESCRIPTION
        '
        Me.DESCRIPTION.Text = "DESCRIPTION"
        Me.DESCRIPTION.Width = 219
        '
        'BRAND
        '
        Me.BRAND.Text = "BRAND"
        Me.BRAND.Width = 218
        '
        'ButtonScooterHistory
        '
        Me.ButtonScooterHistory.Enabled = False
        Me.ButtonScooterHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScooterHistory.Location = New System.Drawing.Point(885, 258)
        Me.ButtonScooterHistory.Name = "ButtonScooterHistory"
        Me.ButtonScooterHistory.Size = New System.Drawing.Size(211, 62)
        Me.ButtonScooterHistory.TabIndex = 29
        Me.ButtonScooterHistory.Text = "SCOOTER HISTORY"
        Me.ButtonScooterHistory.UseVisualStyleBackColor = True
        '
        'ButtonClientHistory
        '
        Me.ButtonClientHistory.Enabled = False
        Me.ButtonClientHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClientHistory.Location = New System.Drawing.Point(885, 148)
        Me.ButtonClientHistory.Name = "ButtonClientHistory"
        Me.ButtonClientHistory.Size = New System.Drawing.Size(211, 63)
        Me.ButtonClientHistory.TabIndex = 24
        Me.ButtonClientHistory.Text = "CLIENT HISTORY"
        Me.ButtonClientHistory.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(306, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(168, 17)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "List of scooters we have: "
        '
        'TextBoxDBPath
        '
        Me.TextBoxDBPath.Location = New System.Drawing.Point(434, 367)
        Me.TextBoxDBPath.Name = "TextBoxDBPath"
        Me.TextBoxDBPath.Size = New System.Drawing.Size(419, 24)
        Me.TextBoxDBPath.TabIndex = 17
        '
        'ButtonScooterType
        '
        Me.ButtonScooterType.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonScooterType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonScooterType.Enabled = False
        Me.ButtonScooterType.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonScooterType.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ButtonScooterType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.ButtonScooterType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScooterType.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScooterType.Location = New System.Drawing.Point(47, 364)
        Me.ButtonScooterType.Name = "ButtonScooterType"
        Me.ButtonScooterType.Size = New System.Drawing.Size(217, 62)
        Me.ButtonScooterType.TabIndex = 16
        Me.ButtonScooterType.Text = "Type of scooter management"
        Me.ButtonScooterType.UseVisualStyleBackColor = False
        '
        'ButtonScooter
        '
        Me.ButtonScooter.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonScooter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonScooter.Enabled = False
        Me.ButtonScooter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonScooter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ButtonScooter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.ButtonScooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonScooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonScooter.Location = New System.Drawing.Point(47, 258)
        Me.ButtonScooter.Name = "ButtonScooter"
        Me.ButtonScooter.Size = New System.Drawing.Size(217, 62)
        Me.ButtonScooter.TabIndex = 15
        Me.ButtonScooter.Text = "Scooter management"
        Me.ButtonScooter.UseVisualStyleBackColor = False
        '
        'ButtonClient
        '
        Me.ButtonClient.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ButtonClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonClient.Enabled = False
        Me.ButtonClient.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ButtonClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan
        Me.ButtonClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClient.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClient.Location = New System.Drawing.Point(47, 148)
        Me.ButtonClient.Name = "ButtonClient"
        Me.ButtonClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ButtonClient.Size = New System.Drawing.Size(217, 63)
        Me.ButtonClient.TabIndex = 13
        Me.ButtonClient.Text = "Client management"
        Me.ButtonClient.UseVisualStyleBackColor = False
        '
        'ButtonConnectDB
        '
        Me.ButtonConnectDB.Enabled = False
        Me.ButtonConnectDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnectDB.Location = New System.Drawing.Point(309, 401)
        Me.ButtonConnectDB.Name = "ButtonConnectDB"
        Me.ButtonConnectDB.Size = New System.Drawing.Size(109, 32)
        Me.ButtonConnectDB.TabIndex = 12
        Me.ButtonConnectDB.Text = "Connect to DB"
        Me.ButtonConnectDB.UseVisualStyleBackColor = True
        '
        'ButtonPath
        '
        Me.ButtonPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPath.Location = New System.Drawing.Point(309, 364)
        Me.ButtonPath.Name = "ButtonPath"
        Me.ButtonPath.Size = New System.Drawing.Size(109, 31)
        Me.ButtonPath.TabIndex = 11
        Me.ButtonPath.Text = "DBPath"
        Me.ButtonPath.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Rockwell", 70.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(47, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1051, 107)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Welcome to Scootinator"
        '
        'Bookings
        '
        Me.Bookings.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Bookings.Controls.Add(Me.Label21)
        Me.Bookings.Controls.Add(Me.ListBoxScootersBooked)
        Me.Bookings.Controls.Add(Me.Label19)
        Me.Bookings.Controls.Add(Me.GroupBox1)
        Me.Bookings.Controls.Add(Me.ButtonAddScooters)
        Me.Bookings.Controls.Add(Me.ListBoxScooters)
        Me.Bookings.Controls.Add(Me.Label10)
        Me.Bookings.Controls.Add(Me.ButtonInsert)
        Me.Bookings.Controls.Add(Me.ListBoxDesiredScooters)
        Me.Bookings.Controls.Add(Me.ButtonDelete)
        Me.Bookings.Controls.Add(Me.Label9)
        Me.Bookings.Controls.Add(Me.ButtonClear)
        Me.Bookings.Controls.Add(Me.Label8)
        Me.Bookings.Controls.Add(Me.ListBoxClients)
        Me.Bookings.Controls.Add(Me.Label7)
        Me.Bookings.Controls.Add(Me.ListBoxBookings)
        Me.Bookings.Location = New System.Drawing.Point(4, 27)
        Me.Bookings.Name = "Bookings"
        Me.Bookings.Padding = New System.Windows.Forms.Padding(3)
        Me.Bookings.Size = New System.Drawing.Size(1127, 467)
        Me.Bookings.TabIndex = 1
        Me.Bookings.Text = "Bookings"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(944, 18)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(153, 17)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "SCOOTERS´ BOOKED"
        '
        'ListBoxScootersBooked
        '
        Me.ListBoxScootersBooked.FormattingEnabled = True
        Me.ListBoxScootersBooked.ItemHeight = 18
        Me.ListBoxScootersBooked.Location = New System.Drawing.Point(942, 38)
        Me.ListBoxScootersBooked.Name = "ListBoxScootersBooked"
        Me.ListBoxScootersBooked.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxScootersBooked.Size = New System.Drawing.Size(164, 220)
        Me.ListBoxScootersBooked.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(209, 384)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(168, 72)
        Me.Label19.TabIndex = 24
        Me.Label19.Text = "Select the scooters you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "want. Once you have " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "selected, click " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ADD SCOOTERS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumericUpDownBDMinutes)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownBDHours)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerBookingDate)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownETMinutes)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownETHour)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerEndTime)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownBTMinutes)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownBTHours)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerBeginTime)
        Me.GroupBox1.Controls.Add(Me.TextBoxTotalPrice)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxClient)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBoxBookingID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(19, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(553, 284)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bookings"
        '
        'NumericUpDownBDMinutes
        '
        Me.NumericUpDownBDMinutes.Location = New System.Drawing.Point(491, 191)
        Me.NumericUpDownBDMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownBDMinutes.Name = "NumericUpDownBDMinutes"
        Me.NumericUpDownBDMinutes.ReadOnly = True
        Me.NumericUpDownBDMinutes.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownBDMinutes.TabIndex = 37
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(428, 193)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(57, 17)
        Me.Label16.TabIndex = 36
        Me.Label16.Text = "Minutes"
        '
        'NumericUpDownBDHours
        '
        Me.NumericUpDownBDHours.Location = New System.Drawing.Point(386, 191)
        Me.NumericUpDownBDHours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownBDHours.Name = "NumericUpDownBDHours"
        Me.NumericUpDownBDHours.ReadOnly = True
        Me.NumericUpDownBDHours.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownBDHours.TabIndex = 35
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(345, 193)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(39, 17)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "Hour"
        '
        'DateTimePickerBookingDate
        '
        Me.DateTimePickerBookingDate.Location = New System.Drawing.Point(130, 191)
        Me.DateTimePickerBookingDate.Name = "DateTimePickerBookingDate"
        Me.DateTimePickerBookingDate.Size = New System.Drawing.Size(209, 23)
        Me.DateTimePickerBookingDate.TabIndex = 33
        '
        'NumericUpDownETMinutes
        '
        Me.NumericUpDownETMinutes.Location = New System.Drawing.Point(491, 112)
        Me.NumericUpDownETMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownETMinutes.Name = "NumericUpDownETMinutes"
        Me.NumericUpDownETMinutes.ReadOnly = True
        Me.NumericUpDownETMinutes.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownETMinutes.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(428, 114)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Minutes:"
        '
        'NumericUpDownETHour
        '
        Me.NumericUpDownETHour.Location = New System.Drawing.Point(386, 112)
        Me.NumericUpDownETHour.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownETHour.Name = "NumericUpDownETHour"
        Me.NumericUpDownETHour.ReadOnly = True
        Me.NumericUpDownETHour.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownETHour.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(345, 114)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(43, 17)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Hour:"
        '
        'DateTimePickerEndTime
        '
        Me.DateTimePickerEndTime.Location = New System.Drawing.Point(130, 112)
        Me.DateTimePickerEndTime.Name = "DateTimePickerEndTime"
        Me.DateTimePickerEndTime.Size = New System.Drawing.Size(209, 23)
        Me.DateTimePickerEndTime.TabIndex = 28
        '
        'NumericUpDownBTMinutes
        '
        Me.NumericUpDownBTMinutes.Location = New System.Drawing.Point(491, 75)
        Me.NumericUpDownBTMinutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownBTMinutes.Name = "NumericUpDownBTMinutes"
        Me.NumericUpDownBTMinutes.ReadOnly = True
        Me.NumericUpDownBTMinutes.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownBTMinutes.TabIndex = 27
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(428, 77)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 17)
        Me.Label18.TabIndex = 26
        Me.Label18.Text = "Minutes:"
        '
        'NumericUpDownBTHours
        '
        Me.NumericUpDownBTHours.Location = New System.Drawing.Point(386, 74)
        Me.NumericUpDownBTHours.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownBTHours.Name = "NumericUpDownBTHours"
        Me.NumericUpDownBTHours.ReadOnly = True
        Me.NumericUpDownBTHours.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownBTHours.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(345, 77)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(43, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Hour:"
        '
        'DateTimePickerBeginTime
        '
        Me.DateTimePickerBeginTime.Location = New System.Drawing.Point(130, 74)
        Me.DateTimePickerBeginTime.Name = "DateTimePickerBeginTime"
        Me.DateTimePickerBeginTime.Size = New System.Drawing.Size(209, 23)
        Me.DateTimePickerBeginTime.TabIndex = 23
        '
        'TextBoxTotalPrice
        '
        Me.TextBoxTotalPrice.Enabled = False
        Me.TextBoxTotalPrice.Location = New System.Drawing.Point(130, 227)
        Me.TextBoxTotalPrice.Name = "TextBoxTotalPrice"
        Me.TextBoxTotalPrice.Size = New System.Drawing.Size(397, 23)
        Me.TextBoxTotalPrice.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Total Price:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Booking Date:"
        '
        'TextBoxClient
        '
        Me.TextBoxClient.Enabled = False
        Me.TextBoxClient.Location = New System.Drawing.Point(130, 152)
        Me.TextBoxClient.Name = "TextBoxClient"
        Me.TextBoxClient.Size = New System.Drawing.Size(397, 23)
        Me.TextBoxClient.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Client:"
        '
        'TextBoxBookingID
        '
        Me.TextBoxBookingID.Enabled = False
        Me.TextBoxBookingID.Location = New System.Drawing.Point(130, 36)
        Me.TextBoxBookingID.Name = "TextBoxBookingID"
        Me.TextBoxBookingID.Size = New System.Drawing.Size(397, 23)
        Me.TextBoxBookingID.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "End Time:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Begin Time:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking ID:"
        '
        'ButtonAddScooters
        '
        Me.ButtonAddScooters.Enabled = False
        Me.ButtonAddScooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddScooters.Location = New System.Drawing.Point(771, 348)
        Me.ButtonAddScooters.Name = "ButtonAddScooters"
        Me.ButtonAddScooters.Size = New System.Drawing.Size(133, 51)
        Me.ButtonAddScooters.TabIndex = 22
        Me.ButtonAddScooters.Text = "ADD SCOOTERS"
        Me.ButtonAddScooters.UseVisualStyleBackColor = True
        '
        'ListBoxScooters
        '
        Me.ListBoxScooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxScooters.FormattingEnabled = True
        Me.ListBoxScooters.ItemHeight = 18
        Me.ListBoxScooters.Location = New System.Drawing.Point(591, 290)
        Me.ListBoxScooters.Name = "ListBoxScooters"
        Me.ListBoxScooters.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxScooters.Size = New System.Drawing.Size(157, 166)
        Me.ListBoxScooters.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(939, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(149, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "DESIRED SCOOTERS"
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Enabled = False
        Me.ButtonInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsert.Location = New System.Drawing.Point(55, 330)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(100, 39)
        Me.ButtonInsert.TabIndex = 9
        Me.ButtonInsert.Text = "INSERT"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'ListBoxDesiredScooters
        '
        Me.ListBoxDesiredScooters.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxDesiredScooters.FormattingEnabled = True
        Me.ListBoxDesiredScooters.ItemHeight = 18
        Me.ListBoxDesiredScooters.Location = New System.Drawing.Point(942, 290)
        Me.ListBoxDesiredScooters.Name = "ListBoxDesiredScooters"
        Me.ListBoxDesiredScooters.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxDesiredScooters.Size = New System.Drawing.Size(157, 166)
        Me.ListBoxDesiredScooters.TabIndex = 21
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(237, 330)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(100, 39)
        Me.ButtonDelete.TabIndex = 11
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(588, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(162, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "SCOOTERS AVAILABLE"
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(428, 330)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(100, 39)
        Me.ButtonClear.TabIndex = 12
        Me.ButtonClear.Text = "CLEAR"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(763, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(141, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "BOOKING CREATED"
        '
        'ListBoxClients
        '
        Me.ListBoxClients.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxClients.FormattingEnabled = True
        Me.ListBoxClients.ItemHeight = 18
        Me.ListBoxClients.Location = New System.Drawing.Point(591, 38)
        Me.ListBoxClients.Name = "ListBoxClients"
        Me.ListBoxClients.Size = New System.Drawing.Size(157, 220)
        Me.ListBoxClients.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(588, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "CLIENTS"
        '
        'ListBoxBookings
        '
        Me.ListBoxBookings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxBookings.FormattingEnabled = True
        Me.ListBoxBookings.ItemHeight = 18
        Me.ListBoxBookings.Location = New System.Drawing.Point(766, 38)
        Me.ListBoxBookings.Name = "ListBoxBookings"
        Me.ListBoxBookings.Size = New System.Drawing.Size(157, 220)
        Me.ListBoxBookings.TabIndex = 4
        '
        'Form_Initial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1154, 521)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_Initial"
        Me.Text = "ScooTINATOR"
        Me.TabControl1.ResumeLayout(False)
        Me.Home.ResumeLayout(False)
        Me.Home.PerformLayout()
        Me.Bookings.ResumeLayout(False)
        Me.Bookings.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownBDMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBDHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownETMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownETHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBTMinutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBTHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Home As TabPage
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SCOOTERID As ColumnHeader
    Friend WithEvents DESCRIPTION As ColumnHeader
    Friend WithEvents BRAND As ColumnHeader
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxDBPath As TextBox
    Friend WithEvents ButtonScooterType As Button
    Friend WithEvents ButtonScooter As Button
    Friend WithEvents ButtonClient As Button
    Friend WithEvents ButtonConnectDB As Button
    Friend WithEvents ButtonPath As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Bookings As TabPage
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxTotalPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxClient As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxBookingID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonAddScooters As Button
    Friend WithEvents ListBoxScooters As ListBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents ListBoxDesiredScooters As ListBox
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents ButtonClear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ListBoxClients As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBoxBookings As ListBox
    Friend WithEvents ButtonClientHistory As Button
    Friend WithEvents ButtonScooterHistory As Button
    Friend WithEvents ButtonProfit As Button
    Friend WithEvents NumericUpDownBDMinutes As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents NumericUpDownBDHours As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents DateTimePickerBookingDate As DateTimePicker
    Friend WithEvents NumericUpDownETMinutes As NumericUpDown
    Friend WithEvents Label14 As Label
    Friend WithEvents NumericUpDownETHour As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents DateTimePickerEndTime As DateTimePicker
    Friend WithEvents NumericUpDownBTMinutes As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents NumericUpDownBTHours As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents DateTimePickerBeginTime As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents ListBoxScootersBooked As ListBox
End Class
