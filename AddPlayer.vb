Imports System.Data.SqlClient

Public Class AddPlayer
    Private ConnStr As String

    Public Sub New(strc As String)
        InitializeComponent()
        ConnStr = strc

    End Sub



    Private Sub AddPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub ConfirmAddButton_Click(sender As Object, e As EventArgs) Handles ConfirmAddButton.Click

        If Me.PlayerNameTextBox.TextLength = 0 Or Me.GamertagTextBox.TextLength = 0 Then
            MessageBox.Show("Player name and Gamertag must be at least one character.")
        Else
            Dim strGT As String = Me.GamertagTextBox.Text.ToString()
            Dim strName As String = Me.PlayerNameTextBox.Text.ToString()
            Using conn As New SqlConnection(ConnStr)
                Using cmd As New SqlCommand
                    cmd.Connection = conn
                    ' Check if gamertag is already being used
                    cmd.CommandText = "SELECT COUNT(*) FROM PlayerDB WHERE GamerTag = @gt"
                    cmd.Parameters.Add("@gt", strGT)
                    conn.Open()
                    If cmd.ExecuteScalar <> 0 Then
                        ' If in use, tell user so
                        MessageBox.Show("Unable to add; a player with that gamertag already exists.")
                    Else
                        ' Else, add the new player to the database
                        cmd.CommandText = "INSERT INTO PlayerDB (Playername, GamerTag, Wins, Losses) VALUES (@name, @tag, 0, 0)"
                        cmd.Parameters.Add("@name", strName)
                        cmd.Parameters.Add("@tag", strGT)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Player has been added.")
                        Me.PlayerNameTextBox.Clear()
                        Me.GamertagTextBox.Clear()
                    End If
                End Using
            End Using
        End If


    End Sub

End Class