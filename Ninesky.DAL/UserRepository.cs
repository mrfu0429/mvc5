using Ninesky.IDAL;
using Ninesky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninesky.DAL
{
    /// <summary>
    /// 用户仓库
    /// <remarks>创建：2017.07.03</remarks>
    /// </summary>
    class UserRepository : BaseRepository<User>, InterfaceUserRepository
    {
    }
}
