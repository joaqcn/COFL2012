

Public Class Title
    Private roadType As String

    Public welcome As New Welcome()
    Private Sub next_buttom_project_Click(sender As Object, e As EventArgs) Handles next_buttom_project.Click

        welcome.Job = project_title.Text
        welcome.FacilityName = facility_name.Text
        welcome.UsersName = user_name.Text
        welcome.RunName = TextBox4.Text
        welcome.ProjectYear = project_year.Text
        welcome.LandUse = roadType

        ' Check if any of the text boxes are empty
        If String.IsNullOrEmpty(project_title.Text) Or
           String.IsNullOrEmpty(facility_name.Text) Or
           String.IsNullOrEmpty(user_name.Text) Or
           String.IsNullOrEmpty(TextBox4.Text) Or
           String.IsNullOrEmpty(project_year.Text) Then
            MessageBox.Show("Please fill in all required fields.")
        Else
            ' Hide the Welcome Page
            Me.Hide()

            Dim district As New District()
            district.Show()
        End If
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
