using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace twozerofoureight
{
    public partial class TwoZeroFourEightScoreView : Form,View
    {
        Model M;
        public TwoZeroFourEightScoreView()
        {
            InitializeComponent();
            M = new TwoZeroFourEightModel();
            M.AttachObserver(this);
        }

        public void Notify(Model m)
        {
            lblScore2.Text = (((TwoZeroFourEightModel)m).Updatescore());
            
            //Updatescore(((TwoZeroFourEightModel) m).GetBoard());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblScore2_Click(object sender, EventArgs e)
        {

        }

        private void TwoZeroFourEightScoreView_Load(object sender, EventArgs e)
        {

        }
    }
}
