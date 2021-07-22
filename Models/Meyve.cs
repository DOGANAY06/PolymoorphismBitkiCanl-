using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymoorphism.Models
{
    public abstract class Meyve:Bitki
    {
        public sealed override void NefesAl()
        { //başka bir sınıfa miras veremesin diye 
            MessageBox.Show("Ağaçta fotosentez");
        }
    }
}
