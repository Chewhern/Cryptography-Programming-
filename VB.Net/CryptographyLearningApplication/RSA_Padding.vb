Imports System.Security.Cryptography
Imports System.Numerics
Imports System.Text
Public Class RSA_Padding
    Private Sub RSA_Padding_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim MyRSA As New RSACryptoServiceProvider(384)
        Dim Params As New RSAParameters
        Dim DataString As String = ""
        Dim DataByte As Byte() = New Byte() {}
        Dim ModulusByte As Byte() = New Byte() {}
        Dim EncryptedDataByte As Byte() = New Byte() {}
        Dim DecryptedDataByte As Byte() = New Byte() {}
        Dim DataBigInt As BigInteger = 0
        Dim EncryptedDataBigInt As BigInteger = 0
        Dim DecryptedDataBigInt As BigInteger = 0
        Dim ModulusBigInt As BigInteger = 0
        DataString = DataTB.Text
        If DataString <> "" Then
            DataByte = Encoding.UTF8.GetBytes(DataString)
            DataBigInt = New BigInteger(DataByte)
            Params = MyRSA.ExportParameters(True)
            ModulusByte = Params.Modulus
            ModulusBigInt = New BigInteger(ModulusByte)
            If ModulusBigInt.Sign <> 1 Then
                ModulusBigInt = BigInteger.Multiply(ModulusBigInt, -1)
            End If
            If DataBigInt.Sign <> 1 Then
                DataBigInt = BigInteger.Multiply(DataBigInt, -1)
            End If
            If ModulusBigInt.CompareTo(DataBigInt) > 0 Then
                If DataByte.Length <= 37 Then
                    EncryptedDataByte = MyRSA.Encrypt(DataByte, False)
                    EncryptedDataBigInt = New BigInteger(EncryptedDataByte)
                    DecryptedDataByte = MyRSA.Decrypt(EncryptedDataByte, False)
                    DecryptedDataBigInt = New BigInteger(DecryptedDataByte)
                    EncryptedDataTB.Text = EncryptedDataBigInt.ToString
                    DecryptedDataTB.Text = Encoding.UTF8.GetString(DecryptedDataByte)
                    DecryptedDataBigIntTB.Text = DecryptedDataBigInt.ToString
                Else
                    MessageBox.Show("This data is too big for PKCS padding encryption scheme")
                End If
            Else
                MessageBox.Show("Your input data was too big")
            End If
        Else
            MessageBox.Show("Please enter data..")
        End If
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("For modern rsa crt, there're 2 kinds of encryption padding.. , one is OAEP padding, one is PKCS padding")
        MessageBox.Show("Encryption padding is actually kind of removable salt on password hashing....")
        MessageBox.Show("For PKCS padding to calculate the space needed for the padding, you will need to take the modulus size divide by 8 to get the number of bytes it have")
        MessageBox.Show("For example in this case, 384 bit modulus or keypair size, it's equivalent to 48 bytes.. , PKCS padding normally uses 11 bytes..")
        MessageBox.Show("So .. , your maximum allowable data size is 37 bytes")
    End Sub
End Class