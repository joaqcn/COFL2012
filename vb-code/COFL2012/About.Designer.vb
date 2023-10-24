<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(About))
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(321, 80)
        Label2.Name = "Label2"
        Label2.RightToLeft = RightToLeft.No
        Label2.Size = New Size(645, 25)
        Label2.TabIndex = 1
        Label2.Text = "CO Florida 2012 is the FDOT's latest version of Florida's CO screening model"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(272, 130)
        Label3.Name = "Label3"
        Label3.Size = New Size(761, 75)
        Label3.TabIndex = 2
        Label3.Text = resources.GetString("Label3.Text")
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(160, 224)
        Label4.Name = "Label4"
        Label4.Size = New Size(1026, 50)
        Label4.TabIndex = 3
        Label4.Text = resources.GetString("Label4.Text")
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(511, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(291, 37)
        Label1.TabIndex = 4
        Label1.Text = "About CO Florida 2012"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(580, 414)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 5
        Label5.Text = "Label5"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(580, 738)
        Label6.Name = "Label6"
        Label6.Size = New Size(41, 15)
        Label6.TabIndex = 6
        Label6.Text = "Label6"
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ButtonShadow
        Button1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(1094, 767)
        Button1.Name = "Button1"
        Button1.Size = New Size(201, 39)
        Button1.TabIndex = 7
        Button1.Text = "Close ""About"""
        Button1.UseVisualStyleBackColor = False
        ' 
        ' About
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1351, 838)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "About"
        Text = "About"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
End Class
