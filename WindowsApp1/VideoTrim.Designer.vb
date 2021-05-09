<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VideoTrim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VideoTrim))
        Me.MS = New System.Windows.Forms.MenuStrip()
        Me.TSM_load = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_load_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_load_folder = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_load_clear = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_ffmpeg = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_ffmpeg_github = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_ffmpeg_set = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSM_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.OFD_load_file = New System.Windows.Forms.OpenFileDialog()
        Me.FBD_ffmpeg = New System.Windows.Forms.FolderBrowserDialog()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BTN_load_dragdrop = New System.Windows.Forms.Button()
        Me.LB_start_loadfoldertext = New System.Windows.Forms.Label()
        Me.LB_start_loadfiletext = New System.Windows.Forms.Label()
        Me.BTN_load_folder = New System.Windows.Forms.Button()
        Me.BTN_load_file = New System.Windows.Forms.Button()
        Me.LB_start_desc = New System.Windows.Forms.Label()
        Me.LB_start_title = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GB_info = New System.Windows.Forms.GroupBox()
        Me.TB_info_audiosamplerate = New System.Windows.Forms.TextBox()
        Me.TB_info_audiobitrate = New System.Windows.Forms.TextBox()
        Me.TB_info_audiocodec = New System.Windows.Forms.TextBox()
        Me.TB_info_audiostreams = New System.Windows.Forms.TextBox()
        Me.TB_info_videostreams = New System.Windows.Forms.TextBox()
        Me.TB_info_totalframes = New System.Windows.Forms.TextBox()
        Me.TB_info_framerate = New System.Windows.Forms.TextBox()
        Me.TB_info_resolution = New System.Windows.Forms.TextBox()
        Me.TB_info_bitrate = New System.Windows.Forms.TextBox()
        Me.TB_info_codec = New System.Windows.Forms.TextBox()
        Me.TB_info_format = New System.Windows.Forms.TextBox()
        Me.TB_info_duration = New System.Windows.Forms.TextBox()
        Me.TB_info_filesize = New System.Windows.Forms.TextBox()
        Me.TB_info_name = New System.Windows.Forms.TextBox()
        Me.LB_info_bitrate = New System.Windows.Forms.Label()
        Me.LB_info_audiosamplerate = New System.Windows.Forms.Label()
        Me.LB_info_audiobitrate = New System.Windows.Forms.Label()
        Me.LB_info_audiocodec = New System.Windows.Forms.Label()
        Me.LB_info_audiostreams = New System.Windows.Forms.Label()
        Me.LB_info_videostreams = New System.Windows.Forms.Label()
        Me.LB_info_totalframes = New System.Windows.Forms.Label()
        Me.LB_info_framerate = New System.Windows.Forms.Label()
        Me.LB_info_resolution = New System.Windows.Forms.Label()
        Me.LB_info_codec = New System.Windows.Forms.Label()
        Me.LB_info_format = New System.Windows.Forms.Label()
        Me.LB_info_duration = New System.Windows.Forms.Label()
        Me.LB_info_filesize = New System.Windows.Forms.Label()
        Me.LB_info_name = New System.Windows.Forms.Label()
        Me.GB_state = New System.Windows.Forms.GroupBox()
        Me.PNL_CB_fluent = New System.Windows.Forms.Panel()
        Me.CB_fluent = New System.Windows.Forms.CheckBox()
        Me.LB_fluent = New System.Windows.Forms.Label()
        Me.PNL_CB_bg = New System.Windows.Forms.Panel()
        Me.CB_fastmode = New System.Windows.Forms.CheckBox()
        Me.LB_CB_fluent_info = New System.Windows.Forms.Label()
        Me.TB_state_currentpart = New System.Windows.Forms.TextBox()
        Me.LB_state_console = New System.Windows.Forms.Label()
        Me.RTB_state_console = New System.Windows.Forms.RichTextBox()
        Me.LB_state_trimin = New System.Windows.Forms.Label()
        Me.BTN_current_cacel = New System.Windows.Forms.Button()
        Me.BTN_current_start = New System.Windows.Forms.Button()
        Me.TB_state_current_num = New System.Windows.Forms.TextBox()
        Me.TB_state_current = New System.Windows.Forms.TextBox()
        Me.LB_state_totalprogress = New System.Windows.Forms.Label()
        Me.PB_state_totalprogress = New System.Windows.Forms.ProgressBar()
        Me.LB_state_currentprogress = New System.Windows.Forms.Label()
        Me.PB_state_currentprogress = New System.Windows.Forms.ProgressBar()
        Me.LB_state_current = New System.Windows.Forms.Label()
        Me.LB_CB_fastmode = New System.Windows.Forms.Label()
        Me.LB_CB_fastmode_info = New System.Windows.Forms.Label()
        Me.GB_Output = New System.Windows.Forms.GroupBox()
        Me.LB_output_extfolder = New System.Windows.Forms.Label()
        Me.CB_output_exfolder = New System.Windows.Forms.CheckBox()
        Me.TB_output_name = New System.Windows.Forms.TextBox()
        Me.LB_output_name = New System.Windows.Forms.Label()
        Me.CB_output_format = New System.Windows.Forms.ComboBox()
        Me.LB_output_format = New System.Windows.Forms.Label()
        Me.BTN_output_folder = New System.Windows.Forms.Button()
        Me.TB_output_folder = New System.Windows.Forms.TextBox()
        Me.LB_output_folder = New System.Windows.Forms.Label()
        Me.LB_output_replace = New System.Windows.Forms.Label()
        Me.GB_queue = New System.Windows.Forms.GroupBox()
        Me.BTN_queue_dragdrop = New System.Windows.Forms.Button()
        Me.BTN_queue_folder = New System.Windows.Forms.Button()
        Me.BTN_queue_file = New System.Windows.Forms.Button()
        Me.BTN_clear = New System.Windows.Forms.Button()
        Me.FLY_queue = New System.Windows.Forms.FlowLayoutPanel()
        Me.FBD_load_folder = New System.Windows.Forms.FolderBrowserDialog()
        Me.FBD_output_folder = New System.Windows.Forms.FolderBrowserDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BW_process = New System.ComponentModel.BackgroundWorker()
        Me.BW_infos = New System.ComponentModel.BackgroundWorker()
        Me.MS.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GB_info.SuspendLayout()
        Me.GB_state.SuspendLayout()
        Me.PNL_CB_fluent.SuspendLayout()
        Me.PNL_CB_bg.SuspendLayout()
        Me.GB_Output.SuspendLayout()
        Me.GB_queue.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MS
        '
        Me.MS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_load, Me.TSM_ffmpeg, Me.TSM_about})
        Me.MS.Location = New System.Drawing.Point(0, 0)
        Me.MS.Name = "MS"
        Me.MS.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MS.Size = New System.Drawing.Size(785, 24)
        Me.MS.TabIndex = 1
        Me.MS.Text = "MenuStrip1"
        '
        'TSM_load
        '
        Me.TSM_load.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_load_file, Me.TSM_load_folder, Me.TSM_load_clear})
        Me.TSM_load.Name = "TSM_load"
        Me.TSM_load.Size = New System.Drawing.Size(45, 20)
        Me.TSM_load.Text = "Load"
        '
        'TSM_load_file
        '
        Me.TSM_load_file.Name = "TSM_load_file"
        Me.TSM_load_file.Size = New System.Drawing.Size(107, 22)
        Me.TSM_load_file.Text = "File"
        '
        'TSM_load_folder
        '
        Me.TSM_load_folder.Name = "TSM_load_folder"
        Me.TSM_load_folder.Size = New System.Drawing.Size(107, 22)
        Me.TSM_load_folder.Text = "Folder"
        '
        'TSM_load_clear
        '
        Me.TSM_load_clear.Name = "TSM_load_clear"
        Me.TSM_load_clear.Size = New System.Drawing.Size(107, 22)
        Me.TSM_load_clear.Text = "Clear"
        '
        'TSM_ffmpeg
        '
        Me.TSM_ffmpeg.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSM_ffmpeg_github, Me.TSM_ffmpeg_set})
        Me.TSM_ffmpeg.Name = "TSM_ffmpeg"
        Me.TSM_ffmpeg.Size = New System.Drawing.Size(63, 20)
        Me.TSM_ffmpeg.Text = "FFMPEG"
        '
        'TSM_ffmpeg_github
        '
        Me.TSM_ffmpeg_github.Name = "TSM_ffmpeg_github"
        Me.TSM_ffmpeg_github.Size = New System.Drawing.Size(126, 22)
        Me.TSM_ffmpeg_github.Text = "GitHub"
        '
        'TSM_ffmpeg_set
        '
        Me.TSM_ffmpeg_set.Name = "TSM_ffmpeg_set"
        Me.TSM_ffmpeg_set.Size = New System.Drawing.Size(126, 22)
        Me.TSM_ffmpeg_set.Text = "Set Folder"
        '
        'TSM_about
        '
        Me.TSM_about.Name = "TSM_about"
        Me.TSM_about.Size = New System.Drawing.Size(52, 20)
        Me.TSM_about.Text = "About"
        '
        'OFD_load_file
        '
        Me.OFD_load_file.Filter = "mkv|*.mkv|webm|*.webm|flv|*.flv|avi|*.avi|mov|*.mov|mp4|*.mp4|mpg|*.mpg|mpeg|*.mp" &
    "eg|m4v|*.m4v"
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.BTN_load_dragdrop)
        Me.TabPage1.Controls.Add(Me.LB_start_loadfoldertext)
        Me.TabPage1.Controls.Add(Me.LB_start_loadfiletext)
        Me.TabPage1.Controls.Add(Me.BTN_load_folder)
        Me.TabPage1.Controls.Add(Me.BTN_load_file)
        Me.TabPage1.Controls.Add(Me.LB_start_desc)
        Me.TabPage1.Controls.Add(Me.LB_start_title)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(755, 639)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'BTN_load_dragdrop
        '
        Me.BTN_load_dragdrop.AllowDrop = True
        Me.BTN_load_dragdrop.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BTN_load_dragdrop.Location = New System.Drawing.Point(198, 386)
        Me.BTN_load_dragdrop.Name = "BTN_load_dragdrop"
        Me.BTN_load_dragdrop.Size = New System.Drawing.Size(356, 42)
        Me.BTN_load_dragdrop.TabIndex = 6
        Me.BTN_load_dragdrop.Text = "OR Drag and Dtop File/s here!"
        Me.BTN_load_dragdrop.UseVisualStyleBackColor = True
        '
        'LB_start_loadfoldertext
        '
        Me.LB_start_loadfoldertext.AutoSize = True
        Me.LB_start_loadfoldertext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LB_start_loadfoldertext.Location = New System.Drawing.Point(380, 277)
        Me.LB_start_loadfoldertext.Name = "LB_start_loadfoldertext"
        Me.LB_start_loadfoldertext.Size = New System.Drawing.Size(150, 13)
        Me.LB_start_loadfoldertext.TabIndex = 5
        Me.LB_start_loadfoldertext.Text = "*load an entire folder of videos"
        '
        'LB_start_loadfiletext
        '
        Me.LB_start_loadfiletext.AutoSize = True
        Me.LB_start_loadfiletext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LB_start_loadfiletext.Location = New System.Drawing.Point(199, 277)
        Me.LB_start_loadfiletext.Name = "LB_start_loadfiletext"
        Me.LB_start_loadfiletext.Size = New System.Drawing.Size(111, 13)
        Me.LB_start_loadfiletext.TabIndex = 4
        Me.LB_start_loadfiletext.Text = "*load one single video"
        '
        'BTN_load_folder
        '
        Me.BTN_load_folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BTN_load_folder.Location = New System.Drawing.Point(379, 293)
        Me.BTN_load_folder.Name = "BTN_load_folder"
        Me.BTN_load_folder.Size = New System.Drawing.Size(175, 84)
        Me.BTN_load_folder.TabIndex = 3
        Me.BTN_load_folder.Text = "Load Folder"
        Me.BTN_load_folder.UseVisualStyleBackColor = True
        '
        'BTN_load_file
        '
        Me.BTN_load_file.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.BTN_load_file.Location = New System.Drawing.Point(198, 293)
        Me.BTN_load_file.Name = "BTN_load_file"
        Me.BTN_load_file.Size = New System.Drawing.Size(175, 84)
        Me.BTN_load_file.TabIndex = 2
        Me.BTN_load_file.Text = "Load File"
        Me.BTN_load_file.UseVisualStyleBackColor = True
        '
        'LB_start_desc
        '
        Me.LB_start_desc.AutoSize = True
        Me.LB_start_desc.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.LB_start_desc.Location = New System.Drawing.Point(161, 219)
        Me.LB_start_desc.Name = "LB_start_desc"
        Me.LB_start_desc.Size = New System.Drawing.Size(433, 29)
        Me.LB_start_desc.TabIndex = 1
        Me.LB_start_desc.Text = "Please load a video into the program."
        '
        'LB_start_title
        '
        Me.LB_start_title.AutoSize = True
        Me.LB_start_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_start_title.Location = New System.Drawing.Point(230, 175)
        Me.LB_start_title.Name = "LB_start_title"
        Me.LB_start_title.Size = New System.Drawing.Size(291, 44)
        Me.LB_start_title.TabIndex = 0
        Me.LB_start_title.Text = "Lets get startet!"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(10, 17)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(763, 665)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.GB_info)
        Me.TabPage2.Controls.Add(Me.GB_state)
        Me.TabPage2.Controls.Add(Me.GB_Output)
        Me.TabPage2.Controls.Add(Me.GB_queue)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(755, 639)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'GB_info
        '
        Me.GB_info.Controls.Add(Me.TB_info_audiosamplerate)
        Me.GB_info.Controls.Add(Me.TB_info_audiobitrate)
        Me.GB_info.Controls.Add(Me.TB_info_audiocodec)
        Me.GB_info.Controls.Add(Me.TB_info_audiostreams)
        Me.GB_info.Controls.Add(Me.TB_info_videostreams)
        Me.GB_info.Controls.Add(Me.TB_info_totalframes)
        Me.GB_info.Controls.Add(Me.TB_info_framerate)
        Me.GB_info.Controls.Add(Me.TB_info_resolution)
        Me.GB_info.Controls.Add(Me.TB_info_bitrate)
        Me.GB_info.Controls.Add(Me.TB_info_codec)
        Me.GB_info.Controls.Add(Me.TB_info_format)
        Me.GB_info.Controls.Add(Me.TB_info_duration)
        Me.GB_info.Controls.Add(Me.TB_info_filesize)
        Me.GB_info.Controls.Add(Me.TB_info_name)
        Me.GB_info.Controls.Add(Me.LB_info_bitrate)
        Me.GB_info.Controls.Add(Me.LB_info_audiosamplerate)
        Me.GB_info.Controls.Add(Me.LB_info_audiobitrate)
        Me.GB_info.Controls.Add(Me.LB_info_audiocodec)
        Me.GB_info.Controls.Add(Me.LB_info_audiostreams)
        Me.GB_info.Controls.Add(Me.LB_info_videostreams)
        Me.GB_info.Controls.Add(Me.LB_info_totalframes)
        Me.GB_info.Controls.Add(Me.LB_info_framerate)
        Me.GB_info.Controls.Add(Me.LB_info_resolution)
        Me.GB_info.Controls.Add(Me.LB_info_codec)
        Me.GB_info.Controls.Add(Me.LB_info_format)
        Me.GB_info.Controls.Add(Me.LB_info_duration)
        Me.GB_info.Controls.Add(Me.LB_info_filesize)
        Me.GB_info.Controls.Add(Me.LB_info_name)
        Me.GB_info.Location = New System.Drawing.Point(6, 311)
        Me.GB_info.Name = "GB_info"
        Me.GB_info.Size = New System.Drawing.Size(438, 133)
        Me.GB_info.TabIndex = 4
        Me.GB_info.TabStop = False
        Me.GB_info.Text = "Current Video Info"
        '
        'TB_info_audiosamplerate
        '
        Me.TB_info_audiosamplerate.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_audiosamplerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_audiosamplerate.Location = New System.Drawing.Point(380, 54)
        Me.TB_info_audiosamplerate.Multiline = True
        Me.TB_info_audiosamplerate.Name = "TB_info_audiosamplerate"
        Me.TB_info_audiosamplerate.ReadOnly = True
        Me.TB_info_audiosamplerate.Size = New System.Drawing.Size(52, 16)
        Me.TB_info_audiosamplerate.TabIndex = 48
        Me.TB_info_audiosamplerate.Text = "N/A"
        '
        'TB_info_audiobitrate
        '
        Me.TB_info_audiobitrate.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_audiobitrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_audiobitrate.Location = New System.Drawing.Point(358, 36)
        Me.TB_info_audiobitrate.Multiline = True
        Me.TB_info_audiobitrate.Name = "TB_info_audiobitrate"
        Me.TB_info_audiobitrate.ReadOnly = True
        Me.TB_info_audiobitrate.Size = New System.Drawing.Size(74, 16)
        Me.TB_info_audiobitrate.TabIndex = 47
        Me.TB_info_audiobitrate.Text = "N/A"
        '
        'TB_info_audiocodec
        '
        Me.TB_info_audiocodec.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_audiocodec.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_audiocodec.Location = New System.Drawing.Point(358, 16)
        Me.TB_info_audiocodec.Multiline = True
        Me.TB_info_audiocodec.Name = "TB_info_audiocodec"
        Me.TB_info_audiocodec.ReadOnly = True
        Me.TB_info_audiocodec.Size = New System.Drawing.Size(74, 16)
        Me.TB_info_audiocodec.TabIndex = 46
        Me.TB_info_audiocodec.Text = "N/A"
        '
        'TB_info_audiostreams
        '
        Me.TB_info_audiostreams.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_audiostreams.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_audiostreams.Location = New System.Drawing.Point(219, 90)
        Me.TB_info_audiostreams.Multiline = True
        Me.TB_info_audiostreams.Name = "TB_info_audiostreams"
        Me.TB_info_audiostreams.ReadOnly = True
        Me.TB_info_audiostreams.Size = New System.Drawing.Size(65, 16)
        Me.TB_info_audiostreams.TabIndex = 45
        Me.TB_info_audiostreams.Text = "N/A"
        '
        'TB_info_videostreams
        '
        Me.TB_info_videostreams.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_videostreams.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_videostreams.Location = New System.Drawing.Point(219, 72)
        Me.TB_info_videostreams.Multiline = True
        Me.TB_info_videostreams.Name = "TB_info_videostreams"
        Me.TB_info_videostreams.ReadOnly = True
        Me.TB_info_videostreams.Size = New System.Drawing.Size(65, 16)
        Me.TB_info_videostreams.TabIndex = 44
        Me.TB_info_videostreams.Text = "N/A"
        '
        'TB_info_totalframes
        '
        Me.TB_info_totalframes.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_totalframes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_totalframes.Location = New System.Drawing.Point(212, 54)
        Me.TB_info_totalframes.Multiline = True
        Me.TB_info_totalframes.Name = "TB_info_totalframes"
        Me.TB_info_totalframes.ReadOnly = True
        Me.TB_info_totalframes.Size = New System.Drawing.Size(72, 16)
        Me.TB_info_totalframes.TabIndex = 43
        Me.TB_info_totalframes.Text = "N/A"
        '
        'TB_info_framerate
        '
        Me.TB_info_framerate.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_framerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_framerate.Location = New System.Drawing.Point(201, 36)
        Me.TB_info_framerate.Multiline = True
        Me.TB_info_framerate.Name = "TB_info_framerate"
        Me.TB_info_framerate.ReadOnly = True
        Me.TB_info_framerate.Size = New System.Drawing.Size(83, 16)
        Me.TB_info_framerate.TabIndex = 42
        Me.TB_info_framerate.Text = "N/A"
        '
        'TB_info_resolution
        '
        Me.TB_info_resolution.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_resolution.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_resolution.Location = New System.Drawing.Point(203, 17)
        Me.TB_info_resolution.Multiline = True
        Me.TB_info_resolution.Name = "TB_info_resolution"
        Me.TB_info_resolution.ReadOnly = True
        Me.TB_info_resolution.Size = New System.Drawing.Size(81, 16)
        Me.TB_info_resolution.TabIndex = 41
        Me.TB_info_resolution.Text = "N/A"
        '
        'TB_info_bitrate
        '
        Me.TB_info_bitrate.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_bitrate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_bitrate.Location = New System.Drawing.Point(45, 108)
        Me.TB_info_bitrate.Multiline = True
        Me.TB_info_bitrate.Name = "TB_info_bitrate"
        Me.TB_info_bitrate.ReadOnly = True
        Me.TB_info_bitrate.Size = New System.Drawing.Size(94, 16)
        Me.TB_info_bitrate.TabIndex = 40
        Me.TB_info_bitrate.Text = "N/A"
        '
        'TB_info_codec
        '
        Me.TB_info_codec.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_codec.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_codec.Location = New System.Drawing.Point(47, 90)
        Me.TB_info_codec.Multiline = True
        Me.TB_info_codec.Name = "TB_info_codec"
        Me.TB_info_codec.ReadOnly = True
        Me.TB_info_codec.Size = New System.Drawing.Size(92, 16)
        Me.TB_info_codec.TabIndex = 39
        Me.TB_info_codec.Text = "N/A"
        '
        'TB_info_format
        '
        Me.TB_info_format.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_format.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_format.Location = New System.Drawing.Point(47, 72)
        Me.TB_info_format.Multiline = True
        Me.TB_info_format.Name = "TB_info_format"
        Me.TB_info_format.ReadOnly = True
        Me.TB_info_format.Size = New System.Drawing.Size(92, 16)
        Me.TB_info_format.TabIndex = 38
        Me.TB_info_format.Text = "N/A"
        '
        'TB_info_duration
        '
        Me.TB_info_duration.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_duration.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_duration.Location = New System.Drawing.Point(55, 54)
        Me.TB_info_duration.Multiline = True
        Me.TB_info_duration.Name = "TB_info_duration"
        Me.TB_info_duration.ReadOnly = True
        Me.TB_info_duration.Size = New System.Drawing.Size(84, 16)
        Me.TB_info_duration.TabIndex = 37
        Me.TB_info_duration.Text = "N/A"
        '
        'TB_info_filesize
        '
        Me.TB_info_filesize.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_filesize.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_filesize.Location = New System.Drawing.Point(51, 36)
        Me.TB_info_filesize.Multiline = True
        Me.TB_info_filesize.Name = "TB_info_filesize"
        Me.TB_info_filesize.ReadOnly = True
        Me.TB_info_filesize.Size = New System.Drawing.Size(88, 16)
        Me.TB_info_filesize.TabIndex = 36
        Me.TB_info_filesize.Text = "N/A"
        '
        'TB_info_name
        '
        Me.TB_info_name.BackColor = System.Drawing.SystemColors.Control
        Me.TB_info_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.TB_info_name.Location = New System.Drawing.Point(44, 18)
        Me.TB_info_name.Multiline = True
        Me.TB_info_name.Name = "TB_info_name"
        Me.TB_info_name.ReadOnly = True
        Me.TB_info_name.Size = New System.Drawing.Size(95, 16)
        Me.TB_info_name.TabIndex = 22
        Me.TB_info_name.Text = "N/A"
        '
        'LB_info_bitrate
        '
        Me.LB_info_bitrate.AutoSize = True
        Me.LB_info_bitrate.Location = New System.Drawing.Point(6, 110)
        Me.LB_info_bitrate.Name = "LB_info_bitrate"
        Me.LB_info_bitrate.Size = New System.Drawing.Size(40, 13)
        Me.LB_info_bitrate.TabIndex = 35
        Me.LB_info_bitrate.Text = "Bitrate:"
        '
        'LB_info_audiosamplerate
        '
        Me.LB_info_audiosamplerate.AutoSize = True
        Me.LB_info_audiosamplerate.Location = New System.Drawing.Point(291, 55)
        Me.LB_info_audiosamplerate.Name = "LB_info_audiosamplerate"
        Me.LB_info_audiosamplerate.Size = New System.Drawing.Size(90, 13)
        Me.LB_info_audiosamplerate.TabIndex = 34
        Me.LB_info_audiosamplerate.Text = "AudioSamplerate:"
        '
        'LB_info_audiobitrate
        '
        Me.LB_info_audiobitrate.AutoSize = True
        Me.LB_info_audiobitrate.Location = New System.Drawing.Point(291, 37)
        Me.LB_info_audiobitrate.Name = "LB_info_audiobitrate"
        Me.LB_info_audiobitrate.Size = New System.Drawing.Size(68, 13)
        Me.LB_info_audiobitrate.TabIndex = 33
        Me.LB_info_audiobitrate.Text = "AudioBItrate:"
        '
        'LB_info_audiocodec
        '
        Me.LB_info_audiocodec.AutoSize = True
        Me.LB_info_audiocodec.Location = New System.Drawing.Point(291, 17)
        Me.LB_info_audiocodec.Name = "LB_info_audiocodec"
        Me.LB_info_audiocodec.Size = New System.Drawing.Size(68, 13)
        Me.LB_info_audiocodec.TabIndex = 32
        Me.LB_info_audiocodec.Text = "AudioCodec:"
        '
        'LB_info_audiostreams
        '
        Me.LB_info_audiostreams.AutoSize = True
        Me.LB_info_audiostreams.Location = New System.Drawing.Point(145, 92)
        Me.LB_info_audiostreams.Name = "LB_info_audiostreams"
        Me.LB_info_audiostreams.Size = New System.Drawing.Size(75, 13)
        Me.LB_info_audiostreams.TabIndex = 31
        Me.LB_info_audiostreams.Text = "AudioStreams:"
        '
        'LB_info_videostreams
        '
        Me.LB_info_videostreams.AutoSize = True
        Me.LB_info_videostreams.Location = New System.Drawing.Point(145, 73)
        Me.LB_info_videostreams.Name = "LB_info_videostreams"
        Me.LB_info_videostreams.Size = New System.Drawing.Size(75, 13)
        Me.LB_info_videostreams.TabIndex = 30
        Me.LB_info_videostreams.Text = "VideoStreams:"
        '
        'LB_info_totalframes
        '
        Me.LB_info_totalframes.AutoSize = True
        Me.LB_info_totalframes.Location = New System.Drawing.Point(145, 55)
        Me.LB_info_totalframes.Name = "LB_info_totalframes"
        Me.LB_info_totalframes.Size = New System.Drawing.Size(68, 13)
        Me.LB_info_totalframes.TabIndex = 29
        Me.LB_info_totalframes.Text = "TotalFrames:"
        '
        'LB_info_framerate
        '
        Me.LB_info_framerate.AutoSize = True
        Me.LB_info_framerate.Location = New System.Drawing.Point(145, 37)
        Me.LB_info_framerate.Name = "LB_info_framerate"
        Me.LB_info_framerate.Size = New System.Drawing.Size(57, 13)
        Me.LB_info_framerate.TabIndex = 28
        Me.LB_info_framerate.Text = "Framerate:"
        '
        'LB_info_resolution
        '
        Me.LB_info_resolution.AutoSize = True
        Me.LB_info_resolution.Location = New System.Drawing.Point(145, 19)
        Me.LB_info_resolution.Name = "LB_info_resolution"
        Me.LB_info_resolution.Size = New System.Drawing.Size(60, 13)
        Me.LB_info_resolution.TabIndex = 27
        Me.LB_info_resolution.Text = "Resolution:"
        '
        'LB_info_codec
        '
        Me.LB_info_codec.AutoSize = True
        Me.LB_info_codec.Location = New System.Drawing.Point(7, 92)
        Me.LB_info_codec.Name = "LB_info_codec"
        Me.LB_info_codec.Size = New System.Drawing.Size(41, 13)
        Me.LB_info_codec.TabIndex = 26
        Me.LB_info_codec.Text = "Codec:"
        '
        'LB_info_format
        '
        Me.LB_info_format.AutoSize = True
        Me.LB_info_format.Location = New System.Drawing.Point(6, 73)
        Me.LB_info_format.Name = "LB_info_format"
        Me.LB_info_format.Size = New System.Drawing.Size(42, 13)
        Me.LB_info_format.TabIndex = 25
        Me.LB_info_format.Text = "Format:"
        '
        'LB_info_duration
        '
        Me.LB_info_duration.AutoSize = True
        Me.LB_info_duration.Location = New System.Drawing.Point(7, 55)
        Me.LB_info_duration.Name = "LB_info_duration"
        Me.LB_info_duration.Size = New System.Drawing.Size(50, 13)
        Me.LB_info_duration.TabIndex = 24
        Me.LB_info_duration.Text = "Duration:"
        '
        'LB_info_filesize
        '
        Me.LB_info_filesize.AutoSize = True
        Me.LB_info_filesize.Location = New System.Drawing.Point(7, 37)
        Me.LB_info_filesize.Name = "LB_info_filesize"
        Me.LB_info_filesize.Size = New System.Drawing.Size(46, 13)
        Me.LB_info_filesize.TabIndex = 23
        Me.LB_info_filesize.Text = "FileSize:"
        '
        'LB_info_name
        '
        Me.LB_info_name.AutoSize = True
        Me.LB_info_name.Location = New System.Drawing.Point(7, 19)
        Me.LB_info_name.Name = "LB_info_name"
        Me.LB_info_name.Size = New System.Drawing.Size(38, 13)
        Me.LB_info_name.TabIndex = 22
        Me.LB_info_name.Text = "Name:"
        '
        'GB_state
        '
        Me.GB_state.Controls.Add(Me.PNL_CB_fluent)
        Me.GB_state.Controls.Add(Me.LB_fluent)
        Me.GB_state.Controls.Add(Me.PNL_CB_bg)
        Me.GB_state.Controls.Add(Me.LB_CB_fluent_info)
        Me.GB_state.Controls.Add(Me.TB_state_currentpart)
        Me.GB_state.Controls.Add(Me.LB_state_console)
        Me.GB_state.Controls.Add(Me.RTB_state_console)
        Me.GB_state.Controls.Add(Me.LB_state_trimin)
        Me.GB_state.Controls.Add(Me.BTN_current_cacel)
        Me.GB_state.Controls.Add(Me.BTN_current_start)
        Me.GB_state.Controls.Add(Me.TB_state_current_num)
        Me.GB_state.Controls.Add(Me.TB_state_current)
        Me.GB_state.Controls.Add(Me.LB_state_totalprogress)
        Me.GB_state.Controls.Add(Me.PB_state_totalprogress)
        Me.GB_state.Controls.Add(Me.LB_state_currentprogress)
        Me.GB_state.Controls.Add(Me.PB_state_currentprogress)
        Me.GB_state.Controls.Add(Me.LB_state_current)
        Me.GB_state.Controls.Add(Me.LB_CB_fastmode)
        Me.GB_state.Controls.Add(Me.LB_CB_fastmode_info)
        Me.GB_state.Location = New System.Drawing.Point(6, 6)
        Me.GB_state.Name = "GB_state"
        Me.GB_state.Size = New System.Drawing.Size(444, 299)
        Me.GB_state.TabIndex = 3
        Me.GB_state.TabStop = False
        Me.GB_state.Text = "State"
        '
        'PNL_CB_fluent
        '
        Me.PNL_CB_fluent.BackColor = System.Drawing.SystemColors.ControlText
        Me.PNL_CB_fluent.Controls.Add(Me.CB_fluent)
        Me.PNL_CB_fluent.Location = New System.Drawing.Point(131, 129)
        Me.PNL_CB_fluent.Name = "PNL_CB_fluent"
        Me.PNL_CB_fluent.Size = New System.Drawing.Size(12, 12)
        Me.PNL_CB_fluent.TabIndex = 26
        '
        'CB_fluent
        '
        Me.CB_fluent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.CB_fluent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_fluent.Location = New System.Drawing.Point(0, 1)
        Me.CB_fluent.Name = "CB_fluent"
        Me.CB_fluent.Size = New System.Drawing.Size(11, 10)
        Me.CB_fluent.TabIndex = 22
        Me.CB_fluent.Text = "Use Fastmode"
        Me.CB_fluent.UseVisualStyleBackColor = True
        '
        'LB_fluent
        '
        Me.LB_fluent.AutoSize = True
        Me.LB_fluent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.LB_fluent.Location = New System.Drawing.Point(143, 129)
        Me.LB_fluent.Name = "LB_fluent"
        Me.LB_fluent.Size = New System.Drawing.Size(69, 13)
        Me.LB_fluent.TabIndex = 27
        Me.LB_fluent.Text = "Fluent queue"
        '
        'PNL_CB_bg
        '
        Me.PNL_CB_bg.BackColor = System.Drawing.SystemColors.ControlText
        Me.PNL_CB_bg.Controls.Add(Me.CB_fastmode)
        Me.PNL_CB_bg.Location = New System.Drawing.Point(131, 115)
        Me.PNL_CB_bg.Name = "PNL_CB_bg"
        Me.PNL_CB_bg.Size = New System.Drawing.Size(12, 12)
        Me.PNL_CB_bg.TabIndex = 23
        '
        'CB_fastmode
        '
        Me.CB_fastmode.Checked = True
        Me.CB_fastmode.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_fastmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.CB_fastmode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CB_fastmode.Location = New System.Drawing.Point(0, 1)
        Me.CB_fastmode.Name = "CB_fastmode"
        Me.CB_fastmode.Size = New System.Drawing.Size(11, 10)
        Me.CB_fastmode.TabIndex = 22
        Me.CB_fastmode.Text = "Use Fastmode"
        Me.CB_fastmode.UseVisualStyleBackColor = True
        '
        'LB_CB_fluent_info
        '
        Me.LB_CB_fluent_info.AutoSize = True
        Me.LB_CB_fluent_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_CB_fluent_info.ForeColor = System.Drawing.Color.DarkGray
        Me.LB_CB_fluent_info.Location = New System.Drawing.Point(208, 129)
        Me.LB_CB_fluent_info.Name = "LB_CB_fluent_info"
        Me.LB_CB_fluent_info.Size = New System.Drawing.Size(13, 13)
        Me.LB_CB_fluent_info.TabIndex = 28
        Me.LB_CB_fluent_info.Text = "?"
        '
        'TB_state_currentpart
        '
        Me.TB_state_currentpart.BackColor = System.Drawing.SystemColors.Control
        Me.TB_state_currentpart.Location = New System.Drawing.Point(388, 19)
        Me.TB_state_currentpart.Name = "TB_state_currentpart"
        Me.TB_state_currentpart.ReadOnly = True
        Me.TB_state_currentpart.Size = New System.Drawing.Size(50, 20)
        Me.TB_state_currentpart.TabIndex = 21
        Me.TB_state_currentpart.Text = "0"
        Me.TB_state_currentpart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LB_state_console
        '
        Me.LB_state_console.AutoSize = True
        Me.LB_state_console.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LB_state_console.Location = New System.Drawing.Point(7, 240)
        Me.LB_state_console.Name = "LB_state_console"
        Me.LB_state_console.Size = New System.Drawing.Size(48, 13)
        Me.LB_state_console.TabIndex = 20
        Me.LB_state_console.Text = "Console:"
        '
        'RTB_state_console
        '
        Me.RTB_state_console.BackColor = System.Drawing.SystemColors.ControlLight
        Me.RTB_state_console.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.RTB_state_console.Location = New System.Drawing.Point(9, 256)
        Me.RTB_state_console.Name = "RTB_state_console"
        Me.RTB_state_console.ReadOnly = True
        Me.RTB_state_console.Size = New System.Drawing.Size(429, 32)
        Me.RTB_state_console.TabIndex = 19
        Me.RTB_state_console.Text = ""
        '
        'LB_state_trimin
        '
        Me.LB_state_trimin.AutoSize = True
        Me.LB_state_trimin.Location = New System.Drawing.Point(158, 58)
        Me.LB_state_trimin.Name = "LB_state_trimin"
        Me.LB_state_trimin.Size = New System.Drawing.Size(60, 13)
        Me.LB_state_trimin.TabIndex = 18
        Me.LB_state_trimin.Text = "Total parts:"
        '
        'BTN_current_cacel
        '
        Me.BTN_current_cacel.Enabled = False
        Me.BTN_current_cacel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BTN_current_cacel.Location = New System.Drawing.Point(220, 77)
        Me.BTN_current_cacel.Name = "BTN_current_cacel"
        Me.BTN_current_cacel.Size = New System.Drawing.Size(85, 35)
        Me.BTN_current_cacel.TabIndex = 17
        Me.BTN_current_cacel.Text = "Cancel"
        Me.BTN_current_cacel.UseVisualStyleBackColor = True
        '
        'BTN_current_start
        '
        Me.BTN_current_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.BTN_current_start.Location = New System.Drawing.Point(130, 77)
        Me.BTN_current_start.Name = "BTN_current_start"
        Me.BTN_current_start.Size = New System.Drawing.Size(85, 35)
        Me.BTN_current_start.TabIndex = 15
        Me.BTN_current_start.Text = "Start"
        Me.BTN_current_start.UseVisualStyleBackColor = True
        '
        'TB_state_current_num
        '
        Me.TB_state_current_num.BackColor = System.Drawing.SystemColors.Window
        Me.TB_state_current_num.Location = New System.Drawing.Point(224, 55)
        Me.TB_state_current_num.MaxLength = 2
        Me.TB_state_current_num.Name = "TB_state_current_num"
        Me.TB_state_current_num.Size = New System.Drawing.Size(50, 20)
        Me.TB_state_current_num.TabIndex = 14
        Me.TB_state_current_num.Text = "2"
        Me.TB_state_current_num.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_state_current
        '
        Me.TB_state_current.BackColor = System.Drawing.SystemColors.Control
        Me.TB_state_current.Location = New System.Drawing.Point(57, 19)
        Me.TB_state_current.Name = "TB_state_current"
        Me.TB_state_current.ReadOnly = True
        Me.TB_state_current.Size = New System.Drawing.Size(325, 20)
        Me.TB_state_current.TabIndex = 13
        '
        'LB_state_totalprogress
        '
        Me.LB_state_totalprogress.AutoSize = True
        Me.LB_state_totalprogress.Location = New System.Drawing.Point(7, 188)
        Me.LB_state_totalprogress.Name = "LB_state_totalprogress"
        Me.LB_state_totalprogress.Size = New System.Drawing.Size(86, 13)
        Me.LB_state_totalprogress.TabIndex = 4
        Me.LB_state_totalprogress.Text = "Queue Progress:"
        '
        'PB_state_totalprogress
        '
        Me.PB_state_totalprogress.Location = New System.Drawing.Point(9, 204)
        Me.PB_state_totalprogress.Name = "PB_state_totalprogress"
        Me.PB_state_totalprogress.Size = New System.Drawing.Size(429, 25)
        Me.PB_state_totalprogress.TabIndex = 3
        '
        'LB_state_currentprogress
        '
        Me.LB_state_currentprogress.AutoSize = True
        Me.LB_state_currentprogress.Location = New System.Drawing.Point(7, 144)
        Me.LB_state_currentprogress.Name = "LB_state_currentprogress"
        Me.LB_state_currentprogress.Size = New System.Drawing.Size(81, 13)
        Me.LB_state_currentprogress.TabIndex = 2
        Me.LB_state_currentprogress.Text = "Video Progress:"
        '
        'PB_state_currentprogress
        '
        Me.PB_state_currentprogress.Location = New System.Drawing.Point(9, 160)
        Me.PB_state_currentprogress.Name = "PB_state_currentprogress"
        Me.PB_state_currentprogress.Size = New System.Drawing.Size(429, 25)
        Me.PB_state_currentprogress.TabIndex = 1
        '
        'LB_state_current
        '
        Me.LB_state_current.AutoSize = True
        Me.LB_state_current.Location = New System.Drawing.Point(7, 22)
        Me.LB_state_current.Name = "LB_state_current"
        Me.LB_state_current.Size = New System.Drawing.Size(44, 13)
        Me.LB_state_current.TabIndex = 0
        Me.LB_state_current.Text = "Current:"
        '
        'LB_CB_fastmode
        '
        Me.LB_CB_fastmode.AutoSize = True
        Me.LB_CB_fastmode.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.LB_CB_fastmode.Location = New System.Drawing.Point(143, 115)
        Me.LB_CB_fastmode.Name = "LB_CB_fastmode"
        Me.LB_CB_fastmode.Size = New System.Drawing.Size(71, 13)
        Me.LB_CB_fastmode.TabIndex = 24
        Me.LB_CB_fastmode.Text = "Use fastmode"
        '
        'LB_CB_fastmode_info
        '
        Me.LB_CB_fastmode_info.AutoSize = True
        Me.LB_CB_fastmode_info.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LB_CB_fastmode_info.ForeColor = System.Drawing.Color.DarkGray
        Me.LB_CB_fastmode_info.Location = New System.Drawing.Point(210, 115)
        Me.LB_CB_fastmode_info.Name = "LB_CB_fastmode_info"
        Me.LB_CB_fastmode_info.Size = New System.Drawing.Size(13, 13)
        Me.LB_CB_fastmode_info.TabIndex = 25
        Me.LB_CB_fastmode_info.Text = "?"
        '
        'GB_Output
        '
        Me.GB_Output.Controls.Add(Me.LB_output_extfolder)
        Me.GB_Output.Controls.Add(Me.CB_output_exfolder)
        Me.GB_Output.Controls.Add(Me.TB_output_name)
        Me.GB_Output.Controls.Add(Me.LB_output_name)
        Me.GB_Output.Controls.Add(Me.CB_output_format)
        Me.GB_Output.Controls.Add(Me.LB_output_format)
        Me.GB_Output.Controls.Add(Me.BTN_output_folder)
        Me.GB_Output.Controls.Add(Me.TB_output_folder)
        Me.GB_Output.Controls.Add(Me.LB_output_folder)
        Me.GB_Output.Controls.Add(Me.LB_output_replace)
        Me.GB_Output.Location = New System.Drawing.Point(6, 450)
        Me.GB_Output.Name = "GB_Output"
        Me.GB_Output.Size = New System.Drawing.Size(444, 183)
        Me.GB_Output.TabIndex = 2
        Me.GB_Output.TabStop = False
        Me.GB_Output.Text = "Output"
        '
        'LB_output_extfolder
        '
        Me.LB_output_extfolder.AutoSize = True
        Me.LB_output_extfolder.Location = New System.Drawing.Point(6, 73)
        Me.LB_output_extfolder.Name = "LB_output_extfolder"
        Me.LB_output_extfolder.Size = New System.Drawing.Size(96, 13)
        Me.LB_output_extfolder.TabIndex = 12
        Me.LB_output_extfolder.Text = "Create extra folder:"
        '
        'CB_output_exfolder
        '
        Me.CB_output_exfolder.AutoSize = True
        Me.CB_output_exfolder.Checked = True
        Me.CB_output_exfolder.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_output_exfolder.Location = New System.Drawing.Point(108, 72)
        Me.CB_output_exfolder.Name = "CB_output_exfolder"
        Me.CB_output_exfolder.Size = New System.Drawing.Size(15, 14)
        Me.CB_output_exfolder.TabIndex = 11
        Me.CB_output_exfolder.UseVisualStyleBackColor = True
        '
        'TB_output_name
        '
        Me.TB_output_name.Location = New System.Drawing.Point(51, 92)
        Me.TB_output_name.Name = "TB_output_name"
        Me.TB_output_name.Size = New System.Drawing.Size(387, 20)
        Me.TB_output_name.TabIndex = 9
        '
        'LB_output_name
        '
        Me.LB_output_name.AutoSize = True
        Me.LB_output_name.Location = New System.Drawing.Point(7, 95)
        Me.LB_output_name.Name = "LB_output_name"
        Me.LB_output_name.Size = New System.Drawing.Size(38, 13)
        Me.LB_output_name.TabIndex = 8
        Me.LB_output_name.Text = "Name:"
        '
        'CB_output_format
        '
        Me.CB_output_format.DisplayMember = "1"
        Me.CB_output_format.FormattingEnabled = True
        Me.CB_output_format.Items.AddRange(New Object() {"*original", ".mkv", ".webm", ".flv", ".avi", ".mov", ".mp4", ".mpg", ".mpeg", ".m4v"})
        Me.CB_output_format.Location = New System.Drawing.Point(54, 45)
        Me.CB_output_format.Name = "CB_output_format"
        Me.CB_output_format.Size = New System.Drawing.Size(103, 21)
        Me.CB_output_format.TabIndex = 7
        Me.CB_output_format.ValueMember = "0"
        '
        'LB_output_format
        '
        Me.LB_output_format.AutoSize = True
        Me.LB_output_format.Location = New System.Drawing.Point(6, 48)
        Me.LB_output_format.Name = "LB_output_format"
        Me.LB_output_format.Size = New System.Drawing.Size(42, 13)
        Me.LB_output_format.TabIndex = 6
        Me.LB_output_format.Text = "Format:"
        '
        'BTN_output_folder
        '
        Me.BTN_output_folder.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_output_folder.Location = New System.Drawing.Point(388, 19)
        Me.BTN_output_folder.Name = "BTN_output_folder"
        Me.BTN_output_folder.Size = New System.Drawing.Size(50, 20)
        Me.BTN_output_folder.TabIndex = 5
        Me.BTN_output_folder.Text = "Browse"
        Me.BTN_output_folder.UseVisualStyleBackColor = True
        '
        'TB_output_folder
        '
        Me.TB_output_folder.Location = New System.Drawing.Point(52, 19)
        Me.TB_output_folder.Name = "TB_output_folder"
        Me.TB_output_folder.Size = New System.Drawing.Size(330, 20)
        Me.TB_output_folder.TabIndex = 1
        '
        'LB_output_folder
        '
        Me.LB_output_folder.AutoSize = True
        Me.LB_output_folder.Location = New System.Drawing.Point(7, 22)
        Me.LB_output_folder.Name = "LB_output_folder"
        Me.LB_output_folder.Size = New System.Drawing.Size(39, 13)
        Me.LB_output_folder.TabIndex = 0
        Me.LB_output_folder.Text = "Folder:"
        '
        'LB_output_replace
        '
        Me.LB_output_replace.AutoSize = True
        Me.LB_output_replace.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.5!)
        Me.LB_output_replace.Location = New System.Drawing.Point(52, 112)
        Me.LB_output_replace.Name = "LB_output_replace"
        Me.LB_output_replace.Size = New System.Drawing.Size(238, 65)
        Me.LB_output_replace.TabIndex = 10
        Me.LB_output_replace.Text = resources.GetString("LB_output_replace.Text")
        '
        'GB_queue
        '
        Me.GB_queue.Controls.Add(Me.BTN_queue_dragdrop)
        Me.GB_queue.Controls.Add(Me.BTN_queue_folder)
        Me.GB_queue.Controls.Add(Me.BTN_queue_file)
        Me.GB_queue.Controls.Add(Me.BTN_clear)
        Me.GB_queue.Controls.Add(Me.FLY_queue)
        Me.GB_queue.Location = New System.Drawing.Point(456, 6)
        Me.GB_queue.Name = "GB_queue"
        Me.GB_queue.Size = New System.Drawing.Size(293, 627)
        Me.GB_queue.TabIndex = 1
        Me.GB_queue.TabStop = False
        Me.GB_queue.Text = "Loaded Videos: *"
        '
        'BTN_queue_dragdrop
        '
        Me.BTN_queue_dragdrop.AllowDrop = True
        Me.BTN_queue_dragdrop.Location = New System.Drawing.Point(6, 572)
        Me.BTN_queue_dragdrop.Name = "BTN_queue_dragdrop"
        Me.BTN_queue_dragdrop.Size = New System.Drawing.Size(281, 20)
        Me.BTN_queue_dragdrop.TabIndex = 5
        Me.BTN_queue_dragdrop.Text = "Drag and Drop File/s"
        Me.BTN_queue_dragdrop.UseVisualStyleBackColor = True
        '
        'BTN_queue_folder
        '
        Me.BTN_queue_folder.Location = New System.Drawing.Point(85, 598)
        Me.BTN_queue_folder.Name = "BTN_queue_folder"
        Me.BTN_queue_folder.Size = New System.Drawing.Size(73, 20)
        Me.BTN_queue_folder.TabIndex = 4
        Me.BTN_queue_folder.Text = "Add Folder"
        Me.BTN_queue_folder.UseVisualStyleBackColor = True
        '
        'BTN_queue_file
        '
        Me.BTN_queue_file.Location = New System.Drawing.Point(6, 598)
        Me.BTN_queue_file.Name = "BTN_queue_file"
        Me.BTN_queue_file.Size = New System.Drawing.Size(73, 20)
        Me.BTN_queue_file.TabIndex = 3
        Me.BTN_queue_file.Text = "Add File"
        Me.BTN_queue_file.UseVisualStyleBackColor = True
        '
        'BTN_clear
        '
        Me.BTN_clear.Location = New System.Drawing.Point(164, 598)
        Me.BTN_clear.Name = "BTN_clear"
        Me.BTN_clear.Size = New System.Drawing.Size(123, 20)
        Me.BTN_clear.TabIndex = 2
        Me.BTN_clear.Text = "Clear Queue"
        Me.BTN_clear.UseVisualStyleBackColor = True
        '
        'FLY_queue
        '
        Me.FLY_queue.AutoScroll = True
        Me.FLY_queue.Location = New System.Drawing.Point(6, 19)
        Me.FLY_queue.Name = "FLY_queue"
        Me.FLY_queue.Size = New System.Drawing.Size(281, 547)
        Me.FLY_queue.TabIndex = 2
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(10, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 25)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BW_process
        '
        Me.BW_process.WorkerReportsProgress = True
        Me.BW_process.WorkerSupportsCancellation = True
        '
        'BW_infos
        '
        Me.BW_infos.WorkerReportsProgress = True
        Me.BW_infos.WorkerSupportsCancellation = True
        '
        'VideoTrim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 692)
        Me.Controls.Add(Me.MS)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MS
        Me.MaximizeBox = False
        Me.Name = "VideoTrim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VideoTrim"
        Me.MS.ResumeLayout(False)
        Me.MS.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GB_info.ResumeLayout(False)
        Me.GB_info.PerformLayout()
        Me.GB_state.ResumeLayout(False)
        Me.GB_state.PerformLayout()
        Me.PNL_CB_fluent.ResumeLayout(False)
        Me.PNL_CB_bg.ResumeLayout(False)
        Me.GB_Output.ResumeLayout(False)
        Me.GB_Output.PerformLayout()
        Me.GB_queue.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MS As MenuStrip
    Friend WithEvents TSM_load As ToolStripMenuItem
    Friend WithEvents TSM_load_file As ToolStripMenuItem
    Friend WithEvents TSM_load_folder As ToolStripMenuItem
    Friend WithEvents TSM_ffmpeg As ToolStripMenuItem
    Friend WithEvents TSM_ffmpeg_github As ToolStripMenuItem
    Friend WithEvents TSM_ffmpeg_set As ToolStripMenuItem
    Friend WithEvents TSM_about As ToolStripMenuItem
    Friend WithEvents TSM_load_clear As ToolStripMenuItem
    Friend WithEvents OFD_load_file As OpenFileDialog
    Friend WithEvents FBD_ffmpeg As FolderBrowserDialog
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents LB_start_loadfoldertext As Label
    Friend WithEvents LB_start_loadfiletext As Label
    Friend WithEvents BTN_load_folder As Button
    Friend WithEvents BTN_load_file As Button
    Friend WithEvents LB_start_desc As Label
    Friend WithEvents LB_start_title As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents FBD_load_folder As FolderBrowserDialog
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents GB_queue As GroupBox
    Friend WithEvents FLY_queue As FlowLayoutPanel
    Friend WithEvents BTN_clear As Button
    Friend WithEvents BTN_queue_folder As Button
    Friend WithEvents BTN_queue_file As Button
    Friend WithEvents GB_Output As GroupBox
    Friend WithEvents BTN_output_folder As Button
    Friend WithEvents TB_output_folder As TextBox
    Friend WithEvents LB_output_folder As Label
    Friend WithEvents FBD_output_folder As FolderBrowserDialog
    Friend WithEvents CB_output_format As ComboBox
    Friend WithEvents LB_output_format As Label
    Friend WithEvents TB_output_name As TextBox
    Friend WithEvents LB_output_name As Label
    Friend WithEvents LB_output_replace As Label
    Friend WithEvents LB_output_extfolder As Label
    Friend WithEvents CB_output_exfolder As CheckBox
    Friend WithEvents GB_state As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LB_state_current As Label
    Friend WithEvents LB_state_totalprogress As Label
    Friend WithEvents PB_state_totalprogress As ProgressBar
    Friend WithEvents LB_state_currentprogress As Label
    Friend WithEvents PB_state_currentprogress As ProgressBar
    Friend WithEvents BTN_current_cacel As Button
    Friend WithEvents BTN_current_start As Button
    Friend WithEvents TB_state_current As TextBox
    Friend WithEvents LB_state_trimin As Label
    Friend WithEvents TB_state_current_num As TextBox
    Friend WithEvents LB_state_console As Label
    Friend WithEvents RTB_state_console As RichTextBox
    Friend WithEvents TB_state_currentpart As TextBox
    Friend WithEvents BW_process As System.ComponentModel.BackgroundWorker
    Friend WithEvents GB_info As GroupBox
    Friend WithEvents LB_info_bitrate As Label
    Friend WithEvents LB_info_audiosamplerate As Label
    Friend WithEvents LB_info_audiobitrate As Label
    Friend WithEvents LB_info_audiocodec As Label
    Friend WithEvents LB_info_audiostreams As Label
    Friend WithEvents LB_info_videostreams As Label
    Friend WithEvents LB_info_totalframes As Label
    Friend WithEvents LB_info_framerate As Label
    Friend WithEvents LB_info_resolution As Label
    Friend WithEvents LB_info_codec As Label
    Friend WithEvents LB_info_format As Label
    Friend WithEvents LB_info_duration As Label
    Friend WithEvents LB_info_filesize As Label
    Friend WithEvents LB_info_name As Label
    Friend WithEvents BW_infos As System.ComponentModel.BackgroundWorker
    Friend WithEvents TB_info_audiosamplerate As TextBox
    Friend WithEvents TB_info_audiobitrate As TextBox
    Friend WithEvents TB_info_audiocodec As TextBox
    Friend WithEvents TB_info_audiostreams As TextBox
    Friend WithEvents TB_info_videostreams As TextBox
    Friend WithEvents TB_info_totalframes As TextBox
    Friend WithEvents TB_info_framerate As TextBox
    Friend WithEvents TB_info_resolution As TextBox
    Friend WithEvents TB_info_bitrate As TextBox
    Friend WithEvents TB_info_codec As TextBox
    Friend WithEvents TB_info_format As TextBox
    Friend WithEvents TB_info_duration As TextBox
    Friend WithEvents TB_info_filesize As TextBox
    Friend WithEvents TB_info_name As TextBox
    Friend WithEvents CB_fastmode As CheckBox
    Friend WithEvents PNL_CB_bg As Panel
    Friend WithEvents LB_CB_fastmode As Label
    Friend WithEvents LB_CB_fastmode_info As Label
    Friend WithEvents PNL_CB_fluent As Panel
    Friend WithEvents CB_fluent As CheckBox
    Friend WithEvents LB_fluent As Label
    Friend WithEvents LB_CB_fluent_info As Label
    Friend WithEvents BTN_load_dragdrop As Button
    Friend WithEvents BTN_queue_dragdrop As Button
End Class
