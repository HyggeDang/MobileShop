Option Compare Text
Imports System.Data.OleDb

Public Class Login

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.BackgroundImage = Image.FromFile(Application.StartupPath & "\Images\title.jpg")
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim cmd As New OleDbCommand("Select * from UserInfo where UName='" & TextBox1.Text & "' And UPaswd='" & TextBox2.Text & "'", cn)
            cn.Open()
            Dim dr As OleDbDataReader = cmd.ExecuteReader

            If dr.Read Then
                MsgBox("Wel Come To Mobile Shopy System......!", MsgBoxStyle.Information, Me.Text)
                Dim o As New MainForm
                Me.Hide()
                cn.Close()
                o.Show()
            Else
                MsgBox("Plz Insert Valid UserName And Password......!", MsgBoxStyle.Exclamation, Me.Text)
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox1.Focus()
                cn.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
        End Try
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class
