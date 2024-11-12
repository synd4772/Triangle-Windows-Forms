using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle.Forms.XmlForm
{
    public partial class XmlTabelForm : Form
    {
        private DataSet DataSet { get; set; }
        private DataGridView DataGridView { get; set; }
        
        public XmlTabelForm()
        {
            this.ClientSize = new Size(500, 200);
            this.DataSet = new DataSet();
            this.DataGridView = new DataGridView();
            this.Controls.Add(this.DataGridView);
        }
        public XmlTabelForm(string path)
        {
            this.ClientSize = new Size(500, 200);
            this.DataSet = new DataSet();
            this.DataSet.ReadXml(path);

            this.DataGridView = new DataGridView();
            this.DataGridView.DataSource = this.DataSet.Tables[0];
            this.Controls.Add(this.DataGridView);
        }

        private void DrawXmlTable()
        {
            
        }
        
    }
}
