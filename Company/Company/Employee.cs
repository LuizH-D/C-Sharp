using System.Globalization;


namespace Company {
    class Employee {
        // Atributtes
        public int Id { get; private set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        // Constructors
        public Employee(int id, string name, double salary) {
            
            Id = id;
            Name = name;
            Salary = salary;

            
        }

        // Methods

        public void IncreaseSalary(double percentage) {
            Salary += (percentage * Salary) / 100;
        }

        public override string ToString() {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";

        }
    }
}
