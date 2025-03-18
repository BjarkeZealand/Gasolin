namespace Gasolin.Model
{ 

	public class Member
	{
		public string Name { get; set; }
		public string ImgPath { get; set; }
		public string Role { get; set; }
		public int YearOfBirth { get; set; }
		public string YearOfDeath { get; set; }
		public int Age { get; set; }

		public Member(string name,string imgPath, string role, int yob, int yod)
		{
			Name = name;
			ImgPath = imgPath;
			Role = role;
			YearOfBirth = yob;
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
	}
}
