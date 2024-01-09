Imports System
Imports System.IO
Imports System.Collections
Imports System.CodeDom.Compiler

Public Class Welcome
    'General Global Variables
    Public PassFail As Boolean
    Public StreamToDisplay As StreamReader
    Public PrimaryDirectory As String
    Public TestMsg As String
    Public EFArray(65, 40) As Single
    Public InputsCorrect(4) As Boolean
    Public QuickVerify As Boolean = False
    Public EWTollBooth As Boolean = True
    Public IFR(150) As String
    Public sAppPath As String
    Public NumInputLines As Integer
    Public LineOfText As String
    Public CALInputLine(111) As String
    Public RandNum As Integer

    'Global Constants
    Public Const ZR = 6
    Public Const ATIM = 60
    Public Const VS = 0
    Public Const VD = 0
    Public Const SCAL = 0.3048
    Public Const IOPT = 1
    Public Const IDEBUG = 1
    Public Const TYP = "'AG'"
    Public Const HL = 0
    Public Const YFAC = 3
    Public Const SFR = 1600
    Public Const SFRRamps = 1500
    Public Const ST = 1
    Public Const AT = 3
    Public Const U = 1
    Public Const BRG = 0
    Public Const MIXH = 1000
    Public Const AMB = 0
    Public Const VAR = "'Y'"
    Public Const DEGR = 5
    Public Const VAL1 = 0
    Public Const VAL2 = 71
    Public Const NM = 1
    Public Const PRINT2 = 0
    Public Const MODE = "'CO'"
    Public Const TPF = 0.6
    Public Const RVP As Single = 13.3

    'Multiplier Factors
    Public MultAcc As Single
    Public MultHwyOn As Single
    Public MultTollBooth As Single

    'Title Screen Global Variable Declarations
    Public Job As String
    Public FacilityName As String
    Public UsersName As String
    Public RunName As String
    Public ProjectYear As String
    Public LandUse As String
    Public ZO As Integer
    Public CLAS As Integer
    Public CLASLetter As String
    Public NL As Integer
    Public COBack1Hr As String
    Public COBack8Hr As String
    Public Conc8(20) As Single
    Public Conc1(20) As Single

    'District Screen Global Variable Declarations
    Public DistrictNum As Integer
    Public Temperature As String

    'IntersectionType Screen Global Variable Declarations
    Public IntType As String
    Public XR(20) As Integer
    Public YR(20) As Integer
    Public NR As Integer

    'Intersection Data Global Variable Declarations
    Public SNB As String
    Public ATNB As String
    Public SEB As String
    Public ATEB As String
    Public SSB As String
    Public ATSB As String
    Public SWB As String
    Public ATWB As String
    Public ATMax As Integer
    Public ATLeft As Integer
    Public ATRight As Integer
    Public ATQ As Integer
    Public FTMax As Integer
    Public FTLeft As Integer
    Public FTRight As Integer
    Public Speed As Integer
    Public HwySpeed As Integer

    'Variables Unique to Diamonds
    Public ORNB As String
    Public OREB As String
    Public ORSB As String
    Public ORWB As String
    Public FTDep As Integer
    Public ATDep As Integer

    'Variables Unique to Tollbooths
    Public ETCSB As String
    Public ETCWB As String
    Public ETCNB As String
    Public ETCEB As String

    'CO FL 2012 input and output file names
    Public FDOTin As String
    Public FDOTout As String

    'Variables used to extract and interpolate EF's to be used in CAL3QHC input file
    Public EFNB As Single
    Public EFEB As Single
    Public EFSB As Single
    Public EFWB As Single
    Public EFFree As Single
    Public EFFreeAcc As Single
    Public EFTollAcc As Single
    Public EF10mph As Single
    Public EFHwy As Single
    Public EFHwyOn As Single
    Public EFId As Single
    Public EFLt As Single
    Public EFRt As Single





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Hide the Welcome Page
        Me.Hide()

        ' Loads the projectDescription Windows
        Dim projectDescription As New Title()
        projectDescription.Show()



    End Sub

    Public Sub RoundButton(btn As Button)
        btn.FlatStyle = FlatStyle.Flat
        btn.FlatAppearance.BorderSize = 0.5
        btn.BackColor = Color.LightGray
        btn.ForeColor = Color.Black
        btn.Cursor = Cursors.Hand

        Dim Path As New Drawing2D.GraphicsPath

        Path.StartFigure()
        ' Append a line segment to the current figure (left-top corner)
        Path.AddLine(0, 0, 50, 0)
        ' Append a line segment to the current figure (right-top corner)
        Path.AddLine(btn.Width - 50, 0, btn.Width, 0)
        ' Append a line segment to the current figure (right-bottom corner)
        Path.AddLine(btn.Width, btn.Height, btn.Width - 50, btn.Height)
        ' Append a line segment to the current figure (left-bottom corner)
        Path.AddLine(50, btn.Height, 0, btn.Height)
        ' Close the current figure
        Path.CloseFigure()

        ' Set the region associated with the control
        btn.Region = New Region(Path)
    End Sub



    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundButton(Button1)
        'Gets the primary directory
        PrimaryDirectory = Directory.GetCurrentDirectory()

    End Sub



    '****************************************************************************************************
    '****************************************Sub MakeARun************************************************
    '****************************************************************************************************
    Public Sub MakeARun()
        'Calls WriteCAL3QIN
        WriteCAL3QHCIN()

        'Calls GenerateOutput
        GenerateOutput()


        My.Forms.Results.Show()
    End Sub

    '****************************************************************************************************
    '***************************Sub ClearAll - Clears all inputs for a new user run**********************
    '****************************************************************************************************
    Public Sub ClearAll()
        Dim i As Integer
        Dim TempIntType As String

        TempIntType = IntType

        Job = ""
        FacilityName = ""
        UsersName = ""
        RunName = ""
        ProjectYear = ""
        LandUse = ""
        ZO = 0
        CLAS = 0
        NL = 0
        COBack1Hr = 0
        DistrictNum = 0
        IntType = ""
        NR = 0
        SNB = ""
        ATNB = ""
        SEB = ""
        ATEB = ""
        SSB = ""
        ATSB = ""
        SWB = ""
        ATWB = ""
        ATMax = 0
        ATLeft = 0
        ATRight = 0
        ATQ = 0
        FTMax = 0
        FTLeft = 0
        FTRight = 0
        ORNB = ""
        OREB = ""
        ORSB = ""
        ORWB = ""
        ETCSB = ""
        ETCWB = ""
        ETCNB = ""
        ETCEB = ""

        For i = 1 To 20
            XR(i) = 0
            YR(i) = 0
        Next

        Select Case TempIntType
            Case "4 X 4"
                _4X4.Init4X4()
            Case "4 X 6"
                _4X6.Init4X6()
            Case ("6 X 4")
                _6X4.Init6X4()
            Case ("6 X 6")
                _6X6.Init6X6()
            Case "East Tee"
                East_Tee.InitEastTee()
            Case ("North Tee")
                North_Tee.InitNorthTee()
            Case ("Toll Booth")
                TollBoothEW.InitTollBooth()
            Case ("West Tee")
                WestTee.InitWestTee()
            Case ("South Tee")
                SouthTee.InitSouthTee()
            Case ("N-S Diamond")
                NorthSouthFreeway.InitNSDiamond()
            Case ("E-W Diamond")
                EastWestFreeway.InitEWDiamond()
        End Select
    End Sub






    '****************************************************************************************************
    '*******************************Sub FillEFArray - Responds to call from District Form****************
    '****************************************************************************************************
    Sub FillEFArray()
        Dim i As Integer
        Dim j As Integer


        Console.WriteLine($"Current Directory: {Directory.GetCurrentDirectory()}")

        'Opens the Appropriate EF File for the Selected District
        Directory.SetCurrentDirectory(PrimaryDirectory)

        Select Case DistrictNum
            Case 1
                StreamToDisplay = New StreamReader("EFTextFiles\Dist1EF.txt")
            Case 2
                StreamToDisplay = New StreamReader("EFTextFiles\Dist2EF.txt")
            Case 3
                StreamToDisplay = New StreamReader("EFTextFiles\Dist3EF.txt")
            Case 4
                StreamToDisplay = New StreamReader("EFTextFiles\Dist4EF.txt")
            Case 5
                StreamToDisplay = New StreamReader("EFTextFiles\Dist5EF.txt")
            Case 6
                StreamToDisplay = New StreamReader("EFTextFiles\Dist6EF.txt")
            Case 7
                StreamToDisplay = New StreamReader("EFTextFiles\Dist7EF.txt")
        End Select

        'Reads EF's from the Appropriate District Input File
        LineOfText = StreamToDisplay.ReadLine() 'First input line contains unused variable, District Name

        Do Until StreamToDisplay.EndOfStream
            For i = 0 To 13
                For j = 0 To 40
                    LineOfText = StreamToDisplay.ReadLine()
                    EFArray(i, j) = LineOfText
                Next j
            Next i
        Loop

        StreamToDisplay.Close()
    End Sub






    '****************************************************************************************************
    '**************Sub GetEFs - Extracts EFs for the given district from the appropriate text file*******
    '****************************************************************************************************
    Sub GetEFs()
        Dim x As Single
        Dim TempSingle As Single

        'Gets EFId, EF10mph, EFRt, and EFLt
        EFId = EFArray(0, (ProjectYear - 2010))
        EF10mph = EFArray(10 / 5, (ProjectYear - 2010))
        EFRt = EFArray(15 / 5, (ProjectYear - 2010))
        EFLt = EFArray(20 / 5, (ProjectYear - 2010))

        'Gets other needed EFs
        If IntType <> "South Tee" Then
            EFSB = EFArray((CInt(SSB) / 5), (ProjectYear - 2010))
        End If
        If IntType <> "West Tee" Then
            EFWB = EFArray((CInt(SWB) / 5), (ProjectYear - 2010))
        End If
        If IntType <> "North Tee" Then
            EFNB = EFArray((CInt(SNB) / 5), (ProjectYear - 2010))
        End If
        If IntType <> "East Tee" Then
            EFEB = EFArray((CInt(SEB) / 5), (ProjectYear - 2010))
        End If

        'Choses largest EF of free flow link values
        EFFree = 0

        If IntType <> "South Tee" Then
            If EFFree < EFSB Then
                EFFree = EFSB
                Speed = CInt(SSB)
            End If
        End If
        If IntType <> "West Tee" Then
            If EFFree < EFWB Then
                EFFree = EFWB
                Speed = CInt(SWB)
            End If
        End If
        If IntType <> "North Tee" Then
            If EFFree < EFNB Then
                EFFree = EFNB
                Speed = CInt(SNB)
            End If
        End If
        If IntType <> "East Tee" Then
            If EFFree < EFEB Then
                EFFree = EFEB
                Speed = CInt(SEB)
            End If
        End If

        'Calculates Multipliers
        'First calculates as a function of speed
        MultAcc = (-0.0007 * Speed ^ 3) + (0.0417 * Speed ^ 2) + (0.4407 * Speed) - 23.493
        MultTollBooth = (0.0015 * Speed ^ 3) - (0.2408 * Speed ^ 2) + (12.408 * Speed) - 191.41

        'Then adjusts for the year
        If CInt(ProjectYear) < 2025 Then
            TempSingle = MultAcc
            MultAcc = TempSingle * ((0.014 * ProjectYear) - 27.213)
            TempSingle = MultTollBooth
            MultTollBooth = TempSingle * ((0.014 * ProjectYear) - 27.213)
        Else
            TempSingle = MultAcc
            MultAcc = TempSingle * 1.137
            TempSingle = MultTollBooth
            MultTollBooth = TempSingle * 1.137
        End If

        'Then adjusts for fraction of traffic on arterial links
        x = (1 / 2) * (6 * 5280 / 3600) * (Speed / 6) ^ 2
        TempSingle = MultAcc
        MultAcc = (75 / 120) * (x / 1000) * (TempSingle) + (1) * (1 - (75 / 120) * (x / 1000))

        If MultTollBooth < 1 Then MultTollBooth = 1
        If MultAcc < 1 Then MultAcc = 1

        'Adjusts EF's with multiplier factors
        EFFreeAcc = EFFree * MultAcc
        EFTollAcc = EFFree * MultTollBooth

        'Rounds EF's to the .1 Place
        EFFree = (Fix(EFFree * 10 + 0.5)) / 10
        EFFreeAcc = (Fix(EFFreeAcc * 10 + 0.5)) / 10
        EFTollAcc = (Fix(EFTollAcc * 10 + 0.5)) / 10
        EFId = (Fix(EFId * 10 + 0.5)) / 10
        EFLt = (Fix(EFLt * 10 + 0.5)) / 10
        EFRt = (Fix(EFRt * 10 + 0.5)) / 10
        EF10mph = (Fix(EF10mph * 10 + 0.5)) / 10
    End Sub





    '****************************************************************************************************
    '******Sub GetDiamondEFs - Extracts EFs for the given district from the appropriate text file********
    '****************************************************************************************************
    Sub GetDiamondEFs()
        Dim x As Single
        Dim TempSingle As Single

        'Gets EFId, EFRt, and EFLt
        EFId = EFArray(0, (ProjectYear - 2010))
        EFRt = EFArray(15 / 5, (ProjectYear - 2010))
        EFLt = EFArray(20 / 5, (ProjectYear - 2010))

        'Gets other needed EFs
        EFSB = EFArray((CInt(SSB) / 5), (ProjectYear - 2010))
        EFWB = EFArray((CInt(SWB) / 5), (ProjectYear - 2010))
        EFNB = EFArray((CInt(SNB) / 5), (ProjectYear - 2010))
        EFEB = EFArray((CInt(SEB) / 5), (ProjectYear - 2010))

        'Chooses the largest EF for FreeFlow and HwyFlow
        EFFree = 0
        EFHwy = 0

        If IntType = "N-S Diamond" Then
            If EFFree < EFWB Then
                EFFree = EFWB
                Speed = CInt(SWB)
            End If
            If EFFree < EFEB Then
                EFFree = EFEB
                Speed = CInt(SEB)
            End If
            If EFHwy < EFSB Then
                EFHwy = EFSB
                HwySpeed = CInt(SSB)
            End If
            If EFHwy < EFNB Then
                EFHwy = EFNB
                HwySpeed = CInt(SNB)
            End If
        Else
            If EFHwy < EFWB Then
                EFHwy = EFWB
                HwySpeed = CInt(SWB)
            End If
            If EFHwy < EFEB Then
                EFHwy = EFEB
                HwySpeed = CInt(SEB)
            End If
            If EFFree < EFSB Then
                EFFree = EFSB
                Speed = CInt(SSB)
            End If
            If EFFree < EFNB Then
                EFFree = EFNB
                Speed = CInt(SNB)
            End If
        End If

        'Calculates Multipliers
        'First calculates as a function of speed
        MultAcc = (-0.0007 * Speed ^ 3) + (0.0417 * Speed ^ 2) + (0.4407 * Speed) - 23.493
        MultHwyOn = (0.0013 * HwySpeed ^ 3) - (0.2099 * HwySpeed ^ 2) + (10.74 * HwySpeed) - 161.77

        'Then adjusts for the year
        If CInt(ProjectYear) < 2025 Then
            TempSingle = MultAcc
            MultAcc = TempSingle * ((0.014 * ProjectYear) - 27.213)
            TempSingle = MultHwyOn
            MultHwyOn = TempSingle * ((0.014 * ProjectYear) - 27.213)
        Else
            TempSingle = MultAcc
            MultAcc = TempSingle * 1.137
            TempSingle = MultHwyOn
            MultHwyOn = TempSingle * 1.137
        End If

        'Then adjusts for fraction of traffic on arterial links
        x = (1 / 2) * (6 * 5280 / 3600) * (Speed / 6) ^ 2
        TempSingle = MultAcc
        MultAcc = (75 / 120) * (x / 1000) * (TempSingle) + (1) * (1 - (75 / 120) * (x / 1000))

        If MultHwyOn < 1 Then MultHwyOn = 1
        If MultAcc < 1 Then MultAcc = 1

        'Adjusts EF's with multiplier factors
        EFFreeAcc = EFFree * MultAcc
        EFHwyOn = EFHwy * MultHwyOn

        'Rounds EF's to the .1 Place
        EFFreeAcc = (Fix(EFFreeAcc * 10 + 0.5)) / 10
        EFLt = (Fix(EFLt * 10 + 0.5)) / 10
        EFRt = (Fix(EFRt * 10 + 0.5)) / 10
        EFHwy = (Fix(EFHwy * 10 + 0.5)) / 10
        EFHwyOn = (Fix(EFHwyOn * 10 + 0.5)) / 10
        EFId = (Fix(EFId * 10 + 0.5)) / 10
    End Sub





    '****************************************************************************************************************************************
    '********************************************************Writes CAL3QHC Input File*******************************************************
    '****************************************************************************************************************************************
    Sub WriteCAL3QHCIN()
        Directory.SetCurrentDirectory(PrimaryDirectory)

        'Writes CALInputLine Array out to "incal3qhc.in"
        Directory.SetCurrentDirectory(PrimaryDirectory)
        Dim sWriter As IO.StreamWriter = New IO.StreamWriter("incal3qhc.in")
        Dim i As Integer

        For i = 1 To NumInputLines
            LineOfText = CALInputLine(i)
            sWriter.WriteLine(LineOfText)
        Next

        sWriter.Flush()
        sWriter.Close()
    End Sub

    Sub GenerateOutput()
        'Runs CAL3QHC
        Directory.SetCurrentDirectory(PrimaryDirectory)
        'sAppPath = "CAL3QHC incal3qhc" & RunNumber & ".in outcal3qhc" & RunNumber & ".out"
        sAppPath = "CAL3QHC incal3qhc.in outcal3qhc.out"
        Shell(sAppPath, vbMaximizedFocus)

        'Reads resulting concentrations from outcal3qhc.out
        ReadCAL3QHCOUT()

        'Fills out onscreen output screen
        Results.TextBox2.Text = Format$(Now, "Long Date")

        Results.TextBox10.Text = Job
        Results.TextBox8.Text = FacilityName
        Results.TextBox6.Text = UsersName
        Results.TextBox4.Text = RunName
        Results.TextBox26.Text = DistrictNum
        Results.TextBox28.Text = ProjectYear

        If IntType = "Toll Booth" Then
            If EWTollBooth = True Then
                Results.TextBox30.Text = "E-W Freeway " & IntType
            Else
                Results.TextBox30.Text = "N-S Freeway " & IntType
            End If
        Else
            Results.TextBox30.Text = IntType
        End If

        Results.TextBox38.Text = "Speed"
        Results.TextBox37.Text = "Approach Traffic"

        If IntType = "Toll Booth" Then
            If EWTollBooth = True Then
                Results.TextBox30.Text = "E-W Freeway " & IntType
            Else
                Results.TextBox30.Text = "N-S Freeway " & IntType
            End If
        Else
            Results.TextBox30.Text = IntType
        End If

        Results.TextBox38.Text = "Speed"
        Results.TextBox37.Text = "Approach Traffic"

        If IntType = "Toll Booth" Then
            If EWTollBooth = True Then
                Results.TextBox38.Text = "East Bound"
                Results.TextBox37.Text = "EB Stopping"
                Results.TextBox40.Text = SEB & " mph"
                Results.TextBox39.Text = CInt(ATEB * (100 - ETCEB) / 100) & " vph"
                Results.TextBox34.Text = "West Bound"
                Results.TextBox42.Text = "WB Stopping"
                Results.TextBox36.Text = SWB & " mph"
                Results.TextBox41.Text = CInt(ATWB * (100 - ETCWB) / 100) & " vph"
                If ETCEB > 0 Then
                    Results.TextBox32.Text = "EB ETC-only"
                    Results.TextBox35.Text = CInt(ATEB * ETCEB / 100) & " vph"
                Else
                    Results.TextBox32.Text = ""
                    Results.TextBox35.Text = ""
                End If
                If ETCWB > 0 Then
                    Results.TextBox44.Text = "WB ETC-only"
                    Results.TextBox43.Text = CInt(ATWB * ETCWB / 100) & " vph"
                Else
                    Results.TextBox44.Text = ""
                    Results.TextBox43.Text = ""
                End If
            Else
                Results.TextBox38.Text = "North Bound"
                Results.TextBox37.Text = "NB Stopping"
                Results.TextBox40.Text = SNB & " mph"
                Results.TextBox39.Text = CInt(ATNB * (100 - ETCNB) / 100) & " vph"
                Results.TextBox34.Text = "South Bound"
                Results.TextBox42.Text = "SB Stopping"
                Results.TextBox36.Text = SSB & " mph"
                Results.TextBox41.Text = CInt(ATSB * (100 - ETCSB) / 100) & " vph"
                If ETCNB > 0 Then
                    Results.TextBox32.Text = "NB ETC-only"
                    Results.TextBox35.Text = CInt(ATNB * ETCNB / 100) & " vph"
                Else
                    Results.TextBox32.Text = ""
                    Results.TextBox35.Text = ""
                End If
                If ETCSB > 0 Then
                    Results.TextBox44.Text = "SB ETC-only"
                    Results.TextBox43.Text = CInt(ATSB * ETCSB / 100) & " vph"
                Else
                    Results.TextBox44.Text = ""
                    Results.TextBox43.Text = ""
                End If
            End If

        ElseIf (IntType = "N-S Diamond" Or IntType = "E-W Diamond") Then
            Results.TextBox38.Text = "Arterial"
            Results.TextBox34.Text = "Freeway"
            Results.TextBox37.Text = "Arterial"
            Results.TextBox42.Text = "Freeway"
            Results.TextBox40.Text = Speed & " mph"
            Results.TextBox36.Text = HwySpeed & " mph"
            Results.TextBox39.Text = ATMax & " vph"
            Results.TextBox41.Text = FTMax & " vph"
            Results.TextBox32.Text = ""
            Results.TextBox35.Text = ""
            Results.TextBox44.Text = ""
            Results.TextBox43.Text = ""
        Else
            Results.TextBox38.Text = "Arterial"
            Results.TextBox40.Text = Speed & " mph"
            Results.TextBox37.Text = "Arterial"
            Results.TextBox39.Text = ATMax & " vph"
            Results.TextBox34.Text = ""
            Results.TextBox36.Text = ""
            Results.TextBox44.Text = ""
            Results.TextBox42.Text = ""
            Results.TextBox41.Text = ""
            Results.TextBox32.Text = ""
            Results.TextBox35.Text = ""
            Results.TextBox44.Text = ""
            Results.TextBox43.Text = ""
        End If

        Results.TextBox14.Text = Temperature & " °F"
        Results.TextBox16.Text = RVP & " psi"
        Results.TextBox18.Text = LandUse
        Results.TextBox20.Text = CLASLetter
        Results.TextBox22.Text = ZO & " cm"
        Results.TextBox24.Text = Format(CSng(COBack1Hr), "#0.0") & " ppm"
        Results.TextBox173.Text = Format(CSng(COBack8Hr), "#0.0") & " ppm"

        'Outputs for intersections with 20 receptors or leaves blanks for the Tee Intersections with 17 receptors
        If (IntType = "East Tee" Or IntType = "North Tee" Or IntType = "West Tee" Or IntType = "South Tee") Then
            Results.TextBox125.Text = ""
            Results.TextBox124.Text = ""
            Results.TextBox123.Text = ""
            Results.TextBox115.Text = ""
            Results.TextBox114.Text = ""
            Results.TextBox113.Text = ""
            Results.TextBox105.Text = ""
            Results.TextBox104.Text = ""
            Results.TextBox103.Text = ""
        Else
            Results.TextBox125.Text = "18"
            Results.TextBox124.Text = "19"
            Results.TextBox123.Text = "20"
            Results.TextBox115.Text = Format(Conc1(18), "#0.0")
            Results.TextBox114.Text = Format(Conc1(19), "#0.0")
            Results.TextBox113.Text = Format(Conc1(20), "#0.0")
            Results.TextBox105.Text = Format(Conc8(18), "#0.0")
            Results.TextBox104.Text = Format(Conc8(19), "#0.0")
            Results.TextBox103.Text = Format(Conc8(20), "#0.0")
        End If

        Results.TextBox152.Text = Format(Conc1(1), "#0.0")
        Results.TextBox151.Text = Format(Conc1(2), "#0.0")
        Results.TextBox150.Text = Format(Conc1(3), "#0.0")
        Results.TextBox149.Text = Format(Conc1(4), "#0.0")
        Results.TextBox148.Text = Format(Conc1(5), "#0.0")
        Results.TextBox147.Text = Format(Conc1(6), "#0.0")
        Results.TextBox146.Text = Format(Conc1(7), "#0.0")
        Results.TextBox145.Text = Format(Conc1(8), "#0.0")
        Results.TextBox144.Text = Format(Conc1(9), "#0.0")
        Results.TextBox143.Text = Format(Conc1(10), "#0.0")
        Results.TextBox122.Text = Format(Conc1(11), "#0.0")
        Results.TextBox121.Text = Format(Conc1(12), "#0.0")
        Results.TextBox120.Text = Format(Conc1(13), "#0.0")
        Results.TextBox119.Text = Format(Conc1(14), "#0.0")
        Results.TextBox118.Text = Format(Conc1(15), "#0.0")
        Results.TextBox117.Text = Format(Conc1(16), "#0.0")
        Results.TextBox116.Text = Format(Conc1(17), "#0.0")

        Results.TextBox142.Text = Format(Conc8(1), "#0.0")
        Results.TextBox141.Text = Format(Conc8(2), "#0.0")
        Results.TextBox140.Text = Format(Conc8(3), "#0.0")
        Results.TextBox139.Text = Format(Conc8(4), "#0.0")
        Results.TextBox138.Text = Format(Conc8(5), "#0.0")
        Results.TextBox137.Text = Format(Conc8(6), "#0.0")
        Results.TextBox136.Text = Format(Conc8(7), "#0.0")
        Results.TextBox135.Text = Format(Conc8(8), "#0.0")
        Results.TextBox134.Text = Format(Conc8(9), "#0.0")
        Results.TextBox133.Text = Format(Conc8(10), "#0.0")
        Results.TextBox112.Text = Format(Conc8(11), "#0.0")
        Results.TextBox111.Text = Format(Conc8(12), "#0.0")
        Results.TextBox110.Text = Format(Conc8(13), "#0.0")
        Results.TextBox109.Text = Format(Conc8(14), "#0.0")
        Results.TextBox108.Text = Format(Conc8(15), "#0.0")
        Results.TextBox107.Text = Format(Conc8(16), "#0.0")
        Results.TextBox106.Text = Format(Conc8(17), "#0.0")


        'Prints pass/fail message
        If PassFail = False Then
            Results.TextBox171.Visible = True
            Results.TextBox169.Visible = False
        Else
            Results.TextBox169.Visible = True
            Results.TextBox171.Visible = False
        End If
    End Sub






    '****************************************************************************************************************************************
    '********************************************************Reads CAL3QHC Output File*******************************************************
    '****************************************************************************************************************************************
    Sub ReadCAL3QHCOUT()
        Dim i As Integer
        Dim Delay As Integer = 1000000000
        Dim ReadLine(220) As String
        Dim PPMString As String

        PassFail = True
        Directory.SetCurrentDirectory(PrimaryDirectory)

        'Opens the CAL3QHC output file
        For i = 1 To Delay
        Next
        Try
            StreamToDisplay = New StreamReader("outcal3qhc.out")
        Catch
            For i = 1 To Delay
            Next i
            Try
                StreamToDisplay = New StreamReader("outcal3qhc.out")
            Catch
                Exit Sub
            End Try
        End Try

        'Reads the CAL3QHC output file into the array ReadLine
        i = 1
        Do Until StreamToDisplay.EndOfStream
            ReadLine(i) = StreamToDisplay.ReadLine()
            i = i + 1
        Loop

        StreamToDisplay.Close()

        PPMString = ReadLine(i - 4)

        'Reads 1 hr. concentration values from outcal3qhc.out and adds in background CO
        If (IntType <> "East Tee" And IntType <> "North Tee" And IntType <> "West Tee" And IntType <> "South Tee") Then
            For i = 20 To 18 Step -1
                Conc1(i) = CSng(Microsoft.VisualBasic.Right(PPMString, 6))
                Conc1(i) = Conc1(i) + CSng(COBack1Hr)
                Conc1(i) = Format(Conc1(i), "#0.0")
                PPMString = Microsoft.VisualBasic.Left(PPMString, (i * 6 + 3))
            Next i
        End If

        For i = 17 To 1 Step -1
            Conc1(i) = CSng(Microsoft.VisualBasic.Right(PPMString, 6))
            Conc1(i) = Conc1(i) + CSng(COBack1Hr)
            Conc1(i) = Format(Conc1(i), "#0.0")
            PPMString = Microsoft.VisualBasic.Left(PPMString, (i * 6 + 3))
        Next i

        'Calculations on receptors 1-17
        For i = 1 To 17

            'Rounds to .1
            Conc1(i) = (Fix(Conc1(i) * 10 + 0.5)) / 10

            'Checks for 1 hr exceedances
            If Conc1(i) >= 35 Then PassFail = False

            'Calculates 8 hr concentrations via Total Persistence Factor
            Conc8(i) = (Fix((Conc1(i) * TPF) * 10 + 0.5)) / 10

            'Checsk for 8 hr exceedances
            If Conc8(i) >= 9 Then PassFail = False
        Next i

        If (IntType = "East Tee" Or IntType = "South Tee" Or IntType = "West Tee" Or IntType = "North Tee") Then
            Exit Sub
        Else
            'Calculations on receptors 18-20
            For i = 18 To 20

                'Rounds to .1
                Conc1(i) = (Fix(Conc1(i) * 10 + 0.5)) / 10

                'Checks for 1 hr exceedancesF
                If Conc1(i) >= 35 Then PassFail = False

                'Calculates 8 hr concentrations via Total Persistence Factor
                Conc8(i) = (Fix((Conc1(i) * TPF) * 10 + 0.5)) / 10

                'Checsk for 8 hr exceedances
                If Conc8(i) >= 9 Then PassFail = False
            Next i
        End If
    End Sub







    '****************************************************************************************************************************************
    '*****************************************Builds input string array for CAL3QHC input files - 4X4****************************************
    '****************************************************************************************************************************************
    Sub Build4X4()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        '4X4-Specific Parameters
        NR = 20
        NumInputLines = 71
        NL = 20

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To (21)
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(22) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'NEXT, Write all Queue Links
        'South Bound Approach Queue Link
        CALInputLine(23) = 2
        CALInputLine(24) = "'SB Queue Link'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & -18 & " , " & 3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(25) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'South Bound Left Queue Link
        CALInputLine(26) = 2
        CALInputLine(27) = "'SB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & 0 & " , " & 3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(28) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'West Bound Approach Queue Link
        CALInputLine(29) = 2
        CALInputLine(30) = "'WB Queue Link'" & "," & TYP & ", " & 30 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(31) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'West Bound Left Queue Link
        CALInputLine(32) = 2
        CALInputLine(33) = "'WB Left Queue Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(34) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Approach Queue Link
        CALInputLine(35) = 2
        CALInputLine(36) = "'NB Queue Link'" & "," & TYP & ", " & 18 & " , " & -30 & " , " & 18 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(37) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Left Queue Link
        CALInputLine(38) = 2
        CALInputLine(39) = "'NB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & 0 & " , " & -3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(40) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Approach Queue Link
        CALInputLine(41) = 2
        CALInputLine(42) = "'EB Queue Link'" & "," & TYP & ", " & -30 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(43) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Left Queue Link
        CALInputLine(44) = 2
        CALInputLine(45) = "'EB Left Queue Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(46) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Approach Link
        CALInputLine(47) = 1
        CALInputLine(48) = "'SB Approach Link'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & -18 & " , " & 3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'SB Left Link
        CALInputLine(49) = 1
        CALInputLine(50) = "'SB Left Link'" & "," & TYP & ", " & 0 & " , " & 0 & " , " & 0 & " , " & 3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'SB Departure Link
        CALInputLine(51) = 1
        CALInputLine(52) = "'SB Departure Link'" & "," & TYP & ", " & 18 & " , " & 0 & " , " & 18 & " , " & 3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Approach Link
        CALInputLine(53) = 1
        CALInputLine(54) = "'WB Approach Link'" & "," & TYP & ", " & 0 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'WB Left Link
        CALInputLine(55) = 1
        CALInputLine(56) = "'WB Left Link'" & "," & TYP & ", " & 0 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'WB Departure Link
        CALInputLine(57) = 1
        CALInputLine(58) = "'WB Departure Link'" & "," & TYP & ", " & 0 & " , " & -18 & " , " & 3000 & " , " & -18 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Approach Link
        CALInputLine(59) = 1
        CALInputLine(60) = "'NB Approach Link'" & "," & TYP & ", " & 18 & " , " & 0 & " , " & 18 & " , " & -3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'NB Left Link
        CALInputLine(61) = 1
        CALInputLine(62) = "'NB Left Link'" & "," & TYP & ", " & 0 & " , " & 0 & " , " & 0 & " , " & -3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'NB Departure Link
        CALInputLine(63) = 1
        CALInputLine(64) = "'NB Departure Link'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & -18 & " , " & -3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Approach Link
        CALInputLine(65) = 1
        CALInputLine(66) = "'EB Approach Link'" & "," & TYP & ", " & 0 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'EB Left Link
        CALInputLine(67) = 1
        CALInputLine(68) = "'EB Left Link'" & "," & TYP & ", " & 0 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'EB Departure Link
        CALInputLine(69) = 1
        CALInputLine(70) = "'EB Departure Link'" & "," & TYP & ", " & 0 & " , " & 18 & " , " & -3000 & " , " & 18 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44

        'Last Line
        CALInputLine(71) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub






    '****************************************************************************************************************************************
    '*****************************************Builds input string array for CAL3QHC input files - 4X6****************************************
    '****************************************************************************************************************************************
    Sub Build4X6()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = 0
        If ATSB > ATMax Then ATMax = ATSB
        If ATWB > ATMax Then ATMax = ATWB
        If ATNB > ATMax Then ATMax = ATNB
        If ATEB > ATMax Then ATMax = ATEB

        ATLeft = CInt(ATMax * 0.15)
        ATQ = CInt(ATMax * 0.85)

        '4X6 -Specific Parameters
        NR = 20
        NumInputLines = 71
        NL = 20

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To (21)
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(22) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'NEXT, Write all Queue Links
        'West Bound Approach Queue Link
        CALInputLine(23) = 2
        CALInputLine(24) = "'WB Queue Link'" & "," & TYP & ", " & 48 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(25) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'West Bound Left Queue Link
        CALInputLine(26) = 2
        CALInputLine(27) = "'WB Left Queue Link'" & "," & TYP & ", " & 48 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(28) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Approach Queue Link
        CALInputLine(29) = 2
        CALInputLine(30) = "'NB Queue Link'" & "," & TYP & ", " & 3000 & " , " & -30 & " , " & 0 & " , " & 3 - 0 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(31) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Left Queue Link
        CALInputLine(32) = 2
        CALInputLine(33) = "'NB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & 0 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(34) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Approach Queue Link
        CALInputLine(35) = 2
        CALInputLine(36) = "'EB Queue Link'" & "," & TYP & ", " & -48 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(37) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Left Queue Link
        CALInputLine(38) = 2
        CALInputLine(39) = "'EB Left Queue Link'" & "," & TYP & ", " & -48 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(40) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'South Bound Approach Queue Link
        CALInputLine(41) = 2
        CALInputLine(42) = "'SB Queue Link'" & "," & TYP & ", " & -30 & " , " & 30 & " , " & -30 & " , " & 3000 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(43) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'South Bound Left Queue Link
        CALInputLine(44) = 2
        CALInputLine(45) = "'SB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & 0 & " , " & 3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(46) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Approach Link
        CALInputLine(47) = 1
        CALInputLine(48) = "'WB Approach Link'" & "," & TYP & ", " & 0 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'WB Left Link
        CALInputLine(49) = 1
        CALInputLine(50) = "'WB Left Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'WB Departure Link
        CALInputLine(51) = 1
        CALInputLine(52) = "'WB Departure Link'" & "," & TYP & ", " & 0 & " , " & -18 & " , " & 3000 & " , " & -18 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Approach Link
        CALInputLine(53) = 1
        CALInputLine(54) = "'NB Approach Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 30 & " , " & -3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'NB Left Link
        CALInputLine(55) = 1
        CALInputLine(56) = "'NB Left Link'" & "," & TYP & ", " & 0 & " , " & 18 & " , " & 0 & " , " & -3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'NB Departure Link
        CALInputLine(57) = 1
        CALInputLine(58) = "'NB Departure Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & -30 & " , " & -3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Approach Link
        CALInputLine(59) = 1
        CALInputLine(60) = "'EB Approach Link'" & "," & TYP & ", " & 0 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'EB Left Link
        CALInputLine(61) = 1
        CALInputLine(62) = "'EB Left Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'EB Departure Link
        CALInputLine(63) = 1
        CALInputLine(64) = "'EB Departure Link'" & "," & TYP & ", " & 0 & " , " & 18 & " , " & -3000 & " , " & 18 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Approach Link
        CALInputLine(65) = 1
        CALInputLine(66) = "'SB Approach Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & -30 & " , " & 3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'SB Left Link
        CALInputLine(67) = 1
        CALInputLine(68) = "'SB Left Link'" & "," & TYP & ", " & 0 & " , " & -18 & " , " & 0 & " , " & 3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'SB Departure Link
        CALInputLine(69) = 1
        CALInputLine(70) = "'SB Departure Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 30 & " , " & 3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'Last Line
        CALInputLine(71) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub






    '****************************************************************************************************************************************
    '*****************************************Builds input string array for CAL3QHC input files - 6X4****************************************
    '****************************************************************************************************************************************
    Sub Build6X4()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = 0
        If ATSB > ATMax Then ATMax = ATSB
        If ATWB > ATMax Then ATMax = ATWB
        If ATNB > ATMax Then ATMax = ATNB
        If ATEB > ATMax Then ATMax = ATEB

        ATLeft = CInt(ATMax * 0.15)
        ATQ = CInt(ATMax * 0.85)

        '6X4 -Specific Parameters
        NR = 20
        NumInputLines = 71
        NL = 20

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To (21)
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(22) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE


        'NEXT, Write all Queue Links
        'South Bound Approach Queue Link
        CALInputLine(23) = 2
        CALInputLine(24) = "'SB Queue Link'" & "," & TYP & ", " & -18 & " , " & 48 & " , " & -18 & " , " & 3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(25) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'South Bound Left Queue Link
        CALInputLine(26) = 2
        CALInputLine(27) = "'SB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & 48 & " , " & 0 & " , " & 3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(28) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'West Bound Approach Queue Link
        CALInputLine(29) = 2
        CALInputLine(30) = "'WB Queue Link'" & "," & TYP & ", " & 30 & " , " & 30 & " , " & 3000 & " , " & 30 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(31) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'West Bound Left Queue Link
        CALInputLine(32) = 2
        CALInputLine(33) = "'WB Left Queue Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(34) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Approach Queue Link
        CALInputLine(35) = 2
        CALInputLine(36) = "'NB Queue Link'" & "," & TYP & ", " & 18 & " , " & -48 & " , " & 18 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(37) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Left Queue Link
        CALInputLine(38) = 2
        CALInputLine(39) = "'NB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & -48 & " , " & 0 & " , " & -3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(40) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Approach Queue Link
        CALInputLine(41) = 2
        CALInputLine(42) = "'EB Queue Link'" & "," & TYP & ", " & -30 & " , " & -30 & " , " & -3000 & " , " & -30 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(43) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Left Queue Link
        CALInputLine(44) = 2
        CALInputLine(45) = "'EB Left Queue Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(46) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Approach Link
        CALInputLine(47) = 1
        CALInputLine(48) = "'SB Approach Link'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & -18 & " , " & 3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'SB Left Link
        CALInputLine(49) = 1
        CALInputLine(50) = "'SB Left Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & 0 & " , " & 3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'SB Departure Link
        CALInputLine(51) = 1
        CALInputLine(52) = "'SB Departure Link'" & "," & TYP & ", " & 18 & " , " & 0 & " , " & 18 & " , " & 3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Approach Link
        CALInputLine(53) = 1
        CALInputLine(54) = "'WB Approach Link'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & 3000 & " , " & 30 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'WB Left Link
        CALInputLine(55) = 1
        CALInputLine(56) = "'WB Left Link'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'WB Departure Link
        CALInputLine(57) = 1
        CALInputLine(58) = "'WB Departure Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & 3000 & " , " & -30 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Approach Link
        CALInputLine(59) = 1
        CALInputLine(60) = "'NB Approach Link'" & "," & TYP & ", " & 18 & " , " & 0 & " , " & 18 & " , " & -3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 44

        'NB Left Link
        CALInputLine(61) = 1
        CALInputLine(62) = "'NB Left Link'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & 0 & " , " & -3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 32

        'NB Departure Link
        CALInputLine(63) = 1
        CALInputLine(64) = "'NB Departure Link'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & -18 & " , " & -3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Approach Link
        CALInputLine(65) = 1
        CALInputLine(66) = "'EB Approach Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & -3000 & " , " & -30 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'EB Left Link
        CALInputLine(67) = 1
        CALInputLine(68) = "'EB Left Link'" & "," & TYP & ", " & 18 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'EB Departure Link
        CALInputLine(69) = 1
        CALInputLine(70) = "'EB Departure Link'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & -3000 & " , " & 30 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'Last Line
        CALInputLine(71) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub





    '****************************************************************************************************************************************
    '*****************************************Builds input string array for CAL3QHC input files - 6X6****************************************
    '****************************************************************************************************************************************
    Sub Build6X6()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = 0
        If ATSB > ATMax Then ATMax = ATSB
        If ATWB > ATMax Then ATMax = ATWB
        If ATNB > ATMax Then ATMax = ATNB
        If ATEB > ATMax Then ATMax = ATEB

        ATLeft = CInt(ATMax * 0.15)
        ATQ = CInt(ATMax * 0.85)

        '6X6 -Specific Parameters
        NR = 20
        NumInputLines = 71
        NL = 20

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To (21)
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(22) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'NEXT, Write all Queue Links
        'South Bound Approach Queue Link
        CALInputLine(23) = 2
        CALInputLine(24) = "'SB Queue Link'" & "," & TYP & ", " & -30 & " , " & 48 & " , " & -30 & " , " & 3000 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(25) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'South Bound Left Queue Link
        CALInputLine(26) = 2
        CALInputLine(27) = "'SB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & 48 & " , " & 0 & " , " & 3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(28) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'West Bound Approach Queue Link
        CALInputLine(29) = 2
        CALInputLine(30) = "'WB Queue Link'" & "," & TYP & ", " & 48 & " , " & 30 & " , " & 3000 & " , " & 30 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(31) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'West Bound Left Queue Link
        CALInputLine(32) = 2
        CALInputLine(33) = "'WB Left Queue Link'" & "," & TYP & ", " & 48 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(34) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Approach Queue Link
        CALInputLine(35) = 2
        CALInputLine(36) = "'NB Queue Link'" & "," & TYP & ", " & 30 & " , " & -48 & " , " & 30 & " , " & -3000 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(37) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'North Bound Left Queue Link
        CALInputLine(38) = 2
        CALInputLine(39) = "'NB Left Queue Link'" & "," & TYP & ", " & 0 & " , " & -48 & " , " & 0 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(40) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Approach Queue Link
        CALInputLine(41) = 2
        CALInputLine(42) = "'EB Queue Link'" & "," & TYP & ", " & -48 & " , " & -30 & " , " & -3000 & " , " & -30 & " , " & HL & " , " & 36 & " , " & 3
        CALInputLine(43) = 120 & " , " & 75 & " , " & YFAC & " , " & ATQ & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'East Bound Left Queue Link
        CALInputLine(44) = 2
        CALInputLine(45) = "'EB Left Queue Link'" & "," & TYP & ", " & -48 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(46) = 120 & " , " & 105 & " , " & YFAC & " , " & ATLeft & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Approach Link
        CALInputLine(47) = 1
        CALInputLine(48) = "'SB Approach Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & -30 & " , " & 3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'SB Left Link
        CALInputLine(49) = 1
        CALInputLine(50) = "'SB Left Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & 0 & " , " & 3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'SB Departure Link
        CALInputLine(51) = 1
        CALInputLine(52) = "'SB Departure Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 30 & " , " & 3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Approach Link
        CALInputLine(53) = 1
        CALInputLine(54) = "'WB Approach Link'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & 3000 & " , " & 30 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'WB Left Link
        CALInputLine(55) = 1
        CALInputLine(56) = "'WB Left Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'WB Departure Link
        CALInputLine(57) = 1
        CALInputLine(58) = "'WB Departure Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & 3000 & " , " & -30 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Approach Link
        CALInputLine(59) = 1
        CALInputLine(60) = "'NB Approach Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 30 & " , " & -3000 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'NB Left Link
        CALInputLine(61) = 1
        CALInputLine(62) = "'NB Left Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 30 & " , " & -3000 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'NB Departure Link
        CALInputLine(63) = 1
        CALInputLine(64) = "'NB Departure Link'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & -30 & " , " & -3000 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Approach Link
        CALInputLine(65) = 1
        CALInputLine(66) = "'EB Approach Link'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & -3000 & " , " & -30 & " , " & ATMax & " , " & EFFree & " , " & HL & " , " & 56

        'EB Left Link
        CALInputLine(67) = 1
        CALInputLine(68) = "'EB Left Link'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & ATLeft & " , " & EFLt & " , " & HL & " , " & 44

        'EB Departure Link
        CALInputLine(69) = 1
        CALInputLine(70) = "'EB Departure Link'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & -3000 & " , " & 30 & " , " & ATMax & " , " & EFFreeAcc & " , " & HL & " , " & 56


        'Last Line
        CALInputLine(71) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub






    '****************************************************************************************************************************************
    '***************************************Builds input string array for CAL3QHC input files - EAST TEE*************************************
    '****************************************************************************************************************************************
    Sub BuildEastTee()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = 0
        If ATSB > ATMax Then ATMax = ATSB
        If ATWB > ATMax Then ATMax = ATWB
        If ATNB > ATMax Then ATMax = ATNB

        ATLeft = CInt(ATMax * 0.15)
        ATQ = CInt(ATMax * 0.85)

        '***Note:  For the tee configurations, the traffic queue and flow volumes are calculated within the individual input line statements
        '***relative to ATMax
        'East Tee -Specific Parameters
        NR = 17
        NumInputLines = 51
        NL = 13

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To 18
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(19) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'NEXT, Write all Queue Links
        'WB Leg Left Q
        CALInputLine(20) = 2
        CALInputLine(21) = "'WB Leg Left Q'" & "," & TYP & ", " & 30 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(22) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'WB Leg Right Q 
        CALInputLine(23) = 2
        CALInputLine(24) = "'WB Leg Right Q'" & "," & TYP & ", " & 30 & " , " & 24 & " , " & 3000 & " , " & 24 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(25) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB Leg Thru Q
        CALInputLine(26) = 2
        CALInputLine(27) = "'NB Leg Thru Q'" & "," & TYP & ", " & 18 & " , " & -36 & " , " & 18 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(28) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 1) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'SB Leg Thru Q
        CALInputLine(29) = 2
        CALInputLine(30) = "'SB Leg Thru Q'" & "," & TYP & ", " & -18 & " , " & 36 & " , " & -18 & " , " & 3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(31) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.85) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'SB Leg Left Q
        CALInputLine(32) = 2
        CALInputLine(33) = "'SB Leg Left Q'" & "," & TYP & ", " & 0 & " , " & 36 & " , " & 0 & " , " & 3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(34) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.15) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Leg Left
        CALInputLine(35) = 1
        CALInputLine(36) = "'WB Leg Left'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & CInt(ATMax * 0.5) & " , " & EFLt & " , " & HL & " , " & 44

        'WB Leg Right
        CALInputLine(37) = 1
        CALInputLine(38) = "'WB Leg Right'" & "," & TYP & ", " & 18 & " , " & 24 & " , " & 3000 & " , " & 24 & " , " & CInt(ATMax * 0.5) & " , " & EFRt & " , " & HL & " , " & 44


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Leg Thru 
        CALInputLine(39) = 1
        CALInputLine(40) = "'NB Leg Thru '" & "," & TYP & ", " & 18 & " , " & 24 & " , " & 18 & " , " & -3000 & " , " & CInt(ATMax * 0.75) & " , " & EFFree & " , " & HL & " , " & 44


        'NB Leg Dep  
        CALInputLine(41) = 1
        CALInputLine(42) = "'NB Leg Dep '" & "," & TYP & ", " & -18 & " , " & 0 & " , " & -18 & " , " & -3000 & " , " & CInt(ATMax * 1.35) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Leg Dep
        CALInputLine(43) = 1
        CALInputLine(44) = "'EB Leg Dep'" & "," & TYP & ", " & 0 & " , " & -24 & " , " & 3000 & " , " & -24 & " , " & CInt(ATMax * 0.4) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Leg Thru
        CALInputLine(45) = 1
        CALInputLine(46) = "'SB Leg Thru'" & "," & TYP & ", " & -18 & " , " & 0 & " , " & -18 & " , " & 3000 & " , " & CInt(ATMax * 0.85) & " , " & EFFree & " , " & HL & " , " & 44

        'SB Leg Left
        CALInputLine(47) = 1
        CALInputLine(48) = "'SB Leg Left'" & "," & TYP & ", " & 0 & " , " & -24 & " , " & 0 & " , " & 3000 & " , " & CInt(ATMax * 0.15) & " , " & EFLt & " , " & HL & " , " & 32

        'SB Leg Dep
        CALInputLine(49) = 1
        CALInputLine(50) = "'SB Leg Dep'" & "," & TYP & ", " & 18 & " , " & 24 & " , " & 18 & " , " & 3000 & " , " & CInt(ATMax * 1.25) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'Last Line
        CALInputLine(51) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub





    '****************************************************************************************************************************************
    '***************************************Builds input string array for CAL3QHC input files - NORTH TEE************************************
    '****************************************************************************************************************************************
    Sub BuildNorthTee()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = 0
        If ATSB > ATMax Then ATMax = ATSB
        If ATWB > ATMax Then ATMax = ATWB
        If ATEB > ATMax Then ATMax = ATEB

        ATLeft = CInt(ATMax * 0.15)
        ATQ = CInt(ATMax * 0.85)

        '***Note:  For the tee configurations, the traffic queue and flow volumes are calculated within the individual input line statements
        '***relative to ATMax
        'NORTH Tee -Specific Parameters
        NR = 17
        NumInputLines = 51
        NL = 13

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To 18
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(19) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'NEXT, Write all Queue Links
        'SB Leg Left Q
        CALInputLine(20) = 2
        CALInputLine(21) = "'SB Leg Left Q'" & "," & TYP & ", " & 0 & " , " & 30 & " , " & 0 & " , " & 3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(22) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'SB Leg Right Q 
        CALInputLine(23) = 2
        CALInputLine(24) = "'SB Leg Right Q'" & "," & TYP & ", " & -24 & " , " & 30 & " , " & -24 & " , " & 3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(25) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'WB Leg Thru Q
        CALInputLine(26) = 2
        CALInputLine(27) = "'WB Leg Thru Q'" & "," & TYP & ", " & 36 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(28) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 1) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB Leg Thru Q
        CALInputLine(29) = 2
        CALInputLine(30) = "'EB Leg Thru Q'" & "," & TYP & ", " & -36 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(31) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.85) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB Leg Left Q
        CALInputLine(32) = 2
        CALInputLine(33) = "'EB Leg Left Q'" & "," & TYP & ", " & -36 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(34) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.15) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Leg Left
        CALInputLine(35) = 1
        CALInputLine(36) = "'SB Leg Left'" & "," & TYP & ", " & 0 & " , " & -18 & " , " & 0 & " , " & 3000 & " , " & CInt(ATMax * 0.5) & " , " & EFLt & " , " & HL & " , " & 44

        'SB Leg Right
        CALInputLine(37) = 1
        CALInputLine(38) = "'SB Leg Right'" & "," & TYP & ", " & -24 & " , " & 18 & " , " & -24 & " , " & 3000 & " , " & CInt(ATMax * 0.5) & " , " & EFRt & " , " & HL & " , " & 44


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Leg Thru 
        CALInputLine(39) = 1
        CALInputLine(40) = "'WB Leg Thru '" & "," & TYP & ", " & -24 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & CInt(ATMax * 0.75) & " , " & EFFree & " , " & HL & " , " & 44

        'WB Leg Dep  
        CALInputLine(41) = 1
        CALInputLine(42) = "'WB Leg Dep '" & "," & TYP & ", " & 0 & " , " & -18 & " , " & 3000 & " , " & -18 & " , " & CInt(ATMax * 1.35) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Leg Dep
        CALInputLine(43) = 1
        CALInputLine(44) = "'SB Leg Dep'" & "," & TYP & ", " & 24 & " , " & 0 & " , " & 24 & " , " & 3000 & " , " & CInt(ATMax * 0.4) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Leg Thru
        CALInputLine(45) = 1
        CALInputLine(46) = "'EB Leg Thru'" & "," & TYP & ", " & 0 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & CInt(ATMax * 0.85) & " , " & EFFree & " , " & HL & " , " & 44

        'EB Leg Left
        CALInputLine(47) = 1
        CALInputLine(48) = "'EB Leg Left'" & "," & TYP & ", " & 24 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & CInt(ATMax * 0.15) & " , " & EFLt & " , " & HL & " , " & 32

        'EB Leg Dep
        CALInputLine(49) = 1
        CALInputLine(50) = "'EB Leg Dep'" & "," & TYP & ", " & -24 & " , " & 18 & " , " & -3000 & " , " & 18 & " , " & CInt(ATMax * 1.25) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'Last Line
        CALInputLine(51) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub





    '****************************************************************************************************************************************
    '**************************************Builds input string array for CAL3QHC input files - TOLL BOOTH************************************
    '****************************************************************************************************************************************
    Sub BuildTollBooth()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'TollBooth - Specific Parameters
        NR = 20
        NumInputLines = 43
        NL = 10

        'Note:  Tollbooth receptor arrays are filled here, 
        'all the other roadway configurations have their receptor arrays filled in the intersection type form.
        'Fill Receptor Arrays
        If EWTollBooth = True Then
            'Fills Receptor Array for the E-W Orientation
            'First, fills X-coords
            XR(1) = -2000
            XR(2) = -1250
            XR(3) = -500
            XR(4) = -150
            XR(5) = -50
            XR(6) = 50
            XR(7) = 150
            XR(8) = 500
            XR(9) = 1250
            XR(10) = 2000
            XR(11) = 2000
            XR(12) = 1250
            XR(13) = 500
            XR(14) = 150
            XR(15) = 50
            XR(16) = -50
            XR(17) = -150
            XR(18) = -500
            XR(19) = -1250
            XR(20) = -2000

            'Next fills, Y-coords
            If (CInt(ETCEB) > 0 Or CInt(ETCWB) > 0) Then
                'Fills for the scenario that includes ETC-Only lanes
                YR(1) = 68
                YR(2) = 68
                YR(3) = 116
                YR(4) = 116
                YR(5) = 116
                YR(6) = 116
                YR(7) = 116
                YR(8) = 116
                YR(9) = 68
                YR(10) = 68
                YR(11) = -68
                YR(12) = -68
                YR(13) = -116
                YR(14) = -116
                YR(15) = -116
                YR(16) = -116
                YR(17) = -116
                YR(18) = -116
                YR(19) = -68
                YR(20) = -68
            Else
                'Fills for the scenario that does not inclue ETC-only lanes
                YR(1) = 68
                YR(2) = 68
                YR(3) = 80
                YR(4) = 80
                YR(5) = 80
                YR(6) = 80
                YR(7) = 80
                YR(8) = 80
                YR(9) = 68
                YR(10) = 68
                YR(11) = -68
                YR(12) = -68
                YR(13) = -80
                YR(14) = -80
                YR(15) = -80
                YR(16) = -80
                YR(17) = -80
                YR(18) = -80
                YR(19) = -68
                YR(20) = -68
            End If
        Else
            'Fills Receptor Array for the N-S Orientation
            'First, fills Y-coords
            YR(1) = 2000
            YR(2) = 1250
            YR(3) = 500
            YR(4) = 150
            YR(5) = 50
            YR(6) = -50
            YR(7) = -150
            YR(8) = -500
            YR(9) = -1250
            YR(10) = -2000
            YR(11) = -2000
            YR(12) = -1250
            YR(13) = -500
            YR(14) = -150
            YR(15) = -50
            YR(16) = 50
            YR(17) = 150
            YR(18) = 500
            YR(19) = -1250
            YR(20) = 2000

            'Next fills, X-coords
            If (CInt(ETCNB) > 0 Or CInt(ETCSB) > 0) Then
                'Fills for the scenario that includes ETC-Only lanes
                XR(1) = 68
                XR(2) = 68
                XR(3) = 116
                XR(4) = 116
                XR(5) = 116
                XR(6) = 116
                XR(7) = 116
                XR(8) = 116
                XR(9) = 68
                XR(10) = 68
                XR(11) = -68
                XR(12) = -68
                XR(13) = -116
                XR(14) = -116
                XR(15) = -116
                XR(16) = -116
                XR(17) = -116
                XR(18) = -116
                XR(19) = -68
                XR(20) = -68
            Else
                'Fills for the scenario that does not inclue ETC-only lanes
                XR(1) = 68
                XR(2) = 68
                XR(3) = 80
                XR(4) = 80
                XR(5) = 80
                XR(6) = 80
                XR(7) = 80
                XR(8) = 80
                XR(9) = 68
                XR(10) = 68
                XR(11) = -68
                XR(12) = -68
                XR(13) = -80
                XR(14) = -80
                XR(15) = -80
                XR(16) = -80
                XR(17) = -80
                XR(18) = -80
                XR(19) = -68
                XR(20) = -68
            End If
        End If

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To (21)
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(22) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'Note:  No Queue links utilized for the tollbooth scenario

        If EWTollBooth = True Then
            'Writes Links for E-W Scenario
            'First Writes EastBound Links
            If (ETCEB > 0 Or ETCWB > 0) Then
                'ETC-Only lanes scenario

                'EB Free-Flow Link1
                CALInputLine(23) = 1
                CALInputLine(24) = "'EB Free-Flow Link1'" & "," & TYP & ", " & -2500 & " , " & -30 & " , " & -900 & " , " & -30 & " , " & ATEB & " , " & EFFree & " , " & HL & " , " & 56

                'EB Free-Flow Link2
                CALInputLine(25) = 1
                CALInputLine(26) = "'EB Free-Flow Link2'" & "," & TYP & ", " & -900 & " , " & -30 & " , " & 900 & " , " & -30 & " , " & CInt(ATEB * (ETCEB / 100)) & " , " & EFFree & " , " & HL & " , " & 44

                'EB Free-Flow Link3
                CALInputLine(27) = 1
                CALInputLine(28) = "'EB Free-Flow Link3'" & "," & TYP & ", " & 900 & " , " & -30 & " , " & 2500 & " , " & -30 & " , " & ATEB & " , " & EFFree & " , " & HL & " , " & 56

                'EB Toll Approach Link
                CALInputLine(29) = 1
                CALInputLine(30) = "'EB Toll Approach Link'" & "," & TYP & ", " & -900 & " , " & -72 & " , " & 0 & " , " & -72 & " , " & CInt(ATEB * (100 - ETCEB) / 100) & " , " & EF10mph & " , " & HL & " , " & 68

                'EB Toll Departure Link
                CALInputLine(31) = 1
                CALInputLine(32) = "'EB Toll Departure Link'" & "," & TYP & ", " & 0 & " , " & -72 & " , " & 900 & " , " & -72 & " , " & CInt(ATEB * (100 - ETCEB) / 100) & " , " & EFTollAcc & " , " & HL & " , " & 68
            Else
                'No ETC-Only lanes scenario
                'EB Free-Flow Link1
                CALInputLine(23) = 1
                CALInputLine(24) = "'EB Free-Flow Link1'" & "," & TYP & ", " & -2500 & " , " & -30 & " , " & -900 & " , " & -30 & " , " & ATEB & " , " & EFFree & " , " & HL & " , " & 56

                'EB Free-Flow Link2
                CALInputLine(25) = 1
                CALInputLine(26) = "'EB Free-Flow Link2'" & "," & TYP & ", " & -900 & " , " & -30 & " , " & 900 & " , " & -30 & " , " & 0 & " , " & EFFree & " , " & HL & " , " & 44

                'EB Free-Flow Link3
                CALInputLine(27) = 1
                CALInputLine(28) = "'EB Free-Flow Link3'" & "," & TYP & ", " & 900 & " , " & -30 & " , " & 2500 & " , " & -30 & " , " & ATEB & " , " & EFFree & " , " & HL & " , " & 56

                'EB Toll Approach Link
                CALInputLine(29) = 1
                CALInputLine(30) = "'EB Toll Approach Link'" & "," & TYP & ", " & -900 & " , " & -36 & " , " & 0 & " , " & -36 & " , " & CInt(ATEB) & " , " & EF10mph & " , " & HL & " , " & 68

                'EB Toll Departure Link
                CALInputLine(31) = 1
                CALInputLine(32) = "'EB Toll Departure Link'" & "," & TYP & ", " & 0 & " , " & -36 & " , " & 900 & " , " & -36 & " , " & CInt(ATEB) & " , " & EFTollAcc & " , " & HL & " , " & 68
            End If

            'Next Writes WestBound Links
            If (ETCEB > 0 Or ETCWB > 0) Then
                'ETC-Only lanes scenario
                'WB Free-Flow Link1
                CALInputLine(33) = 1
                CALInputLine(34) = "'WB Free-Flow Link1'" & "," & TYP & ", " & 2500 & " , " & 30 & " , " & 900 & " , " & 30 & " , " & ATWB & " , " & EFFree & " , " & HL & " , " & 56

                'WB Free-Flow Link2
                CALInputLine(35) = 1
                CALInputLine(36) = "'WB Free-Flow Link2'" & "," & TYP & ", " & 900 & " , " & 30 & " , " & -900 & " , " & 30 & " , " & CInt(ATWB * (ETCWB / 100)) & " , " & EFFree & " , " & HL & " , " & 44

                'WB Free-Flow Link3
                CALInputLine(37) = 1
                CALInputLine(38) = "'WB Free-Flow Link3'" & "," & TYP & ", " & -900 & " , " & 30 & " , " & -2500 & " , " & 30 & " , " & ATWB & " , " & EFFree & " , " & HL & " , " & 56

                'WB Toll Approach Link
                CALInputLine(39) = 1
                CALInputLine(40) = "'WB Toll Approach Link'" & "," & TYP & ", " & 900 & " , " & 72 & " , " & 0 & " , " & 72 & " , " & CInt(ATWB * (100 - ETCWB) / 100) & " , " & EF10mph & " , " & HL & " , " & 68

                'WB Toll Departure Link
                CALInputLine(41) = 1
                CALInputLine(42) = "'WB Toll Departure Link'" & "," & TYP & ", " & 0 & " , " & 72 & " , " & -900 & " , " & 72 & " , " & CInt(ATWB * (100 - ETCWB) / 100) & " , " & EFTollAcc & " , " & HL & " , " & 68
            Else
                'No ETC-Only lanes scenario
                'WB Free-Flow Link1
                CALInputLine(33) = 1
                CALInputLine(34) = "'WB Free-Flow Link1'" & "," & TYP & ", " & 2500 & " , " & 30 & " , " & 900 & " , " & 30 & " , " & ATWB & " , " & EFFree & " , " & HL & " , " & 56

                'WB Free-Flow Link2
                CALInputLine(35) = 1
                CALInputLine(36) = "'WB Free-Flow Link2'" & "," & TYP & ", " & 900 & " , " & 30 & " , " & -900 & " , " & 30 & " , " & 0 & " , " & EFFree & " , " & HL & " , " & 44

                'WB Free-Flow Link3
                CALInputLine(37) = 1
                CALInputLine(38) = "'WB Free-Flow Link3'" & "," & TYP & ", " & -900 & " , " & 30 & " , " & -2500 & " , " & 30 & " , " & ATWB & " , " & EFFree & " , " & HL & " , " & 56

                'WB Toll Approach Link
                CALInputLine(39) = 1
                CALInputLine(40) = "'WB Toll Approach Link'" & "," & TYP & ", " & 900 & " , " & 36 & " , " & 0 & " , " & 36 & " , " & CInt(ATWB) & " , " & EF10mph & " , " & HL & " , " & 68

                'WB Toll Departure Link
                CALInputLine(41) = 1
                CALInputLine(42) = "'WB Toll Departure Link'" & "," & TYP & ", " & 0 & " , " & 36 & " , " & -900 & " , " & 36 & " , " & CInt(ATWB) & " , " & EFTollAcc & " , " & HL & " , " & 68
            End If
        Else
            'Writes Links for N-S Scenario
            'First Writes NorthBound Links
            If (ETCNB > 0 Or ETCSB > 0) Then
                'ETC-Only lanes scenario
                'NB Free-Flow Link1
                CALInputLine(23) = 1
                CALInputLine(24) = "'NB Free-Flow Link1'" & "," & TYP & ", " & 30 & " , " & -2500 & " , " & 30 & " , " & -900 & " , " & ATNB & " , " & EFFree & " , " & HL & " , " & 56

                'NB Free-Flow Link2
                CALInputLine(25) = 1
                CALInputLine(26) = "'NB Free-Flow Link2'" & "," & TYP & ", " & 30 & " , " & -900 & " , " & 30 & " , " & 900 & " , " & CInt(ATNB * (ETCNB / 100)) & " , " & EFFree & " , " & HL & " , " & 44

                'NB Free-Flow Link3
                CALInputLine(27) = 1
                CALInputLine(28) = "'NB Free-Flow Link3'" & "," & TYP & ", " & 30 & " , " & 900 & " , " & 30 & " , " & 2500 & " , " & ATNB & " , " & EFFree & " , " & HL & " , " & 56

                'NB Toll Approach Link
                CALInputLine(29) = 1
                CALInputLine(30) = "'NB Toll Approach Link'" & "," & TYP & ", " & 30 & " , " & -900 & " , " & 72 & " , " & 0 & " , " & CInt(ATNB * (100 - ETCNB) / 100) & " , " & EF10mph & " , " & HL & " , " & 68

                'NB Toll Departure Link
                CALInputLine(31) = 1
                CALInputLine(32) = "'NB Toll Departure Link'" & "," & TYP & ", " & 72 & " , " & 0 & " , " & 30 & " , " & 900 & " , " & CInt(ATNB * (100 - ETCNB) / 100) & " , " & EFTollAcc & " , " & HL & " , " & 68
            Else
                'No ETC-Only lanes scenario
                'NB Free-Flow Link1
                CALInputLine(23) = 1
                CALInputLine(24) = "'NB Free-Flow Link1'" & "," & TYP & ", " & 30 & " , " & -2500 & " , " & 30 & " , " & -900 & " , " & ATNB & " , " & EFFree & " , " & HL & " , " & 56

                'NB Free-Flow Link2
                CALInputLine(25) = 1
                CALInputLine(26) = "'NB Free-Flow Link2'" & "," & TYP & ", " & 30 & " , " & -900 & " , " & 30 & " , " & 900 & " , " & 0 & " , " & EFFree & " , " & HL & " , " & 44

                'NB Free-Flow Link3
                CALInputLine(27) = 1
                CALInputLine(28) = "'NB Free-Flow Link3'" & "," & TYP & ", " & 30 & " , " & 900 & " , " & 30 & " , " & 2500 & " , " & ATNB & " , " & EFFree & " , " & HL & " , " & 56

                'NB Toll Approach Link
                CALInputLine(29) = 1
                CALInputLine(30) = "'NB Toll Approach Link'" & "," & TYP & ", " & 30 & " , " & -900 & " , " & 36 & " , " & 0 & " , " & CInt(ATNB) & " , " & EF10mph & " , " & HL & " , " & 68

                'NB Toll Departure Link
                CALInputLine(31) = 1
                CALInputLine(32) = "'NB Toll Departure Link'" & "," & TYP & ", " & 36 & " , " & 0 & " , " & 30 & " , " & 900 & " , " & CInt(ATMax) & " , " & EFTollAcc & " , " & HL & " , " & 68
            End If

            'Next, Writes SouthBound Links
            If (ETCNB > 0 Or ETCSB > 0) Then
                'ETC-Only lanes scenario
                'SB Free-Flow Link1
                CALInputLine(33) = 1
                CALInputLine(34) = "'SB Free-Flow Link1'" & "," & TYP & ", " & -30 & " , " & 2500 & " , " & -30 & " , " & 900 & " , " & ATSB & " , " & EFFree & " , " & HL & " , " & 56

                'SB Free-Flow Link2
                CALInputLine(35) = 1
                CALInputLine(36) = "'SB Free-Flow Link2'" & "," & TYP & ", " & -30 & " , " & 900 & " , " & -30 & " , " & -900 & " , " & CInt(ATSB * (ETCSB / 100)) & " , " & EFFree & " , " & HL & " , " & 44

                'SB Free-Flow Link3
                CALInputLine(37) = 1
                CALInputLine(38) = "'SB Free-Flow Link3'" & "," & TYP & ", " & -30 & " , " & -900 & " , " & -30 & " , " & -2500 & " , " & ATSB & " , " & EFFree & " , " & HL & " , " & 56

                'SB Toll Approach Link
                CALInputLine(39) = 1
                CALInputLine(40) = "'SB Toll Approach Link'" & "," & TYP & ", " & -30 & " , " & 900 & " , " & -72 & " , " & 0 & " , " & CInt(ATSB * (100 - ETCSB) / 100) & " , " & EF10mph & " , " & HL & " , " & 68

                'SB Toll Departure Link
                CALInputLine(41) = 1
                CALInputLine(42) = "'SB Toll Departure Link'" & "," & TYP & ", " & -72 & " , " & 0 & " , " & -30 & " , " & -900 & " , " & CInt(ATSB * (100 - ETCSB) / 100) & " , " & EFTollAcc & " , " & HL & " , " & 68
            Else
                'No ETC-Only lanes scenario
                'SB Free-Flow Link1
                CALInputLine(33) = 1
                CALInputLine(34) = "'SB Free-Flow Link1'" & "," & TYP & ", " & -30 & " , " & 2500 & " , " & -30 & " , " & 900 & " , " & ATSB & " , " & EFFree & " , " & HL & " , " & 56

                'SB Free-Flow Link2
                CALInputLine(35) = 1
                CALInputLine(36) = "'SB Free-Flow Link2'" & "," & TYP & ", " & -30 & " , " & 900 & " , " & -30 & " , " & -900 & " , " & 0 & " , " & EFFree & " , " & HL & " , " & 44

                'SB Free-Flow Link3
                CALInputLine(37) = 1
                CALInputLine(38) = "'SB Free-Flow Link3'" & "," & TYP & ", " & -30 & " , " & -900 & " , " & -30 & " , " & -2500 & " , " & ATSB & " , " & EFFree & " , " & HL & " , " & 56

                'SB Toll Approach Link
                CALInputLine(39) = 1
                CALInputLine(40) = "'SB Toll Approach Link'" & "," & TYP & ", " & -30 & " , " & 900 & " , " & -36 & " , " & 0 & " , " & CInt(ATSB) & " , " & EF10mph & " , " & HL & " , " & 68

                'SB Toll Departure Link
                CALInputLine(41) = 1
                CALInputLine(42) = "'SB Toll Departure Link'" & "," & TYP & ", " & -36 & " , " & 0 & " , " & -30 & " , " & -900 & " , " & CInt(ATSB) & " , " & EFTollAcc & " , " & HL & " , " & 68
            End If
        End If

        'Last Line
        CALInputLine(43) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub





    '****************************************************************************************************************************************
    '***************************************Builds input string array for CAL3QHC input files - WEST TEE*************************************
    '****************************************************************************************************************************************
    Sub BuildWestTee()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = 0
        If ATSB > ATMax Then ATMax = ATSB
        If ATNB > ATMax Then ATMax = ATNB
        If ATEB > ATMax Then ATMax = ATEB

        ATLeft = CInt(ATMax * 0.15)
        ATQ = CInt(ATMax * 0.85)

        '***Note:  For the tee configurations, the traffic queue and flow volumes are calculated within the individual input line statements
        '***relative to ATMax
        'WEST Tee -Specific Parameters
        NR = 17
        NumInputLines = 51
        NL = 13

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To 18
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(19) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE


        'NEXT, Write all Queue Links
        'EB Leg Left Q
        CALInputLine(20) = 2
        CALInputLine(21) = "'EB Leg Left Q'" & "," & TYP & ", " & -30 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(22) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB Leg Right Q 
        CALInputLine(23) = 2
        CALInputLine(24) = "'EB Leg Right Q'" & "," & TYP & ", " & -30 & " , " & -24 & " , " & -3000 & " , " & -24 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(25) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'SB Leg Thru Q
        CALInputLine(26) = 2
        CALInputLine(27) = "'SB Leg Thru Q'" & "," & TYP & ", " & -18 & " , " & 36 & " , " & -18 & " , " & 3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(28) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 1) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB Leg Thru Q
        CALInputLine(29) = 2
        CALInputLine(30) = "'NB Leg Thru Q'" & "," & TYP & ", " & 18 & " , " & -36 & " , " & 18 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(31) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.85) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB Leg Left Q
        CALInputLine(32) = 2
        CALInputLine(33) = "'NB Leg Left Q'" & "," & TYP & ", " & 0 & " , " & -36 & " , " & 0 & " , " & -3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(34) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.15) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Leg Left
        CALInputLine(35) = 1
        CALInputLine(36) = "'EB Leg Left'" & "," & TYP & ", " & 18 & " , " & 0 & " , " & -3000 & " , " & 0 & " , " & CInt(ATMax * 0.5) & " , " & EFLt & " , " & HL & " , " & 44

        'EB Leg Right
        CALInputLine(37) = 1
        CALInputLine(38) = "'EB Leg Right'" & "," & TYP & ", " & -18 & " , " & -24 & " , " & -3000 & " , " & -24 & " , " & CInt(ATMax * 0.5) & " , " & EFRt & " , " & HL & " , " & 44


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Leg Thru 
        CALInputLine(39) = 1
        CALInputLine(40) = "'SB Leg Thru '" & "," & TYP & ", " & -18 & " , " & -24 & " , " & -18 & " , " & 3000 & " , " & CInt(ATMax * 0.75) & " , " & EFFree & " , " & HL & " , " & 44

        'SB Leg Dep  
        CALInputLine(41) = 1
        CALInputLine(42) = "'SB Leg Dep '" & "," & TYP & ", " & 18 & " , " & 0 & " , " & 18 & " , " & 3000 & " , " & CInt(ATMax * 1.35) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Leg Dep
        CALInputLine(43) = 1
        CALInputLine(44) = "'WB Leg Dep'" & "," & TYP & ", " & 0 & " , " & 24 & " , " & -3000 & " , " & 24 & " , " & CInt(ATMax * 0.4) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Leg Thru
        CALInputLine(45) = 1
        CALInputLine(46) = "'NB Leg Thru'" & "," & TYP & ", " & 18 & " , " & 0 & " , " & 18 & " , " & -3000 & " , " & CInt(ATMax * 0.85) & " , " & EFFree & " , " & HL & " , " & 44

        'NB Leg Left
        CALInputLine(47) = 1
        CALInputLine(48) = "'NB Leg Left'" & "," & TYP & ", " & 0 & " , " & 24 & " , " & 0 & " , " & -3000 & " , " & CInt(ATMax * 0.15) & " , " & EFLt & " , " & HL & " , " & 32

        'NB Leg Dep
        CALInputLine(49) = 1
        CALInputLine(50) = "'NB Leg Dep'" & "," & TYP & ", " & -18 & " , " & -24 & " , " & -18 & " , " & -3000 & " , " & CInt(ATMax * 1.25) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'Last Line
        CALInputLine(51) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub





    '****************************************************************************************************************************************
    '**************************************Builds input string array for CAL3QHC input files - SOUTH TEE*************************************
    '****************************************************************************************************************************************
    Sub BuildSouthTee()
        Dim i As Integer

        'Calls subroutine GetEF's
        GetEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = 0
        If ATWB > ATMax Then ATMax = ATWB
        If ATNB > ATMax Then ATMax = ATNB
        If ATEB > ATMax Then ATMax = ATEB

        ATLeft = CInt(ATMax * 0.15)
        ATQ = CInt(ATMax * 0.85)

        '***Note:  For the tee configurations, the traffic queue and flow volumes are calculated within the individual input line statements
        '***relative to ATMax
        'SOUTH Tee -Specific Parameters
        NR = 17
        NumInputLines = 51
        NL = 13

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To 18
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(19) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'NEXT, Write all Queue Links
        'NB Leg Left Q
        CALInputLine(20) = 2
        CALInputLine(21) = "'NB Leg Left Q'" & "," & TYP & ", " & 0 & " , " & -30 & " , " & 0 & " , " & -3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(22) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB Leg Right Q 
        CALInputLine(23) = 2
        CALInputLine(24) = "'NB Leg Right Q'" & "," & TYP & ", " & 24 & " , " & -30 & " , " & 24 & " , " & -3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(25) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.5) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB Leg Thru Q
        CALInputLine(26) = 2
        CALInputLine(27) = "'EB Leg Thru Q'" & "," & TYP & ", " & -36 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(28) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 1) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'WB Leg Thru Q
        CALInputLine(29) = 2
        CALInputLine(30) = "'WB Leg Thru Q'" & "," & TYP & ", " & 36 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(31) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax * 0.85) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'WB Leg Left Q
        CALInputLine(32) = 2
        CALInputLine(33) = "'WB Leg Left Q'" & "," & TYP & ", " & 36 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(34) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax * 0.15) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Leg Left
        CALInputLine(35) = 1
        CALInputLine(36) = "'NB Leg Left'" & "," & TYP & ", " & 0 & " , " & 18 & " , " & 0 & " , " & -3000 & " , " & CInt(ATMax * 0.5) & " , " & EFLt & " , " & HL & " , " & 44

        'NB Leg Right
        CALInputLine(37) = 1
        CALInputLine(38) = "'NB Leg Right'" & "," & TYP & ", " & 24 & " , " & -18 & " , " & 24 & " , " & -3000 & " , " & CInt(ATMax * 0.5) & " , " & EFRt & " , " & HL & " , " & 44


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Leg Thru 
        CALInputLine(39) = 1
        CALInputLine(40) = "'EB Leg Thru '" & "," & TYP & ", " & 24 & " , " & -18 & " , " & -3000 & " , " & -18 & " , " & CInt(ATMax * 0.75) & " , " & EFFree & " , " & HL & " , " & 44


        'EB Leg Dep  
        CALInputLine(41) = 1
        CALInputLine(42) = "'EB Leg Dep '" & "," & TYP & ", " & 0 & " , " & 18 & " , " & -3000 & " , " & 18 & " , " & CInt(ATMax * 1.35) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Leg Dep
        CALInputLine(43) = 1
        CALInputLine(44) = "'SB Leg Dep'" & "," & TYP & ", " & -24 & " , " & 0 & " , " & -24 & " , " & -3000 & " , " & CInt(ATMax * 0.4) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Leg Thru
        CALInputLine(45) = 1
        CALInputLine(46) = "'WB Leg Thru'" & "," & TYP & ", " & 0 & " , " & 18 & " , " & 3000 & " , " & 18 & " , " & CInt(ATMax * 0.85) & " , " & EFFree & " , " & HL & " , " & 44

        'WB Leg Left
        CALInputLine(47) = 1
        CALInputLine(48) = "'WB Leg Left'" & "," & TYP & ", " & -24 & " , " & 0 & " , " & 3000 & " , " & 0 & " , " & CInt(ATMax * 0.15) & " , " & EFLt & " , " & HL & " , " & 32

        'WB Leg Dep
        CALInputLine(49) = 1
        CALInputLine(50) = "'WB Leg Dep'" & "," & TYP & ", " & 24 & " , " & -18 & " , " & 3000 & " , " & -18 & " , " & CInt(ATMax * 1.25) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'Last Line
        CALInputLine(51) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub






    '****************************************************************************************************************************************
    '*************************************Builds input string array for CAL3QHC input files - N-S DIAMOND************************************
    '****************************************************************************************************************************************
    Sub BuildNSDiamond()
        Dim i As Integer

        'Calls subroutine GetDiamondEF's
        GetDiamondEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = ATEB
        If ATWB > ATMax Then ATMax = ATWB

        ATLeft = CSng(0.5 * OREB)
        If CSng(0.5 * ORWB) > ATLeft Then ATLeft = CSng(0.5 * ORWB)

        ATRight = ATLeft

        FTMax = ATSB
        If ATNB > FTMax Then FTMax = ATNB

        FTRight = CSng(0.5 * ORSB)
        If CSng(0.5 * ORNB) > FTRight Then FTRight = CSng(0.5 * ORNB)

        FTLeft = FTRight

        FTDep = CInt(FTMax) + (CInt(ATRight) + CInt(ATLeft)) - (CInt(FTRight) + CInt(FTLeft))
        ATDep = CInt(ATMax) - (CInt(ATRight) + CInt(ATLeft)) + (CInt(FTRight) + CInt(FTLeft))

        'N-S Diamond particular parameters
        NR = 20
        NumInputLines = 111
        NL = 38

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To 21
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(22) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE

        'NEXT, Write all Queue Links
        'SB OffRamp RightQ
        CALInputLine(23) = 2
        CALInputLine(24) = "'SB OffRamp RightQ'" & "," & TYP & ", " & -208 & " , " & 36 & " , " & -48 & " , " & 1019 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(25) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(FTRight) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'SB OffRamp LeftQ
        CALInputLine(26) = 2
        CALInputLine(27) = "'SB OffRamp LeftQ'" & "," & TYP & ", " & -193 & " , " & 36 & " , " & -48 & " , " & 944 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(28) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(FTLeft) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'WB Leg Thru1Q
        CALInputLine(29) = 2
        CALInputLine(30) = "'WB Leg Thru1Q'" & "," & TYP & ", " & 215 & " , " & 24 & " , " & 3000 & " , " & 24 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(31) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'WB Leg Thru2Q
        CALInputLine(32) = 2
        CALInputLine(33) = "'WB Leg Thru2Q'" & "," & TYP & ", " & -190 & " , " & 24 & " , " & 193 & " , " & 24 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(34) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'WB Leg Left1Q
        CALInputLine(35) = 2
        CALInputLine(36) = "'WB Leg Left1Q'" & "," & TYP & ", " & 215 & " , " & 6 & " , " & 3000 & " , " & 6 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(37) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'WB Leg Left2Q
        CALInputLine(38) = 2
        CALInputLine(39) = "'WB Leg Left2Q'" & "," & TYP & ", " & -190 & " , " & 6 & " , " & 215 & " , " & 6 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(40) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB OffRamp RightQ
        CALInputLine(41) = 2
        CALInputLine(42) = "'NB OffRamp RightQ'" & "," & TYP & ", " & 208 & " , " & -36 & " , " & 48 & " , " & -1019 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(43) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(FTRight) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'NB OffRamp LeftQ
        CALInputLine(44) = 2
        CALInputLine(45) = "'NB OffRamp LeftQ'" & "," & TYP & ", " & 193 & " , " & -36 & " , " & 48 & " , " & -944 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(46) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(FTLeft) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'EB Leg Thru1Q
        CALInputLine(47) = 2
        CALInputLine(48) = "'EB Leg Thru1Q'" & "," & TYP & ", " & -215 & " , " & -24 & " , " & -3000 & " , " & -24 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(49) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB Leg Thru2Q
        CALInputLine(50) = 2
        CALInputLine(51) = "'EB Leg Thru2Q'" & "," & TYP & ", " & 190 & " , " & -24 & " , " & -193 & " , " & -24 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(52) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB Leg Left1Q
        CALInputLine(53) = 2
        CALInputLine(54) = "'EB Leg Left1Q'" & "," & TYP & ", " & -215 & " , " & -6 & " , " & -3000 & " , " & -6 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(55) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB Leg Left2Q
        CALInputLine(56) = 2
        CALInputLine(57) = "'EB Leg Left2Q'" & "," & TYP & ", " & 190 & " , " & -6 & " , " & -215 & " , " & -6 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(58) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Fwy Thru1
        CALInputLine(59) = 1
        CALInputLine(60) = "'SB Fwy Thru1'" & "," & TYP & ", " & -30 & " , " & 981 & " , " & -30 & " , " & 4000 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'SB Fwy Thru2
        CALInputLine(61) = 1
        CALInputLine(62) = "'SB Fwy Thru2'" & "," & TYP & ", " & -30 & " , " & 981 & " , " & -30 & " , " & -981 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'SB OffRamp Right
        CALInputLine(63) = 1
        CALInputLine(64) = "'SB OffRamp Right'" & "," & TYP & ", " & -208 & " , " & 36 & " , " & -48 & " , " & 1019 & " , " & CInt(FTRight) & " , " & EFHwy & " , " & HL & " , " & 32

        'SB OffRamp Left1
        CALInputLine(65) = 1
        CALInputLine(66) = "'SB OffRamp Left1'" & "," & TYP & ", " & -193 & " , " & 36 & " , " & -48 & " , " & 944 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'SB OffRamp Left2
        CALInputLine(67) = 1
        CALInputLine(68) = "'SB OffRamp Left2'" & "," & TYP & ", " & -193 & " , " & 36 & " , " & -193 & " , " & -24 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'SB OnRamp
        CALInputLine(69) = 1
        CALInputLine(70) = "'SB OnRamp'" & "," & TYP & ", " & -200 & " , " & -36 & " , " & -48 & " , " & -981 & " , " & (CInt(ATLeft) + CInt(ATRight)) & " , " & EFHwyOn & " , " & HL & " , " & 44

        'SB Leg Dep
        CALInputLine(71) = 1
        CALInputLine(72) = "'SB Leg Dep'" & "," & TYP & ", " & 30 & " , " & 981 & " , " & 30 & " , " & 4000 & " , " & CInt(FTDep) & " , " & EFHwy & " , " & HL & " , " & 56


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Leg Thru1
        CALInputLine(73) = 1
        CALInputLine(74) = "'WB Leg Thru1'" & "," & TYP & ", " & 193 & " , " & 24 & " , " & 3000 & " , " & 24 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'WB Leg Thru2
        CALInputLine(75) = 1
        CALInputLine(76) = "'WB Leg Thru2'" & "," & TYP & ", " & -190 & " , " & 24 & " , " & 193 & " , " & 24 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'WB Leg Left1
        CALInputLine(77) = 1
        CALInputLine(78) = "'WB Leg Left1'" & "," & TYP & ", " & 215 & " , " & 6 & " , " & 3000 & " , " & 6 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'WB Leg Left2
        CALInputLine(79) = 1
        CALInputLine(80) = "'WB Leg Left2'" & "," & TYP & ", " & -190 & " , " & 6 & " , " & 215 & " , " & 6 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'WB Leg Left3
        CALInputLine(81) = 1
        CALInputLine(82) = "'WB Leg Left3'" & "," & TYP & ", " & -190 & " , " & 6 & " , " & -200 & " , " & -36 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'WB Leg Dep
        CALInputLine(83) = 1
        CALInputLine(84) = "'WB Leg Dep'" & "," & TYP & ", " & 190 & " , " & -24 & " , " & 3000 & " , " & -24 & " , " & CInt(ATDep) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all NORTH Bound Free Flow Links
        'NB Fwy Thru 1
        CALInputLine(85) = 1
        CALInputLine(86) = "'NB Fwy Thru 1'" & "," & TYP & ", " & 30 & " , " & -981 & " , " & 30 & " , " & -4000 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'NBFwy Thru 2
        CALInputLine(87) = 1
        CALInputLine(88) = "'NBFwy Thru 2'" & "," & TYP & ", " & 30 & " , " & -981 & " , " & 30 & " , " & 981 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'NB OffRamp Right
        CALInputLine(89) = 1
        CALInputLine(90) = "'NB OffRamp Right'" & "," & TYP & ", " & 208 & " , " & -36 & " , " & 48 & " , " & -1019 & " , " & CInt(FTRight) & " , " & EFHwy & " , " & HL & " , " & 32

        'NB OffRamp Left1
        CALInputLine(91) = 1
        CALInputLine(92) = "'NB OffRamp Left'" & "," & TYP & ", " & 193 & " , " & -36 & " , " & 48 & " , " & -944 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'NB OffRamp Left2
        CALInputLine(93) = 1
        CALInputLine(94) = "'NB OffRamp Left'" & "," & TYP & ", " & 193 & " , " & -36 & " , " & 193 & " , " & 24 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'NB OnRamp
        CALInputLine(95) = 1
        CALInputLine(96) = "'NB OnRamp'" & "," & TYP & ", " & 200 & " , " & 36 & " , " & 48 & " , " & 981 & " , " & (CInt(ATLeft) + CInt(ATRight)) & " , " & EFHwyOn & " , " & HL & " , " & 44

        'NB Leg Dep
        CALInputLine(97) = 1
        CALInputLine(98) = "'NB Leg Dep'" & "," & TYP & ", " & -30 & " , " & -981 & " , " & -30 & " , " & -4000 & " , " & CInt(FTDep) & " , " & EFHwy & " , " & HL & " , " & 56


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Leg Thru1
        CALInputLine(99) = 1
        CALInputLine(100) = "'EB Leg Thru1'" & "," & TYP & ", " & -193 & " , " & -24 & " , " & -3000 & " , " & -24 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'EB Leg Thru2
        CALInputLine(101) = 1
        CALInputLine(102) = "'EB Leg Thru2'" & "," & TYP & ", " & 190 & " , " & -24 & " , " & -193 & " , " & -24 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'EB Leg Left1
        CALInputLine(103) = 1
        CALInputLine(104) = "'EB Leg Left1'" & "," & TYP & ", " & -215 & " , " & -6 & " , " & -3000 & " , " & -6 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'EB Leg Left2
        CALInputLine(105) = 1
        CALInputLine(106) = "'EB Leg Left2'" & "," & TYP & ", " & 190 & " , " & -6 & " , " & -215 & " , " & -6 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'EB Leg Left3
        CALInputLine(107) = 1
        CALInputLine(108) = "'EB Leg Left3'" & "," & TYP & ", " & 190 & " , " & -6 & " , " & 200 & " , " & 36 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'EB Leg Dep
        CALInputLine(109) = 1
        CALInputLine(110) = "'EB Leg Dep'" & "," & TYP & ", " & -190 & " , " & 24 & " , " & -3000 & " , " & 24 & " , " & CInt(ATDep) & " , " & EFFreeAcc & " , " & HL & " , " & 44

        'Last Line
        CALInputLine(111) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub





    '****************************************************************************************************************************************
    '*************************************Builds input string array for CAL3QHC input files - E-W Diamond************************************
    '****************************************************************************************************************************************
    Sub BuildEWDiamond()
        Dim i As Integer

        'Calls subroutine GetDiamondEF's
        GetDiamondEFs()

        'Determines traffic volume to be used for all directions in the CAL3QHC input file
        ATMax = ATNB
        If ATSB > ATMax Then ATMax = ATSB

        ATLeft = CSng(0.5 * ORNB)
        If CSng(0.5 * ORSB) > ATLeft Then ATLeft = CSng(0.5 * ORSB)

        ATRight = ATLeft

        FTMax = ATEB
        If ATWB > FTMax Then FTMax = ATWB

        FTRight = CSng(0.5 * OREB)
        If CSng(0.5 * ORWB) > FTRight Then FTRight = CSng(0.5 * ORWB)

        FTLeft = FTRight

        FTDep = CInt(FTMax) + (CInt(ATRight) + CInt(ATLeft)) - (CInt(FTRight) + CInt(FTLeft))
        ATDep = CInt(ATMax) - (CInt(ATRight) + CInt(ATLeft)) + (CInt(FTRight) + CInt(FTLeft))

        'E-W Diamond particular parameters
        NR = 20
        NumInputLines = 111
        NL = 38

        'First Line
        CALInputLine(1) = "'" & Job & "', " & ATIM & " , " & ZO & " , " & VS & " , " & VD & " , " & NR & " , " & SCAL & " , " & IOPT & " , " & IDEBUG

        'Receptor Lines
        For i = 2 To 21
            CALInputLine(i) = "'Receptor " & (i - 1) & "', " & XR(i - 1) & " , " & YR(i - 1) & " , " & ZR
        Next

        'RunName Title Line
        CALInputLine(22) = "'" & RunName & "', " & NL & " , " & NM & " , " & PRINT2 & " ," & MODE


        'NEXT, Write all Queue Links
        'WB OffRamp RightQ
        CALInputLine(23) = 2
        CALInputLine(24) = "'WB OffRamp RightQ'" & "," & TYP & ", " & 36 & " , " & 208 & " , " & 1019 & " , " & 48 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(25) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(FTRight) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'WB OffRamp LeftQ
        CALInputLine(26) = 2
        CALInputLine(27) = "'WB OffRamp LeftQ'" & "," & TYP & ", " & 36 & " , " & 193 & " , " & 944 & " , " & 48 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(28) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(FTLeft) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'NB Leg Thru1Q
        CALInputLine(29) = 2
        CALInputLine(30) = "'NB Leg Thru1Q'" & "," & TYP & ", " & 24 & " , " & -215 & " , " & 24 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(31) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB Leg Thru2Q
        CALInputLine(32) = 2
        CALInputLine(33) = "'NB Leg Thru2Q'" & "," & TYP & ", " & 24 & " , " & 190 & " , " & 24 & " , " & -193 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(34) = 120 & " , " & 105 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB Leg Left1Q
        CALInputLine(35) = 2
        CALInputLine(36) = "'NB Leg Left1Q'" & "," & TYP & ", " & 6 & " , " & -215 & " , " & 6 & " , " & -3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(37) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'NB Leg Left2Q
        CALInputLine(38) = 2
        CALInputLine(39) = "'NB Leg Left2Q'" & "," & TYP & ", " & 6 & " , " & 190 & " , " & 6 & " , " & -215 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(40) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'EB OffRamp RightQ
        CALInputLine(41) = 2
        CALInputLine(42) = "'EB OffRamp RightQ'" & "," & TYP & ", " & -36 & " , " & -208 & " , " & -1019 & " , " & -48 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(43) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(FTRight) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'EB OffRamp LeftQ
        CALInputLine(44) = 2
        CALInputLine(45) = "'EB OffRamp LeftQ'" & "," & TYP & ", " & -36 & " , " & -193 & " , " & -944 & " , " & -48 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(46) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(FTLeft) & " , " & EFId & " , " & SFRRamps & " , " & ST & " , " & AT

        'SB Leg Thru1Q
        CALInputLine(47) = 2
        CALInputLine(48) = "'SB Leg Thru1Q'" & "," & TYP & ", " & -24 & " , " & 215 & " , " & -24 & " , " & -3000 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(49) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'SB Leg Thru2Q
        CALInputLine(50) = 2
        CALInputLine(51) = "'SB Leg Thru2Q'" & "," & TYP & ", " & -24 & " , " & -190 & " , " & -24 & " , " & 193 & " , " & HL & " , " & 24 & " , " & 2
        CALInputLine(52) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATMax) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'SB Leg Left1Q
        CALInputLine(53) = 2
        CALInputLine(54) = "'SB Leg Left1Q'" & "," & TYP & ", " & -6 & " , " & 215 & " , " & -6 & " , " & 3000 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(55) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT

        'SB Leg Left2Q
        CALInputLine(56) = 2
        CALInputLine(57) = "'SB Leg Left2Q'" & "," & TYP & ", " & -6 & " , " & -190 & " , " & -6 & " , " & 215 & " , " & HL & " , " & 12 & " , " & 1
        CALInputLine(58) = 120 & " , " & 75 & " , " & YFAC & " , " & CInt(ATLeft) & " , " & EFId & " , " & SFR & " , " & ST & " , " & AT


        'NEXT, Write all WEST Bound Free Flow Links
        'WB Fwy Thru1
        CALInputLine(59) = 1
        CALInputLine(60) = "'WB Fwy Thru1'" & "," & TYP & ", " & 981 & " , " & 30 & " , " & 4000 & " , " & 30 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'WB Fwy Thru2
        CALInputLine(61) = 1
        CALInputLine(62) = "'WB Fwy Thru2'" & "," & TYP & ", " & 981 & " , " & 30 & " , " & -981 & " , " & 30 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'WB OffRamp Right
        CALInputLine(63) = 1
        CALInputLine(64) = "'WB OffRamp Right'" & "," & TYP & ", " & 36 & " , " & 208 & " , " & 1019 & " , " & 48 & " , " & CInt(FTRight) & " , " & EFHwy & " , " & HL & " , " & 32

        'WB OffRamp Left1
        CALInputLine(65) = 1
        CALInputLine(66) = "'WB OffRamp Left1'" & "," & TYP & ", " & 36 & " , " & 193 & " , " & 944 & " , " & 48 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'WB OffRamp Left2
        CALInputLine(67) = 1
        CALInputLine(68) = "'WB OffRamp Left2'" & "," & TYP & ", " & 36 & " , " & 193 & " , " & -24 & " , " & 193 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'WB OnRamp
        CALInputLine(69) = 1
        CALInputLine(70) = "'WB OnRamp'" & "," & TYP & ", " & -36 & " , " & 200 & " , " & -981 & " , " & 48 & " , " & (CInt(ATLeft) + CInt(ATRight)) & " , " & EFHwyOn & " , " & HL & " , " & 44

        'WB Leg Dep
        CALInputLine(71) = 1
        CALInputLine(72) = "'WB Leg Dep'" & "," & TYP & ", " & 981 & " , " & -30 & " , " & 4000 & " , " & -30 & " , " & CInt(FTDep) & " , " & EFHwy & " , " & HL & " , " & 56


        'NEXT, Write all MORTH Bound Free Flow Links
        'NB Leg Thru1
        CALInputLine(73) = 1
        CALInputLine(74) = "'NB Leg Thru1'" & "," & TYP & ", " & 24 & " , " & -193 & " , " & 24 & " , " & -3000 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'NB Leg Thru2
        CALInputLine(75) = 1
        CALInputLine(76) = "'NB Leg Thru2'" & "," & TYP & ", " & 24 & " , " & 190 & " , " & 24 & " , " & -193 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'NB Leg Left1
        CALInputLine(77) = 1
        CALInputLine(78) = "'NB Leg Left1'" & "," & TYP & ", " & 6 & " , " & -215 & " , " & 6 & " , " & -3000 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'NB Leg Left2
        CALInputLine(79) = 1
        CALInputLine(80) = "'NB Leg Left2'" & "," & TYP & ", " & 6 & " , " & 190 & " , " & 6 & " , " & -215 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'NB Leg Left3
        CALInputLine(81) = 1
        CALInputLine(82) = "'NB Leg Left3'" & "," & TYP & ", " & 6 & " , " & 190 & " , " & -36 & " , " & 200 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'NB Leg Dep
        CALInputLine(83) = 1
        CALInputLine(84) = "'NB Leg Dep'" & "," & TYP & ", " & -24 & " , " & -190 & " , " & -24 & " , " & -3000 & " , " & CInt(ATDep) & " , " & EFFreeAcc & " , " & HL & " , " & 44


        'NEXT, Write all EAST Bound Free Flow Links
        'EB Fwy Thru 1
        CALInputLine(85) = 1
        CALInputLine(86) = "'EB Fwy Thru 1'" & "," & TYP & ", " & -981 & " , " & -30 & " , " & -4000 & " , " & -30 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'EBFwy Thru 2
        CALInputLine(87) = 1
        CALInputLine(88) = "'EBFwy Thru 2'" & "," & TYP & ", " & -981 & " , " & -30 & " , " & 981 & " , " & -30 & " , " & CInt(FTMax) & " , " & EFHwy & " , " & HL & " , " & 56

        'EB OffRamp Right
        CALInputLine(89) = 1
        CALInputLine(90) = "'EB OffRamp Right'" & "," & TYP & ", " & -36 & " , " & -208 & " , " & -1019 & " , " & -48 & " , " & CInt(FTRight) & " , " & EFHwy & " , " & HL & " , " & 32

        'EB OffRamp Left1
        CALInputLine(91) = 1
        CALInputLine(92) = "'EB OffRamp Left1'" & "," & TYP & ", " & -36 & " , " & -193 & " , " & -944 & " , " & -48 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'EB OffRamp Left2
        CALInputLine(93) = 1
        CALInputLine(94) = "'EB OffRamp Left2'" & "," & TYP & ", " & -36 & " , " & -193 & " , " & 24 & " , " & -193 & " , " & CInt(FTLeft) & " , " & EFHwy & " , " & HL & " , " & 32

        'EB OnRamp
        CALInputLine(95) = 1
        CALInputLine(96) = "'EB OnRamp'" & "," & TYP & ", " & 36 & " , " & -200 & " , " & 981 & " , " & -48 & " , " & (CInt(ATLeft) + CInt(ATRight)) & " , " & EFHwyOn & " , " & HL & " , " & 44

        'EB Leg Dep
        CALInputLine(97) = 1
        CALInputLine(98) = "'EB Leg Dep'" & "," & TYP & ", " & -981 & " , " & 30 & " , " & -4000 & " , " & 30 & " , " & CInt(FTDep) & " , " & EFHwy & " , " & HL & " , " & 56


        'NEXT, Write all SOUTH Bound Free Flow Links
        'SB Leg Thru1
        CALInputLine(99) = 1
        CALInputLine(100) = "'SB Leg Thru1'" & "," & TYP & ", " & -24 & " , " & 193 & " , " & -24 & " , " & 3000 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'SB Leg Thru2
        CALInputLine(101) = 1
        CALInputLine(102) = "'SB Leg Thru2'" & "," & TYP & ", " & -24 & " , " & -190 & " , " & -24 & " , " & 193 & " , " & CInt(ATMax) & " , " & EFFree & " , " & HL & " , " & 44

        'SB Leg Left1
        CALInputLine(103) = 1
        CALInputLine(104) = "'SB Leg Left1'" & "," & TYP & ", " & -6 & " , " & 215 & " , " & -6 & " , " & 3000 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'SB Leg Left2
        CALInputLine(105) = 1
        CALInputLine(106) = "'SB Leg Left2'" & "," & TYP & ", " & -6 & " , " & -190 & " , " & -6 & " , " & 215 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'SB Leg Left3
        CALInputLine(107) = 1
        CALInputLine(108) = "'SB Leg Left3'" & "," & TYP & ", " & -6 & " , " & -190 & " , " & 36 & " , " & -200 & " , " & CInt(ATLeft) & " , " & EFLt & " , " & HL & " , " & 32

        'SB Leg Dep
        CALInputLine(109) = 1
        CALInputLine(110) = "'SB Leg Dep'" & "," & TYP & ", " & 24 & " , " & 190 & " , " & 24 & " , " & 3000 & " , " & CInt(ATDep) & " , " & EFFreeAcc & " , " & HL & " , " & 44

        'Last Line
        CALInputLine(111) = U & " , " & BRG & " , " & CLAS & " , " & MIXH & " , " & AMB & " ," & VAR & ", " & DEGR & " , " & VAL1 & " , " & VAL2
    End Sub

    '******************************************************************************************************************
    '*****************************************Open and Save Subroutines************************************************
    '******************************************************************************************************************
    Sub OpenFile()
        Dim i As Integer

        StreamToDisplay = New StreamReader(FDOTin)

        i = 1
        Do Until StreamToDisplay.EndOfStream
            IFR(i) = StreamToDisplay.ReadLine()
            i = i + 1
        Loop

        If IFR(1) <> "CO Florida 2012 - User Input Summary File" Then
            MsgBox("The file that you've selected is not a valid COFL input file.", 0, "CO Florida 2012")
            Exit Sub
        Else
            ClearAll()
        End If

        Job = IFR(5)
        FacilityName = IFR(8)
        UsersName = IFR(11)
        RunName = IFR(14)
        ProjectYear = IFR(17)
        Temperature = IFR(20)
        LandUse = IFR(23)
        ZO = IFR(26)
        CLAS = IFR(29)
        CLASLetter = IFR(30)
        COBack1Hr = IFR(33)
        COBack8Hr = IFR(36)
        DistrictNum = IFR(39)
        IntType = IFR(42)
        SSB = IFR(45)
        SWB = IFR(48)
        SNB = IFR(51)
        SEB = IFR(54)
        ATSB = IFR(57)
        ATWB = IFR(60)
        ATNB = IFR(63)
        ATEB = IFR(66)
        ORSB = IFR(69)
        ORWB = IFR(72)
        ORNB = IFR(75)
        OREB = IFR(78)
        ETCSB = IFR(81)
        ETCWB = IFR(84)
        ETCNB = IFR(87)
        ETCEB = IFR(90)
        InputsCorrect(1) = IFR(93)
        InputsCorrect(2) = IFR(96)
        InputsCorrect(3) = IFR(99)
        InputsCorrect(4) = IFR(102)

        For i = 105 To 124
            XR(i - 104) = IFR(i)
        Next

        For i = 127 To 146
            YR(i - 126) = IFR(i)
        Next

        EWTollBooth = IFR(149)

        StreamToDisplay.Close()

        FillEFArray()

        Select Case IntType
            Case "4 X 4"
                _4X4.Init4X4()
            Case "4 X 6"
                _4X6.Init4X6()
            Case ("6 X 4")
                _6X4.Init6X4()
            Case ("6 X 6")
                _6X6.Init6X6()
            Case "East Tee"
                East_Tee.InitEastTee()
            Case ("North Tee")
                North_Tee.InitNorthTee()
            Case ("Toll Booth")
                TollBoothEW.InitTollBooth()
            Case ("West Tee")
                WestTee.InitWestTee()
            Case ("South Tee")
                SouthTee.InitSouthTee()
            Case ("N-S Diamond")
                NorthSouthFreeway.InitNSDiamond()
            Case ("E-W Diamond")
                EastWestFreeway.InitEWDiamond()
        End Select
    End Sub




    Sub SaveFile()
        Dim i As Integer

        'Writes user inputted data to the user input file
        Dim sWriter As IO.StreamWriter

        sWriter = New IO.StreamWriter(FDOTin)

        sWriter.WriteLine("CO Florida 2012 - User Input Summary File")
        sWriter.WriteLine("")
        sWriter.WriteLine("")

        sWriter.WriteLine("Project Title")
        sWriter.WriteLine(Job)
        sWriter.WriteLine("")

        sWriter.WriteLine("Facility Name")
        sWriter.WriteLine(FacilityName)
        sWriter.WriteLine("")

        sWriter.WriteLine("User's Name")
        sWriter.WriteLine(UsersName)
        sWriter.WriteLine("")

        sWriter.WriteLine("Run Name")
        sWriter.WriteLine(RunName)
        sWriter.WriteLine("")

        sWriter.WriteLine("Project Year")
        sWriter.WriteLine(ProjectYear)
        sWriter.WriteLine("")

        sWriter.WriteLine("Temperature")
        sWriter.WriteLine(Temperature)
        sWriter.WriteLine("")

        sWriter.WriteLine("Land Use")
        sWriter.WriteLine(LandUse)
        sWriter.WriteLine("")

        sWriter.WriteLine("Zo")
        sWriter.WriteLine(ZO)
        sWriter.WriteLine("")

        sWriter.WriteLine("Stability Class")
        sWriter.WriteLine(CLAS)
        sWriter.WriteLine(CLASLetter)
        sWriter.WriteLine("")

        sWriter.WriteLine("1-hr CO Background Concentration")
        sWriter.WriteLine(COBack1Hr)
        sWriter.WriteLine("")

        sWriter.WriteLine("8-hr CO Background Concentration")
        sWriter.WriteLine(COBack8Hr)
        sWriter.WriteLine("")

        sWriter.WriteLine("FDOT District Number")
        sWriter.WriteLine(DistrictNum)
        sWriter.WriteLine("")

        sWriter.WriteLine("Intersection Type")
        sWriter.WriteLine(IntType)
        sWriter.WriteLine("")

        sWriter.WriteLine("Speed South Bound")
        sWriter.WriteLine(SSB)
        sWriter.WriteLine("")

        sWriter.WriteLine("Speed West Bound")
        sWriter.WriteLine(SWB)
        sWriter.WriteLine("")

        sWriter.WriteLine("Speed North Bound")
        sWriter.WriteLine(SNB)
        sWriter.WriteLine("")

        sWriter.WriteLine("Speed East Bound")
        sWriter.WriteLine(SEB)
        sWriter.WriteLine("")

        sWriter.WriteLine("Approach Traffic South Bound")
        sWriter.WriteLine(ATSB)
        sWriter.WriteLine("")

        sWriter.WriteLine("Approach Traffic West Bound")
        sWriter.WriteLine(ATWB)
        sWriter.WriteLine("")

        sWriter.WriteLine("Approach Traffic North Bound")
        sWriter.WriteLine(ATNB)
        sWriter.WriteLine("")

        sWriter.WriteLine("Approach Traffic East Bound")
        sWriter.WriteLine(ATEB)
        sWriter.WriteLine("")

        sWriter.WriteLine("On/Off Ramp Traffic South Bound")
        sWriter.WriteLine(ORSB)
        sWriter.WriteLine("")

        sWriter.WriteLine("On/Off Ramp Traffic West Bound")
        sWriter.WriteLine(ORWB)
        sWriter.WriteLine("")

        sWriter.WriteLine("On/Off Ramp Traffic North Bound")
        sWriter.WriteLine(ORNB)
        sWriter.WriteLine("")

        sWriter.WriteLine("On/Off Ramp Traffic East Bound")
        sWriter.WriteLine(OREB)
        sWriter.WriteLine("")

        sWriter.WriteLine("ETC-Only Percentage South Bound")
        sWriter.WriteLine(ETCSB)
        sWriter.WriteLine("")

        sWriter.WriteLine("ETC-Only Percentage West Bound")
        sWriter.WriteLine(ETCWB)
        sWriter.WriteLine("")

        sWriter.WriteLine("ETC-Only Percentage North Bound")
        sWriter.WriteLine(ETCNB)
        sWriter.WriteLine("")

        sWriter.WriteLine("ETC-Only Percentage East Bound")
        sWriter.WriteLine(ETCEB)
        sWriter.WriteLine("")

        sWriter.WriteLine("InputsCorrect(1)")
        sWriter.WriteLine(InputsCorrect(1))
        sWriter.WriteLine("")

        sWriter.WriteLine("InputsCorrect(2)")
        sWriter.WriteLine(InputsCorrect(2))
        sWriter.WriteLine("")

        sWriter.WriteLine("InputsCorrect(3)")
        sWriter.WriteLine(InputsCorrect(3))
        sWriter.WriteLine("")

        sWriter.WriteLine("InputsCorrect(4)")
        sWriter.WriteLine(InputsCorrect(4))
        sWriter.WriteLine("")

        sWriter.WriteLine("Receptor 'X' Coordinates")
        For i = 1 To 20
            sWriter.WriteLine(XR(i))
        Next i
        sWriter.WriteLine("")

        sWriter.WriteLine("Receptor 'Y' Coordinates")
        For i = 1 To 20
            sWriter.WriteLine(YR(i))
        Next i
        sWriter.WriteLine("")

        sWriter.WriteLine("EW Tollbooth")
        sWriter.WriteLine(EWTollBooth)

        sWriter.Flush()
        sWriter.Close()
    End Sub

End Class
