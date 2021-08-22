//====================================================================================================
// Código base generado con Visual Studio: (Build 1.0.1973)
// Layered Architecture Solution Guidance
// Generado por vcontreras - MCGA
//====================================================================================================

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace LMJ.Entities.Model
{


    [Serializable]

    public partial class Formulario : IdentityBase
    {

        public int IdCliente { get; set; }

        public string Descripcion { get; set; }

        public string Sexo { get; set; }
        public string Estilo { get; set; }
        public string Color { get; set; }
        public string Calzado { get; set; }
        public string Remeras { get; set; }
        public string Camisas { get; set; }
        public string Pantalones { get; set; }

        public float Altura { get; set; }

        public float Peso { get; set; }
        public float Talle { get; set; }
        public string Objetivo { get; set; }


        public string DVH { get; set; }

        //public virtual ICollection<OrderDetail> OrderDetail { get; set; }
    }
}
