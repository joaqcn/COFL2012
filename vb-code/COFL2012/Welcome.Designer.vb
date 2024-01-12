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
        Label5 = New Label()
        Label6 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        Button1 = New Button()
        Panel1 = New Panel()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Roboto Mono", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(254, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(605, 84)
        Label1.TabIndex = 0
        Label1.Text = "CO Florida 2012"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Roboto Mono", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(153, 11)
        Label5.Name = "Label5"
        Label5.Size = New Size(238, 32)
        Label5.TabIndex = 5
        Label5.Text = "Developed by UCF"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Roboto Mono", 18F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(651, 11)
        Label6.Name = "Label6"
        Label6.Size = New Size(252, 32)
        Label6.TabIndex = 6
        Label6.Text = "Sponsored by FDOT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.ucf_logo
        PictureBox2.Location = New Point(201, 56)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(136, 102)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.fdot_logo
        PictureBox3.Location = New Point(684, 56)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(187, 102)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.FlatAppearance.BorderColor = Color.Black
        Button1.Font = New Font("Roboto Mono", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(438, 305)
        Button1.Name = "Button1"
        Button1.Size = New Size(240, 62)
        Button1.TabIndex = 9
        Button1.Text = "Start"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(222), CByte(222), CByte(222))
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Location = New Point(2, 466)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1107, 171)
        Panel1.TabIndex = 10
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1108, 636)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        HelpButton = True
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        Name = "Welcome"
        RightToLeftLayout = True
        Text = "CO Florida 2012 - Welcome"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
End Class
