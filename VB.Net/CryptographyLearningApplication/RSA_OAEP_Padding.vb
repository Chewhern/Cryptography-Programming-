Imports System.Numerics
Imports System.Security.Cryptography
Imports System.Text
Public Class RSA_OAEP_Padding

    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim DataString As String = ""
        Dim PaddingString As String = ""
        Dim DataByte As Byte() = New Byte() {}
        Dim EncryptedDataByte As Byte() = New Byte() {}
        Dim DecryptedDataByte As Byte() = New Byte() {}
        Dim EncryptedDataBigInt As BigInteger = 0
        Dim DecryptedDataBigInt As BigInteger = 0
        Dim DataBigInt As BigInteger = 0
        Dim MyRSA As New RSACryptoServiceProvider(2048)
        DataString = DataTB.Text
        PaddingString = PaddingCB.Text
        If DataString <> "" And PaddingString <> "" Then
            DataByte = Encoding.UTF8.GetBytes(DataString)
            DataBigInt = New BigInteger(DataByte)
            If PaddingString.CompareTo("OAEP SHA1") = 0 Then
                If DataByte.Length <= 216 Then
                    EncryptedDataByte = MyRSA.Encrypt(DataByte, RSAEncryptionPadding.OaepSHA1)
                    DecryptedDataByte = MyRSA.Decrypt(EncryptedDataByte, RSAEncryptionPadding.OaepSHA1)
                    EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
                    DecryptedDataBigInt = New BigInteger(DecryptedDataByte)
                    EncryptedDataTB.Text = EncryptedDataBigInt.ToString
                    DecryptedDataTB.Text = Encoding.UTF8.GetString(DecryptedDataByte)
                    DecryptedDataBigIntTB.Text = DecryptedDataBigInt.ToString
                Else
                    MessageBox.Show("Data too big for OAEP SHA1 Encryption Padding")
                End If
            End If
        Else
                MessageBox.Show("Please input data and choose a padding")
        End If
    End Sub

    Private Sub RSA_OAEP_Padding_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("To calculate the space needed for all OAEP padding, you will first need to convert the keypair size into bytes")
        MessageBox.Show("For example, 2048 bits keypair size is equal to 256 bytes")
        MessageBox.Show("SHA1 will produce 160 bits of output given any data you feed into it which is equivalent to 20 bytes")
        MessageBox.Show("SHA256 will produce 256 bits of output given any data you feed into it which is equivalent to 32 bytes")
        MessageBox.Show("SHA384 will produce 384 bits of output given any data you feed into it which is equivalent to 48 bytes")
        MessageBox.Show("SHA512 will produce 512 bits of output given any data you feed into it which is equivalent to 64 bytes")
        MessageBox.Show("You will need to take the hashing output bytes of the SHA family multiply by 2")
        MessageBox.Show("For example SHA1 produce 20 bytes output, you multiply the 20 bytes by 2 , you will get 40 bytes")
        MessageBox.Show("The same goes for other SHA hashing family..")
        MessageBox.Show("Once you are done with it.., take the keypair size bytes amount subtract by the amount of hash bytes after multiply by 2")
        MessageBox.Show("For example 256 bytes - 40 bytes = 216 bytes")
        MessageBox.Show("For example 256 bytes - 64 bytes = 192 bytes")
        MessageBox.Show("For example 256 bytes - 96 bytes = 160 bytes")
        MessageBox.Show("For example 256 bytes - 128 bytes = 128 bytes")
        MessageBox.Show("After calculating all these maximum size for the data with the corresponding padding, you can then develop with fewer errors when involving with RSA cryptographic system...")
    End Sub
End Class