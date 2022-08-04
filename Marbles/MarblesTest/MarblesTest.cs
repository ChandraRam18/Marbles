namespace MarblesTest
{
    [TestClass]
    public class MarblesTest
    {
        [TestMethod]
        public void TestPalindrome()
        {
            Assert.IsTrue(StringHelper.IsPalindrome("Bob"));
            Assert.IsTrue(StringHelper.IsPalindrome("bob"));
            Assert.IsTrue(StringHelper.IsPalindrome("b-ob"));
            Assert.IsFalse(StringHelper.IsPalindrome("test"));
            Assert.AreEqual(StringHelper.IsPalindrome("bob"), true);
            Assert.IsFalse(StringHelper.IsPalindrome("John Smith"));
            Assert.IsFalse(StringHelper.IsPalindrome("Smith"));
            Assert.IsTrue(StringHelper.IsPalindrome("Bob O' Bob"));
            Assert.IsTrue(StringHelper.IsPalindrome("Bob Dad - Bob"));
        }

        /* [TestMethod]
         public void TestMarbleOrdering()
         {
             Assert.Inconclusive();
         }
       


        [TestMethod]
        public void TestSortAndFilter()
        {
            Assert.Inconclusive();
        }
        */



        [TestMethod]
        public void TestMarbleOrdering()
        {
            Marble redMarble = new Marble(1, "Red", "redMarble", 1.0);
            Marble orangeMarble = new Marble(2, "Orange", "orangeMarble", 1.0);
            Marble yellowMarble = new Marble(3, "Yellow", "yellowMarble", 1.0);
            Marble greenMarble = new Marble(4, "Green", "greenMarble", 1.0);
            Marble blueMarble = new Marble(5, "Blue", "blueMarble", 1.0);
            Marble indigoMarble = new Marble(6, "Indigo", "indigoMarble", 1.0);
            Marble violetMarble = new Marble(7, "Violet", "violetMarble", 1.0);
            Marble aquaMarble = new Marble(7, "Aqua", "aquaMarble", 1.0);


            Assert.AreEqual(redMarble.Ordering, 0);
            Assert.AreEqual(orangeMarble.Ordering, 1);
            Assert.AreEqual(yellowMarble.Ordering, 2);
            Assert.AreEqual(greenMarble.Ordering, 3);
            Assert.AreEqual(blueMarble.Ordering, 4);
            Assert.AreEqual(indigoMarble.Ordering, 5);
            Assert.AreEqual(violetMarble.Ordering, 6);
            Assert.AreEqual(aquaMarble.Ordering, -1);

        }




        [TestMethod]
        public void TestSortAndFilter()
        {
            Marble marble1 = new Marble(1, "Blue", "Bob", 0.5);                             //Yes 
            Marble marble2 = new Marble(2, "Red", "John Smith", 0.25);                        //No 
            Marble marble3 = new Marble(3, "Violet", "Bob O' Bob", 0.5);                      //Yes 
            Marble marble4 = new Marble(4, "Indigo", "Bob Dad-Bob", 0.75);                    //No 
            Marble marble5 = new Marble(5, "Yellow", "John", 0.5);                            //No 
            Marble marble6 = new Marble(6, "Orange", "Bob", 0.25);                            //Yes 
            Marble marble7 = new Marble(7, "Blue", "Smith", 0.5);                             //No 
            Marble marble8 = new Marble(8, "Blue", "Bob", 0.25);                              //Yes 
            Marble marble9 = new Marble(9, "Green", "Bobb Ob", 0.75);                         //Yes 
            Marble marble10 = new Marble(10, "Blue", "Bob", 0.5);                             //Yes 


            List<Marble> inputMarbles = new List<Marble>();

            inputMarbles.Add(marble4);
            inputMarbles.Add(marble1);
            inputMarbles.Add(marble2);
            inputMarbles.Add(marble3);
            inputMarbles.Add(marble5);
            inputMarbles.Add(marble6);
            inputMarbles.Add(marble7);
            inputMarbles.Add(marble8);
            inputMarbles.Add(marble9);
            inputMarbles.Add(marble10);


            List<Marble> OutputMarbles = MarbleProcessor.SortAndFilter(inputMarbles);
            Assert.AreEqual(5, OutputMarbles.Count);
            Assert.AreEqual(9, OutputMarbles[0].ID);
            Assert.AreEqual(1, OutputMarbles[1].ID);
            Assert.AreEqual(10, OutputMarbles[2].ID);
            Assert.AreEqual(4, OutputMarbles[3].ID);
            Assert.AreEqual(3, OutputMarbles[4].ID);


            //9,1,10,4,3

        }



    }
}