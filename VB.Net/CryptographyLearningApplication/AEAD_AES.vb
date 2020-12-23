Imports Sodium
Imports System.Text
Imports System.Numerics
Public Class AEAD_AES
    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim DataString As String = ""
        Dim DataByte As Byte() = New Byte() {}
        Dim DataBigInt As BigInteger = 0
        Dim AdditionalDataString As String = ""
        Dim AdditionalDataByte As Byte() = New Byte() {}
        Dim EncryptedDataByte As Byte() = New Byte() {}
        Dim EncryptedDataBigInt As BigInteger = 0
        Dim DecryptedDataByte As Byte() = New Byte() {}
        Dim DecryptedDataBigInt As BigInteger = 0
        Dim DecryptedData As String = ""
        Dim SecretBoxKey As Byte() = New Byte() {}
        Dim SecretBoxNonce As Byte() = New Byte() {}
        DataString = DataTB.Text
        AdditionalDataString = AddDataTB.Text
        If DataString <> "" Then
            DataByte = Encoding.UTF8.GetBytes(DataString)
            DataBigInt = New BigInteger(DataByte)
            SecretBoxKey = SecretBox.GenerateKey
            SecretBoxNonce = SecretAeadChaCha20Poly1305.GenerateNonce
            If AdditionalDataString <> "" Then
                AdditionalDataByte = Encoding.UTF8.GetBytes(AdditionalDataString)
                If AdditionalDataByte.Length <= 16 Then
                    EncryptedDataByte = SecretAeadChaCha20Poly1305.Encrypt(DataByte, SecretBoxNonce, SecretBoxKey, AdditionalDataByte)
                    EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
                    DecryptedDataByte = SecretAeadChaCha20Poly1305.Decrypt(EncryptedDataByte, SecretBoxNonce, SecretBoxKey, AdditionalDataByte)
                    DecryptedDataBigInt = New BigInteger(DecryptedDataByte)
                    DecryptedData = Encoding.UTF8.GetString(DecryptedDataByte)
                Else
                    MessageBox.Show("The additional data is too big.... the additional bytes length can't more than 16 bytes..")
                    EncryptedDataByte = SecretAeadChaCha20Poly1305.Encrypt(DataByte, SecretBoxNonce, SecretBoxKey)
                    EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
                    DecryptedDataByte = SecretAeadChaCha20Poly1305.Decrypt(EncryptedDataByte, SecretBoxNonce, SecretBoxKey)
                    DecryptedDataBigInt = New BigInteger(DecryptedDataByte)
                    DecryptedData = Encoding.UTF8.GetString(DecryptedDataByte)
                End If
            Else
                EncryptedDataByte = SecretAeadChaCha20Poly1305.Encrypt(DataByte, SecretBoxNonce, SecretBoxKey)
                EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
                DecryptedDataByte = SecretAeadChaCha20Poly1305.Decrypt(EncryptedDataByte, SecretBoxNonce, SecretBoxKey)
                DecryptedDataBigInt = New BigInteger(DecryptedDataByte)
                DecryptedData = Encoding.UTF8.GetString(DecryptedDataByte)
            End If
            EncryptedDataBigIntTB.Text = EncryptedDataBigInt.ToString
            EncryptedDataHexaTB.Text = EncryptedDataBigInt.ToString("X")
            DecryptedDataBigIntTB.Text = DecryptedDataBigInt.ToString
            DecryptedDataHexaTB.Text = DecryptedDataBigInt.ToString("X")
            DataBigIntTB.Text = DataBigInt.ToString
            DataHexaTB.Text = DataBigInt.ToString("X")
            DecryptedDataTB.Text = DecryptedData
        Else
            MessageBox.Show("Please enter data..")
        End If
    End Sub

    Private Sub AEAD_AES_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub
End Class