using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WP_InventorySync.Models
{
    class CsvModel
    {
        [Name("Thelco Part Number")]
        public string thelco_part_number { get; set; }

        [Name("Part Number")]
        public string part_number { get; set; }

        [Name("Flowserve 1.0")]
        public string flowserve10 { get; set; }

        [Name("Flowserve .91")]
        public string flowserve91 { get; set; }

        [Name("Flowserve .70")]
        public string flowserve70 { get; set; }

        [Name("Thelco 1.0")]
        public string thelco10 { get; set; }

        [Name("Thelco .91")]
        public string thelco91 { get; set; }

        [Name("Thelco .70")]
        public string thelco70 { get; set; }

        [Name("Vendor Cost")]
        public string vendor_cost { get; set; }

        [Name("Material Code")]
        public string material_code { get; set; }


        [Name("Qty In Stock")]
        public string qty_in_stock { get; set; }


        [Name("Notes")]
        public string notes { get; set; }

        [Name("Dresser Description")]
        public string dresser_description { get; set; }

        [Name("CCN")]
        public string ccn { get; set; }

        [Name("Description")]
        public string description { get; set; }
    }
}
