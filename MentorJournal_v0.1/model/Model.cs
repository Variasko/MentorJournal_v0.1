using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorJournal_v0._1.model
{
    public class Activist
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ActivistTypeId { get; set; }
    }

    public class ActivistType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Admin
    {
        public int PersonId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class AttendingClassHours
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public bool IsVisited { get; set; }
        public DateTime Date { get; set; }
    }

    public class DegreeOfKinship
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Dormitory
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int Room { get; set; }
    }

    public class Event
    {
        public int Id { get; set; }
        public int EventTypeId { get; set; }
        public string Target { get; set; }
        public string Result { get; set; }
        public DateTime Date { get; set; }
        public int GroupId { get; set; }
        public int WorkPlanReportId { get; set; }
    }

    public class EventType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        public int Course { get; set; }
        public int MentorId { get; set; }
        public int SpecificationId { get; set; }
        public bool IsByuget { get; set; }
        public string RecruitmentYear { get; set; }
    }

    public class GroupSocialStatus
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int SocialStatusId { get; set; }
        public DateTime EditDate { get; set; }
    }

    public class HobbieType
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class IndividualWorkWithParrent
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int ParrentId { get; set; }
        public string Topic { get; set; }
        public string Result { get; set; }
    }

    public class IndividualWorkWithStudent
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int StudentId { get; set; }
        public string Topic { get; set; }
        public string Result { get; set; }
    }

    public class Mentor
    {
        public int PersonId { get; set; }
        public string Category { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }

    public class MentorObservationList
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public string Characteristic { get; set; }
    }

    public class Parrent
    {
        public int PersonId { get; set; }
        public int DegreeOfkinshipId { get; set; }
        public string Phone { get; set; }
        public int StudentId { get; set; }
    }

    public class ParrentConference
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Present { get; set; }
        public int Absent { get; set; }
        public int GoodAbsentReason { get; set; }
        public string Target { get; set; }
        public string Result { get; set; }
        public int GroupId { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string PassportSerial { get; set; }
        public string PassportNumber { get; set; }
        public string SNILS { get; set; }
        public string INN { get; set; }
        public bool Gender { get; set; }
        public string Phone { get; set; }
        public string RegistrationAddress { get; set; }
        public string LivingAddress { get; set; }
    }

    public class SocialStatus
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Specification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Qualification { get; set; }
        public string NameReduction { get; set; }
        public string QualificationReduction { get; set; }
    }

    public class Student
    {
        public int PersonId { get; set; }
        public bool IsRemoved { get; set; }
        public DateTime? DateRemoved { get; set; }
    }

    public class StudentHobbie
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int HobbieTypeId { get; set; }
        public bool IsInColledge { get; set; }
    }

    public class StudentInGroup
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public DateTime Date { get; set; }
    }

    public class WorkPlanReport
    {
        public int Id { get; set; }
        public string Target { get; set; }
        public string JobAnalysisReport { get; set; }
        public string SemesterNumber { get; set; }
        public string LearningYear { get; set; }
    }
    public class Temp
    {
        public bool isAdmin { get; set; }
        public int personId { get; set; }
    }
}
