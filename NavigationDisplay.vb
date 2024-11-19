Public Class NavigationDisplay
    Private Property pUserInput As Integer
    Public Sub Home()

        Dim uInput As Integer
        Dim i As Integer = 0

        Console.Clear()
        Console.WriteLine("Select an option:")
        Console.WriteLine("1 - Create New Company")
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
                CreateCompany()
            Case 2
                'ModifyAssetTree()
            Case Else
                Debug.WriteLine("Valid case not selected")
        End Select

    End Sub

    Public Sub CreateCompany()

        Dim inp As String

        Console.Clear()

        Console.WriteLine("Input Company name: ")
        inp = Console.ReadLine()

        Dim company As New Company With {
            .Name = inp
        }

        Console.WriteLine("Do you want to create the company " & company.Name & "?")

        Select Case CStr(Console.Read())
            Case "y"
            Case "n"
            Case Else
        End Select

    End Sub

End Class

