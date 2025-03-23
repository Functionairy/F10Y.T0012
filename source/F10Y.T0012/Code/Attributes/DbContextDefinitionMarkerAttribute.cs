using System;

using F10Y.T0000;


namespace F10Y.T0012
{
    /// <summary>
    /// Attribute indicating an interface is a DB context definition (an interface defining get-only Entity Framework Core DbSet properties).
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying DB context definition interfaces and building a catalogue of DB context definitions.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Interface,
        AllowMultiple = false,
        Inherited = false
    )]
    [MarkerAttributeMarker]
    public class DbContextDefinitionMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that an interface is *not* a DB context definition interface.
        /// This is useful for marking interfaces that end up canonical DB context definition code file locations, but are not DB context definition interfaces.
        /// </summary>
        public bool Is_DbContextDefinition { get; }


        public DbContextDefinitionMarkerAttribute(
            bool is_DbContextDefinition = true)
        {
            this.Is_DbContextDefinition = is_DbContextDefinition;
        }
    }
}
