using System;

namespace DepartmentOfTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("code running: project version " + RoadVehicle.ProjectVersion);

            RoadVehicle v1 = new RoadVehicle(EngineSerialNumber:123);
            Console.WriteLine(v1.Description);


            RoadVehicle v2 = new RoadVehicle(EngineSerialNumber:456);
            Console.WriteLine(v2.Description);

            if ((v1 == null) || (v2 == null))
            {
                Console.WriteLine("borked");
                return;
            }

            Car PrimaryCar = new Car(EngineSerialNumber:999);
            PrimaryCar.HasTowBar = true;
            Console.WriteLine(PrimaryCar.Description);

        }
    }
}
