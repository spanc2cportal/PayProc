namespace PayProc.Domain.Manager.Converter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Omu.ValueInjecter;

    public class IdToTypeIdConverter : ConventionInjection
    {
        protected override bool Match(ConventionInfo curVal)
        {
            return curVal.SourceProp.Name == "Id" && curVal.TargetProp.Name == curVal.Source.Type.Name + "TypeId";
        }
    }
}
