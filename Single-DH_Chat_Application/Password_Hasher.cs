using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;

namespace EncryptedChatApplication
{
    public class Password_Hasher
    {
        public BigInteger Hashing_Function(String UnhashedPassword, String[] Salts, String Pepper) 
        {
            SHA512 MySHA512 = SHA512.Create();
            Byte[] TempHashedByte = new Byte[] { };
            Byte[] HashedByte = new Byte[] { };
            Byte[] SaltByte = new Byte[] { };
            Byte[] PepperByte = new Byte[] { };
            int Loop = 0;
            int Loop2 = 0;
            int Loop3 = 0;
            int SaltBytesCount = 0;
            int PepperBytesCount = 0;
            int TotalBytesCount = 0;
            int LoopCount = Salts.Length;
            BigInteger HashedPasswordBigInt = 0;
            while (Loop < LoopCount) 
            {
                if (Loop == 0)
                {
                    TempHashedByte = MySHA512.ComputeHash(Encoding.UTF8.GetBytes(UnhashedPassword + Salts[Loop] + Pepper));
                }
                else 
                {
                    HashedByte = TempHashedByte;
                    SaltBytesCount = Encoding.UTF8.GetBytes(Salts[Loop]).Length;
                    PepperBytesCount = Encoding.UTF8.GetBytes(Pepper).Length;
                    TotalBytesCount = HashedByte.Length + SaltBytesCount + PepperBytesCount;
                    TempHashedByte = new Byte[TotalBytesCount];
                    SaltByte = Encoding.UTF8.GetBytes(Salts[Loop]);
                    PepperByte = Encoding.UTF8.GetBytes(Pepper);
                    while (Loop2<HashedByte.Length) 
                    {
                        TempHashedByte[Loop2] = HashedByte[Loop2];
                        Loop2 += 1;
                    }
                    Loop3 = 0;
                    while (Loop2 < HashedByte.Length + SaltBytesCount) 
                    {
                        TempHashedByte[Loop2] = SaltByte[Loop3];
                        Loop3 += 1;
                        Loop2 += 1;
                    }
                    Loop3 = 0;
                    while (Loop2 < HashedByte.Length + SaltBytesCount + PepperBytesCount) 
                    {
                        TempHashedByte[Loop2] = PepperByte[Loop3];
                        Loop3 += 1;
                        Loop2 += 1;
                    }
                    Loop3 = 0;
                    Loop2 = 0;
                    TempHashedByte = MySHA512.ComputeHash(TempHashedByte);
                }

                if (Loop+1 == LoopCount) 
                {
                    HashedByte = TempHashedByte;
                }
                Loop += 1;
            }
            HashedPasswordBigInt = new BigInteger(HashedByte);
            return HashedPasswordBigInt;
        }

    }
}
