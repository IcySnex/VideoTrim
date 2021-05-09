Public Class about
    Private Sub about_Load() Handles Me.Load
        TB_path_ffmpeg.Text = My.Settings.path_ffmpeg
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class