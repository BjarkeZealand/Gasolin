﻿using System.Security.Cryptography.X509Certificates;

namespace Gasolin.Model
{ 

	public class Member
	{
		public string Name { get; set; }
		public string ImgPath { get; set; }
		public string Role { get; set; }
		public int YearOfBirth { get; set; }
		public string YearOfDeath { get; set; }
		public string BioLink { get; set; }
		public string Bio { get; set; }
		public int Age { get; set; }

		public Member(string name, string imgPath, string role, int yob, int yod, string bioLink)
		{
			Name = name;
			ImgPath = imgPath;
			Role = role;
			YearOfBirth = yob;
			BioLink = bioLink;
			if (yod == 0)
			{
				YearOfDeath = "Nu";
				Age = DateTime.Now.Year - yob;
			}

			else
			{
				YearOfDeath = yod.ToString();
				Age = yod - yob;
			}
		}
			public Member (string bio)
		{
			Bio = bio;
		}
		
	}
}
