Public Class Title
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
            Me.Hide()

            Dim district As New District()
            district.Show()


        End If
    End Sub
End Class
