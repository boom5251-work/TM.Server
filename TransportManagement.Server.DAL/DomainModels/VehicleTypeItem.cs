using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransportManagement.Server.DAL.DomainModels.Base;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель типа транспортного средства.
    /// </summary>
    [Table("VehicleTypes")]
    [Index(nameof(UniqueKey), IsUnique = true)]
    [Index(nameof(UniqueKey), IsUnique = true)]
    public sealed class VehicleTypeItem
    {
        /// <summary>
        /// Уникальный идентификатор типа транспортного средства.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Уникальный номер.
        /// </summary>
        [Required]
        public int UniqueKey { get; set; }

        /// <summary>
        /// Уникальное название.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string UniqueName { get; set; } = string.Empty;


        /// <summary>
        /// Тип транспортного средства.
        /// </summary>
        [NotMapped]
        public VehicleType Type => (VehicleType)UniqueKey;
    }
}