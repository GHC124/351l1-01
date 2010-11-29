using System;
using System.Collections.Generic;
using System.Text;

namespace BieuThuc_DTO
{
    public class BieuThuc
    {
        private string bieuthuc;

        public BieuThuc()
        {
            bieuthuc = String.Empty;
        }

        public string Bieuthuc
        {
            set { bieuthuc = value; }
            get { return bieuthuc; }
        }
    }
}
