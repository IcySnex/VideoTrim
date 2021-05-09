Public Class custom_msgbox

    Public Sub New(Optional msg As String = "Finsished trimming the entire queue!")
        InitializeComponent()

        Label1.Text = msg
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start(My.Settings.path_output_folder)
        Me.Close()
    End Sub

    Private Sub custom_msgbox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play("C:\Windows\Media\Windows Background.wav", AudioPlayMode.Background)
    End Sub
End Class