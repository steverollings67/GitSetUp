using System;

namespace GitSetUp
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Class Room Implementation....\n");
			Console.WriteLine("Creating a class room.");
			ClassRoom dotNetClassRoom = new ClassRoom(4);
			dotNetClassRoom.Id = 2034;
			dotNetClassRoom.Name = "Dot Net Class Room";
			dotNetClassRoom.Description = "A class room created by Nitin to teach C# .Net";

			Student nitin = new Student(101) { FName = "Nitin", LName = "Rastogi", Email = "nitin.rastogi@live.in" };
			Student shanthi = new Student(102) { FName = "Shanthi", LName = "Natrajan", Email = "s.n@gmail.com" };
			Student steve = new Student(103) { FName = "Steve", LName = "Rollings", Email = "s.r.@yahoo.com" };
			Student sanjana = new Student(104) { FName = "Sanjana", LName = "Natrajan", Email = "s.n@yahoo.com" };
			Student priya = new Student(105) { FName = "Priya", LName = "M", Email = "p.m.@yahoo.com" };

			Console.WriteLine("\tAdding students to class room.");

			dotNetClassRoom.AddStudent(nitin);
			Console.WriteLine("\tAdded Nitin");
			dotNetClassRoom.AddStudent(shanthi);
			Console.WriteLine("\tAdded Shanthi");
			dotNetClassRoom.AddStudent(steve);
			Console.WriteLine("\tAdded Steve");
			dotNetClassRoom.AddStudent(sanjana);
			Console.WriteLine("\tAdded Sanjana");
			Console.WriteLine("\tAdding Priya....");
			dotNetClassRoom.AddStudent(priya);

			PrintClassRoom(dotNetClassRoom);

		}

		public static void PrintClassRoom(ClassRoom classRoom)
		{

			Console.WriteLine($"\n\nWelcome to {classRoom.Name}!!");
			Console.WriteLine($"Class Room Id: {classRoom.Id}");
			Console.WriteLine($"{classRoom.Description}");
			Console.WriteLine($"Students:");
			for (int i = 0; i < classRoom.Students.Length; i++)
			{
				Student stdnt = classRoom.Students[i];
				Console.WriteLine($"Id: {stdnt.Id}, Name: {stdnt.FName} {stdnt.LName}, Email: {stdnt.Email}");
			}
		}
	}
}
