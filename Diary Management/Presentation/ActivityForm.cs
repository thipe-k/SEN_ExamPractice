using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Diary_Management.Business_Logic;

namespace Diary_Management.Presentation
{
    public partial class ActivityForm : Form
    {
        public ActivityForm()
        {
            InitializeComponent();
        }

        private void ActivityForm_Load(object sender, EventArgs e)
        {
            cbxType.Items.AddRange(Enum.GetNames(typeof(ActivityType)));
        }

        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxType.SelectedItem.ToString() == ActivityType.Meeting.ToString())
            {
                cblOwner.SelectionMode = SelectionMode.MultiSimple;
            }
            else {
                cblOwner.SelectionMode = SelectionMode.One;
            }
        }
    }
}
