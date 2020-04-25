using NUnit.Framework;
using laba_4;


namespace Tests
{
    [TestFixture]
    public class Tests
    {
        //AREA 1
        //start point
        [TestCase(0, 0, 5)]
        //quarter II
        [TestCase(-3, 1, 5)]
        //quarter IV
        [TestCase(3, -2, 5)]
        //border btw quarters
        [TestCase(0, 5, 5)]//btw I-II
        [TestCase(-5, 0, 5)]//btw II-III 
        [TestCase(5, 0, 5)]//btw IV-I

        public void TestPointArea1(double x, double y, double R)
        {
            bool expected = true;
            CircleClass c = new CircleClass();
            bool actual = c.Coordinate(x, y, R);
            Assert.AreEqual(expected, actual);
        }
        //AREA 2
        //quarter I
        [TestCase(4, 1, 5)]
        //quarter III
        [TestCase(-4, -1, 5)]

        [TestCase(0, -5, 5)]//btw III-IV
        public void TestPointArea2(double x, double y, double R)
        {
            bool expected = false;
            CircleClass c = new CircleClass();
            bool actual = c.Coordinate(x, y, R);
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void PossibleToSplit()
        {
            StrClass s = new StrClass();
            string s1 = "The.Savage.Tiger.";
            string expected = "The\nSavage\nTiger\n";
            string actual = s.Split(s1, '.', '\n');
            Assert.AreEqual(actual, expected);
        }
        [Test()]
        public void ImpossibleToSplit()
        {
            StrClass s = new StrClass();
            string s1 = "The.Savage.Tiger.";
            string expected = "The.Savage.Tiger.";
            string actual = s.Split(s1, ' ', '\n');
            Assert.AreEqual(actual, expected);
        }

    }
}
