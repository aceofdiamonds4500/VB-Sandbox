Public Class frmSandbox
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
		RadioButton2.Checked = False
	End Sub

	Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
		RadioButton1.Checked = False
	End Sub

	Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

	End Sub

	Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

	End Sub

	Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

	End Sub
End Class
