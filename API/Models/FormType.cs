using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class FormType
    {
        [Key]
        public int Id { get; set; }
        public string TypeName { get; set; }
        public string TypeDescription { get; set; }
        public int DayQuatity { get; set; }
        public ICollection<Form> Forms { get; set; } // Navigation property
    }
}
