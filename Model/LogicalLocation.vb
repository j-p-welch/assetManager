Imports LiteDB
Public Class LogicalLocation

    <BsonId>
    Public Property LocationID As String
    Public Property Name As String
    Public Property Subtype As String
    Public Property ParentLocationID As String
    Public Property SubLocationIDs As List(Of String)

    Public Sub New(locationID As String, Optional name As String = Nothing, Optional parentLocationID As String = Nothing)

        Me.LocationID = locationID
        Me.Name = name
        Me.ParentLocationID = parentLocationID
        Me.SubLocationIDs = New List(Of String)()

    End Sub

End Class
