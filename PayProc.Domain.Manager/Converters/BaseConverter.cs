using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayProc.Domain.Contract;
using Omu.ValueInjecter;

namespace PayProc.Domain.Manager.Converter
{

    public class BaseConverter<TModelSource, TModelTarget> : IBaseConverter<TModelSource, TModelTarget>
        where TModelSource : class, new()
        where TModelTarget : new()
    {
        public virtual TModelTarget SourceModelToTargetModel(TModelSource modelSource, TModelTarget modelTarget)
        {
            modelTarget.InjectFrom(modelSource);
            return modelTarget;
        }
    }

}
