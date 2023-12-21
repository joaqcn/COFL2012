Imports System.IO

Public Class District
    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************
    Private Sub District_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Welcome.RoundButton(btnPrevious)
        Welcome.RoundButton(btnNext)
        'Gets the primary directory
        Welcome.PrimaryDirectory = Directory.GetCurrentDirectory()
        Welcome.InputsCorrect(2) = False
        'Calls Sub to Initialize District Form
        InitDistrict()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub




    '*************************************************************************************************************************************
    '************************************************Top Navigation Menus and Buttons*****************************************************
    '*************************************************************************************************************************************
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Welcome.ClearAll()
        InitDistrict()
        IntersectionType.InitIntType()
        My.Forms.Title.Show()
        Me.Visible = False
        Title.InitTitle()
    End Sub

    Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
        OpenFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        OpenFileDialog1.Filter = "Input files (*in)|*.in|All files (*.*)|*.*"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Welcome.FDOTin = OpenFileDialog1.FileName
            Welcome.OpenFile()
            My.Forms.Title.Show()
            Me.Visible = False
            Title.InitTitle()
            InitDistrict()
            IntersectionType.InitIntType()
        End If
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

    Private Sub TitleToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripButton.Click
        My.Forms.Title.Show()
        Welcome.FillEFArray()
        Me.Visible = False
    End Sub



    Private Sub IntersectionTypeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
        'Verifies that a district has been selected, then advances to selected form
        If Welcome.InputsCorrect(2) = True Then
            My.Forms.IntersectionType.Show()
            Welcome.FillEFArray()
            Me.Visible = False
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2012")
        End If
    End Sub


    Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
        My.Forms.About.Show()
    End Sub


    Private Sub IntersectionDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionDataToolStripButton.Click
        If Welcome.InputsCorrect(2) = True Then
            If Welcome.InputsCorrect(3) = True Then
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
                Welcome.FillEFArray()
                Me.Visible = False
            Else
                MsgBox("All intermediary screens must be completed to proceed.", 0, "CO Florida 2012")
            End If
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2012")
        End If
    End Sub



    Private Sub RunToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
        If Welcome.InputsCorrect(2) = True Then
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
                Welcome.FillEFArray()
                Me.Visible = False
            Else
                MsgBox("All intermediary screens must be completed to proceed.", 0, "CO Florida 2012")
            End If
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2012")
        End If
    End Sub



    '*************************************************************************************************************************************
    '*************************************************Sets all Buttons to Unselected******************************************************
    '*************************************************************************************************************************************
    Sub AllRegButtons()
        'Button8.Visible = False
        'Button9.Visible = False
        'Button10.Visible = False
        'Button11.Visible = False
        'Button12.Visible = False
        'Button13.Visible = False
        'Button14.Visible = False

        ''Makes main district map visible and hides all others
        'PictureBox12.Visible = True
        'PictureBox13.Visible = False
        'PictureBox14.Visible = False
        'PictureBox15.Visible = False
        'PictureBox16.Visible = False
        'PictureBox17.Visible = False
        'PictureBox18.Visible = False
        'PictureBox19.Visible = False
    End Sub




    '*************************************************************************************************************************************
    '*************************************************Initializes District Form******************************************************
    '*************************************************************************************************************************************
    Sub InitDistrict()
        'AllRegButtons()

        ''Loads Stored District Number
        Select Case Welcome.DistrictNum
            Case 1
                '        Button8.Visible = True
                '        PictureBox13.Visible = True
                Welcome.InputsCorrect(2) = True
            Case 2
                '        Button9.Visible = True
                '        PictureBox14.Visible = True
                Welcome.InputsCorrect(2) = True
            Case 3
                '        Button10.Visible = True
                '        PictureBox15.Visible = True
                Welcome.InputsCorrect(2) = True
            Case 4
                '        Button11.Visible = True
                '        PictureBox16.Visible = True
                Welcome.InputsCorrect(2) = True
            Case 5
                '        Button12.Visible = True
                '        PictureBox17.Visible = True
                Welcome.InputsCorrect(2) = True
            Case 6
                '        Button13.Visible = True
                '        PictureBox18.Visible = True
                Welcome.InputsCorrect(2) = True
            Case 7
                '        Button14.Visible = True
                '        PictureBox19.Visible = True
                Welcome.InputsCorrect(2) = True
        End Select

        ''Makes PictureBox11 visible and hides all the others
        'PictureBox11.Visible = True
        'PictureBox2.Visible = False
        'PictureBox3.Visible = False
        'PictureBox4.Visible = False
        'PictureBox5.Visible = False
        'PictureBox6.Visible = False
        'PictureBox7.Visible = False
        'PictureBox8.Visible = False
        'PictureBox9.Visible = False
        'PictureBox10.Visible = False

        ''Produces a random number to use for selecting a picturebox
        'Randomize()
        'RandNum = Int(Rnd() * 10)

        ''Makes the picturebox associated with the random number visible
        'Select Case RandNum
        '    Case 1
        '        'Do nothing
        '    Case 2
        '        PictureBox11.Visible = False
        '        PictureBox2.Visible = True
        '    Case 3
        '        PictureBox11.Visible = False
        '        PictureBox3.Visible = True
        '    Case 4
        '        PictureBox11.Visible = False
        '        PictureBox4.Visible = True
        '    Case 5
        '        PictureBox11.Visible = False
        '        PictureBox5.Visible = True
        '    Case 6
        '        PictureBox11.Visible = False
        '        PictureBox6.Visible = True
        '    Case 7
        '        PictureBox11.Visible = False
        '        PictureBox7.Visible = True
        '    Case 8
        '        PictureBox11.Visible = False
        '        PictureBox8.Visible = True
        '    Case 9
        '        PictureBox11.Visible = False
        '        PictureBox9.Visible = True
        '    Case 10
        '        PictureBox11.Visible = False
        '        PictureBox10.Visible = True
        'End Select
    End Sub




    '*************************************************************************************************************************************
    '*******************************************************Form Input Controls***********************************************************
    '*************************************************************************************************************************************
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Clears previously selected district
        AllRegButtons()

        ''Highlights the selected button
        'Button8.Visible = True

        ''Shows the district-specific map picture
        'PictureBox13.Visible = True

        Welcome.DistrictNum = 1
        Welcome.Temperature = "48.3"
        Welcome.InputsCorrect(2) = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        'Clears previously selected district
        AllRegButtons()

        ''Highlights the selected button
        'Button9.Visible = True

        ''Shows the district-specific map picture
        'PictureBox14.Visible = True

        Welcome.DistrictNum = 2
        Welcome.Temperature = "41.1"
        Welcome.InputsCorrect(2) = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Clears previously selected district
        AllRegButtons()

        ''Highlights the selected button
        'Button10.Visible = True

        ''Shows the district-specific map picture
        'PictureBox15.Visible = True

        Welcome.DistrictNum = 3
        Welcome.Temperature = "39.3"
        Welcome.InputsCorrect(2) = True
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Clears previously selected district
        AllRegButtons()

        ''Highlights the selected button
        'Button11.Visible = True

        ''Shows the district-specific map picture
        'PictureBox16.Visible = True

        Welcome.DistrictNum = 4
        Welcome.Temperature = "53.9"
        Welcome.InputsCorrect(2) = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        'Clears previously selected district
        AllRegButtons()

        ''Highlights the selected button
        'Button12.Visible = True

        ''Shows the district-specific map picture
        'PictureBox17.Visible = True

        Welcome.DistrictNum = 5
        Welcome.Temperature = "47.8"
        Welcome.InputsCorrect(2) = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        'Clears previously selected district
        AllRegButtons()

        ''Highlights the selected button
        'Button13.Visible = True

        ''Shows the district-specific map picture
        'PictureBox18.Visible = True

        Welcome.DistrictNum = 6
        Welcome.Temperature = "53.9"
        Welcome.InputsCorrect(2) = True
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        'Clears previously selected district
        AllRegButtons()

        ''Highlights the selected button
        'Button14.Visible = True

        ''Shows the district-specific map picture
        'PictureBox19.Visible = True

        Welcome.DistrictNum = 7
        Welcome.Temperature = "48.8"
        Welcome.InputsCorrect(2) = True
    End Sub


    'Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
    '    My.Forms.IntersectionType.Show()
    '    FillEFArray()
    '    Me.Visible = False
    'End Sub

    'Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
    '    My.Forms.IntersectionType.Show()
    '    FillEFArray()
    '    Me.Visible = False
    'End Sub

    'Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
    '    My.Forms.IntersectionType.Show()
    '    FillEFArray()
    '    Me.Visible = False
    'End Sub

    'Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
    '    My.Forms.IntersectionType.Show()
    '    FillEFArray()
    '    Me.Visible = False
    'End Sub

    'Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
    '    My.Forms.IntersectionType.Show()
    '    FillEFArray()
    '    Me.Visible = False
    'End Sub

    'Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
    '    My.Forms.IntersectionType.Show()
    '    FillEFArray()
    '    Me.Visible = False
    'End Sub

    'Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
    '    My.Forms.IntersectionType.Show()
    '    FillEFArray()
    '    Me.Visible = False
    'End Sub


    '******************************************************************************************************************
    '****************************************Bottom Navigation Buttons*************************************************
    '******************************************************************************************************************
    Private Sub btnPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        'Verifies that a district has been selected, then advances to selected form
        If Welcome.InputsCorrect(2) = True Then
            My.Forms.Title.Show()
            Me.Visible = False
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2012")
        End If
    End Sub


    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click

        'Verifies that a district has been selected, then advances to selected form
        If Welcome.InputsCorrect(2) = True Then
            Welcome.FillEFArray()
            My.Forms.IntersectionType.Show()
            Me.Visible = False
        Else
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2012")
        End If
    End Sub

End Class


