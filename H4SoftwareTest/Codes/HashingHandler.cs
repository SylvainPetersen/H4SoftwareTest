namespace H4SoftwareTest.Codes
{
    public class HashingHandler
    {
        public string BCryptHashing(string textToHash)
        {
            return BCrypt.Net.BCrypt.HashPassword(textToHash);

            //int workFactor = 10;
            //bool enhanceEntropy = true;
            //return BCrypt.Net.BCrypt.HashPassword(textToHash, workFactor, enhanceEntropy);

            //string salt = BCrypt.Net.BCrypt.GenerateSalt();
            //bool enhanceEntropy = true;
            //HashType hashType = HashType.SHA256;
            //return BCrypt.Net.BCrypt.HashPassword(textToHash, salt, enhanceEntropy, hashType);
        }

        public bool BCryptVerifyHashing(string textToHash, string hashedValue)
        {
            return BCrypt.Net.BCrypt.Verify(textToHash, hashedValue);

            //return BCrypt.Net.BCrypt.Verify(textToHash, hashedValue, true);

            //return BCrypt.Net.BCrypt.Verify(textToHash, hashedValue, true, BCrypt.Net.HashType.SHA256);
        }
    }
}
