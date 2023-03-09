using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Фильтр
{
    public partial class fGraph : Form
    {
        Frm f;
        float a1, a2, a4, a3, a5, a6, a14, t, t1, t2, Tmax, dt, Mt, tc, d0, d2, d10, D11, d12, b, b1;

        private void PB_Click(object sender, EventArgs e)
        {

        }

        float c1, c2, s, s1, s2, s5, s6, z, dU, Ufs, Uist, Upr, Uf, Uppr, K2, v;
        float[] r=new float[10000],A=new float[100];
        int m, nn, k, dd;

        Random rnd = new Random();
        float[] random = new float[100000];
        float[] random10 = new float[10];

        public fGraph(Frm f)
        {
            for (int i = 0; i < random10.Length; i++)
            {
                random10[i] = (float)rnd.Next(500, 1000) / 1000;
            }
            for (int i = 0; i < random.Length; i++)
            {
                random[i] = (float)(rnd.NextDouble() - .5);
            }

            InitializeComponent();
            this.f = f;
            PB.Image = new Bitmap(PB.Width, PB.Height);

            f.TB5.Value = f.TB5.Maximum;
            f.TB2.Value = 1;
            f.TB3.Value = 30;
            f.TB4.Value = 1;

        }

        private void Picture(bool Slow)
        {

            dd = 25;
            int n = PB.Width - 2 * dd;
            float yT = 5;
            using (Graphics g = Graphics.FromImage(PB.Image))
            {
                g.Clear(Color.SkyBlue);
                Tmax = f.TB5.Value;
                float dTmax = Tmax / 5f;
                float dX = n / 5f;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                for (int i = 1; i <= 5; i++)
                {
                    float x = dd + i * dX;
                    g.DrawLine(Pens.Gray, x, dd, x, PB.Height - dd);
                    g.DrawLine(Pens.Black, x, PB.Height - dd - 2, x, PB.Height - dd + 2);
                    g.DrawString(string.Format("{0:F0}", i * dTmax), Font, Brushes.Black, x - 10, PB.Height - dd + 2);
                }
                g.DrawString("Tm", Font, Brushes.Black, PB.Width - 22, PB.Height - dd - 20);
                float dY = (PB.Height - 2 * dd) / 5f;
                for (int i = 0; i <= 5; i++)
                {
                    float y = PB.Height - dd - i * dY;
                    g.DrawLine(Pens.Gray, dd, y, dd + dX * 5, y);
                }
                g.DrawLine(Pens.Black, dd, 0, dd, PB.Height);
                g.DrawLine(Pens.Black, 0, PB.Height - dd, PB.Width, PB.Height - dd);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //
                Random rnd = new Random();
                a2 = a4 = a6 = t = t2 = t1 = 0;
                dt = Tmax / n;
                Mt = n / Tmax;
                if (f.RB1.Checked)//сглаживание
                {
                    tc = t;
                    d0 = d2 = a6 = a2 = a4 = 0;
                    float k1 = f.TB2.Value;
                    float y1 = (PB.Height - 2 * dd) * 0.46f;
                    float y2 = (PB.Height - 2 * dd) * 0.27f;
                    for (int i = 0; i < n; i++)
                    {
                        t += dt;
                        A[0] = dd + tc * Mt;
                        b = dd + t * Mt;
                        a1 = (float)(30 * Math.Sin(t / 10)); // дельта X
                        a5 = 10 * random[i];
                        a2 = a1 + a5;// U =  U1
                        if (k1 <= 12) a4 = a2 - k1 / 12 * a5;
                        else
                            if (k1 <= 24) a4 = a1 - a1 * (k1 - 13) / 11;
                            else a4 = 0;
                        a3 = a4 - a1;
                        if (a6 < a3) a6 = a3;
                        g.DrawLine(Pens.Blue, A[0], y1 - d2, b, y1 - a4);//возмущение
                        g.DrawLine(Pens.Red, A[0], y2 - d0, b, y2 - a2);//дельта X
                        tc = t;
                        d0 = a2;
                        d2 = a4;
                        if (f.CB.Checked && Slow && i % 1 == 0) PB.Refresh();

                    }
                    g.DrawString(string.Format("Uizm = {0:F3}", a2), Font, Brushes.Black, 150, yT);
                    g.DrawString(string.Format("T = {0:F3}", t), Font, Brushes.Black, 250, yT);
                    g.DrawString(string.Format("Uf = {0:F3}", a4), Font, Brushes.Black, 350, yT);
                    g.DrawString(string.Format("dUf = {0:F3}", a6), Font, Brushes.Black, 450, yT);
                }
                if (f.RB2.Checked)//интерполяция
                {
                    K2 = 35 - f.TB3.Value;
                    m = 2 * (36 - (int)K2);
                    tc = t;
                    nn = 0;
                    c1 = s5 = s6 = d0 = d2 = a6 = a2 = a4 = k = 0;
                    for (int i = 0; i < 100; i++)
                        A[i] = 10 * random[i];
                    float y1 = (PB.Height - 2 * dd) * 0.27f;
                    for (int i = 0; i < n; i++)
                    {
                        t += dt;
                        float x = 20 + tc * Mt;
                        b = 20 + t * Mt;
                        a1 = 30 * (float)Math.Sin(t / 10);// дельта X
                        a5 = A[k];
                        a2 = a1 + a5;//U =  U1
                        s5 += Math.Abs(a1);
                        s6 += a2;
                        g.DrawLine(Pens.Red, x, y1 - d0, b, y1 - a2);//дельта X
                        if (++k > 99) k = 0;
                        if (++nn == 1) t1 = t;
                        if (nn == m)
                        {
                            t2 = t;
                            c2 = s6 / m;
                            if (inter(g)) break;
                        }
                        tc = t;
                        d0 = a2;
                        d2 = a1;
                        c2 = s6 / (i + 1);
                        if (f.CB.Checked && Slow && i % 1 == 0) PB.Refresh();
                    }
                    g.DrawString(string.Format("Uizm = {0:F3}", a2), Font, Brushes.Black, 150, yT);
                    g.DrawString(string.Format("T = {0:F3}", Tmax), Font, Brushes.Black, 250, yT);
                    g.DrawString(string.Format("Uf = {0:F3}", a14), Font, Brushes.Black, 350, yT);
                    g.DrawString(string.Format("dUf = {0:F3}", a6 / 100), Font, Brushes.Black, 450, yT);
                }
                if (f.RB3.Checked)//экстраполяция
                {
                    v = 0.7f;
                    //Tmax = TB5.Value;
                    Tmax = 10;
                    K2 = f.TB4.Value * 0.01f;//коэфф фильтрации
                    dt = Tmax / 10;
                    //dt = Tmax / n;
                    Mt = n / Tmax;
                    t = tc = nn = 0;
                    d0 = d2 = D11 = d12 = a2 = a4 = s2 = 0;
                    s = s1 = -1;
                    dU = 0;
                    A[0] = -20;
                    A[1] = 0;
                    Ufs = 0;
                    if (s2 <= 0)
                        for (int i = 0; i < 10; i++)
                        {
                            s2++;
                            s *= s1;
                            r[i] = 20 * s * random10[i];
                        }
                    float y1 = (PB.Height - 2 * dd) * 0.68f;
                    for (int i = 1; i < 10; i++)
                    {
                        t += dt;
                        float x = dd + tc * Mt;
                        b = dd + t * Mt;
                        b1 = dd + (t + dt) * Mt;
                        Uist = 25 * t;
                        a2 = Uist + r[i];
                        Upr = 2 * A[i] - A[i - 1];
                        A[i + 1] = a2;
                        Uf = Upr + K2 * (A[i + 1] - Upr);
                        dU = dU + Math.Abs(Uf - Uist);
                        Uppr = Uf + (Uf - Ufs);
                        A[i + 1] = Uf;
                        //
                        g.DrawLine(Pens.Red, x, y1 - v * d0, b, y1 - v * a2);//ИЗМЕРЕННОЕ
                        g.DrawLine(Pens.Magenta, b, y1 - v * Uf, b1, y1 - v * Uppr);//ПРОГНОЗ
                        g.DrawLine(Pens.Green, x, y1 - v * D11, b, y1 - v * Uf);//ОТФИЛЬТРОВ
                        g.DrawLine(Pens.Blue, x, y1 - v * d12, b, y1 - v * Uist);//ИСТИННОЕ
                        //
                        tc = t;
                        d0 = a2;
                        d2 = a4;
                        d10 = Upr;
                        D11 = Uf;
                        Ufs = Uf;
                        d12 = Uist;
                        if (f.CB.Checked && Slow && i % 1 == 0) PB.Refresh();
                    }
                    g.DrawString(string.Format("Uizm = {0:F2}", a2), Font, Brushes.Black, 100, yT);
                    g.DrawString(string.Format("Uist = {0:F2}", Uist), Font, Brushes.Black, 200, yT);
                    g.DrawString(string.Format("Uf = {0:F2}", Uf), Font, Brushes.Black, 300, yT);
                    g.DrawString(string.Format("Upr = {0:F2}", Uppr), Font, Brushes.Black, 400, yT);
                    g.DrawString(string.Format("dU = {0:F2}", dU), Font, Brushes.Black, 500, yT);
                }
            }
            PB.Refresh();
        }

        private bool inter(Graphics g)
        {
            tc = t1;
            t = t2;
            float x = dd + t1 * Mt;
            b = dd + t2 * Mt;
            d12 = c1;
            a14 = c2;
            a3 = Math.Abs(a14);
            if (a6 < a3) a6 = a3;
            float y1 = (PB.Height - 2 * dd) * 0.46f;
            g.DrawLine(Pens.Blue, x, y1 - d12, b, y1 - a14);//возмущение
            z = (float)Math.Abs((t2 - t1) * (d12 - a14) / 2);
            c1 = a14;
            a6 += (float)Math.Abs(a5 - z);
            c1 = a14;
            s5 = s6 = z = nn = 0;
            return m < 2 * (36 - K2);

        }

        public void ReDraw(Frm f)
        {
            this.f = f;
            Picture(true);
        }

        private void fGraph_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) Close();
        }
        
        private void fGraph_Resize(object sender, EventArgs e)
        {
            if (PB.Width > 0 && PB.Height > 0)
            {
                PB.Image.Dispose();
                PB.Image = new Bitmap(PB.Width, PB.Height);
                Picture(false);
            }
        }

        private void fGraph_Shown(object sender, EventArgs e)
        {
            Picture(true);
        }

        private void fGraph_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.fG = null;
        }
    }
}
