using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aadea.Model
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private byte[] image;

        [DisplayName("Product ID")]
        public int Id
        {
            get { return Id; }
            set { id = value; }

        }

        [DisplayName("Product name")]
        [Required(ErrorMessage = "Product name is requiered")]
        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        [DisplayName("Product description")]
        public string Description
        {
            get { return description; }
            set { description = value; }

        }

        public byte[] Image
        {
            get { return image; }
            set { image = value; }
        }
    }
}
