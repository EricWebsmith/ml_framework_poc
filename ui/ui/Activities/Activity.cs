using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ui
{
    public abstract class Activity
    {
        [CategoryAttribute("Machine Learning")]
        public string Name { get; set; }

        public abstract string ClassName { get;}

    }
}
