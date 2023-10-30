<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class North_Tee
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(North_Tee))
        Button2 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        Label16 = New Label()
        PictureBox7 = New PictureBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
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
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
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
        Label16.Location = New Point(1021, 418)
        Label16.Name = "Label16"
        Label16.Size = New Size(127, 25)
        Label16.TabIndex = 108
        Label16.Text = "WESTBOUND"
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = My.Resources.Resources.blue_arrow_left
        PictureBox7.Location = New Point(944, 383)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(87, 89)
        PictureBox7.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox7.TabIndex = 107
        PictureBox7.TabStop = False
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(944, 520)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(100, 23)
        TextBox3.TabIndex = 105
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(944, 478)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(100, 23)
        TextBox4.TabIndex = 103
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label15.Location = New Point(1063, 518)
        Label15.Name = "Label15"
        Label15.Size = New Size(132, 42)
        Label15.TabIndex = 100
        Label15.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label14.Location = New Point(1073, 478)
        Label14.Name = "Label14"
        Label14.Size = New Size(104, 21)
        Label14.TabIndex = 99
        Label14.Text = "Speed (mph)"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(192, 491)
        Label4.Name = "Label4"
        Label4.Size = New Size(122, 25)
        Label4.TabIndex = 97
        Label4.Text = "EASTBOUND"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.blue_arrow_right
        PictureBox3.Location = New Point(297, 458)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(104, 94)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 96
        PictureBox3.TabStop = False
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(297, 415)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(100, 23)
        TextBox5.TabIndex = 95
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(297, 366)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(100, 23)
        TextBox6.TabIndex = 94
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(159, 413)
        Label6.Name = "Label6"
        Label6.Size = New Size(132, 42)
        Label6.TabIndex = 93
        Label6.Text = "Approach Traffic" & vbCrLf & " (veh/hr)"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(177, 366)
        Label7.Name = "Label7"
        Label7.Size = New Size(104, 21)
        Label7.TabIndex = 92
        Label7.Text = "Speed (mph)"
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
        Label1.Size = New Size(373, 37)
        Label1.TabIndex = 85
        Label1.Text = "Intersection Data - North Tee"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.North_Tee
        PictureBox1.Location = New Point(407, 225)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(531, 440)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 84
        PictureBox1.TabStop = False
        ' 
        ' North_Tee
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label8)
        Controls.Add(Label16)
        Controls.Add(PictureBox7)
        Controls.Add(TextBox3)
        Controls.Add(TextBox4)
        Controls.Add(Label15)
        Controls.Add(Label14)
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
        Name = "North_Tee"
        Text = "North_Tee"
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
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
End Class
