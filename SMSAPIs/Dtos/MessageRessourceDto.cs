using System.ComponentModel.DataAnnotations;

namespace SMSAPIs.Dtos
{
    public class MessageRessourceDto
    {
        [MaxLength(200)]
        [Required]
        public string Message { get; set; }

        [Required]
        public string To { get; set; }
    }
}
