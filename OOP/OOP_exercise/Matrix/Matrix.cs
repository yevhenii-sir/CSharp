using System;

namespace Exercise
{
    public class Matrix
    {
        private double[,] matr;

        public int Rows { get; private set; }
        
        public int Columns { get; private set; }

        public Matrix(int rows, int columns)
        {
            matr = new double[rows, columns];

            Rows = rows;
            Columns = columns;
        }

        public static Matrix operator +(Matrix op1, Matrix op2)
        {
            if (op1.Rows == op2.Rows & op1.Columns == op2.Columns)
            {
                Matrix result = new Matrix(op1.Rows, op1.Columns);

                for (int i = 0; i < op1.Rows; i++)
                {
                    for (int j = 0; j < op1.Columns; j++)
                    {
                        result.matr[i, j] = op1.matr[i, j] + op2.matr[i,j];
                    }
                }

                return result;
            }
            Console.WriteLine("Матрицы разного размера!!!");
            return new Matrix(1, 1);
        }

        public static Matrix operator *(Matrix op1, double op2)
        {
            Matrix result = new Matrix(op1.Rows, op1.Columns);

            for (int i = 0; i < op1.Rows; i++)
            {
                for (int j = 0; j < op1.Columns; j++)
                {
                    result.matr[i, j] = op1.matr[i, j] * op2;
                }
            }

            return result;
        }

        public void ShowMatrix()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write("{0, 6:#.# }", matr[i, j]);
                }

                Console.WriteLine();
            }
        }

        public static Matrix operator *(Matrix op1, Matrix op2)
        {
            if (op1.Rows == op2.Rows & op1.Columns == op2.Columns)
            {
                Matrix result = new Matrix(op1.Rows, op1.Columns);

                for (int i = 0; i < op1.Rows; i++)
                {
                    for (int j = 0; j < op1.Columns; j++)
                    {
                        result.matr[i, j] = op1.matr[i, j] * op2.matr[i,j];
                    }
                }

                return result;
            }
            
            Console.WriteLine("Матрицы разного размера!!!");
            return new Matrix(1, 1);
        }

        public void RandomFill()
        {
            Random randomN = new Random();
            for (int i = 0; i < Rows; i++)
                for (int j = 0; j < Columns; j++)
                    matr[i, j] = randomN.Next(1, 10);
        }
    }
}
