//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmProject.Enity
{
    using System;
    using System.Collections.Generic;
    
    public partial class TFilm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TFilm()
        {
            this.TOyuncu = new HashSet<TOyuncu>();
        }
    
        public int ID { get; set; }
        public string Poster { get; set; }
        public string Yil { get; set; }
        public string Film { get; set; }
        public Nullable<int> Kategori { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOyuncu> TOyuncu { get; set; }
        public virtual TKategori TKategori { get; set; }
    }
}
