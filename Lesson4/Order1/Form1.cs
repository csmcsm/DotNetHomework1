using lesson3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Order1
{
    public partial class Form1 : Form
    {
        public int i = 0;
        public OrderService os;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            os = new OrderService();
            os.orders = new List<Order>();
            details.Visible = false;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f2 = new Form2();
                f2.ShowDialog();
                Client c = new Client(f2.name, int.Parse(f2.id));
                string[] items = f2.item.Split(',');
                Item[] its = Maker.makeItem(items);
                OrderDetails ods = new OrderDetails(its, c);
                Order o = new Order(ods, i);

                os.orders.Add(o);
                details.Visible = true;
                details.Text = "创建成功，订单ID： " + i;
                i++;
            }
            catch { 
            
            }

        }

      
      

        private void Select_Click(object sender, EventArgs e)
        {
            OrderDetailText.Text=
            os.select(int.Parse(idText.Text));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
            os.deleteOrder(int.Parse(idText.Text));
        }

        private void update_Click(object sender, EventArgs e)
            
        {
            Client c = new Client("Women", 11);
            Item[] its = { Maker.makeItem3() };
            OrderDetails ods = new OrderDetails(its, c);
            os.updateOrder(int.Parse(idText.Text),ods);
        }

        private void export_Click(object sender, EventArgs e)
        {
            os.Export();
        }

        private void import_Click(object sender, EventArgs e)
        {
            os.Import();
        }

       
    }
}
