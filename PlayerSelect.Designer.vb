<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlayerSelect
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
        Me.BackButton = New System.Windows.Forms.Button()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.GamerCLB = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BackButton
        '
        Me.BackButton.BackColor = System.Drawing.SystemColors.Window
        Me.BackButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackButton.Location = New System.Drawing.Point(13, 13)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(44, 36)
        Me.BackButton.TabIndex = 0
        Me.BackButton.Text = "←"
        Me.BackButton.UseVisualStyleBackColor = False
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(55, 367)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(160, 40)
        Me.GenerateButton.TabIndex = 1
        Me.GenerateButton.Text = "Generate Bracket"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'GamerCLB
        '
        Me.GamerCLB.CheckOnClick = True
        Me.GamerCLB.FormattingEnabled = True
        Me.GamerCLB.Location = New System.Drawing.Point(90, 64)
        Me.GamerCLB.Name = "GamerCLB"
        Me.GamerCLB.Size = New System.Drawing.Size(394, 276)
        Me.GamerCLB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(313, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select at least 4 players to participate in the tourney."
        '
        'PlayerSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GamerCLB)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.BackButton)
        Me.Name = "PlayerSelect"
        Me.Text = "PlayerSelect"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackButton As Button
    Friend WithEvents GenerateButton As Button
    Friend WithEvents GamerCLB As CheckedListBox
    Friend WithEvents Label1 As Label
End Class
