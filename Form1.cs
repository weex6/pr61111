using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMakeOrder_Click(object sender, EventArgs e)
        {
            if (domType.SelectedIndex < 0 || domSize.SelectedIndex < 0)
                MessageBox.Show("Укажите тип вещи и размер");
            else
            {
                Order order = new Order();
                order.Launch(domType.SelectedItem.ToString(), domSize.SelectedItem.ToString());
                order.OrderStatus(order);
            }
        }
    }
}
