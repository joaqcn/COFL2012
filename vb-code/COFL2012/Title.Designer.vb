<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Title
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        TextBox1 = New TextBox()
        Label7 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        PictureBox1 = New PictureBox()
        Button4 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(40, 104)
        Label1.Name = "Label1"
        Label1.Size = New Size(122, 30)
        Label1.TabIndex = 1
        Label1.Text = "Project Title"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(40, 210)
        Label2.Name = "Label2"
        Label2.Size = New Size(126, 30)
        Label2.TabIndex = 2
        Label2.Text = "User's name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(40, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(137, 30)
        Label3.TabIndex = 2
        Label3.Text = "Facility Name"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(40, 253)
        Label4.Name = "Label4"
        Label4.Size = New Size(112, 30)
        Label4.TabIndex = 3
        Label4.Text = "Run Name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(40, 333)
        Label5.Name = "Label5"
        Label5.Size = New Size(122, 60)
        Label5.TabIndex = 4
        Label5.Text = "Project Year" & vbCrLf & "(2010-2050)"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(40, 453)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 30)
        Label6.TabIndex = 5
        Label6.Text = "Land Use"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(198, 111)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(348, 23)
        TextBox1.TabIndex = 6
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(576, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(220, 32)
        Label7.TabIndex = 7
        Label7.Text = "Project Description"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(198, 163)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(348, 23)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(198, 210)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(348, 23)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(198, 260)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(348, 23)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(198, 340)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(175, 23)
        TextBox5.TabIndex = 11
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Control
        Button1.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(198, 423)
        Button1.Name = "Button1"
        Button1.Size = New Size(132, 34)
        Button1.TabIndex = 12
        Button1.Text = "Urban"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(198, 466)
        Button2.Name = "Button2"
        Button2.Size = New Size(132, 34)
        Button2.TabIndex = 13
        Button2.Text = "Suburban"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(198, 509)
        Button3.Name = "Button3"
        Button3.Size = New Size(132, 34)
        Button3.TabIndex = 14
        Button3.Text = "Rural"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.swamp
        PictureBox1.Location = New Point(669, 104)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(610, 652)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ControlDark
        Button4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(278, 717)
        Button4.Name = "Button4"
        Button4.Size = New Size(107, 39)
        Button4.TabIndex = 17
        Button4.Text = "Next"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Title
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Button4)
        Controls.Add(PictureBox1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label7)
        Controls.Add(TextBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "Title"
        Text = "projectDescription"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
End Class
