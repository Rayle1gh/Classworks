using System;

namespace Classwork12
{
	public class BaseDocument
	{
		public BaseDocument(string docName, string docNumber, DateTimeOffset issueDate)
		{
			DocName = docName;
			DocNumber = docNumber;
			IssueDate = issueDate;
		}
		public string DocName { get; set; }
		public string DocNumber { get; set; }
		public DateTimeOffset IssueDate { get; set; }
		public virtual string PropertiesString { get { return 
					$"Имя док-та: {DocName}, " +
					$"№ док-та: {DocNumber}, " +
					$"Дата выдачи: {IssueDate},"; } }
		public void WriteToConsole()
		{
			Console.WriteLine(PropertiesString);
		}
	}
}
