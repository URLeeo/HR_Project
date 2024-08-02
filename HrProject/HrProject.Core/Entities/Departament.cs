using HrProject.Core.Interfaces;

namespace HrProject.Core.Entities;

public class Departament : IEntity<int>
{
    public int Id { get; }
    public string Name { get; set; } = null!;

    private static int _id;
    public Departament(string name)
    {
        Id=_id++;
        Name = name;
    }
}
