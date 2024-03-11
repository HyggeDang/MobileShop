Public Class MainForm

    Private Sub FeatureMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeatureMasterToolStripMenuItem.Click
        Dim o As New FeaturesMaster
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub ModelMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModelMasterToolStripMenuItem.Click
        Dim o As New ModelMaster
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub ModelFeaturesDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModelFeaturesDetailToolStripMenuItem.Click
        Dim o As New ModelFeatureDetail
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub CustomerMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerMasterToolStripMenuItem.Click
        Dim o As New CustomerMaster
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub SupplierMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierMasterToolStripMenuItem.Click
        Dim o As New SupplierMaster
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub PurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        Dim o As New PurchaseOrder
        o.MdiParent = Me
        o.Show()
    End Sub


    Private Sub SaleOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleOrderToolStripMenuItem.Click
        Dim o As New SaleOrder
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub ToolsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem.Click

    End Sub

    Private Sub CalculatorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculatorToolStripMenuItem.Click
        Shell("Calc.exe")
    End Sub


    Private Sub NotepadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotepadToolStripMenuItem.Click
        Shell("Notepad.exe")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ModelDetailReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModelDetailReportToolStripMenuItem.Click
        rptStr = "Model"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub

   

    Private Sub FeaturesReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FeaturesReportToolStripMenuItem.Click
        rptStr = "Feat"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub OrderMasterReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrderMasterReportToolStripMenuItem.Click
        rptStr = "Purc"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub SaleOrderMasterRepoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleOrderMasterRepoToolStripMenuItem.Click
        rptStr = "Sale"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub CustomerReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReportToolStripMenuItem.Click
        rptStr = "Cust"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub SupplierReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierReportToolStripMenuItem.Click
        rptStr = "Supp"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub ModelFeatureReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModelFeatureReportToolStripMenuItem.Click
        rptStr = "MF"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub

    Private Sub SaleBillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaleBillToolStripMenuItem.Click
        rptStr = "SB"
        Dim o As New ReportForm
        o.MdiParent = Me
        o.Show()
    End Sub
End Class