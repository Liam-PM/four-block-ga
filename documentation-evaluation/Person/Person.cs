using System;

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
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the age is set to a negative value.
        /// </exception>
        public int Age
        {
            get => _age;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Age cannot be negative.");
                }
                _age = value;
            }
        }

        private int _age;

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        public Person()
        {
            // Default constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class with the specified name and age.
        /// </summary>
        /// <param name="name">The name of the person.</param>
        /// <param name="age">The age of the person.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when the name is null or empty.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when the age is negative.
        /// </exception>
        public Person(string name, int age)
        {
            // Validate and set the name
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name cannot be null or empty.");
            }
            Name = name;

            // Set the age using the property to ensure validation
            Age = age;
        }
    }
}
