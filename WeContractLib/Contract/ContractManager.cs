using System.Reflection;
using WeContractLib.Diagnostics;

namespace WeContractLib.Contract
{
    public class ContractManager : Atlas<Contract>
    {
        
        public ContractManager() : base("Contract")
        {
        }

        public override bool Add(Contract entity)
        {
            if (Exist(entity.CID))
            {
                Logger.Inst.Error($"{_TName} with CID: {entity.CID} already exist!", MethodBase.GetCurrentMethod());
                return false;
            }

            entity.ID = _indexCounter;
            _indexCounter++;

            _listIThings.Add(entity);
            _dictIThings.Add(entity.CID, entity);
            Logger.Inst.Info($@"{_TName} with Customer name:{entity.CustomerName} added to {_TName}Manager!.");
            return true;
        }

    }
}