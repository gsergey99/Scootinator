<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_TypeScooters
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
        Me.TextBoxPricePerHour = New System.Windows.Forms.TextBox()
        Me.TextBoxMaxSpeed = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxMaxWeight = New System.Windows.Forms.TextBox()
        Me.TextBoxBrand = New System.Windows.Forms.TextBox()
        Me.TextBoxTypeID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBoxTypes = New System.Windows.Forms.ListBox()
        Me.ButtonInsert = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBoxPricePerHour)
        Me.GroupBox1.Controls.Add(Me.TextBoxMaxSpeed)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBoxMaxWeight)
        Me.GroupBox1.Controls.Add(Me.TextBoxBrand)
        Me.GroupBox1.Controls.Add(Me.TextBoxTypeID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(559, 242)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Scooter_Types"
        '
        'TextBoxPricePerHour
        '
        Me.TextBoxPricePerHour.Location = New System.Drawing.Point(130, 177)
        Me.TextBoxPricePerHour.Name = "TextBoxPricePerHour"
        Me.TextBoxPricePerHour.Size = New System.Drawing.Size(380, 23)
        Me.TextBoxPricePerHour.TabIndex = 11
        '
        'TextBoxMaxSpeed
        '
        Me.TextBoxMaxSpeed.Location = New System.Drawing.Point(130, 142)
        Me.TextBoxMaxSpeed.Name = "TextBoxMaxSpeed"
        Me.TextBoxMaxSpeed.Size = New System.Drawing.Size(380, 23)
        Me.TextBoxMaxSpeed.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "PricePerHour:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "MaxSpeed:"
        '
        'TextBoxMaxWeight
        '
        Me.TextBoxMaxWeight.Location = New System.Drawing.Point(130, 104)
        Me.TextBoxMaxWeight.Name = "TextBoxMaxWeight"
        Me.TextBoxMaxWeight.Size = New System.Drawing.Size(380, 23)
        Me.TextBoxMaxWeight.TabIndex = 7
        '
        'TextBoxBrand
        '
        Me.TextBoxBrand.Location = New System.Drawing.Point(130, 69)
        Me.TextBoxBrand.Name = "TextBoxBrand"
        Me.TextBoxBrand.Size = New System.Drawing.Size(380, 23)
        Me.TextBoxBrand.TabIndex = 6
        '
        'TextBoxTypeID
        '
        Me.TextBoxTypeID.Enabled = False
        Me.TextBoxTypeID.Location = New System.Drawing.Point(130, 36)
        Me.TextBoxTypeID.Name = "TextBoxTypeID"
        Me.TextBoxTypeID.Size = New System.Drawing.Size(380, 23)
        Me.TextBoxTypeID.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "MaxWeight:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Brand:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type ID:"
        '
        'ListBoxTypes
        '
        Me.ListBoxTypes.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxTypes.FormattingEnabled = True
        Me.ListBoxTypes.ItemHeight = 18
        Me.ListBoxTypes.Location = New System.Drawing.Point(609, 38)
        Me.ListBoxTypes.Name = "ListBoxTypes"
        Me.ListBoxTypes.Size = New System.Drawing.Size(169, 274)
        Me.ListBoxTypes.TabIndex = 3
        '
        'ButtonInsert
        '
        Me.ButtonInsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonInsert.Location = New System.Drawing.Point(46, 282)
        Me.ButtonInsert.Name = "ButtonInsert"
        Me.ButtonInsert.Size = New System.Drawing.Size(100, 39)
        Me.ButtonInsert.TabIndex = 4
        Me.ButtonInsert.Text = "INSERT"
        Me.ButtonInsert.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Enabled = False
        Me.ButtonUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUpdate.Location = New System.Drawing.Point(188, 282)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(100, 39)
        Me.ButtonUpdate.TabIndex = 5
        Me.ButtonUpdate.Text = "UPDATE"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Enabled = False
        Me.ButtonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonDelete.Location = New System.Drawing.Point(332, 282)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(100, 39)
        Me.ButtonDelete.TabIndex = 6
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonClear.Location = New System.Drawing.Point(471, 282)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(100, 39)
        Me.ButtonClear.TabIndex = 7
        Me.ButtonClear.Text = "CLEAR"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'Form_TypeScooters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(800, 335)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonInsert)
        Me.Controls.Add(Me.ListBoxTypes)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form_TypeScooters"
        Me.Text = "Type of Scooters"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBoxMaxWeight As TextBox
    Friend WithEvents TextBoxBrand As TextBox
    Friend WithEvents TextBoxTypeID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxPricePerHour As TextBox
    Friend WithEvents TextBoxMaxSpeed As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBoxTypes As ListBox
    Friend WithEvents ButtonInsert As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClear As Button
End Class
