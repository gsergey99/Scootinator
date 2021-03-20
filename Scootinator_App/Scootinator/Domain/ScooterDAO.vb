Imports System.Data.OleDb
Public Class ScooterDAO
    Private ScooterList As Collection

    Public Sub New()
        Me.ScooterList = New Collection
    End Sub
    Public Function update_Scooter(ByRef s As Scooter) As Integer


        Return DBBroker.GetBroker().Change("UPDATE Scooters SET Description='" & s.Descrip() & "', Type =" & s.S_T.ID & " WHERE ScooterID =" & s.ID() & ";")

    End Function
    Public Function insert_Scooter(ByRef s As Scooter) As Integer


        Return DBBroker.GetBroker().Change("INSERT INTO Scooters (Description, Type)VALUES('" & s.Descrip() & "','" & s.S_T.ID & "');")

    End Function

    Public Sub readall_Scooter(ByVal path As String)
        Dim s As Scooter
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker(path).Read("Select * FROM Scooters ORDER BY ScooterID;")
        While ReadData.Read()
            s = New Scooter(Long.Parse(ReadData("ScooterID").ToString))
            s.readScooter()
            ScooterList.Add(s)
        End While
    End Sub

    Public Sub read_Scooter(ByRef s As Scooter)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT * FROM Scooters WHERE ScooterID=" & s.ID() & ";")
        If ReadData.Read() Then
            s.Descrip = ReadData("Description").ToString
            s.S_T.ID = Long.Parse(ReadData("Type").ToString)
        End If
    End Sub

    Public Function delete_Scooter(ByRef s As Scooter) As Integer

        Return DBBroker.GetBroker().Change("DELETE FROM Scooters WHERE ScooterID=" & s.ID() & ";")

    End Function
    Public Sub read_Booking_History(ByRef s As Scooter, ByVal time1 As DateTime, ByVal time2 As DateTime)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT DISTINCT Client FROM BOOKINGS INNER JOIN RENTALS ON RENTALS.Booking=BOOKINGS.BookingID WHERE Scooter=" & s.ID() & " AND BookingDate BETWEEN #" & time1.ToString("MM/dd/yyyy hh:mm:ss") & "# AND #" & time2.ToString("MM/dd/yyyy hh:mm:ss") & "# ORDER BY Client ;")
        Dim b As Booking
        While ReadData.Read()
            b = New Booking()
            b.Clint.ID = ReadData("Client").ToString
            s.Bookng.Add(b)

        End While
    End Sub

    Public Property List() As Collection
        Get
            Return Me.ScooterList
        End Get
        Set(ByVal list As Collection)
            Me.ScooterList = list
        End Set
    End Property


End Class
