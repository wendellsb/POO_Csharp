using POO_Enumerações_Composição.Entities.Enums;
using System.Collections.Generic;

namespace POO_Enumerações_Composição.Entities
{
    internal class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();
        
        public Worker()
        {
        }
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        // cria a função AddContract passando como parametro um contract do tipo HoutContract
        // depois acessa a lista de Contracts e com .Add adiciona o contrato passado por parametro a lista
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // como na função acima porem utilizando o remove para remover um contrato da lista de contratos
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        //income significa ganho
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
