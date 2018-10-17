using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDirect
{
    [DataContract]
    public class PnpProducts
    {
        [DataMember]
        [Key]
        public int ProductID { get; set; }

        [DataMember]
        [Display(Name = "Name")]
        public string ProductName { get; set; }

        [DataMember]
        [Display(Name = "Price")]
        public float ProductPrice { get; set; }

        [DataMember]
        [Display(Name = "Image")]
        public string ProductImage { get; set; }

        [DataMember]
        [Display(Name = "Percent")]
        public double ProductDropPercent { get; set; }

        [DataMember]
        [Display(Name = "Description")]
        public string ProductDesc { get; set; }

        [DataMember]
        [Display(Name = "SpecialEndDate")]
        public DateTime ProductDateEndPromo { get; set; }
        [Display(Name = "Catagory")]

        [DataMember]
        public ProductCatagory Catagory { get; set; }   
    }
}
