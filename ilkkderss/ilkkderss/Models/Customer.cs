using System.ComponentModel.DataAnnotations;

namespace ilkkderss.Models
{
    public class Customer
    {
        //public int CustomerId { get; set; }

        //Validationda yani doğrulamada kullanacağım zorunluluklarımı burada girdim


        [Required(ErrorMessage ="isim kısmını boş geçemezsiniz")]
        [StringLength(30,ErrorMessage ="max 30 karakter kullanabilirsin!")]
        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        [EmailAddress(ErrorMessage ="Emailinizi kontrol ediniz")]
        public string Email { get; set; }



    }
}
