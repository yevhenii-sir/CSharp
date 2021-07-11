namespace Exercise.TrainsClassesAndIntf
{
    public class ListTrain<T> where T : Train, ITypeTrain
    {
        private T[] Trains;

        public int Count { get; set; }

        public ListTrain(int size)
        {
            Trains = new T[size];
            Count = 0;
        }
        
        public bool Add(T trains)
        {
            if (Count == Trains.Length || trains == null) return false;
            
            Trains[Count++] = trains;
            return true;
        }

        public T this[int index] => Trains[index]; 
        
        public void Show()
        {
            for (int i = 0; i < Count; i++)
            {
                Trains[i].ShowTrainInfo();
            }
        }
    }
}
