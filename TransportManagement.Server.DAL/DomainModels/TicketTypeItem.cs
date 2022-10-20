using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransportManagement.Server.DAL.DomainModels.Base;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель типа билета.
    /// </summary>
    [Table("TicketTypes")]
    [Index(nameof(UniqueKey), IsUnique = true)]
    public sealed class TicketTypeItem
    {
        /// <summary>
        /// Уникальный идентификатор типа билета.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Уникальный номер.
        /// </summary>
        [Required]
        public int UniqueKey { get; set; }


        /// <summary>
        /// Тип проездного билета.
        /// </summary>
        [NotMapped]
        public TicketType Type => (TicketType)UniqueKey;
    }
}