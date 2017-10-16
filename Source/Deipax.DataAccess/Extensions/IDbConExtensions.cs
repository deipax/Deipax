﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Deipax.DataAccess.Interfaces
{
	public static class IDbConExtensions
	{
		public static IDbDataParameter CreateParameter(
			this IDbCon source,
			string name = null,
			object value = null,
			ParameterDirection? direction = default(ParameterDirection?),
			DbType? dbType = default(DbType?),
			int? size = default(int?))
		{
			return source
				.GetConnection()
				.CreateParameter(name, value, direction, dbType, size);
		}

		public static IEnumerable<IDbDataParameter> CreateParameters(
			this IDbCon source,
			string baseName,
			IEnumerable<object> values)
		{
			return source
				.GetConnection()
				.CreateParameters(baseName, values);
		}

		public static void AsBatch(
			this IDbCon source,
			Action<IDbBatch> func)
		{
			func(source.CreateDbBatch());
		}

		public static T AsBatch<T>(
			this IDbCon source,
			Func<IDbBatch, T> func)
		{
			return func(source.CreateDbBatch());
		}

		public static void AsTransaction(
			this IDbCon source,
			Action<IDbBatch> func)
		{
			var batch = source.CreateDbBatch();
			batch.Connection.OpenSafe(batch.Db);

			using (var trans = batch.Connection.BeginTransaction())
			{
				try
				{
					func(batch.SetTransaction(trans));
					trans.Commit();
				}
				catch
				{
					trans.Rollback();
					throw;
				}
			}
		}

		public static void AsTransaction(
			this IDbCon source,
			IsolationLevel isolationLevel,
			Action<IDbBatch> func)
		{
			var batch = source.CreateDbBatch();
			batch.Connection.OpenSafe(batch.Db);

			using (var trans = batch.Connection.BeginTransaction(isolationLevel))
			{
				try
				{
					func(batch.SetTransaction(trans));
					trans.Commit();
				}
				catch
				{
					trans.Rollback();
					throw;
				}
			}
		}

		public static T AsTransaction<T>(
			this IDbCon source,
			Func<IDbBatch, T> func)
		{
			var batch = source.CreateDbBatch();
			batch.Connection.OpenSafe(batch.Db);

			using (var trans = batch.Connection.BeginTransaction())
			{
				try
				{
					T retVal = func(batch.SetTransaction(trans));
					trans.Commit();
					return retVal;
				}
				catch
				{
					trans.Rollback();
					throw;
				}
			}
		}

		public static T AsTransaction<T>(
			this IDbCon source,
			IsolationLevel isolationLevel,
			Func<IDbBatch, T> func)
		{
			var batch = source.CreateDbBatch();
			batch.Connection.OpenSafe(batch.Db);

			using (var trans = batch.Connection.BeginTransaction(isolationLevel))
			{
				try
				{
					T retVal = func(batch.SetTransaction(trans));
					trans.Commit();
					return retVal;
				}
				catch
				{
					trans.Rollback();
					throw;
				}
			}
		}
	}
}