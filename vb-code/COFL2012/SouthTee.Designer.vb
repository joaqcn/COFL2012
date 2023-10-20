<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SouthTee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(SouthTee))
        Button2 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        Label16 = New Label()
        Label19 = New Label()
        PictureBox7 = New PictureBox()
        TextBox10 = New TextBox()
        PictureBox8 = New PictureBox()
        TextBox9 = New TextBox()
        TextBox12 = New TextBox()
        Label15 = New Label()
        TextBox11 = New TextBox()
        Label14 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
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
        Button2.TabIndex = 83
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
        Button1.TabIndex = 82
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
        Label8.TabIndex = 81
        Label8.Text = resources.GetString("Label8.Text")
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label16.Location = New Point(1034, 294)
        Label16.Name = "Label16"
        Label16.Size = New Size(127, 25)
        Label16.TabIndex = 80
        Label16.Text = "WESTBOUND"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label19.Location = New Point(671, 687)
        Label19.Name = "Label19"
        Label19.Size = New Size(144, 25)
        Label19.TabIndex = 79
        Label19.Text = "NORTHBOUND"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.blue_arrow_left
        PictureBox7.Location = New Point(957, 259)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 89)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 78
        PictureBox7.TabStop = False
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(957, 396)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(100, 23)
        TextBox10.TabIndex = 76
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = My.Resources.Resources.blue_arrow_top
        PictureBox8.Location = New Point(665, 600)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(150, 94)
        PictureBox8.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox8.TabIndex = 77
        PictureBox8.TabStop = False
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(957, 354)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(100, 23)
        TextBox9.TabIndex = 74
        ' 
        ' TextBox12
        ' 
        TextBox12.Location = New Point(559, 654)
        TextBox12.Name = "TextBox12"
        TextBox12.Size = New Size(100, 23)
        TextBox12.TabIndex = 75
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(1076, 394)
        Label15.Name = "Label15"
        Label15.Size = New Size(132, 42)
        Label15.TabIndex = 71
        Label15.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' TextBox11
        ' 
        TextBox11.Location = New Point(559, 605)
        TextBox11.Name = "TextBox11"
        TextBox11.Size = New Size(100, 23)
        TextBox11.TabIndex = 73
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(1086, 354)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 21)
        Label14.TabIndex = 70
        Label14.Text = "Speed (mph)"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(422, 652)
        Label18.Name = "Label18"
        Label18.Size = New Size(132, 42)
        Label18.TabIndex = 72
        Label18.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label17.Location = New Point(435, 603)
        Label17.Name = "Label17"
        Label17.Size = New Size(104, 21)
        Label17.TabIndex = 69
        Label17.Text = "Speed (mph)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(205, 384)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 25)
        Label4.TabIndex = 68
        Label4.Text = "EASTBOUND"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.blue_arrow_right
        PictureBox3.Location = New Point(310, 351)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(104, 94)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 67
        PictureBox3.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(310, 308)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 66
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(310, 259)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 65
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(172, 306)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 42)
        Label6.TabIndex = 64
        Label6.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(190, 259)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 21)
        Label7.TabIndex = 63
        Label7.Text = "Speed (mph)"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(501, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(372, 37)
        Label1.TabIndex = 56
        Label1.Text = "Intersection Data - South Tee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.South_Tee
        PictureBox1.Location = New Point(420, 141)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 55
        PictureBox1.TabStop = False
        ' 
        ' SouthTee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(Label19)
        Controls.Add(PictureBox7)
        Controls.Add(TextBox10)
        Controls.Add(PictureBox8)
        Controls.Add(TextBox9)
        Controls.Add(TextBox12)
        Controls.Add(Label15)
        Controls.Add(TextBox11)
        Controls.Add(Label14)
        Controls.Add(Label18)
        Controls.Add(Label17)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(Label6)
        Controls.Add(Label7)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        Name = "SouthTee"
        Text = "SouthTee"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
