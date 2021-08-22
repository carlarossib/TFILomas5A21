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

    public partial class Bitacora : IdentityBase
    {

        public Bitacora()
        {
            //    this.Product = new HashSet<Product>();
        }
        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public string FechaHora { get; set; }

        [DataMember]
        public string Criticidad { get; set; }

        [DataMember]
        public string DVH { get; set; }
        //[DataMember]
        //public virtual ICollection<Product> Product { get; set; }
    }


}

