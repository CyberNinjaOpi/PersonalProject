using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataModels
{
	public class Content
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Link { get; set; }
		public string Image { get; set; }
		public int CategoryId { get; set; }
	}
}
