using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NTDHLesson08CF.Models
{
    /// <summary>
    /// tạo ra cấu trúc bảng Book
    /// </summary>
    public class NTDHBook
    {
        [Key]
        public int NTDHBookId { get; set; }
        public string NTDHTitle { get; set; }
        public string NTDHAuthor { get; set; }
        public int NTDHYear { get; set; }
        public string NTDHPublisher { get; set; }
        public string NTDHPicture { get; set; }
        public int NTDHCategoryId { get; set; }

        // Thuộc tính quan hệ
        public virtual NTDHCategory NTDHCategory { get; set; }
    }
}