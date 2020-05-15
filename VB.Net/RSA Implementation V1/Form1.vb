Imports System.Security.Cryptography
Imports System.Numerics
Imports System.IO
Imports System.Text

Module RSAVariables
    Public P As BigInteger
    Public Q As BigInteger
    Public Modulus As BigInteger
    Public Exponent As BigInteger
    Public D As BigInteger
    Public DP As BigInteger
    Public DQ As BigInteger
    Public InverseQ As BigInteger
    Public PBytes As Byte()
    Public QBytes As Byte()
    Public ModulusBytes As Byte()
    Public ExponentBytes As Byte()
    Public DBytes As Byte()
    Public DPBytes As Byte()
    Public DQBytes As Byte()
    Public InverseQBytes As Byte()
    Public SelectionBoolean As Boolean
    Public PublicPrimeList, PublicPrimeList2 As New List(Of BigInteger)
    Public PublicX As Integer
    Public PublicRandomIndex As Integer
    Sub SetP(ByVal PParams As BigInteger)
        P = PParams
    End Sub
    Sub SetQ(ByVal QParams As BigInteger)
        Q = QParams
    End Sub
    Sub SetModulus(ByVal ModulusParams As BigInteger)
        Modulus = ModulusParams
    End Sub
    Sub SetExponent(ByVal ExponentParams As BigInteger)
        Exponent = ExponentParams
    End Sub
    Sub SetD(ByVal DParams As BigInteger)
        D = DParams
    End Sub
    Sub SetDP(ByVal DPParams As BigInteger)
        DP = DPParams
    End Sub
    Sub SetDQ(ByVal DQParams As BigInteger)
        DQ = DQParams
    End Sub
    Sub SetInverseQ(ByVal InverseQParams As BigInteger)
        InverseQ = InverseQParams
    End Sub
    Sub SetPBytes(ByVal PBytesParams As Byte())
        PBytes = PBytesParams
    End Sub
    Sub SetQBytes(ByVal QBytesParams As Byte())
        QBytes = QBytesParams
    End Sub
    Sub SetModulusBytes(ByVal ModulusBytesParams As Byte())
        ModulusBytes = ModulusBytesParams
    End Sub
    Sub SetExponentBytes(ByVal ExponentBytesParams As Byte())
        ExponentBytes = ExponentBytesParams
    End Sub
    Sub SetDBytes(ByVal DBytesParams As Byte())
        DBytes = DBytesParams
    End Sub
    Sub SetDPBytes(ByVal DPBytesParams As Byte())
        DPBytes = DPBytesParams
    End Sub
    Sub SetDQBytes(ByVal DQBytesParams As Byte())
        DQBytes = DQBytesParams
    End Sub
    Sub SetInverseQBytes(ByVal InverseQBytesParams As Byte())
        InverseQBytes = InverseQBytesParams
    End Sub
End Module
Public Class KeyGenerationForm
    Function ModInverse(ByVal a As BigInteger, ByVal b As BigInteger) As BigInteger

        Dim b0 As BigInteger = b
        Dim t As BigInteger
        Dim q As BigInteger
        Dim x0 As BigInteger = 0
        Dim x1 As BigInteger = 1

        If b = 1 Then Return 1

        While a > 1
            q = BigInteger.Divide(a, b)
            t = b
            b = BigInteger.Remainder(a, b)
            a = t
            t = x0
            x0 = BigInteger.Subtract(x1, BigInteger.Multiply(q, x0))
            x1 = t
        End While

        If x1 < 0 Then x1 += b0
        Return x1

    End Function

    Private Sub GenerateBTN_Click(sender As Object, e As EventArgs) Handles GenerateBTN.Click
        Dim MyRSACryptoServiceProvider As New RSACryptoServiceProvider(384)
        Dim MyRSAParams As New RSAParameters
        Dim Modulus1 As BigInteger
        Dim P As BigInteger
        Dim Q As BigInteger
        Dim Modulus As BigInteger
        Dim Exponent As BigInteger
        Dim D As BigInteger
        Dim DP As BigInteger
        Dim DQ As BigInteger
        Dim InverseQ As BigInteger
        Dim PrimeList, PrimeList2 As New List(Of BigInteger)
        Dim x As Integer = 1
        Dim RandomNumber1, RandomNumber2 As Integer
        Dim Random As New Random
        'Due to RSA is performance taxing and there's no available prime numbers
        'out there, I actually created a list of prime numbers by using
        'BouncyCastle C# API
        'To actually efficiently generate a list of possible RSA Key
        'I will need to generate possible RSA key based on list of data
        'stored in different files
        'Normally I will generate at least 80k amount of prime numbers
        'before using this program to generate RSA. 
        'I generate those 80k amount of prime numbers by letting my laptop
        'does it works which means sitting for a whole day etc by using
        'Beginner level of multithreading (Normal programming won't handle it so well
        'Due to absurd time needed to complete the loop)

        'If you have a list of prime numbers for a specific bit let's say 384 bits
        'You can then change the file source according to the file source destination
        'The file can actually store let's say a part of the complete let's say 384 bits
        'list or full prime numbers for 384 bits(not really possible due to time needed to
        'generate is very long)
        'In your own cases, you can change to whatever supported key size based on
        'the accepted key size provided by Microsoft RSA library
        'The current accepted key size supported by Microsoft was 384 bits to 16384 bits
        'This key size could be changed later on depends on how Microsoft uses it
        Using StreamReader As New StreamReader("G:\PrimeList384P1.txt")
            Dim line As String
            While x <= 80000
                line = StreamReader.ReadLine
                If x >= 1 And x <= 40000 Then
                    PrimeList.Add(BigInteger.Parse(line))
                ElseIf x >= 40001 And x <= 800000 Then
                    PrimeList2.Add(BigInteger.Parse(line))
                End If
                x += 1
            End While
        End Using
        PublicPrimeList = PrimeList
        PublicPrimeList2 = PrimeList2
        RandomNumber1 = Random.Next(0, (PrimeList.Count - 1))
        RandomNumber2 = RandomNumber1
        Q = PrimeList(RandomNumber1)
        P = PrimeList2(RandomNumber2)
        Modulus = P * Q
        Modulus1 = (P - 1) * (Q - 1)
        D = ModInverse(65537, Modulus1)
        DP = BigInteger.Remainder(D, (P - 1))
        DQ = BigInteger.Remainder(D, (Q - 1))
        InverseQ = ModInverse(Q, P)
        x = 0
        If Modulus.ToByteArray.Count <> 48 Or D.ToByteArray.Count <> 48 Or
            DP.ToByteArray.Count <> 24 Or DQ.ToByteArray.Count <> 24 Or
            InverseQ.ToByteArray.Count <> 24 Or
            P.ToByteArray(P.ToByteArray.Count - 1) = 0 Or
            Q.ToByteArray(Q.ToByteArray.Count - 1) = 0 Or
            Modulus.ToByteArray(Modulus.ToByteArray.Count - 1) = 0 Or
            D.ToByteArray(D.ToByteArray.Count - 1) = 0 Or
            DP.ToByteArray(DP.ToByteArray.Count - 1) = 0 Or
            DQ.ToByteArray(DQ.ToByteArray.Count - 1) = 0 Or
            InverseQ.ToByteArray(InverseQ.ToByteArray.Count - 1) = 0 Or
            BigInteger.GreatestCommonDivisor(P, Q) <> 1 Then

            SelectionBoolean = True
            PublicX = x
            While x < 40000
                Q = PrimeList(x)
                P = PrimeList2(x)
                Modulus = P * Q
                Modulus1 = (P - 1) * (Q - 1)
                D = ModInverse(65537, Modulus1)
                DP = BigInteger.Remainder(D, (P - 1))
                DQ = BigInteger.Remainder(D, (Q - 1))
                InverseQ = ModInverse(Q, P)
                If Modulus.ToByteArray.Count = 48 Or D.ToByteArray.Count = 48 Or
                    DP.ToByteArray.Count = 24 Or DQ.ToByteArray.Count = 24 Or
                    InverseQ.ToByteArray.Count = 24 Or
                    P.ToByteArray(P.ToByteArray.Count - 1) <> 0 Or
                    Q.ToByteArray(Q.ToByteArray.Count - 1) <> 0 Or
                    Modulus.ToByteArray(Modulus.ToByteArray.Count - 1) <> 0 Or
                    D.ToByteArray(D.ToByteArray.Count - 1) <> 0 Or
                    DP.ToByteArray(DP.ToByteArray.Count - 1) <> 0 Or
                    DQ.ToByteArray(DQ.ToByteArray.Count - 1) <> 0 Or
                    InverseQ.ToByteArray(InverseQ.ToByteArray.Count - 1) <> 0 Or
                    BigInteger.GreatestCommonDivisor(P, Q) = 1 Then
                    Exit While

                ElseIf x = 39999 Then
                    MessageBox.Show("Not Found")

                End If
                x += 1
            End While
        Else
            SelectionBoolean = False
            PublicRandomIndex = RandomNumber1
        End If
        Exponent = 65537
        RSAVariables.SetP(P)
        RSAVariables.SetQ(Q)
        RSAVariables.SetModulus(Modulus)
        RSAVariables.SetExponent(Exponent)
        RSAVariables.SetD(D)
        RSAVariables.SetDP(DP)
        RSAVariables.SetDQ(DQ)
        RSAVariables.SetInverseQ(InverseQ)
        RSAVariables.SetPBytes(ExportUnsignedBigEndian(P))
        RSAVariables.SetQBytes(ExportUnsignedBigEndian(Q))
        RSAVariables.SetModulusBytes(ExportUnsignedBigEndian(Modulus))
        RSAVariables.SetExponentBytes(ExportUnsignedBigEndian(Exponent))
        RSAVariables.SetDBytes(ExportUnsignedBigEndian(D))
        RSAVariables.SetDPBytes(ExportUnsignedBigEndian(DP))
        RSAVariables.SetDQBytes(ExportUnsignedBigEndian(DQ))
        RSAVariables.SetInverseQBytes(ExportUnsignedBigEndian(InverseQ))
        ExponentTextBox.Text = Exponent.ToString
        DTextBox.Text = D.ToString
        PTextBox.Text = P.ToString
        QTextBox.Text = Q.ToString
        ModulusTextBox.Text = Modulus.ToString
        DPTextBox.Text = DP.ToString
        DQTextBox.Text = DQ.ToString
        InverseQTextBox.Text = InverseQ.ToString
        MyRSAParams.P = ExportUnsignedBigEndian(P)
        MyRSAParams.Q = ExportUnsignedBigEndian(Q)
        MyRSAParams.Modulus = ExportUnsignedBigEndian(Modulus)
        MyRSAParams.Exponent = ExportUnsignedBigEndian(Exponent)
        MyRSAParams.D = ExportUnsignedBigEndian(D)
        MyRSAParams.DP = ExportUnsignedBigEndian(DP)
        MyRSAParams.DQ = ExportUnsignedBigEndian(DQ)
        MyRSAParams.InverseQ = ExportUnsignedBigEndian(InverseQ)
        MyRSACryptoServiceProvider.ImportParameters(MyRSAParams)
    End Sub

    Function RandomNumberGenerator(ByVal List As List(Of BigInteger)) As Integer
        Dim Random As New Random
        Dim RandomInteger As Integer
        RandomInteger = Random.Next(0, List.Count)
        Return RandomInteger
    End Function

    Function ExportUnsignedBigEndian(ByVal val As BigInteger) As Byte()
        Dim export As Byte() = val.ToByteArray()
        Dim ExportLastIndex As Integer = (export.Length) - 1
        If export(ExportLastIndex) = 0 Then
            Array.Resize(Of Byte)(export, ExportLastIndex)
        End If
        Array.Reverse(export)
        Return export
    End Function

    Private Sub TestBTN_Click(sender As Object, e As EventArgs) Handles TestBTN.Click
        'Eventually here you can see the RSA Parameter byte size by calling the
        'Functions as below
        'These functions will aim to give the developer a hint on the size of the
        'correct data format for each RSA Parameter
        'Microsoft .Net Library uses CRT to implement RSA
        'This allows the encryption and decryption of RSA becomes faster
        Dim MyRSACryptoServiceProvider As New RSACryptoServiceProvider(384)
        'The value in the bracket allows the key size from minimum 384 bits
        'to 16384 bits
        Dim MyRSAParams As New RSAParameters
        'For demonstration purposes, we export all the key information (including
        'private key information) if we specifies it as True
        'In actual implementation the Boolean in the value can be either True
        'or False(Not exporting private key information)

        'Eventually you will see tons of numbers stating the count
        'But do remember this count is counting the bytes for you
        'instead of counting it in bits

        'If let's say after you read all of these comments, you still don't know
        'how the RSA works in VB.Net
        'I will then write more "comment" for better explanation
        'or explain in forums etc
        'Given that you give credits to me and don't claim this program/code
        'as yours

        '如果这里有中国的编程员想知道究竟VB.Net的RSA 加解密是如何应用的
        '我可以写这些"Comment" 但前提是你们不可以把这个东西归为你们所有
        '你们得告诉人们这个代码你们究竟从哪拿到的
        '如果做到你们就在GitHub那里做个请求吧
        '如果要求的人过多且还是不明白那么才考虑建个群什么的
        '注:我是海外的华裔/华人
        '同样的如果你是台湾人或者华人或者海外中国人,你也必须得准守我对中国的编程员所设下的条例
        MyRSAParams = MyRSACryptoServiceProvider.ExportParameters(True)
        MessageBox.Show("P Count" = MyRSAParams.P.Count)
        MessageBox.Show("Q Count" = MyRSAParams.Q.Count)
        MessageBox.Show("Modulus Count" = MyRSAParams.Modulus.Count)
        MessageBox.Show("Exponent Count" = MyRSAParams.Exponent.Count)
        MessageBox.Show("D Count" = MyRSAParams.D.Count)
        MessageBox.Show("DP Count" = MyRSAParams.DP.Count)
        MessageBox.Show("DQ Count" = MyRSAParams.DQ.Count)
        MessageBox.Show("InverseQ Count" = MyRSAParams.InverseQ.Count)
    End Sub

    Private Sub EncryptionBTN_Click(sender As Object, e As EventArgs) Handles EncryptionBTN.Click
        Me.Hide()
        RSAEncryptDecryptForm.Show()
    End Sub

    Private Sub GenerateCustomBTN_Click(sender As Object, e As EventArgs) Handles GenerateCustomBTN.Click
        'The functions below will only be required if the generation of key is not 
        'generated randomly and user would like to generate bigger RSA Key
        Dim PreviousModulus As BigInteger = RSAVariables.Modulus
        Dim MyRSACryptoServiceProvider As New RSACryptoServiceProvider(384)
        Dim MyRSAParams As New RSAParameters
        Dim Modulus As BigInteger = 0
        Dim Modulus1 As BigInteger = 0
        Dim P As BigInteger = 0
        Dim Q As BigInteger = 0
        Dim Exponent As BigInteger = 65537
        Dim D As BigInteger = 0
        Dim DP As BigInteger = 0
        Dim DQ As BigInteger = 0
        Dim InverseQ As BigInteger = 0
        Dim PrimeList, PrimeList2 As New List(Of BigInteger)
        Dim x As Integer = 1
        Using StreamReader As New StreamReader("G:\PrimeList384P1.txt")
            Dim line As String
            While x <= 80000
                line = StreamReader.ReadLine
                If x >= 1 And x <= 40000 Then
                    PrimeList.Add(BigInteger.Parse(line))
                ElseIf x >= 40001 And x <= 800000 Then
                    PrimeList2.Add(BigInteger.Parse(line))
                End If
                x += 1
            End While
        End Using
        If SelectionBoolean = True Then
            x = 0
            While x < 40000
                IndexTB.Text = x.ToString
                Q = PrimeList(x)
                P = PrimeList2(x)
                Modulus = P * Q
                Modulus1 = (P - 1) * (Q - 1)
                D = ModInverse(65537, Modulus1)
                DP = BigInteger.Remainder(D, (P - 1))
                DQ = BigInteger.Remainder(D, (Q - 1))
                InverseQ = ModInverse(Q, P)
                If Modulus.ToByteArray.Count = 48 Or D.ToByteArray.Count = 48 Or
                    DP.ToByteArray.Count = 24 Or DQ.ToByteArray.Count = 24 Or
                        InverseQ.ToByteArray.Count = 24 Or
                        P.ToByteArray(P.ToByteArray.Count - 1) <> 0 Or
                        Q.ToByteArray(Q.ToByteArray.Count - 1) <> 0 Or
                        Modulus.ToByteArray(Modulus.ToByteArray.Count - 1) <> 0 Or
                        D.ToByteArray(D.ToByteArray.Count - 1) <> 0 Or
                        DP.ToByteArray(DP.ToByteArray.Count - 1) <> 0 Or
                        DQ.ToByteArray(DQ.ToByteArray.Count - 1) <> 0 Or
                        InverseQ.ToByteArray(InverseQ.ToByteArray.Count - 1) <> 0 Or
                        BigInteger.GreatestCommonDivisor(P, Q) = 1 Then
                    If (Modulus > PreviousModulus) Then
                        PublicX = x
                        Exit While
                    End If

                ElseIf x = 39999 Then
                    MessageBox.Show("Not Found")

                End If
                x += 1
            End While
            RSAVariables.SetP(P)
            RSAVariables.SetQ(Q)
            RSAVariables.SetModulus(Modulus)
            RSAVariables.SetExponent(Exponent)
            RSAVariables.SetD(D)
            RSAVariables.SetDP(DP)
            RSAVariables.SetDQ(DQ)
            RSAVariables.SetInverseQ(InverseQ)
            RSAVariables.SetPBytes(ExportUnsignedBigEndian(P))
            RSAVariables.SetQBytes(ExportUnsignedBigEndian(Q))
            RSAVariables.SetModulusBytes(ExportUnsignedBigEndian(Modulus))
            RSAVariables.SetExponentBytes(ExportUnsignedBigEndian(Exponent))
            RSAVariables.SetDBytes(ExportUnsignedBigEndian(D))
            RSAVariables.SetDPBytes(ExportUnsignedBigEndian(DP))
            RSAVariables.SetDQBytes(ExportUnsignedBigEndian(DQ))
            RSAVariables.SetInverseQBytes(ExportUnsignedBigEndian(InverseQ))
            ExponentTextBox.Text = Exponent.ToString
            DTextBox.Text = D.ToString
            PTextBox.Text = P.ToString
            QTextBox.Text = Q.ToString
            ModulusTextBox.Text = Modulus.ToString
            DPTextBox.Text = DP.ToString
            DQTextBox.Text = DQ.ToString
            InverseQTextBox.Text = InverseQ.ToString
        Else
            MessageBox.Show("It doesn't go through the selection loop, it is still using random index to generate public/private key")
        End If
    End Sub

    Private Sub GenerateSmallerKeyBTN_Click(sender As Object, e As EventArgs) Handles GenerateSmallerKeyBTN.Click
        'The functions below will only be required if the generation of key is not 
        'generated randomly and user would like to generate smaller RSA Key
        Dim PreviousModulus As BigInteger = RSAVariables.Modulus
        Dim MyRSACryptoServiceProvider As New RSACryptoServiceProvider(384)
        Dim MyRSAParams As New RSAParameters
        Dim Modulus As BigInteger = 0
        Dim Modulus1 As BigInteger = 0
        Dim P As BigInteger = 0
        Dim Q As BigInteger = 0
        Dim Exponent As BigInteger = 65537
        Dim D As BigInteger = 0
        Dim DP As BigInteger = 0
        Dim DQ As BigInteger = 0
        Dim InverseQ As BigInteger = 0
        Dim PrimeList, PrimeList2 As New List(Of BigInteger)
        Dim x As Integer = 1
        Using StreamReader As New StreamReader("G:\PrimeList384P1.txt")
            Dim line As String
            While x <= 80000
                line = StreamReader.ReadLine
                If x >= 1 And x <= 40000 Then
                    PrimeList.Add(BigInteger.Parse(line))
                ElseIf x >= 40001 And x <= 800000 Then
                    PrimeList2.Add(BigInteger.Parse(line))
                End If
                x += 1
            End While
        End Using
        If SelectionBoolean = True Then
            x = PublicX
            While x >= 0
                IndexTB.Text = x.ToString
                Q = PrimeList(x)
                P = PrimeList2(x)
                Modulus = P * Q
                Modulus1 = (P - 1) * (Q - 1)
                D = ModInverse(65537, Modulus1)
                DP = BigInteger.Remainder(D, (P - 1))
                DQ = BigInteger.Remainder(D, (Q - 1))
                InverseQ = ModInverse(Q, P)
                If Modulus.ToByteArray.Count = 48 Or D.ToByteArray.Count = 48 Or
                    DP.ToByteArray.Count = 24 Or DQ.ToByteArray.Count = 24 Or
                        InverseQ.ToByteArray.Count = 24 Or
                        P.ToByteArray(P.ToByteArray.Count - 1) <> 0 Or
                        Q.ToByteArray(Q.ToByteArray.Count - 1) <> 0 Or
                        Modulus.ToByteArray(Modulus.ToByteArray.Count - 1) <> 0 Or
                        D.ToByteArray(D.ToByteArray.Count - 1) <> 0 Or
                        DP.ToByteArray(DP.ToByteArray.Count - 1) <> 0 Or
                        DQ.ToByteArray(DQ.ToByteArray.Count - 1) <> 0 Or
                        InverseQ.ToByteArray(InverseQ.ToByteArray.Count - 1) <> 0 Or
                        BigInteger.GreatestCommonDivisor(P, Q) = 1 Then
                    If (Modulus < PreviousModulus) Then
                        Exit While
                        PublicX = x
                    End If

                ElseIf x = 39999 Then
                    MessageBox.Show("Not Found")

                End If
                x -= 1
            End While
            RSAVariables.SetP(P)
            RSAVariables.SetQ(Q)
            RSAVariables.SetModulus(Modulus)
            RSAVariables.SetExponent(Exponent)
            RSAVariables.SetD(D)
            RSAVariables.SetDP(DP)
            RSAVariables.SetDQ(DQ)
            RSAVariables.SetInverseQ(InverseQ)
            RSAVariables.SetPBytes(ExportUnsignedBigEndian(P))
            RSAVariables.SetQBytes(ExportUnsignedBigEndian(Q))
            RSAVariables.SetModulusBytes(ExportUnsignedBigEndian(Modulus))
            RSAVariables.SetExponentBytes(ExportUnsignedBigEndian(Exponent))
            RSAVariables.SetDBytes(ExportUnsignedBigEndian(D))
            RSAVariables.SetDPBytes(ExportUnsignedBigEndian(DP))
            RSAVariables.SetDQBytes(ExportUnsignedBigEndian(DQ))
            RSAVariables.SetInverseQBytes(ExportUnsignedBigEndian(InverseQ))
            ExponentTextBox.Text = Exponent.ToString
            DTextBox.Text = D.ToString
            PTextBox.Text = P.ToString
            QTextBox.Text = Q.ToString
            ModulusTextBox.Text = Modulus.ToString
            DPTextBox.Text = DP.ToString
            DQTextBox.Text = DQ.ToString
            InverseQTextBox.Text = InverseQ.ToString
        Else
            MessageBox.Show("It doesn't go through the selection loop, it is still using random index to generate public/private key")
        End If
    End Sub

    Private Sub GenerateBiggerRandomKeyBTN_Click(sender As Object, e As EventArgs) Handles GenerateBiggerRandomKeyBTN.Click
        'The functions below will only be required if the generation of key is not 
        'generated randomly and user would like to generate bigger RSA Key
        Dim PreviousModulus As BigInteger = RSAVariables.Modulus
        Dim MyRSACryptoServiceProvider As New RSACryptoServiceProvider(384)
        Dim MyRSAParams As New RSAParameters
        Dim Modulus As BigInteger = 0
        Dim Modulus1 As BigInteger = 0
        Dim P As BigInteger = 0
        Dim Q As BigInteger = 0
        Dim Exponent As BigInteger = 65537
        Dim D As BigInteger = 0
        Dim DP As BigInteger = 0
        Dim DQ As BigInteger = 0
        Dim InverseQ As BigInteger = 0
        Dim PrimeList, PrimeList2 As New List(Of BigInteger)
        Dim x As Integer = 1
        Using StreamReader As New StreamReader("G:\PrimeList384P1.txt")
            Dim line As String
            While x <= 80000
                line = StreamReader.ReadLine
                If x >= 1 And x <= 40000 Then
                    PrimeList.Add(BigInteger.Parse(line))
                ElseIf x >= 40001 And x <= 800000 Then
                    PrimeList2.Add(BigInteger.Parse(line))
                End If
                x += 1
            End While
        End Using
        If SelectionBoolean = False Then
            x = PublicRandomIndex
            While x < 40000
                RandomIndexTB.Text = x.ToString
                Q = PrimeList(x)
                P = PrimeList2(x)
                Modulus = P * Q
                Modulus1 = (P - 1) * (Q - 1)
                D = ModInverse(65537, Modulus1)
                DP = BigInteger.Remainder(D, (P - 1))
                DQ = BigInteger.Remainder(D, (Q - 1))
                InverseQ = ModInverse(Q, P)
                If Modulus.ToByteArray.Count = 48 Or D.ToByteArray.Count = 48 Or
                    DP.ToByteArray.Count = 24 Or DQ.ToByteArray.Count = 24 Or
                        InverseQ.ToByteArray.Count = 24 Or
                        P.ToByteArray(P.ToByteArray.Count - 1) <> 0 Or
                        Q.ToByteArray(Q.ToByteArray.Count - 1) <> 0 Or
                        Modulus.ToByteArray(Modulus.ToByteArray.Count - 1) <> 0 Or
                        D.ToByteArray(D.ToByteArray.Count - 1) <> 0 Or
                        DP.ToByteArray(DP.ToByteArray.Count - 1) <> 0 Or
                        DQ.ToByteArray(DQ.ToByteArray.Count - 1) <> 0 Or
                        InverseQ.ToByteArray(InverseQ.ToByteArray.Count - 1) <> 0 Or
                        BigInteger.GreatestCommonDivisor(P, Q) = 1 Then
                    If (Modulus > PreviousModulus) Then
                        PublicRandomIndex = x
                        Exit While
                    End If

                ElseIf x = 39999 Then
                    MessageBox.Show("Not Found")

                End If
                x += 1
            End While
            RSAVariables.SetP(P)
            RSAVariables.SetQ(Q)
            RSAVariables.SetModulus(Modulus)
            RSAVariables.SetExponent(Exponent)
            RSAVariables.SetD(D)
            RSAVariables.SetDP(DP)
            RSAVariables.SetDQ(DQ)
            RSAVariables.SetInverseQ(InverseQ)
            RSAVariables.SetPBytes(ExportUnsignedBigEndian(P))
            RSAVariables.SetQBytes(ExportUnsignedBigEndian(Q))
            RSAVariables.SetModulusBytes(ExportUnsignedBigEndian(Modulus))
            RSAVariables.SetExponentBytes(ExportUnsignedBigEndian(Exponent))
            RSAVariables.SetDBytes(ExportUnsignedBigEndian(D))
            RSAVariables.SetDPBytes(ExportUnsignedBigEndian(DP))
            RSAVariables.SetDQBytes(ExportUnsignedBigEndian(DQ))
            RSAVariables.SetInverseQBytes(ExportUnsignedBigEndian(InverseQ))
            ExponentTextBox.Text = Exponent.ToString
            DTextBox.Text = D.ToString
            PTextBox.Text = P.ToString
            QTextBox.Text = Q.ToString
            ModulusTextBox.Text = Modulus.ToString
            DPTextBox.Text = DP.ToString
            DQTextBox.Text = DQ.ToString
            InverseQTextBox.Text = InverseQ.ToString
        End If
    End Sub

    Private Sub GenerateSmallerRandomKeyBTN_Click(sender As Object, e As EventArgs) Handles GenerateSmallerRandomKeyBTN.Click
        'The functions below will only be required if the generation of key is not 
        'generated randomly and user would like to generate smaller RSA Key
        Dim PreviousModulus As BigInteger = RSAVariables.Modulus
        Dim MyRSACryptoServiceProvider As New RSACryptoServiceProvider(384)
        Dim MyRSAParams As New RSAParameters
        Dim Modulus As BigInteger = 0
        Dim Modulus1 As BigInteger = 0
        Dim P As BigInteger = 0
        Dim Q As BigInteger = 0
        Dim Exponent As BigInteger = 65537
        Dim D As BigInteger = 0
        Dim DP As BigInteger = 0
        Dim DQ As BigInteger = 0
        Dim InverseQ As BigInteger = 0
        Dim PrimeList, PrimeList2 As New List(Of BigInteger)
        Dim x As Integer = 1
        Using StreamReader As New StreamReader("G:\PrimeList384P1.txt")
            Dim line As String
            While x <= 80000
                line = StreamReader.ReadLine
                If x >= 1 And x <= 40000 Then
                    PrimeList.Add(BigInteger.Parse(line))
                ElseIf x >= 40001 And x <= 800000 Then
                    PrimeList2.Add(BigInteger.Parse(line))
                End If
                x += 1
            End While
        End Using
        If SelectionBoolean = False Then
            x = PublicRandomIndex
            While x >= 0
                RandomIndexTB.Text = x.ToString
                Q = PrimeList(x)
                P = PrimeList2(x)
                Modulus = P * Q
                Modulus1 = (P - 1) * (Q - 1)
                D = ModInverse(65537, Modulus1)
                DP = BigInteger.Remainder(D, (P - 1))
                DQ = BigInteger.Remainder(D, (Q - 1))
                InverseQ = ModInverse(Q, P)
                If Modulus.ToByteArray.Count = 48 Or D.ToByteArray.Count = 48 Or
                    DP.ToByteArray.Count = 24 Or DQ.ToByteArray.Count = 24 Or
                        InverseQ.ToByteArray.Count = 24 Or
                        P.ToByteArray(P.ToByteArray.Count - 1) <> 0 Or
                        Q.ToByteArray(Q.ToByteArray.Count - 1) <> 0 Or
                        Modulus.ToByteArray(Modulus.ToByteArray.Count - 1) <> 0 Or
                        D.ToByteArray(D.ToByteArray.Count - 1) <> 0 Or
                        DP.ToByteArray(DP.ToByteArray.Count - 1) <> 0 Or
                        DQ.ToByteArray(DQ.ToByteArray.Count - 1) <> 0 Or
                        InverseQ.ToByteArray(InverseQ.ToByteArray.Count - 1) <> 0 Or
                        BigInteger.GreatestCommonDivisor(P, Q) = 1 Then
                    If (Modulus < PreviousModulus) Then
                        Exit While
                        PublicRandomIndex = x
                    End If

                ElseIf x = 39999 Then
                    MessageBox.Show("Not Found")

                End If
                x -= 1
            End While
            RSAVariables.SetP(P)
            RSAVariables.SetQ(Q)
            RSAVariables.SetModulus(Modulus)
            RSAVariables.SetExponent(Exponent)
            RSAVariables.SetD(D)
            RSAVariables.SetDP(DP)
            RSAVariables.SetDQ(DQ)
            RSAVariables.SetInverseQ(InverseQ)
            RSAVariables.SetPBytes(ExportUnsignedBigEndian(P))
            RSAVariables.SetQBytes(ExportUnsignedBigEndian(Q))
            RSAVariables.SetModulusBytes(ExportUnsignedBigEndian(Modulus))
            RSAVariables.SetExponentBytes(ExportUnsignedBigEndian(Exponent))
            RSAVariables.SetDBytes(ExportUnsignedBigEndian(D))
            RSAVariables.SetDPBytes(ExportUnsignedBigEndian(DP))
            RSAVariables.SetDQBytes(ExportUnsignedBigEndian(DQ))
            RSAVariables.SetInverseQBytes(ExportUnsignedBigEndian(InverseQ))
            ExponentTextBox.Text = Exponent.ToString
            DTextBox.Text = D.ToString
            PTextBox.Text = P.ToString
            QTextBox.Text = Q.ToString
            ModulusTextBox.Text = Modulus.ToString
            DPTextBox.Text = DP.ToString
            DQTextBox.Text = DQ.ToString
            InverseQTextBox.Text = InverseQ.ToString
        End If
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("To use the encrypt/decrypt button, you must first click the 'Generate' Button", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("To use the Generate Bigger/Smaller Key button, you must first click the 'Generate' Button" & vbNewLine &
                        "Note:The Generate Bigger/Smaller Key can be used if and only there's no pop up message stating the following:" & vbNewLine &
                        "It doesn't go through the selection loop, it is still using random index to generate public/private key", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("To use the Generate Bigger/Smaller Key (Random) button, you must first click the 'Generate' Button" & vbNewLine &
                        "Note:The Generate Bigger/Smaller Key (Random) can be used if and only there's a pop up message stating the following:" & vbNewLine &
                        "It doesn't go through the selection loop, it is still using random index to generate public/private key", "Instruction", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
