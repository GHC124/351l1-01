using System;
using System.Collections.Generic;
using System.Text;

namespace BieuThuc_DAO
{
    class GiaTri
    {
        private NhanDien ND; //so khop
        private So S1, S2, S3;
        private string[] input; //bieu thuc sau khi da tach thanh tung token
        private byte kich_thuoc_toi_da; //kich thuoc toi da cua bieu thuc input
        private string error;
        private int so_lan_lap; //do chinh xac cac phep tinh
        //
        public GiaTri()
        {
            ND = new NhanDien();
            S1 = new So();
            S2 = new So();
            S3 = new So();
            kich_thuoc_toi_da = 40; //toi da 40 token
            input = new string[kich_thuoc_toi_da];
            error = null;
            so_lan_lap = 5;
        }
        //
        public string Input
        {
            set
            {
                try
                {
                    input = value.Split(' ');
                }
                catch
                {
                    error = "Out of array ";
                }
            }
        }
        public string Output
        {
            get
            {
                return value();
            }
        }
        public string Error
        {
            get
            {
                return error;
            }
        }

        //xet bieu thuc, tinh toan bieu thuc
        private string value()
        {
            byte i = 0, j = 0;
            string[] v = new string[kich_thuoc_toi_da];
            while (input[i] != "END")
            {
                //ket thuc chuoi thi thoat

                // tinh toan cac toan tu 2 ngoi. vi du: + - * /
                if (ND.IsToanTu2Ngoi(input[i]))
                {
                    v[j - 2] = Tinh2Ngoi(v[j - 2], v[j - 1], input[i]);
                    j--;
                }
                // tinh toan cac toan tu 1 ngoi. vi du: !
                else if (ND.IsToanTu1Ngoi(input[i]))
                {
                    v[j - 1] = Tinh1Ngoi(v[j - 1], input[i]);
                }
                // tinh toan cac toan tu logic. vi du: =
                else if (ND.IsToanTuLogic(input[i]))
                {
                    v[j - 2] = TinhLogic(v[j - 2], v[j - 1], input[i]);
                    j--;
                }
                // tinh toan cac ham luong giac, ham gia tri
                else if (ND.IsHam(input[i]))
                {
                    if (ND.IsHamLuongGiac(input[i]))
                        v[j - 1] = TinhHamLuongGiac(input[i], v[j - 1]);
                    else if (ND.IsHamGiaTri(input[i]))
                        v[j - 1] = TinhHamGiaTri(input[i], v[j - 1]);
                }
                else //la So
                {
                    try
                    {
                        //so dac biet: vd: pi, e...
                        if (ND.IsSoDacBiet(input[i]))
                        {
                            v[j++] = SoDacBiet(input[i]);
                        }
                        // la so binh thuong: vd: 1.2
                        else v[j++] = input[i];
                    }
                    catch
                    {
                        error = "sai định đạng";
                    }
                }
                i++;
            }
            return (v[0] != null) ? v[0].ToString() : error;
        }

        //cac ham su dung
        #region Cac ham tinh toan
        //
        #region so dac biet
        //
        private string SoDacBiet(string s)
        {
            switch (s)
            {
                case "pi":
                    return "3.14";
                case "e":
                    return "2.71";
                default: error = "Rat tiec, gia tri: " + s + " chua tinh duoc";
                    return null;
            }
            return null;
        }
        #endregion
        //
        #region logic
        private string TinhLogic(string a, string b, string toantu)
        {
            string c = "";
            switch (toantu)
            {
                case "=": c = Bang(a, b);
                    break;
                case "<": c = NhoHon(a, b);
                    break;
                case "<=": c = Nho(a, b);
                    break;
                case ">": c = LonHon(a, b);
                    break;
                case ">=": c = Lon(a, b);
                    break;
                default: error = "Rat tiec, toan tu: " + toantu + " chua tinh duoc";
                    return null;
            }
            return c;
        }
        private string Bang(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                if (S1.TuongDuong(S2))
                    return "true";
                else return "false";
            }
            error = S1.Error;
            return null;
        }
        private string NhoHon(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                if (S1.NhoHon(S2))
                    return "true";
                else return "false";
            }
            error = S1.Error;
            return null;
        }
        private string Nho(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                if (S1.NhoHonHoacBang(S2))
                    return "true";
                else return "false";
            }
            error = S1.Error;
            return null;
        }
        private string LonHon(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                if (S1.LonHon(S2))
                    return "true";
                else return "false";
            }
            error = S1.Error;
            return null;
        }
        private string Lon(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                if (S1.LonHonHoacBang(S2))
                    return "true";
                else return "false";
            }
            error = S1.Error;
            return null;
        }
        #endregion
        //
        #region chuyen doi he so


        #endregion
        //
        #region tinh bieu thuc 1 ngoi
        //
        private string Tinh1Ngoi(string n, string toantu)
        {
            string c = "";
            switch (toantu)
            {
                case "!": c = GiaiThua(n);
                    break;
            }
            return c;
        }

        //!
        private string GiaiThua(string n)
        {
            //if (n > 10) return 1;
            int m = 0;
            try
            {
                m = Convert.ToInt32(n);
            }
            catch
            {
                error = "bieu thuc ! sai";
                return null;
            }
            long t = S1.GiaiThua(m);
            if (t == -1)
            {
                error = S1.Error;
                return null;
            }
            return t.ToString();
        }
        //
        #endregion
        //
        #region tinh bieu thuc 2 ngoi
        //
        private string Tinh2Ngoi(string a, string b, string toantu)
        {
            string c = "";
            switch (toantu)
            {
                case "+": c = Cong(a, b);
                    break;
                case "-": c = Tru(a, b);
                    break;
                case "*": c = Nhan(a, b);
                    break;
                case "/": c = Chia(a, b);
                    break;
                case "^": c = HamMu(a, b);
                    break;
                case "%": c = HamMod(a, b);
                    break;
                default: error = "Rat tiec, toan tu: " + toantu + " chua tinh duoc";
                    return null;
            }
            //S1.Reset();
            // S2.Reset();
            //  S3.Reset();
            return c;
        }
        //+
        private string Cong(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                S3 = S1.Cong(S2);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }
        //-
        private string Tru(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                S3 = S1.Tru(S2);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }
        //*
        private string Nhan(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                S3 = S1.Nhan(S2);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }
        // /
        private string Chia(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                S3 = S1.Chia(S2);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }
        // ^
        private string HamMu(string a, string b)
        {
            if (S1.Input(a))
            {
                int n = 0;
                try
                {
                    n = Convert.ToInt32(b);
                }
                catch
                {
                    error = "gia tri ham ^ nhap sai";
                    return null;
                }
                S3 = S1.HamMu(n);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }
        // %
        private string HamMod(string a, string b)
        {
            if (S1.Input(a) && S2.Input(b))
            {
                S3 = S1.Mod(S2);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }

        //
        #endregion
        //
        #region tinh ham luong giac
        //
        private string TinhHamLuongGiac(string tenham, string giatri)
        {
            string c = "";
            switch (tenham)
            {
                case "sin": c = Sin(giatri, so_lan_lap);
                    break;
                case "cos": c = Cos(giatri, so_lan_lap);
                    break;
                case "tan": c = Tan(giatri, so_lan_lap);
                    break;
                default:
                    error = "Rat tiec, ham: " + tenham + " chua tinh duoc";
                    return null;
            }
            
            return c;
        }

        //
        private string Sin(string giatri, int lap)
        {
            if (S1.Input(giatri))
            {
                S3 = S1.Sin(S1);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;

        }

        //cos
        private string Cos(string giatri, int lap)
        {
            if (S1.Input(giatri))
            {
                S3 = S1.Cos(S1);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }

        //tan
        private string Tan(string giatri, int lap)
        {
            if (S1.Input(giatri))
            {
                S3 = S1.Tan(S1);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }

        //
        #endregion
        //      
        #region tinh ham gia tri
        //
        private string TinhHamGiaTri(string tenham, string giatri)
        {
            string c = "";
            switch (tenham)
            {
                case "abs": c = Abs(giatri);
                    break;
                case "lg": c = Lg(giatri, so_lan_lap);
                     break;
                default:
                    error = "Rat tiec, ham: " + tenham + " chua tinh duoc";
                    return null;
            }
            return c;
        }

        // abs
        private string Abs(string giatri)
        {
            if (S1.Input(giatri))
            {
                S3 = S1.Abs(S1);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }
        // ln
        private string Lg(string giatri, int lap)
        {
            if (S1.Input(giatri))
            {
                S3 = S1.Lg(S1);
                if (S3 != null)
                    return S3.Output;
            }
            error = S1.Error;
            return null;
        }
        //
        #endregion
        //
        #endregion

    }
}
