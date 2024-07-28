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
        Label2 = New Label()
        Button2 = New Button()
        txtFactor = New TextBox()
        Button1 = New Button()
        txtInput = New TextBox()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(323, 109)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 37)
        btnClear.TabIndex = 24
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(188, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(68, 20)
        Label2.TabIndex = 23
        Label2.Text = "Factorial:"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.Red
        Button2.ForeColor = Color.White
        Button2.Location = New Point(431, 217)
        Button2.Name = "Button2"
        Button2.Size = New Size(113, 49)
        Button2.TabIndex = 22
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' txtFactor
        ' 
        txtFactor.Location = New Point(275, 179)
        txtFactor.Name = "txtFactor"
        txtFactor.Size = New Size(125, 27)
        txtFactor.TabIndex = 21
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(188, 109)
        Button1.Name = "Button1"
        Button1.Size = New Size(99, 37)
        Button1.TabIndex = 20
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(275, 58)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(125, 27)
        txtInput.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(97, 61)
        Label1.Name = "Label1"
        Label1.Size = New Size(159, 20)
        Label1.TabIndex = 18
        Label1.Text = "Please enter a number:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(602, 297)
        Controls.Add(btnClear)
        Controls.Add(Label2)
        Controls.Add(Button2)
        Controls.Add(txtFactor)
        Controls.Add(Button1)
        Controls.Add(txtInput)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtFactor As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txtInput As TextBox
    Friend WithEvents Label1 As Label

End Class
