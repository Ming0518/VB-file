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
        gbPackage = New GroupBox()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        rbDiamond = New RadioButton()
        rbGold = New RadioButton()
        rbSilver = New RadioButton()
        rbBasic = New RadioButton()
        GroupBox1 = New GroupBox()
        cbLS = New CheckBox()
        cbSMC = New CheckBox()
        cbHMC = New CheckBox()
        cbCMC = New CheckBox()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label12 = New Label()
        GroupBox2 = New GroupBox()
        txtTotalCharge = New TextBox()
        lblTC = New Label()
        txtAdditionalCharges = New TextBox()
        lblAC = New Label()
        txtPackageCharge = New TextBox()
        lblPC = New Label()
        btnCalculate = New Button()
        btnExit = New Button()
        TextBox1 = New TextBox()
        gbPackage.SuspendLayout()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbPackage
        ' 
        gbPackage.Controls.Add(Label6)
        gbPackage.Controls.Add(Label5)
        gbPackage.Controls.Add(Label4)
        gbPackage.Controls.Add(Label3)
        gbPackage.Controls.Add(Label2)
        gbPackage.Controls.Add(Label1)
        gbPackage.Controls.Add(rbDiamond)
        gbPackage.Controls.Add(rbGold)
        gbPackage.Controls.Add(rbSilver)
        gbPackage.Controls.Add(rbBasic)
        gbPackage.Location = New Point(58, 39)
        gbPackage.Name = "gbPackage"
        gbPackage.Size = New Size(304, 190)
        gbPackage.TabIndex = 0
        gbPackage.TabStop = False
        gbPackage.Text = "Cable Package"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(24, 32)
        Label6.Name = "Label6"
        Label6.Size = New Size(66, 20)
        Label6.TabIndex = 9
        Label6.Text = "Package"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(178, 149)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 20)
        Label5.TabIndex = 8
        Label5.Text = "99.99"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(178, 119)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 7
        Label4.Text = "84.99"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(178, 89)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 6
        Label3.Text = "42.99"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(178, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(44, 20)
        Label2.TabIndex = 5
        Label2.Text = "24.99"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(136, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(146, 20)
        Label1.TabIndex = 4
        Label1.Text = "Monthly Charge ($)"
        ' 
        ' rbDiamond
        ' 
        rbDiamond.AutoSize = True
        rbDiamond.Location = New Point(24, 147)
        rbDiamond.Name = "rbDiamond"
        rbDiamond.Size = New Size(92, 24)
        rbDiamond.TabIndex = 3
        rbDiamond.TabStop = True
        rbDiamond.Text = "Diamond"
        rbDiamond.UseVisualStyleBackColor = True
        ' 
        ' rbGold
        ' 
        rbGold.AutoSize = True
        rbGold.Location = New Point(24, 117)
        rbGold.Name = "rbGold"
        rbGold.Size = New Size(62, 24)
        rbGold.TabIndex = 2
        rbGold.TabStop = True
        rbGold.Text = "Gold"
        rbGold.UseVisualStyleBackColor = True
        ' 
        ' rbSilver
        ' 
        rbSilver.AutoSize = True
        rbSilver.Location = New Point(24, 87)
        rbSilver.Name = "rbSilver"
        rbSilver.Size = New Size(66, 24)
        rbSilver.TabIndex = 1
        rbSilver.TabStop = True
        rbSilver.Text = "Silver"
        rbSilver.UseVisualStyleBackColor = True
        ' 
        ' rbBasic
        ' 
        rbBasic.AutoSize = True
        rbBasic.Location = New Point(24, 57)
        rbBasic.Name = "rbBasic"
        rbBasic.Size = New Size(64, 24)
        rbBasic.TabIndex = 0
        rbBasic.TabStop = True
        rbBasic.Text = "Basic"
        rbBasic.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbLS)
        GroupBox1.Controls.Add(cbSMC)
        GroupBox1.Controls.Add(cbHMC)
        GroupBox1.Controls.Add(cbCMC)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Label11)
        GroupBox1.Controls.Add(Label12)
        GroupBox1.Location = New Point(390, 39)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(421, 190)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Additional Features"
        ' 
        ' cbLS
        ' 
        cbLS.AutoSize = True
        cbLS.Location = New Point(24, 148)
        cbLS.Name = "cbLS"
        cbLS.Size = New Size(125, 24)
        cbLS.TabIndex = 17
        cbLS.Text = "Local stations "
        cbLS.UseVisualStyleBackColor = True
        ' 
        ' cbSMC
        ' 
        cbSMC.AutoSize = True
        cbSMC.Location = New Point(24, 118)
        cbSMC.Name = "cbSMC"
        cbSMC.Size = New Size(212, 24)
        cbSMC.TabIndex = 16
        cbSMC.Text = "Showtimer movie channels "
        cbSMC.UseVisualStyleBackColor = True
        ' 
        ' cbHMC
        ' 
        cbHMC.AutoSize = True
        cbHMC.Location = New Point(24, 88)
        cbHMC.Name = "cbHMC"
        cbHMC.Size = New Size(165, 24)
        cbHMC.TabIndex = 15
        cbHMC.Text = "HBI movie channels "
        cbHMC.UseVisualStyleBackColor = True
        ' 
        ' cbCMC
        ' 
        cbCMC.AutoSize = True
        cbCMC.Location = New Point(24, 58)
        cbCMC.Name = "cbCMC"
        cbCMC.Size = New Size(211, 24)
        cbCMC.TabIndex = 14
        cbCMC.Text = "Cinnematic movie channels"
        cbCMC.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(24, 32)
        Label7.Name = "Label7"
        Label7.Size = New Size(66, 20)
        Label7.TabIndex = 9
        Label7.Text = "Package"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(281, 148)
        Label8.Name = "Label8"
        Label8.Size = New Size(36, 20)
        Label8.TabIndex = 8
        Label8.Text = "6.00"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(273, 119)
        Label9.Name = "Label9"
        Label9.Size = New Size(44, 20)
        Label9.TabIndex = 7
        Label9.Text = "10.50"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(281, 89)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 20)
        Label10.TabIndex = 6
        Label10.Text = "9.50"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(281, 59)
        Label11.Name = "Label11"
        Label11.Size = New Size(36, 20)
        Label11.TabIndex = 5
        Label11.Text = "9.50"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(238, 32)
        Label12.Name = "Label12"
        Label12.Size = New Size(146, 20)
        Label12.TabIndex = 4
        Label12.Text = "Monthly Charge ($)"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(txtTotalCharge)
        GroupBox2.Controls.Add(lblTC)
        GroupBox2.Controls.Add(txtAdditionalCharges)
        GroupBox2.Controls.Add(lblAC)
        GroupBox2.Controls.Add(txtPackageCharge)
        GroupBox2.Controls.Add(lblPC)
        GroupBox2.Location = New Point(58, 247)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(304, 179)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        GroupBox2.Text = "Total Charges"
        ' 
        ' txtTotalCharge
        ' 
        txtTotalCharge.Enabled = False
        txtTotalCharge.Location = New Point(179, 121)
        txtTotalCharge.Name = "txtTotalCharge"
        txtTotalCharge.Size = New Size(103, 27)
        txtTotalCharge.TabIndex = 5
        ' 
        ' lblTC
        ' 
        lblTC.AutoSize = True
        lblTC.Location = New Point(24, 123)
        lblTC.Name = "lblTC"
        lblTC.Size = New Size(99, 20)
        lblTC.TabIndex = 4
        lblTC.Text = "Total Charges"
        lblTC.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtAdditionalCharges
        ' 
        txtAdditionalCharges.Enabled = False
        txtAdditionalCharges.Location = New Point(179, 81)
        txtAdditionalCharges.Name = "txtAdditionalCharges"
        txtAdditionalCharges.Size = New Size(103, 27)
        txtAdditionalCharges.TabIndex = 3
        ' 
        ' lblAC
        ' 
        lblAC.AutoSize = True
        lblAC.Location = New Point(24, 85)
        lblAC.Name = "lblAC"
        lblAC.Size = New Size(136, 20)
        lblAC.TabIndex = 2
        lblAC.Text = "Additional Charges"
        lblAC.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' txtPackageCharge
        ' 
        txtPackageCharge.Enabled = False
        txtPackageCharge.Location = New Point(179, 43)
        txtPackageCharge.Name = "txtPackageCharge"
        txtPackageCharge.Size = New Size(103, 27)
        txtPackageCharge.TabIndex = 1
        ' 
        ' lblPC
        ' 
        lblPC.AutoSize = True
        lblPC.Location = New Point(24, 47)
        lblPC.Name = "lblPC"
        lblPC.Size = New Size(120, 20)
        lblPC.TabIndex = 0
        lblPC.Text = "Package Charges"
        lblPC.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(423, 318)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(145, 59)
        btnCalculate.TabIndex = 12
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.Red
        btnExit.Location = New Point(594, 318)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(145, 59)
        btnExit.TabIndex = 13
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(487, 267)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(877, 450)
        Controls.Add(TextBox1)
        Controls.Add(btnExit)
        Controls.Add(btnCalculate)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(gbPackage)
        Name = "Form1"
        Text = "Form1"
        gbPackage.ResumeLayout(False)
        gbPackage.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gbPackage As GroupBox
    Friend WithEvents rbDiamond As RadioButton
    Friend WithEvents rbGold As RadioButton
    Friend WithEvents rbSilver As RadioButton
    Friend WithEvents rbBasic As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPackageCharge As TextBox
    Friend WithEvents lblPC As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtTotalCharge As TextBox
    Friend WithEvents lblTC As Label
    Friend WithEvents txtAdditionalCharges As TextBox
    Friend WithEvents lblAC As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents cbCMC As CheckBox
    Friend WithEvents cbHMC As CheckBox
    Friend WithEvents cbLS As CheckBox
    Friend WithEvents cbSMC As CheckBox
    Friend WithEvents TextBox1 As TextBox

End Class
