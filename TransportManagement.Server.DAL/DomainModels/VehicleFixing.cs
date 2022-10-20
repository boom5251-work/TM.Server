using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Фиксация транспортного средства.
    /// </summary>
    [Table("VehicleFixing")]
    public sealed class VehicleFixing
    {
        /// <summary>
        /// Уникальный идентификатор фиксации транспортного средства.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Дата и время фиксации.
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Местоположение: широта.
        /// </summary>
        [Required]
        public double Latitude { get; set; }

        /// <summary>
        /// Местоположение: долгота.
        /// </summary>
        [Required]
        public double Longitude { get; set; }

        /// <summary>
        /// Скорость в момент фиксации.
        /// </summary>
        [Required]
        public double Speed { get; set; }

        /// <summary>
        /// Уникальный идентификатор транспортного средства (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Vehicle))]
        public uint VehicleId { get; set; }

        /// <summary>
        /// Уникальный идентификатор маршрута (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Route))]
        public uint RountId { get; set; }


        internal Vehicle? Vehicle { get; set; }

        internal Route? Route { get; set; }
    }
}