using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DataAccessLayer.Service
{
    public interface IService
    {
        DataTable getAll();
        int delete(string code);
        DataTable get(string code);
    }
}
