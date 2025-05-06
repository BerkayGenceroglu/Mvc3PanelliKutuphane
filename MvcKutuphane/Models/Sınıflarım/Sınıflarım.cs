using MvcKutuphane.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;

namespace MvcKutuphane.Models.Sınıflarım
{
    public class Sınıflarım
    {
        public IEnumerable<TBLKITAP> Kitaplar { get; set; }
        public IEnumerable<TBLHAKKIMDA> Hakkımda { get; set; }
        //Her ikisi de koleksiyon(list gibi) veri tutuyor ama sadece foreach ile gezilebilirlik garantisi veren IEnumerable<T> kullanılmış.Bu kodda sen TBLKITAP ve TBLHAKKIMDA tablolarına ait verileri tutan, dolaşılabilir (foreach ile gezilebilen) koleksiyonlar tanımlıyorsun. Büyük ihtimalle bunları bir ViewModel'de kullanıyor ve sayfaya veri gönderiyorsun.
        //}
    }
}