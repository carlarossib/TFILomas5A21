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

    public partial class Asociado : IdentityBase
    {

        public Asociado()
        {
            //    this.Product = new HashSet<Product>();
        }
        [DataMember]
        public string Descripcion { get; set; }

        [DataMember]
        public string Telefono { get; set; }

        [DataMember]
        public string NombreContacto { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Plazo { get; set; }

        [DataMember]
        public int Vigencia { get; set; }

        [DataMember]
        public string DVH { get; set; }
        //[DataMember]
        //public virtual ICollection<Product> Product { get; set; }
    }


}

