using GymDataAccesLayer;
using System;
using System.Data;

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



        private bool _AddNewSubscription()

        {
            this.ID = clsTraineeDataAccess.AddNewSubscription(this.PlayerID,
                this.StartDate, this.EndDate, this.TotalAmount, this.PaidAmount);
            return this.ID != -1;
        }


        private bool _UpdateSubscription()
        {
            return clsTraineeDataAccess.UpdateTraineeSubscription(this.PlayerID,
                  this.StartDate, this.EndDate, this.TotalAmount, this.PaidAmount);
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

            Mode = enMode.Update;
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewSubscription())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateSubscription();
            }
            return false;
        }
        public static decimal GetPaidByDates(DateTime startDate, DateTime endDate)
        {
            return clsTraineeDataAccess.GetPaidByDates(startDate, endDate);
        }

        public static decimal GetBalanceByDates(DateTime startDate, DateTime endDate)
        {
            return clsTraineeDataAccess.GetPaidByDates(startDate, endDate);
        }

        public static decimal GetRemainingByDates(DateTime startDate, DateTime endDate)
        {
            return clsTraineeDataAccess.GetRemainingByDates(startDate, endDate);
        }
        public static DataTable GetTraineesSubscriptionsByDates(DateTime startDate, DateTime endDate)
        {
            return clsTraineeDataAccess.GetTraineesSubscriptionsByDates(startDate, endDate);
        }
        public static DataTable GetTraineesWithRemaining()
        {
            return clsTraineeDataAccess.GetTraineesWithRemaining();
        }
        public static int AddNewSubscription(int playerID, DateTime startDate,
            DateTime endDate, int totalAmount, int paidAmount)
        {
            return clsTraineeDataAccess.AddNewSubscription(playerID, startDate,
                endDate, totalAmount, paidAmount);
        }

    }
}
