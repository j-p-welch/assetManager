Imports System
Imports LiteDB

Module Program

    'Dim db As New DatabaseServer
    Sub Main(args As String())
        Dim menu As New NavigationDisplay
        menu.Home()
    End Sub
End Module

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

Public Class Part

    <BsonId>
    Public Property PartID As String

    Public Sub New()

    End Sub

End Class

Public Class DatabaseServer
    Public Property Database As LiteDatabase
    Private Property FilePath As String = "\db.tb"

End Class

Public Class NavigationDisplay

    Private Property pUserInput As Integer

    Public Sub Home()

        Dim uInput As Integer
        Dim i As Integer = 0

        Console.WriteLine("Select an option:")
        Console.WriteLine("1 - View asset tree")
        Console.WriteLine("2 - Modify asset tree")

        Do
            If i > 0 Then
                Console.WriteLine("Please select option")
            End If
            uInput = Console.ReadLine()
            i += 1
        Loop Until (0 < uInput And uInput < 3)

        Select Case uInput
            Case 1
                ViewAssetTree()
            Case 2
                ModifyAssetTree()
            Case Else
                Debug.WriteLine("Valid case not selected")
        End Select

    End Sub

    Public Sub ViewAssetTree()
        Dim inp As String = Nothing

        Console.WriteLine("***==View Asset Tree==***")
        inp = Console.ReadLine()

        If inp = "r" Then
            Console.Clear()
            Me.Home()
        End If

    End Sub
    Public Sub ModifyAssetTree()
        Dim inp As String = Nothing

        Console.WriteLine("***==Modify Asset Tree==***")
        inp = Console.ReadLine()

        If inp = "r" Then
            Console.Clear()
            Me.Home()
        End If

    End Sub
End Class