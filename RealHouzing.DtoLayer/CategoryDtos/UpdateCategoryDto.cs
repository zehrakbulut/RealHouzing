﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHouzing.DtoLayer.CategoryDtos
{
    public class UpdateCategoryDto
    {
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
		public string Icon { get; set; }
		public string ImageUrl { get; set; }
	}
}
