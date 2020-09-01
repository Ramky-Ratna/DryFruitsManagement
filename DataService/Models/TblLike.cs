using System;
using System.Collections.Generic;

namespace DataService.Models
{
    public partial class TblLike
    {
        public int LikeId { get; set; }
        public string LikeLikedBy { get; set; }
        public int? LikePostId { get; set; }
        public DateTime? LikeDate { get; set; }

        public virtual TblPost LikePost { get; set; }
    }
}
