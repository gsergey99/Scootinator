Public Class Form_TypeScooters

    Private Sub Form_TypeScooters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scootertype As ScooterType = New ScooterType
        Dim scootertypeAux As ScooterType
        scootertype.readallScooterType(Form_Initial.TextBoxDBPath.Text)
        For Each scootertypeAux In scootertype.ScooterType.List
            Me.ListBoxTypes.Items.Add(scootertypeAux.ID())
        Next
    End Sub
    Private Sub ListBoxTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTypes.SelectedIndexChanged
        If ListBoxTypes.SelectedItem IsNot Nothing Then
            Dim Id As Long = Long.Parse(ListBoxTypes.SelectedItem.ToString)
            Dim scootertype As ScooterType = New ScooterType(Id)
            scootertype.readScooterType()
            Me.TextBoxTypeID.Text = scootertype.ID.ToString
            Me.TextBoxBrand.Text = scootertype.Brnd
            Me.TextBoxMaxWeight.Text = scootertype.MxWeight.ToString
            Me.TextBoxMaxSpeed.Text = scootertype.MxSpeed.ToString
            Me.TextBoxPricePerHour.Text = scootertype.PHour.ToString
            Me.TextBoxTypeID.Enabled = False
            Me.ButtonInsert.Enabled = False
            Me.ButtonUpdate.Enabled = True
            Me.ButtonDelete.Enabled = True
        End If
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click

        Me.TextBoxTypeID.Clear()
        Me.TextBoxBrand.Clear()
        Me.TextBoxMaxWeight.Clear()
        Me.TextBoxMaxSpeed.Clear()
        Me.TextBoxPricePerHour.Clear()
        Me.ListBoxTypes.ClearSelected()
        Me.TextBoxTypeID.Enabled = False
        Me.ButtonInsert.Enabled = True
        Me.ButtonUpdate.Enabled = False
        Me.ButtonDelete.Enabled = False
    End Sub
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Try
            TextBoxTypeID.Enabled = False
            Dim brand As String = TextBoxBrand.Text
            Dim maxw As Long = Long.Parse(TextBoxMaxWeight.Text)
            Dim maxs As Long = Long.Parse(TextBoxMaxSpeed.Text)
            Dim pph As Double = Convert.ToDouble(TextBoxPricePerHour.Text)
            Dim scootertype As ScooterType = New ScooterType(brand, maxw, maxs, pph)
            If scootertype.insertScooterType() = 1 Then
                ListBoxTypes.Items.Clear()

                Dim scootertypeAux As ScooterType
                scootertype.readallScooterType(Form_Initial.TextBoxDBPath.Text)
                For Each scootertypeAux In scootertype.ScooterType.List
                    Me.ListBoxTypes.Items.Add(scootertypeAux.ID())
                Next
                Me.ButtonClear.PerformClick()
                MessageBox.Show("Type of scooter inserted correctly", "Type of scooter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Dim id As Long = Long.Parse(TextBoxTypeID.Text)
            Dim brand As String = TextBoxBrand.Text
            Dim maxw As Long = Integer.Parse(TextBoxMaxWeight.Text)
            Dim maxs As Long = Long.Parse(TextBoxMaxSpeed.Text)
            Dim pph As Double = Convert.ToDouble(TextBoxPricePerHour.Text)
            Dim scootertype As ScooterType = New ScooterType(id, brand, maxw, maxs, pph)
            If scootertype.updateScooterType() = 1 Then
                MessageBox.Show("Type of scooter updated correctly", "Type of scooter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        TextBoxTypeID.Enabled = False
    End Sub
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim id As Long = Long.Parse(TextBoxTypeID.Text)
            Dim scootertype As ScooterType = New ScooterType(id)
            If scootertype.deleteScooterType() = 1 Then
                Me.ListBoxTypes.ClearSelected()
                Me.ListBoxTypes.Items.Remove(id)
                Me.ButtonClear.PerformClick()
                MessageBox.Show("Type of scooter deleted correctly", "Type of scooter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
        Me.TextBoxTypeID.Enabled = False
    End Sub
End Class









