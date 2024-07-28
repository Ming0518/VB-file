<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        rbMember = New RadioButton()
        rbNonMember = New RadioButton()
        GroupBox1 = New GroupBox()
        groupBoxDays = New GroupBox()
        rbMonThur = New RadioButton()
        rbFriSun = New RadioButton()
        Label1 = New Label()
        txtTotal = New TextBox()
        btnCalculate = New Button()
        GroupBox1.SuspendLayout()
        groupBoxDays.SuspendLayout()
        SuspendLayout()
        ' 
        ' rbMember
        ' 
        rbMember.AutoSize = True
        rbMember.Location = New Point(39, 43)
        rbMember.Name = "rbMember"
        rbMember.Size = New Size(86, 24)
        rbMember.TabIndex = 1
        rbMember.TabStop = True
        rbMember.Text = "Member"
        rbMember.UseVisualStyleBackColor = True
        ' 
        ' rbNonMember
        ' 
        rbNonMember.AutoSize = True
        rbNonMember.Location = New Point(39, 85)
        rbNonMember.Name = "rbNonMember"
        rbNonMember.Size = New Size(120, 24)
        rbNonMember.TabIndex = 2
        rbNonMember.TabStop = True
        rbNonMember.Text = "Non-Member"
        rbNonMember.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbMember)
        GroupBox1.Controls.Add(rbNonMember)
        GroupBox1.Location = New Point(94, 57)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(246, 124)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        GroupBox1.Text = "Member Or Non-Member:"
        ' 
        ' groupBoxDays
        ' 
        groupBoxDays.Controls.Add(rbMonThur)
        groupBoxDays.Controls.Add(rbFriSun)
        groupBoxDays.Location = New Point(376, 57)
        groupBoxDays.Name = "groupBoxDays"
        groupBoxDays.Size = New Size(246, 124)
        groupBoxDays.TabIndex = 4
        groupBoxDays.TabStop = False
        groupBoxDays.Text = "Days"
        groupBoxDays.Visible = False
        ' 
        ' rbMonThur
        ' 
        rbMonThur.AutoSize = True
        rbMonThur.Location = New Point(39, 43)
        rbMonThur.Name = "rbMonThur"
        rbMonThur.Size = New Size(161, 24)
        rbMonThur.TabIndex = 1
        rbMonThur.TabStop = True
        rbMonThur.Text = " Monday - Thursday"
        rbMonThur.UseVisualStyleBackColor = True
        ' 
        ' rbFriSun
        ' 
        rbFriSun.AutoSize = True
        rbFriSun.Location = New Point(39, 85)
        rbFriSun.Name = "rbFriSun"
        rbFriSun.Size = New Size(132, 24)
        rbFriSun.TabIndex = 2
        rbFriSun.TabStop = True
        rbFriSun.Text = "Friday - Sunday"
        rbFriSun.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(208, 286)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 20)
        Label1.TabIndex = 5
        Label1.Text = "Total cost:"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(295, 283)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(125, 27)
        txtTotal.TabIndex = 6
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(273, 228)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 7
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 351)
        Controls.Add(btnCalculate)
        Controls.Add(txtTotal)
        Controls.Add(Label1)
        Controls.Add(groupBoxDays)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Question 1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        groupBoxDays.ResumeLayout(False)
        groupBoxDays.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbMember As RadioButton
    Friend WithEvents rbNonMember As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents groupBoxDays As GroupBox
    Friend WithEvents rbMonThur As RadioButton
    Friend WithEvents rbFriSun As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCalculate As Button

End Class
