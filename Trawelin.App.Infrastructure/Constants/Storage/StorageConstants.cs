using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trawelin.App.Infrastructure.Constants.Storage
{
    public static class StorageConstants
    {
        public static class Local {

            public static string baseUrl = "https://api.trawelin.com";

            public static string AuthToken = "AuthToken";

            public static string headerName = "Authorization";


            //Users
            public static string userId = "X-Id";
            public static string userUsername = "X-Username";
            public static string userEmail = "X-Email";
        }

    }
}
