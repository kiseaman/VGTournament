<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddPlayer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PlayerNameLabel = New System.Windows.Forms.Label()
        Me.PlayerNameTextBox = New System.Windows.Forms.TextBox()
        Me.GamertagLabel = New System.Windows.Forms.Label()
        Me.GamertagTextBox = New System.Windows.Forms.TextBox()
        Me.ConfirmAddButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'PlayerNameLabel
        '
        Me.PlayerNameLabel.AutoSize = True
        Me.PlayerNameLabel.Location = New System.Drawing.Point(65, 66)
        Me.PlayerNameLabel.Name = "PlayerNameLabel"
        Me.PlayerNameLabel.Size = New System.Drawing.Size(86, 16)
        Me.PlayerNameLabel.TabIndex = 0
        Me.PlayerNameLabel.Text = "Player Name"
        '
        'PlayerNameTextBox
        '
        Me.PlayerNameTextBox.Location = New System.Drawing.Point(157, 63)
        Me.PlayerNameTextBox.MaxLength = 50
        Me.PlayerNameTextBox.Name = "PlayerNameTextBox"
        Me.PlayerNameTextBox.Size = New System.Drawing.Size(204, 22)
        Me.PlayerNameTextBox.TabIndex = 1
        '
        'GamertagLabel
        '
        Me.GamertagLabel.AutoSize = True
        Me.GamertagLabel.Location = New System.Drawing.Point(68, 106)
        Me.GamertagLabel.Name = "GamertagLabel"
        Me.GamertagLabel.Size = New System.Drawing.Size(67, 16)
        Me.GamertagLabel.TabIndex = 2
        Me.GamertagLabel.Text = "Gamertag"
        '
        'GamertagTextBox
        '
        Me.GamertagTextBox.Location = New System.Drawing.Point(157, 106)
        Me.GamertagTextBox.MaxLength = 50
        Me.GamertagTextBox.Name = "GamertagTextBox"
        Me.GamertagTextBox.Size = New System.Drawing.Size(204, 22)
        Me.GamertagTextBox.TabIndex = 3
        '
        'ConfirmAddButton
        '
        Me.ConfirmAddButton.Location = New System.Drawing.Point(71, 170)
        Me.ConfirmAddButton.Name = "ConfirmAddButton"
        Me.ConfirmAddButton.Size = New System.Drawing.Size(75, 23)
        Me.ConfirmAddButton.TabIndex = 5
        Me.ConfirmAddButton.Text = "Add"
        Me.ConfirmAddButton.UseVisualStyleBackColor = True
        '
        'AddPlayer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 248)
        Me.Controls.Add(Me.ConfirmAddButton)
        Me.Controls.Add(Me.GamertagTextBox)
        Me.Controls.Add(Me.GamertagLabel)
        Me.Controls.Add(Me.PlayerNameTextBox)
        Me.Controls.Add(Me.PlayerNameLabel)
        Me.Name = "AddPlayer"
        Me.Text = "Add Player"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PlayerNameLabel As Label
    Friend WithEvents PlayerNameTextBox As TextBox
    Friend WithEvents GamertagLabel As Label
    Friend WithEvents GamertagTextBox As TextBox
    Friend WithEvents ConfirmAddButton As Button
End Class
