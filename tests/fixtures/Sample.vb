Imports System

Public Interface IUserRepository
    Function FindById(id As Integer) As User
End Interface

Public Class User
    Public Property Id As Integer
End Class

Public Class InMemoryRepo
    Implements IUserRepository

    Public Function FindById(id As Integer) As User Implements IUserRepository.FindById
        Return New User()
    End Function

    Public Sub Save(user As User)
        Console.WriteLine(user.Id)
    End Sub
End Class