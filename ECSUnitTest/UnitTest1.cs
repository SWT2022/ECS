
using NUnit.Framework;
using ReDesignECS;
using NSubstitute;

namespace ECSUnitTest
{
    public class Tests
    {
        private ECS uut;
        private ITempSensor tempSensor;
        private IHeater heater;
        [SetUp]
        public void Setup()
        {
            tempSensor = Substitute.For<ITempSensor>();
            heater = Substitute.For<IHeater>();
            uut = new ECS(15, tempSensor, heater);
            //tempSensor = new FakeTempSensor();
            //heater = new FakeHeater();
            //hello
        }

        [Test]
        public void Test_Temp_20_Heater_Off()
        {

            tempSensor.GetTemp().Returns(20);
            uut.Regulate();
            heater.Received(1).TurnOff();
            ////Arrange
            //uut = new ECS(10, tempSensor, heater);

            ////Act
            //uut.Regulate();

            ////Assert
            //Assert.That(heater.state, Is.EqualTo(false));
        }

        [Test]
        public void Test_Temp_2_Heater_On()
        {
            tempSensor.GetTemp().Returns(2);
            uut.Regulate();
            heater.Received(1).TurnOn();

            ////Arrange

            //uut = new ECS(30, tempSensor, heater);

            ////Act
            //uut.Regulate();

            ////Assert
            //Assert.That(heater.state, Is.EqualTo(true));
        }
        [Test]
        public void Test_GetCurTemp_20()
        {
            ////Arrange

            //uut = new ECS(30, tempSensor, heater);

            ////Act
            ////Assert
            //Assert.That(uut.GetCurTemp(), Is.EqualTo(20));
        }
        [Test]
        public void RunSelfTest_TempSelfTestTrue_HeatSelfTestTrue()
        {
            // Arrange
            tempSensor.RunSelfTest().Returns(true);
            tempSensor.RunSelfTest().Returns(true);
            // Assert
            Assert.That(uut.RunSelfTest, Is.True);

        }
    }
}