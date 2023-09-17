using Models;
using System.Linq.Expressions;

namespace EcoPower_Logistics.Repository
{
    
        public interface ICustomersRepository : IGenericRepository<Customer>
        {
            //Customer GetMostRecentService();
            Customer GetById(int id);
        IEnumerable<Customer> GetAll();
        IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression);
        void Add(Customer entity);
        void AddRange(IEnumerable<Customer> entities);
        void Remove(Customer entity);
        void RemoveRange(IEnumerable<Customer> entities);
        void Update(Customer entity);
    }

    
}
