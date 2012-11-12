using System.Collections.Generic;

using NUnit.Framework;

namespace ConcurrentList.Tests
{
    [TestFixture]
    public class ConcurrentListTests : ListTestsBase
    {
        protected override IList<int> CreateList()
        {
            return new ConcurrentList<int>();
        }
    }
}
