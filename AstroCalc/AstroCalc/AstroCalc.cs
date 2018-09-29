using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using SD = System.Drawing;
namespace AstroCalc
{
    public class AstroCalc
    {

        private float uhora;
        private float uhorazonal;
        private float ulongit;
        private float ulatit;
        private float uDiita;
        private float uMessa;
        private float uAnoru;

        public string sNombre;
        public string sLugar;
        public string sDianac;
        public string sHoranac;
        private AstralSet mvarResultSet; //As ResultSet

        public AstralSet astralSet
        {
            get { return mvarResultSet; }
            set { mvarResultSet = value; }
        }
        private float[] arcasas = new float[38]; //(37); //As Single
        private object conn; //As Object
        private string[] aspinf; //As String * 12

        private float hora;//!
        private float horazonal;//!
        private float longit;//!
        private float latit;//!
        private float g = 0;//!
        private float ta;//!
        private float sa;//!
        private float ru;//!
        private string nom;//$
        private string city;//$
        public string msghsl;//$

        private float[] DAT = new float[80]; // As Single
        private float[] DOP = new float[8]; // As Single
        float[] erg = new float[26]; // As Single
        private IdPlanets[] shw = new IdPlanets[14]; // As IdPlanets
        private IdCasa[] shc = new IdCasa[7]; // As IdCasa
        private string[] bk = new string[25];// bk$(24)
        private int nnew;//  nnew%
        private string rtr;//  rtr$
        private float[] mxm = new float[15];//  mxm(15) As Single
        private float[] cas = new float[12];// cas(12) As Single
        private string[] mono = new string[12];//  mono$(1 To 12)
        private asptipo[,] aspc = new asptipo[13, 13];// aspc(12, 12) As asptipo
        private posplatipo[] ui = new posplatipo[12];//  ui(12) As posplatipo
        private string[] plt = new string[14];// plt$(14)
        private string[] plx = new string[16];//  plx$(16)
        private string[] apc = new string[5];// apc$(5)
        private string[] monx = new string[12];//  monx$(1 To 12)

        private guytipo person;// As guytipo
        private despart indito;// As despart
        private float ef = 4 * (600 / 200) / 31; // As Single
        private string see, p = "E:", s;
        private float delta; //!

        private static int q = 90;
        private static float e = 23.4523f;
        private static float pi = 3.141592654f;
        private static float rd = pi / 180;
        private static int[,] validpos = new int[3, 57];// -16 To 40]



        public AstroCalc(string nombv, float diav, float mesv, float anov, float horav, float minuv,
            string lugarv, float tzonev, float lngtv, float lattv)
        {
            uhora = horav + minuv / 100; //'person.hora:
            uhorazonal = tzonev;// 'person.tzone
            ulongit = lngtv;// 'person.lng:
            ulatit = lattv;// 'person.lat
            uDiita = diav;//  'Val(dia$):
            uMessa = mesv;//  'Val(mas$):
            uAnoru = anov; //  'Val(ano$)
            sNombre = nombv;
            sLugar = lugarv;
            sDianac = diav + "-" + mesv + "-" + anov;
            string lahor = uhora.ToString("0#.:#0");
            sHoranac = lahor.Substring(1, 2) + lahor.Substring(lahor.Length - 3, 3);// & Right(lahor$, 3)

            DAT[0] = 0f;
            DAT[1] = 0.387099f;
            DAT[2] = 0.2056275f;
            DAT[3] = 47.85714f;
            DAT[4] = 0.0118544f;
            DAT[5] = 76.83311f;
            DAT[6] = 0.01555769f;
            DAT[7] = 222.6217f;
            DAT[8] = 1494.741f;
            DAT[9] = 7.003972f;
            DAT[10] = 0f;
            DAT[11] = 0.723332f;
            DAT[12] = 0.00679f;
            DAT[13] = 76.31969f;
            DAT[14] = 0.009004011f;
            DAT[15] = 131.0083f;
            DAT[16] = 0.01406859f;
            DAT[17] = 174.2943f;
            DAT[18] = 585.1921f;
            DAT[19] = 3.304278f;
            DAT[20] = 0f;
            DAT[21] = 1.523691f;
            DAT[22] = 0.093372f;
            DAT[23] = 49.24903f;
            DAT[24] = 0.007709388f;
            DAT[25] = 335.3227f;
            DAT[26] = 0.01841086f;
            DAT[27] = 258.7673f;
            DAT[28] = 191.417f;
            DAT[29] = 1.849889f;
            DAT[30] = 0f;
            DAT[31] = 5.202803f;
            DAT[32] = 0.04844f;
            DAT[33] = 100.0444f;
            DAT[34] = 0.01010972f;
            DAT[35] = 13.67822f;
            DAT[36] = 0.01611332f;
            DAT[37] = 259.8145f;
            DAT[38] = 30.36469f;
            DAT[39] = 1.305083f;
            DAT[40] = 0f;
            DAT[41] = 9.528843f;
            DAT[42] = 0.05566f;
            DAT[43] = 113.3075f;
            DAT[44] = 0.008731755f;
            DAT[45] = 92.26447f;
            DAT[46] = 0.01959435f;
            DAT[47] = 280.6714f;
            DAT[48] = 12.2351f;
            DAT[49] = 2.489694f;
            DAT[50] = 0f;
            DAT[51] = 19.18228f;
            DAT[52] = 0.04722f;
            DAT[53] = 73.79628f;
            DAT[54] = 0.005106254f;
            DAT[55] = 170.0109f;
            DAT[56] = 0.01624111f;
            DAT[57] = 141.305f;
            DAT[58] = 4.299108f;
            DAT[59] = 0.7730833f;
            DAT[60] = 0f;
            DAT[61] = 30.05708f;
            DAT[62] = 0.008578f;
            DAT[63] = 131.3398f;
            DAT[64] = 0.01101817f;
            DAT[65] = 44.27392f;
            DAT[66] = 0.008781757f;
            DAT[67] = 216.9409f;
            DAT[68] = 2.198554f;
            DAT[69] = 1.773278f;
            DAT[70] = 0f;
            DAT[71] = 39.591f;
            DAT[72] = 0.249f;
            DAT[73] = 109.7333f;
            DAT[74] = 0.014f;
            DAT[75] = 223.2833f;
            DAT[76] = 0.014f;
            DAT[77] = 180.1815f;
            DAT[78] = 1.453402f;
            DAT[79] = 17.13333f;

            for (int i = 1; i <= 13; i++)
            {
                plt[i] = "Sol ,Luna,Merc,Vens,Mart,Jupi,Satr,Uran,Nept,Plut,Nodo,Asc.,Mhv.".Substring((i - 1) * 5, 4);
                bk[(i - 1) * 2] = " ";
            }
            plx = ", Sol ,Luna,Mercurio,Venus,Marte,Jupiter,Saturno,Urano,Neptuno,Pluton,Nodo,Ascendente,Medio Cielo,Descendente,Nadir,".Split(',');
            //uy = 0;
            //For i = 1 To 15:
            //  cb$ = "Sol ,Luna,Mercurio,Venus,Marte,Jupiter,Saturno,Urano,Neptuno,Pluton,Nodo,Ascendente,Medio Cielo,Descendente,Nadir,"
            //  luy% = uy% + 1:
            //  uy% = InStr(luy%, cb$, ",")
            //  plx$(i) = Mid(cb$, luy%, uy% - luy%)
            //Next i
            apc = ", Conjunción, Sextil, Cuadratura, Trino, Oposición,".Split(',');
            //uy% = 0
            //For i = 1 To 5:
            //  cb$ = "Conjunción, Sextil, Cuadratura, Trino, Oposición,"
            //  luy% = uy% + 1:
            //  uy% = InStr(luy%, cb$, ",")
            //  apc$(i) = Mid(cb$, luy%, uy% - luy%)
            //Next i
            mono = ", Ari, Tau, Gem, Can, Leo, Vir, Lib, Sco, Sag, Cap, Acu, Pis,".Split(',');
            //uy% = 0
            //For i = 1 To 12:
            //  cb$ = " Ari, Tau, Gem, Can, Leo, Vir, Lib, Sco, Sag, Cap, Acu, Pis,"
            //  luy% = uy% + 1:
            //  uy% = InStr(luy%, cb$, ",")
            //  mono$(i) = Mid(cb$, luy%, uy% - luy%)
            //Next i
            monx = ", Aries, Tauro, Geminis, Cancer, Leo, Virgo, Libra, Scorpio, Sagitario, Capricornio, Acuario, Piscis,".Split(',');
            //uy% = 0
            //For i = 1 To 12:
            //  cb$ = " Aries, Tauro, Geminis, Cancer, Leo, Virgo, Libra, Scorpio, Sagitario, Capricornio, Acuario, Piscis,"
            //  luy% = uy% + 1:
            //  uy% = InStr(luy%, cb$, ",")
            //  monx$(i) = Mid(cb$, luy%, uy% - luy%)
            //Next i




            mvarResultSet = new AstralSet();


        }

        public void CalculaPosiciones()
        {
            hora = uhora;// '+ minuv / 100 'person.hora:
            horazonal = uhorazonal;// 'person.tzone
            longit = ulongit;// 'person.lng:
            latit = ulatit;// 'person.lat
            ta = uDiita;//  'Val(dia$):
            sa = uMessa;//  'Val(mas$):
            ru = uAnoru;//  'Val(ano$)
            mvarResultSet = new AstralSet();
            int c1, c2, c3;
            float j = 0, k = 0, m = 0, h = 0;
            float lz = hora; float hz = horazonal;
            g = (float)Math.Round(15 * _f.endecimal(lz) - 15 * _f.endecimal(-hz), 2);
            float hg = _f.enggmmss(g / 15, out c1, out c2, out c3);

            float lo = _f.endecimal(longit);
            float latd = _f.endecimal(latit);
            //'r$ = " "
            g = g - 5;
            float djj = diajuliano(g, ru, ta, sa, lo, ref j, ref k, ref m, ref h);
            float i = 0, f = 0;

            elsol(j, k, m, ref i, ref f);


            for (int Planet = 1; Planet <= 8; Planet++)
            {
                planetas(Planet, j, k, f, i); //: Next ' erg(planet% * 2 + 3) = c!: NEXT
            }
            g = g + 5; rtr = " ";
            int yagraph = 0;
            float c = diajuliano(g, ru, ta, sa, lo, ref j, ref k, ref m, ref h);
            float hsl = c / 15; float lst = _f.enggmmss(c / 15, out c1, out c2, out c3);

            //''LOCATE 2, 1: ' rg$ = Str(INT(hg!)) + "h." + Str(INT((hg! - INT(hg!)) * 100)) + "m."
            //msghsl = "H.S.L.:" + Str(c1) + "h." + Str(c2) + "m. H.Grw.:" + Str(Int(hg!)) + "h." + Str(Int((hg! - Int(hg!)) * 100)) + "m."
            msghsl = "H.S.L.:" + c1.ToString() + "h." + c2.ToString() + "m. H.Grw.:" + (Math.Truncate(hg)).ToString() + "h." + (Math.Truncate((hg - Math.Truncate(hg)) * 100)).ToString() + "m.";
            elsol(j, k, m, ref i, ref f); //            elsol j!, k!, m!, i!, f!:
            GetPlanet(1, plt[1], this.erg[1], rtr);
            impconsig(ref shw[1], this.erg[1], rtr); //: Rem  SOL

            float r, xl;
            laluna(j, k, m, out  r, out xl); //            laluna j!, k!, m!, r!, xl!:
            GetPlanet(2, plt[2], erg[3], rtr);
            impconsig(ref shw[2], erg[3], rtr); //: Rem LUNA
            for (int Planet = 1; Planet <= 8; Planet++)
            {
                planetas(Planet, j, k, f, i); rtr = bk[Planet * 2 + 2];
                GetPlanet(Planet + 2, plt[Planet + 2], erg[Planet * 2 + 3], rtr);
                impconsig(ref shw[Planet + 2], erg[Planet * 2 + 3], rtr);

            }
            float v; string cb; float hato;
            elnodo(j, k, out v, out c, out cb);
            GetPlanet(11, plt[11], erg[21], rtr);
            impconsig(ref shw[11], erg[21], rtr); //: Rem NODO
            rtr = " ";
            for (int casa = 1; casa <= 6; casa++)
            { //   '12
                cas[casa] = lacasa(casa, h, latd, out hato, out cb);
                GetCasa(1 * casa, cas[casa]);
                string Msg = impcasa(casa, cas[casa]);
                if (casa == 1)
                {
                    erg[22] = hato; erg[23] = _f.enggmmss(erg[22]);
                    GetPlanet(12, plt[12], erg[23], "");
                    impconsig(ref shw[12], erg[23], "");
                }
                if (casa == 4)
                {// Then
                    erg[24] = _f.bajo360(hato + 360); erg[25] = _f.enggmmss(erg[24]);
                    GetPlanet(13, plt[13], erg[25], "");
                    impconsig(ref shw[13], erg[25], "");
                }//End If
            }
            float lcat = 0, cicl = 0;
            for (int cat = 1; cat <= 37; cat++)
            {
                int ct = cat % 12; if (ct == 0) ct = 12;
                int smc = 0; if (ct > 6) { smc = 1; ct = ct - 6; }
                float gt = _f.bajo360(cas[ct] + smc * 180) + cicl * 360;
                if (_f.bajo360(lcat) > _f.bajo360(gt))
                { //Then
                    cicl = cicl + 1;
                    gt = _f.bajo360(cas[ct] + smc * 180) + cicl * 360;
                } //End If
                arcasas[cat] = gt;
                lcat = gt;
            }//Next cat
            //'planetas en las casas
            for (int pis = 0; pis <= 10; pis++)
            {
                float testing = erg[pis * 2 + 1];
                int tc = cualcasa(testing); //'tc=casa
                AddHousetoPlanet(pis + 1, tc);
                //ms$ = roman$(tc + 0)
                shw[pis + 1].h0 = tc;
                shw[pis + 1].h = _f.roman(tc + 0);// ms$
            } //Next this
            CalcAspectos();
        }
        void CalcAspectos()
        {
            //Sub CalcAspectos()
            int s, r, knd = 0, ina = 0, inb = 0; //Dim s%, r%
            string asp = "";
            //'  ape% = FreeFile: Open App.Path & "\astaspc.dat" For Random As ape% Len = Len(arraspinf)
            for (s = 0; s <= 20; s = s + 2)
            {
                for (r = s + 2; r <= 24; r = r + 2)
                {
                    ina = (int)Math.Truncate((float)s / 2);
                    inb = (int)Math.Truncate((float)r / 2);
                    int y = (ina) * 5 + 1; int x = (inb) + 14; string cud = ".:...";
                    if (r <= 20)
                    {// Then
                        //'           Pat x%, y%, cud$:
                    }
                    else
                    { //     'IF r > 20 THEN
                        y = (inb) * 5 + 16; x = (ina) + 14;
                        //'            Pat x%, y%, cud$
                    } //End If         'len(see$)
                    this.aspc[s / 2, r / 2].see = "   ";
                    this.aspc[s / 2, r / 2].kind = 0;
                    float a = Math.Abs(erg[r] - erg[s]);
                    if (a > 2 * 90) a = 4 * 90 - a;
                    int c = 30 * (int)Math.Truncate((a + 9) / 30);
                    float D = Math.Abs(c - a);
                    int ESP = 0;
                    if (c == 60 || r >= 20)
                    {
                        D = 2 * D;
                        ESP = 1;
                    }
                    bool medorb = false, vira = false;

                    if (c == 30) { knd = 0; vira = true; }
                    if (c == 150) { knd = 0; vira = true; }
                    if (D >= 12) { knd = 0; vira = true; }
                    if (vira == false)
                    {
                        if (s + r == 2) medorb = true;
                        if (D > 10) { knd = 0; vira = true; }
                        if (s < 3) medorb = true;
                        if (D > 8) { knd = 0; vira = true; }
                        //medorb:
                        if (vira == false)
                        {
                            if (ESP == 1) D = D / 2;
                            switch (c)
                            {
                                case 0: asp = "cnj"; knd = 1; break;// '"¢"
                                case 60: asp = "sxt"; knd = 2; break;// '"*"
                                case 90: asp = "cdr"; knd = 3; break;// '"þ"
                                case 120: asp = "trn"; knd = 4; break;// '""
                                case 180: asp = "ops"; knd = 5; break;// '"ô"
                            } //End Select
                            //'  d = INT(d + .5)
                            int tc = ina; int dh = inb; int sw = 0;
                            if (tc > dh) { sw = dh; dh = tc; tc = sw; }// Then SWAP tc, dh
                            int sh = 0;
                            for (int dt = 0; dt <= tc - 1; dt++) { sh = sh + (12 - dt); }// Next dt
                            int ood = knd - 1;
                            int dev = sh * 5 + ood * (12 - tc) + dh - tc;
                            //'Get ape%, dev, arraspinf
                            if (D + 1 > 12)
                            {// Then GoTo vira
                                knd = 0; vira = true;
                            }
                            else
                            {
                                // no solo con informe
                                //if ((int)(aspinf[dev].Substring((int)(D) + 1, 1))[0] > 0)
                                //{//if (Asc(aspinf[dev].Substring((int)(D) + 1, 1)) > 0) {//Then
                                aspc[ina, inb].see = asp;
                                aspc[ina, inb].kind = knd;
                                aspc[inb, ina].kind = knd;
                                aspc[ina, inb].dev = D;
                                Aspect rel1 = new Aspect(ina, inb, asp, knd, D);
                                rel1.planet1 = plt[ina + 1];
                                rel1.planet2 = plt[inb + 1];
                                mvarResultSet.Aspects.Add(rel1.sKey, rel1);
                                Aspect rel2 = new Aspect(inb, ina, asp, knd, D);
                                rel2.planet1 = plt[inb + 1];
                                rel2.planet2 = plt[ina + 1];
                                mvarResultSet.Aspects.Add(rel2.sKey, rel2);
                                if (r <= 20)
                                {// Then
                                    //'          Mid$(see$, (x% - 1) * 80 + y%, Len(asp$)) = asp$
                                }
                                else
                                { //Else      //'IF r > 20 THEN
                                    y = (inb) * 5 + 16; x = (ina) + 14;
                                    //'           Mid$(see$, (x% - 1) * 80 + y%, Len(asp$)) = asp$
                                } //End If         //'len(see$)
                                //no solo con informe       } //End If
                                knd = 0;
                            }
                        }
                    }
                } //Next r
            } //Next s
            //'Close ape%

            //End Sub

        }
        float diajuliano(float g, float ru, float ta, float sa, float lo,
            ref float j, ref float k, ref float m, ref float h)
        {
            //Private Function diajuliano(g!, ru!, ta!, sa!, lo!, j!, k!, m!, h!) As Single
            //'Dim c      '       ENTRA G,R,T,S,L,Q
            //'SHARED Q, c     '       ENTRA G,R,T,S,L,Q
            //     'HRGW = g: AIO = ru: DIA = ta: mes = sa: LOPG = lo
            k = ru + 10000f;
            float a = sa + 1;
            if (sa < 3)
            {
                k = k - 1;
                a = a + 12;
            }
            //dDay = ta:
            //UP = (k + 1) / 4: ' IF UP - INT(UP) = 0 THEN TA = dDAY - 1

            k = ta - 4346448.5f + (int)Math.Truncate(30.6001f * a) + (int)Math.Truncate(365.25f * k)
                + (int)Math.Truncate(0.0025f * k) - (int)Math.Truncate(0.01f * k) + g / (4 * q);
            j = k / 365.25f / 100; //: ta = dDay
            float c = 279.69668f + 0.985647335f * k + 0.000303f * j * j;
            c = _f.bajo360(c); m = c;
            c = g - 2 * q - lo + m;
            c = _f.bajo360(c);
            h = c;
            //'           SALE DIA JUL = J,K,M,H
            //diajuliano = c!
            return c;
        }
        void elsol(float j, float k, float m, ref float i, ref float f)
        {

            // Private Sub elsol(j!, k!, m!, i!, f!)
            //'SHARED c, cb$',e
            //'SHARED Q, RD, PI, c, cb$',e
            //Rem CALC EL SOL , entra J,K,M,Q )) sale I,F

            float n = 281.22083f + 0.0000470684f * k + (0.000453f + 0.000003f * j) * j * j;
            float o = 0.01675104f - (0.0000418f + 0.000000126f * j) * j;
            float c = m - n;
            float D = c;
            for (int b = 1; b <= 3; b++)
            {
                D = D + (c - D + (float)(2 * q * o / pi * Math.Sin(D * rd))) / (float)(1 - o * Math.Cos(D * rd));
            }
            float a = (float)(Math.Sin(0.5 * D * rd) * Math.Sqrt((1 + o) / (1 - o)));
            float b0 = (float)Math.Cos(0.5 * D * rd);
            c = _f.mdospi(a, b0);
            c = n + 2 * c;
            c = _f.bajo360(c);
            i = c;
            f = 1 - o * (float)Math.Cos(D * rd);
            c = 259.183275f - 0.0529539222f * k;
            c = c + (0.002078f + 0.000002f * j) * j * j;
            float v = _f.bajo360(c);
            i = i - (0.0047872222f + 0.00000472222222f * j) * (float)Math.Sin(v * rd);
            string cb = "Sol ";
            int c1, c2, c3;
            c = i;
            c = _f.bajo360(c); c = _f.enggmmss(c, out c1, out c2, out c3);
            // Rem TERMINA CON EL SOL , sale I,F
            //     erg(1) = c: erg(0) = endecien(c)
            //End Sub
            erg[1] = c; erg[0] = _f.endecien(c);

        }
        void planetas(int Planet, float j, float k, float f, float i)
        {
            //Private Sub planetas(Planet%, j!, k!, f!, i!)
            //'SHARED c
            //'SHARED Q, RD, PI, c
            //Rem PLANET  ..ENTRA DAT(**), S= 0,10,20,30,40,50,60,70 ..J,K, SOL-!F,I
            float c;
            int s = (Planet - 1) * 10;
            for (int a1 = 3; a1 <= 7; a1 = a1 + 2)
            {
                //b = s + a;
                c = DAT[s + a1] + (100 * j - 60) * DAT[s + a1 + 1];
                DOP[a1] = _f.bajo360(c);
            }
            c = DOP[7] - DOP[5];
            c = _f.bajo360(c);
            float D = c; float o = DAT[s + 2];
            for (int b1 = 1; b1 <= 3; b1++)
            {
                D = D + (c - D + 2 * q * o / pi * (float)Math.Sin(D * rd)) / (1 - o * (float)Math.Cos(D * rd));
            }
            float n = DAT[s + 1] * (1 - o * (float)Math.Cos(D * rd));
            float a = (float)Math.Sin(0.5 * D * rd) * (float)Math.Sqrt((1 + o) / (1 - o));
            float b = (float)Math.Cos(0.5 * D * rd); c = _f.mdospi(a, b);
            b = DOP[5] - DOP[3] + 2 * c;
            c = DAT[s + 9]; a = (float)Math.Sin(c * rd) * (float)Math.Sin(b * rd); a = _f.momo(a); o = a;
            a = (float)Math.Cos(c * rd) * (float)Math.Sin(b * rd);
            b = (float)Math.Cos(b * rd); c = _f.mdospi(a, b);
            c = DOP[3] + c; c = _f.bajo360(c);
            float udd = c;
            a = n * (float)Math.Cos(o * rd) * (float)Math.Sin(udd * rd) + f * (float)Math.Sin(i * rd);
            b = n * (float)Math.Cos(o * rd) * (float)Math.Cos(udd * rd) + f * (float)Math.Cos(i * rd);
            c = _f.mdospi(a, b);
            float w = s / 5 + 4;
            //' erg(planet% * 2 + 3) = 0: IF a > 0 THEN erg(planet% * 2 + 3) = 1
            int in1 = (s / 10) + 3;
            if (c < erg[Planet * 2 + 2])
            {
                rtr = "R";
                bk[Planet * 2 + 2] = "R";
            }
            else
            {
                rtr = " ";
                bk[Planet * 2 + 2] = " ";
            }
            erg[Planet * 2 + 2] = c;
            a = i - c; D = udd - c; c = _f.enggmmss(c);
            erg[Planet * 2 + 3] = c;
            D = (float)Math.Atan((n * (float)Math.Sin(o * rd)) / (f * (float)Math.Cos(a * rd) + n * (float)Math.Cos(o * rd) * (float)Math.Cos(D * rd)));
            //      ': ERG(W + 1) = D / RD
            //'REM SALE PLANET  en ERG(4,6,8,10,12,14,16,18)


        }



        private void GetPlanet(int PLId, string seed, float posit, string retro)
        {
            //Sub GetPlanet(PLId, seed As String, posit!, retro$)
            Planet Plnet = new Planet();// As Planet
            float za;
            Plnet.who = PLId;
            Plnet.see = seed;
            Plnet.plt = plt[PLId];
            Plnet.plx = plx[PLId];
            int c1, c2, c3;
            za = _f.refgms(posit, out c1, out c2, out c3);

            c1 = (int)Math.Truncate(za % 30);
            Plnet.sh = "" + _f.Right("  " + c1, 2) + "º" + _f.Right("  " + c2, 2) + "'";
            Plnet.r = retro;
            Plnet.sg0 = (int)za / 30 + 1; // = za \ 30 + 1
            Plnet.sg = (mono[Plnet.sg0]).Trim(); // = Trim("" & mono(za \ 30 + 1))
            Plnet.p = posit;
            //'retro$ = " "
            mvarResultSet.Planets.Add(seed, Plnet); //  Plnet = mvarResultSet.Planets.Add(PLId, seed);

        }
        private void impconsig(ref IdPlanets cb, float posit, string retro)
        {
            //Sub impconsig(cb As IdPlanets, posit!, retro$)
            int c1, c2, c3;
            float za;
            za = _f.refgms(posit, out c1, out c2, out c3);
            c1 = (int)Math.Truncate(za % 30);
            cb.sh = "" + _f.Right("  " + c1, 2) + "º" + _f.Right("  " + c2, 2) + "'";
            cb.r = retro;
            cb.sg0 = (int)za / 30 + 1;
            cb.sg = ("" + mono[cb.sg0]).Trim();
            cb.p = posit;
            //retro$ = " "

        }
        string impcasa(int ha, float c)
        {
            //Function impcasa$(ha%, c!)
            int c1, c2, c3;
            float za = _f.refgms(c, out c1, out c2, out c3); c1 = (int)Math.Truncate(c) % 30;
            shc[ha].sg0 = (int)Math.Truncate(c) / 30 + 1;
            shc[ha].sg = mono[shc[ha].sg0].Trim();
            shc[ha].so = mono[(int)Math.Truncate(_f.bajo360(c + 180)) / 30 + 1].Trim();
            shc[ha].sh = _f.decnum(c1) + "º" + _f.decnum(c2) + "'";
            return "";


        }
        void laluna(float j, float k, float m, out float r, out float x)
        {
            //            Private Sub laluna(j, k, m, r, x)
            //'''''SHARED c, cb$', e
            //'SHARED Q, RD, PI, c, cb$, e
            // Rem  LA LUNA  ..ENTRA J,K,   SALE R,X
            float n = 281.22083f + 0.0000470684f * k + (0.000453f + 0.000003f * j) * j * j;
            float t = _f.bajo360(270.434358f + 13.1763965f * k - (0.001133f - 0.0000019f * j) * j * j);
            float ul = _f.bajo360(334.329652f + 0.11140408f * k - (0.010325f + 0.000012f * j) * j * j);
            float v = _f.bajo360(259.183275f - 0.0529539222f * k + (0.002078f + 0.000002f * j) * j * j);
            float s = 0.054900489f;
            float c = t - ul;
            float D = c;
            for (int b1 = 1; b1 <= 3; b1++)
            {
                D = D + (c - D + 2 * q * s / pi * (float)Math.Sin(D * rd)) / (1 - s * (float)Math.Cos(D * rd));
            }
            float a = (float)Math.Sin(0.5 * D * rd) * (float)Math.Sqrt((1 + s) / (1 - s));
            float b = (float)Math.Cos(0.5 * D * rd); c = _f.mdospi(a, b);
            float w = 5.14539637f;
            b = ul - v + 2 * c; a = (float)Math.Cos(w * rd) * (float)Math.Sin(b * rd);
            float a0 = a; a = (float)Math.Sin(w * rd) * (float)Math.Sin(b * rd); a = _f.momo(a);
            x = a; a = a0;
            b = (float)Math.Cos(b * rd); c = _f.mdospi(a, b);
            float LUN = _f.bajo360(v + c);
            a = t - m; b = t - ul; c = m - n;
            LUN = LUN + 1.2739f * (float)Math.Sin((2 * a - b) * rd) + 0.6583f * (float)Math.Sin(2 * a * rd) - 0.1856f * (float)Math.Sin(c * rd) - 0.0374f * (float)Math.Sin(a * rd);
            string cb = "Luna"; c = _f.enggmmss(_f.bajo360(LUN));
            erg[3] = c; erg[2] = _f.endecien(c);
            //'PRINT n, s, w, t, ul, M, c
            //Rem TERMINA LA LUNA
            r = c;
        }
        void GetCasa(int ha, float c)
        {
            //Sub GetCasa(ha%, c!)
            House oCasa; int c1, c2, c3;
            float za = _f.refgms(c, out c1, out c2, out c3); c1 = (int)Math.Truncate(c) % 30;
            oCasa = new House();
            oCasa.sg0 = (int)Math.Truncate(c) / 30 + 1;
            oCasa.sg = mono[oCasa.sg0].Trim();
            oCasa.so = mono[(int)Math.Truncate(_f.bajo360(c + 180)) / 30 + 1].Trim(); //  oCasa.so = Trim("" & mono$(Int(bajo360(c + 180)) \ 30 + 1))
            oCasa.sh = (_f.decnum(c1) + "º" + _f.decnum(c2) + "'");
            oCasa.romqi = _f.roman(ha);
            oCasa.romla = _f.roman((ha + 6) % 12 == 0 ? 12 : (ha + 6) % 12);
            oCasa.ha = ha;
            //'impcasa$ = ""
            mvarResultSet.Houses.Add(ha.ToString(), oCasa);

        }
        void elnodo(float j, float k, out float v, out float c, out string cb)
        {
            //Private Sub elnodo(j, k, v, c!, cb$)
            //Rem EL NODO DE LA LUNA .. ENTRA J,K
            c = 259.183275f - 0.0529539222f * k;
            c = c + (0.002078f + 0.000002f * j) * j * j;
            c = _f.bajo360(c); v = c;
            cb = "Nodo"; c = v; c = _f.bajo360(c); c = _f.enggmmss(c);
            erg[21] = c; erg[20] = _f.endecien(c);
            //'RETURN: REM SALE V

        }
        float lacasa(int casa, float h, float p, out float hato, out string cb)
        {
            //Function lacasa(casa!, h!, p!, hato!) As Single
            float c, b;
            //'SHARED e, Q, PI, RD, cb$, c, lo
            int cont = 0, Home = casa;
            if (casa == 4 || casa > 6)
            {
                cont = 1;
                casa = casa - 6; if (casa < 0) casa = 10;
                if (Home == 10) { casa = Home; cont = 0; }
            } //End If
            float n = (casa - 1) * 30;

            float s = n / q;
            float a = h + n - 270;
            if (s - Math.Truncate(s) == 0)
            {
                //GoSub casangu
                if (Math.Cos(2 * q * s * rd) > 0)
                {
                    //anguno:
                    b = -(float)Math.Sin(e * rd) * (float)Math.Sin(p * rd) + (float)Math.Cos(e * rd) * (float)Math.Cos(p * rd) * (float)Math.Cos(a * rd);
                    a = (float)Math.Sin(a * rd) * (float)Math.Cos(p * rd);
                    c = _f.mdospi(a, b);
                }
                else
                {
                    // casangu:

                    b = (float)Math.Cos(a * rd); a = (float)Math.Sin(a * rd) / (float)Math.Cos(e * rd);
                    c = _f.mdospi(a, b); //: GoTo casangdos
                }
                //casangdos:
                if (Math.Sin((s * q - 9) * rd) > 0) c = c - 2 * q;
                c = _f.bajo360(c);

            }
            else
            {//: GoSub lasmias
                //lasmias:   ' casas succedent  y  cadent
                float NR = n * rd;
                float D = (float)Math.Atan((float)Math.Sin(NR) / (float)Math.Cos(NR));
                D = D / rd;
                s = 1;
                if (D < 0) s = 3;
                float lat = p * (3 - n / 30) / 3;
                b = (float)Math.Cos(e * rd) * (float)Math.Cos(lat * rd) * (float)Math.Cos(a * rd) - (float)Math.Sin(e * rd) * (float)Math.Sin(lat * rd);
                a = (float)Math.Sin(a * rd) * (float)Math.Cos(lat * rd);
                c = _f.mdospi(a, b);

            } //End If
            a = 1 + n / 30;
            c = c + 0.0001f;
            hato = c;
            c = _f.enggmmss(c);
            float Z = a;
            if (Home == 1)
            { // Then
                cb = "Asc.: ";
            }
            else if (Home == 10)
            {// Then: 
                cb = "Mhv.: ";
            }
            else
            {
                cb = _f.decnum(Home);
            }
            if (cont == 1) c = _f.bajo360(c + 180);
            Z = c;
            casa = Home;
            return c;
            //Exit Function 'RETURN: REM term calc casasÓ
            //casangu:
            //If Cos(2 * q * s * rd) > 0 Then GoTo anguno
            //     b = Cos(a * rd): a = Sin(a * rd) / Cos(e * rd):
            //     c = mdospi(a, b): GoTo casangdos
            //anguno:
            //b = -Sin(e * rd) * Sin(p * rd) + Cos(e * rd) * Cos(p * rd) * Cos(a * rd)
            //     a = Sin(a * rd) * Cos(p * rd):
            //     c = mdospi(a, b)
            //casangdos:
            //If Sin((s * q - 9) * rd) > 0 Then c = c - 2 * q
            //     c = bajo360(c)
            //Return
            //     Rem casas propias
            //lasmias:   ' casas succedent  y  cadent
            //NR = n * rd:
            //D = Atn(Sin(NR) / Cos(NR)): D = D / rd
            //s = 1: If D < 0 Then s = 3
            //lat = p * (3 - n / 30) / 3:
            //b = Cos(e * rd) * Cos(lat * rd) * Cos(a * rd) - Sin(e * rd) * Sin(lat * rd)
            //a = Sin(a * rd) * Cos(lat * rd):
            //c = mdospi(a, b)
            //Return        '      fin rut casas

        } //End Function
        int cualcasa(float tes)
        {
            //Private Function cualcasa(testing!)
            float totest = tes;
            if (totest <= arcasas[1]) totest = totest + 360;
            int cat = 0;
            for (cat = 1; cat <= 36; cat++)
            {
                if (totest >= arcasas[cat] - 5 && totest < arcasas[cat + 1] - 5) break;
                //If seem Then Exit For
            } //Next cat
            cat = cat % 12; if (cat == 0) cat = 12;
            return cat;

        }
        void AddHousetoPlanet(int id, int tc)
        {
            //Sub AddHousetoPlanet(id%, tc)
            Planet Plnet = mvarResultSet.Planets[plt[id]];
            //ms$ = roman$(tc + 0)
            Plnet.h0 = tc;
            Plnet.h = _f.roman(tc); //ms$
        }
        public void NoMakeGraph(String WebDir, String pfx, String BackGround = "")
        {
            // Public Function MakeGraph(WebDir, pfx, Optional BackGround) As String
            // Dim OutPic As PictureBox, Fsp As String
            int awX = 15; //Screen.TwipsPerPixelX
            int awY = 15; //Screen.TwipsPerPixelY
            SD.Bitmap bmp = new SD.Bitmap((int)(12240 * 0.85 * awX / 15), (int)(15840 * 0.83 * awY / 15)); //bmp_width, bmp_height))
            var Pintura = SD.Graphics.FromImage(bmp);
            // Set OutPic = PicForm.Pintura
            //OutPic.ScaleMode = vbPixels
            //'OutPic.Parent.ScaleMode = vbPixels '5 'Inches
            // OutPic.Width = 12240 * 0.85 * awX / 15 '11016 '9792 '12240 ' Printer.Width
            // OutPic.Height = 15840 * 0.83 * awY / 15 '5 '14256 '12672 '15840 'Printer.Height
            // 'OutPic.Width = 690 ' 12240 * 0.85 '11016 '9792 '12240 ' Printer.Width
            // 'OutPic.Height = 870 '15840 * 0.83 '5 '14256 '12672 '15840 'Printer.Height
            // OutPic.ScaleMode = vbTwips
            // OutPic.Cls
            Pintura.Clear(SD.Color.FromArgb(255, 0, 0, 0));
            //On Error Resume Next
            //If Not IsMissing(BackGround) Then OutPic.Picture = LoadPicture(BackGround)
            //On Error GoTo 0
            if (BackGround != "")
            {
                var fondo = SD.Image.FromFile(BackGround);
                Pintura.DrawImageUnscaled(fondo, 0, 0);
            }
            GarficaNatal(Pintura, bmp.Width, bmp.Width, -2);
            //Call graficos(OutPic, OutPic.Width, OutPic.Width, -2)
            /*     PrinterFlag = False 'True
                 OutPic.ScaleMode = vbInches
                 PrintStartDoc OutPic, PrinterFlag, 8.5, 11
                 PrtFntName "Arial"
                 PrtFSize 12
                 PrtFntBold -1
                 dy! = 0.18: tr! = 0.19
                 ph! = (8.5 - OutPic.TextWidth(sNombre$)) / 2
                 PrtAt ph!, tr! + dy! * 0, sNombre$ '& awX & ":" & awY
                 dy! = 0.18: tr! = 0.2
                 PrtFSize 10
                 tx$ = sLugar$ & " " & sDianac$ & " " & sHoranac$: ph! = (8.5 - OutPic.TextWidth(tx$)) / 2
                 PrtAt ph!, tr! + dy! * 1, tx$
                 tx$ = "Long:" & ulongit & " Latit:" & ulatit & " HZon:" & uhorazonal: ph! = (8.5 - OutPic.TextWidth(tx$)) / 2
                 PrtAt ph!, tr! + dy! * 2, tx$
                 'PrintCalculos 5.84!, OutPic
                 PrintCalculos 7.3!, OutPic
             'Printer.EndDoc
             Fsp = getFileSpec(WebDir, pfx)
  
           tfname$ = WebDir & "\" & Fsp & ".bmp"
           '  TraceProgress "AstroCalc MakeGraph Prev SavePicture OutPic.Image, tfname$"
               On Error Resume Next
                   Kill tfname$
               On Error GoTo 0
  
             SavePicture OutPic.Image, tfname$

               Unload PicForm

           fname$ = WebDir & "\" & Fsp & ".jpg"
               On Error Resume Next
                   Kill fname$
               On Error GoTo 0
  
           '  TraceProgress "AstroCalc MakeGraph Prev Ok = ConvertBMP2JPG(tfname$, fname$)"
  
             Ok = ConvertBMP2JPG(tfname$, fname$)
  
               On Error Resume Next
                   Kill tfname$
               On Error GoTo 0
           */
            string Fsp = "";
            //return Fsp + ".jpg";
            //End Function
        }

        public SD.Bitmap MakeGraph(String opcion, int bmp_width, int bmp_height, String BackGround = "")
        {
            // Public Function MakeGraph(WebDir, pfx, Optional BackGround) As String
            // Dim OutPic As PictureBox, Fsp As String
            int awX = 15; //Screen.TwipsPerPixelX
            int awY = 15; //Screen.TwipsPerPixelY
            //int bmp_width = (int)(1224.0 * 0.85 * awX / 15);
            //int bmp_height = (int)(1584.0 * 0.83 * awY / 15);
            SD.Bitmap bmp = new SD.Bitmap(bmp_width, bmp_height);
            var Pintura = SD.Graphics.FromImage(bmp);
            // Set OutPic = PicForm.Pintura
            //OutPic.ScaleMode = vbPixels
            //'OutPic.Parent.ScaleMode = vbPixels '5 'Inches
            // OutPic.Width = 12240 * 0.85 * awX / 15 '11016 '9792 '12240 ' Printer.Width
            // OutPic.Height = 15840 * 0.83 * awY / 15 '5 '14256 '12672 '15840 'Printer.Height
            // 'OutPic.Width = 690 ' 12240 * 0.85 '11016 '9792 '12240 ' Printer.Width
            // 'OutPic.Height = 870 '15840 * 0.83 '5 '14256 '12672 '15840 'Printer.Height
            // OutPic.ScaleMode = vbTwips
            // OutPic.Cls
            Pintura.Clear(SD.Color.FromArgb(255, 0, 0, 0));
            Pintura.FillRectangle(SD.Brushes.LightGoldenrodYellow, 0, 0, bmp_width, bmp_height);
            //On Error Resume Next
            //If Not IsMissing(BackGround) Then OutPic.Picture = LoadPicture(BackGround)
            //On Error GoTo 0
            //BackGround =app
            if (BackGround != "")
            {
                var fondo = SD.Image.FromFile(BackGround);
                Pintura.DrawImageUnscaled(fondo, 0, 0);
            }
            GarficaNatal(Pintura, bmp.Width, bmp.Width, -2);
            //Call graficos(OutPic, OutPic.Width, OutPic.Width, -2)
            /*     PrinterFlag = False 'True
                 OutPic.ScaleMode = vbInches
                 PrintStartDoc OutPic, PrinterFlag, 8.5, 11
                 PrtFntName "Arial"
                 PrtFSize 12
                 PrtFntBold -1
                 dy! = 0.18: tr! = 0.19
                 ph! = (8.5 - OutPic.TextWidth(sNombre$)) / 2
                 PrtAt ph!, tr! + dy! * 0, sNombre$ '& awX & ":" & awY
                 dy! = 0.18: tr! = 0.2
                 PrtFSize 10
                 tx$ = sLugar$ & " " & sDianac$ & " " & sHoranac$: ph! = (8.5 - OutPic.TextWidth(tx$)) / 2
                 PrtAt ph!, tr! + dy! * 1, tx$
                 tx$ = "Long:" & ulongit & " Latit:" & ulatit & " HZon:" & uhorazonal: ph! = (8.5 - OutPic.TextWidth(tx$)) / 2
                 PrtAt ph!, tr! + dy! * 2, tx$
                 'PrintCalculos 5.84!, OutPic
                 PrintCalculos 7.3!, OutPic
             'Printer.EndDoc
             Fsp = getFileSpec(WebDir, pfx)
  
           tfname$ = WebDir & "\" & Fsp & ".bmp"
           '  TraceProgress "AstroCalc MakeGraph Prev SavePicture OutPic.Image, tfname$"
               On Error Resume Next
                   Kill tfname$
               On Error GoTo 0
  
             SavePicture OutPic.Image, tfname$

               Unload PicForm

           fname$ = WebDir & "\" & Fsp & ".jpg"
               On Error Resume Next
                   Kill fname$
               On Error GoTo 0
  
           '  TraceProgress "AstroCalc MakeGraph Prev Ok = ConvertBMP2JPG(tfname$, fname$)"
  
             Ok = ConvertBMP2JPG(tfname$, fname$)
  
               On Error Resume Next
                   Kill tfname$
               On Error GoTo 0
           */
            string Fsp = "";
            return bmp; // Fsp + ".jpg";
            //End Function
        }

        void GarficaNatal(SD.Graphics Pic, int Ancho, int Alto, int Heavy)
        {
            float mgs = 0.9F;
            //grafica:
            float rsh, ytx, xtx, rsv, cntx, cnty, r1, r2;
            if (Heavy == -2)
            {
                ef = 1;
                rsh = Ancho * 0.9f; rsv = Alto * 0.9f;
                ytx = rsh; xtx = rsv;
                cntx = Ancho / 2; cnty = rsv / 2;
                r2 = 0.35f * rsh;
                r1 = 0.74f * r2;
            }
            else
            {
                ef = 0.85f;// '1 '6 * (ancho / Alto) / 12
                rsh = Ancho; rsv = Alto; // ' rsh = 640: rsv = 350
                ytx = rsh; xtx = rsv; //': ytx = 80: xtx = 25
                cntx = rsh / 2; cnty = rsv / 2;
                r2 = 0.35f * Ancho; // '2700 ' r1 = 115: r2 = 170
                r1 = 0.76f * r2;
            }
            SD.Pen myPen = null;
            int pw = 1;
            if (Heavy == -1)
            {
                myPen = new SD.Pen(System.Drawing.Color.Blue, pw);
            }
            else if (Heavy >= 0)
            {
                myPen = new SD.Pen(System.Drawing.Color.Gray, pw);
            }
            else if (Heavy == -2)
            {
                myPen = new SD.Pen(System.Drawing.Color.Blue, pw);
            }
            if (Heavy == -2)
            {
                Pic.DrawEllipse(myPen, cntx - r1, cnty - r1, r1 * 2, r1 * 2 * ef); //  pic.Circle (cntx, cnty), r1, QBColor(clr_circ), , , ef
                Pic.DrawEllipse(myPen, cntx - r2, cnty - r2, r2 * 2, r2 * 2 * ef);
            }
            else
            {
                Pic.DrawEllipse(myPen, cntx - r1, cnty - r1, r1 * 2, r1 * 2 * ef); //  pic.Circle (cntx, cnty), r1, QBColor(clr_circ), , , ef
                Pic.DrawEllipse(myPen, cntx - (r1 + 15), cnty - (r1 + 15), (r1 + 15) * 2, (r1 + 15) * 2 * ef); //  pic.Circle (cntx, cnty), r1 + 15, QBColor(clr_circ), , , ef
                Pic.DrawEllipse(myPen, cntx - r2, cnty - r2, r2 * 2, r2 * 2 * ef);  //pic.Circle (cntx, cnty), r2, QBColor(clr_circ), , , ef
                Pic.DrawEllipse(myPen, cntx - (r2 + 15), cnty - (r2 + 15), (r2 + 15) * 2, (r2 + 15) * 2 * ef); // pic.Circle (cntx, cnty), r2 + 15, QBColor(clr_circ), , , ef
            }
            //' calcula circulo planetas
            //CalCircPlnt:
            //yagraph = 1
            int clr_punt = 15; if (Heavy > 0) clr_punt = 1;
            SD.Pen pPen = new SD.Pen(SD.Color.BlueViolet, 2F);
            pw = 1;
            System.Drawing.Color clr1 = System.Drawing.Color.Gray;
            SD.Font font = new SD.Font("Arial", 9f);
            SD.RectangleF rectf = new SD.RectangleF(70, 90, 90, 50);
            Pic.SmoothingMode = SD.Drawing2D.SmoothingMode.AntiAlias;
            Pic.InterpolationMode = SD.Drawing2D.InterpolationMode.HighQualityBicubic;
            Pic.PixelOffsetMode = SD.Drawing2D.PixelOffsetMode.HighQuality;
            Pic.DrawString("yourText", new SD.Font("Arial", 9f), SD.Brushes.Black, rectf);
            //Pic.DrawBezier(new SD.Pen(SD.Color.Blue, 2F), 100, 500, 240, 550, 100, 200, 150, 30);

            //SD.Point[] p = new SD.Point[6];
            //p[0].X = 0;
            //p[0].Y = 0;
            //p[1].X = 53;
            //p[1].Y = 111;
            //p[2].X = 114;
            //p[2].Y = 86;
            //p[3].X = 34;
            //p[3].Y = 34;
            //p[4].X = 165;
            //p[4].Y = 7;
            //Pic.DrawPolygon(new SD.Pen(SD.Color.BlueViolet, 2F), p);
            ////            pic.Font.Name = "Arial": pic.Font.Size = ancho& / 8200 * 9

            //   SD.Pen pen1 = new SD.Pen(SD.Color.BlueViolet, 2F);
            //For i = 0 To 10            'captura posic planets
            /* Calcula Circuloas de Planetas */
            for (int i = 0; i <= 10; i++)
            {
                // lp = erg(i * 2): rt$ = LCase$(plt$(i + 1))
                float lp = erg[i * 2]; String rt = (plt[i + 1]).ToLower();
                //  ui(i + 1).who = i
                ui[i + 1].who = i;
                //  cs2 = (cas(1) + 360 * 2 - lp) * rd
                float cs2 = (cas[1] + 360 * 2 - lp) * rd;
                //  a0 = Sin(cs2) * ef * r1: b0 = Cos(cs2) * r1
                float a0 = (float)Math.Sin(cs2) * ef * r1;
                float b0 = (float)Math.Cos(cs2) * r1;
                //  ui(i + 1).x0 = cntx - b0: ui(i + 1).y0 = cnty - a0    'pos x e y en el circulo
                ui[i + 1].x0 = (cntx - b0); ui[i + 1].y0 = cnty - a0;    //pos x e y en el circulo
                //  pic.FillStyle = 0:  pic.FillColor = QBColor(clr_punt)
                //  pic.Circle (ui(i + 1).x0, ui(i + 1).y0), 30, QBColor(clr_punt)
                SD.Pen pen = new SD.Pen(SD.Color.Red);
                Pic.DrawEllipse(pen, ui[i + 1].x0 - 2, ui[i + 1].y0 - 2, 3, 3);
                //  pic.FillStyle = 1
                //    'b = COS(cs2) * r3:           'ytx / rsh
                //    za = acote(erg(i * 2 + 1), c2): 'rt$?
                int c2; int za = _f.acote(erg[i * 2 + 1], out c2); //: 'rt$?
                //    ui(i + 1).see = plt$(i + 1) + ":" + decnum$(za) + "º" + decnum$(c2)
                ui[i + 1].see = plt[i + 1] + ":" + _f.decnum(za) + "º" + _f.decnum(c2);
                //     If ui(i + 1).x0 < cntx Then
                if (ui[i + 1].x0 < cntx)
                {
                    //        ui(i + 1).px = cntx - r2 - 200 - pic.TextWidth("Luna:30º30")
                    ui[i + 1].px = cntx - r2 - 25 - (int)Pic.MeasureString("Luna:30º30", font).Width;
                    //        ui(i + 1).x = ui(i + 1).px + pic.TextWidth(Trim(ui(i + 1).see))
                    ui[i + 1].x = ui[i + 1].px + (int)Pic.MeasureString(ui[i + 1].see.Trim(), font).Width;
                    //     Else                                       'xrc= pos x de i en la recta
                }
                else
                {
                    //        ui(i + 1).px = cntx + r2 + 100 'alto& - 100 - pic.TextWidth(ui(i + 1).see) '67
                    ui[i + 1].px = cntx + r2 + 10; // 'alto& - 100 - pic.TextWidth(ui(i + 1).see) '67
                    //        ui(i + 1).x = ui(i + 1).px '(ytx - Len(ui(i + 1).see) - 1) * (rsh / ytx)
                    ui[i + 1].x = ui[i + 1].px; // '(ytx - Len(ui(i + 1).see) - 1) * (rsh / ytx)
                    //     End If
                }
                //    a = Sin(cs2) * ef * r2 '* 1.1
                float a = (float)Math.Sin(cs2) * ef * r2;// '* 1.1
                //    ui(i + 1).y = cnty - a                  'yrc=pos y de i en la recta
                ui[i + 1].y = cnty - a;                  //'yrc=pos y de i en la recta
                //    ui(i + 1).py = Int(ui(i + 1).y * xtx / rsv)
                ui[i + 1].py = (int)(ui[i + 1].y * xtx / rsv);
                //    If ui(i + 1).py <> xtx Then ui(i + 1).py = ui(i + 1).py Mod xtx + 1:
                if (ui[i + 1].py != xtx) { ui[i + 1].py = ui[i + 1].py % xtx + 1; }
                //      a0 = Sin(cs2) * ef * r2 * 1.2: b0 = Cos(cs2) * r2 * 1.2
                a0 = (float)Math.Sin(cs2) * ef * r2 * 1.2F;
                b0 = (float)Math.Cos(cs2) * r2 * 1.2F;
                //  '    ui(i + 1).x = cntx - b0: ui(i + 1).y = cnty - a0    'pos x e y en el circulo
                //Next i
            }
            //////////'rayitas y simbolos
            // For i = 0 To 11           'Lineas separacion de signos
            for (int i = 0; i <= 11; i++)
            { //           'Lineas separacion de signos
                //  cs2 = (cas(1) + 360 * 2 - (i * 30)) * rd
                float cs2 = (cas[1] + 360 * 2 - (i * 30)) * rd;
                //  a0 = Sin(cs2) * ef * r1: b0 = Cos(cs2) * r1
                float a0 = (float)Math.Sin(cs2) * ef * r1;
                float b0 = (float)Math.Cos(cs2) * r1;
                //  a = Sin(cs2) * ef * r2: b = Cos(cs2) * r2
                float a = (float)Math.Sin(cs2) * ef * r2;
                float b = (float)Math.Cos(cs2) * r2;
                //  pic.Line (cntx + b0, cnty + a0)-(cntx + b, cnty + a), QBColor(clr_circ)
                Pic.DrawLine(pPen, new SD.Point((int)(cntx + b0), (int)(cnty + a0)), new SD.Point((int)(cntx + b), (int)(cnty + a)));
            }// Next i
            // For i = 0 To 5 '11    'Rayitas y simbolos
            for (int i = 0; i <= 5; i++)
            { // '11    'Rayitas y simbolos
                //  For h = 5 To 25 Step 5
                for (int h = 5; h <= 25; h = h + 5)
                {
                    //   cs2 = (cas(1) + 360 * 2 - (i * 30 + h)) * rd
                    float cs2 = (cas[1] + 360 * 2 - (i * 30 + h)) * rd;
                    //   a0 = Sin(cs2) * ef * r1: b0 = Cos(cs2) * r1
                    float a0 = (float)Math.Sin(cs2) * ef * r1;
                    float b0 = (float)Math.Cos(cs2) * r1;
                    //   If h Mod 10 = 0 Then   'si es diez
                    float a, b;
                    if (h % 10 == 0)
                    {// Then   'si es diez
                        //     pr! = 0.9
                        //     a = Sin(cs2) * ef * (r2 * pr! + r1) / 2: b = Cos(cs2) * (r2 * pr! + r1) / 2
                        float pr = 0.9F;
                        a = (float)Math.Sin(cs2) * ef * (r2 * pr + r1) / 2;
                        b = (float)Math.Cos(cs2) * (r2 * pr + r1) / 2;
                    }
                    else
                    {//   Else                   'si es quino
                        //     a = Sin(cs2) * ef * (r1 + (r2 - r1) / 6): b = Cos(cs2) * (r1 + (r2 - r1) / 6)
                        a = (float)Math.Sin(cs2) * ef * (r1 + (r2 - r1) / 6);
                        b = (float)Math.Cos(cs2) * (r1 + (r2 - r1) / 6);
                    }//   End If
                    //   pic.Line (cntx + b0, cnty + a0)-(cntx + b, cnty + a), QBColor(clr_circ)
                    Pic.DrawLine(pPen, new SD.Point((int)(cntx + b0), (int)(cnty + a0)), new SD.Point((int)(cntx + b), (int)(cnty + a)));
                    //   pic.Line (cntx - b0, cnty - a0)-(cntx - b, cnty - a), QBColor(clr_circ)
                    Pic.DrawLine(pPen, new SD.Point((int)(cntx - b0), (int)(cnty - a0)), new SD.Point((int)(cntx - b), (int)(cnty - a)));
                    //   If h = 15 Then   'se pone mono
                    if (h == 15)
                    {// Then   'se pone mono
                        //     clr_sign = 11:
                        //     pic.Font.Name = "Wingdings":
                        //'     pic.Font.Size = 12
                        //     pic.Font.Size = ancho& / 3800 * 9
                        SD.Font font1 = new SD.Font("Wingdings", 12f);
                        //     a = Sin(cs2) * ef * (r1 + r2) / 2: b = Cos(cs2) * (r2 + r1) / 2
                        a = (float)Math.Sin(cs2) * ef * (r1 + r2) / 2;
                        b = (float)Math.Cos(cs2) * (r2 + r1) / 2;
                        //     px = (cntx - b) - pic.TextWidth("n") / 2
                        //     py = (cnty - a) - pic.TextHeight("n") / 2
                        float px = (cntx - b) - (int)Pic.MeasureString("n", font1).Width / 2;
                        float py = (cnty - a) - (int)Pic.MeasureString("n", font1).Height / 2;
                        //     pic.CurrentX = px: pic.CurrentY = py
                        //     If heavy& <> 0 Then clr_sign = ((i Mod 4) = 0) * -4 + ((i Mod 4) = 1) * -2 + ((i Mod 4) = 2) * -14 + ((i Mod 4) = 3) * -1
                        SD.Brush brsh;
                        switch (i % 4)
                        {
                            case 1: brsh = new SD.SolidBrush(SD.Color.Green); break;
                            case 2: brsh = new SD.SolidBrush(SD.Color.Gold); break;
                            case 0: brsh = new SD.SolidBrush(SD.Color.Firebrick); break;
                            case 3: brsh = new SD.SolidBrush(SD.Color.Navy); break;
                            default: brsh = new SD.SolidBrush(SD.Color.CadetBlue); break;
                        }
                        //     pic.ForeColor = QBColor(clr_sign)
                        //     pic.Print Chr(94 + i)
                        String s = Convert.ToChar(94 + i).ToString();
                        Pic.DrawString(s, font1, brsh, new SD.PointF(px, py));
                        //     px = (cntx + b) - pic.TextWidth("n") / 2
                        //     py = (cnty + a) - pic.TextHeight("n") / 2
                        px = (cntx + b) - (int)Pic.MeasureString("n", font1).Width / 2;
                        py = (cnty + a) - (int)Pic.MeasureString("n", font1).Height / 2;
                        //     pic.CurrentX = px: pic.CurrentY = py
                        //     If heavy& <> 0 Then clr_sign = ((i Mod 4) = 0) * -14 + ((i Mod 4) = 1) * -1 + ((i Mod 4) = 2) * -4 + ((i Mod 4) = 3) * -2
                        //     pic.ForeColor = QBColor(clr_sign)
                        //     pic.Print Chr(94 + i + 6)
                        switch (i % 4)
                        {
                            case 2: brsh = new SD.SolidBrush(SD.Color.Firebrick); break;
                            case 1: brsh = new SD.SolidBrush(SD.Color.Navy); break;
                            case 3: brsh = new SD.SolidBrush(SD.Color.Green); break;
                            case 0: brsh = new SD.SolidBrush(SD.Color.Gold); break;
                            default: brsh = new SD.SolidBrush(SD.Color.CadetBlue); break;
                        }
                        String s1 = Convert.ToChar(94 + i + 6).ToString();
                        Pic.DrawString(s1, font1, brsh, new SD.PointF(px, py));
                    }//   End If
                }//  Next h
            }// Next i
            //////////////' si papel graditos
            if (Heavy == -2)
            {// Then
                for (int i = 0; i <= 5; i++)
                {// '11    'Rayitas y simbolos
                    for (int h = 1; h <= 29; h++)
                    {// Step 1
                        float cs2 = (cas[1] + 360 * 2 - (i * 30 + h)) * rd;
                        float a0 = (float)Math.Sin(cs2) * ef * r1;
                        float b0 = (float)Math.Cos(cs2) * r1;
                        float a = (float)Math.Sin(cs2) * ef * (r1 + (r2 - r1) / 12);
                        float b = (float)Math.Cos(cs2) * (r1 + (r2 - r1) / 12);
                        // pic.Line (cntx + b0, cnty + a0)-(cntx + b, cnty + a), QBColor(clr_circ)
                        Pic.DrawLine(pPen, new SD.Point((int)(cntx + b0), (int)(cnty + a0)), new SD.Point((int)(cntx + b), (int)(cnty + a)));
                        // pic.Line (cntx - b0, cnty - a0)-(cntx - b, cnty - a), QBColor(clr_circ)
                        Pic.DrawLine(pPen, new SD.Point((int)(cntx - b0), (int)(cnty - a0)), new SD.Point((int)(cntx - b), (int)(cnty - a)));
                    }//Next h
                }//Next i


            } //End If

            // /////           ' Lineas de casas
            SD.Color clr_angu = SD.Color.DarkGray;// 8 '9
            SD.Color clr_cusp = SD.Color.LightGray;// 11
            Pic.DrawLine(new SD.Pen(clr_angu, 2), new SD.Point((int)(cntx - r2 - 20), (int)cnty), new SD.Point((int)(cntx + r2), (int)cnty)); //, QBColor(clr_angu) '  ascendente
            font = new SD.Font("Arial", 9, SD.FontStyle.Bold);
            //font.Size = 9F; // ancho& / 8200 * 9;
            int c2a;
            String leftrotul = "Asc " + _f.decnum(_f.acote(cas[1], out c2a)) + "º" + _f.decnum(c2a) + "<";
            SD.Point asc = new SD.Point((int)(cntx - r2 - Pic.MeasureString(leftrotul, font).Width), (int)(cnty - Pic.MeasureString(leftrotul, font).Height / 2)); // pic.TextWidth(leftrotul$)
            // pic.CurrentX = cntx - r2 - 200 - pic.TextWidth(leftrotul$): pic.CurrentY = cnty - pic.TextHeight(leftrotul$) / 2
            // pic.ForeColor = QBColor(clr_cusp)
            // pic.Print leftrotul$
            Pic.DrawString(leftrotul, font, new SD.SolidBrush(clr_cusp), asc);
            for (int i = 2; i <= 6; i++)
            { //            'me.circleas de casas
                float cs2 = (cas[1] + 360 * 2 - cas[i]) * rd;
                if (i != 4)
                { // Then
                    float a = (float)Math.Sin(cs2) * ef * r1;
                    float b = (float)Math.Cos(cs2) * r1;
                    //  pic.Line (cntx, cnty)-(cntx + b, cnty + a), QBColor(clr_cusp)
                    //  pic.Line (cntx, cnty)-(cntx - b, cnty - a), QBColor(clr_cusp)
                    Pic.DrawLine(new SD.Pen(clr_cusp), new SD.Point((int)cntx, (int)cnty), new SD.Point((int)(cntx + b), (int)(cnty + a)));
                    Pic.DrawLine(new SD.Pen(clr_cusp), new SD.Point((int)cntx, (int)cnty), new SD.Point((int)(cntx - b), (int)(cnty - a)));
                    // Else
                }
                else
                {
                    float a = (float)Math.Sin(cs2) * ef * r2 * 1.04F;
                    float b = (float)Math.Cos(cs2) * r2 * 1.04F;
                    //  pic.Line (cntx, cnty)-(cntx + b, cnty + a), QBColor(clr_angu)
                    //  pic.Line (cntx, cnty)-(cntx - b, cnty - a), QBColor(clr_angu)
                    Pic.DrawLine(new SD.Pen(clr_cusp), new SD.Point((int)cntx, (int)cnty), new SD.Point((int)(cntx + b), (int)(cnty + a)));
                    Pic.DrawLine(new SD.Pen(clr_cusp), new SD.Point((int)cntx, (int)cnty), new SD.Point((int)(cntx - b), (int)(cnty - a)));
                    a = (float)Math.Sin(cs2) * ef * r2;
                    b = (float)Math.Cos(cs2) * r2;
                    //if (a > 0)
                    //{// THEN
                    float py = (cntx + b) * ytx / Ancho;
                    float px = (cnty + a) * xtx / rsv;
                    if (px < 1) px = 1;
                    font = new SD.Font("Arial", 9, SD.FontStyle.Regular); int c2; //Ancho / 8200 *
                    String toprotul = "Mc " + _f.decnum(_f.acote(cas[4], out c2)) + "º" + _f.decnum(c2);
                    //    pic.CurrentX = cntx + b - pic.TextWidth(toprotul$) / 2:
                    //    pic.CurrentY = cnty + a - 3 * pic.TextHeight(toprotul$) / 2
                    //    pic.ForeColor = QBColor(clr_cusp): pic.Print toprotul$
                    SD.Point sac = new SD.Point((int)(cntx + b - Pic.MeasureString(toprotul, font).Width / 2), (int)(cnty + a - 3 * Pic.MeasureString(toprotul, font).Height / 2)); // pic.TextWidth(leftrotul$)
                    Pic.DrawString(toprotul, font, new SD.SolidBrush(clr_cusp), sac);

                    //    toprotul$ = "Mc" + decnum$(acote(cas(4), c2)) + " " + decnum$(c2)
                    //'    PatMe Me, px + 0, py - 4, toprotul$
                    //}//  'END IF
                }// End If
            }// Next i
            //''''''''''''''''''
            //' descripciones de posiciones
            //'''''''''''''''''''''''
            SD.Font dfnt;// pic.Font.Name = "Arial":
            if (Heavy == -2)
            {// Then
                dfnt = new SD.Font("Arial", 12f, SD.FontStyle.Regular);//  pic.Font.Bold = False
                //  pic.Font.Size = 12
            }
            else
            {// Else: pic.Font.Size = ancho& / 8200 * 9
                dfnt = new SD.Font("Arial", 9f, SD.FontStyle.Regular);
            }// End If

            for (int jumpy = 1; jumpy <= 2; jumpy++)
            {
                for (int i = -15; i <= (23 + 15); i++)
                {
                    validpos[jumpy, i + 15] = 0;
                }// Next
            }//Next
            //'ReDim validpos(2, 25)
            float LiTx = Alto * mgs;
            if (Heavy == -2) LiTx = (2 * r2 * 1.2F) * mgs;
            int jump = (int)(LiTx / 23F);
            for (int i = 1; i <= 11; i++)
            {
                CalceDesc((int)(ui[i].py / (LiTx) * 23), i * 1, (ui[i].px < cntx) ? 1 : (ui[i].px > cntx) ? 2 : 1);
            }//Next i
            //Refix(cnty);
            //'refix en cuadro
            SD.Color clr_dpln = SD.Color.OrangeRed;// 10: 
                if (Heavy != 0) clr_dpln = SD.Color.Salmon;
            SD.Color clr_lpln = SD.Color.RoyalBlue;// 3
            for (jump = 1; jump <= 2; jump++)
            {
                for (int i = 0; i <= 28; i++)
                {
                    if (validpos[jump, i + 15] > 0)
                    {// Then
                        int hs = validpos[jump, i + 15];
                        String leftrot = ui[hs].see;
                        SD.Point tac = new SD.Point((int)(ui[hs].px), (int)(i * (LiTx) / 23)); // pic.TextWidth(leftrotul$)
                        Pic.DrawString(leftrot, font, new SD.SolidBrush(clr_dpln), tac);
                        //     pic.CurrentY = i * (LiTx!) / 23
                        //     pic.CurrentX = ui(hs%).px
                        //     pic.ForeColor = QBColor(clr_dpln)
                        //     pic.Print leftrotul$

                        ui[hs].y = ui[hs].py * 8 - 5;
                        //     pic.Line (ui(hs%).x0, ui(hs%).y0) _
                        //              -(ui(hs%).x, (i * (LiTx!) / 23) + pic.TextHeight("A") / 2), _
                        //                QBColor(clr_lpln)
                        Pic.DrawLine(new SD.Pen(clr_lpln), 
                            new SD.Point((int)(ui[hs].x0), (int)(ui[hs].y0)), 
                            new SD.Point((int)(ui[hs].x), (int)(i * (LiTx) / 23 + Pic.MeasureString("A", font).Height/2)));

                    }//  End If
                }// Next
            }//Next

            ///////////////////////////' muestra los aspectos
            //aspecshow:
            //' ''''''''''''''''''''
            for (int df = 0; df <= 10; df++)
            {
                for (int fd = 0; fd <= 10; fd++)
                {
                    int pf1 = ui[df + 1].who;
                    int pf2 = ui[fd + 1].who;
                    if (aspc[pf1, pf2].see != null)
                    {
                        String asp = aspc[pf1, pf2].see;
                        if ((int)asp.ToCharArray()[0] > 32)
                        {// Then
                            SD.Color clr_asp;
                            switch (aspc[pf1, pf2].kind)
                            {
                                case 1: clr_asp = SD.Color.Fuchsia; break;
                                case 2: clr_asp = SD.Color.Gold; break;
                                case 3: clr_asp = SD.Color.Maroon; break;
                                case 4: clr_asp = SD.Color.LightBlue; break;
                                case 5: clr_asp = SD.Color.Black; break;
                                default: clr_asp = SD.Color.Navy; break;
                            }
                            //            Select Case aspc(pf1, pf2).kind
                            //             Case 1: clr_asp = 13  'asp$ = "cnj": knd = 1 '"¢"
                            //             Case 2: clr_asp = 6  'asp$ = "sxt": knd = 2 '"*"
                            //             Case 3: clr_asp = 12  'asp$ = "cdr": knd = 3 '"þ"
                            //             Case 4: clr_asp = 9 'asp$ = "trn": knd = 4 '""
                            //             Case 5: clr_asp = 0  'asp$ = "ops": knd = 5 '"ô"
                            //            End Select
                            Pic.DrawLine(new SD.Pen(clr_asp, 3), new SD.Point((int)ui[df + 1].x0, (int)ui[df + 1].y0),
                                new SD.Point((int)(ui[fd + 1].x0), (int)(ui[fd + 1].y0)));

                            //            pic.Line (ui(df + 1).x0, ui(df + 1).y0) _
                            //                    -(ui(fd + 1).x0, ui(fd + 1).y0), _
                            //                     QBColor(clr_asp)
                        }//           End If
                    }
                }//         Next fd
            }//       Next df


            /* Dibuja Circulos de Planetas */
            for (int i = 0; i <= 10; i++)
            {
                SD.Pen pen = new SD.Pen(SD.Color.Black);
                Pic.DrawEllipse(pen, ui[i + 1].x0 - 2, ui[i + 1].y0 - 2, 3, 3);
            }
            Pic.Flush();







        }

        void CalceDesc(int Rowd, int pl, int sd)
        {
            //        Sub CalceDesc(Rowd%, pl%, sd%)
            int flot;
            int jo = validpos[sd, Rowd + 15];
            if (jo == 0)
            {// Then
                validpos[sd, Rowd + 15] = pl;
            }
            else
            {//Else
                // ' si la pos del que estaba es mayor que la mia
                if (ui[pl].py <= ui[jo].py)
                {// Then
                    if (movealdown(Rowd, sd))
                    {// Then
                        validpos[sd, Rowd + 15] = pl;
                    }
                    else
                    {    //   Else
                        //    MsgBox "fatal"
                    }//   End If
                }
                else
                {    // Else
                    if (moveallup(Rowd, sd))
                    { // Then
                        validpos[sd, Rowd + 15] = pl;
                        //   Else
                    }//   End If
                }// End If
            }//End If
        }//End Sub

        bool movealdown(int Rowd, int sd)
        {
            int i, k;
            bool qmovealdown = false;
            for (i = Rowd + 1; i <= (23 + 14); i++)
            {
                k = validpos[sd, i + 15];
                if (k == 0) break; // Then Exit For
            }// Next
            k = i;
            for (i = k; i >= (Rowd + 1); i--)
            {// Step -1
                validpos[sd, i + 15] = validpos[sd, (i - 1) + 15];
                validpos[sd, (i - 1) + 15] = 0;
            }// Next
            qmovealdown = true;
            return qmovealdown;
        } //End Function
        bool moveallup(int Rowd, int sd)
        {// As Integer
            int i, k;
            bool qmoveallup = false;
            for (i = Rowd - 1; i >= -14; i--)
            {// Step -1
                k = validpos[sd, i + 15];
                if (k == 0) break; // Then Exit For
            }// Next
            k = i;
            for (i = k; i <= (Rowd - 1); i++)
            {
                validpos[sd, i + 15] = validpos[sd, (i + 1) + 15];
                validpos[sd, (i + 1) + 15] = 0;
            }// Next
            qmoveallup = true;
            return qmoveallup;
        }//End Function

        void Refix(float cnty)
        {
           int bol = 0, i;
           for (int sd = 1; sd<= 2; sd++) {
               int Rowd = validpos[sd, 11 + 15];
               if (Rowd != 0)
               {// Then
                   if (ui[Rowd].py > cnty) {// Then
                        movealdown(11, sd);
                   } else {//    Else
                       moveallup(11, sd);
                    }//    End If
               }//  End If
            //arriba:
               bool flag = false;
               while (!flag) {
                   for (i = validpos.GetLowerBound(1); i <= 15; i++)
                   {// To 0
                       if (validpos[sd, i] != 0)
                       {// Then 
                           bol = -1; break;
                       }
                       else bol = 0;
                   }//  Next
                   if (bol != 0)
                   { // Then
                       movealdown(i, sd);
                       //   GoTo arriba
                   }
                   else
                   {
                       flag = true;
                   }//  End If
               }
            //abbajo:
               bool flago = false;
               while (!flago)
               {
                   for (i = validpos.GetUpperBound(1) -15; i >= (24-15); i--)
                   {// Step -1
                       if (validpos[sd, i] != 0) {// Then 
                           bol = -1; break;
                       } else bol = 0;
                   }//  Next
                   if (bol == -1)
                   {//% Then
                       moveallup(i, sd);
                       //   GoTo abbajo
                   } else {
                       flago = true;
                   }//  End If
               }
           }// Next
        } //End Sub


    } //end class


    public struct IdPlanets
    {
        public float p;// As Single
        public string sh;// As String * 6
        public string r;// As String * 1
        public int sg0;// As Integer
        public string sg;// As String * 3
        public int h0; // As Integer
        public string h;// As String * 4

    }
    public struct startipo
    {
        public string nombre;// As String * 30
        public string colores;// As String * 14
        public string estrella;// As String * 15
        public string signo; // As String * 15
        public string grados; // As String * 15
        public float eclipgrados; // As Single
        public string latitud; // As String * 15
        public string constelacion; // As String * 30
        public string caracter; // As String * 15
    }
    public struct IdCasa
    {
        public string sg;// As String * 3
        public int sg0;// As Integer
        public string sh;// As String * 6
        public string so;// As String * 3
    }
    public struct grupotipo
    {
        public string desc;// As String * 60
        public string arch;// As String * 8
    }
    public struct guytipo
    {
        public string nom; // As String * 30
        public string fecnac;// As String * 4
        public float hora;// As Single
        public string lugar;// As String * 30
        public int tzone;// As Integer
        public float lng;// As Single
        public float lat;// As Single
    }
    public struct posplatipo
    {
        public int who;// As Integer
        public string see;// As String * 10
        public float x0;// As Single
        public float y0;// As Single
        public float x;// As Single
        public float y; // As Single
        public float px;// As Single
        public float py;// As Single
    }
    public struct asptipo
    {
        public string see;// As String * 3
        public int kind;// As Integer
        public float dev;// As Integer
    }
    public struct aspinfotipo
    {
        public string nombre;// As String * 25
        public string valor;// As String * 12
        public string imagen;// As String * 300
        public string Descrip;// As String * 1600
    }
    public struct posinfotipo
    {
        public string nombre;// As String * 25
        public string imagen;// As String * 300
        public string Descrip;// As String * 1600
    }

    public struct despart
    {
        public int n;// As Integer
        public string nom;// As String * 80
    }
    /* 
     0 	Negro 	8 	Gris
1 	Azul 	9 	Azul claro
2 	Verde 	10 	Verde claro
3 	Aguamarina 	11 	Aguamarina claro
4 	Rojo 	12 	Rojo claro
5 	Fucsia 	13 	Fucsia claro
6 	Amarillo 	14 	Amarillo claro
7 	Blanco 	15 	Blanco brillante
     */
}
