<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Welcome
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Welcome))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button1 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Trebuchet MS", 36F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(593, 63)
        Label1.Name = "Label1"
        Label1.Size = New Size(393, 61)
        Label1.TabIndex = 0
        Label1.Text = "CO Florida 2012"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(672, 165)
        Label2.Name = "Label2"
        Label2.Size = New Size(289, 29)
        Label2.TabIndex = 1
        Label2.Text = "For Florida Intersections"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(736, 226)
        Label3.Name = "Label3"
        Label3.Size = New Size(154, 29)
        Label3.TabIndex = 2
        Label3.Text = "Version 2.00"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Trebuchet MS", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(714, 282)
        Label4.Name = "Label4"
        Label4.Size = New Size(171, 29)
        Label4.TabIndex = 3
        Label4.Text = "(Change date)"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BorderStyle = BorderStyle.FixedSingle
        PictureBox1.Image = My.Resources.Resources.road
        PictureBox1.Location = New Point(-1, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(553, 636)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(584, 531)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 44)
        Label5.TabIndex = 5
        Label5.Text = "Created " & vbCrLf & "by UCF" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Trebuchet MS", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(833, 531)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 44)
        Label6.TabIndex = 6
        Label6.Text = "Sponsored" & vbCrLf & " by FDOT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.ucf_logo
        PictureBox2.Location = New Point(672, 524)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(113, 80)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.fdot_logo
        PictureBox3.Location = New Point(940, 524)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(120, 80)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.FlatAppearance.BorderSize = 6
        Button1.Font = New Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(730, 352)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 38)
        Button1.TabIndex = 9
        Button1.Text = "Continue"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightGray
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1108, 636)
        Controls.Add(Button1)
        Controls.Add(PictureBox3)
        Controls.Add(PictureBox2)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Welcome"
        RightToLeftLayout = True
        Text = "CO Florida 2012 - Welcome"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
End Class
