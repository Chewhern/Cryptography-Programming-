Imports Sodium
Imports Sodium.SodiumCore
Imports System.Numerics
Public Class Random_Pass_Generator
    Private Sub Random_Pass_Generator_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub GenerateBTN_Click(sender As Object, e As EventArgs) Handles GenerateBTN.Click
        Dim LengthString As String = ""
        Dim Length As Integer = 0
        Dim PasswordByte As Byte() = New Byte() {}
        Dim PasswordString As String = ""
        Dim PasswordBigInt As BigInteger = 0
        LengthString = PasswordBytesLengthTB.Text
        If LengthString <> "" Then
            Try
                Length = Integer.Parse(LengthString)
                If Length < 0 Then
                    MessageBox.Show("Please enter positive numbers...")
                Else
                    If Length >= 32 Then
                        PasswordByte = GetRandomBytes(Length)
                        PasswordString = Convert.ToBase64String(PasswordByte)
                        PasswordBigInt = New BigInteger(PasswordByte)
                        PasswordBase64TB.Text = PasswordString
                        PasswordHexaTB.Text = PasswordBigInt.ToString("X")
                        PasswordBigIntTB.Text = PasswordBigInt.ToString
                    Else
                        MessageBox.Show("Please enter number bigger or equal to 32")
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Please enter numbers..")
            End Try
        Else
            MessageBox.Show("Please enter something..")
        End If
    End Sub
End Class