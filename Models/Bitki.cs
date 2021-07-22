using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymoorphism.Models
{
    public class Bitki:Canli
    {//bitki akciğer solunumu yapmaz 
        public override void NefesAl()
        {//ezdik bunu polymorphism uygulamak için 
            MessageBox.Show("Fotosentez yap");

        }
    }
}
