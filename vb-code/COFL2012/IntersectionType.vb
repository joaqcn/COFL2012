Public Class IntersectionType
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) Handles fourByFourPic.Click, fourbySixPic.Click, sixByFourPic.Click, sixBySixPic.Click, eastTeePic.Click, northTeePic.Click, tollBoothPic.Click, westTeePic.Click, southTeePic.Click, northSouthFreewayPic.Click, eastWestFreewayPic.Click
        Select Case DirectCast(sender, PictureBox).Name
            Case "fourByFourPic"
                Dim fourByFour As New _4X4()
                Welcome.IntType = "4X4"
                Me.Hide()
                fourByFour.Show()
            Case "fourbySixPic"
                ' Codfor fourbySixPic
                Dim fourBySix As New _4X6()
                Welcome.IntType = "4X6"
                Me.Hide()
                fourBySix.Show()
            Case "sixByFourPic"
                Dim sixByFour As New _6X4()
                Welcome.IntType = "6X4"
                Me.Hide()
                sixByFour.Show()
            Case "sixBySixPic"
                Dim sixBySix As New _6X6()
                Welcome.IntType = "6X6"
                Me.Hide()
                sixBySix.Show()
            Case "eastTeePic"
                Dim eastTee As New East_Tee()
                Welcome.IntType = "East Tee"
                Me.Hide()
                eastTee.Show()
            Case "northTeePic"
                Dim northTee As New North_Tee()
                Welcome.IntType = "North Tee"
                Me.Hide()
                northTee.Show()
            Case "tollBoothPic"
                Dim tollBooth As New TollBoothEW()
                Welcome.IntType = "Toll Booth"
                Me.Hide()
                tollBooth.Show()
            Case "westTeePic"
                Dim westTee As New WestTee()
                Welcome.IntType = "West Tee"
                Me.Hide()
                westTee.Show()
            Case "southTeePic"
                ' Code for southTeePic
                Dim southTee As New SouthTee()
                Welcome.IntType = "South Tee"
                Me.Hide()
                southTee.Show()
            Case "northSouthFreewayPic"
                Dim northSouthFreeway As New NorthSouthFreeway()
                Welcome.IntType = "Diamond Interchange N-S Freeway"
                Me.Hide()
                northSouthFreeway.Show()
            Case "eastWestFreewayPic"
                Dim eastWestFreeway As New EastWestFreeway()
                Welcome.IntType = "Diamond Interchange E-W Freeway"
                Me.Hide()
                eastWestFreeway.Show()
        End Select
    End Sub
End Class
