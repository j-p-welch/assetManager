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