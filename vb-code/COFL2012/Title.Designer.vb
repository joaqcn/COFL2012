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
        project_title = New TextBox()
        Label7 = New Label()
        facility_name = New TextBox()
        user_name = New TextBox()
        TextBox4 = New TextBox()
        project_year = New TextBox()
        urban_button = New Button()
        suburban_button = New Button()
        rural_button = New Button()
        PictureBox1 = New PictureBox()
        next_buttom_project = New Button()
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
        ' project_title
        ' 
        project_title.Location = New Point(198, 111)
        project_title.Name = "project_title"
        project_title.Size = New Size(348, 23)
        project_title.TabIndex = 6
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
        ' facility_name
        ' 
        facility_name.Location = New Point(198, 163)
        facility_name.Name = "facility_name"
        facility_name.Size = New Size(348, 23)
        facility_name.TabIndex = 8
        ' 
        ' user_name
        ' 
        user_name.Location = New Point(198, 210)
        user_name.Name = "user_name"
        user_name.Size = New Size(348, 23)
        user_name.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(198, 260)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(348, 23)
        TextBox4.TabIndex = 10
        ' 
        ' project_year
        ' 
        project_year.Location = New Point(198, 340)
        project_year.Name = "project_year"
        project_year.Size = New Size(175, 23)
        project_year.TabIndex = 11
        ' 
        ' urban_button
        ' 
        urban_button.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        urban_button.Location = New Point(198, 423)
        urban_button.Name = "urban_button"
        urban_button.Size = New Size(132, 34)
        urban_button.TabIndex = 12
        urban_button.Text = "Urban"
        urban_button.UseVisualStyleBackColor = True
        ' 
        ' suburban_button
        ' 
        suburban_button.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        suburban_button.Location = New Point(198, 466)
        suburban_button.Name = "suburban_button"
        suburban_button.Size = New Size(132, 34)
        suburban_button.TabIndex = 13
        suburban_button.Text = "Suburban"
        suburban_button.UseVisualStyleBackColor = True
        ' 
        ' rural_button
        ' 
        rural_button.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point)
        rural_button.Location = New Point(198, 509)
        rural_button.Name = "rural_button"
        rural_button.Size = New Size(132, 34)
        rural_button.TabIndex = 14
        rural_button.Text = "Rural"
        rural_button.UseVisualStyleBackColor = True
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
        ' next_buttom_project
        ' 
        next_buttom_project.BackColor = SystemColors.ControlDark
        next_buttom_project.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        next_buttom_project.Location = New Point(278, 717)
        next_buttom_project.Name = "next_buttom_project"
        next_buttom_project.Size = New Size(107, 39)
        next_buttom_project.TabIndex = 17
        next_buttom_project.Text = "Next"
        next_buttom_project.UseVisualStyleBackColor = False
        ' 
        ' projectDescription
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(next_buttom_project)
        Controls.Add(PictureBox1)
        Controls.Add(rural_button)
        Controls.Add(suburban_button)
        Controls.Add(urban_button)
        Controls.Add(project_year)
        Controls.Add(TextBox4)
        Controls.Add(user_name)
        Controls.Add(facility_name)
        Controls.Add(Label7)
        Controls.Add(project_title)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "projectDescription"
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
    Friend WithEvents project_title As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents facility_name As TextBox
    Friend WithEvents user_name As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents project_year As TextBox
    Friend WithEvents urban_button As Button
    Friend WithEvents suburban_button As Button
    Friend WithEvents rural_button As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents next_buttom_project As Button
End Class
