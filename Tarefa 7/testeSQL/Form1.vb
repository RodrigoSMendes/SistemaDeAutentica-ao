Imports System.ComponentModel

Public Class Form1
    Private Sub UtilizadoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles UtilizadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.UtilizadoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.UsersDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'UsersDataSet.Utilizadores' table. You can move, or remove it, as needed.
        Me.UtilizadoresTableAdapter.Fill(Me.UsersDataSet.Utilizadores)
        BindingNavigatorAddNewItem.Enabled = True
        BindingNavigatorDeleteItem.Enabled = True

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Me.Validate()
        Me.UtilizadoresBindingSource.EndEdit()
        UtilizadoresTableAdapter.Insert(CDec(IDTextBox.Text), UsernameTextBox.Text,
        PasswordTextBox.Text, NomeTextBox.Text, ApelidoTextBox.Text)

        Me.UtilizadoresTableAdapter.Fill(Me.UsersDataSet.Utilizadores)


    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        Me.Validate()
        Me.UtilizadoresBindingSource.EndEdit()

        UtilizadoresTableAdapter.Delete(CDec(IDTextBox.Text), UsernameTextBox.Text,
        PasswordTextBox.Text, NomeTextBox.Text, ApelidoTextBox.Text)

        Me.UtilizadoresTableAdapter.Fill(Me.UsersDataSet.Utilizadores)




    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Application.Exit()
    End Sub
End Class
