using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace DapperUnitOfWork.Repositories
{
    internal abstract class RepositoryBase
    {
        protected OracleTransaction Transaction { get; private set; }
        protected OracleConnection Connection { get { return Transaction.Connection; } }

        public RepositoryBase(OracleTransaction transaction)
        {
            Transaction = transaction;
        }
    }
}
