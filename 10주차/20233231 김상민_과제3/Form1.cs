﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20233231_김상민_과제3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int[] Arrary01 = new int[10];
                string str1 = "";
                double num = 0;
                double average = 0;

                System.Random Rannum = new System.Random();
                for (int i = 0; i < 10; i++)
                {
                    Arrary01[i] = Rannum.Next(1, 100);
                }
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Arrary01[i] + "\n";
                        num += Arrary01[i];
                    }
                    else
                    {
                        str1 = str1 + "iarray[" + i + "] = " + Arrary01[i] + "      ";
                        num += Arrary01[i];
                    }
                }
                label1.Text = str1;
                average = num / 10;
                label2.Text = "10개 원소 배열값의 평균은 " + average;

            }
            catch (Exception ex)
            {

            }
        }
    }
}
