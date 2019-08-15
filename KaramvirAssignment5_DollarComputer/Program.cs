using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaramvirAssignment5_DollarComputer
{
    static class Program
    {
        /// <summary>
        /// Application Name : KaramvirAssignment5_DollarComputer
        /// 
        /// Author Of the Project : Karamvir Singh
        /// 
        /// Student ID : 301044965
        /// 
        /// Application Development Date : 15 Aug 2019
        /// </summary>
        public static SelectedItem selectedItem;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            selectedItem = new SelectedItem();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
