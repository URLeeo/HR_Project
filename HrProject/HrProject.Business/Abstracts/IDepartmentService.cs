﻿using HrProject.Core.Entities;

namespace HrProject.Business.Abstracts;

public interface IDepartmentService
{
    void Create(string name);
    void Update(int id, string name);
    void Delete(int id);
    List<Department> GetAll();
    Department GetById(int id);
}
