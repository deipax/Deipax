using System;
using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Performance.Cloning
{
	public abstract class BaseTest
	{
		#region Field Members
		private static readonly string _outDir = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		#endregion

		public TestContext TestContext { get; set; }

		public void WriteLine(string output)
		{
			string filePath = Path.Combine(_outDir, "TestOutput.txt");

			StringBuilder sb = new StringBuilder();

			sb.AppendLine(this.TestContext.TestName);
			sb.AppendLine(output);
			sb.AppendLine();

			Console.WriteLine(sb.ToString());
			File.AppendAllText(filePath, sb.ToString());
		}
	}
}