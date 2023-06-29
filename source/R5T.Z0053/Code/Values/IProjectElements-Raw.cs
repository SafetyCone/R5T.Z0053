using System;
using System.Threading.Tasks;

using R5T.L0032.T000;
using R5T.T0131;


namespace R5T.Z0053.Raw
{
    /// <summary>
    /// Project project values.
    /// </summary>
    [ValuesMarker]
    public partial interface IProjectElements : IValuesMarker
    {
        /// <inheritdoc cref="Z0052.Z000.IProjectFileXmlTexts.N_001"/>
        public IProjectElement N_001 => Instances.ProjectElementOperations.From(
            Instances.ProjectFileXmlTexts.N_001);

        /// <inheritdoc cref="Z0052.Z000.IProjectFileXmlTexts.R5T_Z0052_Z000_FromString"/>
        public IProjectElement R5T_Z0052_Z000 => Instances.ProjectElementOperations.From(
            Instances.ProjectFileXmlTexts.R5T_Z0052_Z000_FromString);

        public Task<IProjectElement> R5T_Z0052_Z001 => Instances.ProjectElementOperations.From(
            Instances.ProjectFileXmlTexts.R5T_Z0052_Z001_FromFile);
    }
}
