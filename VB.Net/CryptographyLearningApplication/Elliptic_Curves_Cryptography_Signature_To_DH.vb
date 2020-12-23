Imports Sodium
Imports System.Numerics
Public Class Elliptic_Curves_Cryptography_Signature_To_DH
    Private Sub ConvertBTN_Click(sender As Object, e As EventArgs) Handles ConvertBTN.Click
        Dim SignatureKeyPair As KeyPair
        Dim SignaturePublicKeyByte As Byte() = New Byte() {}
        Dim SignaturePrivateKeyByte As Byte() = New Byte() {}
        Dim DiffieHellmanPublicKeyByte As Byte() = New Byte() {}
        Dim DiffieHellmanPrivateKeyByte As Byte() = New Byte() {}
        Dim SignaturePublicKey As BigInteger = 0
        Dim SignaturePrivateKey As BigInteger = 0
        Dim DiffieHellmanPublicKey As BigInteger = 0
        Dim DiffieHellmanPrivateKey As BigInteger = 0
        SignatureKeyPair = PublicKeyAuth.GenerateKeyPair
        SignaturePublicKeyByte = SignatureKeyPair.PublicKey
        SignaturePrivateKeyByte = SignatureKeyPair.PrivateKey
        SignaturePublicKey = New BigInteger(SignaturePublicKeyByte)
        SignaturePrivateKey = New BigInteger(SignaturePrivateKeyByte)
        DiffieHellmanPrivateKeyByte = PublicKeyAuth.ConvertEd25519SecretKeyToCurve25519SecretKey(SignaturePrivateKeyByte)
        DiffieHellmanPublicKeyByte = PublicKeyAuth.ConvertEd25519PublicKeyToCurve25519PublicKey(SignaturePublicKeyByte)
        DiffieHellmanPublicKey = New BigInteger(DiffieHellmanPublicKeyByte)
        DiffieHellmanPrivateKey = New BigInteger(DiffieHellmanPrivateKeyByte)
        SignaturePKTB.Text = SignaturePublicKey.ToString
        SignatureSKTB.Text = SignaturePrivateKey.ToString
        DHPKTB.Text = DiffieHellmanPublicKey.ToString
        DHSKTB.Text = DiffieHellmanPrivateKey.ToString
    End Sub

    Private Sub Elliptic_Curves_Cryptography_Signature_To_DH_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub
End Class