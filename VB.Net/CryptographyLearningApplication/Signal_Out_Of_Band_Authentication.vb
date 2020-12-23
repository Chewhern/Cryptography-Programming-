Imports System.Numerics
Imports Sodium
Public Class Signal_Out_Of_Band_Authentication
    Private Sub Signal_Out_Of_Band_Authentication_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub CreateBTN_Click(sender As Object, e As EventArgs) Handles CreateBTN.Click
        Dim MyKeyPair As KeyPair = PublicKeyBox.GenerateKeyPair
        Dim OtherKeyPair As KeyPair = PublicKeyBox.GenerateKeyPair
        Dim MyPublicKeyByte As Byte() = New Byte() {}
        Dim OtherPublicKeyByte As Byte() = New Byte() {}
        Dim CombinedByte As Byte() = New Byte() {}
        Dim MutualFingerPrintByte As Byte() = New Byte() {}
        Dim MutualFingerPrintBigInt As BigInteger = 0
        Dim MyPublicKeyBigInt As BigInteger = 0
        Dim OtherPublicKeyBigInt As BigInteger = 0
        MyPublicKeyByte = MyKeyPair.PublicKey
        MyPublicKeyBigInt = New BigInteger(MyPublicKeyByte)
        OtherPublicKeyByte = OtherKeyPair.PublicKey
        OtherPublicKeyBigInt = New BigInteger(OtherPublicKeyByte)
        CombinedByte = MyPublicKeyByte.Concat(OtherPublicKeyByte).ToArray
        MutualFingerPrintByte = GenericHash.Hash(CombinedByte, Nothing, CombinedByte.Length)
        MutualFingerPrintBigInt = New BigInteger(MutualFingerPrintByte)
        MyDiffieHellmanPKTB.Text = MyPublicKeyBigInt.ToString
        OtherDiffieHellmanPKTB.Text = OtherPublicKeyBigInt.ToString
        MutualFingerPrintTB.Text = MutualFingerPrintBigInt.ToString
    End Sub
End Class