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
        Label1 = New Label()
        txtSales = New TextBox()
        gbWork = New GroupBox()
        rbLess = New RadioButton()
        rbOver = New RadioButton()
        gbTravel = New GroupBox()
        rbFalse = New RadioButton()
        rbTrue = New RadioButton()
        btnCalculate = New Button()
        txtCommission = New TextBox()
        Label2 = New Label()
        txtAdditional = New TextBox()
        Label3 = New Label()
        txtTotal = New TextBox()
        Label4 = New Label()
        btnExit = New Button()
        btnClear = New Button()
        txtTest = New TextBox()
        Label5 = New Label()
        btnTest = New Button()
        txtRes = New TextBox()
        btnWriteToFile = New Button()
        ListBox1 = New ListBox()
        dgvRecord = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Button2 = New Button()
        CheckedListBox1 = New CheckedListBox()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        ComboBox1 = New ComboBox()
        gbWork.SuspendLayout()
        gbTravel.SuspendLayout()
        CType(dgvRecord, ComponentModel.ISupportInitialize).BeginInit()
        TabControl1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(240, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(84, 20)
        Label1.TabIndex = 0
        Label1.Text = "Enter Sales:"
        ' 
        ' txtSales
        ' 
        txtSales.Location = New Point(343, 47)
        txtSales.Name = "txtSales"
        txtSales.Size = New Size(125, 27)
        txtSales.TabIndex = 1
        ' 
        ' gbWork
        ' 
        gbWork.Controls.Add(rbLess)
        gbWork.Controls.Add(rbOver)
        gbWork.Location = New Point(83, 95)
        gbWork.Name = "gbWork"
        gbWork.Size = New Size(250, 125)
        gbWork.TabIndex = 2
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
        ' gbTravel
        ' 
        gbTravel.Controls.Add(rbFalse)
        gbTravel.Controls.Add(rbTrue)
        gbTravel.Location = New Point(404, 95)
        gbTravel.Name = "gbTravel"
        gbTravel.Size = New Size(250, 125)
        gbTravel.TabIndex = 3
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
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(257, 248)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(94, 29)
        btnCalculate.TabIndex = 4
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' txtCommission
        ' 
        txtCommission.Location = New Point(363, 301)
        txtCommission.Name = "txtCommission"
        txtCommission.Size = New Size(125, 27)
        txtCommission.TabIndex = 6
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(240, 308)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 20)
        Label2.TabIndex = 5
        Label2.Text = "Commission:"
        ' 
        ' txtAdditional
        ' 
        txtAdditional.Location = New Point(363, 343)
        txtAdditional.Name = "txtAdditional"
        txtAdditional.Size = New Size(125, 27)
        txtAdditional.TabIndex = 8
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(194, 350)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 20)
        Label3.TabIndex = 7
        Label3.Text = "Additional Amount:"
        ' 
        ' txtTotal
        ' 
        txtTotal.Location = New Point(363, 385)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(125, 27)
        txtTotal.TabIndex = 10
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(257, 388)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 20)
        Label4.TabIndex = 9
        Label4.Text = "Total Due:"
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Red
        btnExit.ForeColor = SystemColors.ButtonHighlight
        btnExit.Location = New Point(578, 385)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(94, 50)
        btnExit.TabIndex = 11
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(374, 248)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(94, 29)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' txtTest
        ' 
        txtTest.Location = New Point(858, 234)
        txtTest.Name = "txtTest"
        txtTest.Size = New Size(125, 27)
        txtTest.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(755, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 20)
        Label5.TabIndex = 13
        Label5.Text = "Enter Sales:"
        ' 
        ' btnTest
        ' 
        btnTest.Location = New Point(779, 299)
        btnTest.Name = "btnTest"
        btnTest.Size = New Size(94, 29)
        btnTest.TabIndex = 15
        btnTest.Text = "Calculate"
        btnTest.UseVisualStyleBackColor = True
        ' 
        ' txtRes
        ' 
        txtRes.Location = New Point(858, 365)
        txtRes.Name = "txtRes"
        txtRes.Size = New Size(125, 27)
        txtRes.TabIndex = 16
        ' 
        ' btnWriteToFile
        ' 
        btnWriteToFile.Location = New Point(587, 248)
        btnWriteToFile.Name = "btnWriteToFile"
        btnWriteToFile.Size = New Size(94, 29)
        btnWriteToFile.TabIndex = 17
        btnWriteToFile.Text = "Calculate"
        btnWriteToFile.UseVisualStyleBackColor = True
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.Location = New Point(671, -1)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(331, 104)
        ListBox1.TabIndex = 18
        ' 
        ' dgvRecord
        ' 
        dgvRecord.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvRecord.Columns.AddRange(New DataGridViewColumn() {Column1})
        dgvRecord.Location = New Point(745, 132)
        dgvRecord.Name = "dgvRecord"
        dgvRecord.RowHeadersWidth = 51
        dgvRecord.Size = New Size(290, 88)
        dgvRecord.TabIndex = 19
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Column1"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(889, 299)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 20
        Button1.Text = "Calculate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(721, 379)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 21
        Button2.Text = "Calculate"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(43, 286)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(150, 114)
        CheckedListBox1.TabIndex = 22
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(59, 47)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(268, 135)
        TabControl1.TabIndex = 23
        ' 
        ' TabPage1
        ' 
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(260, 102)
        TabPage1.TabIndex = 0
        TabPage1.Text = "TabPage1"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(260, 102)
        TabPage2.TabIndex = 1
        TabPage2.Text = "TabPage2"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(39, 216)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 24
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1148, 500)
        Controls.Add(ComboBox1)
        Controls.Add(TabControl1)
        Controls.Add(CheckedListBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(dgvRecord)
        Controls.Add(ListBox1)
        Controls.Add(btnWriteToFile)
        Controls.Add(txtRes)
        Controls.Add(btnTest)
        Controls.Add(txtTest)
        Controls.Add(Label5)
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
        Text = "Question7"
        gbWork.ResumeLayout(False)
        gbWork.PerformLayout()
        gbTravel.ResumeLayout(False)
        gbTravel.PerformLayout()
        CType(dgvRecord, ComponentModel.ISupportInitialize).EndInit()
        TabControl1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSales As TextBox
    Friend WithEvents gbWork As GroupBox
    Friend WithEvents gbTravel As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtCommission As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAdditional As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents rbLess As RadioButton
    Friend WithEvents rbOver As RadioButton
    Friend WithEvents rbFalse As RadioButton
    Friend WithEvents rbTrue As RadioButton
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txtTest As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnTest As Button
    Friend WithEvents txtRes As TextBox
    Friend WithEvents btnWriteToFile As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents dgvRecord As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ComboBox1 As ComboBox

End Class
