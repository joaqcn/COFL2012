

Public Class Title
    Private roadType As String
    Private Sub next_buttom_project_Click(sender As Object, e As EventArgs) Handles next_buttom_project.Click




        ' Check if any of the text boxes are empty
        If String.IsNullOrEmpty(project_title.Text) Or
           String.IsNullOrEmpty(facility_name.Text) Or
           String.IsNullOrEmpty(user_name.Text) Or
           String.IsNullOrEmpty(TextBox4.Text) Or
           String.IsNullOrEmpty(project_year.Text) Then
            MessageBox.Show("Please fill in all required fields.")
        Else
            ' Hide the Welcome Page
            getDataFromTitle()
            Me.Hide()
            Dim district As New District()
            district.Show()
        End If
    End Sub

    Private Sub getDataFromTitle()
        Welcome.Job = project_title.Text
        Welcome.FacilityName = facility_name.Text
        Welcome.Job = project_title.Text
        Welcome.FacilityName = facility_name.Text
        Welcome.UsersName = user_name.Text
        Welcome.RunName = TextBox4.Text
        Welcome.ProjectYear = project_year.Text
        Welcome.LandUse = roadType
    End Sub

    Private Sub urban_button_Click(sender As Object, e As EventArgs) Handles urban_button.Click
        roadType = "Urban"

    End Sub

    Private Sub suburban_button_Click(sender As Object, e As EventArgs) Handles suburban_button.Click
        roadType = "Suburban"
    End Sub

    Private Sub rural_button_Click(sender As Object, e As EventArgs) Handles rural_button.Click
        roadType = "Rural"
    End Sub
End Class
