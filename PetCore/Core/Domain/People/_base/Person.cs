namespace Core.Domain.People._base
{
    public class Person
    {
        #region Personal Information

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        #endregion

        #region Accessibility

        public string Login { get; set; }
        //TODO: Handle permissions / Profiles

        #endregion
    }
}