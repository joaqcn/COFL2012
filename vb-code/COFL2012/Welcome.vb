Imports System.Runtime.CompilerServices

Public Class Welcome


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' Hide the Welcome Page
        Me.Hide()

        ' Loads the projectDescription Windows
        Dim projectDescription As New projectDescription()
        projectDescription.Show()



    End Sub
End Class
