using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyGuru.FastKey.Utilities
{
    public class CrmSettings
    {
        public int AgeingLeadLimit { get; set; } = 30;
        public List<Item> QuickFilter { get; set; }
        public bool FollowUpRemarkOnTaskCompletion { get; set; }
        public int NonAppointmentTaskDailyLimit { get; set; } = 40;
        public int AppointmentTaskDailyLimit { get; set; } = 5;
        public bool CreateNewTaskOnCompletion { get; set; }
        public bool LinkActivitiesWithTask { get; set; }
        public int LeadSourceAttributionModel { get; set; } = 2;
        public int AppointmentReminderTimeInMins { get; set; }
        public bool EnableTasks { get; set; }
        public List<FollowupTask> Tasks { get; set; }
        public SortOptions SortOptions { get; set; } = new SortOptions();
        public List<Options> LostReasons { get; set; }
        public Guid LostReasonId { get; set; }
        public int DefaultBookingLostReason { get; set; } = 1;
        public Guid DefaultStageOnlineLead { get; set; }
        public bool LinkStatusWithStage { get; set; }
        public List<BookingStatusToStageMapping> BookingStatusToStageMappings { get; set; } = new List<BookingStatusToStageMapping>();

    }
    public class Item
    {
        public dynamic Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool Active { get; set; }

        public int Order { get; set; }
    }

    public class FollowupTask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }

    public class SortOrder
    {
        public string Name { get; set; }
        public string Field { get; set; }
        public string Order { get; set; }
        public bool IsDefault { get; set; }
    }

    public class Options
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }


    public class SortOptions
    {
        public List<SortOrderModel> UnitListing { get; set; }
        public List<SortOrderModel> FloorPlan { get; set; }
        public List<SortOrderModel> Approval { get; set; }
        public List<SortOrderModel> LeadListing { get; set; }
        public List<SortOrderModel> DashboardSummary { get; set; }
        public List<SortOrderModel> ActiveLeadsPipeline { get; set; }
        public List<SortOrderModel> FirstContactTime { get; set; }
        public List<SortOrderModel> AcceptanceRate { get; set; }
        public List<SortOrderModel> Transaction { get; set; }
        public List<SortOrderModel> Ballot { get; set; }
    }

    public class SortOrderModel
    {
        public string Name { get; set; }
        public string Field { get; set; }
        public string Order { get; set; }
        public bool IsDefault { get; set; }
    }

    public class BookingStatusToStageMapping
    {
        public Guid StageId { get; set; }
        public string StageName { get; set; }
        public int BookingStatusId { get; set; }
        public string BookingStatusName { get; set; }
    }
}
