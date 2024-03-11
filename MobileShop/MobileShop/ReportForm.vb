Public Class ReportForm

    Private Sub ReportForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If rptStr = "Supp" Then
            Dim o As New rptSupplier
            CRV.ReportSource = o
        ElseIf rptStr = "Cust" Then
            Dim o As New rptCustomer
            CRV.ReportSource = o
        ElseIf rptStr = "Sale" Then
            Dim o As New rptSale
            CRV.ReportSource = o
        ElseIf rptStr = "Purc" Then
            Dim o As New rptPurchaseOrder
            CRV.ReportSource = o
        ElseIf rptStr = "Model" Then
            Dim o As New rptModel_Details
            CRV.ReportSource = o

        ElseIf rptStr = "Feat" Then
            Dim o As New rptFMaster
            CRV.ReportSource = o

        ElseIf rptStr = "MF" Then
            Dim o As New rptMFeature
            CRV.ReportSource = o
        ElseIf rptStr = "SB" Then
            Dim o As New SMSDR
            CRV.ReportSource = o
        End If
        CRV.Show()
        CRV.DisplayGroupTree = False
        CRV.Zoom(90)
    End Sub


    Private Sub ReportForm_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        CRV.Height = Me.Height - 20
        CRV.Width = Me.Width
    End Sub

End Class