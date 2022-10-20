namespace TransportManagement.Server.DAL.DomainModels.Base
{
    /// <summary>
    /// Тип транспортного средства.
    /// </summary>
    public enum VehicleType
    {
        /// <summary>
        /// Трамвай.
        /// </summary>
        Tram,
        /// <summary>
        /// Автобус.
        /// </summary>
        Bus,
        /// <summary>
        /// Троллейбус.
        /// </summary>
        Trolleybus,
        /// <summary>
        /// Монорельс.
        /// </summary>
        Monorail,
        /// <summary>
        /// Судно.
        /// </summary>
        Ship,
        /// <summary>
        /// Такси.
        /// </summary>
        Taxi
    }
}