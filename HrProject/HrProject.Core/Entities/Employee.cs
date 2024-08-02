using HrProject.Core.Interfaces;

namespace HrProject.Core.Entities;

public class Employee : IEntity<Guid>
{
    public Guid Id { get; }
    public string Name { get; set; } = null!;
    public string? Lastname { get; set; }
    public int? DepartamentId { get; set; }
    public int PositionId { get; set; }

    public Employee(string name, int departamentId, int positionId, string? lastname = null)
    {
        Name = name;
        DepartamentId = departamentId;
        PositionId = positionId;
        Lastname = lastname;
        Id = new Guid();
    }
}

