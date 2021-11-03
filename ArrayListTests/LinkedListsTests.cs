using Lists;
using NUnit.Framework;
using System;

namespace List.Tests
{
    public class LinkedListsTests
    {
        private LinkedList _linklist;

        [SetUp]
        public void Setup()
        {
            _linklist = new LinkedList();
        }

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 5, new int[] { 1, 2, 3, 4, 5 })]
        public void AddLastTests(int[] array, int value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            arrayToTest.AddLast(value);
            int[] actual = arrayToTest.ToArray();

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, 5, new int[] { 5 })]
       

        [TestCase(new int[] { 1, 2, 3 }, 4, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 4, new int[] { 4, 1, 2, 3, 1 })]
        public void AddFirstTests(int[] array, int value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            arrayToTest.AddFirst(value);
            int[] actual = arrayToTest.ToArray();

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 3 }, 2, 4, new int[] { 1, 2, 4, 3 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 3, 3, new int[] { 1, 2, 3, 3, 1 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 4, 3, new int[] { 1, 2, 3, 1, 3 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 0, 3, new int[] { 3, 1, 2, 3, 1 })]
        public void AddAtTests(int[] array, int idx, int value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            arrayToTest.AddAt(idx, value);
            int[] actual = arrayToTest.ToArray();

            // act

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 1 }, 2, new int[] { 6, 6, 6 }, new int[] { 1, 2, 6, 6, 6, 3, 1 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 0, new int[] { 6, 6, 6 }, new int[] { 6, 6, 6, 1, 2, 3, 1 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 4, new int[] { 6, 6, 6 }, new int[] { 1, 2, 3, 1, 6, 6, 6 })]
        public void AddAtListTests(int[] array, int idx, int[] value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            LinkedList listToAdd = new LinkedList(value);
            int[] arrayToAdd = listToAdd.ToArray();
            //arrayToTest.AddAt(idx, arrayToAdd);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 0, 1, 4 }, 10, 5, new int[] { 4 })]
        public void AddAtNegativeTests(int[] array, int idx, int value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.AddAt(idx, value));


        }
        [TestCase(new int[] { 1, 2, 3, 1 }, 5, new int[] { 6, 6, 6 }, new int[] { 1, 2, 3, 1, 6, 6, 6 })]
        public void AddAtListNegativeTests(int[] array, int idx, int[] value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            LinkedList listToAdd = new LinkedList(value);
            int[] arrayToAdd = listToAdd.ToArray();

            //Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.AddAt(idx, arrayToAdd));


        }
      

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3 })]
        public void AddFirstListTests(int[] array, int[] value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            LinkedList listToAdd = new LinkedList(value);
            arrayToTest.AddFirst(listToAdd);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        public void AddFirstListNegativeTests(int[] array, int[] value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            LinkedList listToAdd = new LinkedList(value);

            // act
            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.AddFirst(listToAdd));

        }

        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 1, 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        public void AddLastListTests(int[] array, int[] value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            LinkedList listToAdd = new LinkedList(value);
            arrayToTest.AddLast(listToAdd);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { }, new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { }, new int[] { 1, 2, 3 })]
        public void AddLastListNegativeTests(int[] array, int[] value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);
            LinkedList listToAdd = new LinkedList(value);

            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.AddLast(listToAdd));


        }

        [TestCase(new int[] { 1, 2, 3, 1 }, 0, 3, new int[] { 3, 2, 3, 1 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 3, 6, new int[] { 1, 2, 3, 6 })]
        [TestCase(new int[] { 1, 2, 3, 1 }, 2, 5, new int[] { 1, 2, 5, 1 })]
        public void SetTests(int[] array, int idx, int value, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.Set(idx, value);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 3, 1 }, new int[] { 2, 3, 1 })]
        [TestCase(new int[] { 5, 5, 5 }, new int[] { 5, 5 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveFirstTests(int[] array, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveFirst();

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveFirstNegativeTests(int[] array, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.RemoveFirst());

        }

        [TestCase(new int[] { 1, 2, 3, 1 }, new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 1, 5 }, new int[] { 1, 2, 3, 1 })]
        [TestCase(new int[] { 5, 5, 5 }, new int[] { 5, 5 })]
        [TestCase(new int[] { 1 }, new int[] { })]
        public void RemoveLasttTests(int[] array, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveLast();

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { }, new int[] { })]
        public void RemoveLastNegativeTests(int[] array, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.RemoveLast());

        }

        [TestCase(new int[] { 1, 2, 3, 1, 5 }, 2, new int[] { 1, 2, 1, 5 })]
        [TestCase(new int[] { 1, 2, 3, 1, 5 }, 4, new int[] { 1, 2, 3, 1 })]
        [TestCase(new int[] { 5, 5, 5 }, 2, new int[] { 5, 5 })]
        [TestCase(new int[] { 1 }, 0, new int[] { })]
        public void RemoveAtTests(int[] array, int idx, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveAt(idx);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 1 }, 5, new int[] { })]
        public void RemoveAtNegativeTests(int[] array, int idx, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.RemoveAt(idx));

        }

        [TestCase(new int[] { 5, 5, 5 }, 2, new int[] { 5 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 1, 2, 4, 5, 6, 6 }, 4, new int[] { 6, 6 })]
        public void RemoveFirstMultipleTests(int[] array, int n, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveFirstMultiple(n);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 5, 5, 5 }, 2, new int[] { 5 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 1, 2, 4, 5, 6, 6 }, 4, new int[] { 1, 2 })]
        public void RemoveLastMultipleTests(int[] array, int n, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveLastMultiple(n);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 5, 5, 6, 6 }, 5, new int[] { 1, 2, 6, 6 })]
        [TestCase(new int[] { 1, 2, 5, 5, 6, 6 }, 6, new int[] { 1, 2, 5, 5 })]
        [TestCase(new int[] { 1, 2, 5, 5, 6, 6, 5 }, 5, new int[] { 1, 2, 6, 6 })]
        public void RemoveAllTests(int[] array, int n, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveAll(n);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 2, 4, 5, 6, 6 }, 2, 2, new int[] { 1, 2, 6, 6 })]
        [TestCase(new int[] { 1, 2, 4, 5, 6, 6 }, 2, 0, new int[] { 1, 2, 4, 5, 6, 6 })]
        [TestCase(new int[] { 1, 2, 4, 5, 6, 6 }, 2, 4, new int[] { 1, 2 })]
        [TestCase(new int[] { 1, 2, 4, 5, 6, 6 }, 0, 4, new int[] { 6, 6 })]
        public void RemoveAtMultipleTests(int[] array, int idx, int n, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveAtMultiple(idx, n);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 2, 4, 5, 6, 6 }, 1, 5, new int[] { 6, 6 })]
        public void RemoveAtMultipleNegativeTests(int[] array, int idx, int n, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            Assert.Throws(typeof(IndexOutOfRangeException), () => arrayToTest.RemoveAtMultiple(idx, n));

        }
        [TestCase(new int[] { 5, 5, 5 }, 5, new int[] { 5, 5 })]
        [TestCase(new int[] { 1 }, 1, new int[] { })]
        [TestCase(new int[] { 1, 4, 5, }, 4, new int[] { 1, 5 })]
        [TestCase(new int[] { 1, 4, 5, 4 }, 4, new int[] { 1, 5, 4 })]
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 4, new int[] { 1, 5, 4, 4 })]
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 6, new int[] { 1, 4, 5, 4, 4 })]
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 5, new int[] { 1, 4, 5, 4, 4 })]
        public void RemoveFirstValueTests(int[] array, int val, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveFirst(val);

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 6, -1)]
        public void RemoveFirstValueNegativeTests(int[] array, int val, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.RemoveFirst(val);
            // act
            int actual = arrayToTest.RemoveFirst(val);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 5, 5, 5 }, 5, 0)]
        [TestCase(new int[] { 1 }, 1, 0)]
        [TestCase(new int[] { 1, 4, 5, }, 4, 1)]
        [TestCase(new int[] { 1, 4, 5, 4 }, 4, 1)]
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 5, 2)]
        public void RemoveFirstValueReturnTests(int[] array, int val, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.RemoveFirst(val);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 5, true)]
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 9, false)]
        public void ContainsTests(int[] array, int val, bool expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            bool actual = arrayToTest.Contains(val);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 5, 2)]
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 9, -1)]
        public void IndexOfTests(int[] array, int val, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.IndexOf(val);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 1)]
        [TestCase(new int[] { 5, 6, 4, 5, 4, 4 }, 5)]
        public void GetFirstTests(int[] array, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.GetFirst();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 4)]
        [TestCase(new int[] { 5, 6, 4, 5, 4, 9 }, 9)]
        public void GetLastTests(int[] array, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.GetLast();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 1, 4)]
        [TestCase(new int[] { 5, 6, 4, 5, 3, 9 }, 4, 3)]
        public void GetTests(int[] array, int val, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.Get(val);

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 5)]
        [TestCase(new int[] { 5, 6, 4, 5, 3, 9 }, 9)]
        public void MaxTests(int[] array, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.Max();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 1)]
        [TestCase(new int[] { 5, 6, 4, 5, 3, 9 }, 3)]
        public void MinTests(int[] array, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.Min();

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 2)]
        [TestCase(new int[] { 5, 6, 4, 5, 3, 9 }, 5)]
        public void IndexOfMaxTests(int[] array, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.IndexOfMax();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 5, 4, 4 }, 0)]
        [TestCase(new int[] { 5, 6, 4, 5, 3, 9 }, 4)]
        public void IndexOfMinTests(int[] array, int expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);


            // act
            int actual = arrayToTest.IndexOfMin();

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase(new int[] { 1, 4, 3, 2, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 4, 3, 2, 5, 7 }, new int[] { 1, 2, 3, 4, 5, 7 })]
        public void SortTests(int[] array, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.Sort();

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
        [TestCase(new int[] { 1, 4, 3, 2, 5 }, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 4, 3, 2, 5, 7 }, new int[] { 7, 5, 4, 3, 2, 1 })]
        public void SortDescTests(int[] array, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.SortDesc();

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        } 
        [TestCase(new int[] { 1, 4, 3, 2, 5, 7 }, new int[] { 7, 5, 2, 3, 4, 1 })]
        [TestCase(new int[] { 1, 4, 3, 6, 2, 5, 7 }, new int[] { 7, 5, 2, 6, 3, 4, 1 })]
        public void ReverseTests(int[] array, int[] expected)
        {
            // arrange
            LinkedList arrayToTest = new LinkedList(array);

            arrayToTest.Reverse();

            // act
            int[] actual = arrayToTest.ToArray();

            // assert
            Assert.AreEqual(expected, actual);

        }
    }
}