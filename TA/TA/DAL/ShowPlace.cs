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
    
    public partial class ShowPlace
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShowPlace()
        {
            this.ImagesShowPlaces = new HashSet<ImagesShowPlace>();
            this.PointInTours = new HashSet<PointInTour>();
        }
    
        public int Id { get; set; }
        public string ShowPlaceName { get; set; }
        public decimal Price { get; set; }
        public Nullable<int> CityId { get; set; }
    
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ImagesShowPlace> ImagesShowPlaces { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PointInTour> PointInTours { get; set; }
    }
}
