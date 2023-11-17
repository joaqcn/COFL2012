<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TollBoothEW
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(TollBoothEW))
        btnNext = New Button()
        btnPrevious = New Button()
        Label8 = New Label()
        Label16 = New Label()
        PictureBox7 = New PictureBox()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        TextBox1 = New TextBox()
        TextBox14 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        Label9 = New Label()
        TextBox3 = New TextBox()
        Label2 = New Label()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label3 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        TextBox6 = New TextBox()
        Label10 = New Label()
        TextBox7 = New TextBox()
        TextBox8 = New TextBox()
        Label11 = New Label()
        Label12 = New Label()
        PictureBox4 = New PictureBox()
        Label13 = New Label()
        Label14 = New Label()
        PictureBox5 = New PictureBox()
        TextBox9 = New TextBox()
        Label15 = New Label()
        TextBox10 = New TextBox()
        TextBox11 = New TextBox()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
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
        btnNext.TabIndex = 134
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
        btnPrevious.TabIndex = 133
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BorderStyle = BorderStyle.FixedSingle
        Label8.Location = New Point(12, 244)
        Label8.Name = "Label8"
        Label8.Size = New Size(269, 152)
        Label8.TabIndex = 132
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(1114, 388)
        Label16.Name = "Label16"
        Label16.Size = New Size(127, 25)
        Label16.TabIndex = 131
        Label16.Text = "WESTBOUND"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.blue_arrow_left
        PictureBox7.Location = New Point(1037, 353)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 89)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 130
        PictureBox7.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(79, 491)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 25)
        Label4.TabIndex = 125
        Label4.Text = "EASTBOUND"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.blue_arrow_right
        PictureBox3.Location = New Point(184, 458)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(104, 94)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 124
        PictureBox3.TabStop = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(184, 611)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 123
        ' 
        ' TextBox14
        ' 
        TextBox14.Location = New Point(184, 562)
        TextBox14.Name = "TextBox14"
        TextBox14.Size = New Size(100, 23)
        TextBox14.TabIndex = 122
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(31, 609)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 42)
        Label6.TabIndex = 121
        Label6.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(31, 560)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 42)
        Label7.TabIndex = 120
        Label7.Text = "Freeway " & vbCrLf & "Speed (mph)" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(479, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(459, 37)
        Label1.TabIndex = 113
        Label1.Text = "Tollbooth Interchange: E-W Freeway"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.Tool_Booth
        PictureBox2.Location = New Point(294, 227)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(737, 440)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 112
        PictureBox2.TabStop = False
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(184, 674)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 136
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(27, 672)
        Label9.Name = "Label9"
        Label9.Size = New Size(151, 42)
        Label9.TabIndex = 135
        Label9.Text = "% of Vehicles Using" & vbCrLf & "ETC-Only Lanes" & vbCrLf
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(1201, 575)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 144
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(1044, 573)
        Label2.Name = "Label2"
        Label2.Size = New Size(151, 42)
        Label2.TabIndex = 143
        Label2.Text = "% of Vehicles Using" & vbCrLf & "ETC-Only Lanes" & vbCrLf
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(1201, 512)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 142
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(1201, 463)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 141
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(1048, 510)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 42)
        Label3.TabIndex = 140
        Label3.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(1048, 461)
        Label5.Name = "Label5"
        Label5.Size = New Size(104, 42)
        Label5.TabIndex = 139
        Label5.Text = "Freeway " & vbCrLf & "Speed (mph)" & vbCrLf
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.ToolBoothN_S
        PictureBox1.Location = New Point(294, 228)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(737, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 145
        PictureBox1.TabStop = False
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(319, 198)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 151
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(869, 137)
        Label10.Name = "Label10"
        Label10.Size = New Size(151, 42)
        Label10.TabIndex = 150
        Label10.Text = "% of Vehicles Using" & vbCrLf & "ETC-Only Lanes" & vbCrLf
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(693, 198)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 149
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(869, 198)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 148
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(678, 137)
        Label11.Name = "Label11"
        Label11.Size = New Size(132, 42)
        Label11.TabIndex = 147
        Label11.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(315, 137)
        Label12.Name = "Label12"
        Label12.Size = New Size(104, 42)
        Label12.TabIndex = 146
        Label12.Text = "Freeway " & vbCrLf & "Speed (mph)" & vbCrLf
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = My.Resources.Resources.blue_arrow_down
        PictureBox4.Location = New Point(528, 137)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(100, 84)
        PictureBox4.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox4.TabIndex = 152
        PictureBox4.TabStop = False
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(509, 117)
        Label13.Name = "Label13"
        Label13.Size = New Size(140, 25)
        Label13.TabIndex = 153
        Label13.Text = "SOUTHBOUND"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(693, 761)
        Label14.Name = "Label14"
        Label14.Size = New Size(144, 25)
        Label14.TabIndex = 161
        Label14.Text = "NORTHBOUND"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = My.Resources.Resources.blue_arrow_top
        PictureBox5.Location = New Point(710, 674)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(100, 84)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 160
        PictureBox5.TabStop = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(329, 719)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(100, 23)
        TextBox9.TabIndex = 159
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(889, 674)
        Label15.Name = "Label15"
        Label15.Size = New Size(151, 42)
        Label15.TabIndex = 158
        Label15.Text = "% of Vehicles Using" & vbCrLf & "ETC-Only Lanes" & vbCrLf
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(528, 719)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(100, 23)
        TextBox10.TabIndex = 157
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(902, 719)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(100, 23)
        TextBox11.TabIndex = 156
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(528, 674)
        Label17.Name = "Label17"
        Label17.Size = New Size(132, 42)
        Label17.TabIndex = 155
        Label17.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(329, 674)
        Label18.Name = "Label18"
        Label18.Size = New Size(104, 42)
        Label18.TabIndex = 154
        Label18.Text = "Freeway " & vbCrLf & "Speed (mph)" & vbCrLf
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(483, 21)
        Label19.Name = "Label19"
        Label19.Size = New Size(455, 37)
        Label19.TabIndex = 162
        Label19.Text = "Tollbooth Interchange: N-S Freeway"
        ' 
        ' TollBoothEW
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Label19)
        Controls.Add(Label14)
        Controls.Add(PictureBox5)
        Controls.Add(TextBox9)
        Controls.Add(Label15)
        Controls.Add(TextBox10)
        Controls.Add(TextBox11)
        Controls.Add(Label17)
        Controls.Add(Label18)
        Controls.Add(Label13)
        Controls.Add(PictureBox4)
        Controls.Add(TextBox6)
        Controls.Add(Label10)
        Controls.Add(TextBox7)
        Controls.Add(TextBox8)
        Controls.Add(Label11)
        Controls.Add(Label12)
        Controls.Add(PictureBox1)
        Controls.Add(TextBox3)
        Controls.Add(Label2)
        Controls.Add(TextBox4)
        Controls.Add(TextBox5)
        Controls.Add(Label3)
        Controls.Add(Label5)
        Controls.Add(TextBox2)
        Controls.Add(Label9)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(PictureBox7)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox1)
        Controls.Add(TextBox14)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(PictureBox2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "TollBoothEW"
        Text = "CO Florida 2012 - Toll Booth Design"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox14 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
End Class
