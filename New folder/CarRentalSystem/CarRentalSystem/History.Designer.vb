<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Label18 = New Label()
        btnAddCar = New Button()
        btnExit = New Button()
        DataGridView1 = New DataGridView()
        CarType = New DataGridViewTextBoxColumn()
        DateRent = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        RentDay = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        PlateNum = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(290, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 44)
        Label1.TabIndex = 28
        Label1.Text = "Car Rental System"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(419, 80)
        Label18.Name = "Label18"
        Label18.Size = New Size(142, 33)
        Label18.TabIndex = 57
        Label18.Text = "History"
        ' 
        ' btnAddCar
        ' 
        btnAddCar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddCar.Location = New Point(252, 354)
        btnAddCar.Name = "btnAddCar"
        btnAddCar.Size = New Size(188, 57)
        btnAddCar.TabIndex = 58
        btnAddCar.Text = "Edit History"
        btnAddCar.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(535, 354)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(188, 57)
        btnExit.TabIndex = 59
        btnExit.Text = "Back"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.ButtonFace
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CarType, DateRent, Column1, RentDay, Price, PlateNum, Column2})
        DataGridView1.GridColor = SystemColors.ActiveBorder
        DataGridView1.Location = New Point(26, 116)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(929, 213)
        DataGridView1.TabIndex = 29
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
        ' History
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(967, 470)
        Controls.Add(btnExit)
        Controls.Add(btnAddCar)
        Controls.Add(Label18)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Name = "History"
        Text = "History"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CarType As DataGridViewTextBoxColumn
    Friend WithEvents DateRent As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents RentDay As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents PlateNum As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
End Class
