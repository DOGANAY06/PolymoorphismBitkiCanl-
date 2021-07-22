using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polymoorphism.Models
{
    public abstract class Canli
    {//bütün canlılarda nefes alma özelliği ortaktır 
        public virtual void NefesAl() //virtual olduğu için bu özellik değiştirebilir 
        {
            MessageBox.Show("Akciğer Solunumu Yap");
            //bitkiler hariç bu değerle çalışacak bu konuda 
            //polymorphism giriyor araya virtual olarak 
        }
    }
}
