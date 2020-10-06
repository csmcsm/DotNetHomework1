using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order1
{
    public partial class Form2 : Form
    {
        public string name{ get;set;}
        public string id { get; set; }
        public string item { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            nameText.DataBindings.Add("Text", this,"name");
            idText.DataBindings.Add("Text", this,"id");
            itemNameText.DataBindings.Add("Text", this, "item");
        }

        private void click_Click(object sender, EventArgs e)
        {
          
            this.Close();
        }

    
    }
}
