﻿Imports System.Runtime.Intrinsics.X86
Imports System.Text.Encodings
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class _4X4

    Private Sub _4X4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Welcome.RoundButton(btnPrevious)
        Welcome.RoundButton(btnNext)
        Init4X4()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    ''*************************************************************************************************************************************
    ''************************************************Top Navigation Menus and Buttons*****************************************************
    ''*************************************************************************************************************************************
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Welcome.ClearAll()
        District.InitDistrict()
        IntersectionType.InitIntType()
        My.Forms.Title.Show()
        Me.Visible = False
        Title.InitTitle()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
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

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        'Writes user program run inputs to text file
        SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
        SaveFileDialog1.FileName = ""

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Welcome.FDOTin = SaveFileDialog1.FileName
            Welcome.SaveFile()
        End If
    End Sub

    Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        My.Forms.About.Show()
    End Sub



    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Welcome.QuickVerify = True
        Verify4X4Form()
        Welcome.QuickVerify = False
        My.Forms.Title.Show()
        Me.Visible = False
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Welcome.QuickVerify = True
        Verify4X4Form()
        Welcome.QuickVerify = False
        My.Forms.District.Show()
        Me.Visible = False
    End Sub


    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        Welcome.QuickVerify = True
        Verify4X4Form()
        Welcome.QuickVerify = False
        My.Forms.IntersectionType.Show()
        Me.Visible = False
    End Sub



    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        'Call the routine to check form inputs
        Verify4X4Form()

        'Verifies that all input forms have been completed before making a run
        If (Welcome.InputsCorrect(1) = True And Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4) = True) Then
            Welcome.Build4X4()
            Welcome.MakeARun()
            Me.Visible = False
        Else
            If Welcome.InputsCorrect(4) = True Then
                MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
            End If
        End If


    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Init4X4()
        Verify4X4Form()
    End Sub

    Sub Init4X4()
        'Load Stored Variables
        TextBox1.Text = Welcome.SSB ' Speed South Bound
        TextBox2.Text = Welcome.ATSB   ' Approach Traffic South Bound
        TextBox4.Text = Welcome.SWB   ' Speed West Bound
        TextBox3.Text = Welcome.ATWB ' Aproach Traffic West Bound
        TextBox8.Text = Welcome.SEB   ' Speed East Bound
        TextBox7.Text = Welcome.ATEB  ' Approach Traffic East Bound
        TextBox5.Text = Welcome.SNB   ' Speed North Bound
        TextBox6.Text = Welcome.ATNB  ' Approach Traffic North Bound
    End Sub
    '************************************************************************************************************************
    '********************************Verifies that proper data has been inputted*********************************************
    '************************************************************************************************************************
    Sub Verify4X4Form()
        'Extracts variables from form
        Welcome.SSB = TextBox1.Text
        Welcome.ATSB = TextBox2.Text
        Welcome.ATWB = TextBox3.Text
        Welcome.SWB = TextBox4.Text
        Welcome.ATEB = TextBox7.Text
        Welcome.SEB = TextBox8.Text
        Welcome.ATNB = TextBox6.Text
        Welcome.SNB = TextBox5.Text

        'Verifies that all fields have numeric inputs
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
                    TextBox8.Text = ""
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
                    TextBox7.Text = ""
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
                    TextBox5.Text = ""
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
        If Not (Welcome.SSB <> "" And Welcome.SWB <> "" And Welcome.SNB <> "" And Welcome.SEB <> "" And Welcome.ATSB <> "" And Welcome.ATWB <> "" And Welcome.ATNB <> "" And Welcome.ATEB <> "") Then
            If Welcome.QuickVerify = False Then
                MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
                Welcome.InputsCorrect(4) = False
            Else
                Welcome.InputsCorrect(4) = False
            End If
        Else
            'verifies that traffic volumes are positive numbers
            If Welcome.ATSB < 0 Or Welcome.ATWB < 0 Or Welcome.ATNB < 0 Or Welcome.ATEB < 0 Then
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
                        'Assigns "true" to InputsCorrect, if all tests were passed
                        Welcome.InputsCorrect(4) = True

                        'Determines traffic volume to be used for all directions in the CAL3QHC input file
                        Welcome.ATMax = 0
                        If Welcome.ATMax < CInt(Welcome.ATSB) Then Welcome.ATMax = CInt(Welcome.ATSB)
                        If Welcome.ATMax < CInt(Welcome.ATWB) Then Welcome.ATMax = CInt(Welcome.ATWB)
                        If Welcome.ATMax < CInt(Welcome.ATNB) Then Welcome.ATMax = CInt(Welcome.ATNB)
                        If Welcome.ATMax < CInt(Welcome.ATEB) Then Welcome.ATMax = CInt(Welcome.ATEB)

                        Welcome.ATLeft = CInt(Welcome.ATMax * 0.15)
                        Welcome.ATQ = CInt(Welcome.ATMax * 0.85)
                    End If
                End If
            End If
        End If
    End Sub
    '***************************************************************************************************************************
    '*******************************************Changes to variables in input fields********************************************
    '***************************************************************************************************************************
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
        Welcome.SNB = TextBox5.Text
    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox7.TextChanged
        Welcome.ATNB = TextBox6.Text
    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged
        Welcome.SEB = TextBox8.Text
    End Sub

    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        Welcome.ATEB = TextBox7.Text
    End Sub

    '***************************************************************************************************************************
    '***********************************************Bottom navigation buttons***************************************************
    '***************************************************************************************************************************
    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        'Call the routine to check form inputs
        Verify4X4Form()

        'Verifies that all input forms have been completed before making a run
        If (Welcome.InputsCorrect(1) = True And Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4) = True) Then
            Welcome.Build4X4()
            Welcome.MakeARun()
            Me.Visible = False
        Else
            If Welcome.InputsCorrect(4) = True Then
                MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
            End If
        End If
    End Sub


    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Welcome.QuickVerify = True
        Verify4X4Form()
        Welcome.QuickVerify = False
        My.Forms.IntersectionType.Show()
        Me.Visible = False
    End Sub


End Class


