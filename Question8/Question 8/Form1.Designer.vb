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
        btnCalculate = New Button()
        txtUnitsOrdered = New TextBox()
        rbtnWholesaler = New RadioButton()
        rbtnRetailer = New RadioButton()
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtResult = New RichTextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(260, 256)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(135, 44)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtUnitsOrdered
        ' 
        txtUnitsOrdered.Location = New Point(316, 209)
        txtUnitsOrdered.Name = "txtUnitsOrdered"
        txtUnitsOrdered.Size = New Size(213, 27)
        txtUnitsOrdered.TabIndex = 1
        ' 
        ' rbtnWholesaler
        ' 
        rbtnWholesaler.AutoSize = True
        rbtnWholesaler.Location = New Point(39, 51)
        rbtnWholesaler.Name = "rbtnWholesaler"
        rbtnWholesaler.Size = New Size(104, 24)
        rbtnWholesaler.TabIndex = 2
        rbtnWholesaler.TabStop = True
        rbtnWholesaler.Text = "Wholesaler"
        rbtnWholesaler.UseVisualStyleBackColor = True
        ' 
        ' rbtnRetailer
        ' 
        rbtnRetailer.AutoSize = True
        rbtnRetailer.Location = New Point(219, 51)
        rbtnRetailer.Name = "rbtnRetailer"
        rbtnRetailer.Size = New Size(81, 24)
        rbtnRetailer.TabIndex = 3
        rbtnRetailer.TabStop = True
        rbtnRetailer.Text = "Retailer"
        rbtnRetailer.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbtnRetailer)
        GroupBox1.Controls.Add(rbtnWholesaler)
        GroupBox1.Location = New Point(170, 85)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(325, 107)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Please select your status"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(104, 209)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 20)
        Label1.TabIndex = 5
        Label1.Text = "Please insert number of units: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(140, 319)
        Label2.Name = "Label2"
        Label2.Size = New Size(82, 20)
        Label2.TabIndex = 7
        Label2.Text = "Total price:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Stencil", 36F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(198, 11)
        Label3.Name = "Label3"
        Label3.Size = New Size(318, 71)
        Label3.TabIndex = 8
        Label3.Text = "Ainin Inc"
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(228, 328)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(238, 120)
        txtResult.TabIndex = 9
        txtResult.Text = ""
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(681, 450)
        Controls.Add(txtResult)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Controls.Add(txtUnitsOrdered)
        Controls.Add(btnCalculate)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtUnitsOrdered As TextBox
    Friend WithEvents rbtnWholesaler As RadioButton
    Friend WithEvents rbtnRetailer As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtResult As RichTextBox
End Class
