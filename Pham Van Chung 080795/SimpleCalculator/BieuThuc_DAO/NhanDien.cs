using System;
using System.Text;
using System.Text.RegularExpressions;

namespace BieuThuc_DAO
{
    class NhanDien
    {
        //kiem tra chuoi, tach chuoi, ap dung quy tac bo dau *

        #region định nghĩa các thành phần của biểu thức

        private const string SoNguyen = @"(0|([1-9][0-9]*))";
        private const string SoPhay = @"((([1-9][0-9]*)|0)(\.[0-9]+)?)";
        private const string SoDacBiet = @"(pi|e)";
        private const string ToanTu1Ngoi = @"(!)";
        private const string ToanTu2Ngoi = @"([-/*+^%])";
        private const string ToanTuLogic = @"(=|<|<=|>|>=)";
        private const string HamLuongGiac = @"(sin|cos|tan|cotg)";
        private const string HamGiaTri = @"(abs|ln|lg)";
        private const string MoNgoac = @"\(";
        private const string DongNgoac = @"\)";
        
        private string So;
        private string ToanTu;
        private string Ham;
        private string Ngoac;
        private string Expression; //dinh dang bieu thuc
        
        private string error; //loi phat sinh

        #endregion
        
        public NhanDien()
        {
            So = SoPhay + "|" + SoDacBiet;
            ToanTu = ToanTu1Ngoi + "|" + ToanTu2Ngoi + "|" + ToanTuLogic;
            Ham = HamLuongGiac + "|" + HamGiaTri;
            Ngoac = MoNgoac + "|" + DongNgoac;
            //
            Expression = So + "|" + ToanTu + "|" + Ham + "|" + Ngoac;
            //
            error = null;
        }

        // tra ve loi
        public string Error
        {
            get { return error; }
        }

        private void ERROR(byte i)
        {
            switch (i)
            {
                case 0: error = "biểu thức dài quá";
                    break;
                case 1: error = "không có giá trị nhập";
                    break;
                case 2: error = "biểu thức sai";
                    break;
                case 3: error = "có nhiều hơn 2 toán tử logic";
                    break;
            }
        }
        
        #region nhận diện biểu thức v1.0

        // match token
        private bool ProcessMatch(string pattern, string input)
        {
            Regex re = new Regex(pattern);
            Match m = re.Match(input, 0, input.Length);
            if (m.Success)
                return true;
            return false;
        }
        
        //tach chuoi theo tung token, su dung quy tac rut gon
        private bool ProcessMatch(string pattern, string input, ref string[] output)
        {
            Regex re = new Regex(pattern);
            Match m = re.Match(input);
            int i = 0, j = 0;
            bool so_truoc = false, dong_ngoac_truoc = false, cong_truoc = false,
                //toán tử logic
                logic = false, tru_truoc = false, nho_hon = false, lon_hon = false;
            while (m.Success)
            {
                //kiểm tra tràn mảng
                if (i + 1 < output.GetUpperBound(0))
                {
                    #region quy tắc dấu *

                    //nếu giá trị trước đó là số...
                    if (so_truoc)
                    {
                        //...thì xét giá trị hiện tại...
                        //... 2sin, 2π, 2(
                        if (IsHam(m.Value) || IsSoDacBiet(m.Value) || IsMoNgoac(m.Value))
                        {
                            output[i++] = "*";
                        }
                        so_truoc = false;
                    }
                    if (IsSo(m.Value))
                        so_truoc = true;
                    //nếu giá trị trước đó là đóng ngoặc...
                    if (dong_ngoac_truoc)
                    {
                        //...thì xét giá trị hiện tại...
                        //...)(
                        if (IsMoNgoac(m.Value))
                        {
                            output[i++] = "*";
                        }
                        dong_ngoac_truoc = false;
                    }
                    if (IsDongNgoac(m.Value))
                        dong_ngoac_truoc = true;

                    #endregion
                    #region toán tử logic
                    if (logic)
                        if (IsToanTuLogic(m.Value))
                        {
                            ERROR(3);
                            return false;
                        }
                    if (nho_hon)
                    {
                        if (m.Value == "=")
                        {
                            //kiểm tra lỗi
                            if (m.Index != j)
                            {
                                ERROR(2);
                                return false;
                            }
                            else
                            {
                                output[i - 1] = "<=";
                                j += m.Length;
                                m = m.NextMatch();
                                continue;
                            }
                        }
                        nho_hon = false;
                    }
                    if (m.Value == "<")
                    {
                        nho_hon = true;
                        logic = true;
                    }
                    if (lon_hon)
                    {
                        if (m.Value == "=")
                        {
                            //kiểm tra lỗi
                            if (m.Index != j)
                            {
                                ERROR(2);
                                return false;
                            }
                            else
                            {
                                output[i - 1] = ">=";
                                j += m.Length;
                                m = m.NextMatch();
                                continue;
                            }
                        }
                        lon_hon = false;
                    }
                    if (m.Value == ">")
                    {
                        lon_hon = true;
                        logic = true;
                    }
                    if (m.Value == "=") logic = true;
                    #endregion
                    #region toán tử 1 ngôi
                    if (cong_truoc)
                    {
                        if (m.Value == "+")
                        {
                            //kiểm tra lỗi
                            if (m.Index != j)
                            {
                                ERROR(2);
                                return false;
                            }
                            else
                            {
                                output[i - 1] = "++";
                                j += m.Length;
                                m = m.NextMatch();
                                continue;
                            }
                        }
                        cong_truoc = false;
                    }
                    if (m.Value == "+") cong_truoc = true;
                    if (tru_truoc)
                    {
                        if (m.Value == "-")
                        {
                            //kiểm tra lỗi
                            if (m.Index != j)
                            {
                                ERROR(2);
                                return false;
                            }
                            else
                            {
                                output[i - 1] = "--";
                                j += m.Length;
                                m = m.NextMatch();
                                continue;
                            }
                        }
                        cong_truoc = false;
                    }
                    if (m.Value == "-") tru_truoc = true;
                    #endregion
                    //kiểm tra lỗi
                    if (m.Index != j)
                    {
                        ERROR(2);
                        return false;
                    }
                    else
                    {
                        output[i++] = m.Value;
                        j += m.Length;
                        m = m.NextMatch();
                    }
                }
                else
                {
                    ERROR(0);
                    return false;
                }
            }
            output[i] = "END";
            return true;
        }

        #endregion

        #region nhận diện biểu thức v2.0

        private bool ProcessMatch(string pattern, string input, ref int start, ref string output)
        {
            Regex reg = new Regex(pattern, RegexOptions.IgnoreCase);
            Match m = reg.Match(input, start);
            if (m.Success && m.Index == start)
            {
                start += m.Value.Length;
                output = m.Value;
                return true;
            }
            return false;
        }

        private void QuyTac(ref StringBuilder sb, string type, string input, ref int start, string output)
        {
            string value = string.Empty;

            switch (type)
            {
                case "SO": //2sin, 2pi, 2(
                    sb.Append(output); 
                    if (ProcessMatch(Ham + "|" + MoNgoac, input, ref start, ref value))
                    {
                        sb.Append(" * ");
                        sb.Append(value);
                    }
                    sb.Append(" ");
                    break;
                case "TOAN TU": //<=, >=
                    start--;
                    if (ProcessMatch(@"(<=|>=)", input, ref start, ref value))
                        sb.Append(value);
                    else
                    {
                        sb.Append(output);
                        start++;
                    }
                    sb.Append(" ");
                    break;
                case "DONG NGOAC": // )(, )2, )sin
                    sb.Append(output);
                    if (ProcessMatch(MoNgoac + "|" + So + "|" + Ham, input, ref start, ref value))
                    {
                        sb.Append(" * ");
                        sb.Append(value);
                    }
                    sb.Append(" ");
                    break;
                case "HAM":
                case "MO NGOAC":
                    sb.Append(output);
                    sb.Append(" ");
                    break;
            }
        }

        private bool ProcessMatch2(string input,ref string[] output)
        {
            StringBuilder sb = new StringBuilder();
            string _output = String.Empty;
            string type = String.Empty;

            for (int i = 0; i < input.Length; )
            {
                type = string.Empty;

                if (ProcessMatch(So, input, ref i, ref _output))
                    type = "SO";
                else if (ProcessMatch(ToanTu, input, ref i, ref _output))
                    type = "TOAN TU";
                else if (ProcessMatch(Ham, input, ref i, ref _output))
                    type = "HAM";
                else if (ProcessMatch(MoNgoac, input, ref i, ref _output))
                    type = "MO NGOAC";
                else if (ProcessMatch(DongNgoac, input, ref i, ref _output))
                    type = "DONG NGOAC";
                if (type.Length != 0)
                    QuyTac(ref sb, type, input, ref i, _output);
                else
                {
                    ERROR(2);
                    return false;
                }

            }
            string s = sb.ToString().Trim() + " END";
            output = s.Split(' ');
            
            return true;
        }

        #endregion

        //
        #region So khớp

        public bool IsMoNgoac(string input)
        {
            return ProcessMatch(MoNgoac, input);
        }
        public bool IsDongNgoac(string input)
        {
            return ProcessMatch(DongNgoac, input);
        }
        public bool IsSoNguyen(string input)
        {
            return ProcessMatch(SoNguyen, input);
        }
        public bool IsSoPhay(string input)
        {
            return ProcessMatch(SoPhay, input);
        }
        public bool IsSoDacBiet(string input)
        {
            return ProcessMatch(SoDacBiet, input);
        }
        public bool IsSo(string input)
        {
            return ProcessMatch(So, input);
        }
        public bool IsToanTu1Ngoi(string input)
        {
            return ProcessMatch(ToanTu1Ngoi, input);
        }
        public bool IsToanTu2Ngoi(string input)
        {
            return ProcessMatch(ToanTu2Ngoi, input);
        }
        public bool IsToanTuLogic(string input)
        {
            return ProcessMatch(ToanTuLogic, input);
        }
        public bool IsToanTu(string input)
        {
            return ProcessMatch(ToanTu, input);
        }
        public bool IsHamLuongGiac(string input)
        {
            return ProcessMatch(HamLuongGiac, input);
        }
        public bool IsHamGiaTri(string input)
        {
            return ProcessMatch(HamGiaTri, input);
        }
        public bool IsHam(string input)
        {
            return ProcessMatch(Ham, input);
        }

        #endregion

        public bool TachChuoiNhapVao(string input, ref string[] output)
        {
            input = input.Replace(" ", "");//bo tat ca khoang trang
            //return ProcessMatch(Expression, input, ref output);
            return ProcessMatch2(input, ref output);
        }
    }
}
