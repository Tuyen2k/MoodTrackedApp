using MoodTrackedLib.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodTrackedLib.Entites
{
    public class Diary : BaseModel
    {
        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Title { get; set; }

        public string Content { get; set; }
        public Guid UserId { get; set; }
        public MoodStatus Mood { get; set; }

        /// <summary>
        /// Trạng thái riêng tư của nhật ký
        /// </summary>
        public bool IsPublic { get; set; }

        /// <summary>
        /// Trạng thái yêu thích của nhật ký
        /// </summary>
        public bool IsFavorite { get; set; }

        /// <summary>
        /// Trạng thái khóa của nhật ký
        /// </summary>
        public bool IsLocked { get; set; }

    }
}
