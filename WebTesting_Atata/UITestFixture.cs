using Atata;
using NUnit.Framework;

namespace WebTesting_Atata
{
    [TestFixture]
    [Parallelizable(ParallelScope.Self)]
    public abstract class UiTestFixture
    {
        protected static AtataConfig Config => AtataConfig.Current;
        
        [SetUp]
        public void Setup()
        {
            AtataContext.Configure().ApplyJsonConfig<AtataConfig>().Build();
        }
        
        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}