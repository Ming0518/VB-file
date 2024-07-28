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
        btnBook = New Button()
        txtNumCustomers = New TextBox()
        rbtnInternational = New RadioButton()
        RadioButton2 = New RadioButton()
        txtTotalPayment = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnBook
        ' 
        btnBook.Location = New Point(315, 220)
        btnBook.Name = "btnBook"
        btnBook.Size = New Size(94, 29)
        btnBook.TabIndex = 0
        btnBook.Text = "Book"
        btnBook.UseVisualStyleBackColor = True
        ' 
        ' txtNumCustomers
        ' 
        txtNumCustomers.Location = New Point(385, 110)
        txtNumCustomers.Name = "txtNumCustomers"
        txtNumCustomers.Size = New Size(213, 27)
        txtNumCustomers.TabIndex = 1
        ' 
        ' rbtnInternational
        ' 
        rbtnInternational.AutoSize = True
        rbtnInternational.Location = New Point(220, 178)
        rbtnInternational.Name = "rbtnInternational"
        rbtnInternational.Size = New Size(159, 24)
        rbtnInternational.TabIndex = 2
        rbtnInternational.TabStop = True
        rbtnInternational.Text = "International Movie"
        rbtnInternational.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(399, 178)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(110, 24)
        RadioButton2.TabIndex = 3
        RadioButton2.TabStop = True
        RadioButton2.Text = "Local movie"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' txtTotalPayment
        ' 
        txtTotalPayment.Location = New Point(350, 274)
        txtTotalPayment.Name = "txtTotalPayment"
        txtTotalPayment.Size = New Size(159, 27)
        txtTotalPayment.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(152, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(230, 20)
        Label1.TabIndex = 5
        Label1.Text = "Please enter number of customer:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 281)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 20)
        Label2.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(305, 38)
        Label3.Name = "Label3"
        Label3.Size = New Size(104, 20)
        Label3.TabIndex = 7
        Label3.Text = "Sintok Cinema"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(229, 281)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 20)
        Label4.TabIndex = 8
        Label4.Text = "Total Ticket Fee:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtTotalPayment)
        Controls.Add(RadioButton2)
        Controls.Add(rbtnInternational)
        Controls.Add(txtNumCustomers)
        Controls.Add(btnBook)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnBook As Button
    Friend WithEvents txtNumCustomers As TextBox
    Friend WithEvents rbtnInternational As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
