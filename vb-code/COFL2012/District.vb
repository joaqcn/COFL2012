Public Class District

    Private districtSelected As Boolean = False

    Private Sub district1_Click(sender As Object, e As EventArgs) Handles district1.Click
        districtSelected = True
        Welcome.DistrictNum = 1
    End Sub

    Private Sub district2_Click(sender As Object, e As EventArgs) Handles district2.Click
        districtSelected = True
        Welcome.DistrictNum = 2
    End Sub
    Private Sub district4_Click(sender As Object, e As EventArgs) Handles district4.Click
        districtSelected = True
        Welcome.DistrictNum = 4
    End Sub

    Private Sub district5_Click(sender As Object, e As EventArgs) Handles district5.Click
        districtSelected = True
        Welcome.DistrictNum = 5
    End Sub

    Private Sub district6_Click(sender As Object, e As EventArgs) Handles district6.Click
        districtSelected = True
        Welcome.DistrictNum = 6
    End Sub

    Private Sub district7_Click(sender As Object, e As EventArgs) Handles district7.Click
        districtSelected = True
        Welcome.DistrictNum = 7
    End Sub

    Private Sub district3_Click(sender As Object, e As EventArgs) Handles district3.Click
        districtSelected = True
        Welcome.DistrictNum = 3
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If districtSelected Then
            Dim IntersectionType As New IntersectionType()
            Me.Hide()
            IntersectionType.Show()
        Else
            MessageBox.Show("Please select a district before proceeding")
        End If

    End Sub


End Class