using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaramvirAssignment5_DollarComputer
{
    public partial class OrderForm : Form
    {
        /// <summary>
        /// 
        /// Application Name : KaramvirAssignment5_DollarComputer
        /// 
        /// Author : Karamvir Singh
        /// 
        /// ID : 301044965
        /// 
        /// App Creation Date : 15 AUG 2019
        /// 
        /// </summary>
        public OrderForm()
        {
            InitializeComponent();
        }

        private void CancelOrderButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Selection is in printing process!");
        }

        private void BackOrderButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductInfoForm().Show();
            
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mr. Karamvir Singh\n Version 1.0\n www.DollarComp.can \n+1(411) 831-4212");
        }

        private void FinishOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult R = MessageBox.Show("It is a pleasure doing bussiness with you\n Your order will be delivered to you in approx 7/ 10 days...", "Thank You !", MessageBoxButtons.OKCancel);
            if (R == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            displaySysCompFields();

            populateSpecListBox();
            
            PriceTextBox.Text = Program.selectedItem.Cost.ToString();

            double tax = ((Program.selectedItem.Cost / 100) * 13);
            SalesTaxTextBox.Text = tax.ToString();
            TotalTextBox.Text = (tax + Program.selectedItem.Cost).ToString();

            // Display a random image
            showSelectedItemImage();

        }

        private void showSelectedItemImage()
        {

            int rand = new Random().Next(1, 5);
            ProductImageBox.Load(@"../../Resources/" + rand + ".jpg");
        }

        private void populateSpecListBox()
        {
            HwSpecificationListBox.Items.Clear();
            HwSpecificationListBox.Items.Add(Program.selectedItem.Lcd);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.Memory);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.CpuBrand);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.CpuType);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.CpuNumber);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.CpuSpeed);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.Hdd);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.GpuType);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.Webcam);
            HwSpecificationListBox.Items.Add("");
            HwSpecificationListBox.Items.Add(Program.selectedItem.OS);

        }

        private void displaySysCompFields()
        {
            ConditionTextBox.Text = Program.selectedItem.Condition;
            PlatformTextBox.Text = Program.selectedItem.Platform;
            ManufacTextBox.Text = Program.selectedItem.Manufac;
            ModelTextBox.Text = Program.selectedItem.Model;

        }
    }
}
