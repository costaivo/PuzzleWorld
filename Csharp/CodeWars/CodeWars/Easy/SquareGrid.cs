namespace CodeWars.Easy
{
    public class SquareGrid
    {
        public int [,] squareArray_3 = new int[3,3]
        {
            {1,2,3 },
            {4,5,6 },
            {7,8,9},
        };

        public int [,] squareArray_3_1 = new int[3,3]
        {
            {1,1,1 },
            {1,1,1 },
            {1,2,8},
        };


        public int [,] squareArray_4_1 = new int[4,4]
        {
            {1,1,1,1 },
            {1,1,1,1 },
            {1,2,8,2},
            {1,2,2,2},
        };
        public int [,] squareArray_5_1 = new int[5,5]
        {
            {1,1,1,1,1 },
            {1,1,1,1,1 },
            {1,2,8,2,2},
            {1,2,2,2,4},
            {1,1,1,1,1 },
        };

        public int [,] squareArray_20_1 = new int[20,20]
        {
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1},
            {2,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5},
            {6,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5},
            {5,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,5}
        };

        public int [,] squareArray_5_2 = new int[5,5]
        {
            {5,1,1,1,1 },
            {5,1,1,1,1 },
            {5,2,8,2,2},
            {5,2,2,2,4},
            {5,1,1,1,1 },
        };

        public int [,] squareArray_4 = new int[4,4]
        {
            {1,2,3,4 },
            {5,6,7,8 },
            {9,10,11,12},
            {13,14,15,16 }
        };

        public int FindLargestProduct(int[,] array, int productOfNumbers)
        {
            int largestProduct=0;
            int length = array.GetLength(0);
            for(int i = 0; i < length; i++)
            {
                int j = 0;
                while(j + productOfNumbers <= length)
                {
                    int product1 =array[i,j] * array[i,j+1];
                    int product2 = array[j,i] * array[j+1,i];



                    if(product1 > largestProduct)
                        largestProduct = product1;

                    if(product2 > largestProduct)
                        largestProduct = product2;

                    j++;
                }
            }

            return largestProduct;
        }


        public int FindLargestProduct_4(int[,] array, int productOfNumbers)
        {
            int largestProduct=0;
            int length = array.GetLength(0);
            for(int i = 0; i < length; i++)
            {
                int j = 0;
                while(j + productOfNumbers <= length)
                {
                    int product1 =array[i,j] * array[i,j+1] * array[i,j+2];
                    int product2 = array[j,i] * array[j+1,i] * array[i,j+2];



                    if(product1 > largestProduct)
                        largestProduct = product1;

                    if(product2 > largestProduct)
                        largestProduct = product2;

                    j++;
                }
            }

            return largestProduct;
        }

        public int FindLargestProduct_5(int[,] array, int productOfNumbers)
        {
            int largestProduct=0;
            int length = array.GetLength(0);
            for(int i = 0; i < length; i++)
            {
                int j = 0;
                while(j + productOfNumbers <= length)
                {
                    int product1 =array[i,j] * array[i,j+1] * array[i,j+2]* array[i,j+3];
                    int product2 = array[j,i] * array[j+1,i] * array[j+2,i]* array[j+3,i];



                    if(product1 > largestProduct)
                        largestProduct = product1;

                    if(product2 > largestProduct)
                        largestProduct = product2;

                    j++;
                }
            }

            return largestProduct;
        }

    }
}
