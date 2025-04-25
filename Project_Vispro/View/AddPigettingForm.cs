using Project_Vispro.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Vispro.View
{
    public partial class AddPigettingForm : Form
    {
        FormController controller;
        public AddPigettingForm(FormController controller)
        {
            InitializeComponent();
            this.controller = controller;
            this.closedButton.Click += new System.EventHandler(this.controller.closedButton_Click);
            this.controller.PopulatePigetingCategoryComboBox(pigettingComboBox);
            this.addPigettingButon.Click += new System.EventHandler(this.controller.addPigettingButon_Click);
        }

    }
}
