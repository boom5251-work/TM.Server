using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель маршрута.
    /// </summary>
    [Table("Routes")]
    [Index(nameof(Name), IsUnique = true)]
    public sealed class Route
    {
        /// <summary>
        /// Уникальный идентификатор маршрута.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Уникальное название маршрута.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Отображаемое название маршрута.
        /// </summary>
        [Required]
        [MinLength(1)]
        [MaxLength(10)]        
        public string DisplayName { get; set; } = string.Empty;

        /// <summary>
        /// Описание маршрута (не обязательно).
        /// </summary>
        [MaxLength(255)]
        public string? Description { get; set; }

        /// <summary>
        /// Уникальный идентификатор типа транспортных средств на маршруте (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(VehicleType))]
        public uint VehicleTypeId { get; set; }


        internal VehicleTypeItem? VehicleType { get; set; }
    }
}