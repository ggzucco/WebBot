using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace WebBot.Controllers
{
    public class CryptographyController
    {
        private static Guid _key = new Guid("5CF329AB-7FEF-452F-A033-1D745AB0C588");
        private static Guid _iv = new Guid("73DE984F-6BC0-4146-BB51-285BF26FDE20");

        public static String Encrypt(String text)
        {
            return Crypto(text, CryptoStreamMode.Write);
        }
        public static String Decrypt(String text)
        {         
            return Crypto(text, CryptoStreamMode.Read);
        }
    
        static String Crypto(String input, CryptoStreamMode mode)
        {
            try
            {
                String returnText = null;
                Boolean flgEncrypt = (mode == CryptoStreamMode.Write);

                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = _key.ToByteArray();
                    aesAlg.IV = _iv.ToByteArray();

                    byte[] inputByte = null;
                    ICryptoTransform cryptoTransform = null;

                    //Encrypt
                    if (flgEncrypt)
                    {
                        inputByte = ASCIIEncoding.ASCII.GetBytes(input);
                        cryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);
                    }
                    else //Decrypt
                    {
                        inputByte = Convert.FromBase64String(input);
                        cryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    }

                    using (MemoryStream ms = new MemoryStream(inputByte))
                    {
                        using (CryptoStream cs = new CryptoStream(ms, cryptoTransform, mode))
                        {
                            if (flgEncrypt)
                            {
                                using (StreamWriter swEncrypt = new StreamWriter(cs))
                                {
                                    swEncrypt.Write(inputByte);
                                }

                                returnText = Convert.ToBase64String(ms.ToArray());
                            }
                            else
                            {
                                byte[] bs = new byte[1025];
                                int nb = cs.Read(bs, 0, inputByte.Length);

                                returnText = new ASCIIEncoding().GetString(bs).Substring(0, nb);

                                //using (StreamReader srDecrypt = new StreamReader(cs))
                                //{
                                //    returnText = srDecrypt.ReadToEnd();
                                //}
                            }
                        }
                    }
                }

                return returnText;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
