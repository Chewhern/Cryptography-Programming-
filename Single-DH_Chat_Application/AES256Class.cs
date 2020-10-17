using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.IO;

namespace EncryptedChatApplication
{
    public class AES256Class
    {
        public void EncryptBytes(ref Byte[] EncryptedTextBytes, Byte[] AESKey, Byte[] AESIV , Byte[] Data) {
            Aes MyAES = Aes.Create();
            MyAES.Key = AESKey;
            MyAES.IV = AESIV;
            MyAES.Mode = CipherMode.CBC;
            MyAES.Padding = PaddingMode.PKCS7;
            using (var encryptor = MyAES.CreateEncryptor(MyAES.Key, MyAES.IV))
            {
                EncryptedTextBytes= PerformCryptography(Data, encryptor);
            }
        }

        public void DecryptBytes(ref Byte[] DecryptedTextByte, Byte[] AESKey, Byte[] AESIV, Byte[] EncryptedTextByte) {
            Aes MyAES = Aes.Create();
            MyAES.Key = AESKey;
            MyAES.IV = AESIV;
            MyAES.Mode = CipherMode.CBC;
            MyAES.Padding = PaddingMode.PKCS7;
            using (var decryptor = MyAES.CreateDecryptor(MyAES.Key, MyAES.IV))
            {
                DecryptedTextByte= PerformCryptography(EncryptedTextByte, decryptor);
            }
        }
        private Byte[] PerformCryptography(Byte[] Data, ICryptoTransform cryptoTransform)
        {
            using (var ms = new MemoryStream())
            using (var cryptoStream = new CryptoStream(ms, cryptoTransform, CryptoStreamMode.Write))
            {
                cryptoStream.Write(Data, 0, Data.Length);
                cryptoStream.FlushFinalBlock();

                return ms.ToArray();
            }
        }
    }
}
