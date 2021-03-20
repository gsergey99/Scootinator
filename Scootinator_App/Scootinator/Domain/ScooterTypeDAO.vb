Imports System.Data.OleDb
Public Class ScooterTypeDAO
    Private ScooterList As Collection

    Public Sub New()
        Me.ScooterList = New Collection
    End Sub
    Public Function update_Scoot_Type(ByRef s As ScooterType) As Integer

        Return DBBroker.GetBroker().Change("UPDATE SCOOT_TYPE SET Brand='" & s.Brnd() & "', MaxWeight=" & s.MxWeight() & ", MaxSpeed='" & s.MxSpeed() & "', PricePerHour='" & s.PHour() & "' WHERE TypeID =" & s.ID() & ";")

    End Function
    Public Function insert_Scoot_Type(ByRef s As ScooterType) As Integer

        Return DBBroker.GetBroker().Change("INSERT INTO SCOOT_TYPE (Brand, MaxWeight, MaxSpeed, PricePerHour) VALUES('" & s.Brnd() & "','" & s.MxWeight() & "','" & s.MxSpeed & "','" & s.PHour & "');")

    End Function

    Public Sub readall_Scoot_Type(ByVal path As String)
        Dim st As ScooterType
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker(path).Read("SELECT * FROM SCOOT_TYPE ORDER BY TypeID;")
        While ReadData.Read()
            st = New ScooterType(Long.Parse(ReadData("TypeID").ToString))
            st.readScooterType()
            ScooterList.Add(st)
        End While
    End Sub

    Public Sub read_Scoot_Type(ByRef st As ScooterType)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT * FROM SCOOT_TYPE WHERE TypeID=" & st.ID() & ";")
        If ReadData.Read() Then
            st.Brnd() = ReadData("Brand").ToString
            st.MxWeight = Long.Parse(ReadData("MaxWeight").ToString)
            st.MxSpeed = Long.Parse(ReadData("MaxSpeed").ToString)
            st.PHour = Convert.ToDouble(ReadData("PricePerHour").ToString)
        End If
    End Sub


    Public Function delete_Scoot_Type(ByVal st As ScooterType) As Integer

        Return DBBroker.GetBroker().Change("DELETE FROM SCOOT_TYPE WHERE TypeID=" & st.ID() & ";")

    End Function

    Public Property List() As Collection
        Get
            Return Me.ScooterList
        End Get
        Set(ByVal list As Collection)
            Me.ScooterList = list
        End Set
    End Property
End Class
