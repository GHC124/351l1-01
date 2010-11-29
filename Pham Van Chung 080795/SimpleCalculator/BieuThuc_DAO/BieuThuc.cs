using System;
using System.Collections.Generic;
using System.Text;

namespace BieuThuc_DAO
{
    public class BieuThuc
    {
        private CuPhap cuphap;
        private GiaTri giatri;
        
        public BieuThuc()
        {
            cuphap = new CuPhap();
            giatri = new GiaTri();
        }

        public string TinhToan(BieuThuc_DTO.BieuThuc bt)
        {
            cuphap.Input = bt.Bieuthuc;
            giatri.Input = cuphap.Output;
            if (cuphap.Error != "")
                return cuphap.Error;
            return giatri.Output;
        }
    }
}
