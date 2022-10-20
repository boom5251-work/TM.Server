using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель фиксации остановочного пункта.
    /// </summary>
    [Table("StopFixings")]
    public sealed class StopFixing
    {
        /// <summary>
        /// Уникальный идентификатор фиксации.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Дата и время начала фиксации.
        /// </summary>
        [Required]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Количетсво пассажиров.
        /// </summary>
        [Required]
        public ushort PassengersNumber { get; set; }

        /// <summary>
        /// Уникальный идентификатор остановчного пункта (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Stop))]
        public uint StopId { get; set; }

        /// <summary>
        /// Уникальный идентификатор маршрута (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Route))]
        public uint RouteId { get; set; }

        /// <summary>
        /// Уникальный идентификатор транспортного средства (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Vehicle))]
        public uint VehicleId { get; set; }


        internal Stop? Stop { get; set; }

        internal Route? Route { get; set; }

        internal Vehicle? Vehicle { get; set; }
    }
}