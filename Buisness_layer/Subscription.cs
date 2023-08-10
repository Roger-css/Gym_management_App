using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int TotalAmount { get; set; }
        public float PaidAmount { get; set; }
        //public float RemainingAmount { get; set; }
        //public int DaysTillSubscribtionEnds { get; set; }



<<<<<<< HEAD
        private bool _AddNewSubscribtion()

        {
            this.ID = clsTraineeDataAccess.AddNewSubscribtion(this.PlayerID,
                this.StartDate, this.EndDate, this.TotalAmount, this.PaidAmount);
            return (this.ID != -1);
        }
=======
        //private bool _AddNewSubscribtion()
            
        //{
        //    this.ID = clsSubScribtionDataAccses.AddNewSubscribtion(this.PlayerID,
        //        this.StartDate, this.EndDate, this.TotalAmount, this.PaidAmount,
        //        this.RemainingAmount, this.DaysTillSubscribtionEnds);
        //    return (this.ID != -1);
        //}
>>>>>>> 86782089f99ba96f53e1fad80185526fc9914c08

        private bool _UpdateSubscribtion()
        {
            return clsTraineeDataAccess.UpdateTraineeSubscribtion(this.ID, this.PlayerID,
                  this.StartDate,  this.EndDate, this.TotalAmount, this.PaidAmount);
        }

        public clsSubscription()
        {
            this.ID = -1;
            this.PlayerID = -1;
            this.StartDate = DateTime.MinValue;
            this.EndDate = DateTime.MinValue;
            this.TotalAmount = -1;
            this.PaidAmount = -1;
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

<<<<<<< HEAD


        //public static clsSubscription FindByPlayer(int PlayerID)
        //{
        //    int ID = -1;
        //    DateTime StartDate = DateTime.MinValue,
        //    EndDate = DateTime.MinValue;
        //    int TotalAmount = -1;
        //    float PaidAmount = -1f, RemainingAmount = -1f;
        //    int DaysTillSubscribtionEnds = -1;

        //    if (clsTraineeDataAccess.GetLastSubscribtionByPlayerID
        //        (ref ID,  PlayerID, ref StartDate, ref EndDate,
        //       ref TotalAmount, ref PaidAmount, ref RemainingAmount,
        //       ref DaysTillSubscribtionEnds))

        //        return new clsSubscription(ID, PlayerID, StartDate, EndDate, TotalAmount,
        //            PaidAmount, RemainingAmount, DaysTillSubscribtionEnds);

        //    else
        //        return null;

        //}

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubscribtion())
                    {
                        Mode = enMode.Update;
                    }
                    break;
                case enMode.Update:
                    return _UpdateSubscribtion();
            }
            return false;
        }

 
    
        public static DataTable GetAllSubscribtionsByPlayerID(int PlayerID)
        {
            return clsTraineeDataAccess.GetAllSubscribtionsByPlayerID(PlayerID);
        }

        public static decimal GetBalanceByDates (DateTime startDate, DateTime endDate)
        {
            return clsTraineeDataAccess.GetBalanceByDates(startDate, endDate);
        }
=======
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
>>>>>>> 86782089f99ba96f53e1fad80185526fc9914c08

        public static decimal GetRemainingByDates(DateTime startDate, DateTime endDate)
        {
            return clsTraineeDataAccess.GetRemainingByDates(startDate, endDate);
        }



    }
}
