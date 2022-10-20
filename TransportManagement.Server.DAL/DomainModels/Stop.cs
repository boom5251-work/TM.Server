using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель остановочного пункта.
    /// </summary>
    [Table("Stops")]
    public sealed class Stop
    {
        /// <summary>
        /// Уникальный идентификатор остановочного пункта.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Название остановочного пункта.
        /// </summary>
        [Required]
        [MaxLength(255)]
        public string Name { get; set; } = string.Empty;

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
    }
}