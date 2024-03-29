using System;
using System.Collections.Generic;
using System.Text;

namespace BieuThuc_DAO
{
    class So
    {
        private double m_Val;
        private double Max_Val = double.MaxValue;
        private double Min_Val = double.MinValue;

        //mot so gia tri dinh nghia truoc
        private static So ZERO = new So();
        private static So ONE = new So(1);
        private static So PI = new So(3.141592653589793238);
        private static So E = new So(2.71828182845904512);
       
        private string error = "";

        public So()
        {
            m_Val = 0.0;
        }
        
        public So(double m_val)
        {
            m_Val = m_val;
        }

        public So(So s)
        {
            m_Val = s.m_Val;
        }
    
        public void Reset()
        {
            m_Val = 0.0;
        }

        public string Error
        {
            get
            {
                return error;
            }
        }

        public bool Input(string input)
        {
            if (this.Parse(input) == false)
            {
                error = "số sai định dạng";
                return false;
            }
            return true;
        }

        public string Output
        {
            get
            {
                return this.SoToString();
            }
        }
       
        //chuyen mot chuoi sang So
        public bool Parse(string str)
        {
            try
            {
                m_Val = Convert.ToDouble(str);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        //chuyen tu So sang string
        public string SoToString()
        {
            return m_Val.ToString();
        }

       
        #region cac phep toan

        // abs()
        public So Abs(So x)
        {
            if (x.m_Val < 0) x.m_Val = -x.m_Val;
            return new So(x.m_Val);
        }
        
        // a = -a
        public So Neg()
        {
            return new So(-m_Val);
        }

        // +
        public So Cong(So value)
        {
            if (Max_Val - value.m_Val < m_Val)
            {
                error = "số quá lớn";
                return null;
            }
            return new So( m_Val + value.m_Val);
        }
        
        // -
        public So Tru(So value)
        {
            value.m_Val = -value.m_Val;
            return Cong(value);
        }
      
        // *
        public So Nhan(So value)
        {
            if (value.TuongDuong(ZERO)) return ZERO;
            if (value.TuongDuong(ONE)) return this;
            if (Max_Val / value.m_Val < m_Val)
            {
                error = "số quá lớn";
                return null;
            }
            return new So(m_Val * value.m_Val);
        }
        
        // /
        public So Chia(So value)
        {
            if (value.TuongDuong(ZERO))
            {
                error = "chia cho 0";
                return null;
            }
            if (value.TuongDuong(ONE))
                return this;
            if (value.TuongDuong(this))
                return ONE;
            return new So(m_Val / value.m_Val);
        }
       
        // ^
        public So HamMu(int n)
        {
            if (n == 0)
                return ONE;
            So temp = this;
            if (n > 0)
            {
                for (int k = 1; k < n; k++)
                {
                    temp = temp.Nhan(this);
                    if (temp == null)
                        break;
                }
            }
            else
            {
                //a^-n = 1/a^n
                //tinh a^n
                n = -n;
                for (int k = 1; k < n; k++)
                {
                    temp = temp.Nhan(this);
                    if (temp == null)
                        break;
                }
                //xong lay 1 / a^n
                if (temp != null) temp = new So(1).Chia(temp);
            }
            if (temp == null) error = "so qua lon";
            return temp;
        }

        // !
        public long GiaiThua(int n)
        {
            if (n == 0) return 1;
            if (n < 0)
                error = "! khong xet so am";
            else
            {
                long t = 1L;
                for (int k = 1; k <= n; k++)
                {
                    if (t > Max_Val / k)
                    {
                        error = "so qua lon";
                        return -1;
                    }
                    t = t * k;
                }
                return t;
            }
            return -1;
        }

        // e ^ n
        public So e(int n)
        {
            return E.HamMu(n);
        }

        // Pi
        public So Pi()
        {
            return PI;
        }

        // e
        public So e()
        {
            return E;
        }

        // ln
        public So Lg(So x)
        {
            return new So(Math.Log10(x.m_Val));
        }

        // mod
        public So Mod(So x)
        {
            if (x.TuongDuong(ZERO))
            {
                error = "chia cho 0";
                return null;
            }
            if (this.TuongDuong(ZERO) || this.TuongDuong(x)) return ZERO;
            if (this.NhoHon(x)) return this;
            return new So(this.Tru(new So(x.Nhan(new So(this.m_Val / x.m_Val)))));
        }

        #endregion

        #region ham luong giac
        // sin
        public So Sin(So x)
        {
            //khai trien taylor: sin(x) = x - x^3/3! + x^5/5! + ... + (-1)^n*x^(2n+1)/(2n+1)! + ..
            if (x.TuongDuong(ZERO) || x.TuongDuong(new So(180))) return ZERO;
            if (x.TuongDuong(new So(90))) return ONE;
            if (x.TuongDuong(new So(180))) return ONE.Neg();
            return new So(Math.Sin(x.m_Val));
        }
        
        // cos
        public So Cos(So x)
        {
            //cos(x) = 1 - x^2/2! + x^4/4! -... + (-1)^n*x^2n/(2n)! + ...
            if (x.TuongDuong(ZERO)) return ONE;
            if (x.TuongDuong(new So(180))) return ONE.Neg();
            if (x.TuongDuong(new So(90)) || x.TuongDuong(new So(180))) return ZERO;
            return new So(Math.Cos(x.m_Val));
        }
       
        //tan
        public So Tan(So x)
        {
            So c = Cos(x);
            if (c.TuongDuong(ZERO))
            {
                error = "khong tồn tại tan(" + x.SoToString() + ")";
                return null;
            }
            return new So(Math.Tan(x.m_Val));
        }
        #endregion

        #region ham so sanh
        // >, >=
        public bool LonHon(So x)
        {
            return this.m_Val > x.m_Val;
        }
        public bool LonHonHoacBang(So x)
        {
            return this.m_Val >= x.m_Val;
        }

        // <, <=
        public bool NhoHon(So x)
        {
            return this.m_Val<x.m_Val;
        }
        public bool NhoHonHoacBang(So x)
        {
            return this.m_Val <= x.m_Val;
        }
        // ==
        public bool TuongDuong(So x)
        {
            return this.m_Val == x.m_Val;
        }
        #endregion

    }


}
