Public Class Random_Pass_Generator_System_String
    Private Sub GenPassBTN_Click(sender As Object, e As EventArgs) Handles GenPassBTN.Click
        Dim MinimumPasswordLength As UInteger
        Dim ActualPasswordLength As UInteger
        Dim OriginalPassword As String = Nothing
        Dim ProcessedPassword As String = Nothing
        Dim RandomPasswordGeneratorStringClass As RandomPasswordGeneratorString = New RandomPasswordGeneratorString
        Try
            MinimumPasswordLength = UInteger.Parse(PasswordLengthTB.Text)
            OriginalPassword = RandomPasswordGeneratorStringClass.GenerateMinimumAmountOfUniqueString(MinimumPasswordLength)
        Catch ex As Exception
            MessageBox.Show("Please enter positive whole number or enter whole number")
        End Try
        Try
            ActualPasswordLength = UInteger.Parse(PasswordActualLengthTB.Text)
            If IsNothing(OriginalPassword) = False Then
                ProcessedPassword = OriginalPassword.Substring(0, ActualPasswordLength)
                PasswordBTTB.Text = OriginalPassword
                PasswordATTB.Text = ProcessedPassword
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter positive whole number or enter whole number")
        End Try
    End Sub

    Private Sub Random_Pass_Generator_System_String_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub
End Class