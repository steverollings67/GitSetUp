using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitSetUp
{
	public class ClassRoom
	{
		private int _current;
		private Student[] _students;
		public ClassRoom(int capacity)
		{
			_students = new Student[capacity];
		}


		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Student[] Students
		{
			get
			{
				return _students;
			}
		}

		public void AddStudent(Student student)
		{
			//Console.WriteLine(_current);
			if (_current == Students.Length)
			{
				Console.WriteLine("\tNot adding students any more.");
				return;
			}

			Students[_current] = student;
			_current++;

		}
	}

}