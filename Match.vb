
Public Class Match
    Private player1 As String
    Private player2 As String
    Private winner As Integer

    Public Sub New(p1 As String, p2 As String)
        player1 = p1
        player2 = p2
        winner = 0
    End Sub

    Public ReadOnly Property GetP1()
        Get
            Return player1
        End Get
    End Property

    Public ReadOnly Property GetP2()
        Get
            Return player2
        End Get
    End Property


    Public WriteOnly Property SetWinner() As Integer
        Set(ByVal value As Integer)
            winner = value
        End Set
    End Property


    Public Function GetWinner() As String
        If winner = 1 Then
            Return player1
        Else
            Return player2
        End If

    End Function

    Public Function GetLoser() As String
        If winner = 1 Then
            Return player2
        Else
            Return player1
        End If

    End Function




End Class
