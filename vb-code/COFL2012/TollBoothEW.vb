Imports System.IO

Public Class TollBoothEW


    Private Sub TollBoothEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitTollBooth()
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
    '    VerifyTollboothForm()
    '    QuickVerify = False
    '    My.Forms.Title.Show()
    '    Me.Visible = False
    'End Sub


    'Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistrictToolStripButton.Click
    '    QuickVerify = True
    '    VerifyTollboothForm()
    '    QuickVerify = False
    '    My.Forms.District.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
    '    QuickVerify = True
    '    VerifyTollboothForm()
    '    QuickVerify = False
    '    My.Forms.IntersectionType.Show()
    '    Me.Visible = False
    'End Sub

    'Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunToolStripButton.Click
    '    'Call the routine to check form inputs
    '    VerifyTollboothForm()

    '    'Verifies that all input forms have been completed before making a run
    '    If (InputsCorrect(1) = True And InputsCorrect(2) = True And InputsCorrect(3) = True And InputsCorrect(4) = True) Then
    '        BuildTollBooth()
    '        MakeARun()
    '        Me.Visible = False
    '    Else
    '        If InputsCorrect(4) = True Then
    '            MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
    '        End If
    '    End If
    'End Sub




    '************************************************************************************************************************
    '**************************************Initializes Toll Booth Form*******************************************************
    '************************************************************************************************************************

    Sub InitTollBooth()
        'Load Stored Variables
        TextBox6.Text = Welcome.SSB
        TextBox7.Text = Welcome.ATSB
        TextBox8.Text = Welcome.ETCSB
        TextBox5.Text = Welcome.SWB
        TextBox4.Text = Welcome.ATWB
        TextBox3.Text = Welcome.ETCWB
        TextBox9.Text = Welcome.SNB
        TextBox10.Text = Welcome.ATNB
        TextBox11.Text = Welcome.ETCNB
        TextBox14.Text = Welcome.SEB
        TextBox1.Text = Welcome.ATEB
        TextBox2.Text = Welcome.ETCEB

        If Welcome.EWTollBooth = False Then
            PictureBox1.Visible = False
            PictureBox5.Visible = False
            PictureBox4.Visible = False
            Label12.Visible = False
            Label11.Visible = False
            Label10.Visible = False
            Label13.Visible = False
            Label18.Visible = False
            Label17.Visible = False
            Label15.Visible = False
            Label14.Visible = False
            Label19.Visible = False
            TextBox6.Visible = False
            TextBox7.Visible = False
            TextBox8.Visible = False
            TextBox9.Visible = False
            TextBox10.Visible = False
            TextBox11.Visible = False

            PictureBox2.Visible = True
            PictureBox3.Visible = True
            PictureBox7.Visible = True
            Label5.Visible = True
            Label3.Visible = True
            Label2.Visible = True
            Label16.Visible = True
            Label4.Visible = True
            Label7.Visible = True
            Label6.Visible = True
            Label9.Visible = True
            Label1.Visible = True
            TextBox3.Visible = True
            TextBox4.Visible = True
            TextBox5.Visible = True
            TextBox14.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
        Else
            PictureBox1.Visible = True
            PictureBox5.Visible = True
            PictureBox4.Visible = True
            Label12.Visible = True
            Label11.Visible = True
            Label10.Visible = True
            Label13.Visible = True
            Label18.Visible = True
            Label17.Visible = True
            Label15.Visible = True
            Label14.Visible = True
            Label19.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True

            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox7.Visible = False
            Label5.Visible = False
            Label3.Visible = False
            Label2.Visible = False
            Label16.Visible = False
            Label4.Visible = False
            Label7.Visible = False
            Label6.Visible = False
            Label9.Visible = False
            Label1.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox14.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
        End If

    End Sub





    '************************************************************************************************************************
    '********************************Verifies that proper data has been inputted*********************************************
    '************************************************************************************************************************
    Sub VerifyTollboothForm()
        'Extracts variables from form
        Welcome.SSB = TextBox6.Text
        Welcome.ATSB = TextBox7.Text
        Welcome.ETCSB = TextBox8.Text
        Welcome.SWB = TextBox5.Text
        Welcome.ATWB = TextBox4.Text
        Welcome.ETCWB = TextBox3.Text
        Welcome.SNB = TextBox9.Text
        Welcome.ATNB = TextBox10.Text
        Welcome.ETCNB = TextBox11.Text
        Welcome.SEB = TextBox14.Text
        Welcome.ATEB = TextBox1.Text
        Welcome.ETCEB = TextBox2.Text

        'Verifies that all fields have numeric inputs
        'Checks for EW Orientation:
        If PictureBox2.Visible = True Then
            Try
                Welcome.SWB = CInt(Welcome.SWB)
            Catch ex As Exception
                If Welcome.SWB <> "" Then
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
                Welcome.ATWB = CInt(Welcome.ATWB)
            Catch ex As Exception
                If Welcome.ATWB <> "" Then
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
                Welcome.ETCWB = CInt(Welcome.ETCWB)
            Catch ex As Exception
                If Welcome.ETCWB <> "" Then
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
                Welcome.ATEB = CInt(Welcome.ATEB)
            Catch ex As Exception
                If Welcome.ATEB <> "" Then
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
                Welcome.ETCEB = CInt(Welcome.ETCEB)
            Catch ex As Exception
                If Welcome.ETCEB <> "" Then
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

            'Checks other input conditions
            'Check that at least one speed and one approach traffic volume have been inputted
            If Not (Welcome.SWB <> "" And Welcome.SEB <> "" And Welcome.ATWB <> "" And Welcome.ATEB <> "" And Welcome.ETCEB <> "" And Welcome.ETCWB <> "") Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            Else
                'verifies that traffic volumes are positive numbers
                If Welcome.ATWB < 0 Or Welcome.ATEB < 0 Then
                    If Welcome.QuickVerify = False Then
                        MsgBox("Traffic volumes must be positive numbers.  Please re-enter.", 0, "CO Florida 2012")
                        Welcome.InputsCorrect(4) = False
                    Else
                        Welcome.InputsCorrect(4) = False
                    End If
                Else
                    'Verifies that cruise speeds are between 15 and 65 mph
                    If (Welcome.SWB < 15 Or Welcome.SEB < 15) Or (Welcome.SWB > 65 Or Welcome.SEB > 65) Then
                        If Welcome.QuickVerify = False Then
                            MsgBox("Freeway cruise speeds must be between 15 and 65 mph.  Please re-enter.", 0, "CO Florida 2012")
                            Welcome.InputsCorrect(4) = False
                        Else
                            Welcome.InputsCorrect(4) = False
                        End If
                    Else
                        'Verifies tyhat All AT's are <= 100,000
                        If Welcome.ATWB > 100000 Or Welcome.ATEB > 100000 Then
                            If Welcome.QuickVerify = False Then
                                MsgBox("Traffic volumes may not exceed 100,000 vph.  Please re-enter.", 0, "CO Florida 2012")
                                Welcome.InputsCorrect(4) = False
                            Else
                                Welcome.InputsCorrect(4) = False
                            End If
                        Else
                            'Verifies that ETC's are between 0 and 100
                            If (CInt(Welcome.ETCWB) < 0 Or CInt(Welcome.ETCWB) > 100 Or CInt(Welcome.ETCEB) < 0 Or CInt(Welcome.ETCEB > 100)) Then
                                If Welcome.QuickVerify = False Then
                                    MsgBox("The percentage of vehicles utilizing the ETC-Only lanes must be between 0 and 100.  Please re-enter.", 0, "CO Florida 2012")
                                    Welcome.InputsCorrect(4) = False
                                Else
                                    Welcome.InputsCorrect(4) = False
                                End If
                            Else
                                'Assigns "true" to InputsCorrect, if all tests were passed
                                Welcome.InputsCorrect(4) = True

                                'Sets speeds on unused directions = 55
                                Welcome.SSB = 55
                                Welcome.SNB = 55
                            End If
                        End If
                    End If
                End If
            End If
        Else
            'Checks for NS Orientation
            Try
                Welcome.SSB = CInt(Welcome.SSB)
            Catch ex As Exception
                If Welcome.SSB <> "" Then
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
                Welcome.ETCSB = CInt(Welcome.ETCSB)
            Catch ex As Exception
                If Welcome.ETCSB <> "" Then
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
                Welcome.SNB = CInt(Welcome.SNB)
            Catch ex As Exception
                If Welcome.SNB <> "" Then
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
                Welcome.ATNB = CInt(Welcome.ATNB)
            Catch ex As Exception
                If Welcome.ATNB <> "" Then
                    If Welcome.QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        Welcome.InputsCorrect(4) = False
                        TextBox10.Text = ""
                        Exit Sub
                    Else
                        Welcome.InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                Welcome.ETCNB = CInt(Welcome.ETCNB)
            Catch ex As Exception
                If Welcome.ETCNB <> "" Then
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

            'Checks other input conditions*******************************************************************************************
            'Check that at least one speed and one approach traffic volume have been inputted
            If Not (Welcome.ETCNB <> "" And Welcome.ETCSB <> "" And Welcome.SNB <> "" And Welcome.SSB <> "" And Welcome.ATNB <> "" And Welcome.ATSB <> "") Then
                If Welcome.QuickVerify = False Then
                    MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
                    Welcome.InputsCorrect(4) = False
                Else
                    Welcome.InputsCorrect(4) = False
                End If
            Else

                'verifies that traffic volumes are positive numbers
                If Welcome.ATNB < 0 Or Welcome.ATSB < 0 Then
                    If Welcome.QuickVerify = False Then
                        MsgBox("Traffic volumes must be positive numbers.  Please re-enter.", 0, "CO Florida 2012")
                        Welcome.InputsCorrect(4) = False
                    Else
                        Welcome.InputsCorrect(4) = False
                    End If
                Else

                    'Verifies that cruise speeds are between 15 and 65 mph
                    If (Welcome.SNB < 15 Or Welcome.SSB < 15) Or (Welcome.SNB > 65 Or Welcome.SSB > 65) Then
                        If Welcome.QuickVerify = False Then
                            MsgBox("Freeway cruise speeds must be between 15 and 65 mph.  Please re-enter.", 0, "CO Florida 2012")
                            Welcome.InputsCorrect(4) = False
                        Else
                            Welcome.InputsCorrect(4) = False
                        End If
                    Else
                        'Verifies tyhat All AT's are <= 100,000
                        If Welcome.ATNB > 100000 Or Welcome.ATSB > 100000 Then
                            If Welcome.QuickVerify = False Then
                                MsgBox("Traffic volumes may not exceed 100,000 vph.  Please re-enter.", 0, "CO Florida 2012")
                                Welcome.InputsCorrect(4) = False
                            Else
                                Welcome.InputsCorrect(4) = False
                            End If
                        Else

                            'Verifies that ETC's are between 0 and 100
                            If (CInt(Welcome.ETCNB) < 0 Or CInt(Welcome.ETCNB) > 100 Or CInt(Welcome.ETCSB) < 0 Or CInt(Welcome.ETCSB > 100)) Then
                                If Welcome.QuickVerify = False Then
                                    MsgBox("The percentage of vehicles utilizing the ETC-Only lanes must be between 0 and 100.  Please re-enter.", 0, "CO Florida 2012")
                                    Welcome.InputsCorrect(4) = False
                                Else
                                    Welcome.InputsCorrect(4) = False
                                End If
                            Else

                                'Assigns "true" to InputsCorrect, if all tests were passed
                                Welcome.InputsCorrect(4) = True

                                'Sets speeds on unused directions = 55
                                Welcome.SEB = 55
                                Welcome.SWB = 55

                            End If
                        End If
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
        VerifyTollboothForm()

        'Verifies that all input forms have been completed before making a run
        If (Welcome.InputsCorrect(1) = True And Welcome.InputsCorrect(2) = True And Welcome.InputsCorrect(3) = True And Welcome.InputsCorrect(4) = True) Then
            Welcome.BuildTollBooth()
            Welcome.MakeARun()
            Me.Visible = False
        Else
            If Welcome.InputsCorrect(4) = False Then
                MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
            End If
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        Welcome.QuickVerify = True
        VerifyTollboothForm()
        Welcome.QuickVerify = False
        My.Forms.IntersectionType.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        'Switches to N-S Orientation
        Welcome.EWTollBooth = False
        'N-S
        PictureBox1.Visible = True
        PictureBox5.Visible = True
        PictureBox4.Visible = True
        Label12.Visible = True
        Label11.Visible = True
        Label10.Visible = True
        Label13.Visible = True
        Label18.Visible = True
        Label17.Visible = True
        Label15.Visible = True
        Label14.Visible = True
        Label19.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True

        'E-W
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox7.Visible = False
        Label5.Visible = False
        Label3.Visible = False
        Label2.Visible = False
        Label16.Visible = False
        Label4.Visible = False
        Label7.Visible = False
        Label6.Visible = False
        Label9.Visible = False
        Label1.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox14.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        'Switches to E-W Orientation
        Welcome.EWTollBooth = True
        'N-S
        PictureBox1.Visible = False
        PictureBox5.Visible = False
        PictureBox4.Visible = False
        Label12.Visible = False
        Label11.Visible = False
        Label10.Visible = False
        Label13.Visible = False
        Label18.Visible = False
        Label17.Visible = False
        Label15.Visible = False
        Label14.Visible = False
        Label19.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False

        'E-W
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox7.Visible = True
        Label5.Visible = True
        Label3.Visible = True
        Label2.Visible = True
        Label16.Visible = True
        Label4.Visible = True
        Label7.Visible = True
        Label6.Visible = True
        Label9.Visible = True
        Label1.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox14.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True

    End Sub


End Class
