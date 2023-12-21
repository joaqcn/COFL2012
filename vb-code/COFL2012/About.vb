Public Class About

    Private Sub btnCloseAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Visible = False
    End Sub

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Welcome.RoundButton(Button1)
    End Sub
    'Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    'Makes PictureBox1 visible and hides the rest
    '    PictureBox1.Visible = True
    '    PictureBox2.Visible = False
    '    PictureBox3.Visible = False
    '    PictureBox4.Visible = False
    '    PictureBox5.Visible = False
    '    PictureBox6.Visible = False
    '    PictureBox7.Visible = False
    '    PictureBox8.Visible = False
    '    PictureBox9.Visible = False
    '    PictureBox10.Visible = False
    '    PictureBox11.Visible = False
    '    PictureBox12.Visible = False
    '    PictureBox13.Visible = False
    '    PictureBox14.Visible = False
    '    PictureBox15.Visible = False
    '    PictureBox16.Visible = False
    '    PictureBox17.Visible = False
    '    PictureBox18.Visible = False
    '    PictureBox19.Visible = True

    '    'Generates a random number to be used to select image to display
    '    Randomize()
    '    RandNum = Int(Rnd() * 18)

    '    'Displays the image associated with the random number and hides the rest
    '    Select Case RandNum
    '        Case 1
    '            'Do nothing
    '        Case 2
    '            PictureBox1.Visible = False
    '            PictureBox2.Visible = True
    '        Case 3
    '            PictureBox1.Visible = False
    '            PictureBox3.Visible = True
    '        Case 4
    '            PictureBox1.Visible = False
    '            PictureBox4.Visible = True
    '        Case 5
    '            PictureBox1.Visible = False
    '            PictureBox5.Visible = True
    '        Case 6
    '            PictureBox1.Visible = False
    '            PictureBox6.Visible = True
    '        Case 7
    '            PictureBox1.Visible = False
    '            PictureBox7.Visible = True
    '        Case 8
    '            PictureBox1.Visible = False
    '            PictureBox8.Visible = True
    '        Case 9
    '            PictureBox1.Visible = False
    '            PictureBox9.Visible = True
    '        Case 10
    '            PictureBox1.Visible = False
    '            PictureBox10.Visible = True
    '        Case 11
    '            PictureBox1.Visible = False
    '            PictureBox11.Visible = True
    '        Case 12
    '            PictureBox1.Visible = False
    '            PictureBox12.Visible = True
    '        Case 13
    '            PictureBox1.Visible = False
    '            PictureBox13.Visible = True
    '        Case 14
    '            PictureBox1.Visible = False
    '            PictureBox14.Visible = True
    '        Case 15
    '            PictureBox1.Visible = False
    '            PictureBox15.Visible = True
    '        Case 16
    '            PictureBox1.Visible = False
    '            PictureBox16.Visible = True
    '        Case 17
    '            PictureBox1.Visible = False
    '            PictureBox17.Visible = True
    '        Case 18
    '            PictureBox1.Visible = False
    '            PictureBox18.Visible = True
    '    End Select
    'End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
    End Sub


End Class