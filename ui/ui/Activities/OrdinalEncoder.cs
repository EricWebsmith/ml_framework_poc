using System;
using System.Collections.Generic;
using System.Text;

namespace ui
{
    public class OrdinalEncoder : Activity
    {
        public string Columns { get; set; }
        public override string ClassName { get { return "ml_modules.OrdinalEncoder"; } }

    }
}
