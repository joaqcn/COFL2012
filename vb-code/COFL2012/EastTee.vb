Imports System.Runtime.Intrinsics.X86

Public Class East_Tee
    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************
    Private Sub East_Tee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitEastTee()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub





    ''*************************************************************************************************************************************
    ''************************************************Top Navigation Menus and Buttons*****************************************************
    ''*************************************************************************************************************************************
    'Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
    '    ClearAll()
    '    District.InitDistrict()
    '    IntersectionType.InitIntType()
    '    My.Forms.Title.Show()
    '    Me.Visible = False
    '    Title.InitTitle()
    'End Sub

    'Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click

    '    OpenFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '    OpenFileDialog1.Filter = "Input files (*in)|*.in|All files (*.*)|*.*"
    '    OpenFileDialog1.FileName = ""

    '    If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
    '        FDOTin = OpenFileDialog1.FileName
    '        OpenFile()
    '        My.Forms.Title.Show()
    '        Me.Visible = False
    '        Title.InitTitle()
    '        District.InitDistrict()
    '        IntersectionType.InitIntType()
    '    End If
    'End Sub

    'Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
    '    'Writes user program run inputs to text file
    '    SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '    SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '    SaveFileDialog1.FileName = ""

    '    If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '        FDOTin = SaveFileDialog1.FileName
    '        SaveFile()
    '    End If
    'End Sub

    'Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
    '    My.Forms.About.Show()
    'End Sub

    'Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripButton.Click
    '    QuickVerify = True
    '    VerifyEastTeeForm()
    '    QuickVerify = False
    '    My.Forms.Title.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictToolStripButton.Click
    '    QuickVerify = True
    '    VerifyEastTeeForm()
    '    QuickVerify = False
    '    My.Forms.District.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
    '    QuickVerify = True
    '    VerifyEastTeeForm()
    '    QuickVerify = False
    '    My.Forms.IntersectionType.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
    '    'Call the routine to check form inputs
    '    VerifyEastTeeForm()

    '    'Verifies that all input forms have been completed before making a run
    '    If (InputsCorrect(1) = True And InputsCorrect(2) = True And InputsCorrect(3) = True And InputsCorrect(4) = True) Then
    '        BuildEastTee()
    '        MakeARun()
    '        Me.Visible = False
    '    Else
    '        If InputsCorrect(4) = True Then
    '            MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
    '        End If
    '    End If

    'End Sub




    '************************************************************************************************************************
    Sub InitEastTee()
        'Load Stored Variables
        TextBox1.Text = Welcome.SSB
        TextBox2.Text = Welcome.ATSB
        TextBox3.Text = Welcome.ATWB
        TextBox4.Text = Welcome.SWB
        TextBox7.Text = Welcome.ATNB
        TextBox8.Text = Welcome.SNB
    End Sub

    '************************************************************************************************************************
    '********************************Verifies that proper data has been inputted*********************************************
    '************************************************************************************************************************
    Sub VerifyEastTeeForm()
        'Extracts variables from form
        Welcome.SSB = TextBox1.Text
        Welcome.ATSB = TextBox2.Text
        Welcome.ATWB = TextBox3.Text
        Welcome.SWB = TextBox4.Text
        Welcome.ATNB = TextBox7.Text
        Welcome.SNB = TextBox8.Text

        'Verifies that all fields have numeric inputs***********************************************************************
        Try
            Welcome.SSB = CInt(Welcome.SSB)
        Catch ex As Exception
            If Welcome.SSB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox1.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.ATSB = CInt(Welcome.ATSB)
        Catch ex As Exception
            If Welcome.ATSB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox2.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.ATWB = CInt(Welcome.ATWB)
        Catch ex As Exception
            If Welcome.ATWB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox3.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.SWB = CInt(Welcome.SWB)
        Catch ex As Exception
            If Welcome.SWB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox4.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.ATNB = CInt(Welcome.ATNB)
        Catch ex As Exception
            If Welcome.ATNB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox7.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.SNB = CInt(Welcome.SNB)
        Catch ex As Exception
            If Welcome.SNB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox8.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        'Checks other input conditions
        'Check that at least one speed and one approach traffic volume have been inputted
        If Not (Welcome.SSB <> "" And Welcome.SWB <> "" And Welcome.SNB <> "" And Welcome.ATSB <> "" And Welcome.ATWB <> "" And Welcome.ATNB <> "") Then
            If Welcome.QuickVerify = False Then
                MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
                Welcome.InputsCorrect(4) = False
            Else
                Welcome.InputsCorrect(4) = False
            End If
        Else
            'verifies that traffic volumes are positive numbers
            If Welcome.ATSB < 0 Or Welcome.ATWB < 0 Or Welcome.ATNB < 0 Then
                If Welcome.QuickVerify = False Then
                    MsgBox("Traffic volumes must be positive numbers.  Please re-enter.", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            Else
                'Verifies that cruise speeds are between 15 and 65 mph
                If (Welcome.SSB < 15 Or Welcome.SWB < 15 Or Welcome.SNB < 15) Or (Welcome.SSB > 65 Or Welcome.SWB > 65 Or Welcome.SNB > 65) Then
                    If Welcome.QuickVerify = False Then
                        MsgBox("Cruise speeds must be between 15 and 65 mph.  Please re-enter.", 0, "CO Florida 2012")
                        Welcome.InputsCorrect(4) = False
                    Else
                        Welcome.InputsCorrect(4) = False
                    End If
                Else
                    'Verifies tyhat All AT's are <= 100,000
                    If Welcome.ATSB > 100000 Or Welcome.ATWB > 100000 Or Welcome.ATNB > 100000 Then
                        If Welcome.QuickVerify = False Then
                            MsgBox("Traffic volumes may not exceed 100,000 vph.  Please re-enter.", 0, "CO Florida 2012")
                            Welcome.InputsCorrect(4) = False
                        Else
                            Welcome.InputsCorrect(4) = False
                        End If
                    Else
                        'Assigns "true" to InputsCorrect, if all tests were passed
                        Welcome.InputsCorrect(4) = True

                        'Determines traffic volume to be used for all directions in the CAL3QHC input file
                        Welcome.ATMax = 0
                        If Welcome.ATMax < CInt(Welcome.ATSB) Then Welcome.ATMax = CInt(Welcome.ATSB)
                        If Welcome.ATMax < CInt(Welcome.ATWB) Then Welcome.ATMax = CInt(Welcome.ATWB)
                        If Welcome.ATMax < CInt(Welcome.ATNB) Then Welcome.ATMax = CInt(Welcome.ATNB)

                        Welcome.ATLeft = CInt(Welcome.ATMax * 0.15)
                        Welcome.ATQ = CInt(Welcome.ATMax * 0.85)
                    End If
                End If
            End If
        End If
    End Sub



    '***************************************************************************************************************************
    '***********************************************Bottom navigation buttons***************************************************
    '***************************************************************************************************************************

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'Call the routine to check form inputs
        VerifyEastTeeForm()

        'Verifies that all input forms have been completed before making a run
        If (Welcome.InputsCorrect(1) = True And Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4) = True) Then
            Welcome.BuildEastTee()
            'Welcome.MakeARun()
            Me.Visible = False
        Else
            If Welcome.InputsCorrect(4) = True Then
                MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
            End If
        End If
    End Sub


    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Welcome.QuickVerify = True
        VerifyEastTeeForm()
        Welcome.QuickVerify = False
        My.Forms.IntersectionType.Show()
        Me.Visible = False
    End Sub


    '***************************************************************************************************************************
    '*******************************************Changes to variables in input fields********************************************


    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Welcome.SSB = TextBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Welcome.ATSB = TextBox2.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Welcome.SWB = TextBox4.Text
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Welcome.ATWB = TextBox3.Text
    End Sub

    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Welcome.SNB = TextBox8.Text
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Welcome.ATNB = TextBox7.Text
    End Sub


End Class