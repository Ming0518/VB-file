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
        DataGridView1 = New DataGridView()
        CarType = New DataGridViewTextBoxColumn()
        DateRent = New DataGridViewTextBoxColumn()
        PlateNum = New DataGridViewTextBoxColumn()
        RentDay = New DataGridViewTextBoxColumn()
        Price = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        Label1 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = SystemColors.GradientInactiveCaption
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {CarType, DateRent, PlateNum, RentDay, Price})
        DataGridView1.Location = New Point(58, 95)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(678, 213)
        DataGridView1.TabIndex = 0
        ' 
        ' CarType
        ' 
        CarType.HeaderText = "Car Type"
        CarType.MinimumWidth = 6
        CarType.Name = "CarType"
        CarType.Width = 125
        ' 
        ' DateRent
        ' 
        DateRent.HeaderText = "Date Of Rent"
        DateRent.MinimumWidth = 6
        DateRent.Name = "DateRent"
        DateRent.Width = 125
        ' 
        ' PlateNum
        ' 
        PlateNum.HeaderText = "Plate Number"
        PlateNum.MinimumWidth = 6
        PlateNum.Name = "PlateNum"
        PlateNum.Width = 125
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
        ' Button1
        ' 
        Button1.Location = New Point(303, 356)
        Button1.Name = "Button1"
        Button1.Size = New Size(181, 54)
        Button1.TabIndex = 1
        Button1.Text = "Home Page"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(193, -2)
        Label1.Name = "Label1"
        Label1.Size = New Size(399, 62)
        Label1.TabIndex = 2
        Label1.Text = "History Car Rental"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.InactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "Form1"
        Text = "History"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CarType As DataGridViewTextBoxColumn
    Friend WithEvents DateRent As DataGridViewTextBoxColumn
    Friend WithEvents PlateNum As DataGridViewTextBoxColumn
    Friend WithEvents RentDay As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn

End Class
