using System;
using System.Collections.Generic;
using System.Linq;
using Deipax.Core.Common;
using Xunit;

namespace UnitTests.Core
{
    public class SymbolDictionaryTests
    {
        public SymbolDictionary<int> GetSubject()
        {
            var subject = new SymbolDictionary<int>();

            for (int i = 0; i < 100; i++)
            {
                subject.Add(i.ToString(), i);
            }

            return subject;
        }

        [Fact]
        public void GetEnumeratorTest()
        {
            var subject = GetSubject();
            var enumerator = subject.GetEnumerator();
            int count = 0;

            while (enumerator.MoveNext())
            {
                count++;
                var current = enumerator.Current;
                Assert.NotNull(current.Key);
            }

            Assert.Equal(subject.Count, count);
        }

        [Fact]
        public void AddKeyValuePairTest()
        {
            var subject = GetSubject();
            var currentCount = subject.Count;
            subject.Add(KeyValuePair.Create("One", 1));
            Assert.Equal(currentCount + 1, subject.Count);
            Assert.Equal(1, subject["One"]);
        }

        [Fact]
        public void ClearTest()
        {
            var subject = GetSubject();
            Assert.NotEmpty(subject);
            subject.Clear();
            Assert.Empty(subject);
        }
        
        [Fact]
        public void ContainsKeyValuePairTest()
        {
            var subject = GetSubject();
            var kvp = KeyValuePair.Create("1", 1);
            Assert.True(subject.Contains(kvp));
        }

        [Fact]
        public void CopyToTest()
        {
            var subject = GetSubject();
            var array = new KeyValuePair<string, int>[subject.Count];

            Assert.ThrowsAny<ArgumentNullException>(() => subject.CopyTo(null, 0));
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => subject.CopyTo(array, -1));
            Assert.ThrowsAny<ArgumentOutOfRangeException>(() => subject.CopyTo(array, subject.Count + 1));
            Assert.ThrowsAny<ArgumentException>(() => subject.CopyTo(array, 1));

            subject.CopyTo(array, 0);

            array = array
                .ToList()
                .OrderBy(x => x.Value)
                .ToArray();

            for (int i = 0; i < subject.Count; i++)
            {
                Assert.Equal(i.ToString(), array[i].Key);
                Assert.Equal(i, array[i].Value);
            }
        }

        [Fact]
        public void RemoveKeyValuePairTest()
        {
            var subject = GetSubject();
            var count = subject.Count;

            var kvp = KeyValuePair.Create("1", 1);
            Assert.True(subject.Remove(kvp));
            Assert.Equal(count - 1, subject.Count);
        }

        [Fact]
        public void IsReadOnlyTest()
        {
            var subject = GetSubject();
            Assert.False(subject.IsReadOnly);
        }

        [Fact]
        public void AddTest()
        {
            var subject = GetSubject();
            var currentCount = subject.Count;
            subject.Add("One", 1);
            Assert.Equal(currentCount + 1, subject.Count);
            Assert.Equal(1, subject["One"]);
        }

        [Fact]
        public void ContainsKeyTest()
        {
            var subject = GetSubject();
            Assert.True(subject.ContainsKey("1"));
        }

        [Fact]
        public void RemoveTest()
        {
            var subject = GetSubject();
            var count = subject.Count;
            Assert.True(subject.Remove("1"));
            Assert.Equal(count - 1, subject.Count);
        }

        [Fact]
        public void TryGetValueTest()
        {
            var subject = GetSubject();
            Assert.True(subject.TryGetValue("1", out var value));
            Assert.Equal(1, value);
            Assert.False(subject.TryGetValue("HELLO", out value));
        }

        [Fact]
        public void ThisGetSetTest()
        {
            var subject = GetSubject();

            for (int i = 0; i < subject.Count; i++)
            {
                var key = i.ToString();
                Assert.Equal(i, subject[key]);

                subject[key] = i + 1;
                Assert.Equal(i + 1, subject[key]);
            }
        }
    }
}
