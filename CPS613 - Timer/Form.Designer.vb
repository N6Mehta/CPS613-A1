<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Center
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
        Me.Sec = New System.Windows.Forms.Button()
        Me.Secs3 = New System.Windows.Forms.Button()
        Me.Secs10 = New System.Windows.Forms.Button()
        Me.Min = New System.Windows.Forms.Button()
        Me.Mins3 = New System.Windows.Forms.Button()
        Me.Mins10 = New System.Windows.Forms.Button()
        Me.SingleTimer4 = New CPS613___Timer.SingleTimer()
        Me.SingleTimer3 = New CPS613___Timer.SingleTimer()
        Me.SingleTimer2 = New CPS613___Timer.SingleTimer()
        Me.SingleTimer1 = New CPS613___Timer.SingleTimer()
        Me.SuspendLayout()
        '
        'Sec
        '
        Me.Sec.Location = New System.Drawing.Point(12, 447)
        Me.Sec.Name = "Sec"
        Me.Sec.Size = New System.Drawing.Size(190, 74)
        Me.Sec.TabIndex = 0
        Me.Sec.Text = "1 Second"
        Me.Sec.UseVisualStyleBackColor = True
        '
        'Secs3
        '
        Me.Secs3.Location = New System.Drawing.Point(222, 447)
        Me.Secs3.Name = "Secs3"
        Me.Secs3.Size = New System.Drawing.Size(190, 74)
        Me.Secs3.TabIndex = 1
        Me.Secs3.Text = "3 Seconds"
        Me.Secs3.UseVisualStyleBackColor = True
        '
        'Secs10
        '
        Me.Secs10.Location = New System.Drawing.Point(434, 447)
        Me.Secs10.Name = "Secs10"
        Me.Secs10.Size = New System.Drawing.Size(190, 74)
        Me.Secs10.TabIndex = 2
        Me.Secs10.Text = "10 Seconds"
        Me.Secs10.UseVisualStyleBackColor = True
        '
        'Min
        '
        Me.Min.Location = New System.Drawing.Point(12, 527)
        Me.Min.Name = "Min"
        Me.Min.Size = New System.Drawing.Size(190, 74)
        Me.Min.TabIndex = 3
        Me.Min.Text = "1 Minute"
        Me.Min.UseVisualStyleBackColor = True
        '
        'Mins3
        '
        Me.Mins3.Location = New System.Drawing.Point(222, 527)
        Me.Mins3.Name = "Mins3"
        Me.Mins3.Size = New System.Drawing.Size(190, 74)
        Me.Mins3.TabIndex = 4
        Me.Mins3.Text = "3 Minutes"
        Me.Mins3.UseVisualStyleBackColor = True
        '
        'Mins10
        '
        Me.Mins10.Location = New System.Drawing.Point(434, 527)
        Me.Mins10.Name = "Mins10"
        Me.Mins10.Size = New System.Drawing.Size(190, 74)
        Me.Mins10.TabIndex = 5
        Me.Mins10.Text = "10 Minutes"
        Me.Mins10.UseVisualStyleBackColor = True
        '
        'SingleTimer4
        '
        Me.SingleTimer4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer4.Location = New System.Drawing.Point(333, 224)
        Me.SingleTimer4.LocationText = "Bottom Right"
        Me.SingleTimer4.Name = "SingleTimer4"
        Me.SingleTimer4.Size = New System.Drawing.Size(291, 193)
        Me.SingleTimer4.TabIndex = 9
        '
        'SingleTimer3
        '
        Me.SingleTimer3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer3.Location = New System.Drawing.Point(332, 12)
        Me.SingleTimer3.LocationText = "Top Right"
        Me.SingleTimer3.Name = "SingleTimer3"
        Me.SingleTimer3.Size = New System.Drawing.Size(291, 193)
        Me.SingleTimer3.TabIndex = 8
        '
        'SingleTimer2
        '
        Me.SingleTimer2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer2.Location = New System.Drawing.Point(12, 224)
        Me.SingleTimer2.LocationText = "Bottom Left"
        Me.SingleTimer2.Name = "SingleTimer2"
        Me.SingleTimer2.Size = New System.Drawing.Size(291, 193)
        Me.SingleTimer2.TabIndex = 7
        '
        'SingleTimer1
        '
        Me.SingleTimer1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SingleTimer1.Location = New System.Drawing.Point(12, 12)
        Me.SingleTimer1.LocationText = "Top Left"
        Me.SingleTimer1.Name = "SingleTimer1"
        Me.SingleTimer1.Size = New System.Drawing.Size(291, 193)
        Me.SingleTimer1.TabIndex = 6
        '
        'Center
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(635, 617)
        Me.Controls.Add(Me.SingleTimer4)
        Me.Controls.Add(Me.SingleTimer3)
        Me.Controls.Add(Me.SingleTimer2)
        Me.Controls.Add(Me.SingleTimer1)
        Me.Controls.Add(Me.Mins10)
        Me.Controls.Add(Me.Mins3)
        Me.Controls.Add(Me.Min)
        Me.Controls.Add(Me.Secs10)
        Me.Controls.Add(Me.Secs3)
        Me.Controls.Add(Me.Sec)
        Me.Name = "Center"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nitish Mehta's Timer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Sec As Button
    Friend WithEvents Secs3 As Button
    Friend WithEvents Secs10 As Button
    Friend WithEvents Min As Button
    Friend WithEvents Mins3 As Button
    Friend WithEvents Mins10 As Button
    Friend WithEvents SingleTimer1 As SingleTimer
    Friend WithEvents SingleTimer2 As SingleTimer
    Friend WithEvents SingleTimer3 As SingleTimer
    Friend WithEvents SingleTimer4 As SingleTimer
End Class
