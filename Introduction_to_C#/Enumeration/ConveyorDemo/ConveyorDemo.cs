namespace BasicLearnCSharp
{
    static class ConveyorDemo
    {
        static void Main(string[] args)
        {
            ConveyorControl c = new ConveyorControl();
            
            c.Conveyor(ConveyorControl.Action.Start);
            c.Conveyor(ConveyorControl.Action.Forward);
            c.Conveyor(ConveyorControl.Action.Reverse);
            c.Conveyor(ConveyorControl.Action.Stop);
        }
    }
}
