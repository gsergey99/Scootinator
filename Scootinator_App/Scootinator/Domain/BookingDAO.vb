Imports System.Data.OleDb

Public Class BookingDAO
    Private BookingList As Collection
    Public Sub New()
        Me.BookingList = New Collection
    End Sub
    Public Function check_Booking(ByRef b As Booking) As Boolean
        Dim scooter As Scooter
        Dim available As Boolean = True
        Dim ReadData As OleDbDataReader
        For Each scooter In b.Scooters
            ReadData = DBBroker.GetBroker().Read("SELECT BeginTime, EndTime FROM Bookings, Rentals WHERE Scooter = " & scooter.ID & " AND Booking = BookingID AND ((BeginTime BETWEEN #" & b.BeginT.ToString("MM/dd/yyyy hh:mm:ss") & "# AND #" & b.EndT.ToString("MM/dd/yyyy hh:mm:ss") & "#) OR (EndTime BETWEEN #" & b.BeginT.ToString("MM/dd/yyyy hh:mm:ss") & "# AND #" & b.EndT.ToString("MM/dd/yyyy hh:mm:ss") & "#) OR (#" & b.BeginT.ToString("MM/dd/yyyy hh:mm:ss") & "#  BETWEEN BeginTime AND EndTime) OR (#" & b.EndT.ToString("MM/dd/yyyy hh:mm:ss") & "# BETWEEN BeginTime AND EndTime ));")

            If Not ReadData.Read() Then

                available = True
            Else
                available = False
                Exit For
            End If

        Next
        Return available
    End Function

    Public Function insert_Booking(ByRef b As Booking) As Integer

        Return DBBroker.GetBroker().Change("INSERT INTO Bookings (BeginTime, EndTime, Client, BookingDate, TotalPrice) VALUES ('" & b.BeginT & "', '" & b.EndT & "', '" & b.Clint.ID & "', '" & b.BDate & "', '" & b.TPrice & "');")

    End Function

    Public Sub search_BookingID(ByRef b As Booking)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT @@Identity AS ID;")
        If ReadData.Read() Then
            b.ID = Long.Parse(ReadData("ID").ToString)
        End If
    End Sub

    Public Function insert_Rentals(ByRef b As Booking, ByRef s As Scooter) As Integer

        Return DBBroker.GetBroker().Change("INSERT INTO Rentals VALUES (" & b.ID & "," & s.ID & ");")

    End Function

    Public Sub Readall(ByVal path As String)
        Dim b As Booking
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker(path).Read("SELECT * FROM Bookings ORDER BY BookingID;")
        While ReadData.Read()
            b = New Booking(Integer.Parse(ReadData("BookingID").ToString))
            b.readBooking()
            BookingList.Add(b)
        End While
    End Sub

    Public Sub read_Booking(ByRef b As Booking)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT * FROM Bookings WHERE BookingID=" & b.ID() & ";")
        If ReadData.Read() Then
            b.BeginT = Date.Parse(ReadData("BeginTime").ToString)
            b.EndT = Date.Parse(ReadData("EndTime").ToString)
            b.Clint.ID = ReadData("Client").ToString
            b.Clint.readClient()
            b.BDate = Date.Parse(ReadData("BookingDate").ToString)
            b.TPrice = Double.Parse(ReadData("TotalPrice").ToString)
        End If
    End Sub

    Public Sub read_Rentals(ByRef b As Booking)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT Scooter FROM Rentals WHERE Booking = " & b.ID() & ";")
        Dim scooterID As Long
        Dim scooter As Scooter
        While ReadData.Read()
            scooterID = Long.Parse(ReadData("Scooter").ToString)
            scooter = New Scooter(scooterID)
            scooter.readScooter()
            b.Scooters.Add(scooter)
        End While
    End Sub
    Public Function delete(ByRef b As Booking) As Integer

        Return DBBroker.GetBroker().Change("DELETE FROM Bookings WHERE BookingID=" & b.ID() & ";")

    End Function

    Public Sub readClientHistory(ByVal time1 As DateTime, ByVal time2 As DateTime)
        Dim ReadData As OleDbDataReader
        Dim b As Booking
        Dim s As Scooter
        ReadData = DBBroker.GetBroker().Read("SELECT c.ClientID, c.TelephNumber, c.ClientName, c.Address, c.Email FROM (BOOKINGS b INNER JOIN CLIENTS c ON b.Client=c.ClientID) INNER JOIN RENTALS r ON b.BookingID=r.Booking  WHERE BookingDate BETWEEN #" & time1.ToString("MM/dd/yyyy hh:mm:ss") & "# AND #" & time2.ToString("MM/dd/yyyy hh:mm:ss") & "# GROUP BY c.ClientID, c.TelephNumber, c.ClientName, c.Address, c.Email ORDER BY c.ClientID ;")
        While ReadData.Read()
            b = New Booking()
            s = New Scooter()
            b.Clint.ID = ReadData("ClientID").ToString
            b.Clint.Name = ReadData("ClientName").ToString
            b.Clint.Telephone = Integer.Parse(ReadData("TelephNumber").ToString)
            b.Clint.Location = ReadData("Address").ToString
            b.Clint.Eml = ReadData("Email").ToString
            BookingList.Add(b)
        End While
    End Sub
    Public Sub readScooterHistorical(ByVal time1 As DateTime, ByVal time2 As DateTime)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT DISTINCT Scooter,Type FROM (BOOKINGS INNER JOIN RENTALS ON BOOKINGS.BookingID=RENTALS.Booking) INNER JOIN SCOOTERS ON SCOOTERS.ScooterID=RENTALS.Scooter  WHERE BookingDate BETWEEN #" & time1.ToString("MM/dd/yyyy hh:mm:ss") & "# AND #" & time2.ToString("MM/dd/yyyy hh:mm:ss") & "# ORDER BY Scooter;")
        Dim b As Booking
        Dim s As Scooter
        While ReadData.Read()
            b = New Booking()
            s = New Scooter()
            s.ID = Long.Parse(ReadData("Scooter").ToString)
            s.S_T.ID = Long.Parse(ReadData("Type").ToString)
            b.Scooters.Add(s)
            BookingList.Add(b)
        End While
    End Sub

    Public Sub readProfitRanking(ByVal time1 As DateTime, ByVal time2 As DateTime)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT DISTINCT st.TypeID,  st.Brand, st.MaxWeight, st.MaxSpeed, ROUND(SUM(24*(st.PricePerHour*(b.EndTime-b.BeginTime))),2) AS TotalIncome FROM ((BOOKINGS b INNER JOIN RENTALS r ON b.BookingID=r.Booking) INNER JOIN SCOOTERS s ON s.ScooterID=r.Scooter) INNER JOIN SCOOT_TYPE st ON st.TypeID=s.Type  WHERE (b.BookingDate BETWEEN #" & time2.ToString("MM/dd/yyyy hh:mm:ss") & "# AND #" & time1.ToString("MM/dd/yyyy hh:mm:ss") & "#) GROUP BY st.TypeID,  st.Brand, st.MaxWeight, st.MaxSpeed ORDER BY ROUND(SUM(24*(st.PricePerHour*(b.EndTime-b.BeginTime))),2) DESC;")
        Dim b As Booking = New Booking()
        Dim s As Scooter
        While ReadData.Read()
            s = New Scooter()
            s.S_T.ID = Long.Parse(ReadData("TypeID").ToString)
            s.S_T.Brnd = ReadData("Brand").ToString
            s.S_T.MxWeight = Long.Parse(ReadData("MaxWeight").ToString)
            s.S_T.MxSpeed = Long.Parse(ReadData("MaxSpeed").ToString)
            s.S_T.PHour = Double.Parse(ReadData("TotalIncome").ToString)
            b.Scooters.Add(s)
        End While
        BookingList.Add(b)
    End Sub
    Public Sub readScooterOfClientsHistory(ByRef b As Booking, ByVal time1 As DateTime, ByVal time2 As DateTime)
        Dim ReadData As OleDbDataReader
        Dim s As Scooter
        ReadData = DBBroker.GetBroker().Read("SELECT r.Scooter FROM (BOOKINGS b INNER JOIN CLIENTS c ON b.Client=c.ClientID) INNER JOIN RENTALS r ON b.BookingID=r.Booking WHERE BookingDate BETWEEN #" & time1.ToString("MM/dd/yyyy hh:mm:ss") & "# AND #" & time2.ToString("MM/dd/yyyy hh:mm:ss") & "# AND c.ClientID = '" & b.Clint.ID & "' ORDER BY r.Scooter ;")
        While ReadData.Read()
            s = New Scooter
            s.ID = Long.Parse(ReadData("Scooter").ToString)
            b.Scooters.Add(s)
        End While
    End Sub

    Public Property List() As Collection
        Get
            Return Me.BookingList
        End Get
        Set(ByVal list As Collection)
            Me.BookingList = list
        End Set
    End Property



End Class
