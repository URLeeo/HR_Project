using HrProject.Business.Abstracts;
using HrProject.Business.Exceptions;
using HrProject.Core.Entities;
using System.Xml.Linq;

namespace HrProject.Business.Implementations;

public class DepartmentService : IDepartmentService
{
    private List<Department> _departments;
    public DepartmentService()
    {
        _departments = new List<Department>();
    }
    public void Create(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Name can't be empty");
        }
        var check_department =  _departments.Find(d => d.Name == name);
        if (check_department is not null) 
        {
            throw new AlreadyExsistException("Department with this name is already exist");
        }
        Department department = new Department(name);
        _departments.Add(department);
    }

    public void Delete(int id)
    {
        var department =  _departments.Find(d => d.Id == id);
        if (department is null)
        {
            throw new NotFoundException("This department does not exist");
        }
        //Check if any employee exists in this department
        _departments.Remove(department);
    }

    public List<Department> GetAll()
    {
        return _departments;
    }

    public Department GetById(int id)
    {
        var department = _departments.Find(d => d.Id == id);
        if (department is null)
        {
            throw new NotFoundException("This department does not exist");
        }
        return department;
    }

    public void Update(int id,string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentNullException("Invalid Name");
        }
        var department = _departments.Find(d => d.Id == id);
        if (department is null)
        {
            throw new NotFoundException("This department does not exist");
        }
        var check_department = _departments.Find(d => d.Name == name);
        if (check_department is not null)
        {
            throw new AlreadyExsistException("Department with this name is already exist");
        }
        department.Name = name;
    }
}
