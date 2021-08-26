using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Apotheosis.Models;

namespace Apotheosis.Services
{
    public interface IService<T>
    {
        List<T> Get();
        T Get(string id);
        T Get(Expression expression);
        T Create(T character);
        T Update(T character);
        T Delete(T character);
        T Delete(string id);
        T Delete(object querey);
    }
}
