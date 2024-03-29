using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BieuThuc_DAO
{
    class CuPhap
    {
        private NhanDien ND; //nhận diện biểu thức
        private string[] input; //luu bieu thuc sau khi da tach
        private int kich_thuoc_toi_da; //kich thuoc toi da cua bieu thuc
        private int pos; // vi tri hien tai trong input[]
        
        private string error;
        
        public CuPhap()
        {
            ND = new NhanDien();
            kich_thuoc_toi_da = 40;
            input = new string[kich_thuoc_toi_da];
            pos = 0;
            error = null;
          }
        
        public string Input
        {
            set
            {
                if (ND.TachChuoiNhapVao(value, ref input))
                {
                    error = "";
                    pos = 0;
                }
                else
                {
                    error = ND.Error;
                }
            }
        }
        
        public string Output
        {
            get
            {
                return Eparser();
            }
        }
     
        public string Error
        {
            get
            {
                return error;
            }
        }

        private void ERROR(int i)
        {
            switch (i)
            {
                case 0: error = "biểu thức quá dài";
                    break;
                case 1: error = "thiếu toán hạng";
                    break;
                case 2: error = "thiếu đóng ngoặc";
                    break;
                case 3: error = "biểu thức sai";
                    break;
                case 4: error = "thiếu toán tử";
                    break;
            }
        }

        //chuyển sang token tiếp theo
        private void Go()
        {
            pos++;
        }

        //đọc token tiếp theo
        private string Next()
        {
            return input[pos + 1];
        }

        //đọc token hiện tại
        private string Consume()
        {
            return input[pos];
        }

        #region phân tích biểu thức v2.0

        private bool ToanTuAm(string op)
        {
            if (op == "-")
            {
                if (pos == 0)
                    return true;
                //if ("+-*/(^".Contains(input[pos - 1])) return true;
                if (ND.IsMoNgoac(input[pos - 1]) || ND.IsToanTu2Ngoi(input[pos - 1]) || ND.IsToanTuLogic(input[pos - 1]))
                    return true;
            }
            return false;
        }
           
        private int DoUuTien(string op)
        {
            switch (op)
            {
                case "=":
                case "<":
                case "<=":
                case ">":
                case ">=":
                    return 2;
                case "+":
                case "-":
                    if (ToanTuAm("-"))
                        return 4;
                    return 3;
                case "*":
                case "/":
                    return 5;
                case "^":
                    return 6;
                case "!":
                    return 7;
            }
            return 0;
        }
        /*
        private int QuanHe(string op)
        {
            switch (op)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "=":
                
                case "^":
                case "<":
                case "<=":
                case ">":
                case ">=":
                    return 0;
                case "!":
                    return 1;
            }
            return 0;
        }
         */

        private string TaoBT(string t)
        {
            return t;
        }
        private string TaoBT(string op, string t)
        {
            if (op == "-")
                return "0" + ' ' + t + ' ' + op;
            return t + ' ' + op;
        }
        private string TaoBT(string op, string t1, string t2)
        {
            return t1 + ' ' + t2 + ' ' + op;
        }

        private string Eparser()
        {
            string t;
            if (error=="")
            {
                t = Exp(0);
                if (error=="" && Consume() == "END")
                {
                    return t + " END";
                }
                else
                    if (error == "") ERROR(3);
            }
            return null;
        }

        private string Exp(int p)
        {
            string t;
            t = P();
            if (error=="")
            {
                while (ND.IsToanTu(Consume()) && DoUuTien(Consume()) >= p)
                {
                    string op = Consume();
                    //int q = (QuanHe(op) == 0) ? 1 + DoUuTien(op) : DoUuTien(op);
                    int q = DoUuTien(op);
                    Go();
                    if (q < 7) // 7: độ ưu tiên cao 1-->toán tử 1 ngôi
                    {
                        string t1 = Exp(q);
                        t = TaoBT(op, t, t1);
                    }
                    else t = TaoBT(op, t);
                }
            }
            return t;
        }

        private string P()
        {
            string t = "";
            if (ToanTuAm(Consume()))
            {
                string op = Consume();
                int q = DoUuTien(op);
                Go();
                t = Exp(q);
                return TaoBT(op, t);
            }
            else if (ND.IsMoNgoac(Consume()))
            {
                Go();
                t = Exp(0);
                if (error=="")
                {
                    if (!ND.IsDongNgoac(Consume()))
                        ERROR(2);
                    else Go();
                }
            }
            else if (ND.IsSo(Consume()))
            {
                t = TaoBT(Consume());
                Go();
            }
            else if (ND.IsHam(Consume()))
            {
                string op = Consume();
                Go();
                string t1 = P();
                t = TaoBT(op, t1);
            }
            else if (Consume() == "END") ERROR(1);
            else ERROR(3);
            return t;
        }
        #endregion

    }
}
