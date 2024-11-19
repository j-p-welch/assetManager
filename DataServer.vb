Imports LiteDB
Public Class DataServer
    Public Property FilePath As String
    Public Property Database As LiteDatabase
    Public Sub New(filePath As String)
        Me.FilePath = filePath
        Me.Database = New LiteDatabase(filePath)
    End Sub

    Public Sub CreateCompany(inp As Company)

        Dim db As New LiteDatabase(FilePath)
        Dim col As LiteCollection(Of Company)

        col = db.GetCollection(Of Company)("Company")
        col.Insert(inp)

    End Sub

End Class
