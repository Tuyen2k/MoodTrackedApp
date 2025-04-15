using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodTrackedLib.RequestModels
{
    public class UserRequest
    {
        [Required(ErrorMessage = "{0} là bắt buộc")]
        [Display(Name = "Tên người dùng")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} có độ dài từ {2} đến {1} ký tự")]
        public string Email { get; set; }

        [Required(ErrorMessage = "{0} là bắt buộc")]
        [Display(Name = "Mật khẩu")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&^#()[\\]{}|\\\\/\\-+_.:;=,~`])[^\\s<>]{8,20}$", 
            ErrorMessage ="Mật khẩu phải chứa ít nhất 1 ký tự viết hoa, 1 chữ số, 1 ký tự đặc biệt và có độ dài từ 8 đến 20 ký tự.")]
        public string Password { get; set; }
    }
}
