Public Class ScooterType
    Private TypeID As Long
    Private Brand As String
    Private MaxWeight As Long
    Private MaxSpeed As Long
    Private PricePerHour As Double
    Private Scooter As Scooter
    Private ScooterTypes As ScooterTypeDAO

    Public Sub New(ByVal ID As Long, ByVal Brand As String, ByVal MaxWeight As Long, ByVal MaxSpeed As Long, ByVal PricePerHour As Double)
        Me.TypeID = ID
        Me.Brand = Brand
        Me.MaxWeight = MaxWeight
        Me.MaxSpeed = MaxSpeed
        Me.PricePerHour = PricePerHour
        Me.ScooterTypes = New ScooterTypeDAO()
    End Sub
    Public Sub New(ByVal Brand As String, ByVal MaxWeight As Long, ByVal MaxSpeed As Long, ByVal PricePerHour As Double)
        Me.Brand = Brand
        Me.MaxWeight = MaxWeight
        Me.MaxSpeed = MaxSpeed
        Me.PricePerHour = PricePerHour
        Me.ScooterTypes = New ScooterTypeDAO()
    End Sub
    Public Sub New(ByVal ID As Long)
        Me.TypeID = ID
        Me.ScooterTypes = New ScooterTypeDAO()
    End Sub
    Public Sub New()
        Me.ScooterTypes = New ScooterTypeDAO()
    End Sub

    Public Property ID() As Long
        Get
            Return Me.TypeID
        End Get
        Set(ByVal value As Long)
            Me.TypeID = value
        End Set
    End Property
    Public Property Brnd() As String
        Get
            Return Me.Brand
        End Get
        Set(ByVal value As String)
            Me.Brand = value
        End Set
    End Property
    Public Property MxWeight() As Long
        Get
            Return Me.MaxWeight
        End Get
        Set(ByVal value As Long)
            Me.MaxWeight = value


        End Set
    End Property
    Public Property MxSpeed As Long
        Get
            Return Me.MaxSpeed
        End Get
        Set(ByVal value As Long)
            Me.MaxSpeed = value
        End Set
    End Property
    Public Property PHour() As Double
        Get
            Return Me.PricePerHour
        End Get
        Set(ByVal value As Double)
            Me.PricePerHour = value
        End Set
    End Property
    Public Property ScooterType() As ScooterTypeDAO
        Get
            Return Me.ScooterTypes
        End Get
        Set(ByVal value As ScooterTypeDAO)
            Me.ScooterTypes = value
        End Set
    End Property

    Public Property Scootr As Scooter
        Get
            Return Me.Scooter
        End Get
        Set(ByVal value As Scooter)
            Me.Scooter = value
        End Set
    End Property

    Public Function deleteScooterType() As Integer

        Return ScooterTypes.delete_Scoot_Type(Me)

    End Function

    Public Function insertScooterType() As Integer

        Return ScooterTypes.insert_Scoot_Type(Me)

    End Function

    Public Sub readScooterType()
        ScooterTypes.read_Scoot_Type(Me)

    End Sub

    Public Sub readallScooterType(ByVal path As String)
        ScooterTypes.readall_Scoot_Type(path)
    End Sub

    Public Function updateScooterType() As Integer

        Return ScooterTypes.update_Scoot_Type(Me)

    End Function
End Class
