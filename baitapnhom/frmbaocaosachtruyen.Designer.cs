namespace baitapnhom
{
    partial class frmbaocaosachtruyen
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.masach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maloaisach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malinhvuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matacgia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manhaxuatban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mangonngu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sotrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongiathue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghichu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách các đầu sách đang được thuê ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Kiểm tra";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masach,
            this.tensach,
            this.maloaisach,
            this.malinhvuc,
            this.matacgia,
            this.manhaxuatban,
            this.mangonngu,
            this.sotrang,
            this.dongiathue,
            this.soluong,
            this.anh,
            this.ghichu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 189);
            this.dataGridView1.TabIndex = 27;
            // 
            // masach
            // 
            this.masach.DataPropertyName = "masach";
            this.masach.HeaderText = "Mã sách";
            this.masach.Name = "masach";
            // 
            // tensach
            // 
            this.tensach.DataPropertyName = "tensach";
            this.tensach.HeaderText = "Tên sách";
            this.tensach.Name = "tensach";
            // 
            // maloaisach
            // 
            this.maloaisach.DataPropertyName = "maloaisach";
            this.maloaisach.HeaderText = "Mã loại sách";
            this.maloaisach.Name = "maloaisach";
            // 
            // malinhvuc
            // 
            this.malinhvuc.DataPropertyName = "malinhvuc";
            this.malinhvuc.HeaderText = "Mã lĩnh vực";
            this.malinhvuc.Name = "malinhvuc";
            // 
            // matacgia
            // 
            this.matacgia.DataPropertyName = "matacgia";
            this.matacgia.HeaderText = "Mã tác giả";
            this.matacgia.Name = "matacgia";
            // 
            // manhaxuatban
            // 
            this.manhaxuatban.DataPropertyName = "manhaxuatban";
            this.manhaxuatban.HeaderText = "Mã NXB";
            this.manhaxuatban.Name = "manhaxuatban";
            // 
            // mangonngu
            // 
            this.mangonngu.DataPropertyName = "mangonngu";
            this.mangonngu.HeaderText = "Mã ngôn ngữ";
            this.mangonngu.Name = "mangonngu";
            // 
            // sotrang
            // 
            this.sotrang.DataPropertyName = "sotrang";
            this.sotrang.HeaderText = "Số trang";
            this.sotrang.Name = "sotrang";
            // 
            // dongiathue
            // 
            this.dongiathue.DataPropertyName = "dongiathue";
            this.dongiathue.HeaderText = "Đơn giá thuê";
            this.dongiathue.Name = "dongiathue";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // anh
            // 
            this.anh.DataPropertyName = "anh";
            this.anh.HeaderText = "Ảnh";
            this.anh.Name = "anh";
            // 
            // ghichu
            // 
            this.ghichu.DataPropertyName = "ghichu";
            this.ghichu.HeaderText = "Ghi chú";
            this.ghichu.Name = "ghichu";
            // 
            // frmbaocaosachtruyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 282);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmbaocaosachtruyen";
            this.Text = "frmbaocaosachtruyen";
            this.Load += new System.EventHandler(this.frmbaocaosachtruyen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn masach;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensach;
        private System.Windows.Forms.DataGridViewTextBoxColumn maloaisach;
        private System.Windows.Forms.DataGridViewTextBoxColumn malinhvuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn matacgia;
        private System.Windows.Forms.DataGridViewTextBoxColumn manhaxuatban;
        private System.Windows.Forms.DataGridViewTextBoxColumn mangonngu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sotrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongiathue;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn anh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghichu;
    }
}