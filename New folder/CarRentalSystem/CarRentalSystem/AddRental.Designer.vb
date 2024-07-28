<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AddRental
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        GroupBox1 = New GroupBox()
        Label6 = New Label()
        TextBox5 = New TextBox()
        TextBox4 = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        GroupBox2 = New GroupBox()
        TextBox10 = New TextBox()
        Label11 = New Label()
        TextBox9 = New TextBox()
        TextBox8 = New TextBox()
        TextBox7 = New TextBox()
        TextBox6 = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        GroupBox3 = New GroupBox()
        ComboBox2 = New ComboBox()
        ComboBox1 = New ComboBox()
        DateTimePicker2 = New DateTimePicker()
        DateTimePicker1 = New DateTimePicker()
        Label12 = New Label()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Timer1 = New Timer(components)
        Timer2 = New Timer(components)
        Label17 = New Label()
        RichTextBox1 = New RichTextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label18 = New Label()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(241, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 44)
        Label1.TabIndex = 0
        Label1.Text = "Car Rental System"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(TextBox4)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(TextBox3)
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(25, 97)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(795, 103)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Car Information"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(596, 36)
        Label6.Name = "Label6"
        Label6.Size = New Size(157, 20)
        Label6.TabIndex = 9
        Label6.Text = "Rental price per hours:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(596, 61)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(193, 27)
        TextBox5.TabIndex = 8
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(379, 62)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(193, 27)
        TextBox4.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(309, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(40, 20)
        Label5.TabIndex = 6
        Label5.Text = "Gear"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(309, 32)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 20)
        Label4.TabIndex = 5
        Label4.Text = "Seats"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(379, 29)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(193, 27)
        TextBox3.TabIndex = 4
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(87, 65)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(193, 27)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 68)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 20)
        Label3.TabIndex = 2
        Label3.Text = "C.c"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(87, 29)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(193, 27)
        TextBox1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(6, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 20)
        Label2.TabIndex = 0
        Label2.Text = "Car Name"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox10)
        GroupBox2.Controls.Add(Label11)
        GroupBox2.Controls.Add(TextBox9)
        GroupBox2.Controls.Add(TextBox8)
        GroupBox2.Controls.Add(TextBox7)
        GroupBox2.Controls.Add(TextBox6)
        GroupBox2.Controls.Add(Label10)
        GroupBox2.Controls.Add(Label9)
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(Label7)
        GroupBox2.Location = New Point(25, 227)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(795, 141)
        GroupBox2.TabIndex = 2
        GroupBox2.TabStop = False
        GroupBox2.Text = "Renter Information"
        ' 
        ' TextBox10
        ' 
        TextBox10.Location = New Point(511, 72)
        TextBox10.Name = "TextBox10"
        TextBox10.Size = New Size(227, 27)
        TextBox10.TabIndex = 16
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(420, 75)
        Label11.Name = "Label11"
        Label11.Size = New Size(62, 20)
        Label11.TabIndex = 15
        Label11.Text = "Address"
        ' 
        ' TextBox9
        ' 
        TextBox9.Location = New Point(511, 33)
        TextBox9.Name = "TextBox9"
        TextBox9.Size = New Size(227, 27)
        TextBox9.TabIndex = 14
        ' 
        ' TextBox8
        ' 
        TextBox8.Location = New Point(87, 108)
        TextBox8.Name = "TextBox8"
        TextBox8.Size = New Size(227, 27)
        TextBox8.TabIndex = 13
        ' 
        ' TextBox7
        ' 
        TextBox7.Location = New Point(87, 72)
        TextBox7.Name = "TextBox7"
        TextBox7.Size = New Size(227, 27)
        TextBox7.TabIndex = 12
        ' 
        ' TextBox6
        ' 
        TextBox6.Location = New Point(87, 33)
        TextBox6.Name = "TextBox6"
        TextBox6.Size = New Size(227, 27)
        TextBox6.TabIndex = 10
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(401, 40)
        Label10.Name = "Label10"
        Label10.Size = New Size(81, 20)
        Label10.TabIndex = 11
        Label10.Text = "License No"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(31, 104)
        Label9.Name = "Label9"
        Label9.Size = New Size(46, 20)
        Label9.TabIndex = 10
        Label9.Text = "IC No"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(6, 72)
        Label8.Name = "Label8"
        Label8.Size = New Size(74, 20)
        Label8.TabIndex = 10
        Label8.Text = "Phone No"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(31, 33)
        Label7.Name = "Label7"
        Label7.Size = New Size(49, 20)
        Label7.TabIndex = 10
        Label7.Text = "Name"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(ComboBox2)
        GroupBox3.Controls.Add(ComboBox1)
        GroupBox3.Controls.Add(DateTimePicker2)
        GroupBox3.Controls.Add(DateTimePicker1)
        GroupBox3.Controls.Add(Label12)
        GroupBox3.Controls.Add(Label13)
        GroupBox3.Controls.Add(Label14)
        GroupBox3.Controls.Add(Label15)
        GroupBox3.Controls.Add(Label16)
        GroupBox3.Location = New Point(25, 390)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(795, 117)
        GroupBox3.TabIndex = 17
        GroupBox3.TabStop = False
        GroupBox3.Text = "Rental Information"
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(99, 74)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(151, 28)
        ComboBox2.TabIndex = 20
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(99, 34)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(151, 28)
        ComboBox1.TabIndex = 19
        ' 
        ' DateTimePicker2
        ' 
        DateTimePicker2.Format = DateTimePickerFormat.Time
        DateTimePicker2.Location = New Point(511, 72)
        DateTimePicker2.Name = "DateTimePicker2"
        DateTimePicker2.Size = New Size(250, 27)
        DateTimePicker2.TabIndex = 18
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.Location = New Point(511, 35)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(250, 27)
        DateTimePicker1.TabIndex = 17
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(400, 72)
        Label12.Name = "Label12"
        Label12.Size = New Size(95, 20)
        Label12.TabIndex = 15
        Label12.Text = "Pick Up Time"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(401, 40)
        Label13.Name = "Label13"
        Label13.Size = New Size(94, 20)
        Label13.TabIndex = 11
        Label13.Text = "Pick Up Date"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(31, 104)
        Label14.Name = "Label14"
        Label14.Size = New Size(0, 20)
        Label14.TabIndex = 10
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(31, 72)
        Label15.Name = "Label15"
        Label15.Size = New Size(47, 20)
        Label15.TabIndex = 10
        Label15.Text = "Dates"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(31, 33)
        Label16.Name = "Label16"
        Label16.Size = New Size(48, 20)
        Label16.TabIndex = 10
        Label16.Text = "Hours"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Location = New Point(31, 540)
        Label17.Name = "Label17"
        Label17.Size = New Size(95, 20)
        Label17.TabIndex = 21
        Label17.Text = "Rental Detail"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(31, 565)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(489, 150)
        RichTextBox1.TabIndex = 22
        RichTextBox1.Text = ""
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(631, 583)
        Button1.Name = "Button1"
        Button1.Size = New Size(169, 52)
        Button1.TabIndex = 23
        Button1.Text = "Book"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.ForeColor = Color.Red
        Button2.Location = New Point(631, 650)
        Button2.Name = "Button2"
        Button2.Size = New Size(169, 44)
        Button2.TabIndex = 24
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label18.Location = New Point(25, 50)
        Label18.Name = "Label18"
        Label18.Size = New Size(202, 44)
        Label18.TabIndex = 25
        Label18.Text = "Rent Car"
        ' 
        ' AddRental
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(850, 737)
        Controls.Add(Label18)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label17)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(Label1)
        Name = "AddRental"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Rental"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label17 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label18 As Label
End Class
