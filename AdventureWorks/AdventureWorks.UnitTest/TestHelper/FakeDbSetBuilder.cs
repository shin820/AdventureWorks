using System;

namespace AdventureWorks.UnitTest.TestHelper
{
    public class FakeDbSetBuilder<T> where T : class
    {
        public GenericFakeDbSet<T, TKey> Build<TKey>(Func<T, TKey> keySelector)
        {
            return new GenericFakeDbSet<T, TKey>(keySelector);
        }
    }

    public static class FakeDbSetBuilder
    {
        public static FakeDbSetBuilder<T> New<T>() where T : class
        {
            return new FakeDbSetBuilder<T>();
        }
    }
}