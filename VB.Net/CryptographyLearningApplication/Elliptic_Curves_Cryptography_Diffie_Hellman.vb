Imports System.Numerics
Imports Sodium
Public Class Elliptic_Curves_Cryptography_Diffie_Hellman
    Private Sub CalculateBTN_Click(sender As Object, e As EventArgs) Handles CalculateBTN.Click
        Dim MyKeyPair As KeyPair
        Dim OtherKeyPair As KeyPair
        Dim MyPublicKeyByte As Byte()
        Dim MyPrivateKeyByte As Byte()
        Dim MyPublicKey As BigInteger = 0
        Dim MyPrivateKey As BigInteger = 0
        Dim OtherPublicKeyByte As Byte()
        Dim OtherPrivateKeyByte As Byte()
        Dim OtherPublicKey As BigInteger = 0
        Dim OtherPrivateKey As BigInteger = 0
        Dim MySharedSecretByte As Byte()
        Dim MySharedSecret As BigInteger = 0
        Dim OtherSharedSecretByte As Byte()
        Dim OtherSharedSecret As BigInteger = 0
        MyKeyPair = PublicKeyBox.GenerateKeyPair()
        OtherKeyPair = PublicKeyBox.GenerateKeyPair()
        MyPublicKeyByte = MyKeyPair.PublicKey
        MyPrivateKeyByte = MyKeyPair.PrivateKey
        MyPublicKey = New BigInteger(MyPublicKeyByte)
        MyPrivateKey = New BigInteger(MyPrivateKeyByte)
        OtherPublicKeyByte = OtherKeyPair.PublicKey
        OtherPrivateKeyByte = OtherKeyPair.PrivateKey
        OtherPublicKey = New BigInteger(OtherPublicKeyByte)
        OtherPrivateKey = New BigInteger(OtherPrivateKeyByte)
        MySharedSecretByte = ScalarMult.Mult(MyPrivateKeyByte, OtherPublicKeyByte)
        MySharedSecret = New BigInteger(MySharedSecretByte)
        OtherSharedSecretByte = ScalarMult.Mult(OtherPrivateKeyByte, MyPublicKeyByte)
        OtherSharedSecret = New BigInteger(OtherSharedSecretByte)
        YourPKTB.Text = MyPublicKey.ToString
        YourSKTB.Text = MyPrivateKey.ToString
        OtherPeoplePKTB.Text = OtherPublicKey.ToString
        OtherPeopleSKTB.Text = OtherPrivateKey.ToString
        YourSharedSecretTB.Text = MySharedSecret.ToString
        OtherPeopleSharedSecretTB.Text = OtherSharedSecret.ToString
    End Sub

    Private Sub Elliptic_Curves_Cryptography_Diffie_Hellman_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub
End Class