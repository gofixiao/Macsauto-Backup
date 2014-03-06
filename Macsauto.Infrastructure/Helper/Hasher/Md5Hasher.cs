namespace Macsauto.Infrastructure.Helper.Hasher
{
    using System.Text;
    using System.Security.Cryptography;

    using Macsauto.Infrastructure.Helper.Extension;
    using Macsauto.Infrastructure.Helper.Hasher.Contract;

    public class Md5Hasher : IHasher
    {
        public string Hash(string value)
        {
            var md5 = MD5.Create();
            var resultBytes = md5.ComputeHash(value.ToBytes());
            var resultString = new StringBuilder();

            foreach (var resultByte in resultBytes)
            {
                resultString.Append(resultByte.ToString("x2"));
            }

            return resultString.ToString();
        }
    }
}
