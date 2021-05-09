Imports System.IO
Imports MediaInfoDotNet
Imports Microsoft.WindowsAPICodePack.Shell

Public Class VideoTrim

#Region "General"
    Public Shared queue As New List(Of String)

    Private Sub VideoTrim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.path_ffmpeg = "" Then
            My.Settings.path_ffmpeg = AppDomain.CurrentDomain.BaseDirectory & "ffmpeg"
        End If
        FBD_ffmpeg.SelectedPath = My.Settings.path_ffmpeg

        If My.Settings.path_output_folder = "" Then
            My.Settings.path_output_folder = AppDomain.CurrentDomain.BaseDirectory & "output"
        End If
        TB_output_folder.Text = My.Settings.path_output_folder
        FBD_output_folder.SelectedPath = My.Settings.path_output_folder

        If My.Settings.output_name = "" Then
            My.Settings.output_name = "{original} - {part}of{total}"
        End If
        TB_output_name.Text = My.Settings.output_name

        CB_output_format.SelectedIndex = 0
    End Sub
#End Region

#Region "ToolStripBar"
    Private Sub TSM_load_file_Click(sender As Object, e As EventArgs) Handles TSM_load_file.Click
        LoadFile()
    End Sub

    Private Sub TSM_load_folder_Click(sender As Object, e As EventArgs) Handles TSM_load_folder.Click
        LoadFolder()
    End Sub

    Private Sub TSM_load_clear_Click(sender As Object, e As EventArgs) Handles TSM_load_clear.Click
        Clear()
    End Sub

    Private Sub TSM_ffmpeg_github_Click(sender As Object, e As EventArgs) Handles TSM_ffmpeg_github.Click
        Process.Start("https://www.github.com/FFmpeg/FFmpeg")
    End Sub

    Private Sub TSM_ffmpeg_set_Click(sender As Object, e As EventArgs) Handles TSM_ffmpeg_set.Click
        If FBD_ffmpeg.ShowDialog() = DialogResult.OK Then
            Dim yessir As String = ""
            For Each s As String In My.Computer.FileSystem.GetFiles(FBD_ffmpeg.SelectedPath)
                yessir &= s & ";"
            Next

            If yessir.Contains("avcodec-59.dll") AndAlso yessir.Contains("avdevice-59.dll") AndAlso yessir.Contains("avfilter-8.dll") AndAlso yessir.Contains("avformat-59.dll") AndAlso yessir.Contains("avutil-57.dll") AndAlso yessir.Contains("ffmpeg.exe") AndAlso yessir.Contains("ffplay.exe") AndAlso yessir.Contains("ffprobe.exe") AndAlso yessir.Contains("postproc-56.dll") AndAlso yessir.Contains("swresample-4.dll") AndAlso yessir.Contains("swscale-6.dll") Then
                My.Settings.path_ffmpeg = FBD_ffmpeg.SelectedPath
                MsgBox("Changed ffmpeg folder!", MsgBoxStyle.Information)
            Else
                MsgBox("Folder doesnt contain all ffmpeg files!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub TSM_about_Click(sender As Object, e As EventArgs) Handles TSM_about.Click
        about.ShowDialog()
    End Sub
#End Region

#Region "Load"

#Region "buttons"
    Private Sub BTN_load_file_Click(sender As Object, e As EventArgs) Handles BTN_load_file.Click
        LoadFile()
    End Sub

    Private Sub BTN_load_folder_Click(sender As Object, e As EventArgs) Handles BTN_load_folder.Click
        LoadFolder()
    End Sub

    Private Sub BTN_clear_Click(sender As Object, e As EventArgs) Handles BTN_clear.Click
        Clear()
    End Sub

    Private Sub BTN_queue_file_Click(sender As Object, e As EventArgs) Handles BTN_queue_file.Click
        LoadFile()
    End Sub

    Private Sub BTN_queue_folder_Click(sender As Object, e As EventArgs) Handles BTN_queue_folder.Click
        LoadFolder()
    End Sub
#End Region

    Private Sub LoadFile()
        OFD_load_file.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop

        If OFD_load_file.ShowDialog() = DialogResult.OK Then
            If OFD_load_file.FileName IsNot "" Then
                If queue.Contains(OFD_load_file.FileName) Then
                    MsgBox("Video already exists in queue!", MsgBoxStyle.Critical)
                Else
                    Try
                        If queue.Contains(OFD_load_file.FileName) Then
                            MsgBox("Video already exists in queue!", MsgBoxStyle.Critical)
                        Else
                            queue.Add(OFD_load_file.FileName)
                            ReloadQueue()
                            TabControl1.SelectedTab = TabControl1.TabPages(1)
                            If TB_state_current.Text = "" Then
                                LoadCurrent(0)
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox("Failed adding video to queue!", MsgBoxStyle.Critical)
                    End Try
                End If
            Else
                MsgBox("Failed adding video to queue!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub LoadFolder()
        If FBD_load_folder.ShowDialog() = DialogResult.OK Then
            Dim i As Integer
            For Each item As FileInfo In New DirectoryInfo(FBD_load_folder.SelectedPath).GetFiles
                If item.Extension = ".mkv" Or item.Extension = ".webm" Or item.Extension = ".flv" Or item.Extension = ".avi" Or item.Extension = ".mov" Or item.Extension = ".mp4" Or item.Extension = ".mpg" Or item.Extension = ".mpeg" Or item.Extension = ".m4v" Then
                    If queue.Contains(item.FullName) Then
                        MsgBox("Video already exists in queue!", MsgBoxStyle.Critical)
                    Else
                        queue.Add(item.FullName)
                        i += 1
                    End If
                End If
            Next
            If i = 0 Then
                MsgBox("This folder doesnt contain any supportet videos! (Supportet formats: .mkv .webm .flv .avi .mov .mp4 .mpg .mpeg .m4v)", MsgBoxStyle.Critical)
            Else
                ReloadQueue()
                TabControl1.SelectedTab = TabControl1.TabPages(1)
                If TB_state_current.Text = "" Then
                    LoadCurrent(0)
                End If
            End If
        End If
    End Sub

#Region "Reload Queue"
    Public Shared Sub ReloadQueuePublic()
        VideoTrim.ReloadQueue()
    End Sub

    Private Sub ReloadQueue(Optional mode As String = "n")
        GB_queue.Text = "Loaded videos: " & queue.Count

        queue.Sort()

        FLY_queue.Controls.Clear()
        For Each item As String In queue
            Me.Invoke(CType(Sub() FLY_queue.Controls.Add(New UC_queue(item) With {.Name = item.Replace(" ", "_")}), MethodInvoker))
        Next

        If mode = "n" Then
            If queue.Count = 0 Then
                If TB_state_current.Text = "" Then
                    TabControl1.SelectedTab = TabControl1.TabPages(0)
                    ResetInfos()
                    BW_infos.CancelAsync()
                    TB_state_current.Text = ""
                    TB_state_currentpart.Text = 0
                    RTB_state_console.Text = ""
                    PB_state_currentprogress.Maximum = 100
                    PB_state_currentprogress.Value = 0
                End If
            End If
        End If
    End Sub
#End Region

    Private Sub Clear()
        queue.Clear()
        ReloadQueue()
        If queue.Count < 1 AndAlso TB_state_current.Text = "" Then
            TabControl1.SelectedTab = TabControl1.TabPages(0)
        End If
        MsgBox("Cleared the queue!", MsgBoxStyle.Information)
    End Sub

#Region "LoadCurrent"
    Private Sub LoadCurrent(ByVal index As Integer)
        ResetInfos()
        BW_infos.CancelAsync()
        TB_state_current.Text = ""
        TB_state_currentpart.Text = 0
        RTB_state_console.Text = ""
        PB_state_currentprogress.Maximum = 100
        PB_state_currentprogress.Value = 0

        If queue.Count < 1 Then
            TabControl1.SelectedTab = TabControl1.TabPages(0)
            Dim frm As custom_msgbox = New custom_msgbox
            frm.ShowDialog()
            ReloadQueue()
        Else
            TB_state_current.Text = queue(index)
            queue.RemoveAt(index)
            ReloadQueue("b")

            Try
                BW_infos.RunWorkerAsync()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub BW_infos_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_infos.DoWork
        Control.CheckForIllegalCrossThreadCalls = False

        Dim current_video = New MediaFile(TB_state_current.Text)
        Dim current_file As FileInfo = New FileInfo(TB_state_current.Text)
        Dim prop As PropertySystem.IShellProperty = ShellObject.FromParsingName(TB_state_current.Text).Properties.System.Media.Duration
        Dim current_video_duration As TimeSpan = TimeSpan.FromTicks(CLng(CULng(prop.ValueAsObject)))

        TB_info_name.Text = current_file.Name.Replace(current_file.Extension, "")
        If current_video.size > 1070000000 Then
            TB_info_filesize.Text = String.Format("{0:0.00}", current_video.size / 1024 / 1048576) & " GB"
        Else
            TB_info_filesize.Text = String.Format("{0:0.00}", current_video.size / 1048576) & " MB"
        End If
        TB_info_duration.Text = current_video_duration.ToString.Substring(0, 8)
        TB_info_format.Text = current_file.Extension.Replace(".", "")
        TB_info_codec.Text = current_video.Video(0).CodecId
        TB_info_bitrate.Text = current_video.Video(0).BitRate & " kbps"

        TB_info_resolution.Text = current_video.Video(0).Width & "x" & current_video.Video(0).Height
        TB_info_framerate.Text = current_video.Video(0).FrameRate & " FPS"
        TB_info_totalframes.Text = current_video.Video(0).FrameCount
        TB_info_videostreams.Text = current_video.Video.Count
        TB_info_audiostreams.Text = current_video.Audio.Count

        TB_info_audiocodec.Text = current_video.Audio(0).codecId
        TB_info_audiobitrate.Text = current_video.Audio(0).bitRate & " kbps"
        TB_info_audiosamplerate.Text = current_video.Audio(0).sampleRate & " Hz"
    End Sub

    Private Sub ResetInfos()
        TB_info_name.Text = "N/A"
        TB_info_filesize.Text = "N/A"
        TB_info_duration.Text = "N/A"
        TB_info_format.Text = "N/A"
        TB_info_codec.Text = "N/A"
        TB_info_bitrate.Text = "N/A"

        TB_info_resolution.Text = "N/A"
        TB_info_framerate.Text = "N/A"
        TB_info_totalframes.Text = "N/A"
        TB_info_videostreams.Text = "N/A"
        TB_info_audiostreams.Text = "N/A"

        TB_info_audiocodec.Text = "N/A"
        TB_info_audiobitrate.Text = "N/A"
        TB_info_audiosamplerate.Text = "N/A"
    End Sub
#End Region

#End Region

#Region "Output"
    Private Sub TB_output_folder_TextChanged(sender As Object, e As EventArgs) Handles TB_output_folder.LostFocus
        If Directory.Exists(TB_output_folder.Text) Then
            FBD_ffmpeg.SelectedPath = TB_output_folder.Text
            My.Settings.path_output_folder = TB_output_folder.Text
        Else
            TB_output_folder.Text = My.Settings.path_output_folder
            MsgBox("This directiony doesnt exist!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub BTN_output_folder_Click(sender As Object, e As EventArgs) Handles BTN_output_folder.Click
        If FBD_ffmpeg.ShowDialog() = DialogResult.OK Then
            TB_output_folder.Text = FBD_ffmpeg.SelectedPath
            My.Settings.path_output_folder = FBD_ffmpeg.SelectedPath
        End If
    End Sub

    Private Sub TB_output_name_TextChanged(sender As Object, e As EventArgs) Handles TB_output_name.TextChanged
        My.Settings.output_name = TB_output_name.Text
    End Sub
#End Region

#Region "State"

#Region "Total parts num"
    Private Sub TB_state_current_num_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TB_state_current_num.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TB_state_current_num_LostFocus(sender As Object, e As EventArgs) Handles TB_state_current_num.LostFocus
        If TB_state_current_num.Text = "" Then
            TB_state_current_num.Text = 2
        Else
            If TB_state_current_num.Text <= 1 Then
                TB_state_current_num.Text = 2
                MsgBox("The total parts must be in between 2 and 99!", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

#End Region

#Region "Buttons"
    Private Sub BTN_current_start_Click(sender As Object, e As EventArgs) Handles BTN_current_start.Click
        BW_process.RunWorkerAsync()
        PB_state_totalprogress.Value = 0
        PB_state_totalprogress.Maximum = (queue.Count + 1) * 2
    End Sub

    Private Sub BTN_current_cacel_Click(sender As Object, e As EventArgs) Handles BTN_current_cacel.Click
        Try
            BW_process.CancelAsync()
        Catch ex As Exception
        End Try
        Try
            prcFFMPEG.Kill()
        Catch ex As Exception
        End Try

        PB_state_totalprogress.Value = 0
        PB_state_totalprogress.Maximum = 100
        LoadCurrent(0)
        EnableDisableUser(True)
    End Sub
#End Region

#Region "Processing"

#Region "Return Functions"
    Private Function DivideTime(ByVal duration As TimeSpan, ByVal divideby As Integer)
        Return New TimeSpan(0, 0, 0, duration.TotalSeconds / divideby)
    End Function

    Private Function MultiplyTime(ByVal duration As TimeSpan, ByVal multiplyby As Integer)
        Return New TimeSpan(0, 0, 0, duration.TotalSeconds * multiplyby)
    End Function

    Private Function ReplaceIllegalChar(ByVal str As String)
        Return str.Replace("/", "-").Replace("\", "-").Replace(":", ";").Replace("*", "'").Replace("""", "'").Replace("<", "-").Replace(">", "-").Replace("|", "-")
    End Function
#End Region

#Region "Declearing"
    Dim psiProcInfo As New System.Diagnostics.ProcessStartInfo
    Dim prcFFMPEG As New Process
    Dim ffReader As StreamReader
    Dim strFFOUT As String
#End Region

#Region "Process"
    Private Sub BW_process_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BW_process.DoWork
        Control.CheckForIllegalCrossThreadCalls = False

        If Not queue.Count = 0 Then
            If PB_state_totalprogress.Value + 1 <= PB_state_totalprogress.Maximum Then
                PB_state_totalprogress.Value += 1
            Else
                PB_state_totalprogress.Value = 0
            End If
        End If

        EnableDisableUser(False)

        Dim original As FileInfo = New FileInfo(TB_state_current.Text)
        Dim filename As String = ReplaceIllegalChar(TB_output_name.Text.Replace("{original}", original.Name.Replace(original.Extension, "")).Replace("{total}", TB_state_current_num.Text).Replace("{date}", Date.Now.ToString("MM/dd/yyyy")).Replace("{time}", Date.Now.ToString("HH:mm:ss")).Replace("""", "'") & CB_output_format.SelectedItem.ToString.Replace("*original", original.Extension))
        If CB_output_exfolder.Checked = True Then
            Dim expath As String = $"{ReplaceIllegalChar(original.Name.Replace(original.Extension, ""))}\"
            Directory.CreateDirectory($"{My.Settings.path_output_folder}\{expath}")
            filename = expath & filename
        End If

        Dim fastmode As String = ""
        If CB_fastmode.Checked = True Then
            fastmode = "-c copy"
        Else
            fastmode = ""
        End If

        Dim prop As PropertySystem.IShellProperty = ShellObject.FromParsingName(TB_state_current.Text).Properties.System.Media.Duration
        Dim duration As TimeSpan = TimeSpan.FromTicks(CLng(CULng(prop.ValueAsObject)))
        Dim command As String = ""

        Do Until TB_state_currentpart.Text >= TB_state_current_num.Text
            TB_state_currentpart.Text += 1

            If File.Exists($"{My.Settings.path_output_folder}\{filename}".Replace("{part}", TB_state_currentpart.Text)) Then
                If MessageBox.Show("Video With this name already exists In the output path! Do you want To overwrite it?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                    File.Delete($"{My.Settings.path_output_folder}\{filename}".Replace("{part}", TB_state_currentpart.Text))
                    While File.Exists($"{My.Settings.path_output_folder}\{filename}".Replace("{part}", TB_state_currentpart.Text))
                        System.Threading.Thread.Sleep(100)
                    End While
                Else
                    FinishedProcess()
                    Exit Sub
                End If
            End If

            If TB_state_currentpart.Text <= 1 Then
                command = $" -ss 00:00:00 -i ""{TB_state_current.Text}"" -ss 00:00:00 {fastmode} -t {DivideTime(duration, TB_state_current_num.Text)} ""{$"{My.Settings.path_output_folder}\{filename}"}""".Replace("{part}", TB_state_currentpart.Text)
            ElseIf TB_state_currentpart.Text >= TB_state_current_num.Text Then
                command = $" -ss {MultiplyTime(DivideTime(duration, TB_state_current_num.Text), TB_state_currentpart.Text - 1)} -i ""{TB_state_current.Text}"" -ss 00:00:00 {fastmode} -t {duration} ""{$"{My.Settings.path_output_folder}\{filename}"}""".Replace("{part}", TB_state_currentpart.Text)
            Else
                command = $" -ss {MultiplyTime(DivideTime(duration, TB_state_current_num.Text), TB_state_currentpart.Text - 1)} -i ""{TB_state_current.Text}"" -ss 00:00:00 {fastmode} -t {DivideTime(duration, TB_state_current_num.Text)} ""{$"{My.Settings.path_output_folder}\{filename}"}""".Replace("{part}", TB_state_currentpart.Text)
            End If

            psiProcInfo.FileName = My.Settings.path_ffmpeg & "\ffmpeg.exe"
            psiProcInfo.Arguments = command
            psiProcInfo.UseShellExecute = False
            psiProcInfo.WindowStyle = ProcessWindowStyle.Hidden
            psiProcInfo.RedirectStandardError = True
            psiProcInfo.RedirectStandardOutput = True
            psiProcInfo.CreateNoWindow = True
            prcFFMPEG.StartInfo = psiProcInfo
            prcFFMPEG.Start()
            ffReader = prcFFMPEG.StandardError

            Do
                Try
                    strFFOUT = ffReader.ReadLine
                    RTB_state_console.Text = strFFOUT

                    Try
                        If RTB_state_console.Text.Contains("frame=") Then
                            RefreshCurrentProgressbar(RTB_state_console.Text.Split("f")(1).Replace("rame=", "").Replace(" ", ""))
                        End If
                    Catch ex As Exception
                        RefreshCurrentProgressbar(0)
                    End Try
                Catch ex As Exception

                End Try
            Loop Until prcFFMPEG.HasExited And strFFOUT = Nothing Or strFFOUT = ""
        Loop

        FinishedProcess()
    End Sub

    Private Sub RefreshCurrentProgressbar(ByVal frame As String)
        If IsNumeric(TB_info_totalframes.Text) Then
            If IsNumeric(frame) Then
                PB_state_currentprogress.Maximum = TB_info_totalframes.Text
                PB_state_currentprogress.Value = frame + ((PB_state_currentprogress.Maximum / TB_state_current_num.Text) * (TB_state_currentpart.Text - 1))

            Else
                PB_state_currentprogress.Maximum = 100
                PB_state_currentprogress.Value = PB_state_currentprogress.Value
            End If
        Else
            PB_state_currentprogress.Maximum = 100
            PB_state_currentprogress.Value = PB_state_currentprogress.Value
        End If
    End Sub

#End Region

    Private Async Sub FinishedProcess()
        LoadCurrent(0)
        EnableDisableUser(True)
        If Not queue.Count = 0 Then
            If PB_state_totalprogress.Value + 1 <= PB_state_totalprogress.Maximum Then
                PB_state_totalprogress.Value += 1
            Else
                PB_state_totalprogress.Value = 0
            End If
        End If

        If CB_fluent.Checked = True Then
            Do While Not queue.Count = 0
                Await Task.Delay(150)
                Try
                    BW_process.RunWorkerAsync()
                Catch ex As Exception
                End Try
            Loop

            PB_state_totalprogress.Value = 0
            PB_state_totalprogress.Maximum = 100
            TabControl1.SelectedTab = TabControl1.TabPages(0)
            Dim frm As custom_msgbox = New custom_msgbox
            frm.ShowDialog()
            Exit Sub
        Else
            Try
                Dim original As FileInfo = New FileInfo(TB_state_current.Text)
                Dim filename As String = ReplaceIllegalChar(TB_output_name.Text.Replace("{original}", original.Name.Replace(original.Extension, "")).Replace("{total}", TB_state_current_num.Text).Replace("{date}", Date.Now.ToString("MM/dd/yyyy")).Replace("{time}", Date.Now.ToString("HH:mm:ss")).Replace("""", "'").Replace("{part}", "*") & CB_output_format.SelectedItem.ToString.Replace("*original", original.Extension))
                Dim frm As custom_msgbox = New custom_msgbox($"Finsished trimming video. (""...\{filename}"")")
                frm.ShowDialog()
            Catch ex As Exception
            End Try
            PB_state_totalprogress.Value = 0
            PB_state_totalprogress.Maximum = 100
        End If
        Await Task.Delay(150)
    End Sub

    Private Sub EnableDisableUser(ByVal mode As Boolean)
        If mode = True Then
            MS.Enabled = True
            BTN_current_start.Enabled = True
            BTN_current_cacel.Enabled = False
            TB_state_current_num.Enabled = True
            BTN_output_folder.Enabled = True
            TB_output_folder.Enabled = True
            CB_output_format.Enabled = True
            CB_output_exfolder.Enabled = True
            TB_output_name.Enabled = True
            BTN_queue_file.Enabled = True
            BTN_queue_folder.Enabled = True
            BTN_clear.Enabled = True
            FLY_queue.Enabled = True
        ElseIf mode = False Then
            MS.Enabled = False
            BTN_current_start.Enabled = False
            BTN_current_cacel.Enabled = True
            TB_state_current_num.Enabled = False
            BTN_output_folder.Enabled = False
            TB_output_folder.Enabled = False
            CB_output_format.Enabled = False
            CB_output_exfolder.Enabled = False
            TB_output_name.Enabled = False
            BTN_queue_file.Enabled = False
            BTN_queue_folder.Enabled = False
            BTN_clear.Enabled = False
            FLY_queue.Enabled = False
        End If
    End Sub

#End Region

#Region "CheckBox"

#Region "fastmode"
    Private Sub LB_CB_fastmode_info_Click(sender As Object, e As EventArgs) Handles LB_CB_fastmode_info.Click
        MsgBox($"Enables fastmode for saving trimmed videos. {vbCrLf}{vbCrLf}(Copies the codec from the original instead of creating a new codec. May includes bugs.)", MsgBoxStyle.Information)
    End Sub

    Private Sub LB_CB_fastmode_info_MouseEnter(sender As Object, e As EventArgs) Handles LB_CB_fastmode_info.MouseEnter
        LB_CB_fastmode_info.ForeColor = Color.DimGray
    End Sub

    Private Sub LB_CB_fastmode_info_MouseLeave(sender As Object, e As EventArgs) Handles LB_CB_fastmode_info.MouseLeave
        LB_CB_fastmode_info.ForeColor = Color.DarkGray
    End Sub
#End Region

#Region "fluent"
    Private Sub LB_CB_fluent_info_Click(sender As Object, e As EventArgs) Handles LB_CB_fluent_info.Click
        MsgBox($"Enables seamless transition between videos in queue (- usefull for a group of videos). {vbCrLf}{vbCrLf}(Disables the notification for finishing a trimmed video)", MsgBoxStyle.Information)
    End Sub

    Private Sub LB_CB_fluent_info_MouseEnter(sender As Object, e As EventArgs) Handles LB_CB_fluent_info.MouseEnter
        LB_CB_fluent_info.ForeColor = Color.DimGray
    End Sub

    Private Sub LB_CB_fluent_info_MouseLeave(sender As Object, e As EventArgs) Handles LB_CB_fluent_info.MouseLeave
        LB_CB_fluent_info.ForeColor = Color.DarkGray
    End Sub
#End Region

#End Region

#End Region

#Region "Drag & Drop"

    Private Sub BTN_load_dragdrop_DragEnter(sender As Object, e As DragEventArgs) Handles BTN_load_dragdrop.DragEnter, BTN_queue_dragdrop.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub BTN_load_dragdrop_DragDrop(sender As Object, e As DragEventArgs) Handles BTN_load_dragdrop.DragDrop, BTN_queue_dragdrop.DragDrop
        For Each fi In e.Data.GetData(DataFormats.FileDrop)
            Dim file As FileInfo = New FileInfo(fi)
            If file.Extension = ".mkv" Or file.Extension = ".webm" Or file.Extension = ".flv" Or file.Extension = ".avi" Or file.Extension = ".mov" Or file.Extension = ".mp4" Or file.Extension = ".mpg" Or file.Extension = ".mpeg" Or file.Extension = ".m4v" Then
                If file.FullName IsNot "" Then
                    If queue.Contains(file.FullName) Then
                        MsgBox("Video already exists in queue!", MsgBoxStyle.Critical)
                    Else
                        Try
                            If queue.Contains(file.FullName) Then
                                MsgBox("Video already exists in queue!", MsgBoxStyle.Critical)
                            Else
                                queue.Add(file.FullName)
                                ReloadQueue()
                                TabControl1.SelectedTab = TabControl1.TabPages(1)
                                If TB_state_current.Text = "" Then
                                    LoadCurrent(0)
                                End If
                            End If
                        Catch ex As Exception
                            MsgBox("Failed adding video to queue!", MsgBoxStyle.Critical)
                        End Try
                    End If
                End If
            Else
                MsgBox("The file you drag & dropped in isnt supportet! (Supportet formats: .mkv .webm .flv .avi .mov .mp4 .mpg .mpeg .m4v)", MsgBoxStyle.Critical)
            End If
        Next
    End Sub
#End Region

End Class