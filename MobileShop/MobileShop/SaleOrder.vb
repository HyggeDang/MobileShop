Imports System.Data.OleDb
Public Class SaleOrder
    Dim RowCt As Integer

    Private Sub GridSet()
        With FlexGrid
            .set_ColWidth(0, 400)
            .set_ColWidth(1, 1500)
            .set_ColWidth(2, 1000)
            .set_ColWidth(3, 1000)
            .set_ColWidth(4, 1000)

            .set_TextMatrix(0, 1, "ModelID")
            .set_TextMatrix(0, 2, "Qty")
            .set_TextMatrix(0, 3, "Rate")
            .set_TextMatrix(0, 4, "Amount")

            Dim i As Integer
            For i = 1 To .Rows - 1
                .set_TextMatrix(i, 0, i)
            Next
            .Row = 0
            .Col = 1
            .CellBackColor = Color.LightGray
            .Col = 2
            .CellBackColor = Color.LightGray
            .Col = 3
            .CellBackColor = Color.LightGray
            .Col = 4
            .CellBackColor = Color.LightGray

        End With
    End Sub


    Private Sub SaleOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Call GridSet()

            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\M1.jpg")
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\Exit.gif")
            pictBird.Image = Image.FromFile(Application.StartupPath & "\Images\Bird.gif")

            Dim cmd As New OleDbCommand("Select * from SaleMaster", cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                txtOno.Text = dr(0)
            End While
            txtOno.Text = Val(txtOno.Text) + 1
            dr.Close()
            cn.Close()

            Dim cmd1 As New OleDbCommand("Select * from CustomerMaster", cn)
            cn.Open()

            Dim dr1 As OleDbDataReader = cmd1.ExecuteReader

            While dr1.Read
                cmbSId.Items.Add(dr1(0))
            End While
            dr1.Close()
            cn.Close()


            Dim cmd2 As New OleDbCommand("Select * from ModelMaster", cn)
            cn.Open()

            Dim dr2 As OleDbDataReader = cmd2.ExecuteReader

            While dr2.Read
                cmbMId.Items.Add(dr2(0))
            End While
            dr2.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        pictBird.BackColor = Color.FromArgb(CType(Rnd() * 255, Byte), CType(Rnd() * 255, Byte), CType(Rnd() * 255, Byte))
    End Sub

    Private Sub cmbSId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSId.SelectedIndexChanged
        Try
            Dim cn1 As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & Application.StartupPath & "\DataBase\Mobile.mdb;Persist Security Info=false;")
            Dim cmd As New OleDbCommand("Select * from CustomerMaster where CustomerId=" & cmbSId.Text, cn1)
            cn1.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                lblSName.Text = dr(1)
            End While
            dr.Close()
            cn1.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub cmbMId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMId.SelectedIndexChanged
        Try
            Dim cn2 As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & Application.StartupPath & "\DataBase\Mobile.mdb;Persist Security Info=false;")
            Dim cmd As New OleDbCommand("Select * from ModelMaster where ModelID=" & cmbMId.Text, cn2)
            cn2.Open()
            'cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            While dr.Read
                Dim str1 As String = dr(4)
                PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & str1)
                txtRate.Text = dr(3)
            End While
            dr.Close()
            cn2.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub txtQty_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQty.KeyPress
        If e.KeyChar = Chr(13) Then
            With FlexGrid
                .Rows = .Rows + 1
                .set_TextMatrix(.Rows - 1, 1, cmbMId.Text)
                .set_TextMatrix(.Rows - 1, 2, txtQty.Text)
                .set_TextMatrix(.Rows - 1, 3, txtRate.Text)
                .set_TextMatrix(.Rows - 1, 4, txtAmt.Text)
                txtTotalAmt.Text = Val(txtTotalAmt.Text) + Val(txtAmt.Text)
                txtNetAmount.Text = txtTotalAmt.Text
            End With

            cmbMId.Text = ""
            txtQty.Text = ""
            txtRate.Text = ""
            txtAmt.Text = ""
            cmbMId.Focus()
            Call GridSet()
        Else
            Dim f As Boolean = False
            f = Number_Validation(e.KeyChar)
            If f = True Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtQty_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQty.TextChanged
        txtAmt.Text = Val(txtQty.Text) * Val(txtRate.Text)
    End Sub


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Trim(cmbSId.Text) = "" Then
            MsgBox("Please Select Customer Code", MsgBoxStyle.Exclamation, Me.Text)
            cmbSId.Focus()
            Exit Sub
        End If
        If FlexGrid.Rows < 2 Then
            MsgBox("Please Enter Atleast One Record", MsgBoxStyle.Exclamation, Me.Text)
            cmbMId.Focus()
            Exit Sub
        End If



        '===============================================
        Try
            Dim sql As String
            cn.Open()

            Dim TempDis As Integer = 0
            If Val(txtDiscount.Text) = 0 Then
                TempDis = 0
            Else
                TempDis = Val(txtDiscount.Text)
            End If


            sql = "INSERT INTO SaleMaster VALUES(" & txtOno.Text & "," & _
            cmbSId.Text & ",'" & _
            DTP1.Text & "'," & _
            txtTotalAmt.Text & "," & _
            TempDis & "," & _
            txtNetAmount.Text & ")"

            Dim cmd As New OleDb.OleDbCommand(sql, cn)
            cmd.ExecuteNonQuery()
            Dim i As Integer

            With FlexGrid
                For i = 1 To .Rows - 1
                    Dim MID, Qty, Rate, AMT As String
                    .Row = i
                    .Col = 1
                    MID = .Text
                    .Col = 2
                    Qty = .Text
                    .Col = 3
                    Rate = .Text
                    .Col = 4
                    AMT = .Text
                    sql = "INSERT INTO SaleDetail Values(" & txtOno.Text & "," & MID & "," & Qty & "," & Rate & "," & AMT & ")"
                    Dim cmd1 As New OleDb.OleDbCommand(sql, cn)
                    cmd1.ExecuteNonQuery()
                Next
            End With
            cn.Close()
            MsgBox("Successfully Added A New  Record .......!", MsgBoxStyle.Information, Me.Text)
            Me.Close()


            Dim ob As New SaleOrder
            ob.MdiParent = MainForm.ActiveForm
            ob.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

        '===============================================

    End Sub

    Private Sub btnCancel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        FindGroupBox.Visible = False
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            FindGroupBox.Visible = True
            Dim cmd As New OleDbCommand("Select * from SaleMaster ORDER BY ONo", cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            cmbOno.Items.Clear()

            While dr.Read
                cmbOno.Items.Add(dr(0))
            End While
            dr.Close()
            cn.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
        If cmbOno.Text = "" Then
            MsgBox("Please Select Sale Order Number", MsgBoxStyle.Exclamation, Me.Text)
            cmbOno.Focus()
            Exit Sub
        End If
        Try
            Dim sql As String
            cn.Open()
            sql = "select * from SaleMaster where ONo=" & cmbOno.Text & ""
            Dim Cmd As New OleDb.OleDbCommand(sql, cn)
            Dim ObjReader As OleDb.OleDbDataReader = Cmd.ExecuteReader
            ObjReader.Read()
            txtOno.Text = ObjReader(0)
            cmbSId.Text = ObjReader(1)
            DTP1.Text = ObjReader(2)
            txtTotalAmt.Text = ObjReader(3)
            txtDiscount.Text = ObjReader(4)
            txtNetAmount.Text = ObjReader(5)
            ObjReader.Close()

            sql = "select * from SaleDetail where ONo=" & cmbOno.Text & ""
            Dim Cmd1 As New OleDb.OleDbCommand(sql, cn)
            Dim ObjReader1 As OleDb.OleDbDataReader = Cmd1.ExecuteReader

            FlexGrid.Clear()
            While ObjReader1.Read()
                With FlexGrid
                    .Rows = .Rows + 1
                    .set_TextMatrix(.Rows - 1, 1, ObjReader1(1))
                    .set_TextMatrix(.Rows - 1, 2, ObjReader1(2))
                    .set_TextMatrix(.Rows - 1, 3, ObjReader1(3))
                    .set_TextMatrix(.Rows - 1, 4, ObjReader1(4))
                End With
            End While
            ObjReader1.Close()
            Call GridSet()
            cn.Close()
            FindGroupBox.Visible = False
            'UPD = True
            btnSave.Enabled = False
            btnDelete.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormCancel.Click
        Dim ob As New SaleOrder
        ob.MdiParent = MainForm.ActiveForm
        Me.Close()
        ob.Show()
    End Sub

    Private Sub txtDiscount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscount.KeyPress
        Dim f As Boolean = False
        f = Number_Validation(e.KeyChar)
        If f = True Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If Not Val(txtDiscount.Text) > Val(txtTotalAmt.Text) Then
            txtNetAmount.Text = Val(txtTotalAmt.Text) - Val(txtDiscount.Text)
        Else
            MsgBox("Discount Are Not Allowed Grater Than Total Amount...!", MsgBoxStyle.Exclamation, Me.Text)
            Exit Sub
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim sql As String
            sql = "DELETE From SaleMaster where ONo=" & txtOno.Text & ""
            Dim cmd As New OleDb.OleDbCommand(sql, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            sql = "DELETE From SaleDetail where ONo=" & txtOno.Text & ""
            Dim cmd1 As New OleDb.OleDbCommand(sql, cn)
            cmd1.ExecuteNonQuery()
            cn.Close()
            MsgBox("Successfully Record Ate Deleted....!", MsgBoxStyle.Information, Me.Text)
            Me.Close()

            Dim ob As New SaleOrder
            ob.MdiParent = MainForm.ActiveForm
            ob.Show()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class