using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
    //Çıplak Class Kalmasın Standartı. Bir class inherit etmez ya da interface implementasyonu almıyorsa
    //ileride sorun yaşatabilir. Bu yüzden işaretleme eğilimine gideriz.
    //
    
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}
