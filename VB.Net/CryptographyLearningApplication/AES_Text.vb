Imports System.Numerics
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Public Class AES_Text
    Private Sub AES_Text_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim DataString As String = ""
        Dim DataByte As Byte() = New Byte() {}
        Dim DataBigInt As BigInteger = 0
        Dim EncryptedDataByte As Byte() = New Byte() {}
        Dim EncryptedDataBigInt As BigInteger = 0
        Dim DecryptedString As String = ""
        Dim MyAES As Aes = Aes.Create()
        DataString = DataTB.Text
        If DataString <> "" Then
            DataByte = Encoding.UTF8.GetBytes(DataString)
            DataBigInt = New BigInteger(DataByte)
            EncryptedDataByte = EncryptionAes(DataString, MyAES.Key, MyAES.IV)
            EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
            DecryptedString = DecryptionAES(EncryptedDataByte, MyAES.Key, MyAES.IV)
            DataBigIntTB.Text = DataBigInt.ToString
            DataHexaTB.Text = DataBigInt.ToString("X")
            EncryptedDataBigIntTB.Text = EncryptedDataBigInt.ToString
            EncryptedDataHexaTB.Text = EncryptedDataBigInt.ToString("X")
            DecryptedDataTB.Text = DecryptedString
        Else
            MessageBox.Show("Please enter data..")
        End If
    End Sub

    Function EncryptionAes(ByVal DataString As String, ByVal Key As Byte(), ByVal IV As Byte()) As Byte()
        Dim EncryptedByte As Byte() = New Byte() {}
        Using MyAes As Aes = Aes.Create
            MyAes.Key = Key
            MyAes.IV = IV
            Dim encryptor As ICryptoTransform = MyAes.CreateEncryptor(MyAes.Key, MyAes.IV)
            Using msEncrypt As MemoryStream = New MemoryStream
                Using csEncrypt As CryptoStream = New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As StreamWriter = New StreamWriter(csEncrypt)
                        swEncrypt.Write(DataString)
                    End Using
                    EncryptedByte = msEncrypt.ToArray
                End Using
            End Using
        End Using
        Return EncryptedByte
    End Function

    Function DecryptionAES(ByVal EncryptedByte As Byte(), ByVal Key As Byte(), ByVal IV As Byte()) As String
        Dim DecryptedText As String = ""
        Using MyAes As Aes = Aes.Create
            MyAes.Key = Key
            MyAes.IV = IV
            Dim decryptor As ICryptoTransform = MyAes.CreateDecryptor(MyAes.Key, MyAes.IV)
            Using msDecrypt As MemoryStream = New MemoryStream(EncryptedByte)
                Using csDecrypt As CryptoStream = New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)
                    Using srDecrypt As StreamReader = New StreamReader(csDecrypt)
                        DecryptedText = srDecrypt.ReadToEnd
                    End Using
                End Using
            End Using
        End Using
        Return DecryptedText
    End Function
End Class