using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Data.VO
{
    public class UserVO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string RefreshToken { get; set; }
        public string RefreshTokenExpiryTime { get; set; }
    }
}
