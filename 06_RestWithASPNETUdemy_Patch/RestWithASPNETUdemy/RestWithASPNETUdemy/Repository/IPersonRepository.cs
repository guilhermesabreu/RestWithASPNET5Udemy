using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNETUdemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable(long id);
        Person Enable(long id);

    }
}
