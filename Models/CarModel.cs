﻿using System;
// worked with kel on this file
namespace AspNetCoreTodo.Models
    public class CarItem
    {
        public Guid Id { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public string CarMake { get; set; }
        public int CarYear { get; set; }
    }