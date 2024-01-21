Imports vbinterfaces

Public Class Class1
    Implements IClass1

    Private Sub SayHello() Implements IClass1.SayHello
        Throw New NotImplementedException()
    End Sub

    Public Function GetHello() As String Implements IClass1.GetHello
        Return "Hello"
    End Function
End Class
