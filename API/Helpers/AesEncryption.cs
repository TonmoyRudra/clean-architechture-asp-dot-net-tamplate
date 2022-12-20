using System.Security.Cryptography;
using System.Text;

namespace API.Helpers
{
    public class AesEncryption
    {
        public byte[] GenerateRandomNumber(int length)
        {
            //using (var randomNumberGenerator = new RNGCryptoServiceProvider())
            //{
            //    var randomNumber = new byte[length];
            //    randomNumberGenerator.GetBytes(randomNumber);

            //    return randomNumber;
            //}

            using (var rng = RandomNumberGenerator.Create())
            {
                var randomNumber = new byte[length];
                rng.GetBytes(randomNumber);
                return randomNumber;
            }
        }

        public byte[] Encrypt(byte[] dataToEncrypt, byte[] key, byte[] iv)
        {
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
                aes.IV = iv;

                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(dataToEncrypt, 0, dataToEncrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    return memoryStream.ToArray();
                }
            }
        }

        public byte[] Decrypt(byte[] dataToDecrypt, byte[] key, byte[] iv)
        {
            using (var aes = new AesCryptoServiceProvider())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                aes.Key = key;
                aes.IV = iv;

                using (var memoryStream = new MemoryStream())
                {
                    var cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(),
                        CryptoStreamMode.Write);

                    cryptoStream.Write(dataToDecrypt, 0, dataToDecrypt.Length);
                    cryptoStream.FlushFinalBlock();

                    var decryptBytes = memoryStream.ToArray();

                    return decryptBytes;
                }
            }
        }
    }


    public static class EncryptDecrypt
    {
        private static string sEncryptionPassphrase = "B@|@j!";

        public static string Encrypt(string stringToEncrypt)
        {
            try
            {
                string returnstring;
                var salt = GenerateSalt();
                using (var keyBytes = new Rfc2898DeriveBytes(sEncryptionPassphrase, salt))
                {
                    var key = keyBytes.GetBytes(8);

                    DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                    des.GenerateIV();
                    byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, des.CreateEncryptor(key, des.IV), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    returnstring = Convert.ToBase64String(ms.ToArray());
                }

                //URL Encryption Avoid Reserved Characters
                returnstring = returnstring.Replace("/", "-2F-");
                returnstring = returnstring.Replace("+", "-2B-");
                returnstring = returnstring.Replace("=", "-3D-");

                return returnstring;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public static string Decrypt(string stringToEncrypt)
        {
            try
            {
                string returnstring;
                var salt = GenerateSalt();
                using (var keyBytes = new Rfc2898DeriveBytes(sEncryptionPassphrase, salt))
                {
                    var key = keyBytes.GetBytes(8);

                    DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                    des.GenerateIV();
                    byte[] inputByteArray = Encoding.UTF8.GetBytes(stringToEncrypt);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(key, des.IV), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    returnstring = Convert.ToBase64String(ms.ToArray());
                }

                //URL Encryption Avoid Reserved Characters
                returnstring = returnstring.Replace("/", "-2F-");
                returnstring = returnstring.Replace("+", "-2B-");
                returnstring = returnstring.Replace("=", "-3D-");

                return returnstring;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        private static byte[] GenerateSalt()
        {
            var randomBytes = new byte[8];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
    }
}
