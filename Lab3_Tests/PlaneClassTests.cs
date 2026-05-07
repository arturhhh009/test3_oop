using Lab3_App;

namespace Lab3_Tests
{
    public class PlaneClassTests
    {
        [Fact]
        public void Constructor_CorrectInitializeProperties()
        {
            PlaneClass plane = new PlaneClass("A123", "ВирЛіт", 150, 840);

            Assert.Equal("A123", plane.Model);
            Assert.Equal("ВирЛіт", plane.Manufacturer);
            Assert.Equal(150, plane.PassengerCapacity);
            Assert.Equal(840, plane.MaxSpeed);
            Assert.True(plane.IsReadyToFly);
        }

        [Fact]
        public void MaxSpeed_Setter_HandleNegativeValues()
        {
            PlaneClass plane = new PlaneClass("A123", "ВирЛіт", -100, 840);

            plane.MaxSpeed = -100;

            Assert.False(plane.IsReadyToFly);
        }

        [Fact]
        public void PassengerCapacity_Setter_HandleNegativeValues()
        {
            PlaneClass plane = new PlaneClass("A123", "ВирЛіт", 150, 800);

            plane.PassengerCapacity = -5;

            Assert.Equal(0, plane.PassengerCapacity);
        }

        [Fact]
        public void Equals_IdenticalObjects_ReturnTrue()
        {
            PlaneClass plane1 = new PlaneClass("A123", "ВирЛіт", 4, 226, true);
            PlaneClass plane2 = new PlaneClass("A123", "ВирЛіт", 4, 226, true);

            Assert.True(plane1.Equals(plane2));
        }

        [Fact]
        public void Equals_DifferentObjects_ReturnFalse()
        {
            PlaneClass plane1 = new PlaneClass("A123", "ВирЛіт", 1, 2100);
            PlaneClass plane2 = new PlaneClass("D045", "ВирЛіт", 1, 1900);

            Assert.False(plane1.Equals(plane2));
        }

        [Fact]
        public void GetHashCode_IdenticalObjects_Equal()
        {
            PlaneClass plane1 = new PlaneClass("123", "ВирЛіт", 20, 850);
            PlaneClass plane2 = new PlaneClass("123", "ВирЛіт", 20, 850);

            Assert.Equal(plane1.GetHashCode(), plane2.GetHashCode());
        }

        [Fact]
        public void ToString_ReturnCorrectFormat()
        {
            PlaneClass plane = new PlaneClass("123", "ВирЛіт", 10, 100, true);

            string result = plane.ToString();

            Assert.Contains("Модель: 123", result);
            Assert.Contains("Виробник: ВирЛіт", result);
            Assert.Contains("Дозволена кількість пасажирів: 10", result);
            Assert.Contains("Максимальна швидкість: 100", result);
            Assert.Contains("Готовність до польоту: True", result);
        }
    }
}