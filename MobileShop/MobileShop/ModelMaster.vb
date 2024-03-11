Imports System.Data.OleDb
Public Class ModelMaster

    Dim str As String = ""

    Private Sub FeatureMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Me.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\M1.jpg")
            btnExit.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\Exit.gif")

            Dim cmd As New OleDbCommand("Select * from ModelMaster", cn)
            cn.Open()

            Dim dr As OleDbDataReader = cmd.ExecuteReader

            While dr.Read
                txtMId.Text = dr(0)
            End While
            txtMId.Text = Val(txtMId.Text) + 1
            dr.Close()
            cn.Close()

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
            Dim cmd As New OleDbCommand("Select * from ModelMaster", cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            cmbMId.Items.Clear()

            While dr.Read
                cmbMId.Items.Add(dr(0))
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
            If Len(Trim(cmbMId.Text)) = 0 Then
                MsgBox("Please Select Model Id...!", MsgBoxStyle.Exclamation, Me.Text)
                FindGroupBox.Visible = False
                Exit Sub
            Else

                Dim cmd As New OleDbCommand("Select * from ModelMaster where ModelId=" & cmbMId.Text, cn)
                cn.Open()
                Dim dr As OleDbDataReader = cmd.ExecuteReader

                While dr.Read
                    txtMId.Text = dr(0)
                    txtMNumber.Text = dr(1)
                    cmbModel.Text = dr(2)
                    txtMRate.Text = dr(3)
                    str = dr(4)
                End While
                PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & str)
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
                If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                    If Len(Trim(obj.Text)) = 0 Then
                        MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
                        obj.Focus()
                        Exit Sub
                    End If
                End If
            Next



            Dim cmd As New OleDbCommand("Update ModelMaster set ModelNumber='" & txtMNumber.Text & "',Description='" & cmbModel.Text & "',Rate='" & txtMRate.Text & "',Photo='" & str & "' where ModelId=" & txtMId.Text, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Updated.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()


            Dim o As New ModelMaster
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
                If TypeOf obj Is TextBox Or TypeOf obj Is ComboBox Then
                    If Len(Trim(obj.Text)) = 0 Then
                        MsgBox("Plz Insert ....." & obj.Tag, MsgBoxStyle.Exclamation, Me.Text)
                        obj.Focus()
                        Exit Sub
                    End If
                End If
            Next

            If str = Nothing Then
                MsgBox("Please Select Image BY Click to SelectImage Button..!", MsgBoxStyle.Exclamation, Me.Text)
                btnImage.Focus()
                Exit Sub
            End If

            Dim cmd As New OleDbCommand("Insert into ModelMaster Values(" & txtMId.Text & ",'" & txtMNumber.Text & "','" & cmbModel.Text & "'," & txtMRate.Text & ",'" & str & "')", cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Saved.....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()

            Dim o As New ModelMaster
            o.MdiParent = MainForm.ActiveForm
            o.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub btnImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImage.Click
        Try
            Dim obj As New OpenFileDialog
            Dim i As Integer = 0

            i = obj.ShowDialog

            If i = vbOK Then
                str = obj.FileName
            End If

            Dim x As Integer = 0
            Dim c As Integer = 0


            'Following Code For Retriving Only Image File Name Not the Whole Path.

            '====================================================
            For x = Len(str) - 1 To 0 Step -1
                Dim ch As String = str.Substring(x, 1)
                If ch = "\" Then
                    Exit For
                Else
                    c += 1
                End If
            Next

            '=====================================================
            str = Microsoft.VisualBasic.Right(str, c)
            MsgBox(str)

            PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\" & str)


        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim cmd As New OleDbCommand("Delete from ModelMaster where ModelID=" & txtMId.Text, cn)
            cn.Open()
            cmd.ExecuteNonQuery()
            MsgBox("Successfully Record Deleted....!", MsgBoxStyle.Information, Me.Text)
            cn.Close()
            Me.Close()

            Dim o As New ModelMaster
            o.MdiParent = MainForm.ActiveForm
            o.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub txtMRate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMRate.KeyPress
        Dim f As Boolean = False
        f = Number_Validation(e.KeyChar)
        If f = True Then
            e.Handled = True
        End If
    End Sub


End Class