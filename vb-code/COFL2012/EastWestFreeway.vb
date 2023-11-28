Imports System.Runtime.Intrinsics.X86
Imports System.Text.Encodings

Public Class EastWestFreeway

    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************
    Private Sub EastWestFreeway_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitEWDiamond()
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
        My.Forms.Title.Show()
        Me.Visible = False
        Title.InitTitle()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
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
            IntersectionType.InitIntType()
        End If
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
        'Writes user program run inputs to text file
        SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
        SaveFileDialog1.FileName = ""

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Welcome.FDOTin = SaveFileDialog1.FileName
            Welcome.SaveFile()
        End If
    End Sub

    Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
        My.Forms.About.Show()
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripButton.Click
        Welcome.QuickVerify = True
        VerifyEWDiamondForm()
        Welcome.QuickVerify = False
        My.Forms.Title.Show()
        Me.Visible = False
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictToolStripButton.Click
        Welcome.QuickVerify = True
        VerifyEWDiamondForm()
        Welcome.QuickVerify = False
        My.Forms.District.Show()
        Me.Visible = False
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
        Welcome.QuickVerify = True
        VerifyEWDiamondForm()
        Welcome.QuickVerify = False
        My.Forms.IntersectionType.Show()
        Me.Visible = False
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
        'Call the routine to check form inputs
        VerifyEWDiamondForm()

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


    '************************************************************************************************************************
    '***********************************************Initializes E-W Diamond Form*********************************************
    '************************************************************************************************************************
    Sub InitEWDiamond()
        'Load stored variables
        TextBox8.Text = Welcome.SSB
        TextBox7.Text = Welcome.ATSB
        TextBox9.Text = Welcome.ORSB
        TextBox15.Text = Welcome.ATWB
        TextBox16.Text = Welcome.SWB
        TextBox4.Text = Welcome.ORWB
        TextBox13.Text = Welcome.ATEB
        TextBox14.Text = Welcome.SEB
        TextBox6.Text = Welcome.OREB
        TextBox11.Text = Welcome.ATNB
        TextBox12.Text = Welcome.SNB
        TextBox2.Text = Welcome.ORNB
    End Sub


    '************************************************************************************************************************
    '********************************Verifies that proper data has been inputted*********************************************
    '************************************************************************************************************************
    Sub VerifyEWDiamondForm()
        'Extracts variables from form
        Welcome.SSB = TextBox8.Text
        Welcome.ATSB = TextBox7.Text
        Welcome.ORSB = TextBox9.Text
        Welcome.ATWB = TextBox15.Text
        Welcome.SWB = TextBox16.Text
        Welcome.ORWB = TextBox4.Text
        Welcome.ATEB = TextBox13.Text
        Welcome.SEB = TextBox14.Text
        Welcome.OREB = TextBox6.Text
        Welcome.ATNB = TextBox11.Text
        Welcome.SNB = TextBox12.Text
        Welcome.ORNB = TextBox2.Text

        'Verifies that all fields have numeric inputs
        Try
            Welcome.SSB = CInt(Welcome.SSB)
        Catch ex As Exception
            If Welcome.SSB <> "" Then
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

        Try
            Welcome.ATSB = CInt(Welcome.ATSB)
        Catch ex As Exception
            If Welcome.ATSB <> "" Then
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
            Welcome.ORSB = CInt(Welcome.ORSB)
        Catch ex As Exception
            If Welcome.ORSB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox9.Text = ""
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
                    TextBox15.Text = ""
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
                    TextBox16.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.ORWB = CInt(Welcome.ORWB)
        Catch ex As Exception
            If Welcome.ORWB <> "" Then
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
            Welcome.ATEB = CInt(Welcome.ATEB)
        Catch ex As Exception
            If Welcome.ATEB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox13.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.SEB = CInt(Welcome.SEB)
        Catch ex As Exception
            If Welcome.SEB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox14.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.OREB = CInt(Welcome.OREB)
        Catch ex As Exception
            If Welcome.OREB <> "" Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                    TextBox6.Text = ""
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
                    TextBox11.Text = ""
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
                    TextBox12.Text = ""
                    Exit Sub
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            End If
        End Try

        Try
            Welcome.ORNB = CInt(Welcome.ORNB)
        Catch ex As Exception
            If Welcome.ORNB <> "" Then
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

        '************************************************************************************************************************


        'Checks other input conditions*******************************************************************************************
        'Verify that all data fields have been completed
        If Not (Welcome.SSB <> "" And Welcome.SWB <> "" And Welcome.SNB <> "" And Welcome.SEB <> "" And Welcome.ATSB <> "" And Welcome.ORSB <> "" _
                And Welcome.ATWB <> "" And Welcome.ORWB <> "" And Welcome.ATNB <> "" And Welcome.ORWB <> "" _
                And Welcome.ATEB <> "" And Welcome.OREB <> "") Then
            If Welcome.QuickVerify = False Then
                MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
                Welcome.InputsCorrect(4) = False
            Else
                Welcome.InputsCorrect(4) = False
            End If

        Else

            'verifies that traffic volumes are positive numbers
            If Welcome.ATSB < 0 Or Welcome.ORSB < 0 Or Welcome.ORWB < 0 Or Welcome.ORWB < 0 Or
                Welcome.ATNB < 0 Or Welcome.ORNB < 0 Or Welcome.ATEB < 0 Or Welcome.OREB < 0 Then
                If Welcome.QuickVerify = False Then
                    MsgBox("Traffic volumes must be positive numbers.  Please re-enter.", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                Else
                    Welcome.InputsCorrect(4) = False
                End If

            Else

                'Verifies that cruise speeds are between 15 and 65 mph
                If (Welcome.SSB < 15 Or Welcome.SWB < 15 Or Welcome.SNB < 15 Or Welcome.SEB < 15) Or (Welcome.SSB > 65 Or Welcome.SWB > 65 Or Welcome.SNB > 65 Or Welcome.SEB > 65) Then
                    If Welcome.QuickVerify = False Then
                        MsgBox("Cruise speeds must be between 15 and 65 mph.  Please re-enter.", 0, "CO Florida 2012")
                        Welcome.InputsCorrect(4) = False
                    Else
                        Welcome.InputsCorrect(4) = False
                    End If

                Else
                    'Verifies tyhat All AT's are <= 100,000
                    If Welcome.ATSB > 100000 Or Welcome.ATWB > 100000 Or Welcome.ATNB > 100000 Or Welcome.ATEB > 100000 Then
                        If Welcome.QuickVerify = False Then
                            MsgBox("Traffic volumes may not exceed 100,000 vph.  Please re-enter.", 0, "CO Florida 2012")
                            Welcome.InputsCorrect(4) = False
                        Else
                            Welcome.InputsCorrect(4) = False
                        End If
                    Else

                        'Verifies that all AT's are > OR's
                        If (CInt(Welcome.ORSB) > CInt(Welcome.ATSB) Or CInt(Welcome.ORWB) > CInt(Welcome.ATWB) Or CInt(Welcome.ORNB) > CInt(Welcome.ATNB) Or CInt(Welcome.OREB) > CInt(Welcome.ATEB)) Then
                            If Welcome.QuickVerify = False Then
                                MsgBox("Ramp volumes may not exceed approach volumes.  Please re-enter.", 0, "CO Florida 2012")
                                Welcome.InputsCorrect(4) = False
                            Else
                                Welcome.InputsCorrect(4) = False
                            End If
                        Else
                            'Assigns "true" to InputsCorrect, if all tests were passed
                            Welcome.InputsCorrect(4) = True

                            'Determines traffic volume to be used for all directions in the CAL3QHC input file
                            Welcome.ATMax = 0
                            Welcome.FTMax = 0
                            If Welcome.ATMax < CInt(Welcome.ATSB) Then Welcome.ATMax = CInt(Welcome.ATSB)
                            If Welcome.ATMax < CInt(Welcome.ATNB) Then Welcome.ATMax = CInt(Welcome.ATNB)
                            If Welcome.FTMax < CInt(Welcome.ATEB) Then Welcome.ATMax = CInt(Welcome.ATEB)
                            If Welcome.FTMax < CInt(Welcome.ATWB) Then Welcome.ATMax = CInt(Welcome.ATWB)
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    '***************************************************************************************************************************
    '***********************************************Bottom navigation buttons***************************************************
    '***************************************************************************************************************************
    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Welcome.QuickVerify = True
        VerifyEWDiamondForm()
        Welcome.QuickVerify = False
        My.Forms.IntersectionType.Show()
        Me.Visible = False
    End Sub


    Private Sub btnRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call the routine to check form inputs
        VerifyEWDiamondForm()

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


    '***************************************************************************************************************************
    '*******************************************Changes to variables in input fields********************************************
    '***************************************************************************************************************************
    Private Sub TextBox8_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox8.TextChanged
        Welcome.SSB = TextBox8.Text
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Welcome.ATSB = TextBox7.Text
    End Sub

    Private Sub TextBox9_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox9.TextChanged
        Welcome.ORSB = TextBox9.Text
    End Sub

    Private Sub TextBox16_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox16.TextChanged
        Welcome.SWB = TextBox16.Text
    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged
        Welcome.ATWB = TextBox15.Text
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Welcome.ORWB = TextBox4.Text
    End Sub

    Private Sub TextBox12_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox12.TextChanged
        Welcome.SNB = TextBox12.Text
    End Sub

    Private Sub TextBox11_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox11.TextChanged
        Welcome.ATNB = TextBox11.Text
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        Welcome.ORNB = TextBox2.Text
    End Sub

    Private Sub TextBox14_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox14.TextChanged
        Welcome.SEB = TextBox14.Text
    End Sub

    Private Sub TextBox13_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox13.TextChanged
        Welcome.ATEB = TextBox13.Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Welcome.OREB = TextBox6.Text
    End Sub

    Private Sub btnRun_Click_1(sender As Object, e As EventArgs) Handles btnRun.Click

    End Sub
End Class