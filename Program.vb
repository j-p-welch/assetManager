Imports System
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.IO
Imports LiteDB
Imports Microsoft.VisualBasic.FileIO

Module Program
    Sub Main(args As String())

        If FileSystem.DirectoryExists("C:\ProtonDrive") Then
            DataServer.FilePath = "C:\ProtonDrive\My files\storage\db.db"
        ElseIf FileSystem.DirectoryExists("T:\ProtonDrive") Then
            DataServer.FilePath = "T:\ProtonDrive\My files\storage\db.db"
        Else
            MsgBox("Database file not found")
        End If

        Dim menu As New NavigationDisplay()

        menu.Home()

    End Sub

End Module


