Imports System.Numerics
Imports System.Text
Imports System.Security.Cryptography
Public Class Salt_Pepper_String
    Private Sub HashBTN_Click(sender As Object, e As EventArgs) Handles HashBTN.Click
        Dim PasswordString As String = ""
        Dim PasswordByte As Byte() = New Byte() {}
        Dim PepperString As String = ""
        Dim PepperByte As Byte() = New Byte() {}
        Dim SaltString As String = ""
        Dim SaltByte As Byte() = New Byte() {}
        Dim HashedPasswordByte As Byte() = New Byte() {}
        Dim HashedPasswordBigInt As BigInteger = 0
        Dim MySHA512 As SHA512 = SHA512.Create
        Dim PasswordGeneratorClass As RandomPasswordGeneratorString = New RandomPasswordGeneratorString()
        PasswordString = PasswordTB.Text
        If PasswordString <> "" Then
            PasswordByte = Encoding.UTF8.GetBytes(PasswordString)
            PepperString = PasswordGeneratorClass.GenerateUniqueString
            PepperByte = Encoding.UTF8.GetBytes(PepperString)
            SaltString = PasswordGeneratorClass.GenerateUniqueString()
            While SaltString = PepperString
                SaltString = PasswordGeneratorClass.GenerateUniqueString()
            End While
            SaltByte = Encoding.UTF8.GetBytes(SaltString)
            HashedPasswordByte = MySHA512.ComputeHash(PasswordByte.Concat(SaltByte).Concat(PepperByte).ToArray)
            HashedPasswordBigInt = New BigInteger(HashedPasswordByte)
            PepperTB.Text = PepperString
            SaltTB.Text = SaltString
            PasswordHashedBigIntTB.Text = HashedPasswordBigInt.ToString
            PasswordHashedHexaTB.Text = HashedPasswordBigInt.ToString("X")
        Else
            MessageBox.Show("Please enter your password")
        End If
    End Sub

    Private Sub Salt_Pepper_String_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub
End Class