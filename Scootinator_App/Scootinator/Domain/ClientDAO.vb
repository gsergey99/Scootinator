Imports System.Data.OleDb
Public Class ClientDAO
    Private ClientList As Collection
    Public Sub New()
        Me.ClientList = New Collection
    End Sub
    Public Function update_Client(ByRef c As Client) As Integer

        Return DBBroker.GetBroker().Change("UPDATE CLIENTS SET ClientName = '" & c.Name() & "', TelephNumber = " & c.Telephone & ", Address = '" & c.Location & "', Email = '" & c.Eml & "' WHERE ClientID ='" & c.ID() & "';")

    End Function
    Public Function insert_Client(ByRef c As Client) As Integer

        Return DBBroker.GetBroker().Change("INSERT INTO CLIENTS VALUES('" & c.ID() & "','" & c.Name() & "','" & c.Telephone & "','" & c.Location & "','" & c.Eml & "');")

    End Function

    Public Sub readall_Client(ByVal path As String)
        Dim c As Client
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker(path).Read("SELECT * FROM CLIENTS ORDER BY ClientID;")
        While ReadData.Read()
            c = New Client(ReadData("ClientID").ToString)
            c.readClient()
            ClientList.Add(c)
        End While
    End Sub

    Public Sub read_Client(ByRef c As Client)
        Dim ReadData As OleDbDataReader
        ReadData = DBBroker.GetBroker().Read("SELECT * FROM CLIENTS WHERE ClientID='" & c.ID() & "';")
        If ReadData.Read() Then
            c.Name = ReadData("ClientName").ToString
            c.Telephone = Integer.Parse(ReadData("TelephNumber").ToString)
            c.Location = ReadData("Address").ToString
            c.Eml = ReadData("Email").ToString
        End If
    End Sub

    Public Function delete_Client(ByRef c As Client) As Integer
        Return DBBroker.GetBroker().Change("DELETE FROM CLIENTS WHERE ClientID='" & c.ID() & "';")
    End Function

    Public Property List() As Collection
        Get
            Return Me.ClientList
        End Get
        Set(ByVal list As Collection)
            Me.ClientList = list
        End Set
    End Property


End Class


