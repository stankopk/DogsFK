using DogsFK.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogsFK.View
{
    public partial class MainView : Form
    {
        MainController controller = new MainController();
        public MainView()
        {
            InitializeComponent();
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            var id = GlobalData.Id;
            dgvDogs.DataSource = controller.ShowDogsById(id);
        }
    }
}
