using System;
using System.Security.Cryptography;
using System.Text;

namespace HW2.Core.user
{
    public static class PasswordHelper
    {
        private static MD5 _md5;

        public static string GetHash(string password)
        {
            if (_md5 == null) _md5 = MD5.Create();
            var hash = _md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            return Convert.ToBase64String(hash);
        }
    }
}