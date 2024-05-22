using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H4SoftwareTestTestProject
{
    public class FileTest
    {
        [Fact]
        public void File_IsCreated()
        {
            // Arrange
            var projectRoot = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(projectRoot, "startup-log.txt");
            
            // Act
            startupLog();

            // Assert
            Assert.True(File.Exists(filePath));
        }


        void startupLog()
        {
            var projectRoot = Directory.GetCurrentDirectory();
            var filePath = Path.Combine(projectRoot, "startup-log.txt");
            using (var writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"Application started at: {DateTime.Now}");
            }
        }
    }
}
