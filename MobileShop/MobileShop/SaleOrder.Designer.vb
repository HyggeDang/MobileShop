<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SaleOrder))
        Me.pictBird = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnExit = New System.Windows.Forms.Button
        Me.btnFind = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnFormCancel = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.FlexGrid = New AxMSFlexGridLib.AxMSFlexGrid
        Me.FindGroupBox = New System.Windows.Forms.GroupBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnShow = New System.Windows.Forms.Button
        Me.cmbOno = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtAmt = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQty = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTP1 = New System.Windows.Forms.DateTimePicker
        Me.cmbMId = New System.Windows.Forms.ComboBox
        Me.cmbSId = New System.Windows.Forms.ComboBox
        Me.txtOno = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblSName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblOno = New System.Windows.Forms.Label
        Me.txtNetAmount = New System.Windows.Forms.TextBox
        Me.txtTotalAmt = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtDiscount = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.pictBird, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FlexGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FindGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'pictBird
        '
        Me.pictBird.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pictBird.Location = New System.Drawing.Point(12, 12)
        Me.pictBird.Name = "pictBird"
        Me.pictBird.Size = New System.Drawing.Size(135, 111)
        Me.pictBird.TabIndex = 11
        Me.pictBird.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(191, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(229, 31)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Sale Order Form"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(539, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 193)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.btnFind)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnFormCancel)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 439)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(519, 55)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(423, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(42, 40)
        Me.btnExit.TabIndex = 0
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(238, 18)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 0
        Me.btnFind.Text = "Search"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(148, 19)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 0
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnFormCancel
        '
        Me.btnFormCancel.Location = New System.Drawing.Point(329, 18)
        Me.btnFormCancel.Name = "btnFormCancel"
        Me.btnFormCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnFormCancel.TabIndex = 0
        Me.btnFormCancel.Text = "Cancel"
        Me.btnFormCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(57, 19)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 0
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'FlexGrid
        '
        Me.FlexGrid.Location = New System.Drawing.Point(14, 304)
        Me.FlexGrid.Name = "FlexGrid"
        Me.FlexGrid.OcxState = CType(resources.GetObject("FlexGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.FlexGrid.Size = New System.Drawing.Size(519, 113)
        Me.FlexGrid.TabIndex = 15
        '
        'FindGroupBox
        '
        Me.FindGroupBox.Controls.Add(Me.btnCancel)
        Me.FindGroupBox.Controls.Add(Me.btnShow)
        Me.FindGroupBox.Controls.Add(Me.cmbOno)
        Me.FindGroupBox.Controls.Add(Me.Label12)
        Me.FindGroupBox.Location = New System.Drawing.Point(12, 142)
        Me.FindGroupBox.Name = "FindGroupBox"
        Me.FindGroupBox.Size = New System.Drawing.Size(521, 147)
        Me.FindGroupBox.TabIndex = 31
        Me.FindGroupBox.TabStop = False
        Me.FindGroupBox.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(292, 72)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnShow
        '
        Me.btnShow.Location = New System.Drawing.Point(292, 28)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(75, 23)
        Me.btnShow.TabIndex = 2
        Me.btnShow.Text = "Show"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'cmbOno
        '
        Me.cmbOno.FormattingEnabled = True
        Me.cmbOno.Location = New System.Drawing.Point(104, 66)
        Me.cmbOno.Name = "cmbOno"
        Me.cmbOno.Size = New System.Drawing.Size(121, 21)
        Me.cmbOno.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(135, 28)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Order No"
        '
        'txtAmt
        '
        Me.txtAmt.Location = New System.Drawing.Point(417, 266)
        Me.txtAmt.Name = "txtAmt"
        Me.txtAmt.ReadOnly = True
        Me.txtAmt.Size = New System.Drawing.Size(116, 20)
        Me.txtAmt.TabIndex = 27
        Me.txtAmt.Tag = "Amount"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(451, 238)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Amount"
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(280, 267)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(116, 20)
        Me.txtRate.TabIndex = 25
        Me.txtRate.Tag = "Rate"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(314, 239)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Rate"
        '
        'txtQty
        '
        Me.txtQty.Location = New System.Drawing.Point(150, 266)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(116, 20)
        Me.txtQty.TabIndex = 24
        Me.txtQty.Tag = "Quantity"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(183, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Quantity"
        '
        'DTP1
        '
        Me.DTP1.CustomFormat = "dd/MM/yyyy"
        Me.DTP1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTP1.Location = New System.Drawing.Point(391, 142)
        Me.DTP1.Name = "DTP1"
        Me.DTP1.Size = New System.Drawing.Size(109, 20)
        Me.DTP1.TabIndex = 26
        '
        'cmbMId
        '
        Me.cmbMId.FormattingEnabled = True
        Me.cmbMId.Location = New System.Drawing.Point(12, 267)
        Me.cmbMId.Name = "cmbMId"
        Me.cmbMId.Size = New System.Drawing.Size(116, 21)
        Me.cmbMId.TabIndex = 23
        Me.cmbMId.Tag = "Model ID"
        '
        'cmbSId
        '
        Me.cmbSId.FormattingEnabled = True
        Me.cmbSId.Location = New System.Drawing.Point(137, 183)
        Me.cmbSId.Name = "cmbSId"
        Me.cmbSId.Size = New System.Drawing.Size(116, 21)
        Me.cmbSId.TabIndex = 22
        Me.cmbSId.Tag = "Supplier ID"
        '
        'txtOno
        '
        Me.txtOno.Location = New System.Drawing.Point(137, 146)
        Me.txtOno.Name = "txtOno"
        Me.txtOno.ReadOnly = True
        Me.txtOno.Size = New System.Drawing.Size(116, 20)
        Me.txtOno.TabIndex = 18
        Me.txtOno.Tag = "Order No"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(24, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Model ID"
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.BackColor = System.Drawing.Color.Transparent
        Me.lblSName.Location = New System.Drawing.Point(304, 186)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(35, 13)
        Me.lblSName.TabIndex = 16
        Me.lblSName.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(24, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Customer Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(301, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Order  Date"
        '
        'lblOno
        '
        Me.lblOno.AutoSize = True
        Me.lblOno.BackColor = System.Drawing.Color.Transparent
        Me.lblOno.Location = New System.Drawing.Point(24, 153)
        Me.lblOno.Name = "lblOno"
        Me.lblOno.Size = New System.Drawing.Size(50, 13)
        Me.lblOno.TabIndex = 19
        Me.lblOno.Text = "Order No"
        '
        'txtNetAmount
        '
        Me.txtNetAmount.Location = New System.Drawing.Point(640, 379)
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.ReadOnly = True
        Me.txtNetAmount.Size = New System.Drawing.Size(116, 20)
        Me.txtNetAmount.TabIndex = 36
        '
        'txtTotalAmt
        '
        Me.txtTotalAmt.Location = New System.Drawing.Point(640, 297)
        Me.txtTotalAmt.Name = "txtTotalAmt"
        Me.txtTotalAmt.ReadOnly = True
        Me.txtTotalAmt.Size = New System.Drawing.Size(116, 20)
        Me.txtTotalAmt.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(539, 386)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Net Amount"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(563, 344)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Discount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(539, 304)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 13)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Total Amount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(640, 337)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(116, 20)
        Me.txtDiscount.TabIndex = 37
        Me.txtDiscount.Tag = "Discount"
        Me.txtDiscount.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(545, 344)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "-"
        '
        'SaleOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 503)
        Me.Controls.Add(Me.txtNetAmount)
        Me.Controls.Add(Me.txtTotalAmt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDiscount)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FindGroupBox)
        Me.Controls.Add(Me.txtAmt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTP1)
        Me.Controls.Add(Me.cmbMId)
        Me.Controls.Add(Me.cmbSId)
        Me.Controls.Add(Me.txtOno)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblSName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblOno)
        Me.Controls.Add(Me.FlexGrid)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pictBird)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "SaleOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SaleOrder"
        CType(Me.pictBird, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.FlexGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FindGroupBox.ResumeLayout(False)
        Me.FindGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pictBird As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnFormCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents FlexGrid As AxMSFlexGridLib.AxMSFlexGrid
    Friend WithEvents FindGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnShow As System.Windows.Forms.Button
    Friend WithEvents cmbOno As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTP1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbMId As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSId As System.Windows.Forms.ComboBox
    Friend WithEvents txtOno As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblSName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblOno As System.Windows.Forms.Label
    Friend WithEvents txtNetAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalAmt As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
