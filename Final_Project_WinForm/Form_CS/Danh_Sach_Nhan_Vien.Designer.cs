
namespace Final_Project_WinForm
{
    partial class Danh_Sach_Nhan_Vien
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
            System.Windows.Forms.Panel panel7;
            System.Windows.Forms.Panel panel4;
            this.tabCC = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ho_ten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Fix_SV = new System.Windows.Forms.Button();
            this.btn_Xoa_SV = new System.Windows.Forms.Button();
            this.btn_Them_SV = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel_action = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pannelHD = new System.Windows.Forms.Panel();
            this.txt_pc = new System.Windows.Forms.TextBox();
            this.label_pc = new System.Windows.Forms.Label();
            this.txt_lcb = new System.Windows.Forms.TextBox();
            this.label_lcb = new System.Windows.Forms.Label();
            this.txt_hsl = new System.Windows.Forms.TextBox();
            this.label_so_gio = new System.Windows.Forms.Label();
            this.label_hsl = new System.Windows.Forms.Label();
            this.txt_so_gio = new System.Windows.Forms.TextBox();
            this.label_tc1g = new System.Windows.Forms.Label();
            this.txt_tien_cong_1_gio = new System.Windows.Forms.TextBox();
            this.txt_chuc_vu = new System.Windows.Forms.TextBox();
            this.label_chuc_vu = new System.Windows.Forms.Label();
            this.txt_phong_ban = new System.Windows.Forms.TextBox();
            this.label_phong_ban = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nam_sinh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            panel7 = new System.Windows.Forms.Panel();
            panel4 = new System.Windows.Forms.Panel();
            panel7.SuspendLayout();
            this.tabCC.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            panel4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_action.SuspendLayout();
            this.pannelHD.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            panel7.Controls.Add(this.tabCC);
            panel7.Dock = System.Windows.Forms.DockStyle.Top;
            panel7.Location = new System.Drawing.Point(489, 100);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(657, 500);
            panel7.TabIndex = 120;
            // 
            // tabCC
            // 
            this.tabCC.Controls.Add(this.tabPage3);
            this.tabCC.Controls.Add(this.tabPage4);
            this.tabCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabCC.ItemSize = new System.Drawing.Size(71, 40);
            this.tabCC.Location = new System.Drawing.Point(0, 0);
            this.tabCC.Name = "tabCC";
            this.tabCC.SelectedIndex = 0;
            this.tabCC.Size = new System.Drawing.Size(657, 500);
            this.tabCC.TabIndex = 83;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tabPage3.ForeColor = System.Drawing.Color.Coral;
            this.tabPage3.Location = new System.Drawing.Point(4, 44);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(16, 3, 3, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(649, 452);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Nhân Viên Công Chức";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(643, 446);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 44);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(649, 452);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Nhân Viên Hợp Đồng";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(643, 446);
            this.listView2.TabIndex = 2;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // panel4
            // 
            panel4.Controls.Add(this.button2);
            panel4.Controls.Add(this.button1);
            panel4.Controls.Add(this.label10);
            panel4.Dock = System.Windows.Forms.DockStyle.Top;
            panel4.Location = new System.Drawing.Point(489, 52);
            panel4.Name = "panel4";
            panel4.Size = new System.Drawing.Size(657, 48);
            panel4.TabIndex = 118;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(472, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 43);
            this.button1.TabIndex = 102;
            this.button1.Text = "Làm Mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 26);
            this.label10.TabIndex = 82;
            this.label10.Text = "Danh sách nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(128, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 26);
            this.label8.TabIndex = 111;
            this.label8.Text = "SĐT:";
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(207, 156);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(252, 39);
            this.txt_sdt.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 26);
            this.label5.TabIndex = 106;
            this.label5.Text = "Họ và Tên:";
            // 
            // txt_ho_ten
            // 
            this.txt_ho_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ho_ten.Location = new System.Drawing.Point(207, 9);
            this.txt_ho_ten.Multiline = true;
            this.txt_ho_ten.Name = "txt_ho_ten";
            this.txt_ho_ten.Size = new System.Drawing.Size(252, 43);
            this.txt_ho_ten.TabIndex = 105;
            this.txt_ho_ten.TextChanged += new System.EventHandler(this.txt_ho_ten_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 26);
            this.label3.TabIndex = 102;
            this.label3.Text = "Mã Nhân Viên:";
            // 
            // btn_Fix_SV
            // 
            this.btn_Fix_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fix_SV.Location = new System.Drawing.Point(162, 10);
            this.btn_Fix_SV.Name = "btn_Fix_SV";
            this.btn_Fix_SV.Size = new System.Drawing.Size(129, 43);
            this.btn_Fix_SV.TabIndex = 101;
            this.btn_Fix_SV.Text = "Hiệu Chỉnh";
            this.btn_Fix_SV.UseVisualStyleBackColor = true;
            this.btn_Fix_SV.Click += new System.EventHandler(this.btn_Fix_SV_Click);
            // 
            // btn_Xoa_SV
            // 
            this.btn_Xoa_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_SV.Location = new System.Drawing.Point(38, 10);
            this.btn_Xoa_SV.Name = "btn_Xoa_SV";
            this.btn_Xoa_SV.Size = new System.Drawing.Size(75, 43);
            this.btn_Xoa_SV.TabIndex = 100;
            this.btn_Xoa_SV.Text = "Xóa";
            this.btn_Xoa_SV.UseVisualStyleBackColor = true;
            this.btn_Xoa_SV.Click += new System.EventHandler(this.btn_Xoa_SV_Click);
            // 
            // btn_Them_SV
            // 
            this.btn_Them_SV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_SV.Location = new System.Drawing.Point(336, 10);
            this.btn_Them_SV.Name = "btn_Them_SV";
            this.btn_Them_SV.Size = new System.Drawing.Size(75, 43);
            this.btn_Them_SV.TabIndex = 97;
            this.btn_Them_SV.Text = "Thêm";
            this.btn_Them_SV.UseVisualStyleBackColor = true;
            this.btn_Them_SV.Click += new System.EventHandler(this.btn_Them_SV_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel_action);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.pannelHD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 638);
            this.groupBox1.TabIndex = 116;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // panel_action
            // 
            this.panel_action.Controls.Add(this.btn_Xoa_SV);
            this.panel_action.Controls.Add(this.btn_Fix_SV);
            this.panel_action.Controls.Add(this.btn_Them_SV);
            this.panel_action.Location = new System.Drawing.Point(14, 581);
            this.panel_action.Name = "panel_action";
            this.panel_action.Size = new System.Drawing.Size(460, 56);
            this.panel_action.TabIndex = 118;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(253, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 28);
            this.comboBox1.TabIndex = 117;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pannelHD
            // 
            this.pannelHD.Controls.Add(this.txt_pc);
            this.pannelHD.Controls.Add(this.label_pc);
            this.pannelHD.Controls.Add(this.txt_lcb);
            this.pannelHD.Controls.Add(this.label_lcb);
            this.pannelHD.Controls.Add(this.txt_hsl);
            this.pannelHD.Controls.Add(this.label_so_gio);
            this.pannelHD.Controls.Add(this.label_hsl);
            this.pannelHD.Controls.Add(this.txt_so_gio);
            this.pannelHD.Controls.Add(this.label_tc1g);
            this.pannelHD.Controls.Add(this.txt_tien_cong_1_gio);
            this.pannelHD.Controls.Add(this.txt_chuc_vu);
            this.pannelHD.Controls.Add(this.label_chuc_vu);
            this.pannelHD.Controls.Add(this.txt_phong_ban);
            this.pannelHD.Controls.Add(this.label_phong_ban);
            this.pannelHD.Controls.Add(this.txt_email);
            this.pannelHD.Controls.Add(this.label7);
            this.pannelHD.Controls.Add(this.label4);
            this.pannelHD.Controls.Add(this.txt_nam_sinh);
            this.pannelHD.Controls.Add(this.txt_ho_ten);
            this.pannelHD.Controls.Add(this.label5);
            this.pannelHD.Controls.Add(this.txt_sdt);
            this.pannelHD.Controls.Add(this.label8);
            this.pannelHD.Location = new System.Drawing.Point(12, 111);
            this.pannelHD.Name = "pannelHD";
            this.pannelHD.Size = new System.Drawing.Size(462, 464);
            this.pannelHD.TabIndex = 116;
            // 
            // txt_pc
            // 
            this.txt_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pc.Location = new System.Drawing.Point(207, 368);
            this.txt_pc.Multiline = true;
            this.txt_pc.Name = "txt_pc";
            this.txt_pc.Size = new System.Drawing.Size(252, 39);
            this.txt_pc.TabIndex = 125;
            // 
            // label_pc
            // 
            this.label_pc.AutoSize = true;
            this.label_pc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_pc.Location = new System.Drawing.Point(83, 376);
            this.label_pc.Name = "label_pc";
            this.label_pc.Size = new System.Drawing.Size(100, 31);
            this.label_pc.TabIndex = 126;
            this.label_pc.Text = "Phụ Cấp:";
            this.label_pc.UseCompatibleTextRendering = true;
            // 
            // txt_lcb
            // 
            this.txt_lcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lcb.Location = new System.Drawing.Point(210, 318);
            this.txt_lcb.Multiline = true;
            this.txt_lcb.Name = "txt_lcb";
            this.txt_lcb.Size = new System.Drawing.Size(249, 39);
            this.txt_lcb.TabIndex = 127;
            // 
            // label_lcb
            // 
            this.label_lcb.AutoSize = true;
            this.label_lcb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lcb.Location = new System.Drawing.Point(30, 326);
            this.label_lcb.Name = "label_lcb";
            this.label_lcb.Size = new System.Drawing.Size(156, 31);
            this.label_lcb.TabIndex = 128;
            this.label_lcb.Text = "Lương Cơ Bản:";
            this.label_lcb.UseCompatibleTextRendering = true;
            // 
            // txt_hsl
            // 
            this.txt_hsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hsl.Location = new System.Drawing.Point(207, 419);
            this.txt_hsl.Multiline = true;
            this.txt_hsl.Name = "txt_hsl";
            this.txt_hsl.Size = new System.Drawing.Size(252, 39);
            this.txt_hsl.TabIndex = 130;
            // 
            // label_so_gio
            // 
            this.label_so_gio.AutoSize = true;
            this.label_so_gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_so_gio.Location = new System.Drawing.Point(14, 326);
            this.label_so_gio.Name = "label_so_gio";
            this.label_so_gio.Size = new System.Drawing.Size(181, 31);
            this.label_so_gio.TabIndex = 128;
            this.label_so_gio.Text = "Số Giờ Làm Việc:";
            this.label_so_gio.UseCompatibleTextRendering = true;
            // 
            // label_hsl
            // 
            this.label_hsl.AutoSize = true;
            this.label_hsl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hsl.Location = new System.Drawing.Point(40, 427);
            this.label_hsl.Name = "label_hsl";
            this.label_hsl.Size = new System.Drawing.Size(144, 31);
            this.label_hsl.TabIndex = 129;
            this.label_hsl.Text = "Hệ Số Lương:";
            this.label_hsl.UseCompatibleTextRendering = true;
            // 
            // txt_so_gio
            // 
            this.txt_so_gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so_gio.Location = new System.Drawing.Point(210, 318);
            this.txt_so_gio.Multiline = true;
            this.txt_so_gio.Name = "txt_so_gio";
            this.txt_so_gio.Size = new System.Drawing.Size(249, 39);
            this.txt_so_gio.TabIndex = 127;
            // 
            // label_tc1g
            // 
            this.label_tc1g.AutoSize = true;
            this.label_tc1g.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tc1g.Location = new System.Drawing.Point(14, 376);
            this.label_tc1g.Name = "label_tc1g";
            this.label_tc1g.Size = new System.Drawing.Size(176, 31);
            this.label_tc1g.TabIndex = 126;
            this.label_tc1g.Text = "Tiền Công 1 Giờ:";
            this.label_tc1g.UseCompatibleTextRendering = true;
            // 
            // txt_tien_cong_1_gio
            // 
            this.txt_tien_cong_1_gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tien_cong_1_gio.Location = new System.Drawing.Point(207, 368);
            this.txt_tien_cong_1_gio.Multiline = true;
            this.txt_tien_cong_1_gio.Name = "txt_tien_cong_1_gio";
            this.txt_tien_cong_1_gio.Size = new System.Drawing.Size(252, 39);
            this.txt_tien_cong_1_gio.TabIndex = 125;
            // 
            // txt_chuc_vu
            // 
            this.txt_chuc_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_chuc_vu.Location = new System.Drawing.Point(207, 261);
            this.txt_chuc_vu.Multiline = true;
            this.txt_chuc_vu.Name = "txt_chuc_vu";
            this.txt_chuc_vu.Size = new System.Drawing.Size(252, 39);
            this.txt_chuc_vu.TabIndex = 122;
            // 
            // label_chuc_vu
            // 
            this.label_chuc_vu.AutoSize = true;
            this.label_chuc_vu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chuc_vu.Location = new System.Drawing.Point(90, 269);
            this.label_chuc_vu.Name = "label_chuc_vu";
            this.label_chuc_vu.Size = new System.Drawing.Size(99, 31);
            this.label_chuc_vu.TabIndex = 121;
            this.label_chuc_vu.Text = "Chức Vụ:";
            this.label_chuc_vu.UseCompatibleTextRendering = true;
            // 
            // txt_phong_ban
            // 
            this.txt_phong_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_phong_ban.Location = new System.Drawing.Point(207, 211);
            this.txt_phong_ban.Multiline = true;
            this.txt_phong_ban.Name = "txt_phong_ban";
            this.txt_phong_ban.Size = new System.Drawing.Size(252, 39);
            this.txt_phong_ban.TabIndex = 120;
            // 
            // label_phong_ban
            // 
            this.label_phong_ban.AutoSize = true;
            this.label_phong_ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_phong_ban.Location = new System.Drawing.Point(69, 224);
            this.label_phong_ban.Name = "label_phong_ban";
            this.label_phong_ban.Size = new System.Drawing.Size(126, 26);
            this.label_phong_ban.TabIndex = 119;
            this.label_phong_ban.Text = "Phòng Ban:";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(207, 111);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(252, 39);
            this.txt_email.TabIndex = 118;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(115, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 26);
            this.label7.TabIndex = 117;
            this.label7.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(78, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 26);
            this.label4.TabIndex = 116;
            this.label4.Text = "Năm sinh:";
            // 
            // txt_nam_sinh
            // 
            this.txt_nam_sinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nam_sinh.Location = new System.Drawing.Point(207, 58);
            this.txt_nam_sinh.Multiline = true;
            this.txt_nam_sinh.Name = "txt_nam_sinh";
            this.txt_nam_sinh.Size = new System.Drawing.Size(252, 43);
            this.txt_nam_sinh.TabIndex = 115;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 82;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 52);
            this.panel1.TabIndex = 115;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(315, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 43);
            this.button2.TabIndex = 103;
            this.button2.Text = "Bảng Lương";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Danh_Sach_Nhan_Vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 690);
            this.Controls.Add(panel7);
            this.Controls.Add(panel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Danh_Sach_Nhan_Vien";
            this.RightToLeftLayout = true;
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.Nhap_SV_Load);
            panel7.ResumeLayout(false);
            this.tabCC.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_action.ResumeLayout(false);
            this.pannelHD.ResumeLayout(false);
            this.pannelHD.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ho_ten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Fix_SV;
        private System.Windows.Forms.Button btn_Xoa_SV;
        private System.Windows.Forms.Button btn_Them_SV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pannelHD;
        private System.Windows.Forms.TextBox txt_nam_sinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabCC;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_chuc_vu;
        private System.Windows.Forms.Label label_chuc_vu;
        private System.Windows.Forms.TextBox txt_phong_ban;
        private System.Windows.Forms.Label label_phong_ban;
        private System.Windows.Forms.Label label_tc1g;
        private System.Windows.Forms.TextBox txt_tien_cong_1_gio;
        private System.Windows.Forms.Label label_so_gio;
        private System.Windows.Forms.TextBox txt_so_gio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_action;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_lcb;
        private System.Windows.Forms.TextBox txt_lcb;
        private System.Windows.Forms.Label label_pc;
        private System.Windows.Forms.TextBox txt_pc;
        private System.Windows.Forms.TextBox txt_hsl;
        private System.Windows.Forms.Label label_hsl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}