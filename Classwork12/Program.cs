using System;

namespace Classwork12
{
	class Program
	{
		static void Main(string[] args)
		{
			var docs = new BaseDocument[3];
			docs[0] = new BaseDocument("New Doc", "1", DateTimeOffset.Parse("2019.01.01"));
			docs[1] = new BaseDocument("Papo4ka", "12", DateTimeOffset.Parse("2020.02.02"));
			docs[2] = new Passport("123", DateTimeOffset.Parse("2018.03.03"), "Москва", "Олег?");
			foreach (var doc in docs)
			{
				if (doc is Passport)
				{
					var passport = (Passport)doc;
					passport.ChangeIssueDate(DateTimeOffset.Now);
				}
				doc.WriteToConsole();
			}
		}
	}
}
