using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace TowerOfHanoi
{
    public partial class frmInputInfo : Form
    {
        public static string name;
        public static int spaceNum = 12;
        public static string fileName = "data.dat";
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
                if (!File.Exists(fileName)) //nếu file không tồn tại
                {
                    fs = new FileStream(fileName, FileMode.Create); //tạo file mới
                    fs.Close();
                }
                StreamReader sr = new StreamReader(fileName,true);
                if (sr.ReadToEnd() == null) //file rỗng
                {
                    sr.Close();
                    StreamWriter sw = new StreamWriter(fileName, true);
                    sw.WriteLine(EnCrypt(nameProcessed + ' ' + FrmTHN.level + "       " + FrmTHN.time,key)); //ghi vô file dòng đầu tiên
                    sw.Close();            
                    return;
                }
                sr.Close();
                StreamReader sr2 = new StreamReader(fileName, true);
                string str; 
                while ((str = DeCrypt(sr2.ReadLine(),key)) != null) //trong khi chưa đọc hết file
                {
                    Rank temp = new Rank(); //tạo biến tạm Rank
                    temp.name = str.Substring(0, str.IndexOf(' ')); //thêm tên
                    for (int i = 0; i < spaceNum - str.Substring(0, str.IndexOf(' ')).Length; i++) //thêm dấu cách với số lượng = spaceNum - số kí tự của name
                        temp.name = temp.name + ' ';
                    temp.lv = Int32.Parse(str.Substring(temp.name.Length + 1, 1)); //thêm lv
                    int h = Int32.Parse(str.Substring(str.Length - 8, 2));  //thêm giờ
                    int m = Int32.Parse(str.Substring(str.Length - 5, 2));  //thêm phút
                    int s = Int32.Parse(str.Substring(str.Length - 2, 2));  //thêm giây
                    temp.time = temp.time.Add(new TimeSpan(h, m, s));   //add vào time
                    ranks.Add(temp);    //add vào ranks 

                }
                Rank newrank = new Rank();
                newrank.name = nameProcessed;
                newrank.lv = FrmTHN.level;
                newrank.time = FrmTHN.time;
                ranks.Add(newrank); //thêm rank mới vào ranks
                for (int i = 0 ; i < ranks.Count(); i++)    //selection sort
                {   
                    for (int index = i + 1; index < ranks.Count(); index++)
                    {
                        if (ranks[i].lv == ranks[index].lv && ranks[i].time > ranks[index].time)
                        {
                            SwapRank(ranks, i, index);
                        }
                    }
                    
                }
                sr2.Close();
                StreamWriter sw2 = new StreamWriter(fileName);                
                foreach (Rank rank in ranks) //ghi tất cả rank trong ranks sau khi sort xong
                    sw2.WriteLine(EnCrypt(rank.name + ' ' + rank.lv + "       " + rank.time,key));
                sw2.Close();
            }
            catch (FileLoadException)
            {
                MessageBox.Show("Data file have problem!", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void SwapRank(List<Rank> ranks, int positionA, int positionB) //swap 2 rank
        {
            Rank temp = ranks[positionA];
            ranks[positionA] = ranks[positionB];
            ranks[positionB] = temp;
        }


        //tham khảo tại http://diendan.congdongcviet.com/threads/t35496::ma-hoa-password-trong-csharp-nhu-the-nao.cpp
        public static string key = "test"; //khóa của mã hóa và giải mã
        public static string EnCrypt(string strEnCrypt, string key) //mã hóa sang MD5
        {
            try
            {
                byte[] keyArr;
                byte[] EnCryptArr = UTF8Encoding.UTF8.GetBytes(strEnCrypt);
                MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
                keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
                tripDes.Key = keyArr;
                tripDes.Mode = CipherMode.ECB;
                tripDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = tripDes.CreateEncryptor();
                byte[] arrResult = transform.TransformFinalBlock(EnCryptArr, 0, EnCryptArr.Length);
                return Convert.ToBase64String(arrResult, 0, arrResult.Length);
            }
            catch (Exception) { }
            return null;
        }

        public static string DeCrypt(string strDecypt, string key) //giải mã
        {
            try
            {
                byte[] keyArr;
                byte[] DeCryptArr = Convert.FromBase64String(strDecypt);
                MD5CryptoServiceProvider MD5Hash = new MD5CryptoServiceProvider();
                keyArr = MD5Hash.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider();
                tripDes.Key = keyArr;
                tripDes.Mode = CipherMode.ECB;
                tripDes.Padding = PaddingMode.PKCS7;
                ICryptoTransform transform = tripDes.CreateDecryptor();
                byte[] arrResult = transform.TransformFinalBlock(DeCryptArr, 0, DeCryptArr.Length);
                return UTF8Encoding.UTF8.GetString(arrResult);
            }
            catch (Exception) { }
            return null;
        }
    }
}
