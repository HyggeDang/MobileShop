Imports System.Data.OleDb

Public Class FeaturesMaster

    Private Sub FeaturesMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            PictureBox1.Height = Me.Height
            PictureBox1.Width = Me.Width
            PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\M1.jpg")
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\Exit.gif")

            Dim cmd As New OleDbCommand("Select * from FeatureMaster", cn)
            cn.Open()

            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                txtFId.Text = dr(0)
            End While
            txtFId.Text = Val(txtFId.Text) + 1
            dr.Close()
            cn.Close()

            Dim da As New OleDbDataAdapter("Select * from FeatureMaster", cn)
            Dim ds As New DataSet
            da.Fill(ds, "FMast")
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
            Dim cmd As New OleDbCommand("Select * from FeatureMaster", cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            cmbFId.Items.Clear()

            While dr.Read
                cmbFId.Items.Add(dr(0))
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
            If Len(Trim(cmbFId.Text)) = 0 Then
                MsgBox("Please Select Feature Id...!", MsgBoxStyle.Exclamation, Me.Text)
                FindGroupBox.Visible = False
                Exit Sub
            Else

                Dim cmd As New OleDbCommand("Select * from FeatureMaster where FeatureId=" & cmbFId.Text, cn)
                cn.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                While dr.Read
                    txtFId.Text = dr(0)
                    txtDesc.Text = dr(1)
                End While

                dr.Close()
                cn.Close()
                FindGroupBox.Visible = False
                btnSave.Enabled = False
                btnModify.Enabled = True
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
            For Each obj In ControlGroupBox.Controls
                If TypeOf obj Is TextBox Then
                    If Len(Trim(obj.Text)) = 0 Then
                        MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
                        obj.Focus()
                        Exit Sub
                    End If
                End If
            Next


            Dim cmd As New OleDbCommand("Update FeatureMaster set Description='" & txtDesc.Text & "' where FeatureID=" & cmbFId.Text, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Updated.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()


            Dim o As New FeaturesMaster
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
            For Each obj In ControlGroupBox.Controls
                If TypeOf obj Is TextBox Then
                    If Len(Trim(obj.Text)) = 0 Then
                        MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
                        obj.Focus()
                        Exit Sub
                    End If
                End If
            Next


            Dim cmd As New OleDbCommand("Insert into FeatureMaster Values(" & txtFId.Text & ",'" & txtDesc.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Saved.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()


            Dim o As New FeaturesMaster
            o.MdiParent = MainForm.ActiveForm
            o.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

   
End Class