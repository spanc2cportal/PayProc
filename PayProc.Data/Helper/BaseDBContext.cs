namespace PayProc.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using PayProc.Models;
    using PayProc.Models.Mapping;
    using PayProc.Utilities;

    public partial class BaseDBContext : DbContext
    {
        public BaseDBContext()
            : base(AppDomain.CurrentDomain.GetData("ConStrKey").ToString())//this is the connection string name
        {
        }

        public DbSet<AlertType> AlertTypes { get; set; }
        public DbSet<AmountPayType> AmountPayTypes { get; set; }
        public DbSet<ApplicationMenu> ApplicationMenus { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationSetting> ApplicationSettings { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<PayProc.Models.Attribute> Attributes { get; set; }
        public DbSet<AttributeType> AttributeTypes { get; set; }
        public DbSet<Biller> Billers { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientPostType> ClientPostTypes { get; set; }
        public DbSet<ClientTemplate> ClientTemplates { get; set; }
        public DbSet<ClientType> ClientTypes { get; set; }
        public DbSet<CutoffType> CutoffTypes { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<FileUpload> FileUploads { get; set; }
        public DbSet<MemberAccount> MemberAccounts { get; set; }
        public DbSet<MemberActivityLog> MemberActivityLogs { get; set; }
        public DbSet<MemberBill> MemberBills { get; set; }
        public DbSet<MemberBiller> MemberBillers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
        public DbSet<PaymentFlow> PaymentFlows { get; set; }
        public DbSet<PaymentStatu> PaymentStatus { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<ResponseType> ResponseTypes { get; set; }
        public DbSet<RoleMenu> RoleMenus { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Template> Templates { get; set; }
        public DbSet<TemplateAttribute> TemplateAttributes { get; set; }
        public DbSet<TemplateType> TemplateTypes { get; set; }
        public DbSet<UserActivityType> UserActivityTypes { get; set; }
        public DbSet<UserAlert> UserAlerts { get; set; }
        public DbSet<UserStatusType> UserStatusTypes { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Utility> Utilities { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlertTypeMap());
            modelBuilder.Configurations.Add(new AmountPayTypeMap());
            modelBuilder.Configurations.Add(new ApplicationMenuMap());
            modelBuilder.Configurations.Add(new ApplicationRoleMap());
            modelBuilder.Configurations.Add(new ApplicationSettingMap());
            modelBuilder.Configurations.Add(new ApplicationUserMap());
            modelBuilder.Configurations.Add(new AttributeMap());
            modelBuilder.Configurations.Add(new AttributeTypeMap());
            modelBuilder.Configurations.Add(new BillerMap());
            modelBuilder.Configurations.Add(new ClientMap());
            modelBuilder.Configurations.Add(new ClientPostTypeMap());
            modelBuilder.Configurations.Add(new ClientTemplateMap());
            modelBuilder.Configurations.Add(new ClientTypeMap());
            modelBuilder.Configurations.Add(new CutoffTypeMap());
            modelBuilder.Configurations.Add(new FeedbackMap());
            modelBuilder.Configurations.Add(new FileUploadMap());
            modelBuilder.Configurations.Add(new MemberAccountMap());
            modelBuilder.Configurations.Add(new MemberActivityLogMap());
            modelBuilder.Configurations.Add(new MemberBillMap());
            modelBuilder.Configurations.Add(new MemberBillerMap());
            modelBuilder.Configurations.Add(new PaymentMap());
            modelBuilder.Configurations.Add(new PaymentDetailMap());
            modelBuilder.Configurations.Add(new PaymentFlowMap());
            modelBuilder.Configurations.Add(new PaymentStatuMap());
            modelBuilder.Configurations.Add(new PaymentTypeMap());
            modelBuilder.Configurations.Add(new ResponseTypeMap());
            modelBuilder.Configurations.Add(new RoleMenuMap());
            modelBuilder.Configurations.Add(new StateMap());
            modelBuilder.Configurations.Add(new TemplateMap());
            modelBuilder.Configurations.Add(new TemplateAttributeMap());
            modelBuilder.Configurations.Add(new TemplateTypeMap());
            modelBuilder.Configurations.Add(new UserActivityTypeMap());
            modelBuilder.Configurations.Add(new UserAlertMap());
            modelBuilder.Configurations.Add(new UserStatusTypeMap());
            modelBuilder.Configurations.Add(new UserTypeMap());
            modelBuilder.Configurations.Add(new UtilityMap());
        }
    }
}
