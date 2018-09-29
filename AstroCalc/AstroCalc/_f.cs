using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AstroCalc
{
    public sealed class _f
    {
        private static int q = 90;
        private static float e = 23.4523f;
        private static float pi = 3.141592654f;
        private static float rd = pi / 180;

        public static float refgms(float c, out int c1, out int c2, out int c3)
        {
            //Function refgms(c, c2, c3)
            string hs = "000000" + ((long)(c * 10000)).ToString().Trim();  //     hs$ = "000000" + LTrim$(Str(CLng(c * 10000)))
            c3 = int.Parse(Right(hs, 2));           //     c3 = Val(Right$(hs$, 2))
            c2 = int.Parse(Right(((int.Parse(hs) - c3) / 100).ToString().Trim(), 2)); // c2 = Val(Right$(LTrim$(Str((Val(hs$) - c3) / 100)), 2))
            c1 = int.Parse(((int.Parse(hs) - c3 - c2 * 100) / 10000).ToString().Trim()); //.Substring(0, hs.Length - 4));  //     c1 = Val(Mid$(LTrim$(Str((Val(hs$) - c3 - c2 * 100) / 10000)), 1, Len(hs$) - 4))
            if (c3 >= 30) c2 = c2 + 1; //     If c3 >= 30 Then c2 = c2 + 1
            if (c2 > 59) { c1 = c1 + 1; c2 = c2 - 60; }
            return c1;


        }

        public static int acote(float c, out int c2)
        {
            int c3, c1;

            float za = _f.refgms(c, out c1, out c2, out c3);
            while (za >= 30)
            {
                za = za - 30;
            }
            //Do
            //   If za < 30 Then Exit Do
            //   za = za - 30       ''''' '+ decnum$(C3) + CHR$(34)
            //Loop
            //c1 = Int(za): c3 = Int(c3)
            c1 = int.Parse(za.ToString());
            return c1;
            //End Function
        }
        public static string roman(int nu)
        {
            //Function roman$(nu%)
            string rom = "   I  II III  IV   V  VI VIIVIII  IX   X  XI XII";
            return rom.Substring((nu - 1) * 4, 4);

        }
        public static string decnum(int y)
        {
            //  Function decnum$(y)
            string xq = y.ToString().Trim();
            if (xq.Length < 2) xq = " " + xq;
            return xq;

        }
        public static float enggmmss(float c)
        {
            int c1, c2, c3;
            return enggmmss(c, out  c1, out c2, out c3);

        }
        public static float enggmmss(float c, out int c1, out int c2, out int c3)
        {
            float cc = c;
            c1 = (int)Math.Truncate(cc);
            cc = c - c1;
            c2 = (int)Math.Truncate(cc * 60);
            c3 = (int)((cc * 60 - c2) * 60);
            cc = c1 + 0.01f * c2 + 0.0001f * c3;
            cc = (int)Math.Truncate(cc * 10000) / 10000f;
            return cc;
        }
        public static float endecimal(float c)
        {
            float cc = c;
            int c1 = (int)Math.Truncate(cc);
            cc = cc - c1;
            int c2 = (int)Math.Truncate(cc * 100f);
            float c3 = 100f * cc - c2;
            cc = c1 + c2 / 60f + c3 / 36f;
            return cc;
        }

        public static float bajo360(float c)
        {
            float c1;
            c1 = c;
            c1 = c1 - 360 * VBInt(c1 / 360);
            return c1;
            //End Function
        }
        public static int VBInt(double arg)
        {
            int rr = 0, b = Math.Sign(arg);
            if (b < 0)
            {
                rr = b * (int)Math.Ceiling(Math.Abs(arg));
            }
            else
            {
                rr = (int)Math.Truncate(arg);
            }
            return rr;
        }
        public static float mdospi(float a, float b)
        {
            float c = q * Math.Sign(a);
            if (b != 0)
            {
                c = (float)Math.Atan(a / b);
                c = c / rd;
            }
            //if (n == q) c = c + 2 * q;
            if (b < 0) c = c + 2 * q;
            c = bajo360(c);
            return c;
        }
        public static float endecien(float c)
        {
            float c1 = (float)Math.Truncate(c);
            float D = c - c1;
            float c2 = (float)Math.Truncate(D * 100);
            float c3 = 100 * D - c2;
            return c1 + c2 / 60 + c3 / 36;
        }

        public static float momo(float ac)
        {
            float a = ac;
            //Function momo(a)
            a = (float)Math.Atan(a / (float)Math.Sqrt(-a * a + 1));
            a = a * 180 / pi;
            return a;
        }
        public static string Right(string original, int numberCharacters)
        {
            if (original.Length - numberCharacters > 0)
                return original.Substring(original.Length - numberCharacters);
            else return original;
        }
        public static string Left(string original, int numberCharacters)
        {
            return original.Substring(0, numberCharacters);
        }
    }
}
