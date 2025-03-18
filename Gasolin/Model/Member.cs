namespace Gasolin.Model
{ 

	public class Member
	{
		public string Name { get; set; }
		public string ImgPath { get; set; }


		public Member(string name,string imgPath)
		{
			Name = name;
			ImgPath = imgPath;
		}
		
	}
}
