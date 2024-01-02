<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WestTee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(WestTee))
        btnNext = New Button()
        btnPrevious = New Button()
        Label8 = New Label()
        PictureBox8 = New PictureBox()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label18 = New Label()
        Label17 = New Label()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ToolStrip1 = New ToolStrip()
        NewToolStripButton = New ToolStripButton()
        OpenToolStripButton = New ToolStripButton()
        SaveToolStripButton = New ToolStripButton()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripLabel1 = New ToolStripLabel()
        TitleToolStripButton = New ToolStripButton()
        DistrictToolStripButton = New ToolStripButton()
        IntersectionTypeToolStripButton = New ToolStripButton()
        ToolStripButton7 = New ToolStripButton()
        RunToolStripButton = New ToolStripButton()
        ToolStripLabel2 = New ToolStripLabel()
        AboutToolStripButton = New ToolStripButton()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Label9 = New Label()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.AppWorkspace
        btnNext.Font = New Font("Roboto Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.ForeColor = SystemColors.ControlText
        btnNext.Location = New Point(1207, 744)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(105, 36)
        btnNext.TabIndex = 111
        btnNext.Text = "Run"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.AppWorkspace
        btnPrevious.Font = New Font("Roboto Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.ForeColor = SystemColors.ControlText
        btnPrevious.Location = New Point(1071, 744)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(130, 36)
        btnPrevious.TabIndex = 110
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(0, 651)
        Label8.Name = "Label8"
        Label8.Size = New Size(317, 178)
        Label8.TabIndex = 109
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.blue_arrow_top
        PictureBox8.Location = New Point(682, 671)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(150, 94)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 106
        PictureBox8.TabStop = False
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(576, 725)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 104
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(576, 676)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 102
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(389, 725)
        Label18.Name = "Label18"
        Label18.Size = New Size(170, 42)
        Label18.TabIndex = 101
        Label18.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(439, 678)
        Label17.Name = "Label17"
        Label17.Size = New Size(120, 21)
        Label17.TabIndex = 98
        Label17.Text = "Speed (mph)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(181, 463)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 25)
        Label4.TabIndex = 97
        Label4.Text = "EASTBOUND"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.blue_arrow_right
        PictureBox3.Location = New Point(301, 429)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(104, 94)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 96
        PictureBox3.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(301, 386)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 95
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(301, 337)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 94
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.FlatStyle = FlatStyle.Flat
        Label6.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(125, 386)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 42)
        Label6.TabIndex = 93
        Label6.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(181, 337)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 21)
        Label7.TabIndex = 92
        Label7.Text = "Speed (mph)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(576, 88)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 25)
        Label5.TabIndex = 91
        Label5.Text = "SOUTHBOUND"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.blue_arrow_down
        PictureBox2.Location = New Point(569, 125)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 94)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 90
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(901, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 89
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(861, 125)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 88
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(725, 174)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 42)
        Label3.TabIndex = 87
        Label3.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(725, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 21)
        Label2.TabIndex = 86
        Label2.Text = "Speed (mph)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(475, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(463, 35)
        Label1.TabIndex = 85
        Label1.Text = "Intersection Data - West Tee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.West_Tee
        PictureBox1.Location = New Point(407, 225)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 84
        PictureBox1.TabStop = False
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.InactiveCaption
        ToolStrip1.Items.AddRange(New ToolStripItem() {NewToolStripButton, OpenToolStripButton, SaveToolStripButton, ToolStripSeparator1, ToolStripLabel1, TitleToolStripButton, DistrictToolStripButton, IntersectionTypeToolStripButton, ToolStripButton7, RunToolStripButton, ToolStripLabel2, AboutToolStripButton})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1351, 25)
        ToolStrip1.TabIndex = 117
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' NewToolStripButton
        ' 
        NewToolStripButton.AccessibleRole = AccessibleRole.Equation
        NewToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        NewToolStripButton.Image = My.Resources.Resources.new_file
        NewToolStripButton.ImageTransparentColor = Color.Magenta
        NewToolStripButton.Name = "NewToolStripButton"
        NewToolStripButton.Size = New Size(23, 22)
        NewToolStripButton.Text = "New"
        ' 
        ' OpenToolStripButton
        ' 
        OpenToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        OpenToolStripButton.Image = My.Resources.Resources.folder
        OpenToolStripButton.ImageTransparentColor = Color.Magenta
        OpenToolStripButton.Name = "OpenToolStripButton"
        OpenToolStripButton.Size = New Size(23, 22)
        OpenToolStripButton.Text = "Open"
        ' 
        ' SaveToolStripButton
        ' 
        SaveToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        SaveToolStripButton.Image = My.Resources.Resources.save_file
        SaveToolStripButton.ImageTransparentColor = Color.Magenta
        SaveToolStripButton.Name = "SaveToolStripButton"
        SaveToolStripButton.Size = New Size(23, 22)
        SaveToolStripButton.Text = "Save"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 25)
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(37, 22)
        ToolStripLabel1.Text = "          "
        ' 
        ' TitleToolStripButton
        ' 
        TitleToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        TitleToolStripButton.Image = CType(resources.GetObject("TitleToolStripButton.Image"), Image)
        TitleToolStripButton.ImageTransparentColor = Color.Magenta
        TitleToolStripButton.Name = "TitleToolStripButton"
        TitleToolStripButton.Size = New Size(23, 22)
        TitleToolStripButton.Text = "Title"
        ' 
        ' DistrictToolStripButton
        ' 
        DistrictToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        DistrictToolStripButton.Image = My.Resources.Resources._2408276
        DistrictToolStripButton.ImageTransparentColor = Color.Magenta
        DistrictToolStripButton.Name = "DistrictToolStripButton"
        DistrictToolStripButton.Size = New Size(23, 22)
        DistrictToolStripButton.Text = "District"
        ' 
        ' IntersectionTypeToolStripButton
        ' 
        IntersectionTypeToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        IntersectionTypeToolStripButton.Image = My.Resources.Resources.Intersection_icon
        IntersectionTypeToolStripButton.ImageTransparentColor = Color.Magenta
        IntersectionTypeToolStripButton.Name = "IntersectionTypeToolStripButton"
        IntersectionTypeToolStripButton.Size = New Size(23, 22)
        IntersectionTypeToolStripButton.Text = "Interesection Type"
        ' 
        ' ToolStripButton7
        ' 
        ToolStripButton7.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton7.Image = My.Resources.Resources.data_type_number
        ToolStripButton7.ImageTransparentColor = Color.Magenta
        ToolStripButton7.Name = "ToolStripButton7"
        ToolStripButton7.Size = New Size(23, 22)
        ToolStripButton7.Text = "Interesection Data"
        ' 
        ' RunToolStripButton
        ' 
        RunToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        RunToolStripButton.Image = My.Resources.Resources.button_icon_png_21060
        RunToolStripButton.ImageTransparentColor = Color.Magenta
        RunToolStripButton.Name = "RunToolStripButton"
        RunToolStripButton.Size = New Size(23, 22)
        RunToolStripButton.Text = "Run"
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(37, 22)
        ToolStripLabel2.Text = "          "
        ' 
        ' AboutToolStripButton
        ' 
        AboutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image
        AboutToolStripButton.Image = My.Resources.Resources.Info
        AboutToolStripButton.ImageTransparentColor = Color.Magenta
        AboutToolStripButton.Name = "AboutToolStripButton"
        AboutToolStripButton.Size = New Size(23, 22)
        AboutToolStripButton.Text = "About"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(702, 778)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 25)
        Label9.TabIndex = 118
        Label9.Text = "NORTHBOUND"
        ' 
        ' WestTee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Label9)
        Controls.Add(ToolStrip1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(PictureBox8)
        Controls.Add(TextBox7)
        Controls.Add(TextBox8)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox5)
        Controls.Add(TextBox6)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "WestTee"
        Text = "CO Florida 2012 - West Tee"
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents OpenToolStripButton As ToolStripButton
    Friend WithEvents SaveToolStripButton As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TitleToolStripButton As ToolStripButton
    Friend WithEvents DistrictToolStripButton As ToolStripButton
    Friend WithEvents IntersectionTypeToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents RunToolStripButton As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents AboutToolStripButton As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label9 As Label
End Class
