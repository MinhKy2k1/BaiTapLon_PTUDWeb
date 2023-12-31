﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBTL.Model
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        public string ReceiverAddress { get; set; }

        [Required]
        public string ReceiverEmail { get; set; }

        [Required]
        public string ReceiverPhone { get; set; }

        public string Note { get; set; }

        public DateTime CreateAt { get; set; }

        public int UpdateBy { get; set; }

        public DateTime UpdateAt { get; set; }

        public int Status { get; set; }
    }
}
