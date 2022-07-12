using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using RealityFirst.Models;

namespace RealityFirst.Servicio.Contrato
{
    public interface IServicio<T>
    {
        public IList<T> GetAll();
        public T Get(int id);
        public void Create(T obj);

        public void Update(T obj);
        public void Delete(int id);

    }
}
