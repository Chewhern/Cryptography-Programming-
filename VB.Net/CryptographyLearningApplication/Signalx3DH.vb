Imports System.Numerics
Imports Sodium
Imports System.Text

Public Class Signalx3DH
    Private Sub CalculateBTN_Click(sender As Object, e As EventArgs) Handles CalculateBTN.Click
        Dim AliceIdentityKey As KeyPair = PublicKeyBox.GenerateKeyPair()
        Dim BobSignedPreKey As KeyPair = PublicKeyBox.GenerateKeyPair()
        'First 2 Key Pair Required to Do DH
        Dim BobIdentityKey As KeyPair = PublicKeyBox.GenerateKeyPair()
        Dim AliceEphemeralKey As KeyPair = PublicKeyBox.GenerateKeyPair()
        '3rd and 4th Key Pair Required to Do DH
        '4th Key Pair and 2nd Key Pair Required to Do DH
        Dim BobOneTimePreKey As KeyPair = PublicKeyBox.GenerateKeyPair()
        '4th Key Pair and 5th Key Pair Required to Do DH
        Dim AliceFirstSharedSecret As Byte() = ScalarMult.Mult(AliceIdentityKey.PrivateKey, BobSignedPreKey.PublicKey)
        Dim AliceFirstSharedSecretBigInt As BigInteger = New BigInteger(AliceFirstSharedSecret)
        Dim BobFirstSharedSecret As Byte() = ScalarMult.Mult(BobSignedPreKey.PrivateKey, AliceIdentityKey.PublicKey)
        Dim BobFirstSharedSecretBigInt As BigInteger = New BigInteger(BobFirstSharedSecret)
        Dim AliceSecondSharedSecret As Byte() = ScalarMult.Mult(AliceEphemeralKey.PrivateKey, BobIdentityKey.PublicKey)
        Dim AliceSecondSharedSecretBigInt As BigInteger = New BigInteger(AliceSecondSharedSecret)
        Dim BobSecondSharedSecret As Byte() = ScalarMult.Mult(BobIdentityKey.PrivateKey, AliceEphemeralKey.PublicKey)
        Dim BobSecondSharedSecretBigInt As BigInteger = New BigInteger(BobSecondSharedSecret)
        Dim AliceThirdSharedSecret As Byte() = ScalarMult.Mult(AliceEphemeralKey.PrivateKey, BobSignedPreKey.PublicKey)
        Dim AliceThirdSharedSecretBigInt As BigInteger = New BigInteger(AliceThirdSharedSecret)
        Dim BobThirdSharedSecret As Byte() = ScalarMult.Mult(BobSignedPreKey.PrivateKey, AliceEphemeralKey.PublicKey)
        Dim BobThirdSharedSecretBigInt As BigInteger = New BigInteger(BobThirdSharedSecret)
        Dim AliceFourthSharedSecret As Byte() = ScalarMult.Mult(AliceEphemeralKey.PrivateKey, BobOneTimePreKey.PublicKey)
        Dim AliceFourthSharedSecretBigInt As BigInteger = New BigInteger(AliceFourthSharedSecret)
        Dim BobFourthSharedSecret As Byte() = ScalarMult.Mult(BobOneTimePreKey.PrivateKey, AliceEphemeralKey.PublicKey)
        Dim BobFourthSharedSecretBigInt As BigInteger = New BigInteger(BobFourthSharedSecret)
        Dim SaltByte As Byte() = PasswordHash.ArgonGenerateSalt
        Dim OutPutLength As Long = 32
        Dim AliceConcatSharedSecret As Byte() = AliceFirstSharedSecret.Concat(AliceSecondSharedSecret).Concat(AliceThirdSharedSecret).Concat(AliceFourthSharedSecret).ToArray
        Dim BobConcatSharedSecret As Byte() = BobFirstSharedSecret.Concat(BobSecondSharedSecret).Concat(BobThirdSharedSecret).Concat(BobFourthSharedSecret).ToArray
        Dim AliceMasterSecret As Byte() = PasswordHash.ArgonHashBinary(AliceConcatSharedSecret, SaltByte, PasswordHash.StrengthArgon.Moderate, OutPutLength)
        Dim BobMasterSecret As Byte() = PasswordHash.ArgonHashBinary(BobConcatSharedSecret, SaltByte, PasswordHash.StrengthArgon.Moderate, OutPutLength)
        Dim AliceMasterSecretBigInt As BigInteger = New BigInteger(AliceMasterSecret)
        Dim BobMasterSecretBigInt As BigInteger = New BigInteger(BobMasterSecret)
        AliceDHSession1TB.Text = AliceFirstSharedSecretBigInt.ToString
        AliceDHSession2TB.Text = AliceSecondSharedSecretBigInt.ToString
        AliceDHSession3TB.Text = AliceThirdSharedSecretBigInt.ToString
        AliceDHSession4TB.Text = AliceFourthSharedSecretBigInt.ToString
        BobDHSession1TB.Text = BobFirstSharedSecretBigInt.ToString
        BobDHSession2TB.Text = BobSecondSharedSecretBigInt.ToString
        BobDHSession3TB.Text = BobThirdSharedSecretBigInt.ToString
        BobDHSession4TB.Text = BobFourthSharedSecretBigInt.ToString
        AliceMasterSecretTB.Text = AliceMasterSecretBigInt.ToString
        BobMasterSecretTB.Text = BobMasterSecretBigInt.ToString
    End Sub

    Private Sub Signalx3DH_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub
End Class