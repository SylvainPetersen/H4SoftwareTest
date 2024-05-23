namespace H4SoftwareTest.Codes
{
    public class HashingHandler
    {
        public string BCryptHashing(string textToHash)
        {
            return BCrypt.Net.BCrypt.HashPassword(textToHash);
        }

        public bool BCryptVerifyHashing(string textToHash, string hashedValue)
        {
            return BCrypt.Net.BCrypt.Verify(textToHash, hashedValue);
        }
    }
}
