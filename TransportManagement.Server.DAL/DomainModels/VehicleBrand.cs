using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Марка транспортного средства.
    /// </summary>
    [Table("VehicleBrands")]
    public sealed class VehicleBrand
    {
        /// <summary>
        /// Уникальный идентификатор марки транспортного средства.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Название марки транспортного средства.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Вместимость пассажиров.
        /// </summary>
        [Required]
        public ushort Capacity { get; set; }

        /// <summary>
        /// Максимальная скорость движения.
        /// </summary>
        [Required]
        public double MaxSpeed { get; set; }

        /// <summary>
        /// Уникальный идентификатор транспортного средства (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(VehicleType))]
        public uint VehicleTypeId { get; set; }


        internal VehicleTypeItem? VehicleType { get; set; }
    }
}