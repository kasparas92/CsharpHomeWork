using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    class IdGenerator
    {
        static int id = 0;
        string storeId;
        DateTime dt = new DateTime();

        public string GenerateId()
        {
            string gid = DateTime.Now.ToString("yyyy-MM");
            storeId = gid + ++id;
            return storeId;
        }
    }
}
