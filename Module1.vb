Module Module1
    Class Shape
        Protected width As Double
        Protected height As Double
        Protected radius As Double
        Public Const pi As Double = Math.PI
        Public Sub setwidth(ByVal w As Double)
            width = w
        End Sub
        Public Sub setheight(ByVal w As Double)
            height = w
        End Sub
        Public Sub setradius(ByVal r As Double)
            radius = r
        End Sub

    End Class
    Class Rectangle
        Inherits Shape
        Public Function area()
            Return (width * height)
        End Function
        Public Function Perimeter()
            Return (width + height) * 2
        End Function
    End Class

    Class Square
        Inherits Shape
        Public Function area()
            Return (height * height)
        End Function
        Public Function Perimeter()
            Return (height * 4)
        End Function
    End Class

    Class Circle
        Inherits Shape
        Public Function area()
            Return (pi * radius ^ 2)
        End Function
        Public Function Perimeter()
            Return (2 * pi * radius)
        End Function
    End Class

    Class Disc
        Inherits Shape
        Public Function area()
            Return (2 * pi * radius ^ 2 * 2 * pi * radius * height)
        End Function
        Public Function volume()
            Return (pi * radius ^ 2 * height)
        End Function
    End Class
    Sub Main()
        Dim Rect As New Rectangle
        Dim Squr As New Square
        Dim Circ As New Circle
        Dim disc As New Disc
        Dim code As String
        Do
            Console.WriteLine("******* Program Calculate the area, perimeter and volume of geometric shapes *****")
            Console.WriteLine("Choose from the following geometric shapes ")
            Console.WriteLine("1-Rectangle")
            Console.WriteLine("2-Square")
            Console.WriteLine("3-Circle")
            Console.WriteLine("4-Disc")
            Console.WriteLine("5-Exit")
            code = Console.ReadLine()
            Select Case code
                Case 1
                    Console.WriteLine("Please Enter width Rectangle  ")
                    Rect.setwidth(Console.ReadLine())
                    Console.WriteLine("Please Enter height Rectangle ")
                    Rect.setheight(Console.ReadLine())
                    Console.WriteLine("Rectangle  Area = " & Rect.area())
                    Console.WriteLine("Rectangle Perimeter = " & Rect.Perimeter())
                    Console.WriteLine("please Enter any key to  continue")
                Case 2
                    Console.WriteLine("Please Enter lenght Square")
                    Squr.setheight(Console.ReadLine())
                    Console.WriteLine("Square Area  = " & Squr.area())
                    Console.WriteLine("Square Perimeter = " & Squr.Perimeter())
                    Console.WriteLine("please Enter any key to  continue")
                Case 3
                    Console.WriteLine("Please Enter Radius Circle")
                    Circ.setradius(Console.ReadLine())
                    Console.WriteLine("Circle Area = " & Circ.area())
                    Console.WriteLine("Circle Perimeter = " & Circ.Perimeter())
                    Console.WriteLine("please Enter any key to  continue")
                Case 4
                    Console.WriteLine("Please Enter Radius Disc ")
                    disc.setradius(Console.ReadLine())
                    Console.WriteLine("Please Enter lenght Disc")
                    disc.setheight(Console.ReadLine())
                    Console.WriteLine("Disc Area = " & disc.area())
                    Console.WriteLine("Disc volume = " & disc.volume())
                    Console.WriteLine("please Enter any key to  continue")
                Case 5
                    Exit Do
                Case Else
                    Console.WriteLine("Invalid choice")
                    Console.WriteLine("please Enter any key to  continue")
            End Select
            Console.ReadLine()
        Loop Until code = 5


    End Sub

End Module
