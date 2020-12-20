using Nota;
using Xunit;

namespace XUnitTestNota
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal("Ok", NotaMusic.NotaCheck(0.75,"4 4 4 | 4 4 4 | 4 4 4"));
            Assert.Equal("Ok", NotaMusic.NotaCheck(1, "2 2 | 4 4 4 4 | 2 4 4"));
            Assert.Equal("Длина такта на 0,25 меньше размера такта", NotaMusic.NotaCheck(0.75, "4 4 4 | 4 4 | 4 4 4"));
            Assert.Equal("Длина такта на 0,25 больше размера такта", NotaMusic.NotaCheck(0.75, "4 4 4 | 4 4 4 | 4 4 4 4"));
        }

    }

}
