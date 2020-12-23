Imports Sodium
Imports System.Numerics
Imports System.Text
Public Class Elliptic_Curves_Cryptography_Signature
    Private Sub Elliptic_Curves_Cryptography_Signature_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub SignBTN_Click(sender As Object, e As EventArgs) Handles SignBTN.Click
        Dim SignatureKeyPair As KeyPair
        Dim SignaturePublicKeyByte As Byte() = New Byte() {}
        Dim SignaturePrivateKeyByte As Byte() = New Byte() {}
        Dim TextByte As Byte() = New Byte() {}
        Dim SignTextByte As Byte() = New Byte() {}
        Dim VerifyTextByte As Byte() = New Byte() {}
        Dim TextBigInt As BigInteger = 0
        Dim VerifyTextBigInt As BigInteger = 0
        Dim SignTextBigInt As BigInteger = 0
        Dim SignaturePublicKey As BigInteger = 0
        Dim SignaturePrivateKey As BigInteger = 0
        Dim Text As String = ""
        Dim VerifyText As String = ""
        Text = DataTB.Text
        If Text <> "" Then
            SignatureKeyPair = PublicKeyAuth.GenerateKeyPair
            SignaturePublicKeyByte = SignatureKeyPair.PublicKey
            SignaturePrivateKeyByte = SignatureKeyPair.PrivateKey
            TextByte = Encoding.UTF8.GetBytes(Text)
            SignaturePublicKey = New BigInteger(SignaturePublicKeyByte)
            SignaturePrivateKey = New BigInteger(SignaturePrivateKeyByte)
            TextBigInt = New BigInteger(TextByte)
            SignTextByte = PublicKeyAuth.Sign(TextByte, SignaturePrivateKeyByte)
            SignTextBigInt = New BigInteger(SignTextByte)
            VerifyTextByte = PublicKeyAuth.Verify(SignTextByte, SignaturePublicKeyByte)
            VerifyTextBigInt = New BigInteger(VerifyTextByte)
            VerifyText = Encoding.UTF8.GetString(VerifyTextByte)
            SignaturePublicKeyTB.Text = SignaturePublicKey.ToString()
            SignaturePrivateKeyTB.Text = SignaturePrivateKey.ToString()
            DataHexaTB.Text = TextBigInt.ToString("X")
            DataBigIntTB.Text = TextBigInt.ToString()
            DataAfterSignedHexaTB.Text = SignTextBigInt.ToString("X")
            DataAfterSignedBigIntTB.Text = SignTextBigInt.ToString()
            DataVerifySignatureBigIntTB.Text = VerifyTextBigInt.ToString()
            DataVerifySignatureHexaTB.Text = VerifyTextBigInt.ToString("X")
            DataVerifySignatureTB.Text = VerifyText
        End If
    End Sub
End Class