
Imports System.Drawing.Drawing2D

Public Class Title
    Private roadType As String
    Private isClickedForFirstTime As Boolean = True



    Private Sub TextBox_Click(sender As Object, e As EventArgs) Handles TextBox1.Click, TextBox2.Click, TextBox3.Click, TextBox4.Click, TextBox5.Click
        Dim clickedTextBox As TextBox = DirectCast(sender, TextBox)

        If clickedTextBox.Tag Is Nothing OrElse CBool(clickedTextBox.Tag) = True Then
            clickedTextBox.Text = ""
            clickedTextBox.Tag = False
        End If
    End Sub

    Private Sub RoundedCornersForTextBox(textBox As TextBox)
        ' Create a GraphicsPath with rounded corners
        Dim path As New GraphicsPath()
        Dim radius As Integer = 15
        Dim rect As New Rectangle(0, 0, textBox.Width - 1, textBox.Height - 1)

        ' Add arcs to the GraphicsPath to create rounded corners
        path.AddArc(rect.Left, rect.Top, radius * 2, radius * 2, 180, 90) ' Top-left corner
        path.AddArc(rect.Right - radius * 2, rect.Top, radius * 2, radius * 2, 270, 90) ' Top-right corner
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90) ' Bottom-right corner
        path.AddArc(rect.Left, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90) ' Bottom-left corner

        ' Close the path
        path.CloseFigure()

        ' Set the region of the TextBox to the created path
        textBox.Region = New Region(path)
    End Sub

    Private Sub getDataFromTitle()
        Welcome.Job = TextBox1.Text
        Welcome.FacilityName = TextBox2.Text
        Welcome.Job = TextBox1.Text
        Welcome.FacilityName = TextBox2.Text
        Welcome.UsersName = TextBox3.Text
        Welcome.RunName = TextBox4.Text
        Welcome.ProjectYear = TextBox5.Text
        Welcome.LandUse = roadType
    End Sub

    Private Sub urban_button_Click(sender As Object, e As EventArgs)
        roadType = "Urban"

    End Sub

    Private Sub suburban_button_Click(sender As Object, e As EventArgs)
        roadType = "Suburban"
    End Sub

    Private Sub rural_button_Click(sender As Object, e As EventArgs)
        roadType = "Rural"
    End Sub



    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************
    Private Sub Title_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RoundedCornersForTextBox(TextBox1)
        RoundedCornersForTextBox(TextBox2)
        RoundedCornersForTextBox(TextBox3)
        RoundedCornersForTextBox(TextBox4)
        RoundedCornersForTextBox(TextBox5)
        Welcome.RoundButton(Button1)
        Welcome.RoundButton(Button2)
        Welcome.RoundButton(Button3)
        Welcome.RoundButton(Button4)

        'Calls the subroutine to initialize the Title Form
        InitTitle()


    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub



    '*************************************************************************************************************************************
    '************************************************Top Navigation Menus and Buttons*****************************************************
    '*************************************************************************************************************************************

    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Welcome.ClearAll()
        District.InitDistrict()
        IntersectionType.InitIntType()
        InitTitle()
    End Sub

    Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'Writes user program run inputs to text file

        SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
        SaveFileDialog1.FileName = ""

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Welcome.FDOTin = SaveFileDialog1.FileName
            Welcome.SaveFile()
        End If
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        OpenFileDialog1.Filter = "Input files (*in)|*.in|All files (*.*)|*.*"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Welcome.FDOTin = OpenFileDialog1.FileName
            Welcome.OpenFile()
            InitTitle()
            District.InitDistrict()
            IntersectionType.InitIntType()
        End If
    End Sub


    Private Sub DistrictToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictToolStripButton.Click
        'Call the routine to check form inputs
        VerifyTitleForm()

        'Verifies that all fields have been completed, then advances to selected form
        If Welcome.InputsCorrect(1) = True Then
            My.Forms.District.Show()
            Me.Visible = False
        Else
            MsgBox("All fields must be completed to proceed.", 0, "CO Florida 2012")
        End If
    End Sub


    Private Sub IntersectionTypeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
        'Call the routine to check form inputs
        VerifyTitleForm()

        'Verifies that all fields have been completed, then advances to selected form
        If Welcome.InputsCorrect(1) = True Then
            If Welcome.InputsCorrect(2) = True Then
                My.Forms.IntersectionType.Show()
                Me.Visible = False
            Else
                MsgBox("All intermediary screens must be completed to proceed.", 0, "CO Florida 2012")
            End If
        Else
            MsgBox("All fields must be completed to proceed.", 0, "CO Florida 2012")
        End If
    End Sub


    Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
        My.Forms.About.Show()
    End Sub

    Private Sub IntersectionDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionDataToolStripButton.Click
        'Call the routine to check form inputs
        VerifyTitleForm()

        If Welcome.InputsCorrect(1) = True Then
            If (Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True) Then
                Select Case Welcome.IntType
                    Case ""
                        My.Forms._4X4.Show()
                    Case "4 X 4"
                        My.Forms._4X4.Show()
                    Case "4 X 6"
                        My.Forms._4X6.Show()
                    Case "6 X 4"
                        My.Forms._6X4.Show()
                    Case "6 X 6"
                        My.Forms._6X6.Show()
                    Case "East Tee"
                        My.Forms.East_Tee.Show()
                    Case "North Tee"
                        My.Forms.North_Tee.Show()
                    Case "Toll Booth"
                        My.Forms.TollBoothEW.Show()
                    Case "West Tee"
                        My.Forms.WestTee.Show()
                    Case "South Tee"
                        My.Forms.SouthTee.Show()
                    Case "N-S Diamond"
                        My.Forms.NorthSouthFreeway.Show()
                    Case "E-W Diamond"
                        My.Forms.EastWestFreeway.Show()
                End Select

                Me.Visible = False
            Else
                MsgBox("All intermediary screens must be completed to proceed.", 0, "CO Florida 2012")
            End If
        Else
            MsgBox("All fields must be completed to proceed.", 0, "CO Florida 2012")
        End If
    End Sub

    Private Sub RunToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
        'Call the routine to check form inputs
        VerifyTitleForm()

        If Welcome.InputsCorrect(1) = True Then
            If (Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4)) Then
                Select Case Welcome.IntType
                    Case ""
                        My.Forms._4X4.Show()
                    Case "4 X 4"
                        My.Forms._4X4.Show()
                    Case "4 X 6"
                        My.Forms._4X6.Show()
                    Case "6 X 4"
                        My.Forms._6X4.Show()
                    Case "6 X 6"
                        My.Forms._6X6.Show()
                    Case "East Tee"
                        My.Forms.East_Tee.Show()
                    Case "North Tee"
                        My.Forms.North_Tee.Show()
                    Case "Toll Booth"
                        My.Forms.TollBoothEW.Show()
                    Case "West Tee"
                        My.Forms.WestTee.Show()
                    Case "South Tee"
                        My.Forms.SouthTee.Show()
                    Case "N-S Diamond"
                        My.Forms.NorthSouthFreeway.Show()
                    Case "E-W Diamond"
                        My.Forms.EastWestFreeway.Show()
                End Select

                Me.Visible = False
            Else
                MsgBox("All intermediary screens must be completed to proceed.", 0, "CO Florida 2012")
            End If
        Else
            MsgBox("All fields must be completed to proceed.", 0, "CO Florida 2012")
        End If
    End Sub



    '*************************************************************************************************************************************
    '*************************************************Sets all Buttons to Unselected******************************************************
    '*************************************************************************************************************************************
    Sub AllRegButtons()

        Button1.Visible = True
        Button2.Visible = True
        Button3.Visible = True
        Button4.Visible = True

    End Sub


    '*************************************************************************************************************************************
    '*************************************************Initializes the Title Form******************************************************
    '*************************************************************************************************************************************
    Sub InitTitle()
        AllRegButtons()

        'Loads all stored variables
        TextBox1.Text = Welcome.Job
        TextBox2.Text = Welcome.FacilityName
        TextBox3.Text = Welcome.UsersName
        TextBox4.Text = Welcome.RunName
        TextBox5.Text = Welcome.ProjectYear

        ''Select Case WLandUse
        'Case "Urban"
        '        Button4.Visible = True
        '        Button1.Visible = False
        '    Case "Suburban"
        '        Button5.Visible = True
        '        Button2.Visible = False
        '    Case "Rural"
        '        Button6.Visible = True
        '        Button3.Visible = False
        'End Select

        ''Sets picturebox1 to visible and hides the rest
        'PictureBox1.Visible = True
        'PictureBox2.Visible = False
        'PictureBox3.Visible = False
        'PictureBox4.Visible = False
        'PictureBox5.Visible = False
        'PictureBox6.Visible = False
        'PictureBox7.Visible = False
        'PictureBox8.Visible = False
        'PictureBox9.Visible = False
        'PictureBox10.Visible = False
        'PictureBox11.Visible = False
        'PictureBox12.Visible = False
        'PictureBox13.Visible = False
        'PictureBox14.Visible = False
        'PictureBox15.Visible = False
        'PictureBox16.Visible = False
        'PictureBox17.Visible = False
        'PictureBox18.Visible = False
        'PictureBox19.Visible = False
        'PictureBox20.Visible = False

        ''Creates a random number to choose the picturebox to display
        'Randomize()
        'RandNum = Int(Rnd() * 20)

        'Select Case RandNum
        '    Case 1
        '        'Do nothing
        '    Case 2
        '        PictureBox1.Visible = False
        '        PictureBox2.Visible = True
        '    Case 3
        '        PictureBox1.Visible = False
        '        PictureBox3.Visible = True
        '    Case 4
        '        PictureBox1.Visible = False
        '        PictureBox4.Visible = True
        '    Case 5
        '        PictureBox1.Visible = False
        '        PictureBox5.Visible = True
        '    Case 6
        '        PictureBox1.Visible = False
        '        PictureBox6.Visible = True
        '    Case 7
        '        PictureBox1.Visible = False
        '        PictureBox7.Visible = True
        '    Case 8
        '        PictureBox1.Visible = False
        '        PictureBox8.Visible = True
        '    Case 9
        '        PictureBox1.Visible = False
        '        PictureBox9.Visible = True
        '    Case 10
        '        PictureBox1.Visible = False
        '        PictureBox10.Visible = True
        '    Case 11
        '        PictureBox1.Visible = False
        '        PictureBox11.Visible = True
        '    Case 12
        '        PictureBox1.Visible = False
        '        PictureBox12.Visible = True
        '    Case 13
        '        PictureBox1.Visible = False
        '        PictureBox13.Visible = True
        '    Case 14
        '        PictureBox1.Visible = False
        '        PictureBox14.Visible = True
        '    Case 15
        '        PictureBox1.Visible = False
        '        PictureBox15.Visible = True
        '    Case 16
        '        PictureBox1.Visible = False
        '        PictureBox16.Visible = True
        '    Case 17
        '        PictureBox1.Visible = False
        '        PictureBox17.Visible = True
        '    Case 18
        '        PictureBox1.Visible = False
        '        PictureBox18.Visible = True
        '    Case 19
        '        PictureBox1.Visible = False
        '        PictureBox19.Visible = True
        '    Case 20
        '        PictureBox1.Visible = False
        '        PictureBox20.Visible = True
        'End Select
    End Sub


    '*************************************************************************************************************************************
    '*******************************************************Form Input Controls***********************************************************
    '*************************************************************************************************************************************
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Welcome.Job = TextBox1.Text

        'Verifies that Job length does not exceed 40 characters
        If Len(Welcome.Job) > 40 Then
            MsgBox("Please note: The Project Title may not exceed 40 characters in length.", 0, "CO Florida 2012")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Welcome.FacilityName = TextBox2.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Welcome.UsersName = TextBox3.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Welcome.RunName = TextBox4.Text

        'Verifies that RunName length does not exceed 40 characters
        If Len(Welcome.RunName) > 40 Then
            MsgBox("Please note: The Run Name may not exceed 40 characters in length.", 0, "CO Florida 2012")
        End If
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Welcome.ProjectYear = TextBox5.Text
    End Sub


    'Land Use Selection Buttons
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        AllRegButtons()

        'Highlights the selected button and assigns global variable values
        'Button4.Visible = True
        'Button1.Visible = False
        Button1.BackColor = Color.Gray
        Button2.BackColor = DefaultBackColor
        Button3.BackColor = DefaultBackColor

        Welcome.LandUse = "Urban"
        Welcome.ZO = 175
        Welcome.CLAS = 4
        Welcome.CLASLetter = "D"
        Welcome.COBack1Hr = "5.0"
        Welcome.COBack8Hr = "3.0"
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


        AllRegButtons()

        'Highlights the selected button and assigns global variable values
        'Button5.Visible = True
        'Button2.Visible = False

        Button1.BackColor = DefaultBackColor
        Button2.BackColor = Color.Gray
        Button3.BackColor = DefaultBackColor

        Welcome.LandUse = "Suburban"
        Welcome.ZO = 108
        Welcome.CLAS = 4
        Welcome.CLASLetter = "D"
        Welcome.COBack1Hr = "3.3"
        Welcome.COBack8Hr = "2.0"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        AllRegButtons()

        'Highlights the selected button and assigns global variable values
        'Button6.Visible = True
        'Button3.Visible = False
        Button1.BackColor = DefaultBackColor
        Button2.BackColor = DefaultBackColor
        Button3.BackColor = Color.Gray


        Welcome.LandUse = "Rural"
        Welcome.ZO = 10
        Welcome.CLAS = 5
        Welcome.CLASLetter = "E"
        Welcome.COBack1Hr = "1.7"
        Welcome.COBack8Hr = "1.0"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call the routine to check form inputs
        VerifyTitleForm()

        If Welcome.InputsCorrect(1) = True Then
            My.Forms.District.Show()
            Me.Visible = False
        End If
    End Sub

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    'Call the routine to check form inputs
    '    VerifyTitleForm()

    '    If Welcome.InputsCorrect(1) = True Then
    '        My.Forms.District.Show()
    '        Me.Visible = False
    '    End If
    'End Sub

    'Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
    '    'Call the routine to check form inputs
    '    VerifyTitleForm()

    '    If InputsCorrect(1) = True Then
    '        My.Forms.District.Show()
    '        Me.Visible = False
    '    End If
    'End Sub



    '******************************************************************************************************************
    '********************************Verifies that Form Inputs are Appropriate*****************************************
    '******************************************************************************************************************
    Sub VerifyTitleForm()

        InitTitle()
        Welcome.InputsCorrect(1) = False

        'Verifies that ProjectYear has a numeric value
        Try
            Welcome.ProjectYear = CInt(TextBox5.Text)
        Catch ex As Exception
            MsgBox("The Project Year must be between 2010 and 2050.  Please re-enter.", 0, "CO Florida 2012")
            TextBox5.Text = ""
            Exit Sub
        End Try

        'Verifies that all fields have been completed and that ProjectYear is between 2010 and 2050
        If Welcome.Job = "" Or Welcome.FacilityName = "" Or Welcome.UsersName = "" Or Welcome.RunName = "" Or Welcome.ProjectYear = "" Or Welcome.LandUse = "" Then
            MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
            Welcome.InputsCorrect(1) = False
        Else
            If Welcome.ProjectYear < 2010 Or Welcome.ProjectYear > 2050 Then
                MsgBox("The Project Year must be an integer between 2010 and 2050.  Please re-enter.", 0, "CO Florida 2012")
                Welcome.InputsCorrect(1) = False
            Else
                Welcome.InputsCorrect(1) = True
            End If
        End If
    End Sub



    '******************************************************************************************************************
    '****************************************Bottom Navigation Buttons*************************************************
    '******************************************************************************************************************
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'Call the routine to check form inputs
        VerifyTitleForm()

        'Verifies that all fields have been completed, then advances to selected form
        If Welcome.InputsCorrect(1) = True Then
            My.Forms.District.Show()
            Me.Visible = False
        Else
            MsgBox("All fields must be completed to proceed.", 0, "CO Florida 2012")
        End If
    End Sub

End Class


