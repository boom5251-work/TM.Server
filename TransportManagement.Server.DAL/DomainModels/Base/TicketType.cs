namespace TransportManagement.Server.DAL.DomainModels.Base
{
    /// <summary>
    /// Тип проездного билета.
    /// </summary>
    public enum TicketType
    {
        /// <summary>
        /// Обычный проездной билет.
        /// </summary>
        Common,
        /// <summary>
        /// Пополняемая транспортная карта.
        /// </summary>
        TransportCard,
        /// <summary>
        /// Карта учащегося.
        /// </summary>
        StudentCard,
        /// <summary>
        /// Социальная карта.
        /// </summary>
        SocialCard,
        /// <summary>
        /// Банковская карта.
        /// </summary>
        BankCard
    }
}