Public Class Scooter
    Private ScooterID As Long
    Private Description As String
    Private Scooter_Type As ScooterType
    Private Scooters As ScooterDAO
    Private Booking As Collection
    Public Sub New(ByVal ID As Long, ByVal Description As String, ByVal ScooterTypeID As Long)
        Me.ScooterID = ID
        Me.Description = Description
        Me.Scooters = New ScooterDAO()
        Me.Scooter_Type = New ScooterType(ScooterTypeID)
        Me.Scooter_Type.readScooterType()
        Me.Booking = New Collection
    End Sub
    Public Sub New(ByVal Description As String, ByVal ScooterTypeID As Long)

        Me.Description = Description
        Me.Scooters = New ScooterDAO()
        Me.Scooter_Type = New ScooterType(ScooterTypeID)
        Me.Booking = New Collection
    End Sub
    Public Sub New(ByVal ID As Long)
        Me.ScooterID = ID
        Me.Scooters = New ScooterDAO
        Me.Scooter_Type = New ScooterType()
        Me.Booking = New Collection
    End Sub

    Public Sub New()
        Me.Scooters = New ScooterDAO
        Me.Scooter_Type = New ScooterType()
        Me.Booking = New Collection
    End Sub
    Public Property S_T() As ScooterType
        Get
            Return Me.Scooter_Type
        End Get
        Set(ByVal value As ScooterType)
            Me.Scooter_Type = value
        End Set
    End Property


    Public Property ID() As Long
        Get
            Return Me.ScooterID
        End Get
        Set(ByVal value As Long)
            Me.ScooterID = value
        End Set
    End Property
    Public Property Descrip() As String
        Get
            Return Me.Description
        End Get
        Set(ByVal value As String)
            Me.Description = value
        End Set
    End Property
    Public Property Scooter_DAO() As ScooterDAO
        Get
            Return Me.Scooters
        End Get
        Set(ByVal value As ScooterDAO)
            Me.Scooters = value


        End Set
    End Property

    Public Property Bookng As Collection
        Get
            Return Me.Booking
        End Get
        Set(ByVal value As Collection)
            Me.Booking = value
        End Set
    End Property

    Public Function deleteScooter() As Integer

        Return Scooters.delete_Scooter(Me)

    End Function

    Public Function insertScooter() As Integer

        Return Scooters.insert_Scooter(Me)

    End Function

    Public Sub readScooter()
        Scooters.read_Scooter(Me)
        Me.Scooter_Type.readScooterType()
    End Sub

    Public Sub readallScooter(ByVal path As String)
        Scooters.readall_Scooter(path)
    End Sub

    Public Function updateScooter() As Integer

        Return Scooters.update_Scooter(Me)

    End Function
    Public Sub read_Booking_History(ByVal time1 As DateTime, ByVal time2 As DateTime)
        Scooters.read_Booking_History(Me, time1, time2)
    End Sub


End Class
