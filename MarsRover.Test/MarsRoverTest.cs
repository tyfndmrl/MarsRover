using MarsRover.Core;
using MarsRover.Core.Entities;
using MarsRover.Core.Entities.Enums;
using MarsRover.Core.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MarsRover.Test
{
    [TestClass]
    public class MarsRoverTest
    {
        [TestMethod]
        public void TestScenario_12N_LMLMLMLMM()
        {
            IRover rover = new Rover(new Place(5, 5), new Position(1, 2), Direction.N);
            rover.Process("LMLMLMLMM");
            var output = rover.ToString();

            var expectedOutput = "1 3 N";

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        public void TestScenario_33E_MRRMMRMRRM()
        {
            IRover rover = new Rover(new Place(5, 5), new Position(3, 3), Direction.E);
            rover.Process("MMRMMRMRRM");
            var output = rover.ToString();

            var expectedOutput = "5 1 E";

            Assert.AreEqual(expectedOutput, output);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestScenario_Out_Place()
        {
            IRover rover = new Rover(new Place(5, 5), new Position(4, 4), Direction.W);
            rover.Process("MMM");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestScenario_Set_Position()
        {
            IRover rover = new Rover(new Place(5, 5), new Position(4, 4), Direction.S);
            rover.SetPosition(new Position(5, 6), Direction.W);
        }
    }
}
