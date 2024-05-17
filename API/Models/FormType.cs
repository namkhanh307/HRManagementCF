using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class FormType
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public int DayQuantity { get; set; }  // Corrected property name
        public ICollection<Form> Forms { get; set; }
    }
}
