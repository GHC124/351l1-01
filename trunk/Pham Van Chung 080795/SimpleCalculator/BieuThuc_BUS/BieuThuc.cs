using System;
using System.Collections.Generic;
using System.Text;
using BieuThuc_DAO;
using BieuThuc_DTO;

namespace BieuThuc_BUS
{
    public class BieuThuc
    {
        private BieuThuc_DAO.BieuThuc bt_DAO;
        private BieuThuc_DTO.BieuThuc bt_DTO;
        private string error;

        public BieuThuc()
        {
            bt_DAO = new BieuThuc_DAO.BieuThuc();
            bt_DTO = new BieuThuc_DTO.BieuThuc();
            error = String.Empty;
        }

        public string BT
        {
            set { bt_DTO.Bieuthuc = value; }
        }

        public string GiaTri()
        {
            return bt_DAO.TinhToan(bt_DTO);
        }
    }
}
