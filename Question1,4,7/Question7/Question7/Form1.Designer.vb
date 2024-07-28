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
        btnClear = New Button()
        btnExit = New Button()
        txtTotal = New TextBox()
        Label4 = New Label()
        txtAdditional = New TextBox()
        Label3 = New Label()
        txtCommission = New TextBox()
        Label2 = New Label()
        btnCalculate = New Button()
        gbTravel = New GroupBox()
        rbFalse = New RadioButton()
        rbTrue = New RadioButton()
        gbWork = New GroupBox()
        rbLess = New RadioButton()
        rbOver = New RadioButton()
        txtSales = New TextBox()
        Label1 = New Label()
        gbTravel.SuspendLayout()
        gbWork.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(397, 232)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 25
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(601, 369)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 50)
        btnExit.TabIndex = 24
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(386, 369)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(125, 27)
        txtTotal.TabIndex = 23
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(280, 372)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 22
        Label4.Text = "Total Due:"
        ' 
        ' txtAdditional
        ' 
        txtAdditional.Location = New Point(386, 327)
        txtAdditional.Name = "txtAdditional"
        txtAdditional.Size = New Size(125, 27)
        txtAdditional.TabIndex = 21
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(217, 334)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 20)
        Label3.TabIndex = 20
        Label3.Text = "Additional Amount:"
        ' 
        ' txtCommission
        ' 
        txtCommission.Location = New Point(386, 285)
        txtCommission.Name = "txtCommission"
        txtCommission.Size = New Size(125, 27)
        txtCommission.TabIndex = 19
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(263, 292)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 18
        Label2.Text = "Commission:"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(280, 232)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 17
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' gbTravel
        ' 
        gbTravel.Controls.Add(rbFalse)
        gbTravel.Controls.Add(rbTrue)
        gbTravel.Location = New Point(427, 79)
        gbTravel.Name = "gbTravel"
        gbTravel.Size = New Size(250, 125)
        gbTravel.TabIndex = 16
        gbTravel.TabStop = False
        gbTravel.Text = "Travel"
        ' 
        ' rbFalse
        ' 
        rbFalse.AutoSize = True
        rbFalse.Location = New Point(36, 78)
        rbFalse.Name = "rbFalse"
        rbFalse.Size = New Size(62, 24)
        rbFalse.TabIndex = 3
        rbFalse.TabStop = True
        rbFalse.Text = "False"
        rbFalse.UseVisualStyleBackColor = True
        ' 
        ' rbTrue
        ' 
        rbTrue.AutoSize = True
        rbTrue.Location = New Point(36, 37)
        rbTrue.Name = "rbTrue"
        rbTrue.Size = New Size(58, 24)
        rbTrue.TabIndex = 2
        rbTrue.TabStop = True
        rbTrue.Text = "True"
        rbTrue.UseVisualStyleBackColor = True
        ' 
        ' gbWork
        ' 
        gbWork.Controls.Add(rbLess)
        gbWork.Controls.Add(rbOver)
        gbWork.Location = New Point(106, 79)
        gbWork.Name = "gbWork"
        gbWork.Size = New Size(250, 125)
        gbWork.TabIndex = 15
        gbWork.TabStop = False
        gbWork.Text = "WorkExperience"
        ' 
        ' rbLess
        ' 
        rbLess.AutoSize = True
        rbLess.Location = New Point(38, 78)
        rbLess.Name = "rbLess"
        rbLess.Size = New Size(148, 24)
        rbLess.TabIndex = 1
        rbLess.TabStop = True
        rbLess.Text = "Less than 10 years"
        rbLess.UseVisualStyleBackColor = True
        ' 
        ' rbOver
        ' 
        rbOver.AutoSize = True
        rbOver.Location = New Point(38, 37)
        rbOver.Name = "rbOver"
        rbOver.Size = New Size(119, 24)
        rbOver.TabIndex = 0
        rbOver.TabStop = True
        rbOver.Text = "Over 10 years"
        rbOver.UseVisualStyleBackColor = True
        ' 
        ' txtSales
        ' 
        txtSales.Location = New Point(366, 31)
        txtSales.Name = "txtSales"
        txtSales.Size = New Size(125, 27)
        txtSales.TabIndex = 14
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(263, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 13
        Label1.Text = "Enter Sales:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnClear)
        Controls.Add(btnExit)
        Controls.Add(txtTotal)
        Controls.Add(Label4)
        Controls.Add(txtAdditional)
        Controls.Add(Label3)
        Controls.Add(txtCommission)
        Controls.Add(Label2)
        Controls.Add(btnCalculate)
        Controls.Add(gbTravel)
        Controls.Add(gbWork)
        Controls.Add(txtSales)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        gbTravel.ResumeLayout(False)
        gbTravel.PerformLayout()
        gbWork.ResumeLayout(False)
        gbWork.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAdditional As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCommission As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents gbTravel As GroupBox
    Friend WithEvents rbFalse As RadioButton
    Friend WithEvents rbTrue As RadioButton
    Friend WithEvents gbWork As GroupBox
    Friend WithEvents rbLess As RadioButton
    Friend WithEvents rbOver As RadioButton
    Friend WithEvents txtSales As TextBox
    Friend WithEvents Label1 As Label

End Class
