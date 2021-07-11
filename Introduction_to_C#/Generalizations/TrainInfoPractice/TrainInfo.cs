using System;
using Exercise.TrainsClassesAndIntf;

namespace Exercise
{
    static class TrainInfo
    {
        private static bool CompareTrain<T>(T ob1, T ob2) where T : Train, IComparable<T>
        {
            if (ob1.CompareTo(ob2) > 0) return true;
            else return false;
        }
        
        static void Main(string[] args)
        {
            ListTrain<FreightTrain> cargTr = new ListTrain<FreightTrain>(3);
            cargTr.Add(new FreightTrain("ЧС4", "Вывозной", 4500.0, 5));
            cargTr.Add((new FreightTrain("Rc", "Сквозной", 3600.0, 15)));
            cargTr.Add(new FreightTrain("Rc3", "Ускореный", 3800.0, 8));
            cargTr.Show();
            
            Console.WriteLine("----------------");

            ListTrain<FastTrain> fstTr = new ListTrain<FastTrain>(2);
            fstTr.Add(new FastTrain("LMS 6229", "Тест1", 4800.0, 4));
            fstTr.Add(new FastTrain("LMS 5921", "Тест2", 4200.0, 17));
            fstTr.Show();
            
            Console.WriteLine("----------------");

            ListTrain<PassengerTrain> psgTr = new ListTrain<PassengerTrain>(2);
            psgTr.Add(new PassengerTrain("ГТ1", "Електрический", 1800.0, 3));
            psgTr.Add(new PassengerTrain("ГП1", "Гидравлический", 600.0, 2));
            psgTr.Show();
            
            Console.WriteLine("----------------");
            Console.WriteLine("Товарный поезд ЧС4 мощнее ГП1 - " + CompareTrain<Train>(cargTr[0], psgTr[1]));
        }
    }
}

/*

Название поезда: ЧС4
Класс: Вывозной
Мочность поезда: 4500
Количество вагонов: 5

Название поезда: Rc
Класс: Сквозной
Мочность поезда: 3600
Количество вагонов: 15

Название поезда: Rc3
Класс: Ускореный
Мочность поезда: 3800
Количество вагонов: 8

----------------
Название поезда: LMS 6229
Класс: Тест1
Мочность поезда: 4800
Количество вагонов: 4

Название поезда: LMS 5921
Класс: Тест2
Мочность поезда: 4200
Количество вагонов: 17

----------------
Название поезда: ГТ1
Класс: Електрический
Мочность поезда: 1800
Количество вагонов: 3

Название поезда: ГП1
Класс: Гидравлический
Мочность поезда: 600
Количество вагонов: 2

----------------
Товарный поезд ЧС4 мощнее ГП1 - True

*/
