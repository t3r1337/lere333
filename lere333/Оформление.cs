//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lere333
{
    using System;
    using System.Collections.Generic;
    
    public partial class Оформление
    {
        public int id_оформления { get; set; }
        public Nullable<int> Мебель { get; set; }
        public Nullable<int> Заказ { get; set; }
        public Nullable<int> Количество { get; set; }
    
        public virtual Заказ Заказ1 { get; set; }
        public virtual Мебель Мебель1 { get; set; }
    }
}
