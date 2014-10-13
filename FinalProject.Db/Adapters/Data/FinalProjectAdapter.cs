using FinalProject.DataModels;
using FinalProject.Db.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Db.Adapters.Data
{
	public class FinalProjectAdapter : IFinalProjectAdapter
	{
		/*Content*/
		public List<Content> GetAllContent()
		{
			List<Content> contents;
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				contents = db.Contents.OrderBy(x => x.Title).ToList();
			}
			return contents;
		}
		public Content GetContent(int id)
		{
			Content content;
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				content = db.Contents.Where(x => x.Id == id).FirstOrDefault();
			}
			return content;
		}
		public Content AddContent(Content content)
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				content = db.Contents.Add(content);
				db.SaveChanges();
			}
			return content;
		}
		public Content UpdateContent(Content content)
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				Content oldcontent = db.Contents.Find(content.Id);
				oldcontent.SetProps(content);
				db.SaveChanges();
			}
			return content;
		}
		public Content DeleteContent(int id)
		{
			Content content;
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				content = db.Contents.Find(id);
				db.Contents.Remove(content);
				db.SaveChanges();
			}
			return content;
		}

		/*Category*/
		public List<Category> GetAllCategory()
		{
			List<Category> categorys;
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				categorys = db.Categorys.OrderBy(x => x.Title).ToList();
			}
			return categorys;
		}
		public Category GetCategory(int id)
		{
			Category category;
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				category = db.Categorys.Where(x => x.Id == id).FirstOrDefault();
			}
			return category;
		}
		public Category AddCategory(Category category)
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				category = db.Categorys.Add(category);
				db.SaveChanges();
			}
			return category;
		}
		public Category UpdateCategory(Category category)
		{
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				Category oldcategory = db.Categorys.Find(category.Id);
				oldcategory.SetProps(category);
				db.SaveChanges();
			}
			return category;
		}
		public Category DeleteCategory(int id)
		{
			Category category;
			using (ApplicationDbContext db = new ApplicationDbContext())
			{
				category = db.Categorys.Find(id);
				db.Categorys.Remove(category);
				db.SaveChanges();
			}
			return category;
		}
		/*End*/
	}
}
