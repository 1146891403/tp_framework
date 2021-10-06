using System;

namespace TP.Data.EntityFramework.Entities
{
    public interface ITraceable
    {
        //long Id { get; set; }

        string CreatorId { get; set; }

        ApplicationUser Creator { get; set; }

        DateTime CreateDate { get; set; }

        string ModificatorId { get; set; }

        ApplicationUser Modificator { get; set; }

        DateTime ModifyDate { get; set; }
    }
}