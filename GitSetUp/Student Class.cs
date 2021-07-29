using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSetUp
{
    public class Student
    {
		private int _id;
		public int Id
		{
			get
			{
				return _id;
			}
		}
		public Student(int id)
		{
			_id = id;
		}

		public string FName { get; set; }
		public string LName { get; set; }
		public string Email { get; set; }


	}
}
