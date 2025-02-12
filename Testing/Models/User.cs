using System.ComponentModel;

namespace Testing.Models
{

   public class User
   {
        [DisplayName("User ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
   }
  
}
