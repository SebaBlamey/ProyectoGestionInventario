using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace aadea.Model
{
    public class TrabajadorModel
    {
        private string rut;
        private string nombre;
        private string apellido;
        private string direccion;
        private string telefono;

        [DisplayName("RUT")]
        [Required(ErrorMessage = "Ingrese rut")]
        [RegularExpression("^[0-9]+-[0-9kK]{1}$",
            ErrorMessage = "Ingrese un rut valido (formato 12345678-9).")]
        public string Rut
        {
            get => rut;
            set => rut = value;
        }


        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }
        public string Apellido
        {
            get => apellido;
            set => apellido = value;
        }
        public string Direccion
        {
            get => direccion;
            set => direccion = value;
        }
        public string Telefono
        {
            get => telefono;
            set => telefono = value;
        }
    }
}
