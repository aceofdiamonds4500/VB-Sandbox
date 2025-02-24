<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSandbox
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		RadioButton1 = New RadioButton()
		RadioButton2 = New RadioButton()
		RadioButton3 = New RadioButton()
		RadioButton4 = New RadioButton()
		ProgressBar1 = New ProgressBar()
		SuspendLayout()
		' 
		' RadioButton1
		' 
		RadioButton1.AutoSize = True
		RadioButton1.Location = New Point(41, 257)
		RadioButton1.Name = "RadioButton1"
		RadioButton1.Size = New Size(97, 19)
		RadioButton1.TabIndex = 0
		RadioButton1.TabStop = True
		RadioButton1.Text = "RadioButton1"
		RadioButton1.UseVisualStyleBackColor = True
		' 
		' RadioButton2
		' 
		RadioButton2.AutoSize = True
		RadioButton2.Location = New Point(41, 282)
		RadioButton2.Name = "RadioButton2"
		RadioButton2.Size = New Size(97, 19)
		RadioButton2.TabIndex = 1
		RadioButton2.TabStop = True
		RadioButton2.Text = "RadioButton2"
		RadioButton2.UseVisualStyleBackColor = True
		' 
		' RadioButton3
		' 
		RadioButton3.AutoSize = True
		RadioButton3.Location = New Point(41, 307)
		RadioButton3.Name = "RadioButton3"
		RadioButton3.Size = New Size(97, 19)
		RadioButton3.TabIndex = 2
		RadioButton3.TabStop = True
		RadioButton3.Text = "RadioButton3"
		RadioButton3.UseVisualStyleBackColor = True
		' 
		' RadioButton4
		' 
		RadioButton4.AutoSize = True
		RadioButton4.Location = New Point(41, 332)
		RadioButton4.Name = "RadioButton4"
		RadioButton4.Size = New Size(54, 19)
		RadioButton4.TabIndex = 3
		RadioButton4.TabStop = True
		RadioButton4.Text = "None"
		RadioButton4.UseVisualStyleBackColor = True
		' 
		' ProgressBar1
		' 
		ProgressBar1.Location = New Point(293, 415)
		ProgressBar1.Name = "ProgressBar1"
		ProgressBar1.Size = New Size(204, 23)
		ProgressBar1.TabIndex = 4
		ProgressBar1.Minimum = 0
		ProgressBar1.Maximum = 200
		ProgressBar1.Value = 130
		' 
		' frmSandbox
		' 
		AutoScaleDimensions = New SizeF(7.0F, 15.0F)
		AutoScaleMode = AutoScaleMode.Font
		ClientSize = New Size(800, 450)
		Controls.Add(ProgressBar1)
		Controls.Add(RadioButton4)
		Controls.Add(RadioButton3)
		Controls.Add(RadioButton2)
		Controls.Add(RadioButton1)
		MaximizeBox = False
		MinimizeBox = False
		Name = "frmSandbox"
		Text = "My Sandbox"
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents RadioButton4 As RadioButton
	Friend WithEvents ProgressBar1 As ProgressBar

End Class
