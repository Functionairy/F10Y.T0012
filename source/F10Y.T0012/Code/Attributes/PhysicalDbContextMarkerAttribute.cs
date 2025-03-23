using System;

using F10Y.T0000;


namespace F10Y.T0012
{
    /// <summary>
    /// Attribute indicating a class is a physical DB context implementation (an Entity Framework Core DbContext class that actually managages a physical database via migrations).
    /// The marker attribute is useful for surveying physical DB context implementation classes and building a catalogue of physical DB context implementations.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class,
        AllowMultiple = false,
        Inherited = false
    )]
    [MarkerAttributeMarker]
    public class PhysicalDbContextMarkerAttribute : Attribute
    {
        /// <summary>
        /// Allows specifying that a class is *not* a physical DB context implementation class.
        /// This is useful for marking classes that end up canonical physical DB context implementation code file locations, but are not physical DB context implementation classes.
        /// </summary>
        public bool Is_PhysicalDbContextImplementation { get; }


        public PhysicalDbContextMarkerAttribute(
            bool is_PhysicalDbContextImplementation = true)
        {
            this.Is_PhysicalDbContextImplementation = is_PhysicalDbContextImplementation;
        }
    }
}
