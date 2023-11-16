Imports System.Drawing.Printing
Imports System.Runtime.Intrinsics.X86
Imports System.Text.Encodings

Public Class Results

    Dim FinalClose As Boolean = False



    '*************************************************************************************************************************************
    '******************************************************Form Load and Close Subroutines***********************************************************
    '*************************************************************************************************************************************

    'Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
    '    If FinalClose = False Then
    '        Welcome.TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to exit without saving.", vbYesNo, "Save data?")
    '        If Welcome.TestMsg = vbYes Then
    '            SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '            SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '            SaveFileDialog1.FileName = ""

    '            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '                Welcome.FDOTin = SaveFileDialog1.FileName
    '                Welcome.SaveFile()
    '            End If
    '        End If
    '    End If
    '    FinalClose = True
    '    Application.Exit()
    'End Sub



    ''***************************************************************************************************
    ''************************************************TOP NAVIGATION BUTTONS*****************************
    ''***************************************************************************************************
    'Private Sub NewToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripButton.Click
    '    TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to open a new project without saving.", vbYesNo, "Save data?")
    '    If TestMsg = vbYes Then
    '        SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '        SaveFileDialog1.FileName = ""

    '        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '            FDOTin = SaveFileDialog1.FileName
    '            SaveFile()
    '        End If
    '    End If
    '    ClearAll()
    '    District.InitDistrict()
    '    IntersectionType.InitIntType()
    '    My.Forms.Title.Show()
    '    Me.Visible = False
    '    Title.InitTitle()
    'End Sub


    'Private Sub OpenToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenToolStripButton.Click
    '    Dim TestMsg As Integer

    '    TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to open an existing project without saving.", vbYesNo, "Save data?")
    '    If TestMsg = vbYes Then
    '        SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '        SaveFileDialog1.FileName = ""

    '        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '            FDOTin = SaveFileDialog1.FileName
    '            SaveFile()
    '        End If
    '    End If

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


    'Private Sub TitleToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TitleToolStripButton.Click
    '    TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to return to the Intersection Data screen without saving.", vbYesNo, "Save data?")
    '    If TestMsg = vbYes Then
    '        SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '        SaveFileDialog1.FileName = ""

    '        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '            FDOTin = SaveFileDialog1.FileName
    '            SaveFile()
    '        End If
    '    End If

    '    My.Forms.Title.Show()
    '    Me.Visible = False
    'End Sub


    'Private Sub SaveToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToolStripButton.Click
    '    'Writes user program run inputs to text file

    '    SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '    SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '    SaveFileDialog1.FileName = ""

    '    If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '        FDOTin = SaveFileDialog1.FileName
    '        SaveFile()
    '    End If
    'End Sub


    'Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
    '    TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to return to the Intersection Data screen without saving.", vbYesNo, "Save data?")
    '    If TestMsg = vbYes Then
    '        SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '        SaveFileDialog1.FileName = ""

    '        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '            FDOTin = SaveFileDialog1.FileName
    '            SaveFile()
    '        End If
    '    End If

    '    My.Forms.District.Show()
    '    Me.Visible = False
    'End Sub


    'Private Sub IntersectionTypeToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionTypeToolStripButton.Click
    '    TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to return to the Intersection Data screen without saving.", vbYesNo, "Save data?")
    '    If TestMsg = vbYes Then
    '        SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '        SaveFileDialog1.FileName = ""

    '        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '            FDOTin = SaveFileDialog1.FileName
    '            SaveFile()
    '        End If
    '    End If
    '    My.Forms.IntersectionType.Show()
    '    Me.Visible = False
    'End Sub


    'Private Sub IntersectionDataToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IntersectionDataToolStripButton.Click
    '    TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to return to the Intersection Data screen without saving.", vbYesNo, "Save data?")
    '    If TestMsg = vbYes Then
    '        SaveFileDialog1.InitialDirectory = PrimaryDirectory & "\UsrFiles\"
    '        SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
    '        SaveFileDialog1.FileName = ""

    '        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
    '            FDOTin = SaveFileDialog1.FileName
    '            SaveFile()
    '        End If
    '    End If
    '    Select Case IntType
    '        Case ""
    '            My.Forms.Int4X4.Show()
    '        Case "4 X 4"
    '            My.Forms.Int4X4.Show()
    '        Case "4 X 6"
    '            My.Forms.Int4X6.Show()
    '        Case "6 X 4"
    '            My.Forms.Int6X4.Show()
    '        Case "6 X 6"
    '            My.Forms.Int6X6.Show()
    '        Case "East Tee"
    '            My.Forms.EastTee.Show()
    '        Case "North Tee"
    '            My.Forms.NorthTee.Show()
    '        Case "Toll Booth"
    '            My.Forms.TollBooth.Show()
    '        Case "West Tee"
    '            My.Forms.WestTee.Show()
    '        Case "South Tee"
    '            My.Forms.SouthTee.Show()
    '        Case "N-S Diamond"
    '            My.Forms.NSDiamond.Show()
    '        Case "E-W Diamond"
    '            My.Forms.I11.Show()
    '    End Select

    '    Me.Visible = False
    'End Sub


    'Private Sub AboutToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripButton.Click
    '    My.Forms.About.Show()
    ' End Sub




    '***************************************************************************************************************************************
    '********************************************************Sends Output to Printer********************************************************
    '***************************************************************************************************************************************
    Private Sub PrintDocument1_PrintPage_1(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim i As Integer
        Dim prFont As New Font("Calibri", 11, GraphicsUnit.Point)
        Dim StringToPrint As String = ""
        Dim y As Integer

        Welcome.PassFail = True

        e.Graphics.DrawString("CO Florida 2012 - Results", prFont, Brushes.Black, 340, 75)
        e.Graphics.DrawString(Format$(Now, "Long Date"), prFont, Brushes.Black, 335, 92)
        e.Graphics.DrawString("Project Description", prFont, Brushes.Black, 365, 126)
        e.Graphics.DrawString("Project Title", prFont, Brushes.Black, 168, 160)
        e.Graphics.DrawString(Welcome.Job, prFont, Brushes.Black, 390, 160)
        e.Graphics.DrawString("Facility Name", prFont, Brushes.Black, 168, 177)
        e.Graphics.DrawString(Welcome.FacilityName, prFont, Brushes.Black, 390, 177)
        e.Graphics.DrawString("User's Name", prFont, Brushes.Black, 168, 194)
        e.Graphics.DrawString(Welcome.UsersName, prFont, Brushes.Black, 390, 194)
        e.Graphics.DrawString("Run Name", prFont, Brushes.Black, 168, 211)
        e.Graphics.DrawString(Welcome.RunName, prFont, Brushes.Black, 390, 211)
        e.Graphics.DrawString("FDOT District", prFont, Brushes.Black, 168, 228)
        e.Graphics.DrawString(Welcome.DistrictNum, prFont, Brushes.Black, 390, 228)
        e.Graphics.DrawString("Year", prFont, Brushes.Black, 168, 245)
        e.Graphics.DrawString(Welcome.ProjectYear, prFont, Brushes.Black, 390, 245)
        e.Graphics.DrawString("Intersection Type", prFont, Brushes.Black, 168, 262)


        If Welcome.IntType = "Toll Booth" Then
            If Welcome.EWTollBooth = True Then
                e.Graphics.DrawString("E-W Freeway " & Welcome.IntType, prFont, Brushes.Black, 390, 262)
            Else
                e.Graphics.DrawString("N-S Freeway " & Welcome.IntType, prFont, Brushes.Black, 390, 262)
            End If
        Else
            e.Graphics.DrawString(Welcome.IntType, prFont, Brushes.Black, 390, 262)
        End If

        If (Welcome.IntType = "N-S Diamond" Or Welcome.IntType = "E-W Diamond") Then

            e.Graphics.DrawString("Speed", prFont, Brushes.Black, 168, 279)
            e.Graphics.DrawString("Arterial", prFont, Brushes.Black, 390, 279)
            e.Graphics.DrawString(Welcome.Speed & " mph", prFont, Brushes.Black, 450, 279)
            e.Graphics.DrawString("Freeway", prFont, Brushes.Black, 535, 279)
            e.Graphics.DrawString(Welcome.HwySpeed & " mph", prFont, Brushes.Black, 605, 279)
            e.Graphics.DrawString("Approach Traffic", prFont, Brushes.Black, 168, 296)
            e.Graphics.DrawString("Arterial", prFont, Brushes.Black, 390, 296)
            e.Graphics.DrawString(Welcome.ATMax & " vph", prFont, Brushes.Black, 450, 296)
            e.Graphics.DrawString("Freeway", prFont, Brushes.Black, 535, 296)
            e.Graphics.DrawString(Welcome.FTMax & " vph", prFont, Brushes.Black, 605, 296)
        Else
            If Welcome.IntType = "Toll Booth" Then
                If Welcome.EWTollBooth = True Then

                    e.Graphics.DrawString("Speed", prFont, Brushes.Black, 168, 279)
                    e.Graphics.DrawString("East Bound", prFont, Brushes.Black, 390, 279)
                    e.Graphics.DrawString(Welcome.SEB & " mph", prFont, Brushes.Black, 475, 279)
                    e.Graphics.DrawString("West Bound", prFont, Brushes.Black, 560, 279)
                    e.Graphics.DrawString(Welcome.SWB & " mph", prFont, Brushes.Black, 655, 279)

                    e.Graphics.DrawString("Approach Traffic", prFont, Brushes.Black, 168, 296)
                    e.Graphics.DrawString("EB Stopping", prFont, Brushes.Black, 390, 296)
                    e.Graphics.DrawString(CInt(Welcome.ATEB * ((100 - Welcome.ETCEB) / 100)) & " vph", prFont, Brushes.Black, 475, 296)
                    e.Graphics.DrawString("WB Stopping", prFont, Brushes.Black, 560, 296)
                    e.Graphics.DrawString(CInt(Welcome.ATWB * ((100 - Welcome.ETCWB) / 100)) & " vph", prFont, Brushes.Black, 655, 296)

                    e.Graphics.DrawString("EB ETC-only", prFont, Brushes.Black, 390, 313)
                    e.Graphics.DrawString(CInt(Welcome.ATEB * Welcome.ETCEB / 100) & " vph", prFont, Brushes.Black, 475, 313)
                    e.Graphics.DrawString("WB ETC-only", prFont, Brushes.Black, 560, 313)
                    e.Graphics.DrawString(CInt(Welcome.ATWB * Welcome.ETCWB / 100) & " vph", prFont, Brushes.Black, 655, 313)
                Else
                    e.Graphics.DrawString("Speed", prFont, Brushes.Black, 168, 279)
                    e.Graphics.DrawString("North Bound", prFont, Brushes.Black, 390, 279)
                    e.Graphics.DrawString(Welcome.SNB & " mph", prFont, Brushes.Black, 475, 279)
                    e.Graphics.DrawString("South Bound", prFont, Brushes.Black, 560, 279)
                    e.Graphics.DrawString(Welcome.SSB & " mph", prFont, Brushes.Black, 655, 279)

                    e.Graphics.DrawString("Approach Traffic", prFont, Brushes.Black, 168, 296)
                    e.Graphics.DrawString("NB Stopping", prFont, Brushes.Black, 390, 296)
                    e.Graphics.DrawString(CInt(Welcome.ATNB * ((100 - Welcome.ETCNB) / 100)) & " vph", prFont, Brushes.Black, 475, 296)
                    e.Graphics.DrawString("SB Stopping", prFont, Brushes.Black, 560, 296)
                    e.Graphics.DrawString(CInt(Welcome.ATSB * ((100 - Welcome.ETCSB) / 100)) & " vph", prFont, Brushes.Black, 655, 296)

                    e.Graphics.DrawString("NB ETC-only", prFont, Brushes.Black, 390, 313)
                    e.Graphics.DrawString(CInt(Welcome.ATNB * Welcome.ETCNB / 100) & " vph", prFont, Brushes.Black, 475, 313)
                    e.Graphics.DrawString("SB ETC-only", prFont, Brushes.Black, 560, 313)
                    e.Graphics.DrawString(CInt(Welcome.ATSB * Welcome.ETCSB / 100) & " vph", prFont, Brushes.Black, 655, 313)
                End If
            Else
                e.Graphics.DrawString("Speed", prFont, Brushes.Black, 168, 279)
                e.Graphics.DrawString("Arterial", prFont, Brushes.Black, 390, 279)
                e.Graphics.DrawString(Welcome.Speed & " mph", prFont, Brushes.Black, 450, 279)
                e.Graphics.DrawString("Approach Traffic", prFont, Brushes.Black, 168, 296)
                e.Graphics.DrawString("Arterial", prFont, Brushes.Black, 390, 296)
                e.Graphics.DrawString(Welcome.ATMax & " vph", prFont, Brushes.Black, 450, 296)
            End If
        End If

        e.Graphics.DrawString("Environmental Data", prFont, Brushes.Black, 365, 347)
        e.Graphics.DrawString("Temperature", prFont, Brushes.Black, 168, 381)
        e.Graphics.DrawString(Welcome.Temperature & " °F", prFont, Brushes.Black, 390, 381)
        e.Graphics.DrawString("Reid Vapor Pressure", prFont, Brushes.Black, 168, 398)
        e.Graphics.DrawString(Welcome.RVP & " psi", prFont, Brushes.Black, 390, 398)
        e.Graphics.DrawString("Land Use", prFont, Brushes.Black, 168, 415)
        e.Graphics.DrawString(Welcome.LandUse, prFont, Brushes.Black, 390, 415)
        e.Graphics.DrawString("Stability Class", prFont, Brushes.Black, 168, 432)
        e.Graphics.DrawString(Welcome.CLASLetter, prFont, Brushes.Black, 390, 432)
        e.Graphics.DrawString("Surface Roughness", prFont, Brushes.Black, 168, 449)
        e.Graphics.DrawString(Welcome.ZO & " cm", prFont, Brushes.Black, 390, 449)
        e.Graphics.DrawString("1 Hr. Background Concentration", prFont, Brushes.Black, 168, 466)
        e.Graphics.DrawString(Welcome.COBack1Hr & " ppm", prFont, Brushes.Black, 390, 466)
        e.Graphics.DrawString("8 Hr. Background Concentration", prFont, Brushes.Black, 168, 483)
        e.Graphics.DrawString(Welcome.COBack8Hr & " ppm", prFont, Brushes.Black, 390, 483)
        e.Graphics.DrawString("Results", prFont, Brushes.Black, 388, 517)
        e.Graphics.DrawString("(ppm, including background CO)", prFont, Brushes.Black, 313, 534)
        e.Graphics.DrawString("Receptor       Max 1-Hr       Max 8-Hr", prFont, Brushes.Black, 310, 551)
        e.Graphics.DrawString("-----------       ------------        --------------", prFont, Brushes.Black, 315, 568)

        y = 568

        For i = 1 To 9
            If (Welcome.Conc1(i) > 35 Or Welcome.Conc8(i) > 9) Then Welcome.PassFail = False
            y = y + 17
            e.Graphics.DrawString("  " & i, prFont, Brushes.Black, 330, y)

            If Welcome.Conc1(i) < 100 Then
                StringToPrint = "  " & Format(Welcome.Conc1(i), "#0.0")
                If Welcome.Conc1(i) < 10 Then
                    StringToPrint = "    " & Format(Welcome.Conc1(i), "#0.0")
                End If
            End If
            e.Graphics.DrawString(StringToPrint, prFont, Brushes.Black, 400, y)

            If Welcome.Conc8(i) < 100 Then
                StringToPrint = "  " & Format(Welcome.Conc8(i), "#0.0")
                If Welcome.Conc8(i) < 10 Then
                    StringToPrint = "    " & Format(Welcome.Conc8(i), "#0.0")
                End If
            End If
            e.Graphics.DrawString(StringToPrint, prFont, Brushes.Black, 485, y)
        Next i

        For i = 10 To 17
            If (Welcome.Conc1(i) > 35 Or Welcome.Conc8(i) > 9) Then Welcome.PassFail = False
            y = y + 17
            e.Graphics.DrawString(i, prFont, Brushes.Black, 330, y)

            If Welcome.Conc1(i) < 100 Then
                StringToPrint = "  " & Format(Welcome.Conc1(i), "#0.0")
                If Welcome.Conc1(i) < 10 Then
                    StringToPrint = "    " & Format(Welcome.Conc1(i), "#0.0")
                End If
            End If
            e.Graphics.DrawString(StringToPrint, prFont, Brushes.Black, 400, y)

            If Welcome.Conc8(i) < 100 Then
                StringToPrint = "  " & Format(Welcome.Conc8(i), "#0.0")
                If Welcome.Conc8(i) < 10 Then
                    StringToPrint = "    " & Format(Welcome.Conc8(i), "#0.0")
                End If
            End If
            e.Graphics.DrawString(StringToPrint, prFont, Brushes.Black, 485, y)
        Next i


        If (Welcome.IntType <> "East Tee" And Welcome.IntType <> "North Tee" And Welcome.IntType <> "West Tee" And Welcome.IntType <> "South Tee") Then

            For i = 18 To 20
                If (Welcome.Conc1(i) > 35 Or Welcome.Conc8(i) > 9) Then Welcome.PassFail = False
                y = y + 17
                e.Graphics.DrawString(i, prFont, Brushes.Black, 330, y)
                If Welcome.Conc1(i) < 100 Then
                    StringToPrint = "  " & Format(Welcome.Conc1(i), "#0.0")
                    If Welcome.Conc1(i) < 10 Then
                        StringToPrint = "    " & Format(Welcome.Conc1(i), "#0.0")
                    End If
                End If
                e.Graphics.DrawString(StringToPrint, prFont, Brushes.Black, 400, y)

                If Welcome.Conc8(i) < 100 Then
                    StringToPrint = "  " & Format(Welcome.Conc8(i), "#0.0")
                    If Welcome.Conc8(i) < 10 Then
                        StringToPrint = "    " & Format(Welcome.Conc8(i), "#0.0")
                    End If
                End If
                e.Graphics.DrawString(StringToPrint, prFont, Brushes.Black, 485, y)
            Next i
        End If

        'Checks for pass/fail
        For i = 1 To 17
            'Checks for 1 hr exceedances
            If Welcome.Conc1(i) >= 35 Then Welcome.PassFail = False

            'Checks for 8 hr exceedances
            If Welcome.Conc8(i) >= 9 Then Welcome.PassFail = False
        Next i

        If (Welcome.IntType = "East Tee" Or Welcome.IntType = "South Tee" Or Welcome.IntType = "West Tee" Or Welcome.IntType = "North Tee") Then
            'do nothing
        Else
            'Calculations on receptors 18-20
            For i = 18 To 20

                'Checks for 1 hr exceedances
                If Welcome.Conc1(i) >= 35 Then Welcome.PassFail = False

                'Checsk for 8 hr exceedances
                If Welcome.Conc8(i) >= 9 Then Welcome.PassFail = False
            Next i
        End If

        y = y + 34

        'Prints pass/fail message
        If Welcome.PassFail = False Then
            e.Graphics.DrawString("*******************************", prFont, Brushes.Black, 290, y)
            y = y + 17
            e.Graphics.DrawString("*PROJECT FAILS SCREENING MODEL*", prFont, Brushes.Black, 290, y)
            y = y + 17
            e.Graphics.DrawString("*DETAILED MODELING IS REQUIRED*", prFont, Brushes.Black, 290, y)
            y = y + 17
            e.Graphics.DrawString("*******************************", prFont, Brushes.Black, 290, y)
        Else
            e.Graphics.DrawString("************************************************", prFont, Brushes.Black, 230, y)
            y = y + 17
            e.Graphics.DrawString("*****************PROJECT PASSES******************", prFont, Brushes.Black, 230, y)
            y = y + 17
            e.Graphics.DrawString("*NO EXCEEDANCES OF NAAQ STANDARDS ARE PREDICTED*", prFont, Brushes.Black, 230, y)
            y = y + 17
            e.Graphics.DrawString("************************************************", prFont, Brushes.Black, 230, y)
        End If
    End Sub



    '****************************************************************************************************************************************
    '***************************************Saves Output to .out File***********************************************************************
    '***************************************************************************************************************************************
    Sub SaveOutputFile()
        'Writes user program run Output to .out or .doc File
        Dim i As Integer
        Dim Tab1 As Integer
        Dim Tab2 As Integer
        Dim Tab3 As Integer
        Dim sWriter As IO.StreamWriter

        Welcome.PassFail = True

        SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
        SaveFileDialog1.Filter = "Output files (*.out)|*.out|All files (*.*)|*.*"
        SaveFileDialog1.FileName = ""

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then

            Welcome.FDOTout = SaveFileDialog1.FileName

            Try
                sWriter = New IO.StreamWriter(Welcome.FDOTout)
            Catch ex As Exception
                MsgBox("The selected output file is currently open.  Please close the file and try again.", 0, "CO Florida 2012")
                Exit Sub
            End Try

            sWriter.WriteLine(Space(7) & "CO Florida 2012 - Results")
            sWriter.WriteLine(Space(7) & Format$(Now, "Long Date"))
            sWriter.WriteLine("")
            sWriter.WriteLine(Space(10) & "Project Description")
            sWriter.WriteLine(Space(0) & "Project Title" & Space(19) & Welcome.Job)
            sWriter.WriteLine(Space(0) & "Facility Name" & Space(19) & Welcome.FacilityName)
            sWriter.WriteLine(Space(0) & "User's Name" & Space(21) & Welcome.UsersName)
            sWriter.WriteLine(Space(0) & "Run Name" & Space(24) & Welcome.RunName)
            sWriter.WriteLine(Space(0) & "FDOT District" & Space(19) & Welcome.DistrictNum)
            sWriter.WriteLine(Space(0) & "Year" & Space(28) & Welcome.ProjectYear)

            If Welcome.IntType = "Toll Booth" Then
                If Welcome.EWTollBooth = True Then
                    sWriter.WriteLine(Space(0) & "Intersection Type" & Space(15) & "E-W Freeway " & Welcome.IntType)
                Else
                    sWriter.WriteLine(Space(0) & "Intersection Type" & Space(15) & "N-S Freeway " & Welcome.IntType)
                End If
            Else
                sWriter.WriteLine(Space(0) & "Intersection Type" & Space(15) & "E-W Freeway " & Welcome.IntType)
            End If

            If (Welcome.IntType = "N-S Diamond" Or Welcome.IntType = "E-W Diamond") Then
                'Freeway Diamond Configuration
                Tab1 = 6 - Microsoft.VisualBasic.Len(Welcome.ATMax)
                Tab2 = 5 - Microsoft.VisualBasic.Len(Welcome.FTMax)
                sWriter.WriteLine("Speed" & Space(27) & "Arterial" & Space(4) & Welcome.Speed & " mph" & Space(3) & "Freeway" & Space(5) & Welcome.HwySpeed & " mph")
                sWriter.WriteLine("Approach Traffic" & Space(16) & "Arterial" & Space(Tab1) & Welcome.ATMax & " vph" & Space(3) & "Freeway  " & Space(Tab2) & Welcome.FTMax & " vph")
                sWriter.WriteLine("")
            Else
                'Toll Booth Configuration
                If Welcome.IntType = "Toll Booth" Then
                    If Welcome.EWTollBooth = True Then
                        Tab1 = 7 - Microsoft.VisualBasic.Len(CStr(CInt(Welcome.ATEB * ((100 - Welcome.ETCEB) / 100))))
                        Tab2 = 6 - Microsoft.VisualBasic.Len(CStr(CInt(Welcome.ATWB * ((100 - Welcome.ETCWB) / 100))))

                        sWriter.WriteLine("Speed" & Space(27) & "East Bound" & Space(6) & Welcome.SEB & " mph" & Space(2) & "West Bound" & Space(5) & Welcome.SWB & " mph")
                        sWriter.WriteLine("Approach Traffic" & Space(16) & "EB Stopping" & Space(Tab1) & CInt(Welcome.ATEB * ((100 - Welcome.ETCEB) / 100)) _
                                     & " vph  WB Stopping" & Space(Tab2) & CInt(Welcome.ATWB * ((100 - Welcome.ETCWB) / 100)) & " vph")
                        sWriter.WriteLine(Space(32) & "EB ETC-only" & Space(Tab1) & CInt(Welcome.ATEB * (Welcome.ETCEB / 100)) _
                                     & " vph  WB ETC-only" & Space(Tab2) & CInt(Welcome.ATWB * Welcome.ETCWB / 100) & " vph")

                        sWriter.WriteLine("")
                    Else
                        Tab1 = 7 - Microsoft.VisualBasic.Len(CStr(CInt(Welcome.ATNB * ((100 - Welcome.ETCNB) / 100))))
                        Tab2 = 6 - Microsoft.VisualBasic.Len(CStr(CInt(Welcome.ATSB * ((100 - Welcome.ETCSB) / 100))))

                        sWriter.WriteLine("Speed" & Space(27) & "North Bound" & Space(5) & Welcome.SNB & " mph" & Space(2) & "South Bound" & Space(4) & Welcome.SSB & " mph")
                        sWriter.WriteLine("Approach Traffic" & Space(16) & "NB Stopping" & Space(Tab1) & CInt(Welcome.ATNB * ((100 - Welcome.ETCNB) / 100)) _
                                     & " vph  SB Stopping" & Space(Tab2) & CInt(Welcome.ATSB * ((100 - Welcome.ETCSB) / 100)) & " vph")
                        sWriter.WriteLine(Space(32) & "NB ETC-only" & Space(Tab1) & CInt(Welcome.ATNB * (Welcome.ETCNB / 100)) _
                                     & " vph  SB ETC-only" & Space(Tab2) & CInt(Welcome.ATSB * Welcome.ETCSB / 100) & " vph")

                        sWriter.WriteLine("")
                    End If

                Else
                    'Other configuratons
                    Tab1 = 6 - Microsoft.VisualBasic.Len(Welcome.ATMax)
                    sWriter.WriteLine("Arterial Speed" & Space(18) & Welcome.Speed & Space(4) & "mph")
                    sWriter.WriteLine("Max Approach Traffic" & Space(12) & Welcome.ATMax & Space(Tab1) & "vph")
                    sWriter.WriteLine("")
                End If
            End If

            sWriter.WriteLine(Space(10) & "Environmental Data")
            sWriter.WriteLine(Space(0) & "Temperature" & Space(21) & Welcome.Temperature & " F")
            sWriter.WriteLine(Space(0) & "Reid Vapor Pressure" & Space(13) & Welcome.RVP & " psi")
            sWriter.WriteLine(Space(0) & "Land Use" & Space(24) & Welcome.LandUse)
            sWriter.WriteLine(Space(0) & "Stability Class" & Space(17) & Welcome.CLASLetter)
            sWriter.WriteLine(Space(0) & "Surface Roughness" & Space(15) & Welcome.ZO & " cm")
            sWriter.WriteLine(Space(0) & "1 Hr. Background Concentration" & Space(2) & Welcome.COBack1Hr & " ppm")
            sWriter.WriteLine(Space(0) & "8 Hr. Background Concentration" & Space(2) & Welcome.COBack8Hr & " ppm")
            sWriter.WriteLine("")
            sWriter.WriteLine(Space(16) & "Results")
            sWriter.WriteLine(Space(4) & "(ppm, including background CO)")
            sWriter.WriteLine(Space(4) & "Receptor   Max 1-Hr   Max 8-Hr")
            sWriter.WriteLine(Space(4) & "--------   --------   --------")

            For i = 1 To 17
                If (Welcome.Conc1(i) > 35 Or Welcome.Conc8(i) > 9) Then Welcome.PassFail = False
                Tab1 = 9 - Microsoft.VisualBasic.Len(CStr(i))
                If Fix(Welcome.Conc1(i)) = Welcome.Conc1(i) Then
                    Tab2 = 10 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc1(i)))
                Else
                    Tab2 = 12 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc1(i)))
                End If
                If Fix(Welcome.Conc8(i)) = Welcome.Conc8(i) Then
                    Tab3 = 9 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc8(i)))
                Else
                    Tab3 = 11 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc8(i)))
                End If

                sWriter.WriteLine(Space(Tab1) & i & Space(Tab2) & Format(Welcome.Conc1(i), "#0.0") & Space(Tab3) & Format(Welcome.Conc8(i), "#0.0"))
            Next i

            If (Welcome.IntType <> "East Tee" And Welcome.IntType <> "North Tee" And Welcome.IntType <> "West Tee" And Welcome.IntType <> "South Tee") Then
                For i = 18 To 20
                    If (Welcome.Conc1(i) > 35 Or Welcome.Conc8(i) > 9) Then Welcome.PassFail = False
                    Tab1 = 9 - Microsoft.VisualBasic.Len(CStr(i))
                    If Fix(Welcome.Conc1(i)) = Welcome.Conc1(i) Then
                        Tab2 = 10 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc1(i)))
                    Else
                        Tab2 = 12 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc1(i)))
                    End If
                    If Fix(Welcome.Conc8(i)) = Welcome.Conc8(i) Then
                        Tab3 = 9 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc8(i)))
                    Else
                        Tab3 = 11 - Microsoft.VisualBasic.Len(CStr(Welcome.Conc8(i)))
                    End If

                    sWriter.WriteLine(Space(Tab1) & i & Space(Tab2) & Format(Welcome.Conc1(i), "#0.0") & Space(Tab3) & Format(Welcome.Conc8(i), "#0.0"))
                Next i
            End If

            'Checks for pass/fail
            For i = 1 To 17
                'Checks for 1 hr exceedances
                If Welcome.Conc1(i) >= 35 Then Welcome.PassFail = False

                'Checks for 8 hr exceedances
                If Welcome.Conc8(i) >= 9 Then Welcome.PassFail = False
            Next i

            If (Welcome.IntType = "East Tee" Or Welcome.IntType = "South Tee" Or Welcome.IntType = "West Tee" Or Welcome.IntType = "North Tee") Then
                'do nothing
            Else
                'Calculations on receptors 18-20
                For i = 18 To 20
                    'Checks for 1 hr exceedances
                    If Welcome.Conc1(i) >= 35 Then Welcome.PassFail = False

                    'Checsk for 8 hr exceedances
                    If Welcome.Conc8(i) >= 9 Then Welcome.PassFail = False
                Next i
            End If

            sWriter.WriteLine("")
            'Prints pass/fail message
            If Welcome.PassFail = False Then
                sWriter.WriteLine(Space(0) & "***********************************************")
                sWriter.WriteLine(Space(0) & "*********PROJECT FAILS SCREENING MODEL*********")
                sWriter.WriteLine(Space(0) & "*********DETAILED MODELING IS REQUIRED*********")
                sWriter.WriteLine(Space(0) & "***********************************************")
            Else
                sWriter.WriteLine(Space(0) & "************************************************")
                sWriter.WriteLine(Space(0) & "*****************PROJECT PASSES*****************")
                sWriter.WriteLine(Space(0) & "*NO EXCEEDANCES OF NAAQ STANDARDS ARE PREDICTED*")
                sWriter.WriteLine(Space(0) & "************************************************")

            End If

            sWriter.Flush()
            sWriter.Close()
        End If

    End Sub





    '****************************************************************************************************************************************
    '**********************************************Bottom Navigation Buttons*****************************************************************
    '***************************************************************************************************************************************
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        If PrintDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
            PrintDocument1.Print()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to return to the Intersection Data screen without saving.", vbYesNo, "Save data?")
        If TestMsg = vbYes Then
            SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
            SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
            SaveFileDialog1.FileName = ""

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Welcome.FDOTin = SaveFileDialog1.FileName
                Welcome.SaveFile()
            End If
        End If

        Select Case IntType
            Case ""
                My.Forms.Int4X4.Show()
            Case "4 X 4"
                My.Forms.Int4X4.Show()
            Case "4 X 6"
                My.Forms.Int4X6.Show()
            Case "6 X 4"
                My.Forms.Int6X4.Show()
            Case "6 X 6"
                My.Forms.Int6X6.Show()
            Case "East Tee"
                My.Forms.EastTee.Show()
            Case "North Tee"
                My.Forms.NorthTee.Show()
            Case "Toll Booth"
                My.Forms.TollBooth.Show()
            Case "West Tee"
                My.Forms.WestTee.Show()
            Case "South Tee"
                My.Forms.SouthTee.Show()
            Case "N-S Diamond"
                My.Forms.NSDiamond.Show()
            Case "E-W Diamond"
                My.Forms.I11.Show()
        End Select

        Me.Visible = False
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SaveOutputFile()
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Welcome.TestMsg = MsgBox("Click 'Yes' to save inputs or 'No' to return to the Title screen without saving.", vbYesNo, "Save data?")
        If Welcome.TestMsg = vbYes Then
            SaveFileDialog1.InitialDirectory = Welcome.PrimaryDirectory & "\UsrFiles\"
            SaveFileDialog1.Filter = "Input files (*.in)|*.in|All files (*.*)|*.*"
            SaveFileDialog1.FileName = ""

            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                Welcome.FDOTin = SaveFileDialog1.FileName
                Welcome.SaveFile()
            End If
        End If

        My.Forms.Title.Show()
        Me.Visible = False
    End Sub

    Private Sub Results_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox171.TextChanged

    End Sub
End Class