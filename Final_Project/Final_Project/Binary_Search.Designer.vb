<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONTROLLER_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONTROLLER_2))
        Me.START_2 = New System.Windows.Forms.Button()
        Me.INPUT = New System.Windows.Forms.TextBox()
        Me.OUTPUT = New System.Windows.Forms.TextBox()
        Me.SEARCH = New System.Windows.Forms.TextBox()
        Me.ARRAY = New System.Windows.Forms.TextBox()
        Me.START = New System.Windows.Forms.TextBox()
        Me.MIDDLE = New System.Windows.Forms.TextBox()
        Me.ENDING = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ARRAY_2 = New System.Windows.Forms.RichTextBox()
        Me.RESET_2 = New System.Windows.Forms.Button()
        Me.PANEL_RESULT = New System.Windows.Forms.Panel()
        Me.autocheck = New System.Windows.Forms.CheckBox()
        Me.button_file = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.PANEL_RESULT.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'START_2
        '
        Me.START_2.BackColor = System.Drawing.Color.Black
        Me.START_2.Font = New System.Drawing.Font("Segoe Print", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.START_2.ForeColor = System.Drawing.Color.Coral
        Me.START_2.Location = New System.Drawing.Point(670, 46)
        Me.START_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.START_2.Name = "START_2"
        Me.START_2.Size = New System.Drawing.Size(145, 59)
        Me.START_2.TabIndex = 0
        Me.START_2.Text = "&START"
        Me.START_2.UseVisualStyleBackColor = False
        '
        'INPUT
        '
        Me.INPUT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.INPUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.INPUT.Location = New System.Drawing.Point(34, 72)
        Me.INPUT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.INPUT.Name = "INPUT"
        Me.INPUT.Size = New System.Drawing.Size(317, 35)
        Me.INPUT.TabIndex = 1
        Me.INPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'OUTPUT
        '
        Me.OUTPUT.BackColor = System.Drawing.Color.Snow
        Me.OUTPUT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OUTPUT.Enabled = False
        Me.OUTPUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OUTPUT.ForeColor = System.Drawing.Color.Black
        Me.OUTPUT.Location = New System.Drawing.Point(4, 5)
        Me.OUTPUT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.OUTPUT.Name = "OUTPUT"
        Me.OUTPUT.Size = New System.Drawing.Size(325, 35)
        Me.OUTPUT.TabIndex = 2
        Me.OUTPUT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SEARCH
        '
        Me.SEARCH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SEARCH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SEARCH.Location = New System.Drawing.Point(383, 72)
        Me.SEARCH.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SEARCH.Name = "SEARCH"
        Me.SEARCH.Size = New System.Drawing.Size(151, 35)
        Me.SEARCH.TabIndex = 3
        Me.SEARCH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ARRAY
        '
        Me.ARRAY.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ARRAY.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARRAY.Location = New System.Drawing.Point(2, 173)
        Me.ARRAY.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ARRAY.Multiline = True
        Me.ARRAY.Name = "ARRAY"
        Me.ARRAY.Size = New System.Drawing.Size(1297, 149)
        Me.ARRAY.TabIndex = 4
        Me.ARRAY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'START
        '
        Me.START.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.START.Enabled = False
        Me.START.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.START.ForeColor = System.Drawing.Color.White
        Me.START.Location = New System.Drawing.Point(256, 598)
        Me.START.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.START.Name = "START"
        Me.START.Size = New System.Drawing.Size(112, 35)
        Me.START.TabIndex = 5
        Me.START.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'MIDDLE
        '
        Me.MIDDLE.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MIDDLE.Enabled = False
        Me.MIDDLE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MIDDLE.ForeColor = System.Drawing.Color.White
        Me.MIDDLE.Location = New System.Drawing.Point(473, 598)
        Me.MIDDLE.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MIDDLE.Name = "MIDDLE"
        Me.MIDDLE.Size = New System.Drawing.Size(112, 35)
        Me.MIDDLE.TabIndex = 6
        Me.MIDDLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ENDING
        '
        Me.ENDING.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ENDING.Enabled = False
        Me.ENDING.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ENDING.ForeColor = System.Drawing.Color.White
        Me.ENDING.Location = New System.Drawing.Point(665, 598)
        Me.ENDING.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ENDING.Name = "ENDING"
        Me.ENDING.Size = New System.Drawing.Size(112, 35)
        Me.ENDING.TabIndex = 7
        Me.ENDING.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(37, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(315, 38)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "No. of Input Entries"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(394, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 38)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Search"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(329, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(451, 41)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Enter the sorted list of elements"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Impact", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(394, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(359, 41)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Array after each iteration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(278, 563)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 29)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Start"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(492, 563)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Middle"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(696, 564)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "End"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Impact", 19.8!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Purple
        Me.Label8.Location = New System.Drawing.Point(460, 641)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(125, 48)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Result"
        '
        'ARRAY_2
        '
        Me.ARRAY_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ARRAY_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ARRAY_2.Enabled = False
        Me.ARRAY_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ARRAY_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ARRAY_2.Location = New System.Drawing.Point(2, 371)
        Me.ARRAY_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ARRAY_2.Name = "ARRAY_2"
        Me.ARRAY_2.Size = New System.Drawing.Size(1297, 173)
        Me.ARRAY_2.TabIndex = 17
        Me.ARRAY_2.Text = ""
        '
        'RESET_2
        '
        Me.RESET_2.BackColor = System.Drawing.Color.Black
        Me.RESET_2.Font = New System.Drawing.Font("Segoe Print", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RESET_2.ForeColor = System.Drawing.Color.Coral
        Me.RESET_2.Location = New System.Drawing.Point(844, 47)
        Me.RESET_2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RESET_2.Name = "RESET_2"
        Me.RESET_2.Size = New System.Drawing.Size(132, 60)
        Me.RESET_2.TabIndex = 18
        Me.RESET_2.Text = "&RESET"
        Me.RESET_2.UseVisualStyleBackColor = False
        '
        'PANEL_RESULT
        '
        Me.PANEL_RESULT.BackColor = System.Drawing.SystemColors.Highlight
        Me.PANEL_RESULT.Controls.Add(Me.OUTPUT)
        Me.PANEL_RESULT.Location = New System.Drawing.Point(354, 696)
        Me.PANEL_RESULT.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PANEL_RESULT.Name = "PANEL_RESULT"
        Me.PANEL_RESULT.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PANEL_RESULT.Size = New System.Drawing.Size(333, 48)
        Me.PANEL_RESULT.TabIndex = 19
        '
        'autocheck
        '
        Me.autocheck.BackColor = System.Drawing.Color.Yellow
        Me.autocheck.ForeColor = System.Drawing.Color.Red
        Me.autocheck.Location = New System.Drawing.Point(33, 118)
        Me.autocheck.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.autocheck.Name = "autocheck"
        Me.autocheck.Size = New System.Drawing.Size(107, 26)
        Me.autocheck.TabIndex = 20
        Me.autocheck.Text = "AUTO"
        Me.autocheck.UseVisualStyleBackColor = False
        '
        'button_file
        '
        Me.button_file.BackColor = System.Drawing.Color.Black
        Me.button_file.Font = New System.Drawing.Font("Segoe Print", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_file.ForeColor = System.Drawing.Color.Coral
        Me.button_file.Location = New System.Drawing.Point(995, 47)
        Me.button_file.Margin = New System.Windows.Forms.Padding(3, 2, 3, 4)
        Me.button_file.Name = "button_file"
        Me.button_file.Size = New System.Drawing.Size(310, 60)
        Me.button_file.TabIndex = 21
        Me.button_file.Text = "&Take input from file"
        Me.button_file.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightGray
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Segoe Script", 6.6!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 784)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1272, 200)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Aqua
        Me.PictureBox1.Location = New System.Drawing.Point(1047, 585)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 28)
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DarkOrange
        Me.PictureBox2.Location = New System.Drawing.Point(1047, 631)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 31)
        Me.PictureBox2.TabIndex = 24
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Silver
        Me.PictureBox3.Location = New System.Drawing.Point(1047, 686)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(25, 29)
        Me.PictureBox3.TabIndex = 25
        Me.PictureBox3.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(1078, 590)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 22)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "START , END"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1078, 641)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 22)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "MIDDLE"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(1077, 691)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(219, 22)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "DISCARDED PORTION"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(1068, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(150, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Only txt files allowed"
        '
        'CONTROLLER_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Azure
        Me.ClientSize = New System.Drawing.Size(1313, 1012)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.button_file)
        Me.Controls.Add(Me.autocheck)
        Me.Controls.Add(Me.PANEL_RESULT)
        Me.Controls.Add(Me.RESET_2)
        Me.Controls.Add(Me.ARRAY_2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ENDING)
        Me.Controls.Add(Me.MIDDLE)
        Me.Controls.Add(Me.START)
        Me.Controls.Add(Me.ARRAY)
        Me.Controls.Add(Me.SEARCH)
        Me.Controls.Add(Me.INPUT)
        Me.Controls.Add(Me.START_2)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1335, 1032)
        Me.Name = "CONTROLLER_2"
        Me.Text = "CONTROLLER"
        Me.PANEL_RESULT.ResumeLayout(False)
        Me.PANEL_RESULT.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents START_2 As System.Windows.Forms.Button
    Friend WithEvents INPUT As System.Windows.Forms.TextBox
    Friend WithEvents OUTPUT As System.Windows.Forms.TextBox
    Friend WithEvents SEARCH As System.Windows.Forms.TextBox
    Friend WithEvents ARRAY As System.Windows.Forms.TextBox
    Friend WithEvents START As System.Windows.Forms.TextBox
    Friend WithEvents MIDDLE As System.Windows.Forms.TextBox
    Friend WithEvents ENDING As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ARRAY_2 As System.Windows.Forms.RichTextBox
    Friend WithEvents RESET_2 As System.Windows.Forms.Button
    Friend WithEvents PANEL_RESULT As System.Windows.Forms.Panel
    Friend WithEvents autocheck As System.Windows.Forms.CheckBox
    Friend WithEvents button_file As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As Label
End Class
