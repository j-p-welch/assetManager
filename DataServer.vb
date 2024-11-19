Imports LiteDB
Public Class DataServer
    Public Shared Property FilePath As String
    Public Property Database As LiteDatabase

    Public Sub New()
        Me.Database = New LiteDatabase(DataServer.FilePath)
    End Sub

    Public Sub CreateCompany(inp As Company)

        Dim db As New LiteDatabase(FilePath)
        Dim col As LiteCollection(Of Company)

        col = db.GetCollection(Of Company)("Company")
        col.Insert(inp)

    End Sub

End Class
