using Lab06ConsoleProgram;

namespace Lab04UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Return_Lion_sound()
        {
            // Arrange
            Lion lion = new Lion("Simba", 15, "Meat", "Zoo");

            // Act
            string sound = lion.Sound();

            // Assert
            Assert.Equal("Lion's sound is roaring", sound);
        }
        [Fact]
        public void Lion_Sleep_Returns()
        {
            // Arrange
            Lion lion = new Lion("Simba", 15, "Meat", "Zoo");

            // Act
            string sleep = lion.Sleep();

            // Assert
            Assert.Equal("Lion is Sleeping", sleep);
        }


        [Fact]
        public void Return_Tiger_sound()
        {
            // Arrange
            Tiger tiger = new Tiger("Tony", 15, "Meat", "Zoo");

            // Act
            string sound = tiger.Sound();

            // Assert
            Assert.Equal("Tiger's sound is roaring", sound);
        }
        [Fact]
        public void Tiger_Eat_Returns()
        {
            // Arrange
            Tiger tiger = new Tiger("Tony", 15, "Meat", "Zoo");

            // Act
            string sleep = tiger.Eat();

            // Assert
            Assert.Equal("Tiger eats meat", sleep);
        }

        [Fact]
        public void Snake_Eat_Returns()
        {
            // Arrange
            Snake snake = new Snake("Nagini", 15, "Meat", "Zoo");

            // Act
            string eat = snake.Eat();

            // Assert
            Assert.Equal("Snake is eating", eat);
        }

        [Fact]
        public void Snake_Sound_Returns()
        {
            // Arrange
            Snake snake = new Snake("Nagini", 15, "Meat", "Zoo");

            // Act
            string eat = snake.Sound();

            // Assert
            Assert.Equal("Snake's sound is hissing", eat);
        }



        [Fact]
        public void Crocodile_Sleep_Returns()
        {
            // Arrange
            Crocodile crocodile = new Crocodile("Species", 15, "Meat", "Zoo");

            // Act
            string eat = crocodile.Sleep();

            // Assert
            Assert.Equal("Crocodile is sleeping", eat);
        }

        [Fact]
        public void Crocodile_Sound_Returns()
        {
            // Arrange
            Crocodile crocodile = new Crocodile("Species", 15, "Meat", "Zoo");

            // Act
            string eat = crocodile.Sound();

            // Assert
            Assert.Equal("Crocodile's sound is hissing", eat);
        }


        [Fact]
        public void Eggle_Sleep_Returns()
        {
            // Arrange
            Eagle eagle = new Eagle("Aquila", 15, "Meat", "Zoo");

            // Act
            string eat = eagle.Sleep();

            // Assert
            Assert.Equal("Eagle is sleeping", eat);
        }

        [Fact]
        public void Eggle_Sound_Returns()
        {
            // Arrange
            Eagle eagle = new Eagle("Aquila", 15, "Meat", "Zoo");

            // Act
            string eat = eagle.Sound();

            // Assert
            Assert.Equal("Eagle's sound is Pealing", eat);
        }



        [Fact]
        public void Penguin_Sleep_Returns()
        {
            // Arrange
            Penguin penguin = new Penguin("Pingu", 15, "Meat", "Zoo");

            // Act
            string eat = penguin.Sleep();

            // Assert
            Assert.Equal("Penguin is sleeping", eat);
        }

        [Fact]
        public void Penguin_Sound_Returns()
        {
            // Arrange
            Penguin penguin = new Penguin("Pingu", 15, "Meat", "Zoo");

            // Act
            string eat = penguin.Sound();

            // Assert
            Assert.Equal("Penguin's sound is honking", eat);
        }


    }
}