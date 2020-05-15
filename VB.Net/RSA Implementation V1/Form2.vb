Imports System.Security.Cryptography
Imports System.Numerics
Imports System.IO
Imports System.Text
Public Class RSAEncryptDecryptForm
    Private Sub EncryptBTN_Click(sender As Object, e As EventArgs) Handles EncryptBTN.Click
        'This function down here will be using the RSA variables created in the
        'Previous Form
        Dim MyRSACryptoServiceProvider As New RSACryptoServiceProvider(384)
        Dim MyRSAParams As New RSAParameters With {
            .P = RSAVariables.PBytes,
            .Q = RSAVariables.QBytes,
            .Modulus = RSAVariables.ModulusBytes,
            .Exponent = RSAVariables.ExponentBytes,
            .InverseQ = RSAVariables.InverseQBytes,
            .D = RSAVariables.DBytes,
            .DP = RSAVariables.DPBytes,
            .DQ = RSAVariables.DQBytes
        }
        MyRSACryptoServiceProvider.ImportParameters(MyRSAParams)
        Dim Message As String = ""
        Dim MessageByte As Byte()
        Dim EncryptedMessageByte As Byte()
        Dim DecryptedMessageByte As Byte()
        Dim DecryptedMessage As String = ""
        Dim MessageByteStringBuilder As New StringBuilder
        Dim EncryptedMessageByteBuilder As New StringBuilder
        Dim DecryptedMessageByteBuilder As New StringBuilder
        Dim MessageByteLoop As Integer = 0
        Dim EncryptedMessageByteLoop As Integer = 0
        Dim DecryptedMessageByteLoop As Integer = 0
        Message = MessageTB.Text
        MessageByte = Encoding.UTF8.GetBytes(Message)
        EncryptedMessageByte = MyRSACryptoServiceProvider.Encrypt(MessageByte, False)
        DecryptedMessageByte = MyRSACryptoServiceProvider.Decrypt(EncryptedMessageByte, False)
        DecryptedMessage = Encoding.UTF8.GetString(DecryptedMessageByte)
        While MessageByteLoop < MessageByte.Count
            MessageByteStringBuilder.Append(MessageByte(MessageByteLoop).ToString("X"))
            MessageByteLoop += 1
        End While
        While EncryptedMessageByteLoop < EncryptedMessageByte.Count
            EncryptedMessageByteBuilder.Append(EncryptedMessageByte(EncryptedMessageByteLoop).ToString("X"))
            EncryptedMessageByteLoop += 1
        End While
        While DecryptedMessageByteLoop < DecryptedMessageByte.Count
            DecryptedMessageByteBuilder.Append(DecryptedMessageByte(DecryptedMessageByteLoop).ToString("X"))
            DecryptedMessageByteLoop += 1
        End While
        MessageByteArrayTB.Text = MessageByteStringBuilder.ToString
        EncryptedMessageByteArrayTB.Text = EncryptedMessageByteBuilder.ToString
        DecryptedMessageByteArrayTB.Text = DecryptedMessageByteBuilder.ToString
        DecryptedMessageTB.Text = DecryptedMessage
    End Sub

    Private Sub RSAEncryptDecryptForm_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        KeyGenerationForm.Show()
    End Sub
End Class