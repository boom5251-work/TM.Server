using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель проездного билета.
    /// </summary>
    [Table("Tickets")]
    public sealed class Ticket
    {
        /// <summary>
        /// Уникальный идентификатор проездного билета.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Тип проездного билета (внешний ключ).
        /// </summary>
        public uint TypeId { get; set; }


        internal TicketTypeItem? TicketType { get; set; }
    }
}