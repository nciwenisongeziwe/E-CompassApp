using System.ComponentModel.DataAnnotations;

namespace ServiceDirect
{
    public class ProductCatagory
    {
        [Key]
        public int catagoryID { get; set; }
        [Display(Name = "Name")]
        public string CatagoryName { get; set; }
        [Display(Name = "Description")]
        public string CatagoryDesc { get; set; }
    }
}