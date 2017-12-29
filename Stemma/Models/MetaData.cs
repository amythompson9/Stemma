using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//this is a metadata/buddy class for all of the tables
//mostly the 6 profile questionnaires, but other pages too
//not sure if you have to repeat the namespace line each time
//but it doesn't hurt.

//STILL NEEDED: Media Page!!!

namespace Stemma.Models
{
    [MetadataType(typeof(Relationship.MetaData))]

    public partial class Relationship
    {
        public class MetaData
        {
            //stuff goes here.
            //copied from Relationship.cs (ie, the base model, hidden under tt file)

            public int RelationshipsID { get; set; }
            [Display(Name = "Are you currently married?")]
            public Nullable<bool> CurrentlyMarried { get; set; }
            [Display(Name = "If you're unmarried, are you in a romantic relationship?")]
            public Nullable<bool> InARelationship { get; set; }
            [Display(Name = "Do you have any previous romances you'd like to remember?")]
            public Nullable<bool> PreviousRomance { get; set; }
            [Display(Name = "Do you have children?")]
            public Nullable<bool> HaveChildren { get; set; }
            [Display(Name = "Do you have grandchildren?")]
            public Nullable<bool> HaveGrandchildren { get; set; }
            [Display(Name = "Are there other young people in your life you'd like to remember?")]
            public Nullable<bool> OtherYoungsters { get; set; }
            [Display(Name = "Would you like to commemorate your parents?")]
            public Nullable<bool> HaveParents { get; set; }
            [Display(Name = "Would you like to commemorate your grandparents?")]
            public Nullable<bool> HaveGrandparents { get; set; }
            [Display(Name = "Are there any other adults in your life you'd like to remember?")]
            public Nullable<bool> OtherAdults { get; set; }
            [Display(Name = "Do you have siblings?")]
            public Nullable<bool> HaveSiblings { get; set; }
            [Display(Name = "Do you have other close relatives you'd like to spotlight?")]
            public Nullable<bool> OtherCloseRelatives { get; set; }
            [Display(Name = "Do you have some good friendships you'd like to celebrate?")]
            public Nullable<bool> GoodFriendships { get; set; }
            [Display(Name = "Would you like to reminded about any other loved ones?")]
            public Nullable<bool> EverythingElse { get; set; }

        }
    }
}


namespace Stemma.Models
{
    [MetadataType(typeof(Career.MetaData))]

    public partial class Career
    {
        public class MetaData
        {
            //stuff goes here.
            //copied from Career.cs (ie, the base model, hidden under tt file)

            public int CareerID { get; set; }
            [Display(Name = "")]
            public Nullable<bool> AttendedCollege { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Graduations { get; set; }
            [Display(Name = "")]
            public Nullable<bool> HaveJob { get; set; }
            [Display(Name = "")]
            public Nullable<bool> HadJob { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Accomplishments { get; set; }
            [Display(Name = "")]
            public Nullable<bool> FirstDayOfSchool { get; set; }
            [Display(Name = "")]
            public Nullable<bool> ArmedForces { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Volunteer { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Legacies { get; set; }
            [Display(Name = "")]
            public Nullable<bool> TechSchool { get; set; }
            [Display(Name = "")]
            public Nullable<bool> LicensesCertifications { get; set; }
            [Display(Name = "")]
            public Nullable<bool> FirstJob { get; set; }
            [Display(Name = "")]
            public Nullable<bool> WorstJob { get; set; }
            [Display(Name = "")]
            public Nullable<bool> AnythingElse { get; set; }

        }
    }
}

namespace Stemma.Models
{
    [MetadataType(typeof(Celebration.MetaData))]

    public partial class Celebration
    {
        public class MetaData
        {
            //stuff goes here.
            //copied from Celebration.cs (ie, the base model, hidden under tt file)

            public int CelebrationID { get; set; }
            [Display(Name = "")]
            public Nullable<bool> HolidayRecently { get; set; }
            [Display(Name = "")]
            public Nullable<bool> PartyRecently { get; set; }
            [Display(Name = "")]
            public Nullable<bool> MilestoneRecently { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateChristmas { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateNYE { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateThanksgiving { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateValentine { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateEaster { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateIndependenceDay { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateHalloween { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateMemorialDay { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateLaborDay { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateMothersDay { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateFathersDay { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateChaunakah { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebratePassover { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateRoshHashanah { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelerateYomKippur { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateRamadan { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateEID { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateSTPat { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateBirthdays { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateChineseNewYear { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateQuinceanera { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateBarBatMitzvah { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateDayOfTheDead { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateVeteransDay { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CelebrateCincoDeMayo { get; set; }
            [Display(Name = "")]
            public Nullable<bool> AnythingElse { get; set; }

        }
    }
}

namespace Stemma.Models
{
    [MetadataType(typeof(HobbyTable.MetaData))]

    public partial class HobbyTable
    {
        public class MetaData
        {
            //stuff goes here.
            //copied from HobbyTable.cs (ie, the base model, hidden under tt file)

            public int HobbyID { get; set; }
            [Display(Name = "")]
            public Nullable<bool> PlaySports { get; set; }
            [Display(Name = "")]
            public Nullable<bool> InAShow { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Travel { get; set; }
            [Display(Name = "")]
            public Nullable<bool> OutdoorPerson { get; set; }
            [Display(Name = "")]
            public Nullable<bool> TravelAbroad { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Passions { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Talents { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Trophies { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Exercise { get; set; }
            [Display(Name = "")]
            public Nullable<bool> FamilyVacation { get; set; }
            [Display(Name = "")]
            public Nullable<bool> ChildhoodVacation { get; set; }
            [Display(Name = "")]
            public Nullable<bool> AnythingElse { get; set; }

        }
    }
}

namespace Stemma.Models
{
    [MetadataType(typeof(Memory.MetaData))]

    public partial class Memory
    {
        public class MetaData
        {
            //stuff goes here.
            //copied from Memory.cs (ie, the base model, hidden under tt file)

            public int MemoryID { get; set; }
            [Display(Name = "")]
            public Nullable<bool> BrokenBones { get; set; }
            [Display(Name = "")]
            public Nullable<bool> OwnHome { get; set; }
            [Display(Name = "")]
            public Nullable<bool> DriversLicense { get; set; }
            [Display(Name = "")]
            public Nullable<bool> FirstTooth { get; set; }
            [Display(Name = "")]
            public Nullable<bool> PersonalNickName { get; set; }
            [Display(Name = "")]
            public Nullable<bool> FamilyNickName { get; set; }
            [Display(Name = "")]
            public Nullable<bool> RideBike { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CommitCrime { get; set; }
            [Display(Name = "")]
            public Nullable<bool> BigMove { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Vote { get; set; }
            [Display(Name = "")]
            public Nullable<bool> FamilyTraditions { get; set; }
            [Display(Name = "")]
            public Nullable<bool> EmbarrassingMoment { get; set; }
            [Display(Name = "")]
            public Nullable<bool> ProudestMoments { get; set; }
            [Display(Name = "")]
            public Nullable<bool> ChildhoodCamp { get; set; }
            [Display(Name = "")]
            public Nullable<bool> MemorializeSomeone { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Concerts { get; set; }
            [Display(Name = "")]
            public Nullable<bool> FamilyPet { get; set; }
            [Display(Name = "")]
            public Nullable<bool> CurrentPet { get; set; }
            [Display(Name = "")]
            public Nullable<bool> HSDance { get; set; }
            [Display(Name = "")]
            public Nullable<bool> AnythingElse { get; set; }

        }
    }
}

namespace Stemma.Models
{
    [MetadataType(typeof(WorldEvent.MetaData))]

    public partial class WorldEvent
    {
        public class MetaData
        {
            //stuff goes here.
            //copied from WorldEvent.cs (ie, the base model, hidden under tt file)

            public int WorldEventID { get; set; }
            [Display(Name = "")]
            public Nullable<bool> September11 { get; set; }
            [Display(Name = "")]
            public Nullable<bool> MoonLanding { get; set; }
            [Display(Name = "")]
            public Nullable<bool> NixonResigns { get; set; }
            [Display(Name = "")]
            public Nullable<bool> ElvisDies { get; set; }
            [Display(Name = "")]
            public Nullable<bool> ChallengerExplodes { get; set; }
            [Display(Name = "")]
            public Nullable<bool> WorldWar2Ends { get; set; }
            [Display(Name = "")]
            public Nullable<bool> KennedyDies { get; set; }
            [Display(Name = "")]
            public Nullable<bool> NotableElection { get; set; }
            [Display(Name = "")]
            public Nullable<bool> MLKAssassination { get; set; }
            [Display(Name = "")]
            public Nullable<bool> Y2K { get; set; }
            [Display(Name = "")]
            public Nullable<bool> BerlinWall { get; set; }
            [Display(Name = "")]
            public Nullable<bool> OJSimpsonCarChase { get; set; }
            [Display(Name = "")]
            public Nullable<bool> EndOfProhibition { get; set; }
            [Display(Name = "")]
            public Nullable<bool> AnythingElse { get; set; }
            [Display(Name = "")]
            public Nullable<bool> VietnamWar { get; set; }

        }
    }
}

namespace Stemma.Models
{
    [MetadataType(typeof(EventTable.MetaData))]

    public partial class EventTable
    {
        sealed class MetaData
        {
            //stuff goes here.
            //copied from EventTable.cs (ie, the base model, hidden under tt file)

            public int EventID { get; set; }
            public byte[] DateCreated { get; set; }

            [Display(Name = "Name this event:")]
            public string EventTitle { get; set; }
            [Display(Name = "When did it happen?")]
            //might need to play around in the view
            //so that question applies to m/d/y
            public Nullable<int> EventDay { get; set; }
            public string EventMonth { get; set; }
            public int EventYear { get; set; }
            [Display(Name = "Who would you like to identify at the event?")]
            //hmm -- do we still want this option??
            public string PeopleInvolved { get; set; }
            [Display(Name = "Describe what happened (750 character limit).")]
            public string EventCaption { get; set; }

        }
    }
}

namespace Stemma.Models
{
    [MetadataType(typeof(UserProfile.MetaData))]

    public partial class UserProfile
    {
        sealed class MetaData
        {
            //stuff goes here.
            //copied from UserProfile.cs (ie, the base model, hidden under tt file)

            //not sure if you need to edit anything about the six profiles pages here
            //they SHOULD be updated in their own sections

            public int UserProfileID { get; set; }

            [Display(Name = "What's your birthday? This will start your timeline, so be honest!")]
            //might want to add something to format the date, too
            public System.DateTime Birthdate { get; set; }
            public int RegisterUserID { get; set; }
            public int RelationshipsID { get; set; }
            public int CareerID { get; set; }
            public int CelebrationID { get; set; }
            public int HobbyID { get; set; }
            public int MemoryID { get; set; }
            public int WorldEventID { get; set; }
            public int EventID { get; set; }

        }
    }
}
