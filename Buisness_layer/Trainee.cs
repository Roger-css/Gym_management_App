﻿using GymDataAccesLayer;
using System;
using System.Data;

namespace GymBussniesLayer
{
    public class clsTrainee : Person
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public DateTime EnrollmentStartDate { get; set; }
        public DateTime EnrollmentEndDate { get; set; }


        private bool AddNewTrainee()
        {
            this.ID = clsTraineeDataAccess.AddNewTrainee(this.Name,
                this.Phone, this.Photo);
            return this.ID != -1;
        }

        // 1-Name, 2- POHNE, 3- PHOTO, ENROLMENT START DATE, ENRLMMENT END DATE, 


        private bool _UpdateTrainee()
        {
            return clsTraineeDataAccess.UpdateTrainee(this.ID, this.Name,
                this.Phone, this.Photo);
        }

        public clsTrainee() : base(-1, "", "", "")
        {


            Mode = enMode.AddNew;
        }


        private clsTrainee
            (int id, string name, string phone,
            string photo)
            : base(id, name, phone, photo)
        {

            Mode = enMode.Update;
        }

        public static int AddPlayerWithSubscribtion(string name, string phone, string photo,
            DateTime enrollmentStartDate, DateTime enrollmentEndDate, int totalAmount, int paidAmount, DateTime PayDate)
        {

            clsTrainee TrainneToAdd = new clsTrainee
            {
                Name = name,
                Phone = phone,
                Photo = photo
            };
            if (TrainneToAdd.Save())
            {
                clsSubscription NewSubScription = new clsSubscription
                {
                    PlayerID = TrainneToAdd.ID,
                    StartDate = enrollmentStartDate,
                    EndDate = enrollmentEndDate,
                    TotalAmount = totalAmount,
                    PaidAmount = paidAmount,
                    PayDate = PayDate
                };
                if (NewSubScription.Save())
                    return TrainneToAdd.ID;
            }
            return -1;
        }

        public static bool UpdatePlayerSubscription(int PlayerID, string name, DateTime enrollmentStartDate
            , DateTime enrollmentEndDate, string phone, string photo, int totalAmount, int paidAmount, DateTime payDate)
        {

            clsTrainee TrainneToUpdate = Find(PlayerID);
            TrainneToUpdate.Name = name;
            TrainneToUpdate.Phone = phone;
            TrainneToUpdate.Photo = photo;
            if (TrainneToUpdate.Save())
            {
                return clsTraineeDataAccess.UpdateTraineeSubscription(PlayerID, enrollmentStartDate,
                     enrollmentEndDate, totalAmount, paidAmount, payDate);
            }
            return false;
        }

        public static bool QuickSubscribe(int PlayerID)
        {
            DataTable lastSub = clsTraineeDataAccess.GetLastSubscriptionByPlayerID(PlayerID);
            DataRow row = lastSub.Rows[0];

            DateTime enrollmentStartDate = (DateTime)row["EnrollmentEnd"];
            DateTime enrollmentEndDate = enrollmentStartDate.AddMonths(1);
            double typ = (double)row["TotalAmount"];
            int TotalAmount = (int)typ;
            int paidAmount = TotalAmount;

            int SubNumber = clsTraineeDataAccess.AddNewSubscription(PlayerID, enrollmentStartDate,
                enrollmentEndDate, TotalAmount, paidAmount, enrollmentStartDate);
            return SubNumber > -1;
        }
        public static bool AutoPayRemaining(int PlayerID)
        {
            DataTable lastSub = clsTraineeDataAccess.GetLastSubscriptionByPlayerID(PlayerID);
            DataRow row = lastSub.Rows[0];

            DateTime enrollmentStartDate = (DateTime)row["EnrollmentStart"];
            DateTime enrollmentEndDate = (DateTime)row["EnrollmentEnd"];
            DateTime payDate = (DateTime)row["PayDate"];
            double typ = (double)row["TotalAmount"];
            int totalAmount = (int)typ;
            //float totalAmount = (float)row["TotalAmount"];
            return clsTraineeDataAccess.UpdateTraineeSubscription(PlayerID, enrollmentStartDate,
                    enrollmentEndDate, totalAmount, totalAmount, payDate);

        }

        public static clsTrainee Find(int ID)
        {
            string Name = "", Phone = "", Photo = "";

            if (clsTraineeDataAccess.GetTraineeInfoByID
                (ID, ref Name, ref Phone, ref Photo))

                return new clsTrainee(ID, Name, Phone, Photo);
            else
                return null;

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewTrainee())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    break;
                case enMode.Update:
                    return _UpdateTrainee();
            }
            return false;
        }

        public static DataTable GetTraineesLastSub()
            => clsTraineeDataAccess.GetTraineesLastSub();
        public static DataTable GetTraineesAllSub()
            => clsTraineeDataAccess.GetTraineesAllSubs();

        public static DataTable GetTraineeLastSub(string Name)
            => clsTraineeDataAccess.GetTraineeLastSub(Name);

        public static DataTable GetTraineeAllSubsByName(string Name)
            => clsTraineeDataAccess.GetTraineeAllSubsByName(Name);

        public static DataTable GetTraineeByDatesWithRemaining(DateTime startDate, DateTime endDate)
                => clsTraineeDataAccess.GetTraineesByDatesWithRemaining(startDate, endDate);

        public static DataTable GetTraineesExpiredSubscription()
            => clsTraineeDataAccess.GetTraineesExpiredSubscription();

        public static DataTable GetAllSubscriptionsByPlayerID(int PlayerID)

            => clsTraineeDataAccess.GetAllSubscriptionsByPlayerID(PlayerID);

        public static DataTable GetLastSubscriptionsByPlayerID(int PlayerID)

            => clsTraineeDataAccess.GetLastSubscriptionByPlayerID(PlayerID);

        public static DataTable GetTraineeLastSubByPhone(string Phone)
            => clsTraineeDataAccess.GetTraineeLastSubByPhone(Phone);

        public static DataTable GetTraineeAllSubsByPhone(string Phone)
            => clsTraineeDataAccess.GetTraineeAllSubByPhone(Phone);
        public static DataTable GetLastSubscriptionByPlayerIDWithoutPhoto(int PlayerID)
            => clsTraineeDataAccess.GetLastSubscriptionByPlayerIDWithoutPhoto(PlayerID);
        public static DataTable GetPlayersWithOutSubs()
            => clsTraineeDataAccess.GetPlayersWithOutSubs();
        public static bool DeletePlayerSub(int PlayerID)
            => clsTraineeDataAccess.DeletePlayerSub(PlayerID);
        public static bool IsTraineeNameExists(string PalyerName)
            => clsTraineeDataAccess.IsTraineeNameExists(PalyerName);
        public static DataTable GetPlayersWithOutSubsByName(string Name)
            => clsTraineeDataAccess.GetPlayersWithOutSubsByName(Name);

        public static DataTable GetPlayersWithOutSubsByID(int ID)
          => clsTraineeDataAccess.GetPlayersWithOutSubsByID(ID);
        public static int GetPlayersCount()
            => clsTraineeDataAccess.GetPlayersCount();
    }
}
