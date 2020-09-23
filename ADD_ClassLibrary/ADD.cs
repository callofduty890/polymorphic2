using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADD_ClassLibrary
{
    //1.规定接口
    [ComVisible(true)]//可访问性允许
    [Guid("7DA8270F-79EC-4513-9119-23110F644F02")]
    public interface IMyClass
    {
        int Add(int a, int b);
    }

    //2.实现接口
    [ComVisible(true)]//可访问性允许
    [Guid("42AE81D8-FF96-42B8-AC87-23BE65D351DD")]
    [ProgId("ADD.IMyClass")]//在系统中起别名，方便用户使用
    public class ADD: IMyClass
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
