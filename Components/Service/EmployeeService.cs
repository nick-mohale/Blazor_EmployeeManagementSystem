namespace EmployeeManagementSystem.Components.Model
{
    public class EmployeeService
    {
        private List<EmployeeModel> employees;

        public EmployeeService()
        {
            employees = new List<EmployeeModel>
            {
                new EmployeeModel { Id = 1, FirstName = "John", LastName = "Doe", Email = "john@example.com", HireDate = DateTime.Now, DepartmentId = 101 },
                new EmployeeModel { Id = 2, FirstName = "Jane", LastName = "Smith", Email = "jane@example.com", HireDate = DateTime.Now, DepartmentId = 102 },
            };
        }
        public List<EmployeeModel> GetEmployees()
        {
            return employees;
        }


        public EmployeeModel GetEmployeeById(int id)
        {
            return employees.FirstOrDefault(e => e.Id == id);
        }
    }
}
