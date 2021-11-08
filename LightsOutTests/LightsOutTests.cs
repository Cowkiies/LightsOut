using Xunit;
using LightsOut;
using System.Windows.Forms;
using System;

namespace LightsOutTests
{
    public class TestsFixture : IDisposable
    {

        public int gridSizeX { get; set; }
        public int gridSizeY { get; set; }
        public LightsOut.LightsOut app { get; set; }

        public TestsFixture()
        {
            this.gridSizeX = 5;
            this.gridSizeY = 5;
            this.app = new(gridSizeX, gridSizeY);
        }

        public void Dispose()
        {

        }
    }

    public class LightsOutTests : IClassFixture<TestsFixture>
    {
        TestsFixture fixture;
        public LightsOutTests(TestsFixture fixture)
        {
            this.fixture = fixture;
        }
        [Fact]
        public void TableInitialized()
        {
            TableLayoutPanel table = fixture.app.Controls.Find("tablePanel", true)[0] as TableLayoutPanel;
            Assert.True(table.ColumnCount == fixture.gridSizeX);
            Assert.True(table.RowCount == fixture.gridSizeY);
        }

        [Fact]
        public void GridInitialised()
        {
            int lightedUpCount = 0;
            for (int i = 1; i < fixture.gridSizeX + 1; i++)
            {
                for (int j = 1; j < fixture.gridSizeY + 1; j++)
                {
                    if (fixture.app.Grid[i, j]) lightedUpCount++;
                }
            }
            Assert.True(lightedUpCount == (fixture.gridSizeX + fixture.gridSizeY) / 2);
        }

        [Fact]
        public void WinConTest()
        {
            Assert.False(fixture.app.WinConCheck());
            for (int i = 1; i < fixture.gridSizeX + 1; i++)
            {
                for (int j = 1; j < fixture.gridSizeY + 1; j++)
                {
                    fixture.app.Grid[i, j] = true;
                }
            }

            Assert.True(fixture.app.WinConCheck());
        }
    }
}
