﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
	public class Position
	{
		public int PositionID { get; set; }
		public string PositionName { get; set; }
		public int MinCount { get; set; }
		public int MaxCount { get; set; }
	}
}

