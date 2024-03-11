<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModelMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FeatureMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DetailsFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModelFeaturesDetailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PurchaseOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaleOrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModelDetailReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FeaturesReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrderMasterReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaleOrderMasterRepoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CustomerReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplierReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModelFeatureReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaleBillToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotepadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MasterToolStripMenuItem, Me.DetailsFormToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.ToolsToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MasterToolStripMenuItem
        '
        Me.MasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModelMasterToolStripMenuItem, Me.FeatureMasterToolStripMenuItem, Me.SupplierMasterToolStripMenuItem, Me.CustomerMasterToolStripMenuItem})
        Me.MasterToolStripMenuItem.Name = "MasterToolStripMenuItem"
        Me.MasterToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.MasterToolStripMenuItem.Text = "Master"
        '
        'ModelMasterToolStripMenuItem
        '
        Me.ModelMasterToolStripMenuItem.Name = "ModelMasterToolStripMenuItem"
        Me.ModelMasterToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ModelMasterToolStripMenuItem.Text = "Model Master"
        '
        'FeatureMasterToolStripMenuItem
        '
        Me.FeatureMasterToolStripMenuItem.Name = "FeatureMasterToolStripMenuItem"
        Me.FeatureMasterToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.FeatureMasterToolStripMenuItem.Text = "Feature Master"
        '
        'SupplierMasterToolStripMenuItem
        '
        Me.SupplierMasterToolStripMenuItem.Name = "SupplierMasterToolStripMenuItem"
        Me.SupplierMasterToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.SupplierMasterToolStripMenuItem.Text = "Supplier Master"
        '
        'CustomerMasterToolStripMenuItem
        '
        Me.CustomerMasterToolStripMenuItem.Name = "CustomerMasterToolStripMenuItem"
        Me.CustomerMasterToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.CustomerMasterToolStripMenuItem.Text = "Customer Master"
        '
        'DetailsFormToolStripMenuItem
        '
        Me.DetailsFormToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModelFeaturesDetailToolStripMenuItem, Me.PurchaseOrderToolStripMenuItem, Me.SaleOrderToolStripMenuItem})
        Me.DetailsFormToolStripMenuItem.Name = "DetailsFormToolStripMenuItem"
        Me.DetailsFormToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.DetailsFormToolStripMenuItem.Text = "Details Form"
        '
        'ModelFeaturesDetailToolStripMenuItem
        '
        Me.ModelFeaturesDetailToolStripMenuItem.Name = "ModelFeaturesDetailToolStripMenuItem"
        Me.ModelFeaturesDetailToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.ModelFeaturesDetailToolStripMenuItem.Text = "Model Features Detail"
        '
        'PurchaseOrderToolStripMenuItem
        '
        Me.PurchaseOrderToolStripMenuItem.Name = "PurchaseOrderToolStripMenuItem"
        Me.PurchaseOrderToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.PurchaseOrderToolStripMenuItem.Text = "Purchase Order"
        '
        'SaleOrderToolStripMenuItem
        '
        Me.SaleOrderToolStripMenuItem.Name = "SaleOrderToolStripMenuItem"
        Me.SaleOrderToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SaleOrderToolStripMenuItem.Text = "Sale Order"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModelDetailReportToolStripMenuItem, Me.FeaturesReportToolStripMenuItem, Me.OrderMasterReportToolStripMenuItem, Me.SaleOrderMasterRepoToolStripMenuItem, Me.CustomerReportToolStripMenuItem, Me.SupplierReportToolStripMenuItem, Me.ModelFeatureReportToolStripMenuItem, Me.SaleBillToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'ModelDetailReportToolStripMenuItem
        '
        Me.ModelDetailReportToolStripMenuItem.Name = "ModelDetailReportToolStripMenuItem"
        Me.ModelDetailReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ModelDetailReportToolStripMenuItem.Text = "Model Detail Report"
        '
        'FeaturesReportToolStripMenuItem
        '
        Me.FeaturesReportToolStripMenuItem.Name = "FeaturesReportToolStripMenuItem"
        Me.FeaturesReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.FeaturesReportToolStripMenuItem.Text = "Features Report"
        '
        'OrderMasterReportToolStripMenuItem
        '
        Me.OrderMasterReportToolStripMenuItem.Name = "OrderMasterReportToolStripMenuItem"
        Me.OrderMasterReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.OrderMasterReportToolStripMenuItem.Text = "Purchase Master Report"
        '
        'SaleOrderMasterRepoToolStripMenuItem
        '
        Me.SaleOrderMasterRepoToolStripMenuItem.Name = "SaleOrderMasterRepoToolStripMenuItem"
        Me.SaleOrderMasterRepoToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SaleOrderMasterRepoToolStripMenuItem.Text = "Sale  Master Report"
        '
        'CustomerReportToolStripMenuItem
        '
        Me.CustomerReportToolStripMenuItem.Name = "CustomerReportToolStripMenuItem"
        Me.CustomerReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.CustomerReportToolStripMenuItem.Text = "Customer Report"
        '
        'SupplierReportToolStripMenuItem
        '
        Me.SupplierReportToolStripMenuItem.Name = "SupplierReportToolStripMenuItem"
        Me.SupplierReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SupplierReportToolStripMenuItem.Text = "Supplier Report"
        '
        'ModelFeatureReportToolStripMenuItem
        '
        Me.ModelFeatureReportToolStripMenuItem.Name = "ModelFeatureReportToolStripMenuItem"
        Me.ModelFeatureReportToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.ModelFeatureReportToolStripMenuItem.Text = "Model Feature Report"
        '
        'SaleBillToolStripMenuItem
        '
        Me.SaleBillToolStripMenuItem.Name = "SaleBillToolStripMenuItem"
        Me.SaleBillToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.SaleBillToolStripMenuItem.Text = "Sale Bill"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.NotepadToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NotepadToolStripMenuItem
        '
        Me.NotepadToolStripMenuItem.Name = "NotepadToolStripMenuItem"
        Me.NotepadToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.NotepadToolStripMenuItem.Text = "Notepad"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 320)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeatureMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetailsFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelFeaturesDetailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PurchaseOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleOrderToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelDetailReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeaturesReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrderMasterReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleOrderMasterRepoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotepadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CustomerReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplierReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModelFeatureReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaleBillToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
