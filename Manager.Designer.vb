<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.CurrentMatchLabel = New System.Windows.Forms.Label()
        Me.PlayersLabel = New System.Windows.Forms.Label()
        Me.NextMatchButton = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.P1RB = New System.Windows.Forms.RadioButton()
        Me.P2RB = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.Window
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(13, 13)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(62, 42)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "←"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'CurrentMatchLabel
        '
        Me.CurrentMatchLabel.AutoSize = True
        Me.CurrentMatchLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentMatchLabel.ForeColor = System.Drawing.Color.Teal
        Me.CurrentMatchLabel.Location = New System.Drawing.Point(95, 57)
        Me.CurrentMatchLabel.Name = "CurrentMatchLabel"
        Me.CurrentMatchLabel.Size = New System.Drawing.Size(248, 32)
        Me.CurrentMatchLabel.TabIndex = 2
        Me.CurrentMatchLabel.Text = "Round x: Match y"
        '
        'PlayersLabel
        '
        Me.PlayersLabel.AutoSize = True
        Me.PlayersLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayersLabel.Location = New System.Drawing.Point(96, 128)
        Me.PlayersLabel.Name = "PlayersLabel"
        Me.PlayersLabel.Padding = New System.Windows.Forms.Padding(15)
        Me.PlayersLabel.Size = New System.Drawing.Size(122, 59)
        Me.PlayersLabel.TabIndex = 3
        Me.PlayersLabel.Text = "Label2"
        '
        'NextMatchButton
        '
        Me.NextMatchButton.ForeColor = System.Drawing.Color.Indigo
        Me.NextMatchButton.Location = New System.Drawing.Point(101, 354)
        Me.NextMatchButton.Name = "NextMatchButton"
        Me.NextMatchButton.Size = New System.Drawing.Size(109, 23)
        Me.NextMatchButton.TabIndex = 6
        Me.NextMatchButton.Text = "Next Match"
        Me.NextMatchButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Who won?"
        '
        'P1RB
        '
        Me.P1RB.AutoSize = True
        Me.P1RB.Location = New System.Drawing.Point(101, 255)
        Me.P1RB.Name = "P1RB"
        Me.P1RB.Size = New System.Drawing.Size(109, 20)
        Me.P1RB.TabIndex = 8
        Me.P1RB.TabStop = True
        Me.P1RB.Text = "RadioButton1"
        Me.P1RB.UseVisualStyleBackColor = True
        '
        'P2RB
        '
        Me.P2RB.AutoSize = True
        Me.P2RB.Location = New System.Drawing.Point(101, 281)
        Me.P2RB.Name = "P2RB"
        Me.P2RB.Size = New System.Drawing.Size(109, 20)
        Me.P2RB.TabIndex = 9
        Me.P2RB.TabStop = True
        Me.P2RB.Text = "RadioButton1"
        Me.P2RB.UseVisualStyleBackColor = True
        '
        'Manager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(506, 450)
        Me.Controls.Add(Me.P2RB)
        Me.Controls.Add(Me.P1RB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NextMatchButton)
        Me.Controls.Add(Me.PlayersLabel)
        Me.Controls.Add(Me.CurrentMatchLabel)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "Manager"
        Me.Text = "Tournament Manager"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents CurrentMatchLabel As Label
    Friend WithEvents PlayersLabel As Label
    Friend WithEvents NextMatchButton As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents P1RB As RadioButton
    Friend WithEvents P2RB As RadioButton
End Class
