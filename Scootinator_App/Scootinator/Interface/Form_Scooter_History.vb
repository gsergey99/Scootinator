Public Class Form_Scooter_History

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Try
            Dim time1 As DateTime = DateTime.Parse(DateTimePickerTime1.Value.ToShortDateString).AddHours(NumericUpDownHours1.Value).AddMinutes(NumericUpDownMinutes1.Value)
            Dim time2 As DateTime = DateTime.Parse(DateTimePickerTime2.Value.ToShortDateString).AddHours(NumericUpDownHours2.Value).AddMinutes(NumericUpDownMinutes2.Value)
            Dim booking As Booking = New Booking()
            booking.ScooterHistory(time1, time2)
            Dim bookingAux As Booking
            Dim scooteraux As Scooter
            ListViewScooters.Items.Clear()
            Dim lsvitem As ListViewItem = New ListViewItem()
            For Each bookingAux In booking.Booking_DAO.List
                For Each scooteraux In bookingAux.Scooters
                    lsvitem = ListViewScooters.Items.Add(scooteraux.ID.ToString)
                    lsvitem.SubItems.Add(scooteraux.S_T.ID.ToString)
                    ListViewScooters.Update()
                Next
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub ListViewScooterHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewScooters.SelectedIndexChanged
        If ListViewScooters.SelectedItems IsNot Nothing Then
            Dim time1 As DateTime = DateTime.Parse(DateTimePickerTime1.Value.ToShortDateString).AddHours(NumericUpDownHours1.Value).AddMinutes(NumericUpDownMinutes1.Value)
            Dim time2 As DateTime = DateTime.Parse(DateTimePickerTime2.Value.ToShortDateString).AddHours(NumericUpDownHours2.Value).AddMinutes(NumericUpDownMinutes2.Value)

            For i = 0 To ListViewScooters.SelectedIndices.Count - 1

                Dim ID As Long = Long.Parse(ListViewScooters.SelectedItems.Item(i).Text)
                Dim scooter As Scooter = New Scooter(ID)
                Dim bookingAux As Booking
                scooter.read_Booking_History(time1, time2)
                Me.ListBoxClients.Items.Clear()
                For Each bookingAux In scooter.Bookng
                    Me.ListBoxClients.Items.Add(bookingAux.Clint.ID)
                Next
            Next
        End If
    End Sub

End Class