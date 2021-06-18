using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace medical_appointments.Models
{
    public class Patient
    {
        [Key]
        public int PatientId { get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio.")]
        [Display(Name = "Nombre Completo")]
        [StringLength(20, ErrorMessage = "No debe tener mas de 20 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientFullName { get; set; }

        [Required(ErrorMessage = "El Apellido es obligatorio.")]
        [Display(Name = "Apelllido")]
        [StringLength(20, ErrorMessage = "No debe tener mas de 20 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientSurname { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [Display(Name = "Correo")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientEmail { get; set; }

        [Display(Name = "Nombre")]
        [StringLength(20, ErrorMessage = "No debe tener mas de 20 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientCompanionName { get; set; }

        [Display(Name = "Apellido")]
        [StringLength(20, ErrorMessage = "No debe tener mas de 20 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientCompanionSurname { get; set; }

        [Required(ErrorMessage = "La Direcion es obligatoria.")]
        [Display(Name = "Paciente Direcion ")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 20 caracteres.")]
        [MinLength(5, ErrorMessage = "Debe tener mas de 5 caracteres.")]
        public String PatientStreetAddress { get; set; }

        [Required(ErrorMessage = "La Direcion es obligatoria.")]
        [Display(Name = "Paciente Direcion 2")]
        [StringLength(30, ErrorMessage = "No debe tener mas de 30 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientStreetAddressTwo { get; set; }

        [Required(ErrorMessage = "La Ciudad es obligatoria.")]
        [Display(Name = "Ciudad")]
        [StringLength(25, ErrorMessage = "No debe tener mas de 25 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientCity { get; set; }


        [Required(ErrorMessage = "La Provincia es obligatoria.")]
        [Display(Name = "Provincia")]
        [StringLength(15, ErrorMessage = "No debe tener mas de 15 caracteres.")]
        [MinLength(4, ErrorMessage = "Debe tener mas de 4 caracteres.")]
        public String PatientProvince { get; set; }

        [Required(ErrorMessage = "EL codigo Postal es obligatorio.")]
        [Display(Name = "Codigo Postal")]
        public int PatientPostaCode { get; set; }

        [Required(ErrorMessage = "EL Codigo es obligatorio.")]
        [Display(Name = "Codigo Telefono ")]
        public int PatientNumberCode { get; set; }

        [Required(ErrorMessage = "El Numero detelefono es obligatoria.")]
        [Display(Name = "Numero Telefono ")]
        public int PatientNumber { get; set; }

        [Display(Name = "Numero Telefono  Whatsapp")]
        public int PatientNumberWhatsapp { get; set; }
    }
}
