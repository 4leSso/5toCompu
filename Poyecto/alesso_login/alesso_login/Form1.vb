Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class Form1
    Dim con As New SqlConnection(My.Settings.Coneccion)
    Dim mensaje, sentencia As String

    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Dim da As New SqlDataAdapter("select * from Usuarios Where Usuario='" & txt_usuario.Text & "' And Contraseña='" & txt_contraseña.Text & "'", con)
        Dim dt As New DataTable
        da.Fill(dt)
        'Validar'
        Dim validar As Integer = dt.Rows.Count
        'If'
        If validar > 0 Then
            Dim tipo As String = dt(0)("Id_Tipo")
            If tipo = 1 Then
                MsgBox("Bienvenido USUARIO")
                Form2.Show()
                Me.Hide()
            Else
                If tipo = 2 Then
                    MsgBox("Bienvenido SECRETARIA")
                    Form4.Show()
                    Me.Hide()
                ElseIf tipo = 3 Then
                    MsgBox("Bienvenido Administrador")
                    Form3.Show()
                    Me.Hide()
                End If
            End If
        End If

        If txt_Contraseña.Text = "" And txt_Usuario.Text = "" Then
            MsgBox("Ingrese Su USUARIO y CONTRASEÑA")
        Else
            If txt_Contraseña.Text = "" Then
                MsgBox("Ingrese su CONTRASEÑA")
            Else
                If txt_Usuario.Text = "" Then
                    MsgBox("Ingrese su USUARIO")
                End If
            End If
        End If
    End Sub

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click

    End Sub

    Sub EjecutarSql(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
