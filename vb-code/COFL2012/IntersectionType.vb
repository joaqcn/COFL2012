Imports System
Imports System.IO
Imports System.Collections

Public Class IntersectionType
    Private Sub PictureBox_Click(sender As Object, e As EventArgs)
        Select Case DirectCast(sender, PictureBox).Name
            Case "fourByFourPic"
                Dim fourByFour As New _4X4()
                Welcome.IntType = "4X4"
                Me.Hide()
                fourByFour.Show()
            Case "fourbySixPic"
                ' Codfor fourbySixPic
                Dim fourBySix As New _4X6()
                Welcome.IntType = "4X6"
                Me.Hide()
                fourBySix.Show()
            Case "sixByFourPic"
                Dim sixByFour As New _6X4()
                Welcome.IntType = "6X4"
                Me.Hide()
                sixByFour.Show()
            Case "sixBySixPic"
                Dim sixBySix As New _6X6()
                Welcome.IntType = "6X6"
                Me.Hide()
                sixBySix.Show()
            Case "eastTeePic"
                Dim eastTee As New East_Tee()
                Welcome.IntType = "East Tee"
                Me.Hide()
                eastTee.Show()
            Case "northTeePic"
                Dim northTee As New North_Tee()
                Welcome.IntType = "North Tee"
                Me.Hide()
                northTee.Show()
            Case "tollBoothPic"
                Dim tollBooth As New TollBoothEW()
                Welcome.IntType = "Toll Booth"
                Me.Hide()
                tollBooth.Show()
            Case "westTeePic"
                Dim westTee As New WestTee()
                Welcome.IntType = "West Tee"
                Me.Hide()
                westTee.Show()
            Case "southTeePic"
                ' Code for southTeePic
                Dim southTee As New SouthTee()
                Welcome.IntType = "South Tee"
                Me.Hide()
                southTee.Show()
            Case "northSouthFreewayPic"
                Dim northSouthFreeway As New NorthSouthFreeway()
                Welcome.IntType = "Diamond Interchange N-S Freeway"
                Me.Hide()
                northSouthFreeway.Show()
            Case "eastWestFreewayPic"
                Dim eastWestFreeway As New EastWestFreeway()
                Welcome.IntType = "Diamond Interchange E-W Freeway"
                Me.Hide()
                eastWestFreeway.Show()
        End Select
    End Sub

    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************
    Private Sub IntersectionType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitIntType()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub





    ''*************************************************************************************************************************************
    ''************************************************Top Navigation Menus and Buttons*****************************************************
    ''*************************************************************************************************************************************
    Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
        Welcome.ClearAll()
        District.InitDistrict()
        InitIntType()
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
            District.InitDistrict()
            InitIntType()
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
        Me.Visible = False
    End Sub


    Private Sub DistrictToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictToolStripButton.Click
        My.Forms.District.Show()
        Me.Visible = False
    End Sub


    Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
        My.Forms.About.Show()
    End Sub

    Private Sub IntersectionDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionDataToolStripButton.Click
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

            Me.Visible = False
        Else
            MsgBox("Please select an intersection type to proceed.", 0, "CO Florida 2012")
        End If

    End Sub

    Private Sub RunToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
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

            Me.Visible = False
        Else
            MsgBox("Please select an intersection type to proceed.", 0, "CO Florida 2012")
        End If
    End Sub




    '*************************************************************************************************************************************
    '**************************************************Form Input Control Subroutines*****************************************************
    '*************************************************************************************************************************************
    Private Sub Select4X4()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "4 X 4"

        'First, clears out any big pictures
        ' AllSmallPics()

        'Next, shows the big picture for this intersection
        '        PictureBox12.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 40
        Welcome.XR(2) = 40
        Welcome.XR(3) = 40
        Welcome.XR(4) = 80
        Welcome.XR(5) = 180
        Welcome.XR(6) = 180
        Welcome.XR(7) = 80
        Welcome.XR(8) = 40
        Welcome.XR(9) = 40
        Welcome.XR(10) = 40
        Welcome.XR(11) = -40
        Welcome.XR(12) = -40
        Welcome.XR(13) = -40
        Welcome.XR(14) = -80
        Welcome.XR(15) = -180
        Welcome.XR(16) = -180
        Welcome.XR(17) = -80
        Welcome.XR(18) = -40
        Welcome.XR(19) = -40
        Welcome.XR(20) = -40
        Welcome.YR(1) = 180
        Welcome.YR(2) = 80
        Welcome.YR(3) = 40
        Welcome.YR(4) = 40
        Welcome.YR(5) = 40
        Welcome.YR(6) = -40
        Welcome.YR(7) = -40
        Welcome.YR(8) = -40
        Welcome.YR(9) = -80
        Welcome.YR(10) = -180
        Welcome.YR(11) = -180
        Welcome.YR(12) = -80
        Welcome.YR(13) = -40
        Welcome.YR(14) = -40
        Welcome.YR(15) = -40
        Welcome.YR(16) = 40
        Welcome.YR(17) = 40
        Welcome.YR(18) = 40
        Welcome.YR(19) = 80
        Welcome.YR(20) = 180
    End Sub



    Private Sub Select4X6()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "4 X 6"

        'First, clears out any big pictures
        'AllSmallPics()

        'Next, shows the big picture for this intersection
        'PictureBox13.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 58
        Welcome.XR(2) = 58
        Welcome.XR(3) = 58
        Welcome.XR(4) = 98
        Welcome.XR(5) = 198
        Welcome.XR(6) = 198
        Welcome.XR(7) = 98
        Welcome.XR(8) = 58
        Welcome.XR(9) = 58
        Welcome.XR(10) = 58
        Welcome.XR(11) = -58
        Welcome.XR(12) = -58
        Welcome.XR(13) = -58
        Welcome.XR(14) = -98
        Welcome.XR(15) = -198
        Welcome.XR(16) = -198
        Welcome.XR(17) = -98
        Welcome.XR(18) = -58
        Welcome.XR(19) = -58
        Welcome.XR(20) = -58
        Welcome.YR(1) = 180
        Welcome.YR(2) = 80
        Welcome.YR(3) = 40
        Welcome.YR(4) = 40
        Welcome.YR(5) = 40
        Welcome.YR(6) = -40
        Welcome.YR(7) = -40
        Welcome.YR(8) = -40
        Welcome.YR(9) = -80
        Welcome.YR(10) = -180
        Welcome.YR(11) = -180
        Welcome.YR(12) = -80
        Welcome.YR(13) = -40
        Welcome.YR(14) = -40
        Welcome.YR(15) = -40
        Welcome.YR(16) = 40
        Welcome.YR(17) = 40
        Welcome.YR(18) = 40
        Welcome.YR(19) = 80
        Welcome.YR(20) = 180
    End Sub



    Private Sub Select6X4()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "6 X 4"

        'First, clears out any big pictures
        ' AllSmallPics()

        'Next, shows the big picture for this intersection
        ' PictureBox14.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 40
        Welcome.XR(2) = 40
        Welcome.XR(3) = 40
        Welcome.XR(4) = 80
        Welcome.XR(5) = 180
        Welcome.XR(6) = 180
        Welcome.XR(7) = 80
        Welcome.XR(8) = 40
        Welcome.XR(9) = 40
        Welcome.XR(10) = 40
        Welcome.XR(11) = -40
        Welcome.XR(12) = -40
        Welcome.XR(13) = -40
        Welcome.XR(14) = -80
        Welcome.XR(15) = -180
        Welcome.XR(16) = -180
        Welcome.XR(17) = -80
        Welcome.XR(18) = -40
        Welcome.XR(19) = -40
        Welcome.XR(20) = -40
        Welcome.YR(1) = 198
        Welcome.YR(2) = 98
        Welcome.YR(3) = 58
        Welcome.YR(4) = 58
        Welcome.YR(5) = 58
        Welcome.YR(6) = -58
        Welcome.YR(7) = -58
        Welcome.YR(8) = -58
        Welcome.YR(9) = -98
        Welcome.YR(10) = -198
        Welcome.YR(11) = -198
        Welcome.YR(12) = -98
        Welcome.YR(13) = -58
        Welcome.YR(14) = -58
        Welcome.YR(15) = -58
        Welcome.YR(16) = 58
        Welcome.YR(17) = 58
        Welcome.YR(18) = 58
        Welcome.YR(19) = 98
        Welcome.YR(20) = 198
    End Sub



    Private Sub Select6X6()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "6 X 6"

        'First, clears out any big pictures
        'AllSmallPics()

        'Next, shows the big picture for this intersection
        'PictureBox15.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 58
        Welcome.XR(2) = 58
        Welcome.XR(3) = 58
        Welcome.XR(4) = 98
        Welcome.XR(5) = 198
        Welcome.XR(6) = 198
        Welcome.XR(7) = 98
        Welcome.XR(8) = 58
        Welcome.XR(9) = 58
        Welcome.XR(10) = 58
        Welcome.XR(11) = -58
        Welcome.XR(12) = -58
        Welcome.XR(13) = -58
        Welcome.XR(14) = -98
        Welcome.XR(15) = -198
        Welcome.XR(16) = -198
        Welcome.XR(17) = -98
        Welcome.XR(18) = -58
        Welcome.XR(19) = -58
        Welcome.XR(20) = -58
        Welcome.YR(1) = 198
        Welcome.YR(2) = 98
        Welcome.YR(3) = 58
        Welcome.YR(4) = 58
        Welcome.YR(5) = 58
        Welcome.YR(6) = -58
        Welcome.YR(7) = -58
        Welcome.YR(8) = -58
        Welcome.YR(9) = -98
        Welcome.YR(10) = -198
        Welcome.YR(11) = -198
        Welcome.YR(12) = -98
        Welcome.YR(13) = -58
        Welcome.YR(14) = -58
        Welcome.YR(15) = -58
        Welcome.YR(16) = 58
        Welcome.YR(17) = 58
        Welcome.YR(18) = 58
        Welcome.YR(19) = 98
        Welcome.YR(20) = 198
    End Sub



    Private Sub SelectEastTee()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "East Tee"

        'First, clears out any big pictures
        'AllSmallPics()

        'Next, shows the big picture for this intersection
        'PictureBox16.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 40
        Welcome.XR(2) = 40
        Welcome.XR(3) = 40
        Welcome.XR(4) = 80
        Welcome.XR(5) = 180
        Welcome.XR(6) = 180
        Welcome.XR(7) = 80
        Welcome.XR(8) = 40
        Welcome.XR(9) = 40
        Welcome.XR(10) = 40
        Welcome.XR(11) = -40
        Welcome.XR(12) = -40
        Welcome.XR(13) = -40
        Welcome.XR(14) = -40
        Welcome.XR(15) = -40
        Welcome.XR(16) = -40
        Welcome.XR(17) = -40
        Welcome.XR(18) = 999
        Welcome.XR(19) = 999
        Welcome.XR(20) = 999
        Welcome.YR(1) = 186
        Welcome.YR(2) = 86
        Welcome.YR(3) = 46
        Welcome.YR(4) = 46
        Welcome.YR(5) = 46
        Welcome.YR(6) = -46
        Welcome.YR(7) = -46
        Welcome.YR(8) = -46
        Welcome.YR(9) = -86
        Welcome.YR(10) = -186
        Welcome.YR(11) = -186
        Welcome.YR(12) = -86
        Welcome.YR(13) = -24
        Welcome.YR(14) = 0
        Welcome.YR(15) = 24
        Welcome.YR(16) = 86
        Welcome.YR(17) = 186
        Welcome.YR(18) = 999
        Welcome.YR(19) = 999
        Welcome.YR(20) = 999
    End Sub



    Private Sub SelectNorthTee()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "North Tee"

        'First, clears out any big pictures
        'AllSmallPics()

        'Next, shows the big picture for this intersection
        'PictureBox17.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 46
        Welcome.XR(2) = 46
        Welcome.XR(3) = 46
        Welcome.XR(4) = 86
        Welcome.XR(5) = 186
        Welcome.XR(6) = 186
        Welcome.XR(7) = 86
        Welcome.XR(8) = 24
        Welcome.XR(9) = 0
        Welcome.XR(10) = -24
        Welcome.XR(11) = -86
        Welcome.XR(12) = -186
        Welcome.XR(13) = -186
        Welcome.XR(14) = -86
        Welcome.XR(15) = -40
        Welcome.XR(16) = -40
        Welcome.XR(17) = -40
        Welcome.XR(18) = 999
        Welcome.XR(19) = 999
        Welcome.XR(20) = 999
        Welcome.YR(1) = 180
        Welcome.YR(2) = 80
        Welcome.YR(3) = 40
        Welcome.YR(4) = 40
        Welcome.YR(5) = 40
        Welcome.YR(6) = -40
        Welcome.YR(7) = -40
        Welcome.YR(8) = -40
        Welcome.YR(9) = -40
        Welcome.YR(10) = -40
        Welcome.YR(11) = -40
        Welcome.YR(12) = -40
        Welcome.YR(13) = 40
        Welcome.YR(14) = 40
        Welcome.YR(15) = 40
        Welcome.YR(16) = 80
        Welcome.YR(17) = 180
        Welcome.YR(18) = 999
        Welcome.YR(19) = 999
        Welcome.YR(20) = 999
    End Sub



    Private Sub SelectTollBooth()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "Toll Booth"

        'First, clears out any big pictures
        'AllSmallPics()

        'Next, shows the big picture for this intersection
        ' PictureBox18.Visible = True
    End Sub


    Private Sub SelectWestTee()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "West Tee"

        'First, clears out any big pictures
        'AllSmallPics()

        'Next, shows the big picture for this intersection

        'PictureBox19.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 40
        Welcome.XR(2) = 40
        Welcome.XR(3) = 40
        Welcome.XR(4) = 40
        Welcome.XR(5) = 40
        Welcome.XR(6) = 40
        Welcome.XR(7) = 40
        Welcome.XR(8) = -40
        Welcome.XR(9) = -40
        Welcome.XR(10) = -40
        Welcome.XR(11) = -80
        Welcome.XR(12) = -180
        Welcome.XR(13) = -180
        Welcome.XR(14) = -80
        Welcome.XR(15) = -40
        Welcome.XR(16) = -40
        Welcome.XR(17) = -40
        Welcome.XR(18) = 999
        Welcome.XR(19) = 999
        Welcome.XR(20) = 999
        Welcome.YR(1) = 186
        Welcome.YR(2) = 86
        Welcome.YR(3) = 24
        Welcome.YR(4) = 0
        Welcome.YR(5) = -24
        Welcome.YR(6) = -86
        Welcome.YR(7) = -186
        Welcome.YR(8) = -186
        Welcome.YR(9) = -86
        Welcome.YR(10) = -46
        Welcome.YR(11) = -46
        Welcome.YR(12) = -46
        Welcome.YR(13) = 46
        Welcome.YR(14) = 46
        Welcome.YR(15) = 46
        Welcome.YR(16) = 86
        Welcome.YR(17) = 186
        Welcome.YR(18) = 999
        Welcome.YR(19) = 999
        Welcome.YR(20) = 999
    End Sub



    Private Sub SelectSouthTee()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "South Tee"

        'First, clears out any big pictures
        'AllSmallPics()
        'Next, shows the big picture for this intersection
        'PictureBox20.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = -186
        Welcome.XR(2) = -86
        Welcome.XR(3) = -24
        Welcome.XR(4) = 0
        Welcome.XR(5) = 24
        Welcome.XR(6) = 86
        Welcome.XR(7) = 186
        Welcome.XR(8) = 186
        Welcome.XR(9) = 86
        Welcome.XR(10) = 46
        Welcome.XR(11) = 46
        Welcome.XR(12) = 46
        Welcome.XR(13) = -46
        Welcome.XR(14) = -46
        Welcome.XR(15) = -46
        Welcome.XR(16) = -86
        Welcome.XR(17) = -186
        Welcome.XR(18) = 999
        Welcome.XR(19) = 999
        Welcome.XR(20) = 999
        Welcome.YR(1) = 40
        Welcome.YR(2) = 40
        Welcome.YR(3) = 40
        Welcome.YR(4) = 40
        Welcome.YR(5) = 40
        Welcome.YR(6) = 40
        Welcome.YR(7) = 40
        Welcome.YR(8) = -40
        Welcome.YR(9) = -40
        Welcome.YR(10) = -40
        Welcome.YR(11) = -80
        Welcome.YR(12) = -180
        Welcome.YR(13) = -180
        Welcome.YR(14) = -80
        Welcome.YR(15) = -40
        Welcome.YR(16) = -40
        Welcome.YR(17) = -40
        Welcome.YR(18) = 999
        Welcome.YR(19) = 999
        Welcome.YR(20) = 999
    End Sub



    Private Sub SelectNSDiamond()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "N-S Diamond"

        'First, clears out any big pictures
        '  AllSmallPics()

        'Next, shows the big picture for this intersection
        '  PictureBox21.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 46
        Welcome.XR(2) = 116
        Welcome.XR(3) = 166
        Welcome.XR(4) = 261
        Welcome.XR(5) = 361
        Welcome.XR(6) = 361
        Welcome.XR(7) = 261
        Welcome.XR(8) = 166
        Welcome.XR(9) = 116
        Welcome.XR(10) = 46
        Welcome.XR(11) = -46
        Welcome.XR(12) = -116
        Welcome.XR(13) = -166
        Welcome.XR(14) = -261
        Welcome.XR(15) = -361
        Welcome.XR(16) = -361
        Welcome.XR(17) = -261
        Welcome.XR(18) = -166
        Welcome.XR(19) = -116
        Welcome.XR(20) = -46
        Welcome.YR(1) = 1036
        Welcome.YR(2) = 336
        Welcome.YR(3) = 46
        Welcome.YR(4) = 46
        Welcome.YR(5) = 46
        Welcome.YR(6) = -46
        Welcome.YR(7) = -46
        Welcome.YR(8) = -46
        Welcome.YR(9) = -336
        Welcome.YR(10) = -1036
        Welcome.YR(11) = -1036
        Welcome.YR(12) = -336
        Welcome.YR(13) = -46
        Welcome.YR(14) = -46
        Welcome.YR(15) = -46
        Welcome.YR(16) = 46
        Welcome.YR(17) = 46
        Welcome.YR(18) = 46
        Welcome.YR(19) = 336
        Welcome.YR(20) = 1036
    End Sub



    Private Sub SelectEWDiamond()
        Welcome.InputsCorrect(3) = True
        Welcome.IntType = "E-W Diamond"

        'First, clears out any big pictures
        '   AllSmallPics()

        'Next, shows the big picture for this intersection
        '   PictureBox22.Visible = True

        'Fills the receptor coordinate arrays for selected intersection type
        Welcome.XR(1) = 46
        Welcome.XR(2) = 46
        Welcome.XR(3) = 46
        Welcome.XR(4) = 336
        Welcome.XR(5) = 1036
        Welcome.XR(6) = 1036
        Welcome.XR(7) = 336
        Welcome.XR(8) = 46
        Welcome.XR(9) = 46
        Welcome.XR(10) = 46
        Welcome.XR(11) = -46
        Welcome.XR(12) = -46
        Welcome.XR(13) = -46
        Welcome.XR(14) = -336
        Welcome.XR(15) = -1036
        Welcome.XR(16) = -1036
        Welcome.XR(17) = -336
        Welcome.XR(18) = -46
        Welcome.XR(19) = -46
        Welcome.XR(20) = -46
        Welcome.YR(1) = 361
        Welcome.YR(2) = 261
        Welcome.YR(3) = 166
        Welcome.YR(4) = 116
        Welcome.YR(5) = 46
        Welcome.YR(6) = -46
        Welcome.YR(7) = -116
        Welcome.YR(8) = -166
        Welcome.YR(9) = -261
        Welcome.YR(10) = -361
        Welcome.YR(11) = -361
        Welcome.YR(12) = -261
        Welcome.YR(13) = -166
        Welcome.YR(14) = -116
        Welcome.YR(15) = -46
        Welcome.YR(16) = 46
        Welcome.YR(17) = 116
        Welcome.YR(18) = 166
        Welcome.YR(19) = 261
        Welcome.YR(20) = 361
    End Sub



    '*************************************************************************************************************************************
    '********************************************Sets all Picture Buttons to Unselected***************************************************
    '*************************************************************************************************************************************
    Sub AllSmallPics()
        'PictureBox12.Visible = False
        'PictureBox13.Visible = False
        'PictureBox14.Visible = False
        'PictureBox15.Visible = False
        'PictureBox16.Visible = False
        'PictureBox17.Visible = False
        'PictureBox18.Visible = False
        'PictureBox19.Visible = False
        'PictureBox20.Visible = False
        'PictureBox21.Visible = False
        'PictureBox22.Visible = False
    End Sub



    '*************************************************************************************************************************************
    '********************************************Initializes Intersection Type Form*******************************************************
    '************************************************************************************************************************************
    Sub InitIntType()
        AllSmallPics()

        ''Loads Stored Intersection Type
        'Select Case Welcome.IntType
        '    Case "4 X 4"
        '        PictureBox12.Visible = True
        '    Case "4 X 6"
        '        PictureBox13.Visible = True
        '    Case "6 X 4"
        '        PictureBox14.Visible = True
        '    Case "6 X 6"
        '        PictureBox15.Visible = True
        '    Case "East Tee"
        '        PictureBox16.Visible = True
        '    Case "North Tee"
        '        PictureBox17.Visible = True
        '    Case "Toll Booth"
        '        PictureBox18.Visible = True
        '    Case "West Tee"
        '        PictureBox19.Visible = True
        '    Case "South Tee"
        '        PictureBox20.Visible = True
        '    Case "N-S Diamond"
        '        PictureBox21.Visible = True
        '    Case "E-W Diamond"
        '        PictureBox22.Visible = True
        'End Select
    End Sub


    '******************************************************************************************************************
    '****************************************Bottom Navigation Buttons*************************************************
    '******************************************************************************************************************
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.District.Show()
        Me.Visible = False
    End Sub

    Private Sub btnNext_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Verifies that an intersection type has been selected, then advanced to the appropriate intersection data page
        If Welcome.InputsCorrect(3) = True Then
            Select Case Welcome.IntType
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
            MsgBox("Please select a district to proceed.", 0, "CO Florida 2012")
        End If
    End Sub




    '*************************************************************************************************************************************
    '************************************************User Clicks that Fire Subroutines****************************************************
    '*************************************************************************************************************************************

    'Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
    '    Select4X4()
    'End Sub

    'Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
    '    Select4X6()
    'End Sub

    'Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
    '    Select6X4()
    'End Sub

    'Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
    '    Select6X6()
    'End Sub

    'Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
    '    SelectEastTee()
    'End Sub

    'Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
    '    SelectNorthTee()
    'End Sub

    'Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
    '    SelectTollBooth()
    'End Sub

    'Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
    '    SelectWestTee()
    'End Sub

    'Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
    '    SelectSouthTee()
    'End Sub

    'Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SelectNSDiamond()
    'End Sub

    'Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    SelectEWDiamond()
    'End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Select4X4()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Select4X6()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Select6X4()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Select6X6()
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        SelectEastTee()
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click
        SelectNorthTee()
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click
        SelectTollBooth()
    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.Click
        SelectWestTee()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        SelectSouthTee()
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label11.Click
        SelectNSDiamond()
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click
        SelectEWDiamond()
    End Sub



    '**************************************************************************************************************************
    '**********************************************Handle Click-Clicks on Images**********************************************
    '**************************************************************************************************************************
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Select4X4()
        My.Forms._4X4.Show()
        Me.Visible = False
    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Select4X6()
        My.Forms._4X6.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        Select6X4()
        My.Forms._6X4.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        Select6X6()
        My.Forms._6X6.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        SelectEastTee()
        My.Forms.East_Tee.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox8.Click
        SelectNorthTee()
        My.Forms.North_Tee.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click
        SelectTollBooth()
        My.Forms.TollBoothEW.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click
        SelectWestTee()
        My.Forms.WestTee.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        SelectSouthTee()
        My.Forms.SouthTee.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click
        SelectNSDiamond()
        My.Forms.NorthSouthFreeway.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click
        SelectEWDiamond()
        My.Forms.EastWestFreeway.Show()
        Me.Visible = False
    End Sub


End Class




