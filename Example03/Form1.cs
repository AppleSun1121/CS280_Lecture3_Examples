using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreLibrary;

namespace Example03
{
    public partial class Form1 : Form
    {
        private Order order;
        private Customer customer;

        public Form1()
        {
            InitializeComponent();
            this.customer = new Customer();
            this.customer.Name = "AppleSun";
        }

        private void orderRichTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RederScreen();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            this.order = new Order();

            this.order.Customer = this.customer;
            RederScreen();
        }

        private void product1Bottom_Click(object sender, EventArgs e)
        {
            this.order.ProductList.Add(new Product() { Name = "豆漿", Price = 15 });
            RederScreen();
        }

        private void product2Bottom_Click(object sender, EventArgs e)
        {
            this.order.ProductList.Add(new Product() { Name = "油條", Price = 10 });
            RederScreen();
        }

        private void RederScreen()
        {
            this.customerLabel.Text = this.customer.Name;
            this.orderButton.Text = "點餐";
            this.product1Bottom.Text = "豆漿";
            this.product2Bottom.Text = "油條";
            this.accountButton.Text = "結帳";

            if (this.order != null)
            {
                product1Bottom.Enabled = true;
                product2Bottom.Enabled = true;
                orderButton.Enabled = false;
                this.orderRichTextBox.Text = order.GetDetail();
            }
            else
            {
                product1Bottom.Enabled = false;
                product2Bottom.Enabled = false;
                orderButton.Enabled = true;
                orderRichTextBox.Text = string.Empty;
            }
        }

        private void accountButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("{0}, 結帳金額:{1}，謝謝惠顧 ", this.order.Customer.Name, this.order.GetTotal()));
            this.order = null;
            RederScreen();
        }

        private void tableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SelectedIndex = tableComboBox.SelectedIndex;
            this.customer.Name = tableComboBox.Items[SelectedIndex].ToString() + "桌";
            RederScreen();
        }
    }
}