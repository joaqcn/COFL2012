<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NorthSouthFreeway
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(NorthSouthFreeway))
        Button2 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        Label16 = New Label()
        PictureBox7 = New PictureBox()
        TextBox10 = New TextBox()
        PictureBox8 = New PictureBox()
        TextBox9 = New TextBox()
        Label15 = New Label()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Label5 = New Label()
        PictureBox2 = New PictureBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        TextBox5 = New TextBox()
        Label9 = New Label()
        TextBox6 = New TextBox()
        TextBox7 = New TextBox()
        Label11 = New Label()
        TextBox8 = New TextBox()
        Label12 = New Label()
        TextBox11 = New TextBox()
        TextBox12 = New TextBox()
        Label13 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label7 = New Label()
        Label10 = New Label()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.AppWorkspace
        Button2.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(1207, 744)
        Button2.Name = "Button2"
        Button2.Size = New Size(105, 36)
        Button2.TabIndex = 111
        Button2.Text = "Run"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.AppWorkspace
        Button1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(1096, 744)
        Button1.Name = "Button1"
        Button1.Size = New Size(105, 36)
        Button1.TabIndex = 110
        Button1.Text = "Previous"
        Button1.UseVisualStyleBackColor = False
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
        Label16.Location = New Point(1021, 394)
        Label16.Name = "Label16"
        Label16.Size = New Size(127, 25)
        Label16.TabIndex = 108
        Label16.Text = "WESTBOUND"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.blue_arrow_left
        PictureBox7.Location = New Point(944, 359)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 89)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 107
        PictureBox7.TabStop = False
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(944, 496)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(100, 23)
        TextBox10.TabIndex = 105
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.blue_arrow_top
        PictureBox8.Location = New Point(627, 671)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(150, 94)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 106
        PictureBox8.TabStop = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(944, 454)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(100, 23)
        TextBox9.TabIndex = 103
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(1063, 494)
        Label15.Name = "Label15"
        Label15.Size = New Size(132, 42)
        Label15.TabIndex = 100
        Label15.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(196, 462)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 25)
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
        ' TextBox3
        ' 
        TextBox3.Location = New Point(301, 386)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 95
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(301, 337)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 94
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(163, 384)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 42)
        Label6.TabIndex = 93
        Label6.Text = "On Ramp" & vbCrLf & "Traffic (veh/hr)" & vbCrLf
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
        TextBox2.Location = New Point(852, 178)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 89
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(852, 136)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 88
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(714, 178)
        Label3.Name = "Label3"
        Label3.Size = New Size(135, 42)
        Label3.TabIndex = 87
        Label3.Text = "Off- Ramp Traffic" & vbCrLf & "(veh/hr)" & vbCrLf
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(714, 138)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 42)
        Label2.TabIndex = 86
        Label2.Text = "Freeway Speed" & vbCrLf & "(mph)" & vbCrLf
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(501, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(451, 37)
        Label1.TabIndex = 85
        Label1.Text = "Diamond Interchange: N-S Freeway"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.N_S_Freeway
        PictureBox1.Location = New Point(407, 225)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 84
        PictureBox1.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(301, 300)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 113
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label9.Location = New Point(133, 300)
        Label9.Name = "Label9"
        Label9.Size = New Size(162, 21)
        Label9.TabIndex = 112
        Label9.Text = "Arterial Speed (mph)"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(944, 546)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 115
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(852, 98)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(100, 23)
        TextBox7.TabIndex = 117
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label11.Location = New Point(710, 92)
        Label11.Name = "Label11"
        Label11.Size = New Size(136, 42)
        Label11.TabIndex = 116
        Label11.Text = "Approach Traffic " & vbCrLf & "(veh/hr)" & vbCrLf
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(522, 683)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(100, 23)
        TextBox8.TabIndex = 123
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label12.Location = New Point(380, 677)
        Label12.Name = "Label12"
        Label12.Size = New Size(136, 42)
        Label12.TabIndex = 122
        Label12.Text = "Approach Traffic " & vbCrLf & "(veh/hr)" & vbCrLf
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(522, 763)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(100, 23)
        TextBox11.TabIndex = 121
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(522, 721)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(100, 23)
        TextBox12.TabIndex = 120
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label13.Location = New Point(384, 763)
        Label13.Name = "Label13"
        Label13.Size = New Size(135, 42)
        Label13.TabIndex = 119
        Label13.Text = "Off- Ramp Traffic" & vbCrLf & "(veh/hr)" & vbCrLf
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(384, 723)
        Label17.Name = "Label17"
        Label17.Size = New Size(121, 42)
        Label17.TabIndex = 118
        Label17.Text = "Freeway Speed" & vbCrLf & "(mph)" & vbCrLf
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(163, 335)
        Label18.Name = "Label18"
        Label18.Size = New Size(132, 42)
        Label18.TabIndex = 124
        Label18.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(1063, 544)
        Label7.Name = "Label7"
        Label7.Size = New Size(118, 42)
        Label7.TabIndex = 125
        Label7.Text = "On Ramp" & vbCrLf & "Traffic (veh/hr)" & vbCrLf
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label10.Location = New Point(1063, 452)
        Label10.Name = "Label10"
        Label10.Size = New Size(162, 21)
        Label10.TabIndex = 126
        Label10.Text = "Arterial Speed (mph)"
        ' 
        ' NorthSouthFreeway
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Label10)
        Controls.Add(Label7)
        Controls.Add(Label18)
        Controls.Add(TextBox8)
        Controls.Add(Label12)
        Controls.Add(TextBox11)
        Controls.Add(TextBox12)
        Controls.Add(Label13)
        Controls.Add(Label17)
        Controls.Add(TextBox7)
        Controls.Add(Label11)
        Controls.Add(TextBox6)
        Controls.Add(TextBox5)
        Controls.Add(Label9)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(PictureBox7)
        Controls.Add(TextBox10)
        Controls.Add(PictureBox8)
        Controls.Add(TextBox9)
        Controls.Add(Label15)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PictureBox2)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "NorthSouthFreeway"
        Text = "NorthSouthFreeway"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
End Class
