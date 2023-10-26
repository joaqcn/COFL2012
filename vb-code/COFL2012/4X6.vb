﻿Imports System.Runtime.Intrinsics.X86
Imports System.Text.Encodings

Public Class _4X6
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    '************************************************************************************************************************
    '***************************************Initializes 4X6 Form*************************************************************
    '************************************************************************************************************************
    Sub Init4X6()
        'Load Stored Variables
        TextBox1.Text = Welcome.SSB
        TextBox2.Text = Welcome.ATSB
        TextBox3.Text = Welcome.ATWB
        TextBox4.Text = Welcome.SWB
        TextBox5.Text = Welcome.ATEB
        TextBox6.Text = Welcome.SEB
        TextBox7.Text = Welcome.ATNB
        TextBox8.Text = Welcome.SNB
    End Sub
    '************************************************************************************************************************
    '********************************Verifies that proper data has been inputted*********************************************
    '************************************************************************************************************************
    Sub Verify4X6Form()
        'Extracts variables from form
        Welcome.SSB = TextBox1.Text
        Welcome.ATSB = TextBox2.Text
        Welcome.ATWB = TextBox3.Text
        Welcome.SWB = TextBox4.Text
        Welcome.ATEB = TextBox5.Text
        Welcome.SEB = TextBox6.Text
        Welcome.ATNB = TextBox7.Text
        Welcome.SNB = TextBox8.Text

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

        '************************************************************************************************************************


        'Checks other input conditions*******************************************************************************************
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


End Class