namespace BasicLearnCSharp
{
    public class PropAcces
    {
        private int prop;

        public PropAcces()
        {
            prop = 0;
        }

        public int MyProp
        {
            get
            {
                return prop;
            }
            private set
            {
                prop = value;
            }
        }

        public void IncProp()
        {
            MyProp++;
        }
    }
}
