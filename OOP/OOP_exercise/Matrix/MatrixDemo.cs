using System;

namespace Exercise
{
    static class MatrixDemo
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(5, 5);
            Matrix m2 = new Matrix(5, 5);
            Matrix m3;

            Console.WriteLine("Матрица m1: ");
            m1.RandomFill();
            m1.ShowMatrix();
            
            Console.WriteLine("\nМатрица m2: ");
            m2.RandomFill();
            m2.ShowMatrix();
            
            Console.WriteLine("\nРезультат сложения матриц: ");
            m3 = m1 + m2;
            m3.ShowMatrix();
            
            Console.WriteLine("\nУмножение матрицы m1 на число 1.5: ");
            m3 = m1 * 1.5;
            m3.ShowMatrix();
            
            Console.WriteLine("\nУмножение матриц m1 * m2: ");
            m3 = m1 * m2;
            m3.ShowMatrix();
        }
    }
}
