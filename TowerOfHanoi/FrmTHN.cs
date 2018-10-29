using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TowerOfHanoi
{
    public partial class FrmTHN : Form
    {
        PictureBox FirstTopDisk;
        Point d;
        string towerA, towerB;
        public static TimeSpan time; // Thành phần dùng cho đồng hồ
                       //Một đối tượng TimeSpan đại diện cho một khoảng thời gian (khoảng thời gian hoặc thời gian trôi qua)
                       //được đo là số ngày, giờ, phút, giây và phân số của một giây hoặc số dương.
                       //Một TimeSpan giá trị đại diện cho một khoảng thời gian và có thể được diễn tả như một số cụ thể của ngày, giờ, phút, giây và mili giây.
                       //Bởi vì nó đại diện cho một khoảng thời gian chung mà không tham chiếu đến một điểm bắt đầu hoặc điểm kết thúc cụ thể, nó không thể được biểu thị theo năm và tháng
                       //Đơn vị thời gian lớn nhất mà cấu trúc TimeSpan sử dụng để đo thời lượng là một ngày.

        PictureBox[] disks; // 1 mảng các đĩa
        int moveCount;
        public static int level;

        Stack<PictureBox> DisksRodA, DisksRodB, DisksRodC, //Ứng với mỗi cọc cần stack để lưu những đĩa đang bỏ vào tương ứng từng cọc -> cần 3 stack 
                                                           //Mỗi thành phần chứa trong cọc là 1 cái đĩa -> Mà đĩa là picturebox 
                                                           //-> Mỗi phần tử trong stack sẽ là 1 picturebox (Stack<PictureBox>)

                    FirstClickedDisks, SecondClickedDisks; // 2 tham chiếu đến tập đĩa được nhấn ở lần đầu và lần 2 để coi có di chuyển đĩa qua được không
        const int FIRSTY = 411, DISKHEIGHT = 27, // Toạ độ y đầu tiên của đĩa đầu tiên trong mỗi cọc ( biên trên )
                                                 // Để đặt đĩa nằm lên trên và ngay sát lấy toạ độ y của thằng đầu - toạ độ y thằng trên ( = 9 chiều cao của thằng trên = 27 )                         
            DistXFromTowerToDisk = 12; // Toạ độ X từ biên picturebox cột cho đến đĩa 

        public FrmTHN()
        {

            InitializeComponent();
            disks = new PictureBox[] { pic1, pic2, pic3, pic4, pic5, pic6, pic7, pic8 }; // khởi tạo đĩa -> Truyền vào từng PictureBox
                                                                                         // -> Tạo được 1 mảng 1 chiều chứa các tham chiếu đến các đĩa
            picTowerA.Tag = DisksRodA = new Stack<PictureBox>(); //Khởi tạo các đĩa của cọc ->Lấy tham chiếu đến tập đĩa ứng với cọc A bỏ vào thuộc tính tag
            picTowerB.Tag = DisksRodB = new Stack<PictureBox>();
            picTowerC.Tag = DisksRodC = new Stack<PictureBox>();

            btnGiveUp.Enabled = false;
            btnAuto.Enabled = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            //this.Dispose();
            Application.Exit();

        }

        private void FrmTHN_Load(object sender, EventArgs e)
        {

        }

        private void FrmTHN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)

                e.Cancel = true;

        }

        private void btnRule_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Luật chơi: \n- Mỗi lần chỉ được di chuyển 1 đĩa trên cùng của cọc. \n- Đĩa nằm trên phải nhỏ hơn đĩa nằm dưới. \n- Trò chơi được hoàn thành khi các đĩa được chuyển hết từ cọc A ---> cọc C.",
                "Rule (VI)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  Nội dung
            //  Tiêu đề "Luật chơi" cho hộp loại 
            //  1 Nút ok
            //  1 Biểu tượng Information

        }

        private void tmrCountTime_Tick(object sender, EventArgs e) // Đồng hồ đếm thời gian
        {

            time = time.Add(new TimeSpan(0, 0, 1)); // time sẽ bằng chính nó + thêm 1 lượng tgian là 1 giây
            lblTime.Text = string.Format("{0:00}:{1:00}:{2:00}", // label hiển thị thời gian định dạng nó thành string
                                            time.Hours, time.Minutes, time.Seconds);//0,1,2 là thứ tự - 00 là hiển thị khi chạy chương trình

        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            int step = 19;
            if (FirstTopDisk.Location.Y < d.Y)
            {
                FirstTopDisk.Location = new Point(FirstTopDisk.Location.X, d.Y - (d.Y - FirstTopDisk.Location.Y - step));
                if(Math.Abs(FirstTopDisk.Location.Y-d.Y)<10)
                    FirstTopDisk.Location = new Point(FirstTopDisk.Location.X, d.Y);
            }
            if (FirstTopDisk.Location.X < d.X)
            {
                FirstTopDisk.Location = new Point(d.X - (d.X - FirstTopDisk.Location.X - step), FirstTopDisk.Location.Y);
                if (Math.Abs(FirstTopDisk.Location.X - d.X) < 10)
                    FirstTopDisk.Location = new Point(d.X, FirstTopDisk.Location.Y);
            }
            if (FirstTopDisk.Location.Y > d.Y)
            {
                FirstTopDisk.Location = new Point(FirstTopDisk.Location.X, d.Y - (d.Y - FirstTopDisk.Location.Y + step));
                if (Math.Abs(FirstTopDisk.Location.Y - d.Y) < 10)
                    FirstTopDisk.Location = new Point(FirstTopDisk.Location.X, d.Y);
            }
            if (FirstTopDisk.Location.X > d.X)
            {
                FirstTopDisk.Location = new Point(d.X - (d.X - FirstTopDisk.Location.X + step), FirstTopDisk.Location.Y);
                if (Math.Abs(FirstTopDisk.Location.X - d.X) < 10)
                    FirstTopDisk.Location = new Point(d.X, FirstTopDisk.Location.Y);
            }
        }

        private void AutoSolve(int n, PictureBox src, PictureBox aux, PictureBox des)
        {
            if (n > 0)
            {
                AutoSolve(n - 1, src, des, aux);            
                picTower_Click(src, new EventArgs());
                picTower_Click(des, new EventArgs());
                WaitNSeconds(1);
                AutoSolve(n - 1, aux, src, des);
            }
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            if(rtbLog.Text != "Project 1 - Poon & Thanh Tuan\n" + "========== MOVE DETAIL ==========")
            {
                MessageBox.Show("Phải dùng Auto ban đầu bạn ei!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnAuto.Enabled = false;
                this.Enabled = true;
                return;
            }
            btnAuto.Enabled = false;
            AutoSolve((int)nubLevel.Value, picTowerA, picTowerB, picTowerC);
            this.Enabled = true;
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            rtbLog.Text = "Project 1 - Poon & Thanh Tuan\n" +"========== TOP 10 RANK ==========\n" + "   Name         Level    Time";
            System.IO.StreamReader sr = new System.IO.StreamReader(frmInputInfo.fileName, true);
            for (int i = 0, j = 1; i < 10; i++)
            {
                
                string s = SecurityData.DeCrypt(sr.ReadLine(),SecurityData.key);
                if (s == null) return;
                string temp = s.Substring(0, s.IndexOf(' '));
                if (Int32.Parse(s.Substring(temp.Length + (frmInputInfo.spaceNum - temp.Length) + 1, 1)) != numUpDownLV.Value)
                    continue;
                rtbLog.Text = rtbLog.Text + Environment.NewLine+ j + ". " + s;
                j++;
            }
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Give up", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                tmrCountTime.Stop(); //timer sẽ ngừng đếm
                tmrAnimation.Enabled = false;
                nubLevel.Enabled = true;
                btnGiveUp.Enabled = false;
                btnPlay.Enabled = true;
                btnPlay.Text = "PLAY AGAIN";
                MessageBox.Show("You lose :P", "FAIL");
            }
            else return;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            //reset
            tmrCountTime.Stop(); // ->Khi bấm vào thì những trạng thái đang dùng trước đó sẽ trả về ban đầu
                                 // -> Để người dùng có thể bắt đầu chơi lại 1 game mới
            tmrAnimation.Enabled = false;
            btnAuto.Enabled = true;
            rtbLog.Text =
            rtbLog.Text = "Project 1 - Poon & Thanh Tuan\n" + "========== MOVE DETAIL ==========";
            foreach (PictureBox disk in disks)
            {

                disk.Visible = false; // trả về trạng thái ban đầu -> ẩn các đĩa -> Tính đa hình

            }

            time = new TimeSpan(0); // làm mới lại thời gian bắt đầu từ 0
            lblTime.Text = "Move: 00:00:00";
            lblMoveCount.Text = "Move: 0";
            moveCount = 0;// reset số lần đã di chuyển về 0 -> chưa di chuyển lần nào
            

            DisksRodA.Clear();//Khi được reset thì xoá hết các đĩa của cọc
            DisksRodB.Clear();
            DisksRodC.Clear();

            picTowerA.BorderStyle = picTowerB.BorderStyle = picTowerC.BorderStyle = BorderStyle.None;//Khi chọn vào 1 cái cọc sẽ có 1 cái border single 
                                                                                                     //-> Tắt hết borderStyle nếu có cọc nào đang được chọn
            FirstClickedDisks = SecondClickedDisks = null;//reset lần chọn đầu và lần 2

            //Initialize ( Khởi tạo sau khi reset )

            nubLevel.Enabled = false; //Tắt điều chỉnh số đĩa để tránh người dùng đang dùng 3 đĩa nhưng có thể sửa lại n đĩa trong lúc đang chơi 
            level = (int)nubLevel.Value;
            btnGiveUp.Enabled = true;
            btnPlay.Enabled = false;
            btnPlay.Text = "PLAY AGAIN";

            int x = picTowerA.Location.X + DistXFromTowerToDisk, y = FIRSTY; // Các đĩa khởi tạo sẽ bỏ vào cọc A nên toạ độ x phải giống nhau
            // Toạ độ cột A + khoảng chênh lệch -> Toạ độ đĩa

            for (int i = (int)nubLevel.Value - 1; i >= 0; --i, y -= DISKHEIGHT) //Khi người dùng chọn n đĩa thì phải hiển thị nó lên và xếp nó vào cọc A
            {                                                                   //Để biết đĩa nằm vị trí nào ta dùng 1 vòng for i từ số lượng chuyển kiểu của giá trị số lượng đĩa người dùng chọn -1 ( lùi 1 )
                                                                                //Duyệt thông qua mảng PictureBox[] disks 
                                                                                //Ví dụ người ta chọn 3 đĩa thì ứng với đĩa 1,2,3 phần tử 0,1,2 và đĩa lớn sẽ hiển thị trước ( đĩa số 3 )

                disks[i].Location = new Point(x, y);// Trước khi hiển thị đĩa phải chỉnh lại vị trí (Location -> bản thân nó là kiểu Point để lưu được toạ độ) 
                                                    // Dựa vào location bên frm Design
                                                    // Góc toạ độ O nằm ở góc trái trên của form -> Chiều dương x từ O -> sang phải,y từ O -> xuống dưới
                                                    // Các đĩa đều nằm chung vị trí nên có y = 411 ( được định nghĩa bằng 1 cái hằng số ở trên bài )

                disks[i].Visible = true; // Hiển thị đĩa thứ i 
                //Khi vòng lặp chạy lần kế cần lùi toạ độ y lại 1 đoạn = chiều cao đĩa -> đặt nó ở trên 
                DisksRodA.Push(disks[i]);// Sau khi khởi tạo phải push nó vào Stack đĩa cọc A -> Gọi phương thức push(đĩa thứ i)


            }

            switch (nubLevel.Value)
            {
                case 2:
                    lblLeast.Text = "(Minimize in 3 steps)";
                    break;
                case 3:
                    lblLeast.Text = "(Minimize in 7 steps)";
                    break;
                case 4:
                    lblLeast.Text = "(Minimize in 15 steps)";
                    break;
                case 5:
                    lblLeast.Text = "(Minimize in 31 steps)";
                    break;
                case 6:
                    lblLeast.Text = "(Minimize in 63 steps)";
                    break;
                case 7:
                    lblLeast.Text = "(Minimize in 127 steps)";
                    break;
                default:
                    lblLeast.Text = "(Minimize in 255 steps)";
                    break;
            }
            tmrCountTime.Start(); // Cho chạy timer 

        }

        private void picTower_Click(object sender, EventArgs e)
        {
            if (nubLevel.Enabled)

                return; // Trong TH được phép sửa số lượng đĩa thì không xử lí -> Chưa chơi
            PictureBox ClickedTower = (PictureBox)sender; // Lấy ra cọc được nhấn để bật đường biên -> Chuyển kiểu từ sender vì sender chưa tham chiếu đến cọc được nhấn
            Stack<PictureBox> DisksOfClickedTower = (Stack<PictureBox>)ClickedTower.Tag;// Lấy stack chứa những cái đĩa

            if (FirstClickedDisks == null)// nếu tập đĩa được nhấn lần đầu = null -> trc đó chưa nhấn 
            {

                if (DisksOfClickedTower.Count == 0)//Nếu TH chọn vào tập đĩa không có đĩa thì kết thúc k xử lí nữa

                    return;

                //Khi nào cọc nhấn vào có đĩa thì nó mới đánh dấu đó là cái cọc hợp lệ và đánh dấu FirstClickedDisks
                FirstClickedDisks = DisksOfClickedTower;// Cập nhật cái tập đĩa được đầu tiên = tập những cái đĩa được nhấn 
                towerA = ClickedTower.Name.ToString() == "picTowerA" ? "Tower A" : ClickedTower.ToString() == "picTowerB" ? "Tower B" : "Tower C";
                ClickedTower.BorderStyle = BorderStyle.FixedSingle;//Có đường biên để biết cọc nào được nhấn
            }

            else if (SecondClickedDisks == null)// nếu tập đĩa được nhấn lần đầu = null -> trc đó chưa nhấn
            {

                if (DisksOfClickedTower == FirstClickedDisks)//TH lần nhấn 2 nó trùng lần nhấn đầu
                {
                    FirstClickedDisks = null;//Xem như bỏ chọn k muốn di chuyển ở cọc -> reset lần đầu về null xem như chưa chọn
                    ClickedTower.BorderStyle = BorderStyle.None;//Bỏ đường biên -> trả lại trạng thái trc khi chọn
                    return;//Xem như nhấn vào nó là chọn và nhấn lại 9 nó là bỏ chọn

                }
                SecondClickedDisks = DisksOfClickedTower;//Đánh dấu những cái đĩa được nhấn lần 2 = tập những cái đĩa được nhấn 
                towerB = ClickedTower.Name.ToString() == "picTowerA" ? "Tower A" : ClickedTower.ToString() == "picTowerB" ? "Tower B" : "Tower C";
                ProcessMovingDisk(ClickedTower);//Tách ra 1 phương thức xử lí -> Xử lí di chuyển đĩa ntn khi đã được đánh dấu 2 tập đĩa 
            }

        }

        private void ProcessMovingDisk(PictureBox ClickedTower)
        {
            //Lưu ý có 2 trường hợp
            if (SecondClickedDisks.Count == 0)  //Nếu cọc nhận đĩa chưa có đĩa
            {
                MoveDisk(new Point(ClickedTower.Location.X + DistXFromTowerToDisk, FIRSTY));//Chỉ định toạ độ của đĩa được chọn của cọc đầu sang cọc được chọn 
                                                                                            //Đĩa này sẽ là đĩa đầu tiên của cọc chưa có đĩa
            }
            else // Nếu cọc thứ 2 có đĩa -> xét xem đĩa được chọn có nhỏ hơn đĩa đầu cọc 2 k 
            {

                PictureBox FirstTopDisk = FirstClickedDisks.Peek();//Vì chưa chắc sẽ move qua được nên chỉ lấy thông tin 
                PictureBox SecondTopDisk = SecondClickedDisks.Peek();

                if (int.Parse(FirstTopDisk.Tag.ToString()) < int.Parse(SecondTopDisk.Tag.ToString()))//Chuyển kiểu ,Trong lúc tạo đĩa thuộc tính tag đã được điền số tương ứng,
                {                                                                                    //1 chuỗi được lưu vào tt tag,thuộc tính tag giữ tham chiếu đó
                                                                                                     //So sánh nếu FirstTopDisk nhỏ hơn SecondTopDisk thì phù hợp để di chuyển 
                    MoveDisk(new Point(SecondTopDisk.Location.X, SecondTopDisk.Location.Y - DISKHEIGHT));//Toạ độ x sẽ giống nhau,vì đĩa được chuyển qua nằm trên nên toạ độ y xích lên 1 khoảng = chiều cao
                }
                else //Nếu không nhỏ hơn

                    SecondClickedDisks = null;// Bỏ đánh dấu của lần chọn 2 -> Xem như chỉ mới chọn lần 1 -> được phép chọn lại tập đĩa khác thoả điều kiện di chuyển

            }

        }

        private void MoveDisk(Point point)
        {           
            FirstTopDisk = FirstClickedDisks.Pop();//Đầu tiên phải xoá đĩa đầu tiên của cọc được chọn (Phương thức pop -> xoá đĩa đầu và trả lại đĩa đó)    
            d = point;
            tmrAnimation.Start();
            if (FirstTopDisk.Location == d)     //Cập nhật toạ độ của đĩa được lấy
            {
                tmrAnimation.Stop();            
            }

            SecondClickedDisks.Push(FirstTopDisk);//Bỏ đĩa được chọn lên đầu của tập ở lần chọn thứ 2

            ++moveCount;//Mỗi lần di chuyển thành công -> tăng movecount
            lblMoveCount.Text = string.Format("Move: {0}", moveCount);//Và cập nhật lại label movecount ,bỏ movecount vô
            FirstClickedDisks = SecondClickedDisks = null;//reset 2 tập đĩa được nhấn 
            picTowerA.BorderStyle = picTowerB.BorderStyle = picTowerC.BorderStyle = BorderStyle.None;//Vì k biết đường biên của lần chọn là cọc nào nên tắt cả 3 cọc          
            rtbLog.Text = rtbLog.Text + Environment.NewLine + moveCount + ". " + towerA + " --> " + towerB; //thêm vào log
            if (DisksRodC.Count == nubLevel.Value) //Nếu đã di chuyển hết các đĩa qua cọc C rồi
            {                                      //Gọi tập đĩa của cọc C lấy ra count nếu = số lượng đã chọn ở Numeric -> xử lí
                //bxtnGiveUp.PerformClick(); 
                tmrCountTime.Stop();
                nubLevel.Enabled = true;
                btnGiveUp.Enabled = false;
                btnPlay.Enabled = true;
                MessageBox.Show("You have completed the challenge!\nYou are genuis!", "Congratulation",MessageBoxButtons.OK);
                frmInputInfo frm = new frmInputInfo();
                frm.ShowDialog();
                numUpDownLV.Value = nubLevel.Value;
                //btnRank_Click(null, null);
            }
            
        }

        private void picDisks_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox ClickedDisks = (PictureBox)sender;//sender lúc này 9 là picturebox ứng với đĩa được nhấn  

                if (DisksRodA.Contains(ClickedDisks))//Kiểm tra đĩa đang thuộc tập đĩa nào -> kiếm ->Dùng phương thức contains truyền vào đĩa được nhấn

                    picTower_Click(picTowerA, new EventArgs());// nếu đĩa được nhấn nằm ở cọc A -> Gọi lại phương thức xử lí sự kiện click cho cọc A

                else if (DisksRodB.Contains(ClickedDisks))

                    picTower_Click(picTowerB, new EventArgs());

                else

                    picTower_Click(picTowerC, new EventArgs());
            }catch(InvalidCastException a)
            {
                MessageBox.Show("Click chính xác vô bạn ei!", "Oops...", MessageBoxButtons.OK);
            }
        }

        private void WaitNSeconds(int segundos)         //đợi :3
        {
            if (segundos < 1) return;
            DateTime _desired = DateTime.Now.AddSeconds(segundos);
            while (DateTime.Now < _desired)
            {
                Application.DoEvents();
            }
        }
    }
}
