using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace EncryptedChatApplication
{
    public class GetPepperClass
    {
        public String Pepper;
        public String SecretPath = "/db/ChatApplicationPepper.txt";

        public void InitializePepper()
        {
            String Testing = "";
            using (StreamReader SecretPathReader = new StreamReader(SecretPath))
            {
                while ((Testing = SecretPathReader.ReadLine()) != null)
                {
                    Pepper=Testing;
                }
            }
        }
    }
}
