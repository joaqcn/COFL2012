Imports System.IO
Imports System.Runtime.CompilerServices

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
        Dim projectDescription As New projectDescription()
        projectDescription.Show()



    End Sub

    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
