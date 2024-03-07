
namespace EmployeeManagementSystem.Components.Model
{
	public class DepartmentService
	{
		private List<Department> departments;

		public DepartmentService()
		{
			departments = new List<Department>
					{
						new Department { Id = 1, DepartmentName = "IT Department"},
						new Department { Id = 2, DepartmentName = "Sales"},
						new Department { Id = 3, DepartmentName = "Support"},
						new Department { Id = 4, DepartmentName = "Admin"}
					};
		}

		public List<Department> GetDepartments()
		{
			return departments;
		}


		public Department GetDepartmentById(int Id)
		{
			return departments.FirstOrDefault(e => e.Id == Id);
		}
	}


}
