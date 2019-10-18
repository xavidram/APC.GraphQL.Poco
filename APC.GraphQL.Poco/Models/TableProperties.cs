using System;

namespace APC.GraphQL.Poco.Models
{

	public class TableProperties
	{
		public string ColumnName { get; set; }
		public string DataType { get; set; }
		public int MaxLength { get; set; }
		public bool IsPrimaryKey { get; set; }

		public Type GetColumnType()
		{
			return Type.GetType(DataType);
		}
	}

}