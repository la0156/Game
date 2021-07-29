using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Game_bắn_súng
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer NhacGame;
        WindowsMediaPlayer NhacDan;
        WindowsMediaPlayer BanChet;

        PictureBox[] DanQuaiVat;
        int TocDoDanQuaiVat;

        PictureBox[] Sao;
        int TocDoChoi;

        PictureBox[] Dan;
        int TocDoDan;

        PictureBox[] QuaiVat;
        int TocDoQuaiVat;

        int TocDoNen;
        Random NgauNhien;

        int Diem;
        int CapDo;
        int DoKho;
        bool TamDung;
        bool TroChoiKetThuc;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TamDung = false;
            TroChoiKetThuc = false;
            Diem = 0;
            DoKho = 9;
            CapDo = 1;

            TocDoNen = 15;
            TocDoChoi = 30;
            TocDoQuaiVat = 15;
            TocDoDan = 30;
            TocDoDanQuaiVat = 10;

            Dan = new PictureBox[3];


            Image Danban = Image.FromFile(@"hinhanh\Danban.png");

            Image QuaiVat1 = Image.FromFile("hinhanh\\boss1.jpg");
            Image QuaiVat2 = Image.FromFile("hinhanh\\boss2.jpg");
            Image QuaiVat3 = Image.FromFile("hinhanh\\boss3.jpg");
            Image QuaiVat4 = Image.FromFile("hinhanh\\bossHead1.png");
            Image QuaiVat5 = Image.FromFile("hinhanh\\BossHead2.jpg");

            QuaiVat = new PictureBox[10];

            for (int i = 0; i < QuaiVat.Length; i++)
            {
                QuaiVat[i] = new PictureBox();
                QuaiVat[i].Size = new Size(40, 40);
                QuaiVat[i].SizeMode = PictureBoxSizeMode.Zoom;
                QuaiVat[i].BorderStyle = BorderStyle.None;
                QuaiVat[i].Visible = false;
                this.Controls.Add(QuaiVat[i]);
                QuaiVat[i].Location = new Point((i + 1) * 50, -50);
            }

            QuaiVat[0].Image = QuaiVat4;
            QuaiVat[1].Image = QuaiVat2;
            QuaiVat[2].Image = QuaiVat3;
            QuaiVat[3].Image = QuaiVat3;
            QuaiVat[4].Image = QuaiVat1;
            QuaiVat[5].Image = QuaiVat3;
            QuaiVat[6].Image = QuaiVat2;
            QuaiVat[7].Image = QuaiVat3;
            QuaiVat[8].Image = QuaiVat2;
            QuaiVat[9].Image = QuaiVat5;

            for (int i=0; i<Dan.Length; i++)
            {
                Dan[i] = new PictureBox();
                Dan[i].Size = new Size(8, 8);
                Dan[i].Image = Danban;
                Dan[i].SizeMode = PictureBoxSizeMode.Zoom;
                Dan[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(Dan[i]);
            }

            NhacGame = new WindowsMediaPlayer();
            NhacDan = new WindowsMediaPlayer();
            BanChet = new WindowsMediaPlayer();

            NhacGame.URL = "nhac\\nhacnen.mp3";
            NhacDan.URL = "nhac\\dan.mp3";
            BanChet.URL = "nhac\\bom.mp3";

            NhacGame.settings.setMode("loop", true);
            NhacGame.settings.volume = 5;
            NhacDan.settings.volume = 1;
            BanChet.settings.volume = 6;

            Sao = new PictureBox[10];
            NgauNhien = new Random();

            for(int i = 0; i<Sao.Length; i++)
            {
                Sao[i] = new PictureBox();
                Sao[i].BorderStyle = BorderStyle.None;
                Sao[i].Location = new Point(NgauNhien.Next(20, 580), NgauNhien.Next(-10, 400));
                if(i % 2 == 1)
                {
                    Sao[i].Size = new Size(4, 4);
                    Sao[i].BackColor = Color.Wheat;
                }
                else
                {
                    Sao[i].Size = new Size(4, 4);
                    Sao[i].BackColor = Color.Red;
                }

                this.Controls.Add(Sao[i]);              
            }

            DanQuaiVat = new PictureBox[10];
            Image DanQuaiVatBan = Image.FromFile(@"hinhanh\DanQuaiVat.png");

            for (int i = 0; i < DanQuaiVat.Length; i++)
            {
                DanQuaiVat[i] = new PictureBox();
                DanQuaiVat[i].Size = new Size(8, 15);
                DanQuaiVat[i].Image = DanQuaiVatBan;
                DanQuaiVat[i].SizeMode = PictureBoxSizeMode.Zoom;
                //DanQuaiVat[i].Visible = false;
                //DanQuaiVat[i].BackColor = Color.Red;
                int x = NgauNhien.Next(0, 10);
                DanQuaiVat[i].BorderStyle = BorderStyle.None;
                DanQuaiVat[i].Location = new Point(QuaiVat[x].Location.X, QuaiVat[x].Location.Y - 20);
                this.Controls.Add(DanQuaiVat[i]);
            }
            NhacGame.controls.play();
        }

        private void NgoiSao_Tick(object sender, EventArgs e)
        {
            for (int i =0; i< Sao.Length/2; i++)
            {
                Sao[i].Top += TocDoNen;
                if(Sao[i].Top >= this.Height)
                {
                    Sao[i].Top = -Sao[i].Height;
                }
            }
            for (int i = Sao.Length/2; i < Sao.Length; i++)
            {
                Sao[i].Top += TocDoNen - 2;
                if (Sao[i].Top >= this.Height)
                {
                    Sao[i].Top = -Sao[i].Height;
                }
            }
        }

        private void TraiMoveTimer_Tick(object sender, EventArgs e)
        {
            if(NguoiChoi.Left > 10)
            {
                NguoiChoi.Left -= TocDoChoi;
            }
        }

        private void PhaiMoveTimer_Tick(object sender, EventArgs e)
        {
            if (NguoiChoi.Right < 580)
            {
                NguoiChoi.Left += TocDoChoi;
            }
        }

        private void XuongMoveTimer_Tick(object sender, EventArgs e)
        {
            if (NguoiChoi.Top < 400)
            {
                NguoiChoi.Top += TocDoChoi;
            }
        }

        private void LenMoveTimer_Tick(object sender, EventArgs e)
        {
            if (NguoiChoi.Top > 10)
            {
                NguoiChoi.Top -= TocDoChoi;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!TamDung)
            {
                if (e.KeyCode == Keys.Right)
                {
                    PhaiMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    TraiMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    XuongMoveTimer.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    LenMoveTimer.Start();
                }
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            PhaiMoveTimer.Stop();
            TraiMoveTimer.Stop();
            XuongMoveTimer.Stop();
            LenMoveTimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!TroChoiKetThuc)
                {
                    if (TamDung)
                    {
                        BatDauThoiGian();
                        TuaDe.Visible = false;
                        NhacGame.controls.play();
                        TamDung = false;
                    }
                    else
                    {
                        TuaDe.Location = new Point(this.Width / 2 - 120, 150);
                        TuaDe.Text = "TẠM DỪNG";
                        TuaDe.Visible = true;
                        NhacGame.controls.pause();
                        DungThoiGian();
                        TamDung = true;
                    }
                }
            }
        }

        private void DanMoveTimer_Tick(object sender, EventArgs e)
        {
            NhacDan.controls.play();
            for (int i = 0; i< Dan.Length; i++)
            {
                if (Dan[i].Top > 0)
                {
                    Dan[i].Visible = true;
                    Dan[i].Top -= TocDoDan;

                    HieuUng();
                }
                else
                {
                    Dan[i].Visible = false;
                    Dan[i].Location = new Point(NguoiChoi.Location.X + 20, NguoiChoi.Location.Y - i * 30);
                }
            }
        }

        private void QuaiVatMoveTimer_Tick(object sender, EventArgs e)
        {
            QuaiVatChuyenDong(QuaiVat, TocDoQuaiVat);
        }

        private void QuaiVatChuyenDong(PictureBox[] Mang, int TocDo)
        {
            for (int i = 0; i < Mang.Length; i++)
            {
                Mang[i].Visible = true;
                Mang[i].Top += TocDo;
                if(Mang[i].Top > this.Height)
                {
                    Mang[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void HieuUng()
        {
            for (int i = 0; i < QuaiVat.Length; i++)
            {
                if (Dan[0].Bounds.IntersectsWith(QuaiVat[i].Bounds)
                    || Dan[1].Bounds.IntersectsWith(QuaiVat[i].Bounds) || Dan[2].Bounds.IntersectsWith(QuaiVat[i].Bounds))
                {
                    BanChet.controls.play();

#Tínhđiểm
                    Diem = Diem + 1;
                    lblDiem.Text = (Diem < 10) ? "0" + Diem.ToString() : Diem.ToString();

                    if (Diem % 10 == 0)
                    {
                        CapDo = CapDo + 1;
                        lblCap.Text = (CapDo < 10) ? "0" + CapDo.ToString() : CapDo.ToString();

                        if (TocDoQuaiVat <= 10 && TocDoDanQuaiVat <= 10 && DoKho >= 0)
                        {
                            DoKho--;
                            TocDoQuaiVat++;
                            TocDoDanQuaiVat++;
                        }

                        if (CapDo == 10)
                        {
                            GameKetThuc("BẠN CHƠI RẤT TUYỆT");
                        }
                    }

                    QuaiVat[i].Location = new Point((i + 1) * 50, -100);
                }

                if (NguoiChoi.Bounds.IntersectsWith(QuaiVat[i].Bounds))
                {
                    BanChet.settings.volume = 30;
                    BanChet.controls.play();
                    NguoiChoi.Visible = false;
                    GameKetThuc("GAME OVER");
                }
            }
        }

        private void GameKetThuc(String str)
        {
            TuaDe.Text = str;
            //TuaDe.Location = new Point(120, 120);
            TuaDe.Visible = true;
            btnDungTranDau.Visible = true;
            btnThoat.Visible = true;

            NhacGame.controls.stop();
            DungThoiGian();
        }

        private void DungThoiGian()
        {
            NgoiSao.Stop();
            QuaiVatMoveTimer.Stop();
            DanMoveTimer.Stop();
            DanQuaiVatMoveTimer.Stop();
        }

        private void BatDauThoiGian()
        {
            NgoiSao.Start();
            QuaiVatMoveTimer.Start();
            DanMoveTimer.Start();
        }

        private void DanQuaiVatMoveTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (DanQuaiVat.Length - DoKho); i++)
            {
                if (DanQuaiVat[i].Top < this.Height)
                {
                    DanQuaiVat[i].Visible = true;
                    DanQuaiVat[i].Top += TocDoDanQuaiVat;
                    HieuUngDongCuaDan();
                }
                else
                {
                    DanQuaiVat[i].Visible = false;
                    int x = NgauNhien.Next(0, 10);
                    DanQuaiVat[i].Location = new Point(QuaiVat[x].Location.X + 20, QuaiVat[x].Location.Y + 30);
                }
            }
        }

        private void HieuUngDongCuaDan()
        {
            for (int i = 0; i < DanQuaiVat.Length; i++)
            {
                if (DanQuaiVat[i].Bounds.IntersectsWith(NguoiChoi.Bounds))
                {
                    DanQuaiVat[i].Visible = false;
                    BanChet.settings.volume = 30;
                    BanChet.controls.play();
                    NguoiChoi.Visible = false;
                    GameKetThuc("GAME OVER");
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDungTranDau_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);
        }
    }
}
