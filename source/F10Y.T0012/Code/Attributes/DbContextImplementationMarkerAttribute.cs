using System;

using F10Y.T0000;


namespace F10Y.T0012
{
    /// <summary>
    /// Attribute indicating a class is a DB context implementation (a class inheriting from the Entity Framework Core DbContext class with DbSet get-set properties).
    /// </summary>
    /// <remarks>
    /// The marker attribute is useful for surveying DB context implementation classes and building a catalogue of DB context implementations.
    /// </remarks>
    [AttributeUsage(AttributeTargets.Class,
        AllowMultiple = false,
        Inherited = false
    )]
    [MarkerAttributeMarker]
    public class DbContextImplementationMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a class is *not* a DB context implementation class.
        /// This is useful for marking classes that end up canonical DB context implementation code file locations, but are not DB context implementation classes.
        /// </summary>
        public bool Is_DbContextImplementation { get; }


        public DbContextImplementationMarkerAttribute(
            bool is_DbContextImplementation = true)
        {
            this.Is_DbContextImplementation = is_DbContextImplementation;
        }
    }
}
