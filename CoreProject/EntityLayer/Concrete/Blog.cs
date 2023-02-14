using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }

        // category tablosu ile ilişkilendirildi:
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // writer tablosu ile ilişkilendirildi: (yazarın bloglarını listelemek amacıyla)
        public int WriterId { get; set; }
        public Writer writer { get; set; }

        // yorumlar tablosu ile ilişkilendirildi:
        public List<Comment> Comments { get; set; } // 1 blogda 1 den fazla yorum olabilir.
    }

}
