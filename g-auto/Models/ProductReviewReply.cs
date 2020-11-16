﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace g_auto.Models
{
    public class ProductReviewReply
    {
        public int Id { get; set; }
        public int ReviewProductId { get; set; }
        public ReviewProduct ReviewProduct { get; set; }
        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public DateTime PostedDate { get; set; }

        [Column(TypeName = "ntext")]
        [Required(ErrorMessage = "This field cannot be empty.")]
        public string Content { get; set; }
    }
}