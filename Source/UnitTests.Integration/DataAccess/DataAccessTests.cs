using System.Collections.Generic;
using System.Data;
using System.Linq;
using Deipax.DataAccess.Common;
using Deipax.DataAccess.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Integration.DataAccess
{
	[TestClass]
	public class DataAccessTests
	{
		[TestMethod]
		public void DataAccessTests_AsClass()
		{
			/*
			var db = DbManager.Get("TestDb");
			List<Category> items = null;

			db.AsBatch(dbBatch =>
			{
				items = dbBatch
					.CreateDbCmd()
					.SetCommandType(CommandType.Text)
					.SetSql(@"select * from main.[Category]")
					.AsList<Category>();
			});

			Assert.IsTrue(items != null);
			Assert.IsTrue(items.Count > 0);

			var select = items
				.Where(x => x.Id <= 0)
				.ToList();

			Assert.IsTrue(select != null);
			Assert.IsTrue(select.Count == 0);
			*/
		}

		[TestMethod]
		public void DataAccessTests_AsStruct()
		{
			/*
			var db = DbManager.Get("TestDb");
			List<CategoryAsStruct> items = null;

			db.AsBatch(dbBatch =>
			{
				items = dbBatch
					.CreateDbCmd()
					.SetCommandType(CommandType.Text)
					.SetSql(@"select * from main.[Category]")
					.AsList<CategoryAsStruct>();
			});

			Assert.IsTrue(items != null);
			Assert.IsTrue(items.Count > 0);

			var select = items
				.Where(x => x.Id <= 0)
				.ToList();

			Assert.IsTrue(select != null);
			Assert.IsTrue(select.Count == 0);
			*/
		}

		#region Helpers
		class Category
		{
			public int Id { get; set; }
			public string CategoryName { get; set; }
			public string Description { get; set; }
		}

		struct CategoryAsStruct
		{
			public int Id { get; set; }
			public string CategoryName { get; set; }
			public string Description { get; set; }
		}
		#endregion
	}
}