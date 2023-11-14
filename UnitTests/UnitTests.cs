using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Darkside_Form.Tests
{
    [TestClass]
    public class Form1Tests
    {
        [TestMethod]
        public void TestButtonClick_DrawCircle_DefaultSize()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "circle";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsNotNull(form.pictureBox1.Image, "Image should not be null");
            // Add more assertions based on your expected behavior for drawing a default-sized circle
        }

        [TestMethod]
        public void TestButtonClick_DrawCircle_CustomSize()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "circle 50";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsNotNull(form.pictureBox1.Image, "Image should not be null");
            // Add more assertions based on your expected behavior for drawing a circle with a custom size
        }

        [TestMethod]
        public void TestButtonClick_DrawSquare_DefaultSize()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "square";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsNotNull(form.pictureBox1.Image, "Image should not be null");
            // Add more assertions based on your expected behavior for drawing a default-sized square
        }

        [TestMethod]
        public void TestButtonClick_DrawSquare_CustomSize()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "square 80 120";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsNotNull(form.pictureBox1.Image, "Image should not be null");
            // Add more assertions based on your expected behavior for drawing a square with custom size
        }

        [TestMethod]
        public void TestButtonClick_DrawTriangle()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "triangle";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsNotNull(form.pictureBox1.Image, "Image should not be null");
            // Add more assertions based on your expected behavior for drawing a triangle
        }

        [TestMethod]
        public void TestButtonClick_Clear()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "clear";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.IsNotNull(form.pictureBox1.Image, "Image should not be null");
            // Add more assertions based on your expected behavior for clearing the image
        }

        [TestMethod]
        public void TestButtonClick_WrongText()
        {
            // Arrange
            Form1 form = new Form1();
            form.textBox1.Text = "invalid command";

            // Act
            form.button1_Click(null, null);

            // Assert
            Assert.AreEqual("Wrong text", form.textBox3.Text, "Text should be set to 'Wrong text'");
            // Add more assertions based on your expected behavior for wrong text
        }

        // Add more test methods for different scenarios
    }
}
