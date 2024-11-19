Imports LiteDB

Public Class Site

    <BsonId>
    Public Property SiteID As String
    Public Property Name As String
    Public Property Address As String
    Public Property PhoneNumber As String
    Public Sub New(siteID As String, Optional name As String = Nothing, Optional address As String = Nothing, Optional phoneNumber As String = Nothing)
        Me.SiteID = siteID
        Me.Name = name
        Me.Address = address
        Me.PhoneNumber = phoneNumber
    End Sub
End Class
