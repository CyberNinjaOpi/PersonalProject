using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataModels
{
	public class Category
	{
		public int Id{ get; set; }
		public string Title { get; set; }
		public int UserId { get; set; }
		public virtual List<Content> contents {get;set;}

		public Category() { }
		public Category(string title)
		{
			Title = title;
		}
		public void SetProps(Category category) {
			this.Title = category.Title;
		}
	}
}
