using System.Reflection;

namespace EmployeeMovieBooking.Database
{
    public static class AssemblyReference
    {
        /// <summary>
        /// Reference to the assembly of the project
        /// </summary>
        public static readonly Assembly Assembly = typeof(AssemblyReference).Assembly;
    }
}
