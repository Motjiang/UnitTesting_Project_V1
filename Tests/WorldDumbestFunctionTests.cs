using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting_Project_V1.Tests
{
    public class WorldDumbestFunctionTests
    {
        public static void WorldDumbestFunction_ReturnsPickachuIfZero_ReturnsString()
        {
            try
            {
                // Arrange
                WorldDumbestFunction worldDumbestFunction = new WorldDumbestFunction();
                int num = 0;

                // Act
                string result = worldDumbestFunction.ReturnsPikachuIfZero(num);

                // Assert
                if (result == "Pikachu")
                {
                    Console.WriteLine("Test Passed");
                }
                else
                {
                    Console.WriteLine("Test Failed");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
