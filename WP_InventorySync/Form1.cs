using CsvHelper;
using CsvHelper.Configuration;
using WP_InventorySync.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace WP_InventorySync
{
    public partial class WP_Inventory_Sync : Form
    {
        public WP_Inventory_Sync()
        {
            InitializeComponent();
            timer1.Start();
        }

        private List<CsvModel> data = null;
        private DataTable dtProducts = new DataTable();
        private string filterField = "CCN";
        private string search_str = "";

        private void WP_Inventory_Sync_Load(object sender, EventArgs e)
        {
            ccn_opt.Checked = true;

            this.data = new List<CsvModel>();
            dtProducts.Columns.Add("CCN");
            dtProducts.Columns.Add("Part Number");
            dtProducts.Columns.Add("Catalog Number");
            dtProducts.Columns.Add("Desc");
            dtProducts.Columns.Add("Material");
            dtProducts.Columns.Add("List Price");
            dtProducts.Columns.Add("Lead Time");
            dtProducts.Columns.Add("Product Code");
            dtProducts.Columns.Add("Business Unit");

            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                PrepareHeaderForMatch = header_args => header_args.Header.ToLower(),
            };
            try
            {
                using (var reader = new StreamReader("PricingDisplay.csv"))
                using (var csv = new CsvReader(reader, config))
                {
                    data = csv.GetRecords<CsvModel>().ToList();
                }

                foreach (var item in data)
                {
                    var y = item;
                    dtProducts.Rows.Add(item.ccn, item.part_number, "", item.description, item.material_code, "", "", "", "");
                }
                result_dgv.DataSource = dtProducts;
            }
            catch (Exception ex)
            {
                string msg = ex.GetType().FullName;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello, world!", "My App");
            if (ccn_opt.Checked)
            {
                search_str = ccn_txt.Text;
            } 
            else if (part_no_opt.Checked)
            {
                search_str = part_num_txt.Text;
            }
            else if (cat_no_opt.Checked)
            {
                search_str = cat_num_txt.Text;
            }

            dtProducts.DefaultView.RowFilter = string.Format("[{0}] LIKE '%{1}%'", filterField, search_str);
        }

        private void ccn_opt_CheckedChanged(object sender, EventArgs e)
        {
            if (ccn_opt.Checked)
            {
                filterField = "CCN";
            }
        }

        private void part_no_opt_CheckedChanged(object sender, EventArgs e)
        {
            if (part_no_opt.Checked)
            {
                filterField = "Part Number";
            }
        }

        private void cat_no_opt_CheckedChanged(object sender, EventArgs e)
        {
            if (cat_no_opt.Checked)
            {
                filterField = "Catalog Number";
            }
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
    }
}
