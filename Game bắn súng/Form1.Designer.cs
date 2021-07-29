namespace Game_bắn_súng
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.NgoiSao = new System.Windows.Forms.Timer(this.components);
            this.NguoiChoi = new System.Windows.Forms.PictureBox();
            this.TraiMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.PhaiMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.XuongMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.LenMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DanMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.QuaiVatMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.DanQuaiVatMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.TuaDe = new System.Windows.Forms.Label();
            this.btnDungTranDau = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiem = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NguoiChoi)).BeginInit();
            this.SuspendLayout();
            // 
            // NgoiSao
            // 
            this.NgoiSao.Enabled = true;
            this.NgoiSao.Interval = 10;
            this.NgoiSao.Tick += new System.EventHandler(this.NgoiSao_Tick);
            // 
            // NguoiChoi
            // 
            this.NguoiChoi.Image = ((System.Drawing.Image)(resources.GetObject("NguoiChoi.Image")));
            this.NguoiChoi.Location = new System.Drawing.Point(263, 379);
            this.NguoiChoi.Name = "NguoiChoi";
            this.NguoiChoi.Size = new System.Drawing.Size(58, 50);
            this.NguoiChoi.TabIndex = 0;
            this.NguoiChoi.TabStop = false;
            // 
            // TraiMoveTimer
            // 
            this.TraiMoveTimer.Tick += new System.EventHandler(this.TraiMoveTimer_Tick);
            // 
            // PhaiMoveTimer
            // 
            this.PhaiMoveTimer.Tick += new System.EventHandler(this.PhaiMoveTimer_Tick);
            // 
            // XuongMoveTimer
            // 
            this.XuongMoveTimer.Tick += new System.EventHandler(this.XuongMoveTimer_Tick);
            // 
            // LenMoveTimer
            // 
            this.LenMoveTimer.Tick += new System.EventHandler(this.LenMoveTimer_Tick);
            // 
            // DanMoveTimer
            // 
            this.DanMoveTimer.Enabled = true;
            this.DanMoveTimer.Interval = 20;
            this.DanMoveTimer.Tick += new System.EventHandler(this.DanMoveTimer_Tick);
            // 
            // QuaiVatMoveTimer
            // 
            this.QuaiVatMoveTimer.Enabled = true;
            this.QuaiVatMoveTimer.Tick += new System.EventHandler(this.QuaiVatMoveTimer_Tick);
            // 
            // DanQuaiVatMoveTimer
            // 
            this.DanQuaiVatMoveTimer.Enabled = true;
            this.DanQuaiVatMoveTimer.Interval = 20;
            this.DanQuaiVatMoveTimer.Tick += new System.EventHandler(this.DanQuaiVatMoveTimer_Tick);
            // 
            // TuaDe
            // 
            this.TuaDe.AutoSize = true;
            this.TuaDe.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuaDe.ForeColor = System.Drawing.Color.Red;
            this.TuaDe.Location = new System.Drawing.Point(269, 191);
            this.TuaDe.Name = "TuaDe";
            this.TuaDe.Size = new System.Drawing.Size(122, 45);
            this.TuaDe.TabIndex = 1;
            this.TuaDe.Text = "label1";
            this.TuaDe.Visible = false;
            // 
            // btnDungTranDau
            // 
            this.btnDungTranDau.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDungTranDau.Location = new System.Drawing.Point(226, 31);
            this.btnDungTranDau.Name = "btnDungTranDau";
            this.btnDungTranDau.Size = new System.Drawing.Size(327, 95);
            this.btnDungTranDau.TabIndex = 2;
            this.btnDungTranDau.Text = " Trận Đấu Mới";
            this.btnDungTranDau.UseVisualStyleBackColor = true;
            this.btnDungTranDau.Visible = false;
            this.btnDungTranDau.Click += new System.EventHandler(this.btnDungTranDau_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(226, 298);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(329, 89);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Visible = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Điểm";
            // 
            // lblDiem
            // 
            this.lblDiem.AutoSize = true;
            this.lblDiem.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.Location = new System.Drawing.Point(108, 17);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(29, 32);
            this.lblDiem.TabIndex = 5;
            this.lblDiem.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(574, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cấp";
            // 
            // lblCap
            // 
            this.lblCap.AutoSize = true;
            this.lblCap.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCap.Location = new System.Drawing.Point(659, 17);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(29, 32);
            this.lblCap.TabIndex = 7;
            this.lblCap.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDungTranDau);
            this.Controls.Add(this.TuaDe);
            this.Controls.Add(this.NguoiChoi);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "Bắn quái vật";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.NguoiChoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer NgoiSao;
        private System.Windows.Forms.PictureBox NguoiChoi;
        private System.Windows.Forms.Timer TraiMoveTimer;
        private System.Windows.Forms.Timer PhaiMoveTimer;
        private System.Windows.Forms.Timer XuongMoveTimer;
        private System.Windows.Forms.Timer LenMoveTimer;
        private System.Windows.Forms.Timer DanMoveTimer;
        private System.Windows.Forms.Timer QuaiVatMoveTimer;
        private System.Windows.Forms.Timer DanQuaiVatMoveTimer;
        private System.Windows.Forms.Label TuaDe;
        private System.Windows.Forms.Button btnDungTranDau;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCap;
    }
}

