Public Class Form_Profit_Ranking
    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        Try
            Dim time1 As DateTime = DateTime.Parse(DateTimePickerTime1.Value.ToShortDateString).AddHours(NumericUpDownHours1.Value).AddMinutes(NumericUpDownMinutes1.Value)
            Dim time2 As DateTime = DateTime.Parse(DateTimePickerTime2.Value.ToShortDateString).AddHours(NumericUpDownHours2.Value).AddMinutes(NumericUpDownMinutes2.Value)
            Dim booking As Booking = New Booking()
            Dim scooterAux As Scooter
            Dim bookingaux As Booking
            booking.ProfitRanking(time1, time2)
            Dim lsvitem As ListViewItem = New ListViewItem()
            ListViewProfitRanking.Items.Clear()
            Dim rankingNum As Integer
            For Each bookingaux In booking.Booking_DAO.List
                For Each scooterAux In bookingaux.Scooters
                    rankingNum += 1
                    lsvitem = ListViewProfitRanking.Items.Add(rankingNum.ToString)
                    lsvitem.SubItems.Add(scooterAux.S_T.ID.ToString)
                    lsvitem.SubItems.Add(scooterAux.S_T.Brnd.ToString)
                    lsvitem.SubItems.Add(scooterAux.S_T.MxWeight.ToString)
                    lsvitem.SubItems.Add(scooterAux.S_T.MxSpeed.ToString)
                    lsvitem.SubItems.Add(scooterAux.S_T.PHour.ToString)
                Next
            Next
            ListViewProfitRanking.Update()

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString, ex.Source.ToString, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End Try
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ListViewProfitRanking_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewProfitRanking.SelectedIndexChanged

    End Sub

    Private Sub Form_Profit_Ranking_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class