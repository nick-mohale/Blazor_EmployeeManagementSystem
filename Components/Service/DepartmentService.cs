
namespace EmployeeManagementSystem.Components.Model
{
	public class DepartmentService
	{
		private List<DepartmentModel> departments;

		public DepartmentService()
		{
			departments = new List<DepartmentModel>
					{
						new DepartmentModel { Id = 1, DepartmentName = "IT Department"},
						new DepartmentModel { Id = 2, DepartmentName = "Sales"},
						new DepartmentModel { Id = 3, DepartmentName = "Support"},
						new DepartmentModel { Id = 4, DepartmentName = "Admin"}
					};
		}

		public List<DepartmentModel> GetDepartments()
		{
			return departments;
		}
		public DepartmentModel GetDepartmentById(int Id)
		{
			return departments.FirstOrDefault(e => e.Id == Id);
		}
	}


}
