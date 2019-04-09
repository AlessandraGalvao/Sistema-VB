Imports System.Data.SqlClient
Public Class F_login


    Private Sub F_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conectar = New SqlConnection
        conectar.ConnectionString = cnn
    End Sub

    Private Sub bnt_sair_Click(sender As Object, e As EventArgs) Handles bnt_sair.Click
        If MsgBox("Deseja sair", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            End
        Else

        End If

    End Sub
    Private Sub TB_senha_Validated(sender As Object, e As EventArgs)
        If tb_usuario.Text = "" Or tb_senha.Text = "" Then
            lb_login.Text = "Insira um usuário e uma senha"
            tb_usuario.Focus()
            Exit Sub
        End If

        sql = "select * from login where usuario="
        sql += "'" & tb_usuario.Text & "'and senha="
        sql += "'" & tb_senha.Text & "'"
    End Sub

End Class
