using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ninesky.DAL
{
    /// <summary>
    /// 上下文简单工厂
    /// <remarks>
    /// 创建：2017.07.05
    /// </remarks>
    /// </summary>
    public class ContextFactory
    {

        /// <summary>
        /// 获取当前数据上下文
        /// </summary>
        /// <returns></returns>
        public static NineskyDbContext GetCurrentContext()
        {
            NineskyDbContext _nContext = CallContext.GetData("NineskyContext") as NineskyDbContext;
            if (_nContext == null)
            {
                _nContext = new NineskyDbContext();
                CallContext.SetData("NineskyContext", _nContext);
            }
            return _nContext;
        }
    }
}
