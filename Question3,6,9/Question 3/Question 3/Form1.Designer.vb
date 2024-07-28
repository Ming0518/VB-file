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
        gbOrderDetails = New GroupBox()
        txtSFC = New TextBox()
        txtOrder = New TextBox()
        lblFSCode = New Label()
        Label1 = New Label()
        gbTotalOrder = New GroupBox()
        txtSF = New TextBox()
        txtOA = New TextBox()
        lblOrderAmount = New Label()
        lblSF = New Label()
        btnCalc = New Button()
        btnExit = New Button()
        lblWarning = New Label()
        gbOrderDetails.SuspendLayout()
        gbTotalOrder.SuspendLayout()
        SuspendLayout()
        ' 
        ' gbOrderDetails
        ' 
        gbOrderDetails.Controls.Add(txtSFC)
        gbOrderDetails.Controls.Add(txtOrder)
        gbOrderDetails.Controls.Add(lblFSCode)
        gbOrderDetails.Controls.Add(Label1)
        gbOrderDetails.Location = New Point(49, 39)
        gbOrderDetails.Name = "gbOrderDetails"
        gbOrderDetails.Size = New Size(389, 125)
        gbOrderDetails.TabIndex = 0
        gbOrderDetails.TabStop = False
        gbOrderDetails.Text = "Order Details"
        ' 
        ' txtSFC
        ' 
        txtSFC.Location = New Point(206, 77)
        txtSFC.Name = "txtSFC"
        txtSFC.Size = New Size(125, 27)
        txtSFC.TabIndex = 3
        txtSFC.Visible = False
        ' 
        ' txtOrder
        ' 
        txtOrder.Location = New Point(206, 42)
        txtOrder.Name = "txtOrder"
        txtOrder.Size = New Size(125, 27)
        txtOrder.TabIndex = 2
        ' 
        ' lblFSCode
        ' 
        lblFSCode.AutoSize = True
        lblFSCode.Location = New Point(35, 80)
        lblFSCode.Name = "lblFSCode"
        lblFSCode.Size = New Size(139, 20)
        lblFSCode.TabIndex = 1
        lblFSCode.Text = "Free Shipping Code"
        lblFSCode.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 0
        Label1.Text = "Order:"
        ' 
        ' gbTotalOrder
        ' 
        gbTotalOrder.Controls.Add(txtSF)
        gbTotalOrder.Controls.Add(txtOA)
        gbTotalOrder.Controls.Add(lblOrderAmount)
        gbTotalOrder.Controls.Add(lblSF)
        gbTotalOrder.Location = New Point(49, 189)
        gbTotalOrder.Name = "gbTotalOrder"
        gbTotalOrder.Size = New Size(389, 125)
        gbTotalOrder.TabIndex = 1
        gbTotalOrder.TabStop = False
        gbTotalOrder.Text = "Order Amount"
        ' 
        ' txtSF
        ' 
        txtSF.Enabled = False
        txtSF.Location = New Point(206, 33)
        txtSF.Name = "txtSF"
        txtSF.Size = New Size(125, 27)
        txtSF.TabIndex = 4
        ' 
        ' txtOA
        ' 
        txtOA.Enabled = False
        txtOA.Location = New Point(206, 66)
        txtOA.Name = "txtOA"
        txtOA.Size = New Size(125, 27)
        txtOA.TabIndex = 5
        ' 
        ' lblOrderAmount
        ' 
        lblOrderAmount.AutoSize = True
        lblOrderAmount.Location = New Point(35, 66)
        lblOrderAmount.Name = "lblOrderAmount"
        lblOrderAmount.Size = New Size(104, 20)
        lblOrderAmount.TabIndex = 3
        lblOrderAmount.Text = "Order Amount"
        ' 
        ' lblSF
        ' 
        lblSF.AutoSize = True
        lblSF.Location = New Point(35, 34)
        lblSF.Name = "lblSF"
        lblSF.Size = New Size(95, 20)
        lblSF.TabIndex = 2
        lblSF.Text = "Shipping Fee"
        ' 
        ' btnCalc
        ' 
        btnCalc.Location = New Point(468, 78)
        btnCalc.Name = "btnCalc"
        btnCalc.Size = New Size(94, 29)
        btnCalc.TabIndex = 2
        btnCalc.Text = "Calculate"
        btnCalc.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.ForeColor = Color.Red
        btnExit.Location = New Point(468, 119)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 29)
        btnExit.TabIndex = 3
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblWarning
        ' 
        lblWarning.AutoSize = True
        lblWarning.ForeColor = Color.Red
        lblWarning.Location = New Point(64, 163)
        lblWarning.Name = "lblWarning"
        lblWarning.Size = New Size(0, 20)
        lblWarning.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(629, 450)
        Controls.Add(lblWarning)
        Controls.Add(btnExit)
        Controls.Add(btnCalc)
        Controls.Add(gbTotalOrder)
        Controls.Add(gbOrderDetails)
        Name = "Form1"
        Text = "Question 3"
        gbOrderDetails.ResumeLayout(False)
        gbOrderDetails.PerformLayout()
        gbTotalOrder.ResumeLayout(False)
        gbTotalOrder.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents gbOrderDetails As GroupBox
    Friend WithEvents lblFSCode As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents gbTotalOrder As GroupBox
    Friend WithEvents lblOrderAmount As Label
    Friend WithEvents lblSF As Label
    Friend WithEvents txtOrder As TextBox
    Friend WithEvents txtSF As TextBox
    Friend WithEvents txtOA As TextBox
    Friend WithEvents txtSFC As TextBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblWarning As Label

End Class
