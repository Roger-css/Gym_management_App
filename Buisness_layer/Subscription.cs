using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices.ComTypes;
using System.Xml.Linq;
using GymDataAccesLayer;

namespace GymBussniesLayer
{
    public class clsSubscription
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public int ID { get; private set; }
        public int PlayerID { get; set; }
        public DateTime StartDate { get; }
        public DateTime EndDate { get; }
        public int TotalAmount { get; }
        public float PaidAmount { get; set; }
        public float RemainingAmount { get; set; }
        public int DaysTillSubscribtionEnds { get; set; }



        //private bool _AddNewSubscribtion()
            
        //{
        //    this.ID = clsSubScribtionDataAccses.AddNewSubscribtion(this.PlayerID,
        //        this.StartDate, this.EndDate, this.TotalAmount, this.PaidAmount,
        //        this.RemainingAmount, this.DaysTillSubscribtionEnds);
        //    return (this.ID != -1);
        //}

        //private bool _UpdateSubscribtion()
        //{
        //    return clsSubScribtionDataAccses.UpdateTrainee(this.ID, this.PlayerID,
        //        this.StartDate, this.EndDate, this.TotalAmount, this.PaidAmount,
        //        this.RemainingAmount, this.DaysTillSubscribtionEnds);
        //}

        public clsSubscription()
        {
            this.ID = -1;
            this.PlayerID = -1;
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MinValue;
            this.TotalAmount = -1;
            this.PaidAmount = -1;
            this.RemainingAmount = -1;
            this.DaysTillSubscribtionEnds = -1;

            Mode = enMode.AddNew;
        }




        private clsSubscription(int ID, int playerID, DateTime StartDate, DateTime EndDate,
            int totalAmount, float paidAmount, float remainingAmount,
            int daysTillSubscribtionEnds)
        {
            this.ID = ID;
            this.PlayerID = playerID;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.TotalAmount = totalAmount;
            this.PaidAmount = paidAmount;
            this.RemainingAmount = remainingAmount;
            this.DaysTillSubscribtionEnds = daysTillSubscribtionEnds;

            Mode = enMode.Update;
        }


        //public static clsSubscription Find(int ID)
        //{
        //    int PlayerID = -1;
        //    DateTime StartDate = DateTime.MinValue,
        //    EndDate = DateTime.MinValue;
        //    int TotalAmount = -1;
        //    float PaidAmount = -1f, RemainingAmount = -1f;
        //    int DaysTillSubscribtionEnds = -1;

        //    if (clsSubScribtionDataAccses.GetSubscribtionInfoByID
        //        (ID, ref PlayerID, ref StartDate, ref EndDate,
        //       ref TotalAmount, ref PaidAmount, ref RemainingAmount,
        //       ref DaysTillSubscribtionEnds))

        //        return new clsSubscription(ID, PlayerID, StartDate, EndDate, TotalAmount,
        //            PaidAmount, RemainingAmount, DaysTillSubscribtionEnds);

        //    else
        //        return null;

        //}

    //    public static clsSubscription FindByPlayer(int PlayerID)
    //    {
    //        int ID = -1;
    //        DateTime StartDate = DateTime.MinValue,
    //        EndDate = DateTime.MinValue;
    //        int TotalAmount = -1;
    //        float PaidAmount = -1f, RemainingAmount = -1f;
    //        int DaysTillSubscribtionEnds = -1;

    //        if (clsSubScribtionDataAccses.GetLastSubscribtionByPlayerID
    //            (ref ID,  PlayerID, ref StartDate, ref EndDate,
    //           ref TotalAmount, ref PaidAmount, ref RemainingAmount,
    //           ref DaysTillSubscribtionEnds))

    //            return new clsSubscription(ID, PlayerID, StartDate, EndDate, TotalAmount,
    //                PaidAmount, RemainingAmount, DaysTillSubscribtionEnds);

    //        else
    //            return null;

    //    }

    //    public bool Save()
    //    {
    //        switch (Mode)
    //        {
    //            case enMode.AddNew:
    //                if (_AddNewSubscribtion())
    //                {
    //                    Mode = enMode.Update;

    //                }
    //                break;
    //                //case enMode.Update:
    //                //    return _UpdateTrainee();
    //        }
    //        return false;
    //    }



    //    public static DataTable GetAllSubscribtions()
    //    {
    //        return clsSubScribtionDataAccses.GetAllSubscribtions();
    //    }
    //    public static DataTable GetAllSubscribtionsByPlayerID(int PlayerID)
    //    {
    //        return clsSubScribtionDataAccses.GetAllSubscribtionsByPlayerID(PlayerID);
    //    }

    //    public static DataTable GetSubscribtionBetweenDates(DateTime From,  DateTime To)
    //    {
    //        return clsSubScribtionDataAccses.GetSubscribtionBetweenDates(From, To);
    //    }

    }
}
