using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Data.Entites
{
    public class User
    {
        public int Id { get; set; }  // Birincil anahtar (PK)
        public string Username { get; set; }  // Kullanıcı adı
        public string Email { get; set; }  // E-posta adresi

        // Navigation property: Bir kullanıcı birden fazla gönderiye sahip olabilir.
        public List<Post> Posts { get; set; }
    }
}
