Imports System.Numerics
Imports Sodium
Public Class Elliptic_Curves_Cryptography_DH_SK_PK
    Private Sub Elliptic_Curves_Cryptography_DH_SK_PK_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub CalculateBTN_Click(sender As Object, e As EventArgs) Handles CalculateBTN.Click
        Dim MyDiffieHellmanKeyPair As KeyPair
        Dim MyDiffieHellmanPublicKeyByte As Byte() = New Byte() {}
        Dim MyDiffieHellmanPrivateKeyByte As Byte() = New Byte() {}
        Dim DiffieHellmanPublicKeyByte As Byte() = New Byte() {}
        Dim DiffieHellmanPrivateKeyByte As Byte() = New Byte() {}
        Dim MyDiffieHellmanPublicKey As BigInteger = 0
        Dim MyDiffieHellmanPrivateKey As BigInteger = 0
        Dim DiffieHellmanPublicKey As BigInteger = 0
        Dim DiffieHellmanPrivateKey As BigInteger = 0
        MyDiffieHellmanKeyPair = PublicKeyBox.GenerateKeyPair()
        MyDiffieHellmanPublicKeyByte = MyDiffieHellmanKeyPair.PublicKey
        MyDiffieHellmanPrivateKeyByte = MyDiffieHellmanKeyPair.PrivateKey
        MyDiffieHellmanPublicKey = New BigInteger(MyDiffieHellmanPublicKeyByte)
        MyDiffieHellmanPrivateKey = New BigInteger(MyDiffieHellmanPrivateKeyByte)
        DiffieHellmanPrivateKeyByte = MyDiffieHellmanKeyPair.PrivateKey
        DiffieHellmanPrivateKey = New BigInteger(DiffieHellmanPrivateKeyByte)
        DiffieHellmanPublicKeyByte = ScalarMult.Base(DiffieHellmanPrivateKeyByte)
        DiffieHellmanPublicKey = New BigInteger(DiffieHellmanPublicKeyByte)
        ODHPKTB.Text = MyDiffieHellmanPublicKey.ToString
        ODHSKTB.Text = MyDiffieHellmanPrivateKey.ToString
        DHPKTB.Text = DiffieHellmanPublicKey.ToString
        DHSKTB.Text = DiffieHellmanPrivateKey.ToString
    End Sub
End Class