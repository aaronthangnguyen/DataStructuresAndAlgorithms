using System.Collections.Generic;
using Xunit;

namespace DataStructures.Tests
{
    public class BinarySearchTreeTest
    {
        [Fact]
        public void ContainsShouldReturnTrue()
        {
            var newBinarySearchTree = new BinarySearchTree(10);
            var actual = newBinarySearchTree.Contains(10);
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ContainsShouldReturnFalse()
        {
            var newBinarySearchTree = new BinarySearchTree(10);
            var actual = newBinarySearchTree.Contains(9);
            var expected = false;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InsertShouldAddNewTreeNode()
        {
            //--- Arrange
            var newBinarySearchTree = new BinarySearchTree(10);
            newBinarySearchTree.Insert(9);

            //--- Act
            var actual = newBinarySearchTree.Contains(9);

            //--- Assert
            var expected = true;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DeleteNodeWithNoChild()
        {
            //--- Arrange
            BinarySearchTree newBinarySearchTree = new(50); // A new way to instantiate an object
            var dataList = new List<int>() {50, 25, 75, 11, 33, 61, 89, 30, 40, 52, 82, 95, 55};
            foreach (var data in dataList)
            {
                newBinarySearchTree.Insert(data);
            }

            //--- Act
            newBinarySearchTree.Delete(55);
            var actual = newBinarySearchTree.Contains(55);

            //--- Assert
            var expected = false;
            Assert.Equal(expected, actual);

        }
    }
}