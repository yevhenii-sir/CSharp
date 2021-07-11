using System;

namespace Exercise.TrainsClassesAndIntf
{
    public class FastTrain : Train, ITypeTrain
    {
        public string TypeTrain { get; set; }
        
        public FastTrain(string name, string typeTrain, double power, int numCarriage) : base(name, power, numCarriage)
        {
            TypeTrain = typeTrain;
        }

        public void ShowTypeTrain()
        {
            Console.WriteLine(TypeTrain);
        }

        public override void ShowTrainInfo()
        {
            Console.WriteLine($"Название поезда: {Name}\n" +
                              $"Класс: {TypeTrain}\n" +
                              $"Мочность поезда: {Power}\n" +
                              $"Количество вагонов: {NumCarriage}\n");
        }
    }
}
