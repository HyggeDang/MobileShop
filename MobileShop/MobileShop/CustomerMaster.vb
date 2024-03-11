Imports System.Data.OleDb

Public Class CustomerMaster

    Private Sub CustomerMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\M1.jpg")
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\Exit.gif")

            Dim cmd As New OleDbCommand("Select * from CustomerMaster", cn)
            cn.Open()

            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                txtID.Text = dr(0)
            End While
            txtID.Text = Val(txtID.Text) + 1
            dr.Close()
            cn.Close()

            Dim da As New OleDbDataAdapter("Select * from CustomerMaster", cn)
            Dim ds As New DataSet
            da.Fill(ds, "Mast")
            DataGridView1.DataSource = ds.Tables(0)
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

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Try
            FindGroupBox.Visible = True
            Dim cmd As New OleDbCommand("Select * from CustomerMaster", cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            cmbID.Items.Clear()

            While dr.Read
                cmbID.Items.Add(dr(0))
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
        Try
            If Len(Trim(cmbID.Text)) = 0 Then
                MsgBox("Please Select  Id  Number...!", MsgBoxStyle.Exclamation, Me.Text)
                FindGroupBox.Visible = False
                Exit Sub
            Else

                Dim cmd As New OleDbCommand("Select * from CustomerMaster where CustomerId=" & cmbID.Text, cn)
                cn.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    txtID.Text = dr(0)
                    txtName.Text = dr(1)
                    txtAdd.Text = dr(2)
                    txtCity.Text = dr(3)
                    txtPhno.Text = dr(4)
                    txtMail.Text = dr(5)
                End While
                dr.Close()
                cn.Close()
                FindGroupBox.Visible = False
                btnSave.Enabled = False
                btnModify.Enabled = True
                btnDelete.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        FindGroupBox.Visible = False
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Try
            Dim obj As Control
            For Each obj In Me.Controls
                If TypeOf obj Is TextBox Then
                    If Len(Trim(obj.Text)) = 0 Then
                        MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
                        obj.Focus()
                        Exit Sub
                    End If
                End If
            Next


            Dim cmd As New OleDbCommand("Update CustomerMaster set Name='" & txtName.Text & "',Address='" & txtAdd.Text & "',City='" & txtCity.Text & "',Phno='" & txtPhno.Text & "',EMail='" & txtMail.Text & "' where CustomerID=" & txtID.Text, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Updated.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()


            Dim o As New CustomerMaster
            o.MdiParent = MainForm.ActiveForm
            o.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Dim obj As Control
            For Each obj In Me.Controls
                If TypeOf obj Is TextBox Then
                    If Len(Trim(obj.Text)) = 0 Then
                        MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
                        obj.Focus()
                        Exit Sub
                    End If
                End If
            Next


            Dim cmd As New OleDbCommand("Insert into CustomerMaster Values(" & txtID.Text & ",'" & txtName.Text & "','" & txtAdd.Text & "','" & txtCity.Text & "','" & txtPhno.Text & "','" & txtMail.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Saved.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()


            Dim o As New CustomerMaster
            o.MdiParent = MainForm.ActiveForm
            o.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub



    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim cmd As New OleDbCommand("Delete from CustomerMaster where CustomerID=" & txtID.Text, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()


            Dim o As New CustomerMaster
            o.MdiParent = MainForm.ActiveForm
            o.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtCity_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCity.KeyPress, txtName.KeyPress
        Dim f As Boolean = False
        f = Text_Validation(e.KeyChar)
        If f = True Then
            e.Handled = True        'Keyascii=0
        End If
    End Sub


    Private Sub txtPhno_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPhno.KeyPress
        Dim f As Boolean = False
        f = Number_Validation(e.KeyChar)
        If f = True Then
            e.Handled = True
        End If
    End Sub
End Class