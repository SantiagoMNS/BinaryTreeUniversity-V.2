using System;

namespace BinaryTreeUniversity
{
    class Program
    {
        static void Main(string[] args)
        {
            Position rectorPosition = new Position();
            rectorPosition.name = "Rector";
            rectorPosition.Salary = 1000;
            rectorPosition.Impuesto = 30;

            Position VicFIPosition = new Position();
            VicFIPosition.name = "Vicerector financiero";
            VicFIPosition.Salary = 750;
            VicFIPosition.Impuesto = 25;

            Position ContadorPosition = new Position();
            ContadorPosition.name = "Contador";
            ContadorPosition.Salary = 500;
            ContadorPosition.Impuesto = 20;

            Position JefeFINPosition = new Position();
            JefeFINPosition.name = "Jefe financiero";
            JefeFINPosition.Salary = 610;
            JefeFINPosition.Impuesto = 20;

            Position SecretariaFIN1Position = new Position();
            SecretariaFIN1Position.name = "Secretaria Financiera 1";
            SecretariaFIN1Position.Salary = 350;
            SecretariaFIN1Position.Impuesto = 15;

            Position SecretariaFIN2Position = new Position();
            SecretariaFIN2Position.name = "Secretaria Financiera 2";
            SecretariaFIN2Position.Salary = 310;
            SecretariaFIN2Position.Impuesto = 10;

            Position VicACPosition = new Position();
            VicACPosition.name = "Vicerector Academico";
            VicACPosition.Salary = 780;
            VicACPosition.Impuesto = 25;

            Position JefeRegPosition = new Position();
            JefeRegPosition.name = "Jefe registro";
            JefeRegPosition.Salary = 640;
            JefeRegPosition.Impuesto = 20;

            Position SecreReg1Position = new Position();
            SecreReg1Position.name = "Secretaria de registro 1";
            SecreReg1Position.Salary = 400;
            SecreReg1Position.Impuesto = 15;

            Position SecreReg2Position = new Position();
            SecreReg2Position.name = "Secretaria de registro 2";
            SecreReg2Position.Salary = 360;
            SecreReg2Position.Impuesto = 15;

            Position AsisReg1Position = new Position();
            AsisReg1Position.name = "Asistente de registro 1";
            AsisReg1Position.Salary = 250;
            AsisReg1Position.Impuesto = 10;

            Position AsisReg2Position = new Position();
            AsisReg2Position.name = "Asistente de registro 2";
            AsisReg2Position.Salary = 170;
            AsisReg2Position.Impuesto = 5;

            Position MensajeroPosition = new Position();
            MensajeroPosition.name = "Mensajero";
            MensajeroPosition.Salary = 90;
            MensajeroPosition.Impuesto = 0;

            UniversityTree universityTree = new UniversityTree();
            universityTree.CreatePosition(null, rectorPosition, null);
            universityTree.CreatePosition(universityTree.Root, VicFIPosition, rectorPosition.name);
            universityTree.CreatePosition(universityTree.Root, JefeFINPosition, VicFIPosition.name);
            universityTree.CreatePosition(universityTree.Root, ContadorPosition, VicFIPosition.name);
            universityTree.CreatePosition(universityTree.Root, SecretariaFIN1Position, ContadorPosition.name);
            universityTree.CreatePosition(universityTree.Root, SecretariaFIN2Position, ContadorPosition.name);
            universityTree.CreatePosition(universityTree.Root, VicACPosition, rectorPosition.name);
            universityTree.CreatePosition(universityTree.Root, JefeRegPosition, VicACPosition.name);
            universityTree.CreatePosition(universityTree.Root, SecreReg1Position, JefeRegPosition.name);
            universityTree.CreatePosition(universityTree.Root, SecreReg2Position, JefeRegPosition.name);
            universityTree.CreatePosition(universityTree.Root, AsisReg1Position, SecreReg1Position.name);
            universityTree.CreatePosition(universityTree.Root, AsisReg2Position, SecreReg1Position.name);
            universityTree.CreatePosition(universityTree.Root, MensajeroPosition, AsisReg2Position.name);

            universityTree.PrintTree(universityTree.Root);

            float totalSalary = universityTree.addSalaries(universityTree.Root);

            float salarioalto = universityTree.salarioalto(universityTree.Root);


            Console.WriteLine($"Total salarios: {totalSalary}");
            Console.WriteLine($"Salario más alto: {salarioalto}");

            Console.WriteLine("Promedio del total de salarios: 477,69 ");
            Console.WriteLine("");


            Console.ReadLine();

            
        }
    }
}
