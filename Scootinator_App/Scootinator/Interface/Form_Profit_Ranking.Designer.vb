<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Profit_Ranking
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.ListViewProfitRanking = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1.SuspendLayout()
        CType(Me.NumericUpDownMinutes2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownMinutes1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHours2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHours1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.ListViewProfitRanking)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(679, 312)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Profit Ranking (by type of scooter)"
        '
        'NumericUpDownMinutes2
        '
        Me.NumericUpDownMinutes2.Location = New System.Drawing.Point(453, 272)
        Me.NumericUpDownMinutes2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownMinutes2.Name = "NumericUpDownMinutes2"
        Me.NumericUpDownMinutes2.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownMinutes2.TabIndex = 51
        '
        'NumericUpDownMinutes1
        '
        Me.NumericUpDownMinutes1.Location = New System.Drawing.Point(453, 236)
        Me.NumericUpDownMinutes1.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.NumericUpDownMinutes1.Name = "NumericUpDownMinutes1"
        Me.NumericUpDownMinutes1.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownMinutes1.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 274)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Minutes"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(390, 238)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 17)
        Me.Label18.TabIndex = 48
        Me.Label18.Text = "Minutes"
        '
        'NumericUpDownHours2
        '
        Me.NumericUpDownHours2.Location = New System.Drawing.Point(348, 272)
        Me.NumericUpDownHours2.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownHours2.Name = "NumericUpDownHours2"
        Me.NumericUpDownHours2.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownHours2.TabIndex = 47
        '
        'NumericUpDownHours1
        '
        Me.NumericUpDownHours1.Location = New System.Drawing.Point(348, 236)
        Me.NumericUpDownHours1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.NumericUpDownHours1.Name = "NumericUpDownHours1"
        Me.NumericUpDownHours1.Size = New System.Drawing.Size(36, 23)
        Me.NumericUpDownHours1.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(303, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Hour"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(303, 238)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(39, 17)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Hour"
        '
        'DateTimePickerTime2
        '
        Me.DateTimePickerTime2.Location = New System.Drawing.Point(97, 274)
        Me.DateTimePickerTime2.Name = "DateTimePickerTime2"
        Me.DateTimePickerTime2.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerTime2.TabIndex = 43
        '
        'DateTimePickerTime1
        '
        Me.DateTimePickerTime1.Location = New System.Drawing.Point(97, 236)
        Me.DateTimePickerTime1.Name = "DateTimePickerTime1"
        Me.DateTimePickerTime1.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerTime1.TabIndex = 42
        '
        'ButtonSearch
        '
        Me.ButtonSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSearch.Location = New System.Drawing.Point(504, 236)
        Me.ButtonSearch.Name = "ButtonSearch"
        Me.ButtonSearch.Size = New System.Drawing.Size(146, 61)
        Me.ButtonSearch.TabIndex = 38
        Me.ButtonSearch.Text = "SEARCH"
        Me.ButtonSearch.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(22, 274)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "LastDate:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 238)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 17)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "FirstDate:"
        '
        'ListViewProfitRanking
        '
        Me.ListViewProfitRanking.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListViewProfitRanking.Location = New System.Drawing.Point(25, 22)
        Me.ListViewProfitRanking.Name = "ListViewProfitRanking"
        Me.ListViewProfitRanking.Size = New System.Drawing.Size(625, 184)
        Me.ListViewProfitRanking.TabIndex = 35
        Me.ListViewProfitRanking.UseCompatibleStateImageBehavior = False
        Me.ListViewProfitRanking.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nº"
        Me.ColumnHeader1.Width = 85
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TypeID"
        Me.ColumnHeader2.Width = 109
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Brand"
        Me.ColumnHeader3.Width = 82
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Max. Weight"
        Me.ColumnHeader4.Width = 112
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Max. Speed"
        Me.ColumnHeader5.Width = 114
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Total Income"
        Me.ColumnHeader6.Width = 94
        '
        'Form_Profit_Ranking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(724, 347)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_Profit_Ranking"
        Me.Text = "Profit Ranking"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NumericUpDownMinutes2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownMinutes1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHours2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHours1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ButtonSearch As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents ListViewProfitRanking As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents DateTimePickerTime1 As DateTimePicker
    Friend WithEvents DateTimePickerTime2 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents NumericUpDownHours1 As NumericUpDown
    Friend WithEvents NumericUpDownHours2 As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents NumericUpDownMinutes1 As NumericUpDown
    Friend WithEvents NumericUpDownMinutes2 As NumericUpDown
End Class
