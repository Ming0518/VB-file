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
        btnConvert = New Button()
        btnExit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtSentences = New RichTextBox()
        txtLatin = New RichTextBox()
        btnClear = New Button()
        SuspendLayout()
        ' 
        ' btnConvert
        ' 
        btnConvert.Location = New Point(256, 211)
        btnConvert.Name = "btnConvert"
        btnConvert.Size = New Size(94, 29)
        btnConvert.TabIndex = 0
        btnConvert.Text = "Convert"
        btnConvert.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(646, 356)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(89, 40)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(74, 117)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 20)
        Label1.TabIndex = 2
        Label1.Text = "Please Enter A Sentences:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(312, 22)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 20)
        Label2.TabIndex = 4
        Label2.Text = "Pig Latin Convert"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(181, 318)
        Label3.Name = "Label3"
        Label3.Size = New Size(69, 20)
        Label3.TabIndex = 5
        Label3.Text = "Pig Latin:"
        ' 
        ' txtSentences
        ' 
        txtSentences.Location = New Point(256, 88)
        txtSentences.Name = "txtSentences"
        txtSentences.Size = New Size(291, 91)
        txtSentences.TabIndex = 6
        txtSentences.Text = ""
        ' 
        ' txtLatin
        ' 
        txtLatin.Location = New Point(256, 280)
        txtLatin.Name = "txtLatin"
        txtLatin.ReadOnly = True
        txtLatin.Size = New Size(291, 91)
        txtLatin.TabIndex = 7
        txtLatin.Text = ""
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(411, 211)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 8
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(768, 445)
        Controls.Add(btnClear)
        Controls.Add(txtLatin)
        Controls.Add(txtSentences)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnConvert)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSentences As RichTextBox
    Friend WithEvents txtLatin As RichTextBox
    Friend WithEvents btnClear As Button

End Class
