using System;

namespace Classwork12
{
	public class Passport:BaseDocument
	{
		public Passport(string docNumber, DateTimeOffset issueDate, string country, string personName):base("Passport", docNumber, issueDate)
		{
			Country = country;
			PersonName = personName;
		}
		public string Country { get; set; }
		public string PersonName { get; set; }
		public override string PropertiesString { get {return
				$"Имя док-та: {DocName}, " +
				$"№ док-та: {DocNumber}, " +
				$"Дата выдачи: {IssueDate}," +
				$"Страна: {Country}," +
				$"Имя личности: {PersonName}";
			}
		}
		public void ChangeIssueDate(DateTimeOffset newIssueDate)
		{
			IssueDate = newIssueDate;
		}
	}
}
