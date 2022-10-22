using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель депо.
    /// </summary>
    [Table("Depots")]
    [Index(nameof(Name), IsUnique = true)]
    public class Depot
    {
        /// <summary>
        /// Уникальнай идентификатор депо.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Уникальное название депо.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Вместимость депо (максимальное количество транспортных средств).
        /// </summary>
        [Required]
        public ushort Capacity { get; set; }

        /// <summary>
        /// Уникальный идентификатор типа транспортного средства (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(VehicleType))]
        public uint VehicleTypeId { get; set; }


        internal VehicleTypeItem? VehicleType { get; set; }
    }
}