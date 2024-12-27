using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstRelation.Data.Entites
{
    public class Post
    {
        public int Id { get; set; }  // Birincil anahtar (PK)
        public string Title { get; set; }  // Gönderi başlığı
        public string Content { get; set; }  // Gönderi içeriği
        public int UserId { get; set; }  // Yabancı anahtar (User'ın kimliği)

        // Navigation property: Bir gönderinin yalnızca bir yazarı (User) vardır.
        public User User { get; set; }
    }
}
