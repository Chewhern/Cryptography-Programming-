Imports Sodium
Imports System.Text
Imports System.Numerics
Public Class AE_AES
    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim DataString As String = ""
        Dim DataByte As Byte() = New Byte() {}
        Dim DataBigInt As BigInteger = 0
        Dim EncryptedDataByte As Byte() = New Byte() {}
        Dim EncryptedDataBigInt As BigInteger = 0
        Dim DecryptedDataByte As Byte() = New Byte() {}
        Dim DecryptedDataBigInt As BigInteger = 0
        Dim DecryptedString As String = ""
        Dim SecretBoxKey As Byte() = New Byte() {}
        Dim SecretBoxNounce As Byte() = New Byte() {}
        DataString = DataTB.Text
        If DataString <> "" Then
            DataByte = Encoding.UTF8.GetBytes(DataString)
            DataBigInt = New BigInteger(DataByte)
            SecretBoxKey = SecretBox.GenerateKey
            SecretBoxNounce = SecretBox.GenerateNonce
            EncryptedDataByte = SecretBox.Create(DataByte, SecretBoxNounce, SecretBoxKey)
            EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
            DecryptedDataByte = SecretBox.Open(EncryptedDataByte, SecretBoxNounce, SecretBoxKey)
            DecryptedDataBigInt = New BigInteger(DecryptedDataByte)
            DecryptedString = Encoding.UTF8.GetString(DecryptedDataByte)
            DataHexaTB.Text = DataBigInt.ToString("X")
            DataBigIntTB.Text = DataBigInt.ToString
            EncryptedDataBigIntTB.Text = EncryptedDataBigInt.ToString
            EncryptedDataHexaTB.Text = EncryptedDataBigInt.ToString("X")
            DecryptedDataHexaTB.Text = DecryptedDataBigInt.ToString("X")
            DecryptedDataBigIntTB.Text = DecryptedDataBigInt.ToString
            DecryptedDataTB.Text = DecryptedString
        Else
            MessageBox.Show("You need to enter a data....")
        End If
    End Sub

    Private Sub AE_AES_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("Authenticated encryption refers to when u encrypt a data, you put a removable seal that an attacker can't change the encrypted data's content unless he/she has your key")
        MessageBox.Show("This enables you to encrypt data without worrying that your data has been tampered by unwanted people")
        MessageBox.Show("It also enables the intended recipient to know it's from you and no one else could have done it....")
    End Sub
End Class