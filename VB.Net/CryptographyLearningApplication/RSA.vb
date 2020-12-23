Imports System.Text
Imports System.Numerics
Public Class RSA
    Public List1 As New List(Of BigInteger)
    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim PString As String = ""
        Dim QString As String = ""
        Dim DataString As String = ""
        Dim P As ULong = 0
        Dim Q As ULong = 0
        Dim PBigInt As Org.BouncyCastle.Math.BigInteger
        Dim QBigInt As Org.BouncyCastle.Math.BigInteger
        Dim PSBigInt As BigInteger = 0
        Dim QSBigInt As BigInteger = 0
        Dim ModulusSBigInt As BigInteger = 0
        Dim Modulus1SBigInt As BigInteger = 0
        Dim Modulus2SBigInt As BigInteger = 0
        Dim DSBigInt As BigInteger = 0
        Dim ExponentSBigInt As BigInteger = 0
        Dim DataSBigInt As BigInteger = 0
        Dim EncryptedDataSBigInt As BigInteger = 0
        Dim DecryptedDataSBigInt As BigInteger = 0
        Dim DataByte As Byte() = New Byte() {}
        Dim CheckerBoolean As Boolean = True
        Dim CheckerBoolean2 As Boolean = True
        Dim PrimeBoolean1 As Boolean = True
        Dim PrimeBoolean2 As Boolean = True
        Dim LoopCount As Integer = 0
        PString = PTB.Text
        QString = QTB.Text
        DataString = DataTB.Text
        If PString <> "" And QString <> "" And DataString <> "" Then
            Try
                P = ULong.Parse(PString)
            Catch ex As Exception
                CheckerBoolean = False
            End Try
            Try
                Q = ULong.Parse(QString)
            Catch ex As Exception
                CheckerBoolean2 = False
            End Try
            If CheckerBoolean = True And CheckerBoolean2 = True Then
                PBigInt = New Org.BouncyCastle.Math.BigInteger(PString)
                QBigInt = New Org.BouncyCastle.Math.BigInteger(QString)
                PrimeBoolean1 = PBigInt.IsProbablePrime(1)
                PrimeBoolean2 = QBigInt.IsProbablePrime(1)
                If PrimeBoolean1 = True And PrimeBoolean2 = True Then
                    PSBigInt = BigInteger.Parse(PString)
                    QSBigInt = BigInteger.Parse(QString)
                    ModulusSBigInt = BigInteger.Multiply(PSBigInt, QSBigInt)
                    Modulus1SBigInt = BigInteger.Multiply(BigInteger.Subtract(PSBigInt, 1), BigInteger.Subtract(QSBigInt, 1))
                    Modulus2SBigInt = BigInteger.Add(Modulus1SBigInt, 1)
                    FindCoPrimes(Modulus1SBigInt, ModulusSBigInt)
                    ExponentSBigInt = List1(0)
                    DSBigInt = BigInteger.Parse(FindModInverse(ExponentSBigInt, Modulus1SBigInt))
                    DataByte = Encoding.UTF8.GetBytes(DataString)
                    DataSBigInt = New BigInteger(DataByte)
                    If DataSBigInt.CompareTo(ModulusSBigInt) > 0 Then
                        MessageBox.Show("Data is too big", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        DataBigIntTB.Text = DataSBigInt.ToString
                        EncryptedDataSBigInt = BigInteger.ModPow(DataSBigInt, ExponentSBigInt, ModulusSBigInt)
                        DecryptedDataSBigInt = BigInteger.ModPow(EncryptedDataSBigInt, DSBigInt, ModulusSBigInt)
                        EncryptedDataTB.Text = EncryptedDataSBigInt.ToString
                        DecryptedDataTB.Text = DecryptedDataSBigInt.ToString
                        ModulusTB.Text = ModulusSBigInt.ToString
                        ExponentTB.Text = ExponentSBigInt.ToString
                        DTB.Text = DSBigInt.ToString
                    End If
                Else
                    MessageBox.Show("Please only prime numbers for P and Q", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please only enter numbers for P and Q", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Please fill in P,Q and Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Sub FindCoPrimes(ByVal Number As BigInteger, ByVal Number2 As BigInteger)
        Dim LoopCount As BigInteger = 2
        While LoopCount < Number
            If BigInteger.GreatestCommonDivisor(Number, LoopCount) = 1 And BigInteger.GreatestCommonDivisor(Number2, LoopCount) = 1 Then
                List1.Add(LoopCount)
                Exit While
            End If
            LoopCount += 1
        End While
    End Sub

    Function FindModInverse(ByVal Number1 As BigInteger, ByVal Number2 As BigInteger) As String
        Dim Number1String As String = Number1.ToString
        Dim Number2String As String = Number2.ToString
        Dim Number1BC As New Org.BouncyCastle.Math.BigInteger(Number1String)
        Dim Number2BC As New Org.BouncyCastle.Math.BigInteger(Number2String)
        Dim ModInverseNumber As Org.BouncyCastle.Math.BigInteger
        ModInverseNumber = Number1BC.ModInverse(Number2BC)
        Return ModInverseNumber.ToString
    End Function

    Private Sub RSA_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("Please do not enter prime numbers that are beyond your computer's capabilities")
        MessageBox.Show("The Public Key Pair is (Exponent,Modulus)")
        MessageBox.Show("The Private Key Pair is (D,Modulus)")
        MessageBox.Show("In actual scenarios, RSA modulus is required to be big in order for it to encrypt more data, otherwise people is advised to do their own programming to deal with extra data that exceeds the limit, if you want to encrypt it...")
        MessageBox.Show("Due to this limitation, RSA is not so widely used as its capability of encrypting/decrypting data is very limited")
        MessageBox.Show("The big private key part of D is a reason why RSA is slow in decrypting data")
        MessageBox.Show("Every RSA is based on mathematics like operation to perform, meanwhile AES is based on bits like mathematics operation to perform...")
        MessageBox.Show("If the key size of RSA is bigger, it will take more time for a computer to perform the corresponding calculations.... be it encryption or decryption")
        MessageBox.Show("RSA is widely used to wrap up an symmetric key like AES.... , even if you do used them in a way that's like interleave, the programming languages and the modern version of algorithm won't even be supported...")
        MessageBox.Show("Choosing the 2 prime numbers are a tricky one to begin with as you will need to generate them by using ur computer resources and power which in time ... it's very time consuming")
        MessageBox.Show("Furthermore, in modern RSA CRT(Chinese Remainder Theorem), P and Q must have the property of modular inverse operation with a condition that Q is bigger than P (Inverse Q) in CRT")
    End Sub
End Class
