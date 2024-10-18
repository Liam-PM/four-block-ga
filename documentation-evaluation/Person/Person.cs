namespace documentation_evaluation.person
{
    /// <summary>
    /// Represents a person with basic information.
    /// </summary>
    /// <remarks>
    /// This class encapsulates the fundamental attributes of a person,
    /// including their name and age. It can be used as a base class for
    /// more specific person-related classes or as a standalone entity
    /// for basic person representation.
    /// </remarks>
    public class Person
    {
        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        /// <value>
        /// A string representing the person's name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the age of the person.
        /// </summary>
        /// <value>
        /// An integer representing the person's age in years.
        /// </value>
        /// <exception cref="System.ArgumentOutOfRangeException">
        /// Thrown when the age is set to a negative value.
        /// </exception>
        public int Age { get; set; }
    }
}
