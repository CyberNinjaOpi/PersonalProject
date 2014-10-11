using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DataModels
{
	public class Message
	{
		public int Id { get; set; }
		public DateTime Date { get; set; }
		public string PrivateMessage { get; set; }
		public int UserId { get; set; }
		public int FriendId { get; set; }
	}
}
