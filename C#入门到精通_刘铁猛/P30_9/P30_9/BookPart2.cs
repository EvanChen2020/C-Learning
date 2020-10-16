namespace P30_9
{
    using System;
    using System.Collections.Generic;

    // 因为原来定义这个类的地方，如果更新entity，加入的代码会被覆盖掉。而用这种方法。则可以保证新增的代码不会被覆盖掉。
    // partial类还允许同一个类用不同的编程语言去编写
    public partial class Table_1
    {
       public string Report()
        {
            return $"#{this.ID} Name:{this.Name} Price:{this.Price}";
        }
    }
}
