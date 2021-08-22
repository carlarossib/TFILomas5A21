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
    public partial class Producto : IdentityBase
    {
        public Producto()
        {
            this.CartItem = new HashSet<CartItem>();
            this.OrderDetail = new HashSet<OrderDetail>();
            this.Rating = new HashSet<Rating>();
        }

        public string Tipo { get; set; }

        public string Descripcion { get; set; }

        public string Image { get; set; }

        public double Precio { get; set; }

        public int Cantidad { get; set; }

        public int Color { get; set; }

        public double AvgStars { get; set; }
        //public int ArtistId { get; set; }
        //public virtual Artist Artist { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }


    }
}
