Public Class SingleTimer

    Private locationName As String
    Private Sub SingleTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Property LocationText() As String

        Get
            Return locationName
        End Get
        Set(value As String)
            locationName = value
            LocationButton.Text = locationName
        End Set
    End Property

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class
