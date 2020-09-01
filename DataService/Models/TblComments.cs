using System;
using System.Collections.Generic;

namespace DataService.Models
{
    public partial class TblComments
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int? CommentCommentBy { get; set; }
        public int? CommentPostId { get; set; }
        public DateTime? CommentCreated { get; set; }
        public DateTime? CommentUpdated { get; set; }

        public virtual TblPost CommentPost { get; set; }
    }
}
