﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TowerOfHanoi
{
    public partial class frmInputInfo : Form
    {
        public static string name;
        public static int spaceNum = 12;
        public static string fileName = "data.inb";
        List<Rank> ranks = new List<Rank>();
        public struct Rank
        {
            public string name;
            public int lv;
            public TimeSpan time;
        }

        public frmInputInfo()
        {
            InitializeComponent();
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Contains(' ') || tbName.Text == "")
            {
                MessageBox.Show("Name can not contain spaces or null!", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            name = tbName.Text;
            rankInput(name);
            this.Close();
        }

        private void rankInput(string name)
        {
            try
            {
                string nameProcessed = name;
                for (int i = 0; i < spaceNum - name.Length; i++)
                    nameProcessed = nameProcessed + ' ';
                ranks = new List<Rank>();
                FileStream fs;
                if (!File.Exists(fileName))
                {
                    fs = new FileStream(fileName, FileMode.Create);
                    fs.Close();
                }
                StreamReader sr = new StreamReader(fileName,true);
                if (sr.ReadToEnd() == "")
                {
                    sr.Close();
                    StreamWriter sw = new StreamWriter(fileName, true);
                    sw.WriteLine(nameProcessed + ' ' + FrmTHN.level + "       " + FrmTHN.time);
                    sw.Close();            
                    return;
                }
                sr.Close();
                StreamReader sr2 = new StreamReader(fileName, true);
                string str; 
                while ((str = sr2.ReadLine()) != null)
                {
                    Rank temp = new Rank();
                    temp.name = str.Substring(0, str.IndexOf(' '));
                    for (int i = 0; i < spaceNum - str.Substring(0, str.IndexOf(' ')).Length; i++)
                        temp.name = temp.name + ' ';
                    temp.lv = Int32.Parse(str.Substring(temp.name.Length + 1, 1));
                    int h = Int32.Parse(str.Substring(str.Length - 8, 2));
                    int m = Int32.Parse(str.Substring(str.Length - 5, 2));
                    int s = Int32.Parse(str.Substring(str.Length - 2, 2));
                    temp.time = temp.time.Add(new TimeSpan(h, m, s));
                    ranks.Add(temp);

                }
                Rank newrank = new Rank();
                newrank.name = nameProcessed;
                newrank.lv = FrmTHN.level;
                newrank.time = FrmTHN.time;
                ranks.Add(newrank);
                int smallest = 0;
                for (int i = 0 ; i < ranks.Count(); i++)
                {   
                    Rank min = new Rank();
                    min = ranks[i];
                    for (int index = i + 1; index < ranks.Count(); index++)
                    {
                        if (min.lv == ranks[index].lv && min.time > ranks[index].time)
                        {
                            smallest = index;
                        }
                    }
                    SwapRank(ranks, i, smallest);
                }
                sr2.Close();
                StreamWriter sw2 = new StreamWriter(fileName);                
                foreach (Rank rank in ranks)
                    sw2.WriteLine(rank.name + ' ' + rank.lv + "       " + rank.time);
                sw2.Close();
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Data file have problem!", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SwapRank(List<Rank> ranks, int positionA, int positionB)
        {
            Rank temp = ranks[positionA];
            ranks[positionA] = ranks[positionB];
            ranks[positionB] = temp;
        }
    }
}
