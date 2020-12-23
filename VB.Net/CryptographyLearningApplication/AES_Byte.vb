Imports System.Numerics
Imports System.Text
Imports System.Security.Cryptography
Imports System.IO
Public Class AES_Byte
    Private Sub AES_Byte_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim DataString As String = ""
        Dim DataByte As Byte() = New Byte() {}
        Dim DataBigInt As BigInteger = 0
        Dim EncryptedDataByte As Byte() = New Byte() {}
        Dim EncryptedDataBigInt As BigInteger = 0
        Dim DecryptedDataByte As Byte() = New Byte() {}
        Dim DecryptedDataBigInt As BigInteger = 0
        Dim DecryptedText As String = ""
        Dim MyAES As Aes = Aes.Create
        DataString = DataTB.Text
        If DataString <> "" Then
            DataByte = Encoding.UTF8.GetBytes(DataString)
            DataBigInt = New BigInteger(DataByte)
            DataBigIntTB.Text = DataBigInt.ToString
            DataHexaTB.Text = DataBigInt.ToString("X")
            EncryptedDataByte = EncryptBytes(DataByte, MyAES.Key, MyAES.IV)
            EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
            DecryptedDataByte = DecryptBytes(EncryptedDataByte, MyAES.Key, MyAES.IV)
            DecryptedDataBigInt = New BigInteger(DecryptedDataByte)
            DecryptedText = Encoding.UTF8.GetString(DecryptedDataByte)
            EncryptedDataHexaTB.Text = EncryptedDataBigInt.ToString("X")
            EncryptedDataBigIntTB.Text = EncryptedDataBigInt.ToString()
            DecryptedDataBigIntTB.Text = DecryptedDataBigInt.ToString()
            DecryptedDataHexaTB.Text = DecryptedDataBigInt.ToString("X")
            DecryptedDataTB.Text = DecryptedText
        Else
            MessageBox.Show("Please fill in data....")
        End If
    End Sub

    Function PerformCryptography(ByVal data As Byte(), ByVal cryptoTransform As ICryptoTransform) As Byte()
        Using ms As New MemoryStream()
            Using cryptoStream As New CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write)
                cryptoStream.Write(data, 0, data.Length)
                cryptoStream.FlushFinalBlock()
                Return ms.ToArray
            End Using
        End Using
    End Function

    Function EncryptBytes(ByVal data As Byte(), ByVal key As Byte(), ByVal iv As Byte()) As Byte()
        Using AESObject As Aes = Aes.Create()
            AESObject.Key = key
            AESObject.IV = iv
            AESObject.Mode = CipherMode.CBC
            AESObject.Padding = PaddingMode.PKCS7
            Using encryptor As ICryptoTransform = AESObject.CreateEncryptor(AESObject.Key, AESObject.IV)
                Return PerformCryptography(data, encryptor)
            End Using
        End Using
    End Function

    Function DecryptBytes(ByVal data As Byte(), ByVal key As Byte(), ByVal iv As Byte()) As Byte()
        Using AESObject As Aes = Aes.Create()
            AESObject.Key = key
            AESObject.IV = iv
            AESObject.Mode = CipherMode.CBC
            AESObject.Padding = PaddingMode.PKCS7
            Using encryptor As ICryptoTransform = AESObject.CreateDecryptor(AESObject.Key, AESObject.IV)
                Return PerformCryptography(data, encryptor)
            End Using
        End Using
    End Function

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("This approach allows people to encrypt the data and decrypt the data in their array byte form..")
        MessageBox.Show("It's really useful if you want to perform layered AES encryption")
        MessageBox.Show("There're 2 recommended mode for AES cipher mode.. , one is CBC and the other one is CTR")
        MessageBox.Show("You should be avoiding ECB at all costs as it is very simple for one to do so with its own benefits, but turns out to be horribly insecure..")
        MessageBox.Show("CBC and CTR is all good but if they lack of something like authentication on the cipher/encrypted output, there are possible attacks that could be run on it....")
        MessageBox.Show("Padding mode for both CBC and CTR generally uses PKCS7...")
        MessageBox.Show("Symmetric encryption/decryption if you have questions.., you can search for forums out there... to get the standard approach..")
    End Sub
End Class