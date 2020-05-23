Imports System.ComponentModel
Imports System.Data.OleDb
Imports System.Drawing.Text

Public Class Form3



    Dim provider As String
    Dim ficheiro As String
    Dim connString As String
    Dim ligacao As OleDbConnection = New OleDbConnection


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\Users.mdb"

        connString = provider
        ligacao.ConnectionString = connString
        ligacao.Open()

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Utilizadores WHERE username = '" &
                                                   txtLogin.Text & "' AND password = '" & txtPasse.Text & "'", ligacao)
        Dim dr As OleDbDataReader = cmd.ExecuteReader

        Dim encontrou As Boolean = False

        Dim strNome As String = ""
        Dim strApelido As String = ""


        While dr.Read
            encontrou = True
            strNome = dr("nome").ToString
            strApelido = dr("apelido").ToString
        End While

        ligacao.Close()

        If encontrou = True Then
            Me.Hide()
            Form1.Show()

        Else
            Dim msg As String = "Não encontrado." & vbNewLine & "Utilizador ou senha incorretos."
            Dim titulo As String = "Aviso!"
            Dim botoes = MessageBoxButtons.OK
            Dim icone = MessageBoxIcon.Exclamation
            MessageBox.Show(msg, titulo, botoes, icone)
        End If



    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLogin.Select()
    End Sub

    Private Sub txtLogin_TextChanged(sender As Object, e As EventArgs) Handles txtLogin.TextChanged

    End Sub

    Private Sub txtPasse_TextChanged(sender As Object, e As EventArgs) Handles txtPasse.TextChanged

    End Sub

    Private Sub Form3_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class