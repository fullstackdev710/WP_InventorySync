
namespace WP_InventorySync
{
    partial class WP_Inventory_Sync
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
            this.version_lbl = new System.Windows.Forms.Label();
            this.time_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.ccn_lbl = new System.Windows.Forms.Label();
            this.part_number_lbl = new System.Windows.Forms.Label();
            this.cat_num_lbl = new System.Windows.Forms.Label();
            this.desc_lbl = new System.Windows.Forms.Label();
            this.material_lbl = new System.Windows.Forms.Label();
            this.product_code_lbl = new System.Windows.Forms.Label();
            this.list_price_lbl = new System.Windows.Forms.Label();
            this.biz_unit_lbl = new System.Windows.Forms.Label();
            this.load_time_lbl = new System.Windows.Forms.Label();
            this.ccn_txt = new System.Windows.Forms.TextBox();
            this.part_num_txt = new System.Windows.Forms.TextBox();
            this.cat_num_txt = new System.Windows.Forms.TextBox();
            this.desc_txt = new System.Windows.Forms.TextBox();
            this.material_txt = new System.Windows.Forms.TextBox();
            this.biz_unit_txt = new System.Windows.Forms.TextBox();
            this.list_price_txt = new System.Windows.Forms.TextBox();
            this.product_cde_txt = new System.Windows.Forms.TextBox();
            this.load_time_txt = new System.Windows.Forms.TextBox();
            this.search_by_lbl = new System.Windows.Forms.Label();
            this.ccn_opt = new System.Windows.Forms.RadioButton();
            this.part_no_opt = new System.Windows.Forms.RadioButton();
            this.cat_no_opt = new System.Windows.Forms.RadioButton();
            this.search_btn = new System.Windows.Forms.Button();
            this.quit_btn = new System.Windows.Forms.Button();
            this.result_dgv = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.search_opt_group = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.result_dgv)).BeginInit();
            this.search_opt_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.BackColor = System.Drawing.Color.Navy;
            this.version_lbl.ForeColor = System.Drawing.Color.White;
            this.version_lbl.Location = new System.Drawing.Point(12, 9);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(60, 13);
            this.version_lbl.TabIndex = 0;
            this.version_lbl.Text = "Version 2.0";
            // 
            // time_lbl
            // 
            this.time_lbl.AutoSize = true;
            this.time_lbl.BackColor = System.Drawing.Color.Navy;
            this.time_lbl.ForeColor = System.Drawing.Color.White;
            this.time_lbl.Location = new System.Drawing.Point(779, 9);
            this.time_lbl.Name = "time_lbl";
            this.time_lbl.Size = new System.Drawing.Size(68, 13);
            this.time_lbl.TabIndex = 0;
            this.time_lbl.Text = "00:00:00 AM";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.BackColor = System.Drawing.Color.Navy;
            this.title_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.ForeColor = System.Drawing.Color.White;
            this.title_lbl.Location = new System.Drawing.Point(308, 9);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(200, 24);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Parts Pricing Display";
            // 
            // ccn_lbl
            // 
            this.ccn_lbl.AutoSize = true;
            this.ccn_lbl.BackColor = System.Drawing.Color.Navy;
            this.ccn_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccn_lbl.ForeColor = System.Drawing.Color.White;
            this.ccn_lbl.Location = new System.Drawing.Point(12, 40);
            this.ccn_lbl.Name = "ccn_lbl";
            this.ccn_lbl.Size = new System.Drawing.Size(49, 18);
            this.ccn_lbl.TabIndex = 0;
            this.ccn_lbl.Text = "CCN:";
            // 
            // part_number_lbl
            // 
            this.part_number_lbl.AutoSize = true;
            this.part_number_lbl.BackColor = System.Drawing.Color.Navy;
            this.part_number_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_number_lbl.ForeColor = System.Drawing.Color.White;
            this.part_number_lbl.Location = new System.Drawing.Point(300, 40);
            this.part_number_lbl.Name = "part_number_lbl";
            this.part_number_lbl.Size = new System.Drawing.Size(108, 18);
            this.part_number_lbl.TabIndex = 0;
            this.part_number_lbl.Text = "Part Number:";
            // 
            // cat_num_lbl
            // 
            this.cat_num_lbl.AutoSize = true;
            this.cat_num_lbl.BackColor = System.Drawing.Color.Navy;
            this.cat_num_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_num_lbl.ForeColor = System.Drawing.Color.White;
            this.cat_num_lbl.Location = new System.Drawing.Point(597, 40);
            this.cat_num_lbl.Name = "cat_num_lbl";
            this.cat_num_lbl.Size = new System.Drawing.Size(135, 18);
            this.cat_num_lbl.TabIndex = 0;
            this.cat_num_lbl.Text = "Catalog Number:";
            // 
            // desc_lbl
            // 
            this.desc_lbl.AutoSize = true;
            this.desc_lbl.BackColor = System.Drawing.Color.Navy;
            this.desc_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_lbl.ForeColor = System.Drawing.Color.White;
            this.desc_lbl.Location = new System.Drawing.Point(12, 87);
            this.desc_lbl.Name = "desc_lbl";
            this.desc_lbl.Size = new System.Drawing.Size(52, 18);
            this.desc_lbl.TabIndex = 0;
            this.desc_lbl.Text = "Desc:";
            // 
            // material_lbl
            // 
            this.material_lbl.AutoSize = true;
            this.material_lbl.BackColor = System.Drawing.Color.Navy;
            this.material_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material_lbl.ForeColor = System.Drawing.Color.White;
            this.material_lbl.Location = new System.Drawing.Point(597, 87);
            this.material_lbl.Name = "material_lbl";
            this.material_lbl.Size = new System.Drawing.Size(73, 18);
            this.material_lbl.TabIndex = 0;
            this.material_lbl.Text = "Material:";
            // 
            // product_code_lbl
            // 
            this.product_code_lbl.AutoSize = true;
            this.product_code_lbl.BackColor = System.Drawing.Color.Navy;
            this.product_code_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_code_lbl.ForeColor = System.Drawing.Color.White;
            this.product_code_lbl.Location = new System.Drawing.Point(393, 134);
            this.product_code_lbl.Name = "product_code_lbl";
            this.product_code_lbl.Size = new System.Drawing.Size(123, 18);
            this.product_code_lbl.TabIndex = 0;
            this.product_code_lbl.Text = "Product Coder:";
            // 
            // list_price_lbl
            // 
            this.list_price_lbl.AutoSize = true;
            this.list_price_lbl.BackColor = System.Drawing.Color.Navy;
            this.list_price_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_price_lbl.ForeColor = System.Drawing.Color.White;
            this.list_price_lbl.Location = new System.Drawing.Point(12, 134);
            this.list_price_lbl.Name = "list_price_lbl";
            this.list_price_lbl.Size = new System.Drawing.Size(84, 18);
            this.list_price_lbl.TabIndex = 0;
            this.list_price_lbl.Text = "List Price:";
            // 
            // biz_unit_lbl
            // 
            this.biz_unit_lbl.AutoSize = true;
            this.biz_unit_lbl.BackColor = System.Drawing.Color.Navy;
            this.biz_unit_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biz_unit_lbl.ForeColor = System.Drawing.Color.White;
            this.biz_unit_lbl.Location = new System.Drawing.Point(597, 134);
            this.biz_unit_lbl.Name = "biz_unit_lbl";
            this.biz_unit_lbl.Size = new System.Drawing.Size(117, 18);
            this.biz_unit_lbl.TabIndex = 0;
            this.biz_unit_lbl.Text = "Business Unit:";
            // 
            // load_time_lbl
            // 
            this.load_time_lbl.AutoSize = true;
            this.load_time_lbl.BackColor = System.Drawing.Color.Navy;
            this.load_time_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_time_lbl.ForeColor = System.Drawing.Color.White;
            this.load_time_lbl.Location = new System.Drawing.Point(211, 134);
            this.load_time_lbl.Name = "load_time_lbl";
            this.load_time_lbl.Size = new System.Drawing.Size(92, 18);
            this.load_time_lbl.TabIndex = 0;
            this.load_time_lbl.Text = "Load Time:";
            // 
            // ccn_txt
            // 
            this.ccn_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccn_txt.Location = new System.Drawing.Point(15, 62);
            this.ccn_txt.Name = "ccn_txt";
            this.ccn_txt.Size = new System.Drawing.Size(282, 24);
            this.ccn_txt.TabIndex = 1;
            // 
            // part_num_txt
            // 
            this.part_num_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_num_txt.Location = new System.Drawing.Point(303, 61);
            this.part_num_txt.Name = "part_num_txt";
            this.part_num_txt.Size = new System.Drawing.Size(291, 24);
            this.part_num_txt.TabIndex = 1;
            // 
            // cat_num_txt
            // 
            this.cat_num_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_num_txt.Location = new System.Drawing.Point(600, 61);
            this.cat_num_txt.Name = "cat_num_txt";
            this.cat_num_txt.Size = new System.Drawing.Size(247, 24);
            this.cat_num_txt.TabIndex = 1;
            // 
            // desc_txt
            // 
            this.desc_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desc_txt.Location = new System.Drawing.Point(15, 108);
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.Size = new System.Drawing.Size(579, 24);
            this.desc_txt.TabIndex = 1;
            // 
            // material_txt
            // 
            this.material_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.material_txt.Location = new System.Drawing.Point(600, 108);
            this.material_txt.Name = "material_txt";
            this.material_txt.Size = new System.Drawing.Size(247, 24);
            this.material_txt.TabIndex = 1;
            // 
            // biz_unit_txt
            // 
            this.biz_unit_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biz_unit_txt.Location = new System.Drawing.Point(600, 155);
            this.biz_unit_txt.Name = "biz_unit_txt";
            this.biz_unit_txt.Size = new System.Drawing.Size(247, 24);
            this.biz_unit_txt.TabIndex = 1;
            // 
            // list_price_txt
            // 
            this.list_price_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_price_txt.Location = new System.Drawing.Point(12, 155);
            this.list_price_txt.Name = "list_price_txt";
            this.list_price_txt.Size = new System.Drawing.Size(196, 24);
            this.list_price_txt.TabIndex = 1;
            // 
            // product_cde_txt
            // 
            this.product_cde_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product_cde_txt.Location = new System.Drawing.Point(396, 155);
            this.product_cde_txt.Name = "product_cde_txt";
            this.product_cde_txt.Size = new System.Drawing.Size(198, 24);
            this.product_cde_txt.TabIndex = 1;
            // 
            // load_time_txt
            // 
            this.load_time_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_time_txt.Location = new System.Drawing.Point(214, 155);
            this.load_time_txt.Name = "load_time_txt";
            this.load_time_txt.Size = new System.Drawing.Size(176, 24);
            this.load_time_txt.TabIndex = 1;
            // 
            // search_by_lbl
            // 
            this.search_by_lbl.AutoSize = true;
            this.search_by_lbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.search_by_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_by_lbl.ForeColor = System.Drawing.Color.White;
            this.search_by_lbl.Location = new System.Drawing.Point(9, 200);
            this.search_by_lbl.Name = "search_by_lbl";
            this.search_by_lbl.Size = new System.Drawing.Size(90, 18);
            this.search_by_lbl.TabIndex = 0;
            this.search_by_lbl.Text = "Search By:";
            // 
            // ccn_opt
            // 
            this.ccn_opt.AutoSize = true;
            this.ccn_opt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ccn_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccn_opt.ForeColor = System.Drawing.Color.White;
            this.ccn_opt.Location = new System.Drawing.Point(15, 15);
            this.ccn_opt.Name = "ccn_opt";
            this.ccn_opt.Size = new System.Drawing.Size(62, 22);
            this.ccn_opt.TabIndex = 2;
            this.ccn_opt.TabStop = true;
            this.ccn_opt.Text = "CCN";
            this.ccn_opt.UseVisualStyleBackColor = true;
            this.ccn_opt.CheckedChanged += new System.EventHandler(this.ccn_opt_CheckedChanged);
            // 
            // part_no_opt
            // 
            this.part_no_opt.AutoSize = true;
            this.part_no_opt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.part_no_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.part_no_opt.ForeColor = System.Drawing.Color.White;
            this.part_no_opt.Location = new System.Drawing.Point(15, 37);
            this.part_no_opt.Name = "part_no_opt";
            this.part_no_opt.Size = new System.Drawing.Size(89, 22);
            this.part_no_opt.TabIndex = 2;
            this.part_no_opt.TabStop = true;
            this.part_no_opt.Text = "Part No.";
            this.part_no_opt.UseVisualStyleBackColor = true;
            this.part_no_opt.CheckedChanged += new System.EventHandler(this.part_no_opt_CheckedChanged);
            // 
            // cat_no_opt
            // 
            this.cat_no_opt.AutoSize = true;
            this.cat_no_opt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cat_no_opt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_no_opt.ForeColor = System.Drawing.Color.White;
            this.cat_no_opt.Location = new System.Drawing.Point(15, 63);
            this.cat_no_opt.Name = "cat_no_opt";
            this.cat_no_opt.Size = new System.Drawing.Size(116, 22);
            this.cat_no_opt.TabIndex = 2;
            this.cat_no_opt.TabStop = true;
            this.cat_no_opt.Text = "Catalog No.";
            this.cat_no_opt.UseVisualStyleBackColor = true;
            this.cat_no_opt.CheckedChanged += new System.EventHandler(this.cat_no_opt_CheckedChanged);
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(12, 248);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(97, 39);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "&Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // quit_btn
            // 
            this.quit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.quit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quit_btn.Location = new System.Drawing.Point(750, 248);
            this.quit_btn.Name = "quit_btn";
            this.quit_btn.Size = new System.Drawing.Size(97, 39);
            this.quit_btn.TabIndex = 3;
            this.quit_btn.Text = "&Quit";
            this.quit_btn.UseVisualStyleBackColor = true;
            this.quit_btn.Click += new System.EventHandler(this.quit_btn_Click);
            // 
            // result_dgv
            // 
            this.result_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.result_dgv.Location = new System.Drawing.Point(15, 293);
            this.result_dgv.Name = "result_dgv";
            this.result_dgv.Size = new System.Drawing.Size(832, 358);
            this.result_dgv.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // search_opt_group
            // 
            this.search_opt_group.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(120)))), ((int)(((byte)(214)))));
            this.search_opt_group.Controls.Add(this.part_no_opt);
            this.search_opt_group.Controls.Add(this.ccn_opt);
            this.search_opt_group.Controls.Add(this.cat_no_opt);
            this.search_opt_group.Location = new System.Drawing.Point(115, 185);
            this.search_opt_group.Name = "search_opt_group";
            this.search_opt_group.Size = new System.Drawing.Size(134, 102);
            this.search_opt_group.TabIndex = 5;
            this.search_opt_group.TabStop = false;
            // 
            // WP_Inventory_Sync
            // 
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(859, 659);
            this.Controls.Add(this.search_opt_group);
            this.Controls.Add(this.result_dgv);
            this.Controls.Add(this.quit_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.product_cde_txt);
            this.Controls.Add(this.biz_unit_txt);
            this.Controls.Add(this.material_txt);
            this.Controls.Add(this.cat_num_txt);
            this.Controls.Add(this.part_num_txt);
            this.Controls.Add(this.load_time_txt);
            this.Controls.Add(this.list_price_txt);
            this.Controls.Add(this.desc_txt);
            this.Controls.Add(this.ccn_txt);
            this.Controls.Add(this.time_lbl);
            this.Controls.Add(this.title_lbl);
            this.Controls.Add(this.biz_unit_lbl);
            this.Controls.Add(this.material_lbl);
            this.Controls.Add(this.search_by_lbl);
            this.Controls.Add(this.list_price_lbl);
            this.Controls.Add(this.cat_num_lbl);
            this.Controls.Add(this.load_time_lbl);
            this.Controls.Add(this.product_code_lbl);
            this.Controls.Add(this.desc_lbl);
            this.Controls.Add(this.part_number_lbl);
            this.Controls.Add(this.ccn_lbl);
            this.Controls.Add(this.version_lbl);
            this.Name = "WP_Inventory_Sync";
            this.Text = "Inventory Sync";
            this.Load += new System.EventHandler(this.WP_Inventory_Sync_Load);
            ((System.ComponentModel.ISupportInitialize)(this.result_dgv)).EndInit();
            this.search_opt_group.ResumeLayout(false);
            this.search_opt_group.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.Label time_lbl;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Label ccn_lbl;
        private System.Windows.Forms.Label part_number_lbl;
        private System.Windows.Forms.Label cat_num_lbl;
        private System.Windows.Forms.Label desc_lbl;
        private System.Windows.Forms.Label material_lbl;
        private System.Windows.Forms.Label product_code_lbl;
        private System.Windows.Forms.Label list_price_lbl;
        private System.Windows.Forms.Label biz_unit_lbl;
        private System.Windows.Forms.Label load_time_lbl;
        private System.Windows.Forms.TextBox ccn_txt;
        private System.Windows.Forms.TextBox part_num_txt;
        private System.Windows.Forms.TextBox cat_num_txt;
        private System.Windows.Forms.TextBox desc_txt;
        private System.Windows.Forms.TextBox material_txt;
        private System.Windows.Forms.TextBox biz_unit_txt;
        private System.Windows.Forms.TextBox list_price_txt;
        private System.Windows.Forms.TextBox product_cde_txt;
        private System.Windows.Forms.TextBox load_time_txt;
        private System.Windows.Forms.Label search_by_lbl;
        private System.Windows.Forms.RadioButton ccn_opt;
        private System.Windows.Forms.RadioButton part_no_opt;
        private System.Windows.Forms.RadioButton cat_no_opt;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button quit_btn;
        private System.Windows.Forms.DataGridView result_dgv;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox search_opt_group;
    }
}

