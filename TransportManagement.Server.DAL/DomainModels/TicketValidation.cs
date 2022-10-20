using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TransportManagement.Server.DAL.DomainModels
{
    /// <summary>
    /// Модель обработки билета.
    /// </summary>
    [Table("TicketValidations")]
    public sealed class TicketValidation
    {
        /// <summary>
        /// Уникальный идентификатор модели обработки билета.
        /// </summary>
        [Key]
        public uint Id { get; set; }

        /// <summary>
        /// Стоимость действия по билету.
        /// </summary>
        [Required]
        public double Cost { get; set; }

        /// <summary>
        /// Уникальный идентификатор проездного билета (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(Ticket))]
        public uint TicketId { get; set; }

        /// <summary>
        /// Уникальный идентификатор действия по проездному билету (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(TicketAction))]
        public uint TicketActionId { get; set; }

        /// <summary>
        /// Уникальный идентификатор фиксации оствновчного пункта (внешний ключ).
        /// </summary>
        [ForeignKey(nameof(StopFixing))]
        public uint StopFixingId { get; set; }


        internal Ticket? Ticket { get; set; }

        internal TicketActionItem? TicketAction { get; set; }
        
        internal StopFixing? StopFixing { get; set; }
    }
}