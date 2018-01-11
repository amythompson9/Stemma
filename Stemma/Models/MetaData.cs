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
            [Display(Name = "Did you attend college?")]
            public Nullable<bool> AttendedCollege { get; set; }
            [Display(Name = "Did you graduate from high school or college?")]
            public Nullable<bool> Graduations { get; set; }
            [Display(Name = "Do you currently have a job?")]
            public Nullable<bool> HaveJob { get; set; }
            [Display(Name = "Have you ever had a job?")]
            public Nullable<bool> HadJob { get; set; }
            [Display(Name = "Did anything in your professional life make you proud?")]
            public Nullable<bool> Accomplishments { get; set; }
            [Display(Name = "Do you remember a first day of school -- yours or another's?")]
            public Nullable<bool> FirstDayOfSchool { get; set; }
            [Display(Name = "Did you serve in the Armed Forces?")]
            public Nullable<bool> ArmedForces { get; set; }
            [Display(Name = "Have you done any volunteer work?")]
            public Nullable<bool> Volunteer { get; set; }
            [Display(Name = "Have you made any contributions to local institutions?")]
            public Nullable<bool> Legacies { get; set; }
            [Display(Name = "Do you or did you attend a technical or trade school?")]
            public Nullable<bool> TechSchool { get; set; }
            [Display(Name = "Have you earned any professional licences or certifications?")]
            public Nullable<bool> LicensesCertifications { get; set; }
            [Display(Name = "Would you like to memorialize your first job?")]
            public Nullable<bool> FirstJob { get; set; }
            [Display(Name = "Would you like to remember (or perhaps roast) your worst job?")]
            public Nullable<bool> WorstJob { get; set; }
            [Display(Name = "Is there anything else in the education and career field you'd like to memorialize?")]
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
            [Display(Name = "Have you celebrated any holidays recently?")]
            public Nullable<bool> HolidayRecently { get; set; }
            [Display(Name = "Have you been to any parties recently?")]
            public Nullable<bool> PartyRecently { get; set; }
            [Display(Name = "Have you celebrated any milestones recently?")]
            public Nullable<bool> MilestoneRecently { get; set; }
            [Display(Name = "Do you celebrate Christmas?")]
            public Nullable<bool> CelebrateChristmas { get; set; }
            [Display(Name = "Do you celebrate New Year's Eve?")]
            public Nullable<bool> CelebrateNYE { get; set; }
            [Display(Name = "Do you celebrate Thanksgiving?")]
            public Nullable<bool> CelebrateThanksgiving { get; set; }
            [Display(Name = "Do you celebrate Valentine's Day?")]
            public Nullable<bool> CelebrateValentine { get; set; }
            [Display(Name = "Do you celebrate Easter?")]
            public Nullable<bool> CelebrateEaster { get; set; }
            [Display(Name = "Do you celebrate Independence Day?")]
            public Nullable<bool> CelebrateIndependenceDay { get; set; }
            [Display(Name = "Do you celebrate Halloween?")]
            public Nullable<bool> CelebrateHalloween { get; set; }
            [Display(Name = "Do you celebrate Memorial Day?")]
            public Nullable<bool> CelebrateMemorialDay { get; set; }
            [Display(Name = "Do you celebrate Labor Day?")]
            public Nullable<bool> CelebrateLaborDay { get; set; }
            [Display(Name = "Do you celebrate Mother's Day?")]
            public Nullable<bool> CelebrateMothersDay { get; set; }
            [Display(Name = "Do you celebrate Father's Day?")]
            public Nullable<bool> CelebrateFathersDay { get; set; }
            [Display(Name = "Do you celebrate Chaunakah?")]
            public Nullable<bool> CelebrateChaunakah { get; set; }
            [Display(Name = "Do you celebrate Passover?")]
            public Nullable<bool> CelebratePassover { get; set; }
            [Display(Name = "Do you observe Rosh Hashanah?")]
            public Nullable<bool> CelebrateRoshHashanah { get; set; }
            [Display(Name = " Do you observe Yom Kippur?")]
            public Nullable<bool> CelerateYomKippur { get; set; }
            [Display(Name = "Do you observe Ramadan?")]
            public Nullable<bool> CelebrateRamadan { get; set; }
            [Display(Name = "Do you celebrate Eid al-Fitr?")]
            public Nullable<bool> CelebrateEID { get; set; }
            //note there is also an Eid al-Adha, which we can add if we get the chance
            [Display(Name = "Do you celebrate St. Patrick's Day?")]
            public Nullable<bool> CelebrateSTPat { get; set; }
            [Display(Name = "Would you like to commemorate anyone's birthday?")]
            public Nullable<bool> CelebrateBirthdays { get; set; }
            [Display(Name = "Do you celebrate the Chinese New Year?")]
            public Nullable<bool> CelebrateChineseNewYear { get; set; }
            [Display(Name = "Do you celebrate Quinceañera?")]
            public Nullable<bool> CelebrateQuinceanera { get; set; }
            [Display(Name = "Would you like to remember a bar or bat mitzvah?")]
            public Nullable<bool> CelebrateBarBatMitzvah { get; set; }
            [Display(Name = "Do you celebrate the Day of the Dead?")]
            public Nullable<bool> CelebrateDayOfTheDead { get; set; }
            [Display(Name = "Do you observe Veteran's Day?")]
            public Nullable<bool> CelebrateVeteransDay { get; set; }
            [Display(Name = "Do you celebrate Cinco de Mayo?")]
            public Nullable<bool> CelebrateCincoDeMayo { get; set; }
            [Display(Name = "Are there any other holidays or festive occassions you would like to commemorate?")]
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
            [Display(Name = "Do you play any sports?")]
            public Nullable<bool> PlaySports { get; set; }
            [Display(Name = "Have you ever been a show or performance?")]
            public Nullable<bool> InAShow { get; set; }
            [Display(Name = "Do you like to travel?")]
            public Nullable<bool> Travel { get; set; }
            [Display(Name = "Do you enjoy the outdoors?")]
            public Nullable<bool> OutdoorPerson { get; set; }
            [Display(Name = "Have you ever travelled abroad?")]
            public Nullable<bool> TravelAbroad { get; set; }
            [Display(Name = "Are you passionate or enthusiastic about your hobbies?")]
            public Nullable<bool> Passions { get; set; }
            [Display(Name = "Do you have any fun or unusual talents?")]
            public Nullable<bool> Talents { get; set; }
            [Display(Name = "Have your hobbies or interests earned you trophies or awards?")]
            public Nullable<bool> Trophies { get; set; }
            [Display(Name = "Do you like to exercise?")]
            public Nullable<bool> Exercise { get; set; }
            [Display(Name = "Have you been on any family vacations?")]
            public Nullable<bool> FamilyVacation { get; set; }
            [Display(Name = "Did you take any childhood vacations?")]
            public Nullable<bool> ChildhoodVacation { get; set; }
            [Display(Name = "Do you have any other hobbies or entertainments you would like to remember?")]
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
            [Display(Name = "Have you ever broken a bone, or had a similar injury?")]
            public Nullable<bool> BrokenBones { get; set; }
            [Display(Name = "Do you have a home you consider your 'first home'?")]
            public Nullable<bool> OwnHome { get; set; }
            [Display(Name = "Did you get your driver's license?")]
            public Nullable<bool> DriversLicense { get; set; }
            [Display(Name = "Do you have a story about losing a first tooth -- yours or another's?")]
            public Nullable<bool> FirstTooth { get; set; }
            [Display(Name = "If you have a nickname your friends gave you, do you have a story about that?")]
            public Nullable<bool> PersonalNickName { get; set; }
            [Display(Name = "Does a family member or friend have nickname and do you have a story about that?")]
            public Nullable<bool> FamilyNickName { get; set; }
            [Display(Name = "Can you ride a bike?")]
            public Nullable<bool> RideBike { get; set; }
            [Display(Name = "Did you ever commit a crime?")]
            public Nullable<bool> CommitCrime { get; set; }
            [Display(Name = "Have you made any dramatic changes in your life?")]
            public Nullable<bool> BigMove { get; set; }
            [Display(Name = "Have you ever voted?")]
            public Nullable<bool> Vote { get; set; }
            [Display(Name = "Do you have any family traditions you would like to record?")]
            public Nullable<bool> FamilyTraditions { get; set; }
            [Display(Name = "Would you like to write about your most embarrassing moment? (Everyone else wants to read about it!)")]
            public Nullable<bool> EmbarrassingMoment { get; set; }
            [Display(Name = "Do you have any moments about which you are especially proud?")]
            public Nullable<bool> ProudestMoments { get; set; }
            [Display(Name = "Did you attend a sleep-away camp as a child or young adult?")]
            public Nullable<bool> ChildhoodCamp { get; set; }
            [Display(Name = "Do you have any loved ones or influential people in your life you'd like to remember?")]
            public Nullable<bool> MemorializeSomeone { get; set; }
            [Display(Name = "Have you ever been to a concert?")]
            public Nullable<bool> Concerts { get; set; }
            [Display(Name = "Have you ever had a pet?")]
            public Nullable<bool> FamilyPet { get; set; }
            [Display(Name = "Do you currently have pets?")]
            public Nullable<bool> CurrentPet { get; set; }
            [Display(Name = "Did you ever attend a high school dance?")]
            public Nullable<bool> HSDance { get; set; }
            [Display(Name = "Do you have any other special memories you would like to commemorate?")]
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
            [Display(Name = "Do you remember September 11, 2001?")]
            public Nullable<bool> September11 { get; set; }
            [Display(Name = "Do you remember when humans first landed on the moon?")]
            public Nullable<bool> MoonLanding { get; set; }
            [Display(Name = "Do you remember the day President Nixon resigned?")]
            public Nullable<bool> NixonResigns { get; set; }
            [Display(Name = "Do you remember the day Elvis died?")]
            public Nullable<bool> ElvisDies { get; set; }
            [Display(Name = "Do you remember when the space shuttle Challenger exploded?")]
            public Nullable<bool> ChallengerExplodes { get; set; }
            [Display(Name = "Do you remember the end of World War II?")]
            public Nullable<bool> WorldWar2Ends { get; set; }
            [Display(Name = "Do you remember when JFK was assassinated?")]
            public Nullable<bool> KennedyDies { get; set; }
            [Display(Name = "Are there any notable elections you'd like to remember?")]
            public Nullable<bool> NotableElection { get; set; }
            [Display(Name = "Do you remember when Martin Luther King, Jr. was assassinated?")]
            public Nullable<bool> MLKAssassination { get; set; }
            [Display(Name = "Do you remember what you were doing at 11:59 pm on December 31, 1999?")]
            public Nullable<bool> Y2K { get; set; }
            [Display(Name = "Do you remember the fall of the Berlin Wall?")]
            public Nullable<bool> BerlinWall { get; set; }
            [Display(Name = "Do you remember the O.J. Simpson car chase?")]
            public Nullable<bool> OJSimpsonCarChase { get; set; }
            [Display(Name = "Do you remember the end of Prohibition? If so... Bottom's up!")]
            public Nullable<bool> EndOfProhibition { get; set; }
            [Display(Name = "Are there any other world-changing events you would like to remember?")]
            public Nullable<bool> AnythingElse { get; set; }
            [Display(Name = "Do you have memories of the Vietnam War, at home or abroad?")]
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

            [Display(Name = "Title")]
            public string EventTitle { get; set; }
            [Display(Name = "Day")]
            [Range(1, 31)]
            public Nullable<int> EventDay { get; set; }
            [Display(Name = "Month")]
            [Range(1, 12)]
            public string EventMonth { get; set; }
            [Display(Name = "Year (required)")]
            [Range(1800, 2050)]
            public int EventYear { get; set; }
            [Display(Name = "Who was with you?")]
            public string PeopleInvolved { get; set; }
            [Display(Name = "Caption (750 character limit).")]
            public string EventCaption { get; set; }
            [Display(Name = "Upload a file here")]
            public string UploadMedia { get; set; }

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

            [Display(Name = "Your Birthday is")]
            //might want to add something to format the date, too
            public DateTime Birthdate { get; set; }
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
