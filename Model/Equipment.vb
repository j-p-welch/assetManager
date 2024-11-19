Imports LiteDB
Public Class Equipment
    <BsonId>
    Public Property EquipmentID As String
    Public Property Name As String
    Public Property Type As String
    Public Property Subtype As String
    Public Property ParentLocationID As String
    Public Property ParentEquipmentId As String
    Public Property SubEquipmentIDs As List(Of Equipment)
    Public Property Parts As List(Of Part)

    Public Sub New(equipmentID As String, Optional name As String = Nothing, Optional type As String = Nothing,
                   Optional subtype As String = Nothing, Optional parentLocationID As String = Nothing,
                   Optional parentEquipmentID As String = Nothing)

        Me.EquipmentID = equipmentID
        Me.Name = name
        Me.Type = type
        Me.Subtype = subtype
        Me.ParentLocationID = parentLocationID
        Me.ParentEquipmentId = parentEquipmentID

        'need code for adding equipment to parents if not exist

    End Sub

End Class
