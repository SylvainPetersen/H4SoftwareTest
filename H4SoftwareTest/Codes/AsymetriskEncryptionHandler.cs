using System.Security.Cryptography.X509Certificates;

namespace H4SoftwareTest.Codes
{
    public class AsymetriskEncryptionHandler
    {
        private string _privateKey;
        private string _publicKey;

        public AsymetriskEncryptionHandler()
        {
            if (!File.Exists("privateKey.pem"))
            {
                using (System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider())
                {
                    _privateKey = rsa.ToXmlString(true);
                    _publicKey = rsa.ToXmlString(false);

                    File.WriteAllText("privateKey.pem", _privateKey);
                    File.WriteAllText("publicKey.pem", _publicKey);
                }
            }
            else
            {
                _privateKey = File.ReadAllText("privateKey.pem");
                _publicKey = File.ReadAllText("publicKey.pem");
            }
        }

        public string EncryptAsymetrisk(string textToEncrypt)
        {
            using (System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider())
            {
                rsa.FromXmlString(_publicKey);

                byte[] byteArrayTextToEncrypt = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                byte[] encryptedDataAsByteArray = rsa.Encrypt(byteArrayTextToEncrypt, true);
                var encryptedDataAsString = Convert.ToBase64String(encryptedDataAsByteArray);

                return encryptedDataAsString;
            }
        }

        public string DecryptAsymetrisk(string textToDecrypt)
        {
            using (System.Security.Cryptography.RSACryptoServiceProvider rsa = new System.Security.Cryptography.RSACryptoServiceProvider())
            {
                rsa.FromXmlString(_privateKey);

                byte[] byteArrayTextToDecrypt = Convert.FromBase64String(textToDecrypt);
                byte[] decryptedDataAsByteArray = rsa.Decrypt(byteArrayTextToDecrypt, true);
                string decryptedDataAsString = System.Text.Encoding.UTF8.GetString(decryptedDataAsByteArray);

                return decryptedDataAsString;
            }
        }
    }
}
