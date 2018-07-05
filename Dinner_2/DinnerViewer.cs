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

namespace Dinner_2
{
    public partial class DinnerViewer : Form
    {
        public bool m_isStopRoulette { get; set; }
        private DinnerPlaceManager m_dinnerplaces;
        private bool m_isChagedLabel;

        public DinnerViewer(string filePath)
        {
            InitializeComponent();
            m_isStopRoulette    = true;
            this.button1.Text   = "start";
            this.m_dinnerplaces = new DinnerPlaceManager(filePath);
            this.m_isChagedLabel = false;
        }
        
        public void setLabelRandom()
        {
            if (this.m_isStopRoulette && !this.m_isChagedLabel)
            {
                this.m_isChagedLabel  = true;
                this.dinnerLabel.Text = this.m_dinnerplaces.selectDinnerPlace();
            }
            else if(!this.m_isStopRoulette)
            {
                int DinnerPlaceNum = this.m_dinnerplaces.m_dinnerPlaces.Count;
                Random rand = new Random();
                this.dinnerLabel.Text = this.m_dinnerplaces.m_dinnerPlaces[rand.Next(DinnerPlaceNum)].m_dinnerPlace;
            }
        }

        private void clickBtn(object sender, EventArgs e)
        {
            if (this.m_isStopRoulette)
            {
                this.m_isChagedLabel = false;
                this.button1.Text    = "stop";
            }else
                this.button1.Text    = "start";

            this.m_isStopRoulette = !this.m_isStopRoulette;
        }
    }
}
