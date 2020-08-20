using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace ui
{
    public partial class ActivityControl : UserControl
    {
        public ActivityControl()
        {
            InitializeComponent();
        }

        Activity _activity;
        public Activity Activity {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
                if (_activity != null)
                {
                    nameLabel.Text = _activity.GetType().Name;
                }
                
            }

        }

        //[CategoryAttribute("Machine Learning")]
        //public string path { get; set; }

        //[CategoryAttribute("Machine Learning")]
        //public new PostPreEnum  Padding { get; set; }

        //[CategoryAttribute("Machine Learning")]
        //public PostPreEnum Truncating { get; set; }
    }
}
