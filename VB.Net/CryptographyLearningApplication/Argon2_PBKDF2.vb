Imports Konscious.Security.Cryptography
Imports System.Numerics
Imports System.Text
Imports Sodium.SodiumCore
Public Class Argon2_PBKDF2
    Private Sub Argon2_PBKDF2_Close(sender As Object, e As EventArgs) Handles MyBase.Closing
        Home_Form.Show()
    End Sub

    Private Sub HashBTN_Click(sender As Object, e As EventArgs) Handles HashBTN.Click
        Dim MyArgon2 As Argon2id
        Dim SettingsString As String = ""
        Dim PasswordString As String = ""
        Dim PasswordByte As Byte() = New Byte() {}
        Dim SaltByte As Byte() = New Byte() {}
        Dim HashedPasswordByte As Byte() = New Byte() {}
        Dim HashedPasswordBigInt As BigInteger = 0
        Dim HashedPassword64String As String = ""
        Dim Salt64String As String = ""
        Dim ThreadsAmountString As String = ""
        Dim RamSizeString As String = ""
        Dim IterationString As String = ""
        Dim AmountOfUserString As String = ""
        Dim AmountOfUser As Integer = 0
        Dim ThreadsAmount As Integer = 0
        Dim RamSize As Integer = 0
        Dim Iteration As Integer = 0
        Dim TempDouble As Double = 0
        Dim RamSizeULong As ULong = 0
        Dim CheckBoolean As Boolean = True
        Dim CheckBoolean2 As Boolean = True
        Dim CheckBoolean3 As Boolean = True
        SettingsString = SettingsCB.Text
        PasswordString = PasswordTB.Text
        If PasswordString <> "" And SettingsString <> "" And PasswordString <> Nothing And SettingsString <> Nothing Then
            PasswordByte = Encoding.UTF8.GetBytes(PasswordString)
            MyArgon2 = New Argon2id(PasswordByte)
            SaltByte = GetRandomBytes(16)
            Salt64String = Convert.ToBase64String(SaltByte)
            If SettingsString = "Low" Then
                ThreadsAmount = 2
                RamSize = 16
                Iteration = 10
                MyArgon2.Iterations = Iteration
                MyArgon2.MemorySize = RamSize
                MyArgon2.DegreeOfParallelism = ThreadsAmount
                MyArgon2.Salt = SaltByte
                ThreadsAmountTB.Text = ThreadsAmount.ToString
                RamSizeTB.Text = RamSize.ToString
                IterationTB.Text = Iteration.ToString
            ElseIf SettingsString = "Medium" Then
                ThreadsAmount = 2
                RamSize = 128
                Iteration = 10
                MyArgon2.Iterations = Iteration
                MyArgon2.MemorySize = RamSize
                MyArgon2.DegreeOfParallelism = ThreadsAmount
                MyArgon2.Salt = SaltByte
                ThreadsAmountTB.Text = ThreadsAmount.ToString
                RamSizeTB.Text = RamSize.ToString
                IterationTB.Text = Iteration.ToString
            ElseIf SettingsString = "Recommended" Then
                AmountOfUserString = AmountOfUserTB.Text
                If AmountOfUserString <> "" And AmountOfUserString <> Nothing Then
                    Try
                        AmountOfUser = Integer.Parse(AmountOfUserString)
                    Catch ex As Exception
                        CheckBoolean = False
                    End Try
                Else
                    MessageBox.Show("Please enter amount of users..")
                End If
                If CheckBoolean Then
                    RamSizeULong = My.Computer.Info.TotalPhysicalMemory
                    RamSizeULong = ((RamSizeULong / 1024) / 1024)
                    RamSize = Integer.Parse(RamSizeULong.ToString)
                    ThreadsAmount = 2
                    TempDouble = (RamSize / AmountOfUser) * 0.75
                    TempDouble = Math.Round(TempDouble, 0)
                    RamSize = Integer.Parse(TempDouble.ToString)
                    Iteration = 15
                    MyArgon2.Iterations = Iteration
                    MyArgon2.MemorySize = RamSize
                    MyArgon2.DegreeOfParallelism = ThreadsAmount
                    MyArgon2.Salt = SaltByte
                    ThreadsAmountTB.Text = ThreadsAmount.ToString
                    RamSizeTB.Text = RamSize.ToString
                    IterationTB.Text = Iteration.ToString
                Else
                    MessageBox.Show("Please enter amount of users..")
                End If
            Else
                ThreadsAmountString = ThreadsAmountTB.Text
                RamSizeString = RamSizeTB.Text
                IterationString = IterationTB.Text
                If ThreadsAmountString <> "" And ThreadsAmountString <> Nothing And RamSizeString <> "" And RamSizeString <> Nothing And IterationString <> "" And IterationString <> Nothing Then
                    Try
                        ThreadsAmount = Integer.Parse(ThreadsAmountString)
                    Catch ex As Exception
                        CheckBoolean = False
                    End Try
                    Try
                        RamSize = Integer.Parse(RamSizeString)
                    Catch ex As Exception
                        CheckBoolean2 = False
                    End Try
                    Try
                        Iteration = Integer.Parse(IterationString)
                    Catch ex As Exception
                        CheckBoolean3 = False
                    End Try
                    If CheckBoolean And CheckBoolean2 And CheckBoolean3 Then
                        MyArgon2.Iterations = Iteration
                        MyArgon2.MemorySize = RamSize
                        MyArgon2.DegreeOfParallelism = ThreadsAmount
                        MyArgon2.Salt = SaltByte
                    Else
                        MessageBox.Show("Please enter numberic data for the first 3 text box...")
                    End If
                Else
                    MessageBox.Show("Please enter data for the first 3 text box")
                End If
            End If
            HashedPasswordByte = MyArgon2.GetBytes(PasswordByte.Concat(SaltByte).ToArray.Length)
            HashedPassword64String = Convert.ToBase64String(HashedPasswordByte)
            HashedPasswordBigInt = New BigInteger(HashedPasswordByte)
            SaltBase64TB.Text = Salt64String
            PasswordHash64TB.Text = HashedPassword64String
            PasswordHashBigIntTB.Text = HashedPasswordBigInt.ToString
            PasswordHashHexaTB.Text = HashedPasswordBigInt.ToString("X")
        Else
            MessageBox.Show("Please enter a password and choose a setting....")
        End If
    End Sub

    Private Sub SettingsCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SettingsCB.SelectedIndexChanged
        If SettingsCB.Text = "Custom" Then
            ThreadsAmountTB.ReadOnly = False
            IterationTB.ReadOnly = False
            RamSizeTB.ReadOnly = False
            AmountOfUserTB.ReadOnly = True
        ElseIf SettingsCB.Text = "Recommended" Then
            AmountOfUserTB.ReadOnly = False
        Else
            ThreadsAmountTB.ReadOnly = True
            IterationTB.ReadOnly = True
            RamSizeTB.ReadOnly = True
            AmountOfUserTB.ReadOnly = True
        End If
    End Sub

    Private Sub ReadMeBTN_Click(sender As Object, e As EventArgs) Handles ReadMeBTN.Click
        MessageBox.Show("According to github on Konscious Argon2, the iteration count was core amount * 5 which in a condition that the iteration count must be bigger than 2 ...")
        MessageBox.Show("The recommended ram size is always good to start up with a formula with Ram Size in MB divide by user multiply by 75% , if your system requires more security, you can adjust the rate higher")
        MessageBox.Show("Always assume that you couldn't use all of your core and all of your total RAM size as they are needed to run respective tasks on your machine be it server or PC or laptop....")
        MessageBox.Show("For details .. , do always search for forums out there for more reference...")
    End Sub
End Class