using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingMVC.Services
{
    public interface IRepo<T>
    {
        IEnumerable<T> GetAll();
        void Add(T t);
        int Login(T t);
        T Get(int id);
        //IEnumerable<T> GetAllById(T t);
        void Update(int id, T t);
    }
}
