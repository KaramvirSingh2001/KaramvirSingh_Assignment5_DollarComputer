using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaramvirAssignment5_DollarComputer
{
    public partial class ProductInfoForm : Form
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
        private SelectedItem _selectedItem; 
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            DialogResult dialogResult;

            // Start from project directory.
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            
            
            //Only select Text Files
            openFileDialog1.Filter = "Text Files | *.txt";
            
            // Display the File Open dialog box.
            dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult != DialogResult.Cancel)
            { 
              // Open the output file.
                try
                {
                    // Read entire file into a single string.
                    string fileString = File.ReadAllText(openFileDialog1.FileName);
                    // Split the string into individual fields of a string array.
                    string[] values = fileString.Split('\n');
                    // Display the array in a list box.
                    populateSpecFieldsFromFile(values);

                    InfoNextButton.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Error 404 File not Found.");
                }
            }
        }
        /// <summary>
        /// Read all the specs fields line by line from the file
        /// </summary>
        /// <param name="values"></param>

        private void populateSpecFieldsFromFile(string[] values)
        {
            ProductIdTextBox.Text = values[0];
            ConditionTextBox.Text = values[1];
            CostTextBox.Text = values[2];
            PlatformTextBox.Text = values[3];
            OsTextBox.Text = values[4];
            ManufacTextBox.Text = values[5];
            ModelTextBox.Text = values[6];
            MemoryTextBox.Text = values[7];
            LcdTextBox.Text = values[8];
            hddTextBox.Text = values[9];
            CpuBrandTextBox.Text = values[10];
            CpuNumberTextBox.Text = values[11];
            GpuTypeTextBox.Text = values[12];
            CpuTypeTextBox.Text = values[13];
            CpuSpeedTextBox.Text = values[14];
            WebcamTextBox.Text = values[15];
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save as Text File Only
            saveFileDialog1.Filter = "Text Files | *.txt";

            //by default name is:
            saveFileDialog1.FileName = "Product.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // If every thing goes okay
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName))
                {
                    writeSpecFieldsToFile(streamWriter);

                }
            }
        }

        /// <summary>
        /// Write all the specs fields one by one on a new line
        /// </summary>
        /// <param name="S"></param>
        private void writeSpecFieldsToFile(StreamWriter S)
        {
            S.WriteLine(ProductIdTextBox.Text);
            S.WriteLine(ConditionTextBox.Text);
            S.WriteLine(CostTextBox.Text);
            S.WriteLine(PlatformTextBox.Text);
            S.WriteLine(OsTextBox.Text);
            S.WriteLine(ManufacTextBox.Text);
            S.WriteLine(ModelTextBox.Text);
            S.WriteLine(MemoryTextBox.Text);
            S.WriteLine(LcdTextBox.Text);
            S.WriteLine(hddTextBox.Text);
            S.WriteLine(CpuBrandTextBox.Text);
            S.WriteLine(CpuNumberTextBox.Text);
            S.WriteLine(GpuTypeTextBox.Text);
            S.WriteLine(CpuTypeTextBox.Text);
            S.WriteLine(CpuSpeedTextBox.Text);
            S.WriteLine(WebcamTextBox.Text);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.selectedItem.ProductID = int.Parse(this.ProductIdTextBox.Text);
            Program.selectedItem.Condition = this.ConditionTextBox.Text;
            Program.selectedItem.Cost = double.Parse(this.CostTextBox.Text);
            Program.selectedItem.Platform = this.PlatformTextBox.Text;
            Program.selectedItem.OS = this.OsTextBox.Text;
            Program.selectedItem.Manufac = this.ManufacTextBox.Text;
            Program.selectedItem.Model = this.ModelTextBox.Text;
            Program.selectedItem.Memory = this.MemoryTextBox.Text;
            Program.selectedItem.Lcd = this.LcdTextBox.Text;
            Program.selectedItem.Hdd = this.hddTextBox.Text;
            Program.selectedItem.CpuBrand = this.CpuBrandTextBox.Text;
            Program.selectedItem.CpuNumber = this.CpuNumberTextBox.Text;
            Program.selectedItem.GpuType = this.GpuTypeTextBox.Text;
            Program.selectedItem.CpuType = this.CpuTypeTextBox.Text;
            Program.selectedItem.CpuSpeed = this.CpuSpeedTextBox.Text;
            Program.selectedItem.Webcam = this.WebcamTextBox.Text;


            this.Hide();
            OrderForm O = new OrderForm();
            O.Show();
        }

        private void InfoCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InfoSelectProductButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SelectForm().Show();
        }
        
        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            this.ProductIdTextBox.Text = Program.selectedItem.ProductID.ToString();
            this.ConditionTextBox.Text = Program.selectedItem.Condition;
            this.CostTextBox.Text = Program.selectedItem.Cost.ToString();
            this.PlatformTextBox.Text = Program.selectedItem.Platform;
            this.OsTextBox.Text = Program.selectedItem.OS;
            this.ManufacTextBox.Text = Program.selectedItem.Manufac;
            this.ModelTextBox.Text = Program.selectedItem.Model;
            this.MemoryTextBox.Text = Program.selectedItem.Memory;
            this.LcdTextBox.Text = Program.selectedItem.Lcd;
            this.hddTextBox.Text = Program.selectedItem.Hdd;
            this.CpuBrandTextBox.Text = Program.selectedItem.CpuBrand;
            this.CpuNumberTextBox.Text = Program.selectedItem.CpuNumber;
            this.GpuTypeTextBox.Text = Program.selectedItem.GpuType;
            this.CpuTypeTextBox.Text = Program.selectedItem.CpuType;
            this.CpuSpeedTextBox.Text = Program.selectedItem.CpuSpeed;
            this.WebcamTextBox.Text = Program.selectedItem.Webcam;
            InfoNextButton.Enabled = true;
        }
    }
}
