<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_Client_History
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
        Me.ListViewClientHistory = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxScootersRented = New System.Windows.Forms.ListBox()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownMinutes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMinutes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHours2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHours1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListViewClientHistory
        '
        Me.ListViewClientHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListViewClientHistory.HoverSelection = True
        Me.ListViewClientHistory.Location = New System.Drawing.Point(25, 29)
        Me.ListViewClientHistory.Name = "ListViewClientHistory"
        Me.ListViewClientHistory.Size = New System.Drawing.Size(493, 184)
        Me.ListViewClientHistory.TabIndex = 35
        Me.ListViewClientHistory.UseCompatibleStateImageBehavior = False
        Me.ListViewClientHistory.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ClientID"
        Me.ColumnHeader1.Width = 69
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ClientName"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Telephone"
        Me.ColumnHeader3.Width = 84
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Address"
        Me.ColumnHeader4.Width = 121
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Email"
        Me.ColumnHeader5.Width = 104
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ListBoxScootersRented)
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
        Me.GroupBox1.Controls.Add(Me.ListViewClientHistory)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(677, 321)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Clients History"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(536, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 17)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "RentedScooters"
        '
        'ListBoxScootersRented
        '
        Me.ListBoxScootersRented.FormattingEnabled = True
        Me.ListBoxScootersRented.ItemHeight = 16
        Me.ListBoxScootersRented.Location = New System.Drawing.Point(539, 49)
        Me.ListBoxScootersRented.Name = "ListBoxScootersRented"
        Me.ListBoxScootersRented.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBoxScootersRented.Size = New System.Drawing.Size(120, 164)
        Me.ListBoxScootersRented.TabIndex = 65
        '
        'NumericUpDownMinutes2
        '
        Me.NumericUpDownMinutes2.Location = New System.Drawing.Point(453, 271)
        Me.NumericUpDownMinutes2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownMinutes2.Name = "NumericUpDownMinutes2"
        Me.NumericUpDownMinutes2.ReadOnly = True
        Me.NumericUpDownMinutes2.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownMinutes2.TabIndex = 64
        '
        'NumericUpDownMinutes1
        '
        Me.NumericUpDownMinutes1.Location = New System.Drawing.Point(453, 235)
        Me.NumericUpDownMinutes1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownMinutes1.Name = "NumericUpDownMinutes1"
        Me.NumericUpDownMinutes1.ReadOnly = True
        Me.NumericUpDownMinutes1.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownMinutes1.TabIndex = 63
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 273)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Minutes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(390, 237)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 17)
        Me.Label18.TabIndex = 61
        Me.Label18.Text = "Minutes"
        '
        'NumericUpDownHours2
        '
        Me.NumericUpDownHours2.Location = New System.Drawing.Point(348, 271)
        Me.NumericUpDownHours2.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownHours2.Name = "NumericUpDownHours2"
        Me.NumericUpDownHours2.ReadOnly = True
        Me.NumericUpDownHours2.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownHours2.TabIndex = 60
        '
        'NumericUpDownHours1
        '
        Me.NumericUpDownHours1.Location = New System.Drawing.Point(348, 235)
        Me.NumericUpDownHours1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownHours1.Name = "NumericUpDownHours1"
        Me.NumericUpDownHours1.ReadOnly = True
        Me.NumericUpDownHours1.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownHours1.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 273)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Hour"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(303, 237)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 57
        Me.Label17.Text = "Hour"
        '
        'DateTimePickerTime2
        '
        Me.DateTimePickerTime2.Location = New System.Drawing.Point(97, 273)
        Me.DateTimePickerTime2.Name = "DateTimePickerTime2"
        Me.DateTimePickerTime2.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerTime2.TabIndex = 56
        '
        'DateTimePickerTime1
        '
        Me.DateTimePickerTime1.Location = New System.Drawing.Point(97, 235)
        Me.DateTimePickerTime1.Name = "DateTimePickerTime1"
        Me.DateTimePickerTime1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerTime1.TabIndex = 55
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(513, 235)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(146, 61)
        Me.ButtonSearch.TabIndex = 54
        Me.ButtonSearch.Text = "SEARCH"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 273)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 53
        Me.Label14.Text = "LastDate:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 237)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 52
        Me.Label13.Text = "FirstDate:"
        '
        'Form_Client_History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(719, 362)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Client_History"
        Me.Text = "Client History"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownMinutes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMinutes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHours2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHours1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListViewClientHistory As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents GroupBox1 As GroupBox
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
    Friend WithEvents ListBoxScootersRented As ListBox
End Class
