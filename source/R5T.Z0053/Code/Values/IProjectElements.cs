using System;
using System.Threading.Tasks;

using R5T.L0032.T000;
using R5T.T0131;


namespace R5T.Z0053
{
    [ValuesMarker]
    public partial interface IProjectElements : IValuesMarker
    {
        /// <inheritdoc cref="Z0052.Z000.IProjectFileXmlTexts.Missing_NoWarn"/>
        public IProjectElement Missing_NoWarn => Instances.ProjectElementOperations.From(
            Instances.ProjectFileXmlTexts.Missing_NoWarn);

        /// <inheritdoc cref="Z0052.Z000.IProjectFileXmlTexts.N_003"/>
        public IProjectElement Has_NoWarnAndGitHubPrivateRepository => Instances.ProjectElementOperations.From(
            Instances.ProjectFileXmlTexts.N_003);
    }
}
