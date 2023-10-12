<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class District
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
        Label1 = New Label()
        Panel1 = New Panel()
        district7 = New Button()
        district6 = New Button()
        district5 = New Button()
        district4 = New Button()
        district3 = New Button()
        district2 = New Button()
        district1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button3 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(577, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(197, 32)
        Label1.TabIndex = 0
        Label1.Text = "District Selection"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.Control
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(district7)
        Panel1.Controls.Add(district6)
        Panel1.Controls.Add(district5)
        Panel1.Controls.Add(district4)
        Panel1.Controls.Add(district3)
        Panel1.Controls.Add(district2)
        Panel1.Controls.Add(district1)
        Panel1.Location = New Point(43, 173)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(138, 420)
        Panel1.TabIndex = 1
        ' 
        ' district7
        ' 
        district7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        district7.ImageAlign = ContentAlignment.TopCenter
        district7.Location = New Point(16, 360)
        district7.Name = "district7"
        district7.Size = New Size(104, 32)
        district7.TabIndex = 10
        district7.Text = "District 7"
        district7.UseVisualStyleBackColor = True
        ' 
        ' district6
        ' 
        district6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        district6.ImageAlign = ContentAlignment.TopCenter
        district6.Location = New Point(16, 303)
        district6.Name = "district6"
        district6.Size = New Size(104, 32)
        district6.TabIndex = 9
        district6.Text = "District 6"
        district6.UseVisualStyleBackColor = True
        ' 
        ' district5
        ' 
        district5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        district5.ImageAlign = ContentAlignment.TopCenter
        district5.Location = New Point(16, 251)
        district5.Name = "district5"
        district5.Size = New Size(104, 32)
        district5.TabIndex = 8
        district5.Text = "District 5"
        district5.UseVisualStyleBackColor = True
        ' 
        ' district4
        ' 
        district4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        district4.ImageAlign = ContentAlignment.TopCenter
        district4.Location = New Point(17, 194)
        district4.Name = "district4"
        district4.Size = New Size(104, 32)
        district4.TabIndex = 7
        district4.Text = "District 4"
        district4.UseVisualStyleBackColor = True
        ' 
        ' district3
        ' 
        district3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        district3.ImageAlign = ContentAlignment.TopCenter
        district3.Location = New Point(16, 140)
        district3.Name = "district3"
        district3.Size = New Size(104, 32)
        district3.TabIndex = 6
        district3.Text = "District 3"
        district3.UseVisualStyleBackColor = True
        ' 
        ' district2
        ' 
        district2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        district2.ImageAlign = ContentAlignment.TopCenter
        district2.Location = New Point(16, 87)
        district2.Name = "district2"
        district2.Size = New Size(104, 32)
        district2.TabIndex = 5
        district2.Text = "District 2"
        district2.UseVisualStyleBackColor = True
        ' 
        ' district1
        ' 
        district1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        district1.ImageAlign = ContentAlignment.TopCenter
        district1.Location = New Point(16, 31)
        district1.Name = "district1"
        district1.Size = New Size(104, 32)
        district1.TabIndex = 4
        district1.Text = "District 1"
        district1.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.district_map
        PictureBox1.Location = New Point(224, 163)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(550, 468)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.egmont_key
        PictureBox2.Location = New Point(809, 163)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(482, 463)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 3
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(1031, 723)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 32)
        Button1.TabIndex = 11
        Button1.Text = "Previous"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ButtonShadow
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.ImageAlign = ContentAlignment.TopCenter
        Button3.Location = New Point(1141, 723)
        Button3.Name = "Button3"
        Button3.Size = New Size(104, 32)
        Button3.TabIndex = 12
        Button3.Text = "Next"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' District
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "District"
        Text = "District"
        Panel1.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents district1 As Button
    Friend WithEvents district7 As Button
    Friend WithEvents district6 As Button
    Friend WithEvents district5 As Button
    Friend WithEvents district4 As Button
    Friend WithEvents district3 As Button
    Friend WithEvents district2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
