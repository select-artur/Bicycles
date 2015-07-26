using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bicycles
{
    public class BicycleType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Bicycle> Bicycles { get; set; }
    }

    public class AmortizationType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual List<Bicycle> Bicycles { get; set; }
    }

    //public enum BicycleTypes
    //{
    //    [Display(Name = "BMX")]
    //    BMX,
    //    [Display(Name = "Городской")]
    //    City,
    //    [Display(Name = "Круизер")]
    //    Cruiser,
    //    [Display(Name = "Горный")]
    //    Mountain,
    //    [Display(Name = "Дорожный")]
    //    Road,
    //    [Display(Name = "Туринг")]
    //    Touring
    //}

    //public enum AmortizationTypes
    //{
    //    [Display(Name = "Двухподвес")]
    //    FullSuspension,
    //    [Display(Name = "Хардтейл")]
    //    HardTail,
    //    [Display(Name = "Ригид")]
    //    Rigid
    //}

    public class Bicycle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public int? BicycleTypeId { get; set; }
        public int? AmortizationTypeId { get; set; }

        public virtual BicycleType BicycleType { get; set; }
        public virtual AmortizationType AmortizationType { get; set; }
    }
}
