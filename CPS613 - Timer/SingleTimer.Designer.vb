<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SingleTimer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.LocationButton = New System.Windows.Forms.RadioButton()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ColonLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LocationButton
        '
        Me.LocationButton.AutoSize = True
        Me.LocationButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LocationButton.Location = New System.Drawing.Point(12, 15)
        Me.LocationButton.Name = "LocationButton"
        Me.LocationButton.Size = New System.Drawing.Size(197, 35)
        Me.LocationButton.TabIndex = 0
        Me.LocationButton.TabStop = True
        Me.LocationButton.Text = "RadioButton1"
        Me.LocationButton.UseVisualStyleBackColor = True
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(18, 114)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(81, 67)
        Me.StartButton.TabIndex = 1
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(108, 114)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(81, 67)
        Me.StopButton.TabIndex = 2
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(195, 114)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(81, 67)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ColonLabel
        '
        Me.ColonLabel.AutoSize = True
        Me.ColonLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!)
        Me.ColonLabel.Location = New System.Drawing.Point(134, 53)
        Me.ColonLabel.Name = "ColonLabel"
        Me.ColonLabel.Size = New System.Drawing.Size(31, 46)
        Me.ColonLabel.TabIndex = 4
        Me.ColonLabel.Text = ":"
        '
        'SingleTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ColonLabel)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.LocationButton)
        Me.Name = "SingleTimer"
        Me.Size = New System.Drawing.Size(291, 193)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LocationButton As RadioButton
    Friend WithEvents StartButton As Button
    Friend WithEvents StopButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ColonLabel As Label
End Class
