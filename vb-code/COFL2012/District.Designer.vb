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
        Button7 = New Button()
        Button6 = New Button()
        Button5 = New Button()
        Button4 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        Button1 = New Button()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnPrevious = New Button()
        btnNext = New Button()
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
        Panel1.Controls.Add(Button7)
        Panel1.Controls.Add(Button6)
        Panel1.Controls.Add(Button5)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button1)
        Panel1.Location = New Point(43, 173)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(138, 420)
        Panel1.TabIndex = 1
        ' 
        ' Button7
        ' 
        Button7.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button7.ImageAlign = ContentAlignment.TopCenter
        Button7.Location = New Point(16, 360)
        Button7.Name = "Button7"
        Button7.Size = New Size(104, 32)
        Button7.TabIndex = 10
        Button7.Text = "District 7"
        Button7.UseVisualStyleBackColor = True
        ' 
        ' Button6
        ' 
        Button6.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button6.ImageAlign = ContentAlignment.TopCenter
        Button6.Location = New Point(16, 303)
        Button6.Name = "Button6"
        Button6.Size = New Size(104, 32)
        Button6.TabIndex = 9
        Button6.Text = "District 6"
        Button6.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.ImageAlign = ContentAlignment.TopCenter
        Button5.Location = New Point(16, 251)
        Button5.Name = "Button5"
        Button5.Size = New Size(104, 32)
        Button5.TabIndex = 8
        Button5.Text = "District 5"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.ImageAlign = ContentAlignment.TopCenter
        Button4.Location = New Point(17, 194)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 32)
        Button4.TabIndex = 7
        Button4.Text = "District 4"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.ImageAlign = ContentAlignment.TopCenter
        Button3.Location = New Point(16, 140)
        Button3.Name = "Button3"
        Button3.Size = New Size(104, 32)
        Button3.TabIndex = 6
        Button3.Text = "District 3"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.ImageAlign = ContentAlignment.TopCenter
        Button2.Location = New Point(16, 87)
        Button2.Name = "Button2"
        Button2.Size = New Size(104, 32)
        Button2.TabIndex = 5
        Button2.Text = "District 2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ImageAlign = ContentAlignment.TopCenter
        Button1.Location = New Point(16, 31)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 32)
        Button1.TabIndex = 4
        Button1.Text = "District 1"
        Button1.UseVisualStyleBackColor = True
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
        ' btnPrevious
        ' 
        btnPrevious.BackColor = SystemColors.ButtonShadow
        btnPrevious.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrevious.ImageAlign = ContentAlignment.TopCenter
        btnPrevious.Location = New Point(1031, 723)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(104, 32)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "Previous"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = SystemColors.ButtonShadow
        btnNext.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnNext.ImageAlign = ContentAlignment.TopCenter
        btnNext.Location = New Point(1141, 723)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(104, 32)
        btnNext.TabIndex = 12
        btnNext.Text = "Next"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' District
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
