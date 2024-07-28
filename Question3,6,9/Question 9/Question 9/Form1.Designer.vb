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
        gbJackets = New GroupBox()
        lblWarning = New Label()
        txtRedNum = New TextBox()
        txtNavyNum = New TextBox()
        txtBlackNum = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        lblBlackJacket = New Label()
        gbPayment = New GroupBox()
        rbEW = New RadioButton()
        rbOB = New RadioButton()
        rbCash = New RadioButton()
        rbCC = New RadioButton()
        gbJacketList = New GroupBox()
        Label7 = New Label()
        Label6 = New Label()
        lblP1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        txtOriAmount = New TextBox()
        lblOriAmount = New Label()
        txtTotalAmount = New TextBox()
        txtTotalJacket = New TextBox()
        txtDiscount = New TextBox()
        lblTotalJacket = New Label()
        lblDiscount = New Label()
        lblTotalAmount = New Label()
        btnCalc = New Button()
        btnExit = New Button()
        gbJackets.SuspendLayout()
        gbPayment.SuspendLayout()
        gbJacketList.SuspendLayout()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbJackets
        ' 
        gbJackets.Controls.Add(lblWarning)
        gbJackets.Controls.Add(txtRedNum)
        gbJackets.Controls.Add(txtNavyNum)
        gbJackets.Controls.Add(txtBlackNum)
        gbJackets.Controls.Add(Label2)
        gbJackets.Controls.Add(Label1)
        gbJackets.Controls.Add(lblBlackJacket)
        gbJackets.Location = New Point(45, 237)
        gbJackets.Name = "gbJackets"
        gbJackets.Size = New Size(359, 166)
        gbJackets.TabIndex = 0
        gbJackets.TabStop = False
        gbJackets.Text = "Please Input Number of Jackets Here"
        ' 
        ' lblWarning
        ' 
        lblWarning.AutoSize = True
        lblWarning.ForeColor = Color.Red
        lblWarning.Location = New Point(17, 143)
        lblWarning.Name = "lblWarning"
        lblWarning.Size = New Size(0, 20)
        lblWarning.TabIndex = 6
        ' 
        ' txtRedNum
        ' 
        txtRedNum.Location = New Point(207, 102)
        txtRedNum.Name = "txtRedNum"
        txtRedNum.Size = New Size(125, 27)
        txtRedNum.TabIndex = 5
        ' 
        ' txtNavyNum
        ' 
        txtNavyNum.Location = New Point(207, 68)
        txtNavyNum.Name = "txtNavyNum"
        txtNavyNum.Size = New Size(125, 27)
        txtNavyNum.TabIndex = 4
        ' 
        ' txtBlackNum
        ' 
        txtBlackNum.Location = New Point(207, 35)
        txtBlackNum.Name = "txtBlackNum"
        txtBlackNum.Size = New Size(125, 27)
        txtBlackNum.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 105)
        Label2.Name = "Label2"
        Label2.Size = New Size(155, 20)
        Label2.TabIndex = 2
        Label2.Text = "Number of Red Jacket"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(17, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(162, 20)
        Label1.TabIndex = 1
        Label1.Text = "Number of Navy Jacket"
        ' 
        ' lblBlackJacket
        ' 
        lblBlackJacket.AutoSize = True
        lblBlackJacket.Location = New Point(17, 38)
        lblBlackJacket.Name = "lblBlackJacket"
        lblBlackJacket.Size = New Size(164, 20)
        lblBlackJacket.TabIndex = 0
        lblBlackJacket.Text = "Number of Black Jacket"
        ' 
        ' gbPayment
        ' 
        gbPayment.Controls.Add(rbEW)
        gbPayment.Controls.Add(rbOB)
        gbPayment.Controls.Add(rbCash)
        gbPayment.Controls.Add(rbCC)
        gbPayment.Location = New Point(430, 41)
        gbPayment.Name = "gbPayment"
        gbPayment.Size = New Size(332, 105)
        gbPayment.TabIndex = 1
        gbPayment.TabStop = False
        gbPayment.Text = "Payment Method"
        ' 
        ' rbEW
        ' 
        rbEW.AutoSize = True
        rbEW.Location = New Point(146, 63)
        rbEW.Name = "rbEW"
        rbEW.Size = New Size(86, 24)
        rbEW.TabIndex = 3
        rbEW.Text = "E-Wallet"
        rbEW.UseVisualStyleBackColor = True
        ' 
        ' rbOB
        ' 
        rbOB.AutoSize = True
        rbOB.Location = New Point(146, 33)
        rbOB.Name = "rbOB"
        rbOB.Size = New Size(130, 24)
        rbOB.TabIndex = 2
        rbOB.Text = "Online Banking"
        rbOB.UseVisualStyleBackColor = True
        ' 
        ' rbCash
        ' 
        rbCash.AutoSize = True
        rbCash.Location = New Point(24, 63)
        rbCash.Name = "rbCash"
        rbCash.Size = New Size(61, 24)
        rbCash.TabIndex = 1
        rbCash.Text = "Cash"
        rbCash.UseVisualStyleBackColor = True
        ' 
        ' rbCC
        ' 
        rbCC.AutoSize = True
        rbCC.Checked = True
        rbCC.Location = New Point(24, 33)
        rbCC.Name = "rbCC"
        rbCC.Size = New Size(105, 24)
        rbCC.TabIndex = 0
        rbCC.TabStop = True
        rbCC.Text = "Credit Card"
        rbCC.UseVisualStyleBackColor = True
        ' 
        ' gbJacketList
        ' 
        gbJacketList.Controls.Add(Label7)
        gbJacketList.Controls.Add(Label6)
        gbJacketList.Controls.Add(lblP1)
        gbJacketList.Controls.Add(Label3)
        gbJacketList.Controls.Add(Label4)
        gbJacketList.Controls.Add(Label5)
        gbJacketList.Location = New Point(45, 41)
        gbJacketList.Name = "gbJacketList"
        gbJacketList.Size = New Size(359, 178)
        gbJacketList.TabIndex = 6
        gbJacketList.TabStop = False
        gbJacketList.Text = "Jacket List"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(207, 119)
        Label7.Name = "Label7"
        Label7.Size = New Size(58, 20)
        Label7.TabIndex = 5
        Label7.Text = "$39.99"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(207, 85)
        Label6.Name = "Label6"
        Label6.Size = New Size(58, 20)
        Label6.TabIndex = 4
        Label6.Text = "$39.99"
        ' 
        ' lblP1
        ' 
        lblP1.AutoSize = True
        lblP1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblP1.Location = New Point(207, 52)
        lblP1.Name = "lblP1"
        lblP1.Size = New Size(58, 20)
        lblP1.TabIndex = 3
        lblP1.Text = "$45.99"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(31, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(79, 20)
        Label3.TabIndex = 2
        Label3.Text = "Red Jacket"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(31, 85)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 20)
        Label4.TabIndex = 1
        Label4.Text = "Navy Jacket"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(31, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 20)
        Label5.TabIndex = 0
        Label5.Text = "Black Jacket"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtOriAmount)
        GroupBox1.Controls.Add(lblOriAmount)
        GroupBox1.Controls.Add(txtTotalAmount)
        GroupBox1.Controls.Add(txtTotalJacket)
        GroupBox1.Controls.Add(txtDiscount)
        GroupBox1.Controls.Add(lblTotalJacket)
        GroupBox1.Controls.Add(lblDiscount)
        GroupBox1.Controls.Add(lblTotalAmount)
        GroupBox1.Location = New Point(430, 170)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(332, 170)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Output"
        ' 
        ' txtOriAmount
        ' 
        txtOriAmount.Enabled = False
        txtOriAmount.Location = New Point(211, 64)
        txtOriAmount.Name = "txtOriAmount"
        txtOriAmount.Size = New Size(105, 27)
        txtOriAmount.TabIndex = 13
        ' 
        ' lblOriAmount
        ' 
        lblOriAmount.AutoSize = True
        lblOriAmount.Location = New Point(21, 67)
        lblOriAmount.Name = "lblOriAmount"
        lblOriAmount.Size = New Size(119, 20)
        lblOriAmount.TabIndex = 12
        lblOriAmount.Text = "Original Amount"
        ' 
        ' txtTotalAmount
        ' 
        txtTotalAmount.Enabled = False
        txtTotalAmount.Location = New Point(211, 130)
        txtTotalAmount.Name = "txtTotalAmount"
        txtTotalAmount.Size = New Size(105, 27)
        txtTotalAmount.TabIndex = 11
        ' 
        ' txtTotalJacket
        ' 
        txtTotalJacket.Enabled = False
        txtTotalJacket.Location = New Point(211, 31)
        txtTotalJacket.Name = "txtTotalJacket"
        txtTotalJacket.Size = New Size(105, 27)
        txtTotalJacket.TabIndex = 9
        ' 
        ' txtDiscount
        ' 
        txtDiscount.Enabled = False
        txtDiscount.Location = New Point(211, 97)
        txtDiscount.Name = "txtDiscount"
        txtDiscount.Size = New Size(105, 27)
        txtDiscount.TabIndex = 10
        ' 
        ' lblTotalJacket
        ' 
        lblTotalJacket.AutoSize = True
        lblTotalJacket.Location = New Point(21, 34)
        lblTotalJacket.Name = "lblTotalJacket"
        lblTotalJacket.Size = New Size(86, 20)
        lblTotalJacket.TabIndex = 6
        lblTotalJacket.Text = "Total Jacket"
        ' 
        ' lblDiscount
        ' 
        lblDiscount.AutoSize = True
        lblDiscount.Location = New Point(21, 100)
        lblDiscount.Name = "lblDiscount"
        lblDiscount.Size = New Size(67, 20)
        lblDiscount.TabIndex = 7
        lblDiscount.Text = "Discount"
        ' 
        ' lblTotalAmount
        ' 
        lblTotalAmount.AutoSize = True
        lblTotalAmount.Location = New Point(21, 132)
        lblTotalAmount.Name = "lblTotalAmount"
        lblTotalAmount.Size = New Size(99, 20)
        lblTotalAmount.TabIndex = 8
        lblTotalAmount.Text = "Total Amount"
        ' 
        ' btnCalc
        ' 
        btnCalc.Location = New Point(481, 357)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(126, 46)
        btnCalc.TabIndex = 7
        btnCalc.Text = "Calculate"
        btnCalc.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.ForeColor = Color.Red
        btnExit.Location = New Point(636, 357)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(126, 46)
        btnExit.TabIndex = 8
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnExit)
        Controls.Add(btnCalc)
        Controls.Add(GroupBox1)
        Controls.Add(gbJacketList)
        Controls.Add(gbPayment)
        Controls.Add(gbJackets)
        Name = "Form1"
        Text = "Question 9"
        gbJackets.ResumeLayout(False)
        gbJackets.PerformLayout()
        gbPayment.ResumeLayout(False)
        gbPayment.PerformLayout()
        gbJacketList.ResumeLayout(False)
        gbJacketList.PerformLayout()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents gbJackets As GroupBox
    Friend WithEvents txtRedNum As TextBox
    Friend WithEvents txtNavyNum As TextBox
    Friend WithEvents txtBlackNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblBlackJacket As Label
    Friend WithEvents gbPayment As GroupBox
    Friend WithEvents rbEW As RadioButton
    Friend WithEvents rbOB As RadioButton
    Friend WithEvents rbCash As RadioButton
    Friend WithEvents rbCC As RadioButton
    Friend WithEvents gbJacketList As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblP1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents txtTotalJacket As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents lblTotalJacket As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotalAmount As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWarning As Label
    Friend WithEvents txtOriAmount As TextBox
    Friend WithEvents lblOriAmount As Label

End Class
