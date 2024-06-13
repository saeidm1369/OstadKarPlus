using System;

public interface IRepository<T> where T : class
{
    void Add(T model);
    void Update(T model);
    void Delete(T model);
}
