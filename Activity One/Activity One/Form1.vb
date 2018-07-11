Public Class Form1

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'Text boxes
        outName.Text = inputName.Text
        outDOB.Text = FormatDateTime(dtpDob.Value, DateFormat.ShortDate)
        outAge.Text = inputAge.Text
        'Radio Button
        If rdbMale.Checked Then outGender.Text = rdbMale.Text
        If rdbFemale.Checked Then outGender.Text = rdbFemale.Text
        'Combo Box
        outCourse.Text = cbxCourse.Text
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        inputAge.Text = ""
        inputName.Text = ""
        cbxCourse.SelectedIndex = -1
        rdbMale.Checked = False
        rdbFemale.Checked = False
        dtpDob.Value = "01/01/2000"
        outName.Text = ""
        outAge.Text = ""
        outCourse.Text = ""
        outDOB.Text = ""
        outGender.Text = ""
        outDOB.Text = ""
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        End
    End Sub

End Class
