<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Button1 = New Button()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox3 = New TextBox()
        Label4 = New Label()
        TextBox4 = New TextBox()
        Label5 = New Label()
        TextBox5 = New TextBox()
        Label6 = New Label()
        DataGridView1 = New DataGridView()
        CarType = New DataGridViewTextBoxColumn()
        PlateNum = New DataGridViewTextBoxColumn()
        DateRent = New DataGridViewTextBoxColumn()
        RentDay = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(396, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(331, 62)
        Label1.TabIndex = 5
        Label1.Text = "Edit Car Rental"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(578, 380)
        Button1.Name = "Button1"
        Button1.Size = New Size(179, 52)
        Button1.TabIndex = 4
        Button1.Text = "Home Page"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(74, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 20)
        Label2.TabIndex = 6
        Label2.Text = "Car Type:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Enabled = False
        TextBox1.Location = New Point(164, 132)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(146, 382)
        Button2.Name = "Button2"
        Button2.Size = New Size(143, 48)
        Button2.TabIndex = 8
        Button2.Text = "Save"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Enabled = False
        TextBox2.Location = New Point(164, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(125, 27)
        TextBox2.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(99, 225)
        Label3.Name = "Label3"
        Label3.Size = New Size(44, 20)
        Label3.TabIndex = 9
        Label3.Text = "Date:"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(164, 218)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(40, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(103, 20)
        Label4.TabIndex = 11
        Label4.Text = "Plate Number:"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(164, 256)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(125, 27)
        TextBox4.TabIndex = 14
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(32, 263)
        Label5.Name = "Label5"
        Label5.Size = New Size(111, 20)
        Label5.TabIndex = 13
        Label5.Text = "Rent Day/Hour:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Enabled = False
        TextBox5.Location = New Point(164, 300)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(125, 27)
        TextBox5.TabIndex = 16
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(99, 303)
        Label6.Name = "Label6"
        Label6.Size = New Size(44, 20)
        Label6.TabIndex = 15
        Label6.Text = "Price:"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CarType, PlateNum, DateRent, RentDay, Price})
        DataGridView1.Location = New Point(346, 114)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(678, 213)
        DataGridView1.TabIndex = 17
        ' 
        ' CarType
        ' 
        CarType.HeaderText = "Car Type"
        CarType.MinimumWidth = 6
        CarType.Name = "CarType"
        CarType.Width = 125
        ' 
        ' PlateNum
        ' 
        PlateNum.HeaderText = "Plate Number"
        PlateNum.MinimumWidth = 6
        PlateNum.Name = "PlateNum"
        PlateNum.Width = 125
        ' 
        ' DateRent
        ' 
        DateRent.HeaderText = "Date Of Rent"
        DateRent.MinimumWidth = 6
        DateRent.Name = "DateRent"
        DateRent.Width = 125
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
        Price.HeaderText = "Price"
        Price.MinimumWidth = 6
        Price.Name = "Price"
        Price.Width = 125
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(1078, 476)
        Controls.Add(DataGridView1)
        Controls.Add(TextBox5)
        Controls.Add(Label6)
        Controls.Add(TextBox4)
        Controls.Add(Label5)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form2"
        Text = "Edit"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CarType As DataGridViewTextBoxColumn
    Friend WithEvents PlateNum As DataGridViewTextBoxColumn
    Friend WithEvents DateRent As DataGridViewTextBoxColumn
    Friend WithEvents RentDay As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
End Class
