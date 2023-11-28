using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace md5_sql_hash
{
    class md5
    {
        public static string GetHash(string pass) //кодирование пароля
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            return Convert.ToBase64String(hash);
        }

    }
}
