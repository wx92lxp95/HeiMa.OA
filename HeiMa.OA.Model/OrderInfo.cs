//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HeiMa.OA.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderInfo
    {
        public int Id { get; set; }
        public int UId { get; set; }
        public string OrderNo { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
