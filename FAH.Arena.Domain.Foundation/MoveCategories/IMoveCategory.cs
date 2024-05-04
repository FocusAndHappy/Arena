namespace FAH.Arena.Domain.Foundation.MoveCategories
{
    public interface IMoveCategory
    {
        /// <summary>
        /// The name of the move category
        /// </summary>
        public Category Name { get; }

        /// <summary>
        /// The description of the move category
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// This retrieves the value for the offensive stat
        /// </summary>
        /// <returns>Attack or Special Attack value depending on the implementation</returns>
        public int GetOffensiveStatValue();
    }

    public enum Category
    {
        Physical,
        Special,
        Status
    }

}
