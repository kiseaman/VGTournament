Imports System.Data.Entity
Imports System.Data.SqlClient

Public Class Form1
    Private Const ConnStr As String = "Data Source=DOUBLECHOCOLATE\SQLExpress;" + "integrated security=SSPI;" + "database=KirasDB"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate DataGridTable on load
        BindPlayerData()
    End Sub

    Private Sub CreateTourneyButton_Click(sender As Object, e As EventArgs) Handles CreateTourneyButton.Click
        Dim psel As New PlayerSelect(ConnStr)
        psel.Show()
        Me.Hide()
    End Sub


    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        ' Confirm user wants to delete the item
        If MsgBox("Delete the selected item?", MessageBoxButtons.YesNo) = MsgBoxResult.Yes Then
            Dim strGT As String = Me.PlayerDataGridView.CurrentRow.Cells("GamerTag").Value
            ' If yes, delete the item in question
            PlayerDataGridView.Rows.Remove(PlayerDataGridView.CurrentRow)
            Using conn As New SqlConnection(ConnStr)
                Using cmd As New SqlCommand
                    cmd.Connection = conn
                    cmd.CommandText = "DELETE FROM PlayerDB WHERE GamerTag = @tag"
                    cmd.Parameters.Add("@tag", strGT)
                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using
        End If
        ' Else, do nothing
    End Sub

    Public Sub BindPlayerData()
        Dim dbContext As New KirasDBEntities
        dbContext.Players.Load()
        PlayerBindingSource.DataSource = dbContext.Players.Local.ToBindingList()
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        Dim adp As New AddPlayer(ConnStr)
        adp.ShowDialog()
        BindPlayerData()
    End Sub
End Class
