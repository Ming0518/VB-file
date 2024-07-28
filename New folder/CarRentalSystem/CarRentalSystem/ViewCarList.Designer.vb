<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCarList
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
        Panel1 = New Panel()
        btnRemoveCar = New Button()
        btnEditCar = New Button()
        btnViewRental = New Button()
        btnAddRental = New Button()
        btnViewCar = New Button()
        btnExit = New Button()
        btnAddCar = New Button()
        lblCarList = New Label()
        Label1 = New Label()
        ListView1 = New ListView()
        carID = New ColumnHeader()
        carImage = New ColumnHeader()
        carName = New ColumnHeader()
        carSeat = New ColumnHeader()
        carCC = New ColumnHeader()
        carGear = New ColumnHeader()
        rentalPrice = New ColumnHeader()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(btnRemoveCar)
        Panel1.Controls.Add(btnEditCar)
        Panel1.Controls.Add(btnViewRental)
        Panel1.Controls.Add(btnAddRental)
        Panel1.Controls.Add(btnViewCar)
        Panel1.Controls.Add(btnExit)
        Panel1.Controls.Add(btnAddCar)
        Panel1.Dock = DockStyle.Right
        Panel1.Location = New Point(782, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(218, 572)
        Panel1.TabIndex = 0
        ' 
        ' btnRemoveCar
        ' 
        btnRemoveCar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnRemoveCar.Location = New Point(18, 209)
        btnRemoveCar.Name = "btnRemoveCar"
        btnRemoveCar.Size = New Size(188, 57)
        btnRemoveCar.TabIndex = 13
        btnRemoveCar.Text = "Remove Car"
        btnRemoveCar.UseVisualStyleBackColor = True
        ' 
        ' btnEditCar
        ' 
        btnEditCar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnEditCar.Location = New Point(18, 146)
        btnEditCar.Name = "btnEditCar"
        btnEditCar.Size = New Size(188, 57)
        btnEditCar.TabIndex = 12
        btnEditCar.Text = "Update Car"
        btnEditCar.UseVisualStyleBackColor = True
        ' 
        ' btnViewRental
        ' 
        btnViewRental.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnViewRental.Location = New Point(18, 388)
        btnViewRental.Name = "btnViewRental"
        btnViewRental.Size = New Size(188, 57)
        btnViewRental.TabIndex = 11
        btnViewRental.Text = "View Rental"
        btnViewRental.UseVisualStyleBackColor = True
        ' 
        ' btnAddRental
        ' 
        btnAddRental.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddRental.Location = New Point(18, 325)
        btnAddRental.Name = "btnAddRental"
        btnAddRental.Size = New Size(188, 57)
        btnAddRental.TabIndex = 10
        btnAddRental.Text = "Add Rental"
        btnAddRental.UseVisualStyleBackColor = True
        ' 
        ' btnViewCar
        ' 
        btnViewCar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnViewCar.Location = New Point(18, 83)
        btnViewCar.Name = "btnViewCar"
        btnViewCar.Size = New Size(188, 57)
        btnViewCar.TabIndex = 9
        btnViewCar.Text = "View Car"
        btnViewCar.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.Black
        btnExit.Location = New Point(18, 506)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(188, 57)
        btnExit.TabIndex = 8
        btnExit.Text = "Back"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnAddCar
        ' 
        btnAddCar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnAddCar.Location = New Point(18, 20)
        btnAddCar.Name = "btnAddCar"
        btnAddCar.Size = New Size(188, 57)
        btnAddCar.TabIndex = 7
        btnAddCar.Text = "Add Car"
        btnAddCar.UseVisualStyleBackColor = True
        ' 
        ' lblCarList
        ' 
        lblCarList.AutoSize = True
        lblCarList.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblCarList.Location = New Point(12, 55)
        lblCarList.Name = "lblCarList"
        lblCarList.Size = New Size(207, 44)
        lblCarList.TabIndex = 26
        lblCarList.Text = "Car Lists"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(225, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 44)
        Label1.TabIndex = 27
        Label1.Text = "Car Rental System"
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {carID, carImage, carName, carSeat, carCC, carGear, rentalPrice})
        ListView1.Location = New Point(12, 104)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(744, 428)
        ListView1.TabIndex = 28
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' carID
        ' 
        carID.Text = "#"
        ' 
        ' carImage
        ' 
        carImage.Text = "Car Image"
        carImage.Width = 140
        ' 
        ' carName
        ' 
        carName.Text = "Car Name"
        carName.Width = 200
        ' 
        ' carSeat
        ' 
        carSeat.Text = "Car Seat"
        carSeat.Width = 80
        ' 
        ' carCC
        ' 
        carCC.Text = "C.C"
        carCC.Width = 80
        ' 
        ' carGear
        ' 
        carGear.Text = "Car Gear"
        carGear.Width = 80
        ' 
        ' rentalPrice
        ' 
        rentalPrice.Text = "Rental Price"
        rentalPrice.Width = 100
        ' 
        ' ViewCarList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1000, 572)
        Controls.Add(ListView1)
        Controls.Add(Label1)
        Controls.Add(lblCarList)
        Controls.Add(Panel1)
        Name = "ViewCarList"
        StartPosition = FormStartPosition.CenterScreen
        Text = "View Car List"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnViewCar As Button
    Friend WithEvents btnViewRental As Button
    Friend WithEvents btnAddRental As Button
    Friend WithEvents lblCarList As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents carID As ColumnHeader
    Friend WithEvents carName As ColumnHeader
    Friend WithEvents carSeat As ColumnHeader
    Friend WithEvents carCC As ColumnHeader
    Friend WithEvents carGear As ColumnHeader
    Friend WithEvents rentalPrice As ColumnHeader
    Friend WithEvents btnRemoveCar As Button
    Friend WithEvents carImage As ColumnHeader
    Friend WithEvents btnEditCar As Button
End Class
