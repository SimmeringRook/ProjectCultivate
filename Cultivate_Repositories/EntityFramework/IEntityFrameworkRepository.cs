using Cultivate_Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cultivate_Repositories.EntityFramework
{
    public interface IEntityFrameworkRepository<T> : IRepository<T> where T : BaseEntity
    {
        void SaveChanges();
    }
}
