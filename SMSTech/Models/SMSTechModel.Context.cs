﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMSTech.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SMST4MEntities1 : DbContext
    {
        public SMST4MEntities1()
            : base("name=SMST4MEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Academic_ClassRoutine_Days> Academic_ClassRoutine_Days { get; set; }
        public virtual DbSet<Academic_ClassSubjects> Academic_ClassSubjects { get; set; }
        public virtual DbSet<Academic_Holydays> Academic_Holydays { get; set; }
        public virtual DbSet<Academic_Periods> Academic_Periods { get; set; }
        public virtual DbSet<AllowanceAmount> AllowanceAmounts { get; set; }
        public virtual DbSet<AllowanceType> AllowanceTypes { get; set; }
        public virtual DbSet<AssessmentFindingDetail> AssessmentFindingDetails { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassLevel> ClassLevels { get; set; }
        public virtual DbSet<Document_files> Document_files { get; set; }
        public virtual DbSet<Education> Educations { get; set; }
        public virtual DbSet<Exam> Exams { get; set; }
        public virtual DbSet<Exams_ClassSubjects> Exams_ClassSubjects { get; set; }
        public virtual DbSet<Exams_DateSheet> Exams_DateSheet { get; set; }
        public virtual DbSet<Exams_DateSheet_Detail> Exams_DateSheet_Detail { get; set; }
        public virtual DbSet<Exams_DateSheet_Names> Exams_DateSheet_Names { get; set; }
        public virtual DbSet<Exams_GeneralRemarks> Exams_GeneralRemarks { get; set; }
        public virtual DbSet<Exams_Grade> Exams_Grade { get; set; }
        public virtual DbSet<Exams_GroupCollections> Exams_GroupCollections { get; set; }
        public virtual DbSet<Exams_Tests> Exams_Tests { get; set; }
        public virtual DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public virtual DbSet<ExpenseHead> ExpenseHeads { get; set; }
        public virtual DbSet<Experience> Experiences { get; set; }
        public virtual DbSet<FeeAssignment> FeeAssignments { get; set; }
        public virtual DbSet<FeeChallan> FeeChallans { get; set; }
        public virtual DbSet<FeeChallanDetail> FeeChallanDetails { get; set; }
        public virtual DbSet<FeeReceiptDetail> FeeReceiptDetails { get; set; }
        public virtual DbSet<FeeReceipt> FeeReceipts { get; set; }
        public virtual DbSet<FeeRecurring> FeeRecurrings { get; set; }
        public virtual DbSet<FeeType> FeeTypes { get; set; }
        public virtual DbSet<FingerPrint> FingerPrints { get; set; }
        public virtual DbSet<Labels_Internal> Labels_Internal { get; set; }
        public virtual DbSet<Labels_Navigation> Labels_Navigation { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<PersonalizedFee> PersonalizedFees { get; set; }
        public virtual DbSet<Rank> Ranks { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<SalaryIncrement> SalaryIncrements { get; set; }
        public virtual DbSet<SalaryMonth> SalaryMonths { get; set; }
        public virtual DbSet<SalaryReceiptDetail> SalaryReceiptDetails { get; set; }
        public virtual DbSet<SalaryReceipt> SalaryReceipts { get; set; }
        public virtual DbSet<SchoolSetting> SchoolSettings { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<SecurityFee> SecurityFees { get; set; }
        public virtual DbSet<SMS_Networks> SMS_Networks { get; set; }
        public virtual DbSet<SMS_Queue> SMS_Queue { get; set; }
        public virtual DbSet<SMS_Templates> SMS_Templates { get; set; }
        public virtual DbSet<SMS_Triggers> SMS_Triggers { get; set; }
        public virtual DbSet<StartsFrom0AfterEachBilling> StartsFrom0AfterEachBilling { get; set; }
        public virtual DbSet<Student_Attendance> Student_Attendance { get; set; }
        public virtual DbSet<Student_Family> Student_Family { get; set; }
        public virtual DbSet<Student_Groups> Student_Groups { get; set; }
        public virtual DbSet<Student_Guardian_Relation> Student_Guardian_Relation { get; set; }
        public virtual DbSet<Student_Guardians> Student_Guardians { get; set; }
        public virtual DbSet<Student_Relations> Student_Relations { get; set; }
        public virtual DbSet<StudentPayment> StudentPayments { get; set; }
        public virtual DbSet<StudentPayments_History> StudentPayments_History { get; set; }
        public virtual DbSet<StudentPaymentsMeta> StudentPaymentsMetas { get; set; }
        public virtual DbSet<StudentsMeta> StudentsMetas { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Students_temp> Students_temp { get; set; }
        public virtual DbSet<TB_RegisterStudent> TB_RegisterStudent { get; set; }
        public virtual DbSet<Academic_ClassRoutine> Academic_ClassRoutine { get; set; }
        public virtual DbSet<Academic_Courses> Academic_Courses { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Academic_Days> Academic_Days { get; set; }
        public virtual DbSet<AssessmentArea> AssessmentAreas { get; set; }
        public virtual DbSet<AssessmentColor> AssessmentColors { get; set; }
        public virtual DbSet<Academic_Subjects> Academic_Subjects { get; set; }
        public virtual DbSet<AssessmentCategory> AssessmentCategories { get; set; }
        public virtual DbSet<Academic_CourseStudents> Academic_CourseStudents { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<AssessmentFindingMaster> AssessmentFindingMasters { get; set; }
        public virtual DbSet<Capability> Capabilities { get; set; }
        public virtual DbSet<Capabilities_Advance> Capabilities_Advance { get; set; }
        public virtual DbSet<Commitment> Commitments { get; set; }
        public virtual DbSet<Document_names> Document_names { get; set; }
        public virtual DbSet<EmployeeAttendance> EmployeeAttendances { get; set; }
        public virtual DbSet<EmployeeLoan> EmployeeLoans { get; set; }
        public virtual DbSet<EmployeeLoans_History> EmployeeLoans_History { get; set; }
        public virtual DbSet<EmployeePayment> EmployeePayments { get; set; }
        public virtual DbSet<EmployeePayments_History> EmployeePayments_History { get; set; }
        public virtual DbSet<EmployeePenalty> EmployeePenalties { get; set; }
        public virtual DbSet<EmployeeRefundableType> EmployeeRefundableTypes { get; set; }
        public virtual DbSet<EmployeeSecurityInstallment> EmployeeSecurityInstallments { get; set; }
        public virtual DbSet<EmployeeSecurityWithDraw> EmployeeSecurityWithDraws { get; set; }
        public virtual DbSet<Exams_Groups> Exams_Groups { get; set; }
        public virtual DbSet<Exams_Marks> Exams_Marks { get; set; }
        public virtual DbSet<ExpenseAmount_History> ExpenseAmount_History { get; set; }
        public virtual DbSet<ExpenseAmount> ExpenseAmounts { get; set; }
    }
}
