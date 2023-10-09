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
        Label1.Font = New Font("Segoe UI Emoji", 36.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label1.Location = New Point(530, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(382, 64)
        Label1.TabIndex = 0
        Label1.Text = "CO Florida 2012"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(585, 82)
        Label2.Name = "Label2"
        Label2.Size = New Size(276, 32)
        Label2.TabIndex = 1
        Label2.Text = "For Florida Intersections"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(650, 126)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 32)
        Label3.TabIndex = 2
        Label3.Text = "Version 1.01"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(626, 173)
        Label4.Name = "Label4"
        Label4.Size = New Size(182, 32)
        Label4.TabIndex = 3
        Label4.Text = "January 9, 2012"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.florida_beach
        PictureBox1.Location = New Point(117, 219)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1164, 394)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(297, 680)
        Label5.Name = "Label5"
        Label5.Size = New Size(107, 64)
        Label5.TabIndex = 5
        Label5.Text = "Created " & vbCrLf & "by UCF" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(732, 684)
        Label6.Name = "Label6"
        Label6.Size = New Size(129, 64)
        Label6.TabIndex = 6
        Label6.Text = "Sponsored" & vbCrLf & " by FDOT"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.ucf_logo
        PictureBox2.Location = New Point(410, 660)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(165, 114)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.fdot_logo
        PictureBox3.Location = New Point(882, 672)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(165, 102)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 8
        PictureBox3.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Button1.Location = New Point(1121, 706)
        Button1.Name = "Button1"
        Button1.Size = New Size(160, 38)
        Button1.TabIndex = 9
        Button1.Text = "Continue"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Welcome
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
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
        Name = "Welcome"
        Text = "Form1"
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
