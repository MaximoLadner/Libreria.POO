using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp39
{
    public interface IlistaEditable<t> where t : class  
    {
        void Agregar(t item);
        void Quitar(t item);
    }
}
