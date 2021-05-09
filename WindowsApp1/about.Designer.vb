<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class about
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(about))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_path_ffmpeg = New System.Windows.Forms.TextBox()
        Me.LB_path_ffmpeg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Underline)
        Me.Label1.Location = New System.Drawing.Point(0, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VideoTrim"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 15.25!)
        Me.Label2.Location = New System.Drawing.Point(0, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "VB.net"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.RichTextBox1.Location = New System.Drawing.Point(11, 87)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(289, 182)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(110, 323)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(86, 28)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_path_ffmpeg
        '
        Me.TB_path_ffmpeg.BackColor = System.Drawing.SystemColors.Control
        Me.TB_path_ffmpeg.Location = New System.Drawing.Point(61, 279)
        Me.TB_path_ffmpeg.Name = "TB_path_ffmpeg"
        Me.TB_path_ffmpeg.ReadOnly = True
        Me.TB_path_ffmpeg.Size = New System.Drawing.Size(239, 20)
        Me.TB_path_ffmpeg.TabIndex = 4
        '
        'LB_path_ffmpeg
        '
        Me.LB_path_ffmpeg.AutoSize = True
        Me.LB_path_ffmpeg.Location = New System.Drawing.Point(9, 283)
        Me.LB_path_ffmpeg.Name = "LB_path_ffmpeg"
        Me.LB_path_ffmpeg.Size = New System.Drawing.Size(53, 13)
        Me.LB_path_ffmpeg.TabIndex = 5
        Me.LB_path_ffmpeg.Text = "FFMPEG:"
        '
        'about
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 367)
        Me.Controls.Add(Me.TB_path_ffmpeg)
        Me.Controls.Add(Me.LB_path_ffmpeg)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "about"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VideoTrim - About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TB_path_ffmpeg As TextBox
    Friend WithEvents LB_path_ffmpeg As Label
End Class
