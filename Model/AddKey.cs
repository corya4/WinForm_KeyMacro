using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MACP.Model
{
    class AddKey
    {
        public
        Keys key { get; set; }

        public
        int modify  { get; set; }

        public
        int isShift { get; set; }
        public
        int isCtrl { get; set; }
        public
        int isAlt { get; set; }
    }
}
