<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Panel1 = New Panel()
        lblRegisteredCar = New Label()
        lbltotalCarNum = New Label()
        Panel2 = New Panel()
        lblRentedCar = New Label()
        lblRentedCarNum = New Label()
        btnViewCarList = New Button()
        btnExit = New Button()
        ListView1 = New ListView()
        numOfItem = New ColumnHeader()
        carImage = New ColumnHeader()
        carName = New ColumnHeader()
        rentalPrice = New ColumnHeader()
        pickUpDate = New ColumnHeader()
        pickUpTime = New ColumnHeader()
        lblRecentRentedCar = New Label()
        Button1 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 44)
        Label1.TabIndex = 1
        Label1.Text = "Car Rental System"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        Panel1.Controls.Add(lblRegisteredCar)
        Panel1.Controls.Add(lbltotalCarNum)
        Panel1.Location = New Point(21, 75)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 125)
        Panel1.TabIndex = 2
        ' 
        ' lblRegisteredCar
        ' 
        lblRegisteredCar.AutoSize = True
        lblRegisteredCar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRegisteredCar.ForeColor = Color.White
        lblRegisteredCar.Location = New Point(18, 71)
        lblRegisteredCar.Name = "lblRegisteredCar"
        lblRegisteredCar.Size = New Size(143, 28)
        lblRegisteredCar.TabIndex = 1
        lblRegisteredCar.Text = "Registered Car"
        ' 
        ' lbltotalCarNum
        ' 
        lbltotalCarNum.AutoSize = True
        lbltotalCarNum.Font = New Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        lbltotalCarNum.ForeColor = Color.White
        lbltotalCarNum.Location = New Point(18, 16)
        lbltotalCarNum.Name = "lbltotalCarNum"
        lbltotalCarNum.Size = New Size(76, 55)
        lbltotalCarNum.TabIndex = 0
        lbltotalCarNum.Text = "12"
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(192))
        Panel2.Controls.Add(lblRentedCar)
        Panel2.Controls.Add(lblRentedCarNum)
        Panel2.Location = New Point(296, 75)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 125)
        Panel2.TabIndex = 3
        ' 
        ' lblRentedCar
        ' 
        lblRentedCar.AutoSize = True
        lblRentedCar.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblRentedCar.ForeColor = Color.White
        lblRentedCar.Location = New Point(18, 71)
        lblRentedCar.Name = "lblRentedCar"
        lblRentedCar.Size = New Size(111, 28)
        lblRentedCar.TabIndex = 1
        lblRentedCar.Text = "Rented Car"
        ' 
        ' lblRentedCarNum
        ' 
        lblRentedCarNum.AutoSize = True
        lblRentedCarNum.Font = New Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblRentedCarNum.ForeColor = Color.White
        lblRentedCarNum.Location = New Point(18, 16)
        lblRentedCarNum.Name = "lblRentedCarNum"
        lblRentedCarNum.Size = New Size(50, 55)
        lblRentedCarNum.TabIndex = 0
        lblRentedCarNum.Text = "3"
        ' 
        ' btnViewCarList
        ' 
        btnViewCarList.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnViewCarList.Location = New Point(692, 27)
        btnViewCarList.Name = "btnViewCarList"
        btnViewCarList.Size = New Size(222, 57)
        btnViewCarList.TabIndex = 5
        btnViewCarList.Text = "View Car List"
        btnViewCarList.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        btnExit.ForeColor = Color.Red
        btnExit.Location = New Point(692, 187)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(222, 57)
        btnExit.TabIndex = 6
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' ListView1
        ' 
        ListView1.Columns.AddRange(New ColumnHeader() {numOfItem, carImage, carName, rentalPrice, pickUpDate, pickUpTime})
        ListView1.Location = New Point(21, 262)
        ListView1.Name = "ListView1"
        ListView1.Size = New Size(893, 238)
        ListView1.TabIndex = 7
        ListView1.UseCompatibleStateImageBehavior = False
        ListView1.View = View.Details
        ' 
        ' numOfItem
        ' 
        numOfItem.Text = "#"
        ' 
        ' carImage
        ' 
        carImage.Text = "Image"
        ' 
        ' carName
        ' 
        carName.Text = "Car Name"
        ' 
        ' rentalPrice
        ' 
        rentalPrice.Text = "Rental Price"
        ' 
        ' pickUpDate
        ' 
        pickUpDate.Text = "Pick Up Date"
        ' 
        ' pickUpTime
        ' 
        pickUpTime.Text = "Pick Up Time"
        ' 
        ' lblRecentRentedCar
        ' 
        lblRecentRentedCar.AutoSize = True
        lblRecentRentedCar.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblRecentRentedCar.Location = New Point(21, 221)
        lblRecentRentedCar.Name = "lblRecentRentedCar"
        lblRecentRentedCar.Size = New Size(268, 38)
        lblRecentRentedCar.TabIndex = 8
        lblRecentRentedCar.Text = "Recent Rented Cars"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(692, 106)
        Button1.Name = "Button1"
        Button1.Size = New Size(222, 57)
        Button1.TabIndex = 9
        Button1.Text = "View History"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Dashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(980, 575)
        Controls.Add(Button1)
        Controls.Add(lblRecentRentedCar)
        Controls.Add(ListView1)
        Controls.Add(btnExit)
        Controls.Add(btnViewCarList)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Name = "Dashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Dashboard"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbltotalCarNum As Label
    Friend WithEvents lblRegisteredCar As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblRentedCar As Label
    Friend WithEvents lblRentedCarNum As Label
    Friend WithEvents btnAddCar As Button
    Friend WithEvents btnViewCarList As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents lblRecentRentedCar As Label
    Friend WithEvents numOfItem As ColumnHeader
    Friend WithEvents carImage As ColumnHeader
    Friend WithEvents carName As ColumnHeader
    Friend WithEvents rentalPrice As ColumnHeader
    Friend WithEvents pickUpDate As ColumnHeader
    Friend WithEvents pickUpTime As ColumnHeader
    Friend WithEvents Button1 As Button
End Class
