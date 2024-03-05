namespace EmployeeManagementSystem.Components.Model
{
    public class EmployeeService
    {
        private List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", HireDate = DateTime.Now, DepartmentId = 101 },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", HireDate = DateTime.Now, DepartmentId = 102 },
            };
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }


        public Employee GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
