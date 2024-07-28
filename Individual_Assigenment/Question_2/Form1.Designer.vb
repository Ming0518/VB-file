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
        txtDescription = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        txtYear = New TextBox()
        txtCost = New Label()
        txtCosts = New TextBox()
        Label4 = New Label()
        txtLife = New TextBox()
        dgvData = New DataGridView()
        GroupBox1 = New GroupBox()
        rbDouble = New RadioButton()
        rbStaright = New RadioButton()
        btnGenerate = New Button()
        btnClear = New Button()
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(217, 44)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(125, 27)
        txtDescription.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(113, 47)
        Label1.Name = "Label1"
        Label1.Size = New Size(88, 20)
        Label1.TabIndex = 2
        Label1.Text = "Description:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(80, 111)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 20)
        Label2.TabIndex = 4
        Label2.Text = "Year of purchase:"
        ' 
        ' txtYear
        ' 
        txtYear.Location = New Point(217, 104)
        txtYear.Name = "txtYear"
        txtYear.Size = New Size(125, 27)
        txtYear.TabIndex = 3
        ' 
        ' txtCost
        ' 
        txtCost.AutoSize = True
        txtCost.Location = New Point(161, 162)
        txtCost.Name = "txtCost"
        txtCost.Size = New Size(41, 20)
        txtCost.TabIndex = 6
        txtCost.Text = "Cost:"
        ' 
        ' txtCosts
        ' 
        txtCosts.Location = New Point(217, 162)
        txtCosts.Name = "txtCosts"
        txtCosts.Size = New Size(125, 27)
        txtCosts.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(99, 222)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 20)
        Label4.TabIndex = 8
        Label4.Text = "Estimated life:"
        ' 
        ' txtLife
        ' 
        txtLife.Location = New Point(217, 219)
        txtLife.Name = "txtLife"
        txtLife.Size = New Size(125, 27)
        txtLife.TabIndex = 7
        ' 
        ' dgvData
        ' 
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(403, 26)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 51
        dgvData.RowTemplate.Height = 29
        dgvData.Size = New Size(580, 449)
        dgvData.TabIndex = 9
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(rbDouble)
        GroupBox1.Controls.Add(rbStaright)
        GroupBox1.Location = New Point(80, 272)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(274, 164)
        GroupBox1.TabIndex = 10
        GroupBox1.TabStop = False
        GroupBox1.Text = "Methods:"
        ' 
        ' rbDouble
        ' 
        rbDouble.AutoSize = True
        rbDouble.Location = New Point(50, 91)
        rbDouble.Name = "rbDouble"
        rbDouble.Size = New Size(202, 24)
        rbDouble.TabIndex = 1
        rbDouble.TabStop = True
        rbDouble.Text = "Double-declining balance"
        rbDouble.UseVisualStyleBackColor = True
        ' 
        ' rbStaright
        ' 
        rbStaright.AutoSize = True
        rbStaright.Location = New Point(47, 48)
        rbStaright.Name = "rbStaright"
        rbStaright.Size = New Size(112, 24)
        rbStaright.TabIndex = 0
        rbStaright.TabStop = True
        rbStaright.Text = "Straight-line"
        rbStaright.UseVisualStyleBackColor = True
        ' 
        ' btnGenerate
        ' 
        btnGenerate.Location = New Point(80, 458)
        btnGenerate.Name = "btnGenerate"
        btnGenerate.Size = New Size(122, 37)
        btnGenerate.TabIndex = 11
        btnGenerate.Text = "Generate"
        btnGenerate.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(220, 458)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(122, 37)
        btnClear.TabIndex = 12
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1018, 517)
        Controls.Add(btnClear)
        Controls.Add(btnGenerate)
        Controls.Add(GroupBox1)
        Controls.Add(dgvData)
        Controls.Add(Label4)
        Controls.Add(txtLife)
        Controls.Add(txtCost)
        Controls.Add(txtCosts)
        Controls.Add(Label2)
        Controls.Add(txtYear)
        Controls.Add(Label1)
        Controls.Add(txtDescription)
        Name = "Form1"
        Text = "Form1"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtCost As Label
    Friend WithEvents txtCosts As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLife As TextBox
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbDouble As RadioButton
    Friend WithEvents rbStaright As RadioButton
    Friend WithEvents btnGenerate As Button
    Friend WithEvents btnClear As Button

End Class
