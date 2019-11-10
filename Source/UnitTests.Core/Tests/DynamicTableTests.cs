using Deipax.Core.Common;
using Xunit;

namespace UnitTests.Core
{
    public class DynamicTableTests
    {
        [Fact]
        public void CreateFromNull()
        {
            DynamicTable table = new DynamicTable(null);
            var names = table.GetNames();

            Assert.NotNull(names);
            Assert.Empty(names);
            Assert.Equal(0, table.GetFieldCount());
            Assert.Equal(-1, table.GetIndex("tmp"));
            Assert.False(table.FieldExists("tmp"));
        }

        [Fact]
        public void CreateFromEmpty()
        {
            DynamicTable table = new DynamicTable(new string[0]);
            var names = table.GetNames();

            Assert.NotNull(names);
            Assert.Empty(names);
            Assert.Equal(0, table.GetFieldCount());
            Assert.Equal(-1, table.GetIndex("tmp"));
            Assert.False(table.FieldExists("tmp"));
        }

        [Fact]
        public void CreateWithOneField()
        {
            DynamicTable table = new DynamicTable(new[] { "tmp" });
            var names = table.GetNames();

            Assert.NotNull(names);
            Assert.Single(names);
            Assert.Equal(1, table.GetFieldCount());
            Assert.Equal(0, table.GetIndex("tmp"));
            Assert.True(table.FieldExists("tmp"));
        }

        [Fact]
        public void AddField()
        {
            DynamicTable table = new DynamicTable(null);
            var names = table.GetNames();

            Assert.NotNull(names);
            Assert.Empty(names);
            Assert.Equal(0, table.GetFieldCount());
            Assert.Equal(-1, table.GetIndex("tmp"));
            Assert.False(table.FieldExists("tmp"));

            table.AddField("tmp");
            names = table.GetNames();

            Assert.NotNull(names);
            Assert.Single(names);
            Assert.Equal(1, table.GetFieldCount());
            Assert.Equal(0, table.GetIndex("tmp"));
            Assert.True(table.FieldExists("tmp"));
        }
    }
}