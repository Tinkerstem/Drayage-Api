using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel;

namespace DrayageApi.Models
{
    public class LoadPost
    {
        //Find the foreign Key for this Model

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Load Post Date is required")]
        [Display(Name = "Load Post Date")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime LoadPostDate;


        public enum ContainerTypeValue { 
            [Description("Dry")] Dry, 
            [Description("Reefer Standard")] Reefer_Standard, 
            [Description("Reefer High Cube")] Reefer_High_Cube, 
            [Description("Open Top")] Open_Top, 
            [Description("High Cube")] High_Cube, 
            [Description("Tank")] Tank }
        [Required]
        [DisplayName("Container Type")]
        public ContainerTypeValue ContainerType { get; set; }


        public enum ContainerSizeValue {
            [Description("Twenty Feet")] TwentyFeet,
            [Description("Fourty Feet")] FourtyFeet,
            [Description("Fourty Five Feet")] FourtyFiveFeet, 
            [Description("Fifty Feet")] FiftyThreeFeet }
        [Required]
        [DisplayName("Container Size")]
        public ContainerSizeValue ContainerSize { get; set; }


        public enum FreightTypeValue { Ocean, Air, Intermodal }
        [Required]
        [DisplayName("Freight Type")]
        public FreightTypeValue FreightType { get; set; }


        public enum CargoTypeValue { FCL, FTL }
        [Required]
        [DisplayName("Cargo Type")]
        public CargoTypeValue CargoType { get; set; }


        public enum FreightCategoryValue { Import, Export}
        [Required]
        [DisplayName("Freight Category")]
        public FreightCategoryValue FreightCategory { get; set; }



        [Required]
        [DisplayName("Container Number")]
        public int ContainerNumber { get; set; }


        [Required]
        [DisplayName("Cargo Weight(Kg)")]
        public string CargoWeightInKg { get; set; }


        [Required]
        [DisplayName("Cargo Weight(lbs)")]
        public string CargoWeightInLbs { get; set; }

        [Required]
        [DisplayName("Origin Country")]
        public string OriginCountry { get; set; }


        [Required]
        [DisplayName("Origin City")]
        public string OriginCity { get; set; }


        [Required]
        [DisplayName("Origin Port")]
        public string OriginPort { get; set; }


        [Required]
        [DisplayName("Origin ZIP Code")]
        [RegularExpression(@"^[a-z0-9][a-z0-9\- ]{0,10}[a-z0-9]$", ErrorMessage = "Origin ZIP is not valid")]
        public string OriginZipcode { get; set; }
        
        [Required]
        [DisplayName("Destination Country")]
        public string DestCountry { get; set; }


        [Required]
        [DisplayName("Destination City")]
        public string DestCity { get; set; }


        [Required]
        [StringLength(150, ErrorMessage = "The {0} value cannot exceed {1} characters. ")]
        [DisplayName("Destination Port")]
        public string DestPort { get; set; }


        [Required]
        [RegularExpression(@"^[a-z0-9][a-z0-9\- ]{0,10}[a-z0-9]$", ErrorMessage = "Destination ZIP is not valid")]
        [DisplayName("Destination ZIP")]
        public string DestZipcode { get; set; }


        [Required]
        [StringLength(250)]
        [DisplayName("Full Delivery Location")]
        public string FullDeliveryLocation { get; set; }


        [Required]
        [Range(0.1, 3000.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        [DisplayName("Estimated Total Mile(s)")]
        public int EstimatedTotalMile { get; set; }


        [Required]
        [Range(0.1, 3000.00, ErrorMessage = "Price must be between 0.01 and 100.00")]
        [DisplayName("Estimated Total Km")]
        public int EstimatedKilometer { get; set; }


        [Required]
        public bool IsExport { get; set; }


    }
}
