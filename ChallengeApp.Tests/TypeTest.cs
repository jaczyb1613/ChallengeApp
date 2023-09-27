namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void CheckingIfTwoStringsAreEqual()
        {
            string name = "Marta";
            string name1 = "Marta";

            Assert.AreEqual(name, name1);
        }
        [Test]
        public void CheckingIfTwoIntigersAreEqual()
        {

        int number1 = 7;
        int number2 = 7;

            Assert.AreEqual(number1, number2);

        }
        [Test]
        public void CheckingthatTwoEmployessAreNotEqual()
        {
            
            var employee1 = GetEmployee("Paweł");
            var employee2 = GetEmployee("Jacek");
            
            Assert.AreNotEqual(employee1.Name, employee2.Name);
        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name); 
        }
    }
}
