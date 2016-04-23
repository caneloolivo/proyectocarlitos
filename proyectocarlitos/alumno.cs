using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectocarlitos
{
    public class alumno
    {
        public int registro{get; set;}
        public String  nombre{ get; set; }
        public String  aPaterno{ get; set; }
        public String  aMaterno{ get; set;}
        public String  domicilio{ get; set;}
        public String  correo{ get; set;}
        public int  periodo{ get; set;}
        public double telefono{ get; set;}        
        public String  contrasena{ get; set;}
        public String contactoemergencia { get; set;}
        public double numemergencia { get; set; }
        public String carrera { get; set; }
    }
}
