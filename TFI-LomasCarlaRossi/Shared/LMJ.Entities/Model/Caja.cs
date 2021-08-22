using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;


namespace LMJ.Entities.Model
{
    [DataContract]
    [Serializable]

    public partial class Caja : IdentityBase
    {

        public Caja()
        {
            //    this.Product = new HashSet<Product>();
        }

        [DataMember]
        public int NroCaja { get; set; }

        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public int PrecintoEntrada { get; set; }

        [DataMember]
        public int PrecintoSalida { get; set; }

        [DataMember]
        public string EstadoCaja { get; set; }

        [DataMember]
        public string DVH { get; set; }
        //[DataMember]
        //public virtual ICollection<Product> Product { get; set; }
    }


}

