Public Class Form_Initial
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bookings.Enabled = False
    End Sub

    Private Sub ButtonPath_Click(sender As Object, e As EventArgs) Handles ButtonPath.Click
        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            TextBoxDBPath.Text = OpenFileDialog1.FileName
            ButtonConnectDB.Enabled = True
            ButtonConnectDB.Visible = True
        End If
    End Sub

    Private Sub ButtonConnectDB_Click(sender As Object, e As EventArgs) Handles ButtonConnectDB.Click
        Try
            Dim lsvitem As ListViewItem = New ListViewItem()
            ListView1.BeginUpdate()
            Dim scooter As Scooter = New Scooter
            Dim scooterAux As Scooter
            scooter.readallScooter(TextBoxDBPath.Text)
            For Each scooterAux In scooter.Scooter_DAO.List
                lsvitem = ListView1.Items.Add(scooterAux.ID.ToString)
                lsvitem.SubItems.Add(scooterAux.Descrip.ToString)
                lsvitem.SubItems.Add(scooterAux.S_T.Brnd.ToString)
                ListView1.Update()
            Next

            ListView1.EndUpdate()
            TextBoxDBPath.Enabled = False
            ButtonConnectDB.Enabled = False
            ButtonPath.Enabled = False
            ButtonClient.Visible = True
            ButtonClient.Enabled = True
            ButtonScooter.Visible = True
            ButtonScooter.Enabled = True
            ButtonScooterType.Enabled = True
            ButtonScooterType.Visible = True
            ButtonClientHistory.Enabled = True
            ButtonScooterHistory.Enabled = True
            ButtonProfit.Enabled = True
            ButtonInsert.Enabled = True
            ButtonDelete.Enabled = False
            ButtonAddScooters.Enabled = True

            Dim client As Client = New Client
            Dim clientAux As Client
            client.readallClient(TextBoxDBPath.Text)
            For Each clientAux In client.Client_DAO.List
                ListBoxClients.Items.Add(clientAux.ID())
            Next
   
            For Each scooterAux In scooter.Scooter_DAO.List
                ListBoxScooters.Items.Add(scooterAux.ID())
            Next
            Dim booking As Booking = New Booking
            Dim bookingAux As Booking
            booking.readallBooking(TextBoxDBPath.Text)
            For Each bookingAux In booking.Booking_DAO.List
                ListBoxBookings.Items.Add(bookingAux.ID())
            Next
            Bookings.Enabled = True
            DateTimePickerBeginTime.Enabled = True
            DateTimePickerEndTime.Enabled = True
            DateTimePickerBookingDate.Enabled = False
            ListBoxBookings.Enabled = True
            ListBoxClients.Enabled = True
            ListBoxScooters.Enabled = True
            ListBoxDesiredScooters.Enabled = True
            NumericUpDownBDHours.Enabled = False
            NumericUpDownBDMinutes.Enabled = False
            DateTimePickerBookingDate.Value = DateTime.Now
            NumericUpDownBDHours.Value = DateTime.Now.Hour
            NumericUpDownBDMinutes.Value = DateTime.Now.Minute
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            ButtonPath.Enabled = False
            ButtonConnectDB.Enabled = False
            Exit Sub
        End Try
    End Sub

    Private Sub ButtonClient_Click(sender As Object, e As EventArgs) Handles ButtonClient.Click
        Form_Clients.Show()
    End Sub

    Private Sub ButtonScooterType_Click(sender As Object, e As EventArgs) Handles ButtonScooterType.Click
        Form_TypeScooters.Show()
    End Sub

    Private Sub ButtonScooter_Click(sender As Object, e As EventArgs) Handles ButtonScooter.Click
        Form_Scooters.Show()
    End Sub

    Private Sub ListBoxBookings_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxBookings.SelectedIndexChanged
        If ListBoxBookings.SelectedItem IsNot Nothing Then
            Dim Id As Integer = Integer.Parse(ListBoxBookings.SelectedItem.ToString)
            Dim booking As Booking = New Booking(Id)
            Dim scooterAux As Scooter
            booking.readBooking()
            TextBoxBookingID.Text = booking.ID.ToString
            TextBoxBookingID.Enabled = False
            DateTimePickerBeginTime.Value = booking.BeginT
            NumericUpDownBTHours.Value = booking.BeginT.Hour
            NumericUpDownBTMinutes.Value = booking.BeginT.Minute
            DateTimePickerEndTime.Value = booking.EndT
            NumericUpDownETHour.Value = booking.EndT.Hour
            NumericUpDownETMinutes.Value = booking.EndT.Minute
            TextBoxClient.Text = booking.Clint.ID
            ListBoxClients.SelectedItem = booking.Clint.ID
            DateTimePickerBookingDate.Value = booking.BDate
            NumericUpDownBDHours.Value = booking.BDate.Hour
            NumericUpDownBDMinutes.Value = booking.BDate.Minute
            TextBoxTotalPrice.Text = booking.TPrice.ToString
            ListBoxScootersBooked.Items.Clear()
            For Each scooterAux In booking.Scooters
                ListBoxScootersBooked.Items.Add(scooterAux.ID)
            Next
            ButtonInsert.Enabled = False
            ButtonDelete.Enabled = True
            ButtonAddScooters.Enabled = False
            ListBoxDesiredScooters.Enabled = False
        End If
    End Sub
    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        ListBoxBookings.ClearSelected()
        TextBoxBookingID.Clear()
        DateTimePickerBeginTime.ResetText()
        DateTimePickerEndTime.ResetText()
        TextBoxClient.Clear()
        TextBoxTotalPrice.Clear()
        ListBoxClients.ClearSelected()
        ListBoxBookings.ClearSelected()
        ListBoxScooters.ClearSelected()
        ListBoxDesiredScooters.ClearSelected()
        ListBoxDesiredScooters.Items.Clear()
        ListBoxScootersBooked.ClearSelected()
        ListBoxScootersBooked.Items.Clear()
        ButtonAddScooters.Enabled = True
        ButtonInsert.Enabled = True
        ButtonDelete.Enabled = False
        NumericUpDownBTHours.Value = 0
        NumericUpDownBTMinutes.Value = 0
        NumericUpDownETHour.Value = 0
        NumericUpDownETMinutes.Value = 0
    End Sub
    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Try
            Dim client As Client = New Client(TextBoxClient.Text)
            Dim btime As DateTime = DateTime.Parse(DateTimePickerBeginTime.Value.ToShortDateString).AddHours(NumericUpDownBTHours.Value).AddMinutes(NumericUpDownBTMinutes.Value)
            Dim etime As DateTime = DateTime.Parse(DateTimePickerEndTime.Value.ToShortDateString).AddHours(NumericUpDownETHour.Value).AddMinutes(NumericUpDownETMinutes.Value)
            Dim bookingdate As Date = Date.Now
            Dim price As Double = Convert.ToDouble(TextBoxTotalPrice.Text)
            Dim booking As Booking = New Booking(btime, etime, client, bookingdate, price)
            Dim scooter As Scooter
            Dim v As Integer = (ListBoxDesiredScooters.Items.Count - 1)
            For i = 0 To v
                scooter = New Scooter(Long.Parse(ListBoxDesiredScooters.Items(i).ToString))
                scooter.readScooter()
                booking.Scooters.Add(scooter)
            Next
            If booking.insertBooking() = 1 Then
                ListBoxBookings.Items.Clear()

                Dim bookingAux As Booking
                booking.readallBooking(TextBoxDBPath.Text)
                For Each bookingAux In booking.Booking_DAO.List
                    ListBoxBookings.Items.Add(bookingAux.ID())
                Next
                ButtonClear.PerformClick()
                MessageBox.Show("Booking inserted correctly", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try
            Dim id As Long = Long.Parse(TextBoxBookingID.Text)

            Dim booking As Booking = New Booking(id)
            If booking.deleteBooking() = 1 Then
                ListBoxBookings.Items.Remove(id)
                ButtonClear.PerformClick()
                MessageBox.Show("Booking deleted correctly", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                ButtonClear.PerformClick()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ListBoxClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxClients.SelectedIndexChanged
        If ListBoxClients.SelectedItem IsNot Nothing Then
            Dim Id As String = ListBoxClients.SelectedItem.ToString
            Dim client As Client = New Client(Id)
            client.readClient()
            TextBoxClient.Text = client.ID
            TextBoxClient.Enabled = False
        End If
    End Sub


    Private Sub ButtonAddScooters_Click(sender As Object, e As EventArgs) Handles ButtonAddScooters.Click
        Try
            If (ListBoxScooters.SelectedIndex = -1) Then
                MessageBox.Show("Please, select the scooters you want to rent")
            Else
                Dim v As Integer = (ListBoxScooters.SelectedItems.Count - 1)

                For i = 0 To v
                    ListBoxDesiredScooters.Items.Add(ListBoxScooters.SelectedItems(i))
                Next
                If ListBoxDesiredScooters.Items IsNot Nothing Then
                    Dim btime As DateTime = DateTime.Parse(DateTimePickerBeginTime.Value.ToShortDateString).AddHours(NumericUpDownBTHours.Value).AddMinutes(NumericUpDownBTMinutes.Value)
                    Dim etime As DateTime = DateTime.Parse(DateTimePickerEndTime.Value.ToShortDateString).AddHours(NumericUpDownETHour.Value).AddMinutes(NumericUpDownETMinutes.Value)
                    Dim bookingdate As Date = Date.Now
                    Dim s As Collection = New Collection
                    Dim booking As Booking = New Booking()
                    booking.BeginT = btime
                    booking.EndT = etime
                    Dim scooter As Scooter

                    For i = 0 To v
                        scooter = New Scooter(Long.Parse(ListBoxDesiredScooters.Items(i).ToString))
                        booking.Scooters.Add(scooter)
                    Next

                    booking.CalculateTotalPrice()
                    If booking.TPrice = 0 Then
                        MessageBox.Show("Sorry, those scooters are not available", "Bookings", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ListBoxDesiredScooters.Items.Clear()
                        ButtonAddScooters.Enabled = True
                    Else
                        TextBoxTotalPrice.Text = booking.TPrice.ToString
                        ButtonAddScooters.Enabled = False
                        ButtonInsert.Enabled = True
                    End If
                    ListBoxScooters.SelectedItems.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try

    End Sub

    Private Sub ButtonClientHistory_Click(sender As Object, e As EventArgs) Handles ButtonClientHistory.Click
        Form_Client_History.Show()
    End Sub

    Private Sub ButtonScooterHistory_Click(sender As Object, e As EventArgs) Handles ButtonScooterHistory.Click
        Form_Scooter_History.Show()
    End Sub

    Private Sub ButtonProfit_Click(sender As Object, e As EventArgs) Handles ButtonProfit.Click
        Form_Profit_Ranking.Show()
    End Sub


End Class
