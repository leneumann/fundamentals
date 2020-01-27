using src.dataStructures.hashTable;
using Xunit;

namespace test.dataStructure.hashTable
{
    public class HashTableTest
    {
        [Fact]
        public void GivenAnElementWhenAddToHashTableThenGet()
        {
            //Given
            CustomHashTable<string> hashTable = new CustomHashTable<string>();
            //When
            hashTable.Add(3, "teste 1");
            hashTable.Add(4378, "teste 2");
            hashTable.Add(999999999, "teste 3");

            var actual = hashTable.Search(4378);

            //Then
            Assert.Equal("teste 2", actual);
        }

        [Fact]
        public void GivenAnValidKeyWhenAddToHashTableThenSearchKeyAValueIsFound()
        {
            //Given
            CustomHashTable<string> hashTable = new CustomHashTable<string>();
            //When
            hashTable.Add(3, "teste 1");
            hashTable.Add(4378, "teste 2");
            hashTable.Add(999999999, "teste 3");
            hashTable.Add(28359889863, "document of person");


            var actual = hashTable.Search(28359889863);

            //Then
            Assert.Equal("document of person", actual);
        }

        [Fact]
        public void GivenAValidHashTableWhenSearchAInexistentKeyThenReturnEmpty()
        {
        
            //Given
            CustomHashTable<string> hashTable = new CustomHashTable<string>();
            
            //When
            hashTable.Add(3, "teste 1");
            hashTable.Add(4378, "teste 2");
            hashTable.Add(999999999, "teste 3");
            hashTable.Add(28359889863, "document of person");


            var actual = hashTable.Search(4859540);

            //Then
            Assert.Equal(null, actual);
        }
    }
}