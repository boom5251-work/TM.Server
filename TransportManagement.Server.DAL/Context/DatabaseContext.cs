using Microsoft.EntityFrameworkCore;
using TransportManagement.Server.DAL.DomainModels;

namespace TransportManagement.Server.DAL.Context
{
    /// <summary>
    /// Контекст базы данных приложения.
    /// </summary>
    public class DatabaseContext : DbContext, IDatabaseContext
    {
        /// <summary>
        /// Конструктор с параметрами контекста.
        /// </summary>
        /// <param name="options">Параметры контекста.</param>
        public DatabaseContext(DbContextOptions options) : base(options)
        {
            return;
        }


        internal DbSet<Route>? Routes { get; set; }
        internal DbSet<RoutesStops>? RoutesStops { get; set; }
        internal DbSet<Stop>? Stops { get; set; }
        internal DbSet<StopFixing>? StopFixings { get; set; }
        internal DbSet<Ticket>? Ticket { get; set; }
        internal DbSet<TicketActionItem>? TicketActions { get; set; }
        internal DbSet<TicketTypeItem>? TicketTypes { get; set; }
        internal DbSet<TicketValidation>? TicketValidations { get; set; }
        internal DbSet<Vehicle>? Vehicles { get; set; }
        internal DbSet<VehicleBrand>? VehicleBrands { get; set; }
        internal DbSet<VehicleFixing>? VehicleFixings { get; set; }
        internal DbSet<VehicleTypeItem>? VehicleTypes { get; set; }
    }
}