//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TA.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListClientShowInfoTour
    {
        public int Id { get; set; }
        public Nullable<int> ClientId { get; set; }
        public Nullable<int> ToursId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
