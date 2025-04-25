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
    public partial class DetailPigetherForm : Form
    {
        FormController controller;
        public int idPigether;

        public DetailPigetherForm(FormController controller,int idPigether)
        {
            InitializeComponent();
            this.controller = controller;
            this.Load += new System.EventHandler(controller.DetailPigetherForm_Load);
            this.closedButton.Click += new System.EventHandler(controller.closedButton_Click);
            this.idPigether = idPigether;
        }
    }
}
