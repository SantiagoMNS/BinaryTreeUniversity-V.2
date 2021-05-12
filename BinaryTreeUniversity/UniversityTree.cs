using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeUniversity
{
    class UniversityTree
    {
        public PositionNode Root;

        public void CreatePosition(PositionNode parent, Position positionToCreate, string parentPositionName)
        {
            PositionNode newNode = new PositionNode();
            newNode.Position = positionToCreate;

            if (Root == null)

            {

                Root = newNode;
                return;
            }
            if (parent == null)
            {
                return;
            }
            if (parent.Position.name == parentPositionName)
            {

                if (parent.left == null)
                {

                    parent.left = newNode;
                    return;
                }

                parent.Righ = newNode;
                return;
            }

            CreatePosition(parent.left, positionToCreate, parentPositionName);
            CreatePosition(parent.Righ, positionToCreate, parentPositionName);
        }

        public void PrintTree(PositionNode from)
        {

            if (from == null)
            {
                return;
            }
            Console.WriteLine($"{from.Position.name} : ${from.Position.Salary} --- Impuesto:{from.Position.Impuesto} %");

            PrintTree(from.left);
            PrintTree(from.Righ);
        }
        public float addSalaries (PositionNode from)
        {

            if (from == null)
            {
                return 0;
            }
            return from.Position.Salary + addSalaries(from.left) + addSalaries(from.Righ);

            

        }

        public float SalarioMasAlto = 0;
        public float salarioalto(PositionNode from)
        {
            if (from == null)
            {
                return 0;
            }
           
            if (SalarioMasAlto < from.Position.Salary) 
            {
                SalarioMasAlto = from.Position.Salary;
                salarioalto(from.left);
                salarioalto(from.Righ);
            }
            if (from.Position.name == "Rector")
            {
                SalarioMasAlto = 0;
            }
            salarioalto(from.left);
            salarioalto(from.Righ);
            return SalarioMasAlto;
        }
    }
}