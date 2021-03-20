<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Scooter_History
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxClients = New System.Windows.Forms.ListBox()
        Me.NumericUpDownMinutes2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownMinutes1 = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.NumericUpDownHours2 = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownHours1 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.DateTimePickerTime2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePickerTime1 = New System.Windows.Forms.DateTimePicker()
        Me.ButtonSearch = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ListViewScooters = New System.Windows.Forms.ListView()
        Me.Scooter_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Scooter_Type_ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownMinutes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMinutes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHours2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHours1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBoxClients)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownMinutes2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownMinutes1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownHours2)
        Me.GroupBox1.Controls.Add(Me.NumericUpDownHours1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTime2)
        Me.GroupBox1.Controls.Add(Me.DateTimePickerTime1)
        Me.GroupBox1.Controls.Add(Me.ButtonSearch)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.ListViewScooters)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(22, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 321)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scooter History"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(514, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "ClientID"
        '
        'ListBoxClients
        '
        Me.ListBoxClients.FormattingEnabled = True
        Me.ListBoxClients.ItemHeight = 16
        Me.ListBoxClients.Location = New System.Drawing.Point(463, 51)
        Me.ListBoxClients.Name = "ListBoxClients"
        Me.ListBoxClients.Size = New System.Drawing.Size(161, 164)
        Me.ListBoxClients.TabIndex = 78
        '
        'NumericUpDownMinutes2
        '
        Me.NumericUpDownMinutes2.Location = New System.Drawing.Point(453, 269)
        Me.NumericUpDownMinutes2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownMinutes2.Name = "NumericUpDownMinutes2"
        Me.NumericUpDownMinutes2.ReadOnly = True
        Me.NumericUpDownMinutes2.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownMinutes2.TabIndex = 77
        '
        'NumericUpDownMinutes1
        '
        Me.NumericUpDownMinutes1.Location = New System.Drawing.Point(453, 233)
        Me.NumericUpDownMinutes1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownMinutes1.Name = "NumericUpDownMinutes1"
        Me.NumericUpDownMinutes1.ReadOnly = True
        Me.NumericUpDownMinutes1.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownMinutes1.TabIndex = 76
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Minutes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(390, 235)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 17)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "Minutes"
        '
        'NumericUpDownHours2
        '
        Me.NumericUpDownHours2.Location = New System.Drawing.Point(348, 269)
        Me.NumericUpDownHours2.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownHours2.Name = "NumericUpDownHours2"
        Me.NumericUpDownHours2.ReadOnly = True
        Me.NumericUpDownHours2.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownHours2.TabIndex = 73
        '
        'NumericUpDownHours1
        '
        Me.NumericUpDownHours1.Location = New System.Drawing.Point(348, 233)
        Me.NumericUpDownHours1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownHours1.Name = "NumericUpDownHours1"
        Me.NumericUpDownHours1.ReadOnly = True
        Me.NumericUpDownHours1.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownHours1.TabIndex = 72
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Hour"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(303, 235)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 70
        Me.Label17.Text = "Hour"
        '
        'DateTimePickerTime2
        '
        Me.DateTimePickerTime2.Location = New System.Drawing.Point(97, 271)
        Me.DateTimePickerTime2.Name = "DateTimePickerTime2"
        Me.DateTimePickerTime2.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerTime2.TabIndex = 69
        '
        'DateTimePickerTime1
        '
        Me.DateTimePickerTime1.Location = New System.Drawing.Point(97, 233)
        Me.DateTimePickerTime1.Name = "DateTimePickerTime1"
        Me.DateTimePickerTime1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerTime1.TabIndex = 68
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(504, 233)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(146, 61)
        Me.ButtonSearch.TabIndex = 67
        Me.ButtonSearch.Text = "SEARCH"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 271)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 66
        Me.Label14.Text = "LastDate:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 65
        Me.Label13.Text = "FirstDate:"
        '
        'ListViewScooters
        '
        Me.ListViewScooters.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Scooter_ID, Me.Scooter_Type_ID})
        Me.ListViewScooters.HoverSelection = True
        Me.ListViewScooters.Location = New System.Drawing.Point(25, 31)
        Me.ListViewScooters.MultiSelect = False
        Me.ListViewScooters.Name = "ListViewScooters"
        Me.ListViewScooters.Size = New System.Drawing.Size(359, 184)
        Me.ListViewScooters.TabIndex = 39
        Me.ListViewScooters.UseCompatibleStateImageBehavior = False
        Me.ListViewScooters.View = System.Windows.Forms.View.Details
        '
        'Scooter_ID
        '
        Me.Scooter_ID.Text = "Scooter_ID"
        Me.Scooter_ID.Width = 138
        '
        'Scooter_Type_ID
        '
        Me.Scooter_Type_ID.Text = "Scooter_Type_ID"
        Me.Scooter_Type_ID.Width = 193
        '
        'Form_Scooter_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(713, 360)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Scooter_History"
        Me.Text = "Scooter History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownMinutes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMinutes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHours2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHours1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ListViewScooters As ListView
    Friend WithEvents Scooter_ID As ColumnHeader
    Friend WithEvents Scooter_Type_ID As ColumnHeader
    Friend WithEvents NumericUpDownMinutes2 As NumericUpDown
    Friend WithEvents NumericUpDownMinutes1 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents NumericUpDownHours2 As NumericUpDown
    Friend WithEvents NumericUpDownHours1 As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents DateTimePickerTime2 As DateTimePicker
    Friend WithEvents DateTimePickerTime1 As DateTimePicker
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBoxClients As ListBox
End Class
