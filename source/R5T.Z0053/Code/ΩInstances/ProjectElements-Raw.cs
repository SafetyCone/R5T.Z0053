using System;


namespace R5T.Z0053.Raw
{
    public class ProjectElements : IProjectElements
    {
        #region Infrastructure

        public static IProjectElements Instance { get; } = new ProjectElements();


        private ProjectElements()
        {
        }

        #endregion
    }
}
