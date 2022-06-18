using System.ComponentModel.DataAnnotations;
using System;

namespace DrayageApi.Models
{
    public class LoadPost
    {
        [Key]
        public int LoadPostId { get; set; }

        [Required]
        public DateTime intLoadPostDate;

        [Required]
        public string ContainerType { get; set; }
        [Required]
        public int ContainerNumber { get; set; }
        [Required]
        public string CargoWeightInKg { get; set; }
        [Required]
        public string CargoWeightInLbs { get; set; }


        [Required]
        public string OriginCity { get; set; }
        [Required]
        public string OriginPort { get; set; }
        [Required]
        public string OriginZipcode { get; set; }
        [Required]
        public string DestCity { get; set; }
        [Required]
        public string DestPort { get; set; }
        [Required]
        public string DestZipcode { get; set; }
        [Required]
        public string FullDeliveryLocation { get; set; }
        [Required]
        public int EstimatedTotalMile { get; set; }
        [Required]
        public int EstimatedKilometer { get; set; }
        [Required]
        public bool IsExport { get; set; }
        [Required]
        public string FreightType { get; set; }







    }
}
