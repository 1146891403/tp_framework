using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP.Repository.Utility.Interfaces;
using TP.WL.ERP.Data.Entities.Crm;

namespace TP.WL.ERP.Repository.Crm.Interfaces
{
    public interface IClientWorkflowRepository : IWorkflowRepository<Client, ClientWorkflowLog>
    {
    }
}
