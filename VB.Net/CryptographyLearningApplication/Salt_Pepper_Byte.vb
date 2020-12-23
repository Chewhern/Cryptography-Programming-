Imports System.Numerics
Imports System.Text
Imports System.Security.Cryptography

Public Class Salt_Pepper_Byte
    Private Sub GoBTN_Click(sender As Object, e As EventArgs) Handles GoBTN.Click
        Dim PasswordString As String = ""
        Dim PasswordByte As Byte() = New Byte() {}
        Dim PepperByte As Byte() = New Byte() {}
        Dim SaltByte As Byte() = New Byte() {}
        Dim CombinedByte As Byte() = New Byte() {}
        Dim HashedString As String = ""
        Dim HashedBigInt As BigInteger = 0
        Dim HashedByte As Byte() = New Byte() {}
        Dim SaltBigInt As BigInteger = 0
        Dim PepperBigInt As BigInteger = 0
        Dim OutputLength As Long = 0
        Dim MySHA512 As SHA512 = SHA512.Create
        ReDim SaltByte(240)
        ReDim PepperByte(240)
        Dim MyRNGCryptoServiceProvider As RNGCryptoServiceProvider = New RNGCryptoServiceProvider
        MyRNGCryptoServiceProvider.GetBytes(SaltByte)
        MyRNGCryptoServiceProvider.GetBytes(PepperByte)
        PasswordString = PasswordTB.Text
        If PasswordString <> "" Then
            PasswordByte = Encoding.UTF8.GetBytes(PasswordString)
            PepperBigInt = New BigInteger(PepperByte)
            SaltBigInt = New BigInteger(SaltByte)
            CombinedByte = PasswordByte.Concat(SaltByte).Concat(PepperByte).ToArray
            HashedByte = MySHA512.ComputeHash(CombinedByte)
            HashedBigInt = New BigInteger(HashedByte)
            HashedString = Convert.ToBase64String(HashedByte)
            SaltHexaTB.Text = SaltBigInt.ToString("X")
            PepperHexaTB.Text = PepperBigInt.ToString("X")
            PasswordAfterHashHexaTB.Text = HashedBigInt.ToString("X")
            PasswordAfterHashBase64TB.Text = HashedString
        Else
            MessageBox.Show("Please enter data")
        End If
    End Sub

    Private Sub Salt_Pepper_Byte_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("In a proper password system, there's always something to protect it..")
        MessageBox.Show("What people will do is always just owh I take a password from user and just store it normally without processing in database meaning if someone gained access into your database.., he/she can use all your system's users accounts with ease.. because when u design a password based system if ur user forgot the password u can just email it back to them safely without ever changing it..")
        MessageBox.Show("Secondly, well I just take the user password and just mess it up with a way to undo it, this is also a bad way to do it.. because if someone knows how u mess up with it .. they can undo the process...")
        MessageBox.Show("Thirdly, well I just take the user password and do a one way mess up processing which I can't reverse it back and compare it with the processed password entered by user.. , if success then lets them login..")
        MessageBox.Show("First 2 method are kinda naive approach , the 3rd approach is okay but if u just take password and process it well .. to be honest you can find back the processed password into non processed password online.. try search online hash cracker on respective browser..")
        MessageBox.Show("In order to prevent the 3rd method from being attacked, we will need to mix in something called salt and pepper")
        MessageBox.Show("It will make the attacker extremely harder to crack a password because the processed password is now extremely complex")
        MessageBox.Show("Both salt and pepper are actually a random and unique string.. You can assume it as a randomly generated password")
        MessageBox.Show("The difference is a salt is actually a mixture used for each user password while a pepper is actually a centralized hidden mixture that was used in every password like record in each database")
    End Sub
End Class