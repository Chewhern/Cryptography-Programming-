Public Class Home_Form
    Private Sub Home_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        'Label1.Top = (Me.ClientSize.Height - Label1.Height) / 2
        Label1.Top = 15
        Label1.Left = (Me.ClientSize.Width - Label1.Width) / 2
        Destination_CB.Top = 60
        Destination_CB.Left = (Me.ClientSize.Width - Destination_CB.Width) / 2
        Go_BTN.Top = 90
        Go_BTN.Left = (Me.ClientSize.Width - Go_BTN.Width) / 2
    End Sub

    Private Sub Home_Form_Change_Normal(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Normal Then
            'Label1.Top = (Me.ClientSize.Height - Label1.Height) / 2
            Label1.Top = 15
            Label1.Left = (Me.ClientSize.Width - Label1.Width) / 2
            Destination_CB.Top = 60
            Destination_CB.Left = (Me.ClientSize.Width - Destination_CB.Width) / 2
            Go_BTN.Top = 90
            Go_BTN.Left = (Me.ClientSize.Width - Go_BTN.Width) / 2
        ElseIf Me.WindowState = FormWindowState.Maximized Then
            'Label1.Top = (Me.ClientSize.Height - Label1.Height) / 2
            Label1.Top = 15
            Label1.Left = (Me.ClientSize.Width - Label1.Width) / 2
            Destination_CB.Top = 60
            Destination_CB.Left = (Me.ClientSize.Width - Destination_CB.Width) / 2
            Go_BTN.Top = 90
            Go_BTN.Left = (Me.ClientSize.Width - Go_BTN.Width) / 2
        End If
    End Sub

    Private Sub Go_BTN_Click(sender As Object, e As EventArgs) Handles Go_BTN.Click
        If Destination_CB.Text <> "" Then
            If Destination_CB.Text.CompareTo("Elliptic Curves Cryptography Diffie Hellman") = 0 Then
                Elliptic_Curves_Cryptography_Diffie_Hellman.Show()
            ElseIf Destination_CB.Text.CompareTo("Elliptic Curves Cryptography Signature") = 0 Then
                Elliptic_Curves_Cryptography_Signature.Show()
            ElseIf Destination_CB.Text.CompareTo("Elliptic Curves Cryptography Signature to DH Conversion") = 0 Then
                Elliptic_Curves_Cryptography_Signature_To_DH.Show()
            ElseIf Destination_CB.Text.CompareTo("Elliptic Curves Cryptography Calculate DH PK from DH SK") = 0 Then
                Elliptic_Curves_Cryptography_DH_SK_PK.Show()
            ElseIf Destination_CB.Text.CompareTo("RSA(Old School)") = 0 Then
                RSA.Show()
            ElseIf Destination_CB.Text.CompareTo("RSA(Padding)") = 0 Then
                RSA_Padding.Show()
            ElseIf Destination_CB.Text.CompareTo("RSA(OAEP Padding)") = 0 Then
                RSA_OAEP_Padding.Show()
            ElseIf Destination_CB.Text.CompareTo("AES(Byte)") = 0 Then
                AES_Byte.Show()
            ElseIf Destination_CB.Text.CompareTo("AES(Text)") = 0 Then
                AES_Text.Show()
            ElseIf Destination_CB.Text.CompareTo("Authenticated Encryption (AES)") = 0 Then
                AE_AES.Show()
            ElseIf Destination_CB.Text.CompareTo("Authenticated Encryption With Additional Data (AEAD + AES)") = 0 Then
                AEAD_AES.Show()
            ElseIf Destination_CB.Text.CompareTo("Signal's Out Of Band's Authentication (DH + Hash)") = 0 Then
                Signal_Out_Of_Band_Authentication.Show()
            ElseIf Destination_CB.Text.CompareTo("Proper Hashing(Salt + Pepper) {Byte}") = 0 Then
                Salt_Pepper_Byte.Show()
            ElseIf Destination_CB.Text.CompareTo("Proper Hashing(Salt + Pepper) {String}") = 0 Then
                Salt_Pepper_String.Show()
            ElseIf Destination_CB.Text.CompareTo("Random Password Generator with fixed length") = 0 Then
                Random_Pass_Generator.Show()
            ElseIf Destination_CB.Text.CompareTo("Random Password Generator with fixed length(Built In)") = 0 Then
                Random_Pass_Generator_System_String.Show()
            ElseIf Destination_CB.Text.CompareTo("Argon2") = 0 Then
                Argon2_PBKDF2.Show()
            ElseIf Destination_CB.Text.CompareTo("Signal's x3DH") = 0 Then
                Signalx3DH.Show()
            End If
            Me.Hide()
        End If
    End Sub
End Class
