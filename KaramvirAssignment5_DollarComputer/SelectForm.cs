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
    public partial class SelectForm : Form
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
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dollarComputersDataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.dollarComputersDataSet.products);

        }

        

        private void NextSelectionButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            // set the fields of selected Item for the ProductInfoForm
            setSelectedItemForNextForm();
            ProductInfoForm PIF = new ProductInfoForm();
            PIF.Show();
        }

        /// <summary>
        /// Set the SelectedItem instance so that it could be used further in next Form
        /// </summary>
        private void setSelectedItemForNextForm()
        {
            Program.selectedItem.ProductID = int.Parse(DataGridView.SelectedRows[0].Cells[0].Value.ToString());
            Program.selectedItem.Condition = DataGridView.SelectedRows[0].Cells[14].Value.ToString();
            Program.selectedItem.Cost = double.Parse(DataGridView.SelectedRows[0].Cells[1].Value.ToString());
            Program.selectedItem.Platform = DataGridView.SelectedRows[0].Cells[16].Value.ToString();
            Program.selectedItem.OS = DataGridView.SelectedRows[0].Cells[15].Value.ToString();
            Program.selectedItem.Manufac = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
            Program.selectedItem.Model = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
            Program.selectedItem.Memory = DataGridView.SelectedRows[0].Cells[5].Value.ToString();
            Program.selectedItem.Lcd = DataGridView.SelectedRows[0].Cells[7].Value.ToString();
            Program.selectedItem.Hdd = DataGridView.SelectedRows[0].Cells[17].Value.ToString();
            Program.selectedItem.CpuBrand = DataGridView.SelectedRows[0].Cells[10].Value.ToString();
            Program.selectedItem.CpuNumber = DataGridView.SelectedRows[0].Cells[13].Value.ToString();
            Program.selectedItem.GpuType = DataGridView.SelectedRows[0].Cells[19].Value.ToString();
            Program.selectedItem.CpuType = DataGridView.SelectedRows[0].Cells[11].Value.ToString();
            Program.selectedItem.CpuSpeed = DataGridView.SelectedRows[0].Cells[12].Value.ToString();
            Program.selectedItem.Webcam = DataGridView.SelectedRows[0].Cells[30].Value.ToString();

        }

        private void CancelCancelationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// When a row is clicked on datagridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            NextSelectionButton.Enabled = true;
            string manufacturer = DataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string model = DataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string cost = DataGridView.SelectedRows[0].Cells[1].Value.ToString();
            SelectedItemTextBox.Text = manufacturer + " " + model + " Priced At: $" + double.Parse(cost).ToString("N");
        }
    }
}
