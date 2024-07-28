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
        txtFee = New TextBox()
        Label1 = New Label()
        RBNormalCar = New RadioButton()
        RBLuxuryCar = New RadioButton()
        GroupBox1 = New GroupBox()
        gbCoupon = New GroupBox()
        RBYes = New RadioButton()
        RBNo = New RadioButton()
        Label2 = New Label()
        Label3 = New Label()
        btnCalculate = New Button()
        GroupBox1.SuspendLayout()
        gbCoupon.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtFee
        ' 
        txtFee.Location = New Point(125, 339)
        txtFee.Name = "txtFee"
        txtFee.Size = New Size(184, 27)
        txtFee.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(161, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 20)
        Label1.TabIndex = 1
        Label1.Text = "Car Rental System"
        ' 
        ' RBNormalCar
        ' 
        RBNormalCar.AutoSize = True
        RBNormalCar.Location = New Point(54, 36)
        RBNormalCar.Name = "RBNormalCar"
        RBNormalCar.Size = New Size(106, 24)
        RBNormalCar.TabIndex = 2
        RBNormalCar.TabStop = True
        RBNormalCar.Text = "Normal Car"
        RBNormalCar.UseVisualStyleBackColor = True
        ' 
        ' RBLuxuryCar
        ' 
        RBLuxuryCar.AutoSize = True
        RBLuxuryCar.Location = New Point(243, 36)
        RBLuxuryCar.Name = "RBLuxuryCar"
        RBLuxuryCar.Size = New Size(98, 24)
        RBLuxuryCar.TabIndex = 3
        RBLuxuryCar.TabStop = True
        RBLuxuryCar.Text = "Luxury Car"
        RBLuxuryCar.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(RBNormalCar)
        GroupBox1.Controls.Add(RBLuxuryCar)
        GroupBox1.Location = New Point(34, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(395, 97)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Please select rental type"
        ' 
        ' gbCoupon
        ' 
        gbCoupon.Controls.Add(RBYes)
        gbCoupon.Controls.Add(RBNo)
        gbCoupon.Location = New Point(34, 196)
        gbCoupon.Name = "gbCoupon"
        gbCoupon.Size = New Size(395, 97)
        gbCoupon.TabIndex = 5
        gbCoupon.TabStop = False
        gbCoupon.Text = "Do you luxury coupon?"
        ' 
        ' RBYes
        ' 
        RBYes.AutoSize = True
        RBYes.Location = New Point(54, 36)
        RBYes.Name = "RBYes"
        RBYes.Size = New Size(51, 24)
        RBYes.TabIndex = 2
        RBYes.TabStop = True
        RBYes.Text = "Yes"
        RBYes.UseVisualStyleBackColor = True
        ' 
        ' RBNo
        ' 
        RBNo.AutoSize = True
        RBNo.Location = New Point(243, 36)
        RBNo.Name = "RBNo"
        RBNo.Size = New Size(50, 24)
        RBNo.TabIndex = 3
        RBNo.TabStop = True
        RBNo.Text = "No"
        RBNo.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(172, 215)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(41, 342)
        Label3.Name = "Label3"
        Label3.Size = New Size(78, 20)
        Label3.TabIndex = 7
        Label3.Text = "Rental Fee"
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(315, 337)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 450)
        Controls.Add(btnCalculate)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(gbCoupon)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Controls.Add(txtFee)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        gbCoupon.ResumeLayout(False)
        gbCoupon.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtFee As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RBNormalCar As RadioButton
    Friend WithEvents RBLuxuryCar As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents gbCoupon As GroupBox
    Friend WithEvents RBYes As RadioButton
    Friend WithEvents RBNo As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
End Class
