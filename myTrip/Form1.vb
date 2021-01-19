Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblMyTrip.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picPlaces.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDescription.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalgary.Click
        Me.lblMyTrip.Text = "My Trip to Calgary"
        Me.lblDescription.Text = "Canada's Sports Hall of Fame in Calgary"
        picPlaces.Image = My.Resources.Canada_s_Sports_Hall_of_Fame
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEdmonton.Click
        Me.lblMyTrip.Text = "My Trip to Edmonton"
        Me.lblDescription.Text = "TELUS World of Science in Edmonton"
        picPlaces.Image = My.Resources.TELUS_World_of_Science

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBanff.Click
        Me.lblMyTrip.Text = "My Trip to Banff"
        Me.lblDescription.Text = "Banff Gondola Going up Sulphur Mountain"
        picPlaces.Image = My.Resources.Canada_s_Sports_Hall_of_Fame

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnWinnipeg.Click
        Me.lblMyTrip.Text = "My Trip to Winnipeg"
        Me.lblDescription.Text = "The Human Rights Museum and Esplanade Riel Pedestrian Bridge in Downtown Winnipeg at The Forks"
        picPlaces.Image = My.Resources.The_Forks

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnMars.Click
        Me.lblMyTrip.Text = "My Trip to Mars"
        Me.lblDescription.Text = "View of Mars From Space"
        picPlaces.Image = My.Resources.Mars

    End Sub
End Class
