using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

//this is a metadata/buddy class for all of the tables
//mostly the 6 profile questionnaires, but other pages too
//not sure if you have to repeat the namespace line each time
//but it doesn't hurt.

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
//next try adding profile, events and media metaclasses here
//actually, you skipped media because you're not sure how that's going to look 
//or what's needed.

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

            //this one might take more work, because it's got all of the FKs in it.
            //check how you did Wardrobe -- you coded stuff out

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

            //        //the following was copied from the main model
            //        //but you get red squiggles
            //        //I think the solution is just to delete or code out here.

            //        //public virtual Career Career { get; set; }
            //        //public virtual Celebration Celebration { get; set; }
            //        //public virtual HobbyTable HobbyTable { get; set; }
            //        //public virtual Memory Memory { get; set; }
            //        //public virtual RegisterUser RegisterUser { get; set; }
            //        //public virtual Relationship Relationship { get; set; }
            //        //public virtual WorldEvent WorldEvent { get; set; }
            //        //public virtual EventTable EventTable { get; set; }

            //    }
        }
    }
}
