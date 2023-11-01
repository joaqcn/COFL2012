Public Class TollBoothEW
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    '************************************************************************************************************************
    '**************************************Initializes Toll Booth Form*******************************************************
    '************************************************************************************************************************

    Sub InitTollBooth()
        'Load Stored Variables
        TextBox6.Text = SSB
        TextBox7.Text = ATSB
        TextBox8.Text = ETCSB
        TextBox5.Text = SWB
        TextBox4.Text = ATWB
        TextBox3.Text = ETCWB
        TextBox9.Text = SNB
        TextBox10.Text = ATNB
        TextBox11.Text = ETCNB
        TextBox14.Text = SEB
        TextBox1.Text = ATEB
        TextBox2.Text = ETCEB

        If EWTollBooth = False Then
            PictureBox2.Visible = False
            PictureBox3.Visible = False
            PictureBox4.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label5.Visible = False
            Label6.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False
            TextBox3.Visible = False
            TextBox4.Visible = False
            TextBox5.Visible = False
            TextBox14.Visible = False

            PictureBox1.Visible = True
            PictureBox5.Visible = True
            PictureBox6.Visible = True
            Label7.Visible = True
            Label8.Visible = True
            Label9.Visible = True
            Label12.Visible = True
            Label13.Visible = True
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            TextBox6.Visible = True
            TextBox7.Visible = True
            TextBox8.Visible = True
            TextBox9.Visible = True
            TextBox10.Visible = True
            TextBox11.Visible = True
        End If
    End Sub





    '************************************************************************************************************************
    '********************************Verifies that proper data has been inputted*********************************************
    '************************************************************************************************************************
    Sub VerifyTollboothForm()
        'Extracts variables from form
        SSB = TextBox6.Text
        ATSB = TextBox7.Text
        ETCSB = TextBox8.Text
        SWB = TextBox5.Text
        ATWB = TextBox4.Text
        ETCWB = TextBox3.Text
        SNB = TextBox9.Text
        ATNB = TextBox10.Text
        ETCNB = TextBox11.Text
        SEB = TextBox14.Text
        ATEB = TextBox1.Text
        ETCEB = TextBox2.Text

        'Verifies that all fields have numeric inputs
        'Checks for EW Orientation:
        If PictureBox2.Visible = True Then
            Try
                SWB = CInt(SWB)
            Catch ex As Exception
                If SWB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox5.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ATWB = CInt(ATWB)
            Catch ex As Exception
                If ATWB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox4.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ETCWB = CInt(ETCWB)
            Catch ex As Exception
                If ETCWB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox3.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                SEB = CInt(SEB)
            Catch ex As Exception
                If SEB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox14.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ATEB = CInt(ATEB)
            Catch ex As Exception
                If ATEB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox1.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ETCEB = CInt(ETCEB)
            Catch ex As Exception
                If ETCEB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox2.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            'Checks other input conditions
            'Check that at least one speed and one approach traffic volume have been inputted
            If Not (SWB <> "" And SEB <> "" And ATWB <> "" And ATEB <> "" And ETCEB <> "" And ETCWB <> "") Then
                If QuickVerify = False Then
                    MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
                    InputsCorrect(4) = False
                Else
                    InputsCorrect(4) = False
                End If
            Else
                'verifies that traffic volumes are positive numbers
                If ATWB < 0 Or ATEB < 0 Then
                    If QuickVerify = False Then
                        MsgBox("Traffic volumes must be positive numbers.  Please re-enter.", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                    Else
                        InputsCorrect(4) = False
                    End If
                Else
                    'Verifies that cruise speeds are between 15 and 65 mph
                    If (SWB < 15 Or SEB < 15) Or (SWB > 65 Or SEB > 65) Then
                        If QuickVerify = False Then
                            MsgBox("Freeway cruise speeds must be between 15 and 65 mph.  Please re-enter.", 0, "CO Florida 2012")
                            InputsCorrect(4) = False
                        Else
                            InputsCorrect(4) = False
                        End If
                    Else
                        'Verifies tyhat All AT's are <= 100,000
                        If ATWB > 100000 Or ATEB > 100000 Then
                            If QuickVerify = False Then
                                MsgBox("Traffic volumes may not exceed 100,000 vph.  Please re-enter.", 0, "CO Florida 2012")
                                InputsCorrect(4) = False
                            Else
                                InputsCorrect(4) = False
                            End If
                        Else
                            'Verifies that ETC's are between 0 and 100
                            If (CInt(ETCWB) < 0 Or CInt(ETCWB) > 100 Or CInt(ETCEB) < 0 Or CInt(ETCEB > 100)) Then
                                If QuickVerify = False Then
                                    MsgBox("The percentage of vehicles utilizing the ETC-Only lanes must be between 0 and 100.  Please re-enter.", 0, "CO Florida 2012")
                                    InputsCorrect(4) = False
                                Else
                                    InputsCorrect(4) = False
                                End If
                            Else
                                'Assigns "true" to InputsCorrect, if all tests were passed
                                InputsCorrect(4) = True

                                'Sets speeds on unused directions = 55
                                SSB = 55
                                SNB = 55
                            End If
                        End If
                    End If
                End If
            End If
        Else
            'Checks for NS Orientation
            Try
                SSB = CInt(SSB)
            Catch ex As Exception
                If SSB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox7.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ATSB = CInt(ATSB)
            Catch ex As Exception
                If ATSB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox7.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ETCSB = CInt(ETCSB)
            Catch ex As Exception
                If ETCSB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox8.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                SNB = CInt(SNB)
            Catch ex As Exception
                If SNB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox9.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ATNB = CInt(ATNB)
            Catch ex As Exception
                If ATNB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox10.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            Try
                ETCNB = CInt(ETCNB)
            Catch ex As Exception
                If ETCNB <> "" Then
                    If QuickVerify = False Then
                        MsgBox("All input fields must be positive integers.  Please correct inputs", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                        TextBox11.Text = ""
                        Exit Sub
                    Else
                        InputsCorrect(4) = False
                    End If
                End If
            End Try

            'Checks other input conditions*******************************************************************************************
            'Check that at least one speed and one approach traffic volume have been inputted
            If Not (ETCNB <> "" And ETCSB <> "" And SNB <> "" And SSB <> "" And ATNB <> "" And ATSB <> "") Then
                If QuickVerify = False Then
                    MsgBox("All fields must be completed in order to proceed.", 0, "CO Florida 2012")
                    InputsCorrect(4) = False
                Else
                    InputsCorrect(4) = False
                End If
            Else

                'verifies that traffic volumes are positive numbers
                If ATNB < 0 Or ATSB < 0 Then
                    If QuickVerify = False Then
                        MsgBox("Traffic volumes must be positive numbers.  Please re-enter.", 0, "CO Florida 2012")
                        InputsCorrect(4) = False
                    Else
                        InputsCorrect(4) = False
                    End If
                Else

                    'Verifies that cruise speeds are between 15 and 65 mph
                    If (SNB < 15 Or SSB < 15) Or (SNB > 65 Or SSB > 65) Then
                        If QuickVerify = False Then
                            MsgBox("Freeway cruise speeds must be between 15 and 65 mph.  Please re-enter.", 0, "CO Florida 2012")
                            InputsCorrect(4) = False
                        Else
                            InputsCorrect(4) = False
                        End If
                    Else
                        'Verifies tyhat All AT's are <= 100,000
                        If ATNB > 100000 Or ATSB > 100000 Then
                            If QuickVerify = False Then
                                MsgBox("Traffic volumes may not exceed 100,000 vph.  Please re-enter.", 0, "CO Florida 2012")
                                InputsCorrect(4) = False
                            Else
                                InputsCorrect(4) = False
                            End If
                        Else

                            'Verifies that ETC's are between 0 and 100
                            If (CInt(ETCNB) < 0 Or CInt(ETCNB) > 100 Or CInt(ETCSB) < 0 Or CInt(ETCSB > 100)) Then
                                If QuickVerify = False Then
                                    MsgBox("The percentage of vehicles utilizing the ETC-Only lanes must be between 0 and 100.  Please re-enter.", 0, "CO Florida 2012")
                                    InputsCorrect(4) = False
                                Else
                                    InputsCorrect(4) = False
                                End If
                            Else

                                'Assigns "true" to InputsCorrect, if all tests were passed
                                InputsCorrect(4) = True

                                'Sets speeds on unused directions = 55
                                SEB = 55
                                SWB = 55

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
        If (InputsCorrect(1) = True And InputsCorrect(2) = True And InputsCorrect(3) = True And InputsCorrect(4) = True) Then
            BuildTollBooth()
            MakeARun()
            Me.Visible = False
        Else
            If InputsCorrect(4) = True Then
                MsgBox("A run cannot be made until all input forms have been completed.", 0, "CO Florida 2012")
            End If
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrevious.Click
        QuickVerify = True
        VerifyTollboothForm()
        QuickVerify = False
        My.Forms.IntersectionType.Show()
        Me.Visible = False
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs)
        'Switches to N-S Orientation
        EWTollBooth = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox14.Visible = False

        PictureBox1.Visible = True
        PictureBox5.Visible = True
        PictureBox6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label12.Visible = True
        Label13.Visible = True
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        TextBox6.Visible = True
        TextBox7.Visible = True
        TextBox8.Visible = True
        TextBox9.Visible = True
        TextBox10.Visible = True
        TextBox11.Visible = True
    End Sub


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        'Switches to E-W Orientation
        EWTollBooth = True
        PictureBox2.Visible = True
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label5.Visible = True
        Label6.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        TextBox1.Visible = True
        TextBox2.Visible = True
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox5.Visible = True
        TextBox14.Visible = True

        PictureBox1.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        TextBox6.Visible = False
        TextBox7.Visible = False
        TextBox8.Visible = False
        TextBox9.Visible = False
        TextBox10.Visible = False
        TextBox11.Visible = False
    End Sub


End Class
