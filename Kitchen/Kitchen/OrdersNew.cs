using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitchen
{
    public partial class OrdersNew : UserControl
    {
        public OrdersNew()
        {
            InitializeComponent();
        } 
        
            public OrdersNew(String name,String size,String qty)
            {
                InitializeComponent();
                lblName.Text = name;
                lblSize.Text = size;
                lblQty.Text = qty;
            
            }
        

        private void lblSize_Click(object sender, EventArgs e)
        {

        }

        private void OrdersNew_Load(object sender, EventArgs e)
        {

        }

        private void lblQty_Click(object sender, EventArgs e)
        {

        }
    }
}
