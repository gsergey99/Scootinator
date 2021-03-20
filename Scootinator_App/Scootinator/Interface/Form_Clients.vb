Public Class Form_Clients
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim client As Client = New Client()
        Dim clientAux As Client
        client.readallClient(Form_Initial.TextBoxDBPath.Text)
        For Each clientAux In client.Client_DAO.List
            Me.ListBoxClients.Items.Add(clientAux.ID)
        Next
    End Sub
    Private Sub ListBoxClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxClients.SelectedIndexChanged
        If ListBoxClients.SelectedItem IsNot Nothing Then
            Dim Id As String = Me.ListBoxClients.SelectedItem.ToString
            Dim client As Client = New Client(Id)
            client.readClient()
            Me.TextBoxClientID.Text = client.ID
            Me.TextBoxClientID.Enabled = False
            Me.TextBoxName.Text = client.Name
            Me.TextBoxTelephone.Text = client.Telephone.ToString
            Me.TextBoxAddress.Text = client.Location
            Me.TextBoxEmail.Text = client.Eml
            Me.ButtonInsert.Enabled = False
            Me.ButtonUpdate.Enabled = True
            Me.ButtonDelete.Enabled = True
        End If
    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Try
            Dim id As String = Me.TextBoxClientID.Text
            Dim name As String = Me.TextBoxName.Text
            Dim telephone As Integer = Integer.Parse(Me.TextBoxTelephone.Text)
            Dim address As String = Me.TextBoxAddress.Text
            Dim email As String = Me.TextBoxEmail.Text
            Dim client As Client = New Client(id, name, telephone, address, email)
            If client.insertClient() = 1 Then
                Me.ButtonClear.PerformClick()
                MessageBox.Show("Client inserted correctly", "Client", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Try
            Dim id As String = Me.TextBoxClientID.Text
            Dim name As String = Me.TextBoxName.Text
            Dim telephone As Integer = Integer.Parse(Me.TextBoxTelephone.Text)
            Dim address As String = Me.TextBoxAddress.Text
            Dim email As String = Me.TextBoxEmail.Text
            Dim client As Client = New Client(id, name, telephone, address, email)
            If client.updateClient() = 1 Then
                MessageBox.Show("Client updated correctly", "Client", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim id As String = Me.TextBoxClientID.Text
            Dim client As Client = New Client(id)
            If client.deleteClient() = 1 Then
                Me.ListBoxClients.Items.Remove(id)
                Me.ListBoxClients.ClearSelected()
                ButtonClear.PerformClick()
                MessageBox.Show("Client deleted correctly", "Client", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Me.ListBoxClients.ClearSelected()
        Me.TextBoxClientID.Clear()
        Me.TextBoxClientID.Enabled = True
        Me.TextBoxName.Clear()
        Me.TextBoxTelephone.Clear()
        Me.TextBoxAddress.Clear()
        Me.TextBoxEmail.Clear()
        Me.ButtonInsert.Enabled = True
        Me.ButtonUpdate.Enabled = False
        Me.ButtonDelete.Enabled = False

    End Sub

    Private Sub Form_Clients_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Dim client As Client = New Client
        Dim clientAux As Client
        client.readallClient(Form_Initial.TextBoxDBPath.Text)
        Form_Initial.ListBoxClients.Items.Clear()
        For Each clientAux In client.Client_DAO.List
            Form_Initial.ListBoxClients.Items.Add(clientAux.ID())
        Next
    End Sub
End Class