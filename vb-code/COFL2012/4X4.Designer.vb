<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _4X4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_4X4))
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        PictureBox2 = New PictureBox()
        Label5 = New Label()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        PictureBox7 = New PictureBox()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        TextBox5 = New TextBox()
        TextBox6 = New TextBox()
        PictureBox8 = New PictureBox()
        Label19 = New Label()
        Label8 = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        ToolStrip1 = New ToolStrip()
        ToolStripButton1 = New ToolStripButton()
        ToolStripButton2 = New ToolStripButton()
        ToolStripButton3 = New ToolStripButton()
        ToolStripSeparator2 = New ToolStripSeparator()
        ToolStripLabel3 = New ToolStripLabel()
        ToolStripButton4 = New ToolStripButton()
        ToolStripButton5 = New ToolStripButton()
        ToolStripButton6 = New ToolStripButton()
        ToolStripButton7 = New ToolStripButton()
        ToolStripButton8 = New ToolStripButton()
        ToolStripLabel4 = New ToolStripLabel()
        ToolStripButton9 = New ToolStripButton()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources._4x4
        PictureBox1.Location = New Point(405, 230)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Mono", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(474, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(415, 35)
        Label1.TabIndex = 1
        Label1.Text = "Intersection Data - 4 X 4"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(704, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 21)
        Label2.TabIndex = 2
        Label2.Text = "Speed (mph)"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(694, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(170, 42)
        Label3.TabIndex = 3
        Label3.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox1.Location = New Point(861, 132)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 4
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox2.Location = New Point(861, 181)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 5
        TextBox2.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.LightGray
        PictureBox2.Image = My.Resources.Resources.down_arrow_608258
        PictureBox2.Location = New Point(589, 151)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 73)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(557, 114)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 25)
        Label5.TabIndex = 8
        Label5.Text = "SOUTHBOUND"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(182, 464)
        Label4.Name = "Label4"
        Label4.Size = New Size(111, 25)
        Label4.TabIndex = 14
        Label4.Text = "EASTBOUND"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.LightGray
        PictureBox3.Image = My.Resources.Resources.black_arrow_right
        PictureBox3.Location = New Point(299, 451)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(104, 52)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 13
        PictureBox3.TabStop = False
        ' 
        ' TextBox8
        ' 
        TextBox8.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox8.Location = New Point(299, 391)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 12
        TextBox8.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox7
        ' 
        TextBox7.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox7.Location = New Point(299, 342)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 11
        TextBox7.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(123, 391)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 42)
        Label6.TabIndex = 10
        Label6.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(179, 342)
        Label7.Name = "Label7"
        Label7.Size = New Size(120, 21)
        Label7.TabIndex = 9
        Label7.Text = "Speed (mph)"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(1048, 453)
        Label14.Name = "Label14"
        Label14.Size = New Size(120, 21)
        Label14.TabIndex = 15
        Label14.Text = "Speed (mph)"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(1048, 493)
        Label15.Name = "Label15"
        Label15.Size = New Size(170, 42)
        Label15.TabIndex = 16
        Label15.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' TextBox3
        ' 
        TextBox3.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox3.Location = New Point(942, 451)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 17
        TextBox3.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox4
        ' 
        TextBox4.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox4.Location = New Point(942, 493)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 18
        TextBox4.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.black_arrow_left
        PictureBox7.Location = New Point(942, 379)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 54)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 19
        PictureBox7.TabStop = False
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(1035, 391)
        Label16.Name = "Label16"
        Label16.Size = New Size(111, 25)
        Label16.TabIndex = 20
        Label16.Text = "WESTBOUND"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(418, 676)
        Label17.Name = "Label17"
        Label17.Size = New Size(120, 21)
        Label17.TabIndex = 15
        Label17.Text = "Speed (mph)"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Roboto Mono", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(368, 727)
        Label18.Name = "Label18"
        Label18.Size = New Size(170, 42)
        Label18.TabIndex = 16
        Label18.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' TextBox5
        ' 
        TextBox5.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox5.Location = New Point(542, 678)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 17
        TextBox5.TextAlign = HorizontalAlignment.Center
        ' 
        ' TextBox6
        ' 
        TextBox6.Font = New Font("Roboto Mono Medium", 9F, FontStyle.Bold, GraphicsUnit.Point)
        TextBox6.Location = New Point(542, 727)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 18
        TextBox6.TextAlign = HorizontalAlignment.Center
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.black_arrow_top
        PictureBox8.Location = New Point(694, 673)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(55, 77)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 19
        PictureBox8.TabStop = False
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Roboto Mono", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(662, 761)
        Label19.Name = "Label19"
        Label19.Size = New Size(122, 25)
        Label19.TabIndex = 20
        Label19.Text = "NORTHBOUND"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Font = New Font("Roboto Mono", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(12, 651)
        Label8.Name = "Label8"
        Label8.Size = New Size(317, 178)
        Label8.TabIndex = 21
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.AppWorkspace
        btnPrevious.Font = New Font("Roboto Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.ForeColor = SystemColors.ControlText
        btnPrevious.Location = New Point(1048, 750)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(136, 36)
        btnPrevious.TabIndex = 22
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.AppWorkspace
        btnNext.Font = New Font("Roboto Mono", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.ForeColor = SystemColors.ControlText
        btnNext.Location = New Point(1190, 750)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(122, 36)
        btnNext.TabIndex = 25
        btnNext.Text = "Run"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.InactiveCaption
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripButton1, ToolStripButton2, ToolStripButton3, ToolStripSeparator2, ToolStripLabel3, ToolStripButton4, ToolStripButton5, ToolStripButton6, ToolStripButton7, ToolStripButton8, ToolStripLabel4, ToolStripButton9})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(1351, 25)
        ToolStrip1.TabIndex = 38
        ToolStrip1.Text = "ToolStrip2"
        ' 
        ' ToolStripButton1
        ' 
        ToolStripButton1.AccessibleRole = AccessibleRole.Equation
        ToolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton1.Image = My.Resources.Resources.new_file
        ToolStripButton1.ImageTransparentColor = Color.Magenta
        ToolStripButton1.Name = "ToolStripButton1"
        ToolStripButton1.Size = New Size(23, 22)
        ToolStripButton1.Text = "New"
        ' 
        ' ToolStripButton2
        ' 
        ToolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton2.Image = My.Resources.Resources.folder
        ToolStripButton2.ImageTransparentColor = Color.Magenta
        ToolStripButton2.Name = "ToolStripButton2"
        ToolStripButton2.Size = New Size(23, 22)
        ToolStripButton2.Text = "Open"
        ' 
        ' ToolStripButton3
        ' 
        ToolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton3.Image = My.Resources.Resources.save_file
        ToolStripButton3.ImageTransparentColor = Color.Magenta
        ToolStripButton3.Name = "ToolStripButton3"
        ToolStripButton3.Size = New Size(23, 22)
        ToolStripButton3.Text = "Save"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(6, 25)
        ' 
        ' ToolStripLabel3
        ' 
        ToolStripLabel3.Name = "ToolStripLabel3"
        ToolStripLabel3.Size = New Size(37, 22)
        ToolStripLabel3.Text = "          "
        ' 
        ' ToolStripButton4
        ' 
        ToolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), Image)
        ToolStripButton4.ImageTransparentColor = Color.Magenta
        ToolStripButton4.Name = "ToolStripButton4"
        ToolStripButton4.Size = New Size(23, 22)
        ToolStripButton4.Text = "Title"
        ' 
        ' ToolStripButton5
        ' 
        ToolStripButton5.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton5.Image = My.Resources.Resources._2408276
        ToolStripButton5.ImageTransparentColor = Color.Magenta
        ToolStripButton5.Name = "ToolStripButton5"
        ToolStripButton5.Size = New Size(23, 22)
        ToolStripButton5.Text = "District"
        ' 
        ' ToolStripButton6
        ' 
        ToolStripButton6.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton6.Image = My.Resources.Resources.Intersection_icon
        ToolStripButton6.ImageTransparentColor = Color.Magenta
        ToolStripButton6.Name = "ToolStripButton6"
        ToolStripButton6.Size = New Size(23, 22)
        ToolStripButton6.Text = "Interesection Type"
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
        ' ToolStripButton8
        ' 
        ToolStripButton8.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton8.Image = My.Resources.Resources.button_icon_png_21060
        ToolStripButton8.ImageTransparentColor = Color.Magenta
        ToolStripButton8.Name = "ToolStripButton8"
        ToolStripButton8.Size = New Size(23, 22)
        ToolStripButton8.Text = "Run"
        ' 
        ' ToolStripLabel4
        ' 
        ToolStripLabel4.Name = "ToolStripLabel4"
        ToolStripLabel4.Size = New Size(37, 22)
        ToolStripLabel4.Text = "          "
        ' 
        ' ToolStripButton9
        ' 
        ToolStripButton9.DisplayStyle = ToolStripItemDisplayStyle.Image
        ToolStripButton9.Image = My.Resources.Resources.Info
        ToolStripButton9.ImageTransparentColor = Color.Magenta
        ToolStripButton9.Name = "ToolStripButton9"
        ToolStripButton9.Size = New Size(23, 22)
        ToolStripButton9.Text = "About"
        ' 
        ' _4X4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        ClientSize = New Size(1351, 838)
        Controls.Add(ToolStrip1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(Label19)
        Controls.Add(PictureBox7)
        Controls.Add(TextBox4)
        Controls.Add(PictureBox8)
        Controls.Add(TextBox3)
        Controls.Add(TextBox6)
        Controls.Add(Label15)
        Controls.Add(TextBox5)
        Controls.Add(Label14)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox8)
        Controls.Add(TextBox7)
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
        Name = "_4X4"
        Text = "CO Florida 2012 - Intesection Data - 4 X 4"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton7 As ToolStripButton
    Friend WithEvents ToolStripButton8 As ToolStripButton
    Friend WithEvents ToolStripLabel4 As ToolStripLabel
    Friend WithEvents ToolStripButton9 As ToolStripButton
End Class
