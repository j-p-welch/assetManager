Imports System
Imports LiteDB

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
    End Sub
End Module

Public Class LogicalLocation

    <BsonId>
    Public Property LocationID As String
    Public Property Name As String
    Public Property ParentLocationID As String
    Public Property SubLocationIDs As List(Of String)

    Public Sub New(locationID As String, Optional name As String, Optional parentLocationID As String)
        Me.LocationID = locationID
        Me.Name = name
        Me.ParentLocationID = parentLocationID
        Me.SubLocationIDs = New List(Of String)()

    End Sub



End Class
