<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.InfoTerminal = New System.Windows.Forms.Button()
        Me.InfoInitial = New System.Windows.Forms.Button()
        Me.LastTimeFrame_Txt = New System.Windows.Forms.Label()
        Me.ToBtn = New System.Windows.Forms.Button()
        Me.OpenFileDialog_From = New System.Windows.Forms.OpenFileDialog()
        Me.Prev_Btn = New System.Windows.Forms.Button()
        Me.halfTimeFrame_Txt = New System.Windows.Forms.Label()
        Me.MorphTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FromBtn = New System.Windows.Forms.Button()
        Me.Next_Btn = New System.Windows.Forms.Button()
        Me.Timeline_Bar = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Autoplay_Btn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel_Morph = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel_To = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel_From = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Edge_RBtn = New System.Windows.Forms.RadioButton()
        Me.Vertex_RBtn = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Group_Match = New System.Windows.Forms.GroupBox()
        Me.OnetoOne_RBtn = New System.Windows.Forms.RadioButton()
        Me.NtoOne_RBtn = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txt_TimeFrame = New System.Windows.Forms.TextBox()
        CType(Me.Timeline_Bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel_Morph.SuspendLayout()
        Me.Panel_To.SuspendLayout()
        Me.Panel_From.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Group_Match.SuspendLayout()
        Me.SuspendLayout()
        '
        'InfoTerminal
        '
        Me.InfoTerminal.Location = New System.Drawing.Point(316, 959)
        Me.InfoTerminal.Margin = New System.Windows.Forms.Padding(6)
        Me.InfoTerminal.Name = "InfoTerminal"
        Me.InfoTerminal.Size = New System.Drawing.Size(150, 44)
        Me.InfoTerminal.TabIndex = 56
        Me.InfoTerminal.Text = "Info"
        Me.InfoTerminal.UseVisualStyleBackColor = True
        '
        'InfoInitial
        '
        Me.InfoInitial.Location = New System.Drawing.Point(316, 467)
        Me.InfoInitial.Margin = New System.Windows.Forms.Padding(6)
        Me.InfoInitial.Name = "InfoInitial"
        Me.InfoInitial.Size = New System.Drawing.Size(150, 44)
        Me.InfoInitial.TabIndex = 55
        Me.InfoInitial.Text = "Info"
        Me.InfoInitial.UseVisualStyleBackColor = True
        '
        'LastTimeFrame_Txt
        '
        Me.LastTimeFrame_Txt.AutoSize = True
        Me.LastTimeFrame_Txt.Location = New System.Drawing.Point(1784, 971)
        Me.LastTimeFrame_Txt.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LastTimeFrame_Txt.Name = "LastTimeFrame_Txt"
        Me.LastTimeFrame_Txt.Size = New System.Drawing.Size(48, 25)
        Me.LastTimeFrame_Txt.TabIndex = 51
        Me.LastTimeFrame_Txt.Text = "100"
        '
        'ToBtn
        '
        Me.ToBtn.Location = New System.Drawing.Point(64, 959)
        Me.ToBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.ToBtn.Name = "ToBtn"
        Me.ToBtn.Size = New System.Drawing.Size(150, 44)
        Me.ToBtn.TabIndex = 34
        Me.ToBtn.Text = "Open New"
        Me.ToBtn.UseVisualStyleBackColor = True
        '
        'OpenFileDialog_From
        '
        Me.OpenFileDialog_From.FileName = "OpenFromFile"
        '
        'Prev_Btn
        '
        Me.Prev_Btn.Location = New System.Drawing.Point(888, 1017)
        Me.Prev_Btn.Margin = New System.Windows.Forms.Padding(6)
        Me.Prev_Btn.Name = "Prev_Btn"
        Me.Prev_Btn.Size = New System.Drawing.Size(144, 54)
        Me.Prev_Btn.TabIndex = 53
        Me.Prev_Btn.Text = "Pre"
        Me.Prev_Btn.UseVisualStyleBackColor = True
        '
        'halfTimeFrame_Txt
        '
        Me.halfTimeFrame_Txt.AutoSize = True
        Me.halfTimeFrame_Txt.Location = New System.Drawing.Point(1158, 971)
        Me.halfTimeFrame_Txt.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.halfTimeFrame_Txt.Name = "halfTimeFrame_Txt"
        Me.halfTimeFrame_Txt.Size = New System.Drawing.Size(36, 25)
        Me.halfTimeFrame_Txt.TabIndex = 52
        Me.halfTimeFrame_Txt.Text = "50"
        '
        'MorphTimer
        '
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(576, 971)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 25)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "0"
        '
        'FromBtn
        '
        Me.FromBtn.Location = New System.Drawing.Point(64, 467)
        Me.FromBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.FromBtn.Name = "FromBtn"
        Me.FromBtn.Size = New System.Drawing.Size(150, 44)
        Me.FromBtn.TabIndex = 33
        Me.FromBtn.Text = "Open New"
        Me.FromBtn.UseVisualStyleBackColor = True
        '
        'Next_Btn
        '
        Me.Next_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Next_Btn.Location = New System.Drawing.Point(1102, 1017)
        Me.Next_Btn.Margin = New System.Windows.Forms.Padding(6)
        Me.Next_Btn.Name = "Next_Btn"
        Me.Next_Btn.Size = New System.Drawing.Size(144, 54)
        Me.Next_Btn.TabIndex = 49
        Me.Next_Btn.Text = "Next"
        Me.Next_Btn.UseVisualStyleBackColor = True
        '
        'Timeline_Bar
        '
        Me.Timeline_Bar.Location = New System.Drawing.Point(562, 927)
        Me.Timeline_Bar.Margin = New System.Windows.Forms.Padding(6)
        Me.Timeline_Bar.Maximum = 100
        Me.Timeline_Bar.Name = "Timeline_Bar"
        Me.Timeline_Bar.Size = New System.Drawing.Size(1264, 90)
        Me.Timeline_Bar.TabIndex = 47
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label1.Location = New System.Drawing.Point(1948, 136)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(274, 37)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Algorithm Option"
        '
        'Autoplay_Btn
        '
        Me.Autoplay_Btn.Location = New System.Drawing.Point(1320, 1017)
        Me.Autoplay_Btn.Margin = New System.Windows.Forms.Padding(6)
        Me.Autoplay_Btn.Name = "Autoplay_Btn"
        Me.Autoplay_Btn.Size = New System.Drawing.Size(154, 54)
        Me.Autoplay_Btn.TabIndex = 37
        Me.Autoplay_Btn.Text = "AutoPlay"
        Me.Autoplay_Btn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 46)
        Me.Label9.TabIndex = 2
        '
        'Panel_Morph
        '
        Me.Panel_Morph.BackColor = System.Drawing.SystemColors.Window
        Me.Panel_Morph.Controls.Add(Me.Label9)
        Me.Panel_Morph.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel_Morph.Location = New System.Drawing.Point(0, 73)
        Me.Panel_Morph.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel_Morph.Name = "Panel_Morph"
        Me.Panel_Morph.Size = New System.Drawing.Size(1264, 787)
        Me.Panel_Morph.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 12)
        Me.Label8.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 29)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Terminal Shape"
        '
        'Panel_To
        '
        Me.Panel_To.BackColor = System.Drawing.SystemColors.Window
        Me.Panel_To.Controls.Add(Me.Label8)
        Me.Panel_To.Location = New System.Drawing.Point(64, 569)
        Me.Panel_To.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel_To.Name = "Panel_To"
        Me.Panel_To.Size = New System.Drawing.Size(402, 363)
        Me.Panel_To.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(6, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 30)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Initial Shape"
        '
        'Panel_From
        '
        Me.Panel_From.BackColor = System.Drawing.SystemColors.Window
        Me.Panel_From.Controls.Add(Me.Label7)
        Me.Panel_From.Location = New System.Drawing.Point(64, 81)
        Me.Panel_From.Margin = New System.Windows.Forms.Padding(6)
        Me.Panel_From.Name = "Panel_From"
        Me.Panel_From.Size = New System.Drawing.Size(402, 363)
        Me.Panel_From.TabIndex = 35
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel_Morph)
        Me.GroupBox2.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox2.Location = New System.Drawing.Point(562, 61)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox2.Size = New System.Drawing.Size(1264, 854)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Morph Window"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1027, 491)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 37)
        Me.Label5.TabIndex = 59
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GroupBox3.Controls.Add(Me.Edge_RBtn)
        Me.GroupBox3.Controls.Add(Me.Vertex_RBtn)
        Me.GroupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GroupBox3.Location = New System.Drawing.Point(1933, 313)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox3.Size = New System.Drawing.Size(528, 119)
        Me.GroupBox3.TabIndex = 63
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Morphing"
        '
        'Edge_RBtn
        '
        Me.Edge_RBtn.AutoSize = True
        Me.Edge_RBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Edge_RBtn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Edge_RBtn.Location = New System.Drawing.Point(244, 56)
        Me.Edge_RBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.Edge_RBtn.Name = "Edge_RBtn"
        Me.Edge_RBtn.Size = New System.Drawing.Size(108, 35)
        Me.Edge_RBtn.TabIndex = 18
        Me.Edge_RBtn.TabStop = True
        Me.Edge_RBtn.Text = "Edge"
        Me.Edge_RBtn.UseVisualStyleBackColor = True
        '
        'Vertex_RBtn
        '
        Me.Vertex_RBtn.AutoSize = True
        Me.Vertex_RBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Vertex_RBtn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.Vertex_RBtn.Location = New System.Drawing.Point(24, 56)
        Me.Vertex_RBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.Vertex_RBtn.Name = "Vertex_RBtn"
        Me.Vertex_RBtn.Size = New System.Drawing.Size(123, 35)
        Me.Vertex_RBtn.TabIndex = 17
        Me.Vertex_RBtn.TabStop = True
        Me.Vertex_RBtn.Text = "Vertex"
        Me.Vertex_RBtn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightSlateGray
        Me.Label2.Location = New System.Drawing.Point(18, 430)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 37)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Display Option"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1951, 450)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 37)
        Me.Label3.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Group_Match)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Txt_TimeFrame)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Silver
        Me.GroupBox1.Location = New System.Drawing.Point(1933, 61)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(6)
        Me.GroupBox1.Size = New System.Drawing.Size(528, 890)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Candara", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(35, 618)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(295, 54)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "Export to GIF"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Group_Match
        '
        Me.Group_Match.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Group_Match.Controls.Add(Me.OnetoOne_RBtn)
        Me.Group_Match.Controls.Add(Me.NtoOne_RBtn)
        Me.Group_Match.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Group_Match.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Match.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Group_Match.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Group_Match.Location = New System.Drawing.Point(0, 121)
        Me.Group_Match.Margin = New System.Windows.Forms.Padding(6)
        Me.Group_Match.Name = "Group_Match"
        Me.Group_Match.Padding = New System.Windows.Forms.Padding(6)
        Me.Group_Match.Size = New System.Drawing.Size(528, 119)
        Me.Group_Match.TabIndex = 28
        Me.Group_Match.TabStop = False
        Me.Group_Match.Text = "Matching"
        '
        'OnetoOne_RBtn
        '
        Me.OnetoOne_RBtn.AutoSize = True
        Me.OnetoOne_RBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OnetoOne_RBtn.ForeColor = System.Drawing.Color.Black
        Me.OnetoOne_RBtn.Location = New System.Drawing.Point(22, 62)
        Me.OnetoOne_RBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.OnetoOne_RBtn.Name = "OnetoOne_RBtn"
        Me.OnetoOne_RBtn.Size = New System.Drawing.Size(121, 35)
        Me.OnetoOne_RBtn.TabIndex = 18
        Me.OnetoOne_RBtn.TabStop = True
        Me.OnetoOne_RBtn.Text = "1 To 1"
        Me.OnetoOne_RBtn.UseVisualStyleBackColor = True
        '
        'NtoOne_RBtn
        '
        Me.NtoOne_RBtn.AutoSize = True
        Me.NtoOne_RBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NtoOne_RBtn.ForeColor = System.Drawing.Color.Black
        Me.NtoOne_RBtn.Location = New System.Drawing.Point(244, 62)
        Me.NtoOne_RBtn.Margin = New System.Windows.Forms.Padding(6)
        Me.NtoOne_RBtn.Name = "NtoOne_RBtn"
        Me.NtoOne_RBtn.Size = New System.Drawing.Size(126, 35)
        Me.NtoOne_RBtn.TabIndex = 17
        Me.NtoOne_RBtn.TabStop = True
        Me.NtoOne_RBtn.Text = "N To 1"
        Me.NtoOne_RBtn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 508)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(202, 37)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Total Frame"
        '
        'Txt_TimeFrame
        '
        Me.Txt_TimeFrame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TimeFrame.Location = New System.Drawing.Point(254, 501)
        Me.Txt_TimeFrame.Margin = New System.Windows.Forms.Padding(6)
        Me.Txt_TimeFrame.Name = "Txt_TimeFrame"
        Me.Txt_TimeFrame.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Txt_TimeFrame.Size = New System.Drawing.Size(76, 44)
        Me.Txt_TimeFrame.TabIndex = 12
        Me.Txt_TimeFrame.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2546, 1095)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.InfoTerminal)
        Me.Controls.Add(Me.InfoInitial)
        Me.Controls.Add(Me.LastTimeFrame_Txt)
        Me.Controls.Add(Me.ToBtn)
        Me.Controls.Add(Me.Prev_Btn)
        Me.Controls.Add(Me.halfTimeFrame_Txt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.FromBtn)
        Me.Controls.Add(Me.Next_Btn)
        Me.Controls.Add(Me.Timeline_Bar)
        Me.Controls.Add(Me.Autoplay_Btn)
        Me.Controls.Add(Me.Panel_To)
        Me.Controls.Add(Me.Panel_From)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "2D Morph App"
        CType(Me.Timeline_Bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel_Morph.ResumeLayout(False)
        Me.Panel_Morph.PerformLayout()
        Me.Panel_To.ResumeLayout(False)
        Me.Panel_To.PerformLayout()
        Me.Panel_From.ResumeLayout(False)
        Me.Panel_From.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Group_Match.ResumeLayout(False)
        Me.Group_Match.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InfoTerminal As Button
    Friend WithEvents InfoInitial As Button
    Friend WithEvents LastTimeFrame_Txt As Label
    Friend WithEvents ToBtn As Button
    Friend WithEvents OpenFileDialog_From As OpenFileDialog
    Friend WithEvents Prev_Btn As Button
    Friend WithEvents halfTimeFrame_Txt As Label
    Friend WithEvents MorphTimer As Timer
    Friend WithEvents Label10 As Label
    Friend WithEvents FromBtn As Button
    Friend WithEvents Next_Btn As Button
    Friend WithEvents Timeline_Bar As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Autoplay_Btn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Panel_Morph As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel_To As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel_From As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Edge_RBtn As RadioButton
    Friend WithEvents Vertex_RBtn As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Group_Match As GroupBox
    Friend WithEvents OnetoOne_RBtn As RadioButton
    Friend WithEvents NtoOne_RBtn As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_TimeFrame As TextBox
    Friend WithEvents Button1 As Button
End Class
