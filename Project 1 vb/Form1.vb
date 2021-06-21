Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strName As String = txtName.Text
        Dim strIC As String = txtIC.Text
        Dim category As String
        Dim strState As String


        If Not EmptyData(txtName.Text, txtIC.Text) Then

            Dim stateIC = strIC.Substring(6, 2)

            If stateIC = "09" And "40" Then
                strState = "You are the people of Perlis"


                If rdbB40.Checked Then
                    category = "Congratulation! You will receive RM300"
                ElseIf rdbT20.Checked Then
                    category = "Congratulation! You will receive RM100"
                ElseIf rdbM44.Checked Then
                    category = "Sorry! You are not qualified to apply this program."
                Else
                    category = "Please select the category."
                End If
            Else
                strState = "Sorry! You are not the people of Perlis."

            End If
            lblResult.Text = "Name: " & strName & vbCrLf & vbCrLf & "State: " & strState & vbCrLf & vbCrLf & "Result: " & vbCrLf & category
        Else
            MessageBox.Show("Please enter a valid data!")
        End If
    End Sub

    Private Function EmptyData(strName As String, strIC As String) As Boolean
        Return txtName.Text = "" Or txtIC.Text.Length <> 12
    End Function
End Class
