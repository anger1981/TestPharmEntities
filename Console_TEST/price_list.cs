//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Console_TEST
{
    using System;
    using System.Collections.Generic;
    
    public partial class price_list
    {
        public Nullable<int> Id_Price_list { get; set; }
        public int Id_Pharmacy { get; set; }
        public int Id_Product { get; set; }
        public Nullable<decimal> Price { get; set; }
        public System.DateTime Date_upd { get; set; }
        public bool ChaOfIntOfAdm { get; set; }
        public System.DateTime Actual { get; set; }
        public bool EditingOfEditor { get; set; }
        public bool Is_deleted { get; set; }
        public bool Is_privilege { get; set; }
    
        public virtual Pharmacy Pharmacy { get; set; }
    }
}
