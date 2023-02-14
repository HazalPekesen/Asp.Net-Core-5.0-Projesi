using Microsoft.AspNetCore.Http;

namespace CoreMVC.Models
{
    public class AddProfileImage
    {
        public int WriterId { get; set; }
        public string WriterName { get; set; }
        public string WriterAbout { get; set; }
        public IFormFile WriterImage { get; set; }  // bu property'deki değişikliği yapabilmek amacıyla Model içerisinde class oluşturuldu ve bu propertyler tanımlandı.!!!!
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        public bool WriterStatus { get; set; }
    }
}
