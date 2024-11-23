using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboboxvehicle.Items.Add("ماشین");
            comboboxvehicle.Items.Add("دوچرخه");
            comboboxvehicle.SelectedIndex = -1;
        }

        private void buttonshowmove_Click(object sender, EventArgs e)
        {
            vehicle vl;
            if (comboboxvehicle.SelectedItem.ToString() == "ماشین")
            {
                vl = new car();
            }
            else
            { vl = new bicycle(); }
            labelresult.Text = vl.move();
        }
    }
}
    public abstract class vehicle
    {
    public abstract string move();
    }
    public class car : vehicle
  {
    public override string move()
    {
        return "ماشین در حال حرکت در جاده است";
    }
    }
    public class bicycle : vehicle
    {
    public override string move()
    {
        return "دوچرخه در حال حرکت است";
    }
}
