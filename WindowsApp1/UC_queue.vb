Public Class UC_queue
    Public Sub New(ByVal path As String)
        InitializeComponent()

        UC_queue_path.Text = path
    End Sub

    Private Sub UC_queue_delete_Click(sender As Object, e As EventArgs) Handles UC_queue_delete.Click
        VideoTrim.queue.Remove(UC_queue_path.Text)
        VideoTrim.ReloadQueuePublic()
    End Sub
End Class
