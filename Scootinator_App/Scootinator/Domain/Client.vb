Public Class Client
    Private ClientID As String
    Private ClientName As String
    Private TelephNumber As Integer
    Private Address As String
    Private Email As String
    Private Booking As Collection
    Private Clients As ClientDAO
    Public Sub New(ByVal ID As String, ByVal Name As String, ByVal Teleph As Integer, ByVal Address As String, ByVal Email As String)
        Me.ClientName = Name
        Me.ClientID = ID
        Me.TelephNumber = Teleph
        Me.Address = Address
        Me.Email = Email
        Me.Clients = New ClientDAO()
        Me.Booking = New Collection
    End Sub
    Public Sub New(ByVal ID As String)
        Me.ClientID = ID
        Me.Clients = New ClientDAO()
        Me.Booking = New Collection
    End Sub
    Public Sub New()
        Me.Clients = New ClientDAO()
        Me.Booking = New Collection
    End Sub
    Public Property ID() As String
        Get
            Return Me.ClientID
        End Get
        Set(ByVal value As String)
            Me.ClientID = value
        End Set
    End Property
    Public Property Telephone() As Integer
        Get
            Return Me.TelephNumber
        End Get
        Set(ByVal value As Integer)
            Me.TelephNumber = value
        End Set
    End Property
    Public Property Client_DAO() As ClientDAO
        Get
            Return Me.Clients
        End Get
        Set(ByVal value As ClientDAO)
            Me.Clients = value


        End Set
    End Property
    Public Property Name As String
        Get
            Return Me.ClientName
        End Get
        Set(ByVal value As String)
            Me.ClientName = value
        End Set
    End Property
    Public Property Location() As String
        Get
            Return Me.Address
        End Get
        Set(ByVal value As String)
            Me.Address = value
        End Set
    End Property
    Public Property Eml() As String
        Get
            Return Me.Email
        End Get
        Set(ByVal value As String)
            Me.Email = value
        End Set
    End Property
    Public Property Bookings() As Collection
        Get
            Return Me.Booking
        End Get
        Set(ByVal value As Collection)
            Me.Booking = value
        End Set
    End Property
    Public Function deleteClient() As Integer

        Return Clients.delete_Client(Me)

    End Function

    Public Function insertClient() As Integer

        Return Clients.insert_Client(Me)

    End Function

    Public Sub readClient()
        Clients.read_Client(Me)

    End Sub

    Public Sub readallClient(ByVal path As String)
        Clients.readall_Client(path)
    End Sub

    Public Function updateClient() As Integer

        Return Clients.update_Client(Me)

    End Function
End Class
