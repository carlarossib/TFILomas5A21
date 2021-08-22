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

    public partial class Cliente : IdentityBase
    {

        public Cliente()
        {
            //    this.Product = new HashSet<Product>();
        }
        [DataMember]
        public string NOmbre { get; set; }

        [DataMember]
        public string Apellido { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Estado { get; set; }

        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }


        [DataMember]
        public string DatosTarjeta { get; set; }

        [DataMember]
        public int Telefono { get; set; }

        [DataMember]
        public string DVH { get; set; }
        //[DataMember]
        //public virtual ICollection<Product> Product { get; set; }
    }


}

