Imports System.Data.SqlClient
Imports System.Windows.Markup

Public Class Manager
    Private ConnStr As String
    Private playerList As List(Of String)
    Private matchList As List(Of Match)
    Private currentMatch As Integer = 1
    Private currentRound As Integer = 1
    Private finished As Boolean = False

    Public Sub New(ByVal pl As List(Of String), strc As String)
        ' This call is required by the designer.
        InitializeComponent()
        playerList = pl
        matchList = New List(Of Match)
        ConnStr = strc
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateMatches()

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        If MsgBox("End the tournament now and return home?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Form1.BindPlayerData()
            Form1.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CreateMatches()
        For i = 0 To playerList.Count - 1
            If i = playerList.Count - 1 Then
                ' Current item is last player in list and has no one to match against; sole player automatically wins
                Dim matchup As New Match(playerList(i), String.Empty)
                matchup.SetWinner = 1
                matchList.Add(matchup)
            Else
                ' Take current item and next item and create a match of the two players
                Dim matchup As New Match(playerList(i), playerList(i + 1))
                matchList.Add(matchup)
                i += 1
            End If
        Next

        ' Empty the list of players so it can be refilled with the round's winners
        playerList.Clear()
        InitializeDisplay()
    End Sub

    Public Sub PrepNextRound()
        currentMatch = 1
        currentRound += 1
        For Each i In matchList
            playerList.Add(i.GetWinner)
        Next

        ' Empty the list of matches to fill it with new ones
        matchList.Clear()
        CreateMatches()
    End Sub


    Public Sub InitializeDisplay()
        If finished = False Then
            If matchList.Item(currentMatch - 1).GetP2 = String.Empty Then
                PrepNextRound()
            Else
                CurrentMatchLabel.Text = "Round " + currentRound.ToString + ": Match " + currentMatch.ToString
                PlayersLabel.Text = matchList.Item(currentMatch - 1).GetP1 + " vs " + matchList.Item(currentMatch - 1).GetP2
                P1RB.Text = matchList.Item(currentMatch - 1).GetP1
                P2RB.Text = matchList.Item(currentMatch - 1).GetP2
            End If

        Else
            CurrentMatchLabel.Visible = False
            PlayersLabel.Text = "Congratulations! " + matchList.Item(currentMatch - 1).GetWinner + " has won the tournament!"
            NextMatchButton.Visible = False
                P1RB.Visible = False
                P2RB.Visible = False
            Label2.Visible = False
        End If

    End Sub

    Private Sub NextMatchButton_Click(sender As Object, e As EventArgs) Handles NextMatchButton.Click
        If currentMatch < matchList.Count Then
            ' There are still matches left in the round
            If Not P1RB.Checked And Not P2RB.Checked Then
                MessageBox.Show("Please select the winner of the match.")
            Else
                CheckedWinner()
                UpdateWL(matchList.Item(currentMatch - 1))
                currentMatch += 1
            End If

        Else
            ' Current match is the last one in the set
            If matchList.Count = 1 Then
                ' Current match is the last one in the tournament as a whole
                If Not P1RB.Checked And Not P2RB.Checked Then
                    MessageBox.Show("Please select the winner of the match.")
                Else
                    CheckedWinner()
                    UpdateWL(matchList.Item(currentMatch - 1))
                    finished = True
                End If

            Else
                If Not P1RB.Checked And Not P2RB.Checked Then
                    MessageBox.Show("Please select the winner of the match.")
                Else
                    CheckedWinner()
                    UpdateWL(matchList.Item(currentMatch - 1))
                    PrepNextRound()
                End If
            End If
        End If

        InitializeDisplay()
    End Sub

    Private Sub UpdateWL(val As Match)
        Dim strWinGT As String = matchList.Item(currentMatch - 1).GetWinner()
        Dim strLoseGT As String = matchList.Item(currentMatch - 1).GetLoser()
        Using conn As New SqlConnection(ConnStr)
            Using cmd As New SqlCommand
                cmd.Connection = conn
                conn.Open()
                cmd.CommandText = "UPDATE PlayerDB SET Wins = Wins + 1 WHERE GamerTag = @win"
                cmd.Parameters.Add("@win", strWinGT)
                cmd.ExecuteNonQuery()
            End Using
            Using cmd As New SqlCommand
                cmd.Connection = conn
                cmd.CommandText = "UPDATE PlayerDB SET Losses = Losses + 1 WHERE GamerTag = @lose"
                cmd.Parameters.Add("@lose", strLoseGT)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Private Sub CheckedWinner()
        ' Set the winner of the match according to which radio button is checked
        If P1RB.Checked Then
            matchList.Item(currentMatch - 1).SetWinner = 1
        ElseIf P2RB.Checked Then
            matchList.Item(currentMatch - 1).SetWinner = 2
        End If
    End Sub

End Class