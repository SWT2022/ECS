
using NUnit.Framework;
using ReDesignECS;

namespace ECSUnitTest
{
    public class Tests
    {
        private ECS uut;
        private FakeTempSensor tempSensor;
        private FakeHeater heater;
        [SetUp]
        public void Setup()
        {
            tempSensor = new FakeTempSensor();
            heater = new FakeHeater();
            //hello
        }

        [Test]
        public void Test_Temp_20_Heater_Off()
        {
            //Arrange
            uut = new ECS(10, tempSensor, heater);

            //Act
            uut.Regulate();

            //Assert
            Assert.That(heater.state, Is.EqualTo(false));
        }

        [Test]
        public void Test_Temp_2_Heater_On()
        {
            //Arrange

            uut = new ECS(30, tempSensor, heater);

            //Act
            uut.Regulate();

            //Assert
            Assert.That(heater.state, Is.EqualTo(true));
        }
        [Test]
        public void Test_GetCurTemp_20()
        {
            //Arrange

            uut = new ECS(30, tempSensor, heater);

            //Act
            //Assert
            Assert.That(uut.GetCurTemp(), Is.EqualTo(20));
        }
    }
}