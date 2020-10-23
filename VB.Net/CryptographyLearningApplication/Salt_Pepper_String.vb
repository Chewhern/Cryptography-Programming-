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
        PasswordString = PasswordTB.Text
        If PasswordString <> "" Then
            PasswordByte = Encoding.UTF8.GetBytes(PasswordString)
            PepperString = GenerateUniqueString()
            PepperByte = Encoding.UTF8.GetBytes(PepperString)
            SaltString = GenerateUniqueString()
            While SaltString = PepperString
                SaltString = GenerateUniqueString()
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

    Function GenerateUniqueString() As String
        Dim MySHA512 As SHA512 = SHA512.Create
        Dim MyRandomString As String = GenerateRandomString()
        Dim MyRandomStringByte As Byte() = New Byte() {}
        Dim MyUniqueStringByte As Byte() = New Byte() {}
        Dim LoopCount As Integer = 0
        Dim MyStringBuilder As StringBuilder = New StringBuilder()
        MyRandomStringByte = Encoding.UTF8.GetBytes(MyRandomString)
        MyUniqueStringByte = MySHA512.ComputeHash(MyRandomStringByte)
        MyUniqueStringByte = MySHA512.ComputeHash(MyUniqueStringByte)
        MyUniqueStringByte = MySHA512.ComputeHash(MyUniqueStringByte)
        MyUniqueStringByte = MySHA512.ComputeHash(MyUniqueStringByte)
        While LoopCount < MyUniqueStringByte.Length
            If MyUniqueStringByte(LoopCount) >= 33 And MyUniqueStringByte(LoopCount) <= 47 And MyUniqueStringByte(LoopCount) <> 34 And MyUniqueStringByte(LoopCount) <> 39 And MyUniqueStringByte(LoopCount) <> 45 Then
                MyStringBuilder.Append(Chr(MyUniqueStringByte(LoopCount)))
            ElseIf MyUniqueStringByte(LoopCount) >= 48 And MyUniqueStringByte(LoopCount) <= 57 Then
                MyStringBuilder.Append(Chr(MyUniqueStringByte(LoopCount)))
            ElseIf MyUniqueStringByte(LoopCount) >= 60 And MyUniqueStringByte(LoopCount) <= 63 And MyUniqueStringByte(LoopCount) <> 60 And MyUniqueStringByte(LoopCount) <> 62 Then
                MyStringBuilder.Append(Chr(MyUniqueStringByte(LoopCount)))
            ElseIf MyUniqueStringByte(LoopCount) >= 65 And MyUniqueStringByte(LoopCount) <= 90 Then
                MyStringBuilder.Append(Chr(MyUniqueStringByte(LoopCount)))
            ElseIf MyUniqueStringByte(LoopCount) >= 91 And MyUniqueStringByte(LoopCount) <= 95 Then
                MyStringBuilder.Append(Chr(MyUniqueStringByte(LoopCount)))
            ElseIf MyUniqueStringByte(LoopCount) >= 97 And MyUniqueStringByte(LoopCount) <= 122 Then
                MyStringBuilder.Append(Chr(MyUniqueStringByte(LoopCount)))
            ElseIf MyUniqueStringByte(LoopCount) >= 123 And MyUniqueStringByte(LoopCount) <= 126 Then
                MyStringBuilder.Append(Chr(MyUniqueStringByte(LoopCount)))
            End If
            LoopCount += 1
        End While
        If MyStringBuilder.ToString <> "" Then
            Return MyStringBuilder.ToString
        Else
            Return ""
        End If
    End Function

    Function GenerateRandomString() As String
        Dim RandomString As String = ""
        Dim LoopCount As Integer = 1
        Dim RandomNumber As Integer = 0
        Dim MyStringBuilder As StringBuilder = New StringBuilder
        While LoopCount <= 240
            If LoopCount Mod 3 = 0 Then
                RandomNumber = RandomNumbersGenerator(3)
                MyStringBuilder.Append(Chr(RandomNumber))
            ElseIf LoopCount Mod 2 = 0 Then
                RandomNumber = RandomNumbersGenerator(2)
                MyStringBuilder.Append(Chr(RandomNumber))
            Else
                RandomNumber = RandomNumbersGenerator(1)
                MyStringBuilder.Append(Chr(RandomNumber))
            End If
            LoopCount += 1
        End While
        RandomString = MyStringBuilder.ToString
        Return RandomString
    End Function

    Function RandomNumbersGenerator(ByVal Code As Integer) As Integer
        Dim MyRandomClass As Random = New Random
        Dim RandomNumber As Integer = 0
        If Code = 1 Then
            RandomNumber = MyRandomClass.Next(48, 57)
        ElseIf Code = 2 Then
            RandomNumber = MyRandomClass.Next(65, 90)
        ElseIf Code = 3 Then
            RandomNumber = MyRandomClass.Next(97, 122)
        End If
        Return RandomNumber
    End Function
End Class