using System.ComponentModel.DataAnnotations;

namespace MvxSpinnerEnumSample.Core.Models
{
    public class Equipment
    {
        public enum Type
        {
            Detector,
            [Display(Name = "Vegetation Clearance")]
            VegetationClearance,
            Removal,
            Engaging
        }
    }
}