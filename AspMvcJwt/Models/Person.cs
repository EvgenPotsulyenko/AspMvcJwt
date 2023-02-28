using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspMvcJwt.Models
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid id { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        //public Person(string em, string pas)
        //{
        //    Email = em;
        //    Password = pas;
        //}
    }
}
