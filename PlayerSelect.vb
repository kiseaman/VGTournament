Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Data.SqlTypes


Public Class PlayerSelect
    Private ConnStr As String
    Public Sub New(strc As String)
        InitializeComponent()
        ConnStr = strc
    End Sub

    Private Sub PlayerSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New SqlConnection(ConnStr)
            Using sda As New SqlDataAdapter("SELECT GamerTag FROM PlayerDB", conn)
                Dim dt As New DataTable
                sda.Fill(dt)
                GamerCLB.DataSource = dt
                GamerCLB.DisplayMember = "GamerTag"
                GamerCLB.ValueMember = "GamerTag"
            End Using
        End Using

    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click
        ' Check that enough players have been selected
        If GamerCLB.CheckedItems.Count <= 3 Then
            MessageBox.Show("Please select at least four items.")
        Else
            ' Randomise order of selected players
            Dim selected As List(Of String) = Me.GetChecked()
            Dim randomised As New List(Of String)
            Dim upperbound As Integer = selected.Count - 1
            Randomize()
            While upperbound >= 0
                Dim randomValue = CInt(Math.Floor((upperbound + 1) * Rnd()))
                randomised.Add(selected(randomValue))
                selected.RemoveAt(randomValue)
                upperbound -= 1
            End While

            Dim mngr As New Manager(randomised, ConnStr)
            mngr.Show()
            Me.Close()
        End If

    End Sub

    Private Function GetChecked() As List(Of String)
        Dim playerList As New List(Of String)
        Dim itemChecked As Object
        For Each itemChecked In GamerCLB.CheckedItems
            playerList.Add(itemChecked("GamerTag").ToString)
        Next
        Return playerList
    End Function

End Class