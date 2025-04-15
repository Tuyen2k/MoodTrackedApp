using System.ComponentModel.DataAnnotations;

namespace MoodTrackedLib.Entites {
    public class User : BaseModel {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string PasswordHash { get; set; }

        /// <summary>
        /// Tài khoản đang hoạt động hay không
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Tài khoản đã bị khóa hay không
        /// </summary>

        public bool LockoutEnabled { get; set; }

        /// <summary>
        /// Số lần đăng nhập thất bại
        /// </summary>
        public int AccessFailedCount { get; set; }
    }
}
