Option Compare Text
Imports System.Data.OleDb

Public Class ModelFeatureDetail

    Private Sub ModelFeatureDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\M1.jpg")
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\Exit.gif")

            Dim cmd As New OleDbCommand("Select * from ModelMaster", cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                cmbModelID.Items.Add(dr(0))
            End While
            dr.Close()

            Dim cmd1 As New OleDbCommand("Select * from FeatureMaster", cn)
            Dim dr1 As OleDbDataReader = cmd1.ExecuteReader

            While dr1.Read
                cmbFId.Items.Add(dr1(0))
            End While
            dr1.Close()
            cn.Close()

            'Dim da As New OleDbDataAdapter("Select * from ModelFeature", cn)
            'Dim ds As New DataSet
            'da.Fill(ds, "ModelFeature")
            'DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    
    Private Sub cmbModelID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModelID.SelectedIndexChanged
        Try
            Dim cn1 As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & Application.StartupPath & "\DataBase\Mobile.mdb;Persist Security Info=false;")
            cn1.Open()
            Dim cmd As New OleDbCommand("Select * from ModelMaster where ModelID=" & cmbModelID.Text, cn1)
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                Dim str As String = dr(4)
                PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & str)
            End While
            dr.Close()
            cn1.Close()


            Dim da As New OleDbDataAdapter("Select * from ModelFeature where ModelID=" & cmbModelID.Text, cn)
            Dim ds As New DataSet
            da.Fill(ds, "Modelf")
            DataGridView1.DataSource = ds.Tables(0)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub cmbFId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFId.SelectedIndexChanged
        Try
            Dim cn2 As New OleDbConnection("Provider=Microsoft.jet.oledb.4.0;Data Source=" & Application.StartupPath & "\DataBase\Mobile.mdb;Persist Security Info=false;")
            Dim cmd1 As New OleDbCommand("Select * from FeatureMaster where FeatureID=" & cmbFId.Text, cn2)
            cn2.Open()
            Dim dr2 As OleDbDataReader = cmd1.ExecuteReader

            While dr2.Read
                txtFeature.Text = dr2(1)
            End While
            dr2.Close()
            cn2.Close()

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
                If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                    If Len(Trim(obj.Text)) = 0 Then
                        MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
                        obj.Focus()
                        Exit Sub
                    End If
                End If
            Next
            Dim cmd As New OleDbCommand("Insert into ModelFeature Values(" & cmbModelID.Text & "," & cmbFId.Text & ",'" & txtDescrp.Text & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Saved.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()

            Dim o As New ModelFeatureDetail
            o.MdiParent = MainForm.ActiveForm
            o.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub



    'Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
    '    Try



    '        FindGroupBox.Visible = True
    '        Dim cmd As New OleDbCommand("Select * from ModelFeature", cn)
    '        cn.Open()
    '        Dim dr As OleDbDataReader = cmd.ExecuteReader
    '        cmbMId.Items.Clear()


    '        While dr.Read
    '            Dim i As Integer = 0
    '            For i = 0 To cmbMId.Items.Count - 1
    '                If dr(0) = cmbMId.Items(0) Then
    '                    Exit For
    '                Else
    '                    cmbMId.Items.Add(dr(0))
    '                End If
    '            Next
    '        End While


    '        dr.Close()
    '        cn.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub

    'Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
    '    FindGroupBox.Visible = False
    'End Sub

    'Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click
    '    Try
    '        If Len(Trim(cmbMId.Text)) = 0 Then
    '            MsgBox("Please Select Model Id...!", MsgBoxStyle.Exclamation, Me.Text)
    '            FindGroupBox.Visible = False
    '            Exit Sub
    '        Else

    '            Dim cmd As New OleDbCommand("Select * from ModelFeature where ModelId=" & cmbMId.Text, cn)
    '            cn.Open()
    '            Dim dr As OleDbDataReader = cmd.ExecuteReader

    '            While dr.Read
    '                cmbModelID.Text = dr(0)
    '                cmbFId.Items.Add(dr(1))
    '            End While

    '            dr.Close()
    '            cn.Close()


    '            Dim cmd1 As New OleDbCommand("Select * from ModelMaster where ModelID=" & cmbModelID.Text, cn)
    '            cn.Open()

    '            Dim dr1 As OleDbDataReader = cmd1.ExecuteReader

    '            Dim str As String = ""
    '            While dr1.Read
    '                str = dr1(4)
    '            End While
    '            PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & str)
    '            dr1.Close()
    '            cn.Close()

    '            FindGroupBox.Visible = False
    '            btnSave.Enabled = False
    '            btnModify.Enabled = True
    '            btnDelete.Enabled = True
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub

    'Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
    '    Try
    '        Dim obj As Control
    '        For Each obj In Me.Controls
    '            If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
    '                If Len(Trim(obj.Text)) = 0 Then
    '                    MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
    '                    obj.Focus()
    '                    Exit Sub
    '                End If
    '            End If
    '        Next



    '        Dim cmd As New OleDbCommand("Update ModelFeature set Description='" & txtDescrp.Text & "' whete ModelID=" & cmbModelID.Text & " And FeatureID=" & cmbFId.Text, cn)
    '        cn.Open()
    '        cmd.ExecuteNonQuery()
    '        MsgBox("Successfully Record Updated.....!", MsgBoxStyle.Information, Me.Text)
    '        cn.Close()
    '        Me.Close()


    '        Dim o As New ModelFeatureDetail
    '        o.MdiParent = MainForm.ActiveForm
    '        o.Show()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub


    'Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
    '    Try
    '        Dim cmd As New OleDbCommand("Delete from ModelFeature where ModelID=" & cmbModelID.Text & " And FeatureID=" & cmbFId.Text, cn)
    '        cn.Open()
    '        cmd.ExecuteNonQuery()
    '        MsgBox("Successfully Record Deleted....!", MsgBoxStyle.Information, Me.Text)
    '        cn.Close()
    '        Me.Close()

    '        Dim o As New ModelFeatureDetail
    '        o.MdiParent = MainForm.ActiveForm
    '        o.Show()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
    '        If cn.State = ConnectionState.Open Then
    '            cn.Close()
    '        End If
    '    End Try
    'End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class