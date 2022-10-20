namespace TransportManagement.Server.DAL.DomainModels.Base
{
    /// <summary>
    /// Действие по проездному билету.
    /// </summary>
    public enum TicketAction
    {
        /// <summary>
        /// Посадка.
        /// </summary>
        Boarding,
        /// <summary>
        /// Пересадка.
        /// </summary>
        Transfer,
        /// <summary>
        /// Высадка.
        /// </summary>
        GettingOff
    }
}