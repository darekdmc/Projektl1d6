namespace Projektl1d6.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectTwoScores_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "haslo123", 33);
            employee.AddScore(5);
            employee.AddScore(10);

            //act

            var result = employee.Result;

            // assert
            Assert.AreEqual(15, result);

        }


        [Test]
        public void WhenUserCollectThreeScoresv1_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "haslo123", 33);
            employee.AddScore(15);
            employee.SubstractScore(10);
            employee.AddScore(3);

            //act

            var result = employee.Result;

            // assert
            Assert.AreEqual(8, result);

        }

        [Test]
        public void WhenUserCollectThreeScoresv2_ShouldCorrectResult()
        {
            // arrange
            var employee = new Employee("Adam", "haslo123", 33);
            employee.AddScore(5);
            employee.SubstractScore(8);
            employee.SubstractScore(2);

            //act

            var result = employee.Result;

            // assert
            Assert.AreEqual(-5, result);

        }

    }
}