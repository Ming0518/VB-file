<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label18 = New Label()
        TextBox6 = New TextBox()
        Label7 = New Label()
        Label8 = New Label()
        RichTextBox1 = New RichTextBox()
        DataGridView1 = New DataGridView()
        CarType = New DataGridViewTextBoxColumn()
        DateRent = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        RentDay = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        PlateNum = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        btnAddCar = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(468, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 44)
        Label1.TabIndex = 28
        Label1.Text = "Car Rental System"
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Location = New Point(161, 118)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(173, 27)
        TextBox5.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(96, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 37
        Label6.Text = "Price:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(161, 243)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(173, 27)
        TextBox4.TabIndex = 36
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(37, 250)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 20)
        Label5.TabIndex = 35
        Label5.Text = "Rent Day/Hour:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(161, 205)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(173, 27)
        TextBox3.TabIndex = 34
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(51, 168)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 33
        Label4.Text = "Pick Up Date:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(161, 161)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(173, 27)
        TextBox2.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(51, 212)
        Label3.Name = "Label3"
        Label3.Size = New Size(98, 20)
        Label3.TabIndex = 31
        Label3.Text = "Pick Up Time:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(161, 76)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(173, 27)
        TextBox1.TabIndex = 30
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(71, 83)
        Label2.Name = "Label2"
        Label2.Size = New Size(78, 20)
        Label2.TabIndex = 29
        Label2.Text = "Car Name:"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(784, 94)
        Label18.Name = "Label18"
        Label18.Size = New Size(216, 33)
        Label18.TabIndex = 55
        Label18.Text = "Edit History"
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(161, 285)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(173, 27)
        TextBox6.TabIndex = 59
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(70, 292)
        Label7.Name = "Label7"
        Label7.Size = New Size(78, 20)
        Label7.TabIndex = 58
        Label7.Text = "Date Rent:"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(57, 338)
        Label8.Name = "Label8"
        Label8.Size = New Size(98, 20)
        Label8.TabIndex = 60
        Label8.Text = "Rental Detail:"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(161, 338)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(173, 79)
        RichTextBox1.TabIndex = 62
        RichTextBox1.Text = ""
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CarType, DateRent, Column1, RentDay, Price, PlateNum, Column2})
        DataGridView1.GridColor = SystemColors.ActiveBorder
        DataGridView1.Location = New Point(348, 145)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(929, 213)
        DataGridView1.TabIndex = 63
        ' 
        ' CarType
        ' 
        CarType.HeaderText = "Car Name"
        CarType.MinimumWidth = 6
        CarType.Name = "CarType"
        CarType.Width = 125
        ' 
        ' DateRent
        ' 
        DateRent.HeaderText = "Pick Up Date"
        DateRent.MinimumWidth = 6
        DateRent.Name = "DateRent"
        DateRent.Width = 125
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "Pick Up Time"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' RentDay
        ' 
        RentDay.HeaderText = "Rent Day/Hour"
        RentDay.MinimumWidth = 6
        RentDay.Name = "RentDay"
        RentDay.Width = 125
        ' 
        ' Price
        ' 
        Price.HeaderText = "Date Rent"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        Price.Width = 125
        ' 
        ' PlateNum
        ' 
        PlateNum.HeaderText = "Price"
        PlateNum.MinimumWidth = 6
        PlateNum.Name = "PlateNum"
        PlateNum.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Rental Detail"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' btnAddCar
        ' 
        btnAddCar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddCar.Location = New Point(963, 376)
        btnAddCar.Name = "btnAddCar"
        btnAddCar.Size = New Size(188, 57)
        btnAddCar.TabIndex = 64
        btnAddCar.Text = "Back"
        btnAddCar.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(545, 376)
        Button3.Name = "Button3"
        Button3.Size = New Size(188, 57)
        Button3.TabIndex = 65
        Button3.Text = "Save"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button4.Location = New Point(753, 376)
        Button4.Name = "Button4"
        Button4.Size = New Size(188, 57)
        Button4.TabIndex = 66
        Button4.Text = "Delete"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' EditHistory
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1284, 465)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(btnAddCar)
        Controls.Add(DataGridView1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label8)
        Controls.Add(TextBox6)
        Controls.Add(Label7)
        Controls.Add(Label18)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "EditHistory"
        Text = "Edit"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CarType As DataGridViewTextBoxColumn
    Friend WithEvents DateRent As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents RentDay As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents PlateNum As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddCar As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
