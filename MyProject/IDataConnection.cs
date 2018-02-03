using MyProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProjectLibrary
{
    public interface IDataConnection
    {
        UserModel CreatePerson(UserModel userModel);
    }
}
