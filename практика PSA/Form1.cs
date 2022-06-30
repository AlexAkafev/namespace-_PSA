using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика_PSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int p = Convert.ToInt32(textBox1.Text);
            int numberp = p;
            int peremenp = 0;
            int sp = 0;
            int jp = 2;
            if (numberp > 1)
            {
                for (; jp < numberp; jp++)
                {
                    peremenp = numberp % jp;
                    if (peremenp == 0)
                    {
                        sp = 1;
                        break;
                    }
                }
                if (sp == 0)
                {
                    int q = Convert.ToInt32(textBox2.Text);
                    int numberq = q;
                    int peremenq = 0;
                    int sq = 0;
                    int jq = 2;
                    if (numberq > 1)
                    {
                        for (; jq < numberq; jq++)
                        {
                            peremenq = numberq % jq;
                            if (peremenq == 0)
                            {
                                sq = 1;
                                break;
                            }
                        }
                        if (sq == 0)
                        {
                            int n = p * q;
                            int function = (p - 1) * (q - 1);
                            int max = function;
                            int peremen = 0;
                            int s = 0;
                            int r = 0;
                            int[] mas1 = new int[max];
                            for (int i = 2; i <= max; i++)
                               {
                                int j = 2;
                                for (; j < i; j++)
                                {
                                    peremen = i % j;
                                    if (peremen == 0)
                                    {
                                        s = 1;
                                        break;
                                    }
                                }
                                if (s == 0)
                                {
                                    mas1[r] = i;
                                    r = r + 1;
                                }
                                s = 0;
                            }
                            int c = 0; 
                            for (int i = 0; i < max; i++)
                            {
                                if (mas1[i] != 0)
                                {
                                    c = c + 1;
                                }
                            } int[] mass2 = new int[c]; 
                            for (int i = 0; i < c; i++)
                            {
                                mass2[i] = mas1[i];
                            }
                            int E = 0;
                            for (int i = 0; i < (c - 1); i++)
                            {
                                int number = function % mass2[i];
                                if (mass2[i] < function && number != 0)
                                {
                                    E = mass2[i];
                                    break;
                                }
                            }
                            int d = 0;
                            for (int i = 1; i < 10000; i++)
                            {
                                d = (i * E) % function;
                                if (d == 1)
                                {
                                    d = i;
                                    break;
                            }
                        }
                        int P = Convert.ToInt32(textBox4.Text);
                            if (P < n)
                            {
                                ulong a = Convert.ToUInt64(Math.Pow(P, E) % n);
                                ulong b = Convert.ToUInt64(Math.Pow(a, d) % n);
                                textBox3.Text = ("открытые ключи: e = " + E + "; n = " + n) +
                                Environment.NewLine + ("секретные ключи: d = " + d + "; n = " + n) +
                                Environment.NewLine + ("Вы зашифровываете число: " + P) +
                                Environment.NewLine + ("Зашифровонное число: " + a) +
                                Environment.NewLine + ("Расшифрованое число: " + b);
                            }
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
    }
    
