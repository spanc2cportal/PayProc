namespace PayProc.Domain.Contract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface IBaseConverter<TModelSource, TModelTarget>
        where TModelSource : class, new()
        where TModelTarget : new()
    {
        TModelTarget SourceModelToTargetModel(TModelSource sourceModel, TModelTarget targetModel);
    }
}
