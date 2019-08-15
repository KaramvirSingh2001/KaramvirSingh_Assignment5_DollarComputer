using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaramvirAssignment5_DollarComputer
{
    public partial class StartForm : Form
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
        public StartForm()
        {
            InitializeComponent();
            //TODO : double check heading comments
        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            Thread T = new Thread(new ThreadStart(DisplaySplash));
            T.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            T.Abort();
        }

        private void DisplaySplash()
        {

            Application.Run(new SplashScreen());
        }

        private void NewOrderButton_Click(object sender, EventArgs e)
        {
            SelectForm SelectForm = new SelectForm();
            SelectForm.Show();
            this.Hide();
        }

        private void LoadSavedOrderButton_Click(object sender, EventArgs e)
        {

            ProductInfoForm ProductInformationForm = new ProductInfoForm();
            ProductInformationForm.Show();
            this.Hide();
        }

        private void ExitApplicationButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
