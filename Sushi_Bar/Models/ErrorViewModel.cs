using System.ComponentModel.DataAnnotations;

namespace Sushi_Bar.Models
{
    public class ErrorViewModel
    {

        [Display(Name = "Запрос")]
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
