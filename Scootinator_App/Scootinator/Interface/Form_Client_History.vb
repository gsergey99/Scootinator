Public Class Form_Client_History
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Try
            ListBoxScootersRented.Items.Clear()
            Dim time1 As DateTime = DateTime.Parse(DateTimePickerTime1.Value.ToShortDateString).AddHours(NumericUpDownHours1.Value).AddMinutes(NumericUpDownMinutes1.Value)
            Dim time2 As DateTime = DateTime.Parse(DateTimePickerTime2.Value.ToShortDateString).AddHours(NumericUpDownHours2.Value).AddMinutes(NumericUpDownMinutes2.Value)
            Dim booking As Booking = New Booking()
            Dim bookingaux As Booking
            booking.ClientHistory(time1, time2)
            Dim lsvitem As ListViewItem = New ListViewItem()
            ListViewClientHistory.Items.Clear()
            For Each bookingaux In booking.Booking_DAO.List
                lsvitem = ListViewClientHistory.Items.Add(bookingaux.Clint.ID)
                lsvitem.SubItems.Add(bookingaux.Clint.Name)
                lsvitem.SubItems.Add(bookingaux.Clint.Telephone.ToString)
                lsvitem.SubItems.Add(bookingaux.Clint.Location)
                lsvitem.SubItems.Add(bookingaux.Clint.Eml)
            Next
            ListViewClientHistory.Update()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub



    Private Sub ListViewClientHistory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewClientHistory.SelectedIndexChanged
        If ListViewClientHistory.SelectedItems IsNot Nothing Then
            Dim time1 As DateTime = DateTime.Parse(DateTimePickerTime1.Value.ToShortDateString).AddHours(NumericUpDownHours1.Value).AddMinutes(NumericUpDownMinutes1.Value)
            Dim time2 As DateTime = DateTime.Parse(DateTimePickerTime2.Value.ToShortDateString).AddHours(NumericUpDownHours2.Value).AddMinutes(NumericUpDownMinutes2.Value)

            For i = 0 To ListViewClientHistory.SelectedIndices.Count - 1
                Dim booking As Booking = New Booking()
                booking.Clint.ID = ListViewClientHistory.SelectedItems.Item(i).Text
                Dim scooter As Scooter
                booking.ScooterOfClientstHistory(time1, time2)
                ListBoxScootersRented.Items.Clear()
                For Each scooter In booking.Scooters
                    Me.ListBoxScootersRented.Items.Add(scooter.ID)
                Next
            Next
        End If
    End Sub

End Class