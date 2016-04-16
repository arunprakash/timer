
Public Class Timer
    Dim startTime As DateTime
    Private stopwatch As New Stopwatch

    Private Sub Timer1_Tick(ByVal sender As System.Object,
     ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.stopwatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}",
    Math.Floor(elapsed.TotalHours),
    elapsed.Minutes, elapsed.Seconds,
    elapsed.Milliseconds)

    End Sub

    Private Sub Timer_Load(sender As Object, e As EventArgs) Handles Me.Load
        Timer1.Start()
        Me.stopwatch.Start()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub Move_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Move.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Cursor.Position.X - Me.Left 'Sets variable mousex
        mousey = Cursor.Position.Y - Me.Top 'Sets variable mousey
    End Sub

    Private Sub Move_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Move.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Move_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Move.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove
    End Sub


End Class
