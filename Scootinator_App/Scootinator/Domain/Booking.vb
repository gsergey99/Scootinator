Public Class Booking
    Private BookingID As Long
    Private BeginTime As Date
    Private EndTime As Date
    Private Client As Client
    Private BookingDate As Date
    Private TotalPrice As Double
    Private scoot As Collection
    Private Bookings As BookingDAO
    Public Sub New(ByVal BeginTime As DateTime, ByVal EndTime As DateTime, ByVal Client As Client, ByVal BookingDate As DateTime, ByVal Total As Double)
        Me.TotalPrice = Total
        Me.BeginTime = BeginTime
        Me.EndTime = EndTime
        Me.BookingDate = BookingDate
        Me.Bookings = New BookingDAO()
        Me.Client = Client
        Me.scoot = New Collection
    End Sub
    Public Sub New(ByVal ID As Long)
        Me.BookingID = ID
        Me.Bookings = New BookingDAO
        Me.Client = New Client
        Me.scoot = New Collection
    End Sub
    Public Sub New()
        Me.Bookings = New BookingDAO()
        Me.Client = New Client()
        Me.scoot = New Collection
    End Sub
    Public Sub New(ByVal ID As Long, ByVal BeginTime As Date, ByVal EndTime As Date)
        Me.BeginTime = BeginTime
        Me.EndTime = EndTime
        Me.BookingID = ID
        Me.Bookings = New BookingDAO
        Me.scoot = New Collection
    End Sub
    Public Property ID() As Long
        Get
            Return Me.BookingID
        End Get
        Set(ByVal value As Long)
            Me.BookingID = value
        End Set
    End Property
    Public Property BeginT() As Date
        Get
            Return Me.BeginTime
        End Get
        Set(ByVal value As Date)
            Me.BeginTime = value
        End Set
    End Property
    Public Property EndT() As Date
        Get
            Return Me.EndTime
        End Get
        Set(ByVal value As Date)
            Me.EndTime = value


        End Set
    End Property

    Public Property BDate() As Date
        Get
            Return Me.BookingDate
        End Get
        Set(ByVal value As Date)
            Me.BookingDate = value
        End Set
    End Property
    Public Property TPrice() As Double
        Get
            Return Me.TotalPrice
        End Get
        Set(ByVal value As Double)
            Me.TotalPrice = value
        End Set
    End Property
    Public Property Scooters() As Collection
        Get
            Return Me.scoot
        End Get
        Set(ByVal value As Collection)
            Me.scoot = value
        End Set
    End Property
    Public Property Booking_DAO() As BookingDAO
        Get
            Return Me.Bookings
        End Get
        Set(ByVal value As BookingDAO)
            Me.Bookings = value
        End Set
    End Property
    Public Property Clint() As Client
        Get
            Return Me.Client
        End Get
        Set(ByVal value As Client)
            Me.Client = value
        End Set
    End Property

    Public Function deleteBooking() As Integer
        Dim resul As Integer
        resul = Bookings.delete(Me)
        Return resul
    End Function

    Public Function insertBooking() As Integer
        Dim result As Integer = 0
        Dim scooterAux As Scooter
        result = Bookings.insert_Booking(Me)
            If result = 1 Then
                Bookings.search_BookingID(Me)
                For Each scooterAux In Me.Scooters
                    Bookings.insert_Rentals(Me, scooterAux)
                Next
            End If

        Return result
    End Function

    Public Sub readBooking()
        Bookings.read_Booking(Me)
        Bookings.read_Rentals(Me)
    End Sub

    Public Sub readallBooking(ByVal path As String)
        Bookings.Readall(path)
    End Sub

    Public Sub CalculateTotalPrice()
        Dim interval As TimeSpan = Me.EndTime.Subtract(Me.BeginTime)
        Dim totaltime As Double = interval.TotalHours
        Dim result As Double
        Dim scooteraux As Scooter
        If Bookings.check_Booking(Me) = True Then
            For Each scooteraux In Me.Scooters
                scooteraux.readScooter()
                result += (totaltime * scooteraux.S_T.PHour)
            Next
        End If

        Me.TotalPrice = result
    End Sub
    Public Sub ClientHistory(ByVal time1 As DateTime, ByRef time2 As DateTime)

        Me.Bookings.readClientHistory(time1, time2)

    End Sub
    Public Sub ScooterHistory(ByVal time1 As DateTime, ByRef time2 As DateTime)

        Me.Bookings.readScooterHistorical(time1, time2)

    End Sub
    Public Sub ProfitRanking(ByVal time1 As DateTime, ByVal time2 As DateTime)
        Me.Bookings.readProfitRanking(time1, time2)
    End Sub
    Public Sub ScooterOfClientstHistory(ByVal time1 As DateTime, ByRef time2 As DateTime)

        Me.Bookings.readScooterOfClientsHistory(Me, time1, time2)

    End Sub

End Class
