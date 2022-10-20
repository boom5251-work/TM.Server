using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель маршрута-остановки.
    /// </summary>
    [Table(nameof(RoutesStops))]
    public sealed class RoutesStops
    {
        /// <summary>
        /// Уникальный идентификатор маршрута-остановки.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Уникальный идентификатор маршрута (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Route))]
        public uint RouteId { get; set; }

        /// <summary>
        /// Уникальный идентификатор остановки (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Stop))]
        public uint StopId { get; set; }


        internal Route? Route { get; set; }

        internal Stop? Stop { get; set; }
    }
}