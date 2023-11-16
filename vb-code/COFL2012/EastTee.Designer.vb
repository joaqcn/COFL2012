<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class East_Tee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(East_Tee))
        btnNext = New Button()
        btnPrevious = New Button()
        Label8 = New Label()
        Label16 = New Label()
        PictureBox7 = New PictureBox()
        TextBox3 = New TextBox()
        PictureBox8 = New PictureBox()
        TextBox4 = New TextBox()
        TextBox7 = New TextBox()
        Label15 = New Label()
        TextBox8 = New TextBox()
        Label14 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.AppWorkspace
        btnNext.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
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
        btnPrevious.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.ForeColor = SystemColors.ControlText
        btnPrevious.Location = New Point(1096, 744)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(105, 36)
        btnPrevious.TabIndex = 110
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(39, 650)
        Label8.Name = "Label8"
        Label8.Size = New Size(236, 167)
        Label8.TabIndex = 109
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(1021, 414)
        Label16.Name = "Label16"
        Label16.Size = New Size(127, 25)
        Label16.TabIndex = 108
        Label16.Text = "WESTBOUND"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.blue_arrow_left
        PictureBox7.Location = New Point(944, 379)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 89)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 107
        PictureBox7.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(944, 516)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 105
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.blue_arrow_top
        PictureBox8.Location = New Point(650, 668)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(118, 94)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 106
        PictureBox8.TabStop = False
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(944, 474)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 103
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(544, 722)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 104
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(1063, 514)
        Label15.Name = "Label15"
        Label15.Size = New Size(132, 42)
        Label15.TabIndex = 100
        Label15.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(544, 673)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 102
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(1073, 474)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 21)
        Label14.TabIndex = 99
        Label14.Text = "Speed (mph)"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(407, 720)
        Label18.Name = "Label18"
        Label18.Size = New Size(132, 42)
        Label18.TabIndex = 101
        Label18.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(420, 671)
        Label17.Name = "Label17"
        Label17.Size = New Size(104, 21)
        Label17.TabIndex = 98
        Label17.Text = "Speed (mph)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(539, 109)
        Label5.Name = "Label5"
        Label5.Size = New Size(140, 25)
        Label5.TabIndex = 91
        Label5.Text = "SOUTHBOUND"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.blue_arrow_down
        PictureBox2.Location = New Point(540, 127)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(150, 94)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 90
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(832, 176)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 89
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(832, 127)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 88
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(696, 176)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 42)
        Label3.TabIndex = 87
        Label3.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(722, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(104, 21)
        Label2.TabIndex = 86
        Label2.Text = "Speed (mph)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(501, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(349, 37)
        Label1.TabIndex = 85
        Label1.Text = "Intersection Data - East Tee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.East_Tee
        PictureBox1.Location = New Point(407, 225)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 84
        PictureBox1.TabStop = False
        ' 
        ' East_Tee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(PictureBox7)
        Controls.Add(TextBox3)
        Controls.Add(PictureBox8)
        Controls.Add(TextBox4)
        Controls.Add(TextBox7)
        Controls.Add(Label15)
        Controls.Add(TextBox8)
        Controls.Add(Label14)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "East_Tee"
        Text = "CO Florida 2012 - East Tee"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
