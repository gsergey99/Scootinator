Public Class Form_Scooters
    Private Sub Form_Scooters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBoxScooterID.Enabled = False
        Me.TextBoxType.Enabled = True
        Dim scooter As Scooter = New Scooter()
        Dim scootertAux As Scooter
        Dim scootertype As ScooterType = New ScooterType()
        Dim scootertypeAux As ScooterType
        scooter.readallScooter(Form_Initial.TextBoxDBPath.Text)
        scootertype.readallScooterType(Form_Initial.TextBoxDBPath.Text)
        For Each scootertAux In scooter.Scooter_DAO.List
            Me.ListBoxScooters.Items.Add(scootertAux.ID())
        Next
        For Each scootertypeAux In scootertype.ScooterType.List
            Me.ListBoxTypeScooters.Items.Add(scootertypeAux.ID)
        Next

    End Sub
    Private Sub ListBoxScooters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxScooters.SelectedIndexChanged
        If ListBoxScooters.SelectedItem IsNot Nothing Then
            Dim Id As Long = Long.Parse(ListBoxScooters.SelectedItem.ToString)
            Dim scooter As Scooter = New Scooter(Id)
            scooter.readScooter()
            Me.TextBoxScooterID.Text = scooter.ID.ToString
            Me.TextBoxDescription.Text = scooter.Descrip
            Me.TextBoxType.Text = scooter.S_T.ID().ToString
            Me.ListBoxTypeScooters.SelectedItem = scooter.S_T.ID()
            Me.ButtonInsert.Enabled = False
            Me.ButtonUpdate.Enabled = True
            Me.ButtonDelete.Enabled = True

        End If
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Me.TextBoxScooterID.Clear()
        Me.TextBoxDescription.Clear()
        Me.TextBoxType.Clear()
        Me.ButtonInsert.Enabled = True
        Me.ButtonUpdate.Enabled = False
        Me.ButtonDelete.Enabled = False
        Me.ListBoxScooters.ClearSelected()
        Me.ListBoxTypeScooters.ClearSelected()
    End Sub
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Try
            Dim description As String = TextBoxDescription.Text
            Dim type As Long = Long.Parse(TextBoxType.Text)
            Dim scooter As Scooter = New Scooter(description, type)

            If scooter.insertScooter() = 1 Then
                Me.ListBoxScooters.Items.Clear()

                Dim scooterAux As Scooter
                scooter.readallScooter(Form_Initial.TextBoxDBPath.Text)
                For Each scooterAux In scooter.Scooter_DAO.List
                    Me.ListBoxScooters.Items.Add(scooterAux.ID())
                Next
                Me.ButtonClear.PerformClick()
                MessageBox.Show("Scooter inserted correctly", "Scooter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
            Me.ListBoxTypeScooters.ClearSelected()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Dim id As Long = Long.Parse(TextBoxScooterID.Text)
            Dim description As String = TextBoxDescription.Text
            Dim type As Long = Long.Parse(TextBoxType.Text)
            Dim scooter As Scooter = New Scooter(id, description, type)
            If scooter.updateScooter() = 1 Then
                MessageBox.Show("Scooter updated correctly", "Scooter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub
    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim id As Long = Long.Parse(TextBoxScooterID.Text)
            Dim scooter As Scooter = New Scooter(id)
            If scooter.deleteScooter() = 1 Then
                Me.ListBoxScooters.Items.Remove(id)
                Me.ListBoxScooters.ClearSelected()
                Me.ButtonClear.PerformClick()
                MessageBox.Show("Scooter deleted correctly", "Scooter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ListBoxTypeScooters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxTypeScooters.SelectedIndexChanged
        If ListBoxTypeScooters.SelectedItem IsNot Nothing Then
            Dim Id As Long = Long.Parse(ListBoxTypeScooters.SelectedItem.ToString)
            Dim scootertype As ScooterType = New ScooterType(Id)
            scootertype.readScooterType()
            Me.TextBoxType.Text = scootertype.ID.ToString
        End If
    End Sub

    Private Sub Form_Scooters_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim scooter As Scooter = New Scooter()
        Dim scooterAux As Scooter
        scooter.readallScooter(Form_Initial.TextBoxDBPath.Text)
        Form_Initial.ListBoxScooters.Items.Clear()
        For Each scooterAux In scooter.Scooter_DAO.List
            Form_Initial.ListBoxScooters.Items.Add(scooterAux.ID())
        Next
        Dim lsvitem As ListViewItem = New ListViewItem()
        Form_Initial.ListView1.BeginUpdate()
        Form_Initial.ListView1.Items.Clear()
        For Each scooterAux In scooter.Scooter_DAO.List
            lsvitem = Form_Initial.ListView1.Items.Add(scooterAux.ID.ToString)
            lsvitem.SubItems.Add(scooterAux.Descrip.ToString)
            lsvitem.SubItems.Add(scooterAux.S_T.Brnd.ToString)
            Form_Initial.ListView1.Update()
        Next
        Form_Initial.ListView1.EndUpdate()
    End Sub


End Class









