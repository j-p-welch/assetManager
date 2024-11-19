Imports System
Imports LiteDB
Imports Microsoft.VisualBasic.FileIO

Module Program

    Sub Main(args As String())

        Dim db As New DataServer("C:\ProtonDrive\My files\storage\db.db")
        Dim menu As New NavigationDisplay()

        menu.Home()

    End Sub

End Module


