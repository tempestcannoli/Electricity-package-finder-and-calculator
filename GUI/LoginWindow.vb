﻿Public Class LoginWindow
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        GUIMain.Visible = False
        Dim returnString As PrjDatabaseComponent.ILogin
        returnString = New PrjDatabaseComponent.CDatabase
        Dim sumtin As Boolean
        sumtin = returnString.login(tBoxUsername.Text, tBoxPassword.Text)

        If sumtin = True Then


            GUIMain.Show()
            Me.Visible = False
        End If

    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        SignUp.Show()
    End Sub
End Class