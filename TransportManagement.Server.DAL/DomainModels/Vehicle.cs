using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель транспортного средства.
    /// </summary>
    [Table("Vehicles")]
    [Index(nameof(Number), IsUnique = true)]
    public sealed class Vehicle
    {
        /// <summary>
        /// Уникальный идентификатор транспортного средства.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Уникальный номер транспортного средства (госномер).
        /// </summary>
        [Required]
        [MinLength(7)]
        [MaxLength(9)]
        public string Number { get; set; } = string.Empty;

        /// <summary>
        /// Уникальный идентификатор марки транспортного средства (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(VehicleBrand))]
        public uint BrandId { get; set; }


        internal VehicleBrand? VehicleBrand { get; set; }
    }
}