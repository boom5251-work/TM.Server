using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TransportManagement.Server.DAL.DomainModels.Base;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель действия по билету.
    /// </summary>
    [Table("TicketActions")]
    [Index(nameof(UniqueKey), IsUnique = true)]
    public sealed class TicketActionItem
    {
        /// <summary>
        /// Уникальный идетификатор модели действия по билету.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Уникальный номер.
        /// </summary>
        [Required]
        public int UniqueKey { get; set; }


        /// <summary>
        /// Действие по проездному билету.
        /// </summary>
        [NotMapped]
        public TicketAction Action => (TicketAction)UniqueKey;
    }
}