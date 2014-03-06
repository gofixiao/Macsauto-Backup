
namespace Macsauto.Infrastructure.Helper.Extension
{
    using System;

    public static class GuidExtension
    {
        private static string ParseToShortGuidString(this Guid guid)
        {
            var modifiedBase64 = Convert.ToBase64String(guid.ToByteArray())
                .Replace('+', '-').Replace('/', '_') // avoid invalid URL characters
                .Substring(0, 22);

            return modifiedBase64;
        }

        public static Guid ToShortGuid(this Guid guid)
        {
            var shortGuid = ParseToShortGuidString(guid);
            var base64 = shortGuid.Replace('-', '+').Replace('_', '/') + "==";
            var bytes = Convert.FromBase64String(base64);

            return new Guid(bytes);
        }
    }
}