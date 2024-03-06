Imports System.Runtime.Intrinsics.X86
Imports System.Text.Encodings

Public Class Diamond

    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************
    Private Sub EastWestFreeway_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EastWestFreeway.InitEWDiamond()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub


    ''*************************************************************************************************************************************
    ''************************************************Top Navigation Menus and Buttons*****************************************************
    ''*************************************************************************************************************************************
    'Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
    '    Welcome.ClearAll()
    '    District.InitDistrict()
    '    IntersectionType.InitIntType()
    '    My.Forms.Title.Show()
    '    Me.Visible = False
    '    Title.InitTitle()
    'End Sub

    'Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
    '    OpenFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
    '    OpenFileDialog1.Filter = "Input files (*in)|*.in|All files (*.*)|*.*"
    '    OpenFileDialog1.FileName = ""

    '    If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
    '        Welcome.FDOTin = OpenFileDialog1.FileName
    '        Welcome.OpenFile()
    '        My.Forms.Title.Show()
    '        Me.Visible = False
    '        Title.InitTitle()
    '        District.InitDistrict()
    '        IntersectionType.InitIntType()
    '    End If
    'End Sub

    'Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
    '    'Writes user program run inputs to text file
    '    SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
    '    SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '    SaveFileDialog1.FileName = ""

    '    If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '        Welcome.FDOTin = SaveFileDialog1.FileName
    '        Welcome.SaveFile()
    '    End If
    'End Sub

    'Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
    '    My.Forms.About.Show()
    'End Sub

    'Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripButton.Click
    '    Welcome.QuickVerify = True
    '    VerifyEWDiamondForm()
    '    Welcome.QuickVerify = False
    '    My.Forms.Title.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictToolStripButton.Click
    '    Welcome.QuickVerify = True
    '    VerifyEWDiamondForm()
    '    Welcome.QuickVerify = False
    '    My.Forms.District.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
    '    Welcome.QuickVerify = True
    '    VerifyEWDiamondForm()
    '    Welcome.QuickVerify = False
    '    My.Forms.IntersectionType.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
    '    'Call the routine to check form inputs
    '    VerifyEWDiamondForm()

    '    'Verifies that all input forms have been completed before making a run
    '    If (Welcome.InputsCorrect(1) = True And Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4) = True) Then
    '        Welcome.BuildEWDiamond()
    '        Welcome.MakeARun()
    '        Me.Visible = False
    '    Else
    '        If Welcome.InputsCorrect(4) = True Then
    '            MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
    '        End If
    '    End If
    'End Sub



    '***************************************************************************************************************************
    '***********************************************Bottom navigation buttons***************************************************
    '***************************************************************************************************************************
    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs)
        Welcome.QuickVerify = True
        EastWestFreeway.VerifyEWDiamondForm()
        Welcome.QuickVerify = False
        My.Forms.IntersectionType.Show()
        Visible = False
    End Sub


    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRun.Click
        'Call the routine to check form inputs
        EastWestFreeway.VerifyEWDiamondForm()

        'Verifies that all input forms have been completed before making a run
        If (Welcome.InputsCorrect(1) = True And Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4) = True) Then
            Welcome.BuildEWDiamond()
            Welcome.MakeARun()
            Me.Visible = False
        Else
            If Welcome.InputsCorrect(4) = True Then
                MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
            End If
        End If

    End Sub


    ''***************************************************************************************************************************
    ''*******************************************Changes to variables in input fields********************************************
    ''***************************************************************************************************************************
    'Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
    '    Welcome.SSB = TextBox8.Text
    'End Sub

    'Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
    '    Welcome.ATSB = TextBox7.Text
    'End Sub

    'Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
    '    Welcome.ORSB = TextBox9.Text
    'End Sub

    'Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
    '    Welcome.SWB = TextBox16.Text
    'End Sub

    'Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
    '    Welcome.ATWB = TextBox15.Text
    'End Sub

    'Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
    '    Welcome.ORWB = TextBox4.Text
    'End Sub

    'Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
    '    Welcome.SNB = TextBox12.Text
    'End Sub

    'Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
    '    Welcome.ATNB = TextBox11.Text
    'End Sub

    'Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
    '    Welcome.ORNB = TextBox2.Text
    'End Sub

    'Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
    '    Welcome.SEB = TextBox14.Text
    'End Sub

    'Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
    '    Welcome.ATEB = TextBox13.Text
    'End Sub

    'Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
    '    Welcome.OREB = TextBox6.Text
    'End Sub


End Class