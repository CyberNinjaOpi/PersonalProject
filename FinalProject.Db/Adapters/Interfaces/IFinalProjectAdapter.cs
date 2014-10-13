using FinalProject.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Db.Adapters.Interfaces
{
	public interface IFinalProjectAdapter
	{/*CRUD*/

		/*Content*/
		Content AddContent(Content content);
		List<Content> GetAllContent();
		Content GetContent(int id);
		Content UpdateContent(Content content);
		Content DeleteContent(int id);

		/*Category*/
		Category AddCategory(Category category);
		List<Category> GetAllCategory();
		Category GetCategory(int id);
		Category UpdateCategory(Category category);
		Category DeleteCategory(int id);
	}
}
