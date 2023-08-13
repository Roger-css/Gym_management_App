using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using GymDataAccesLayer;

namespace GymBussniesLayer
{
    public class clsTrainee : Person
    {
        public enum enMode { AddNew = 1, Update = 2 }
        public enMode Mode = enMode.AddNew;

        public DateTime EnrollmentStartDate { get; set; }
        public DateTime EnrollmentEndDate { get; set; }


        private bool _AddNewTrainee()
        {
            this.ID = clsTraineeDataAccess.AddNewTrainee(this.Name,
                this.Phone, this.Photo);
            return (this.ID != -1);
        }

        // 1-Name, 2- POHNE, 3- PHOTO, ENROLMENT START DATE, ENRLMMENT END DATE, 


        private bool _UpdateTrainee()
        {
            return clsTraineeDataAccess.UpdateTrainee(this.ID, this.Name,
                this.Phone, this.Photo);
        }

        public clsTrainee(DateTime enrollmentStartDate, DateTime enrollmentEndDate) : base(-1, "", "", "")
        {
            this.EnrollmentStartDate = enrollmentStartDate;
            this.EnrollmentEndDate = enrollmentEndDate;

            Mode = enMode.AddNew;
        }


        private clsTrainee
            (int id, string name, string phone,
            string photo, DateTime enrollmentStartDate, DateTime enrollmentEndDate)
            : base(id, name, phone, photo)
        {

            this.EnrollmentStartDate = enrollmentStartDate;
            this.EnrollmentEndDate = enrollmentEndDate;
            Mode = enMode.Update;
        }

        public static int AddPalyerWithSubscribtion(string name, string phone, string photo,
            DateTime enrollmentStartDate, DateTime enrollmentEndDate, int totalAmount, int paidAmount)
        {

            clsTrainee TrainneToAdd = new clsTrainee(enrollmentStartDate, enrollmentEndDate);
            TrainneToAdd.Name = name;
            TrainneToAdd.Phone = phone;
            TrainneToAdd.Photo = photo;
            if (TrainneToAdd.Save())
            {
                clsSubscription NewSubScribtion = new clsSubscription();

                NewSubScribtion.PlayerID = TrainneToAdd.ID;
                NewSubScribtion.StartDate = TrainneToAdd.EnrollmentStartDate;
                NewSubScribtion.EndDate = TrainneToAdd.EnrollmentEndDate;
                NewSubScribtion.TotalAmount = totalAmount;
                NewSubScribtion.PaidAmount = paidAmount;
                if (NewSubScribtion.Save())
                    return TrainneToAdd.ID;
            }
            return -1;
        }

        public static bool UpdatePlayerSubScribtion(int PlayerID, string name, DateTime enrollmentStartDate
            , DateTime enrollmentEndDate, string phone, string photo, int totalAmount, int paidAmount)
        {

            clsTrainee TrainneToUpdate = clsTrainee.Find(PlayerID);
            TrainneToUpdate.Name = name;
            TrainneToUpdate.Phone = phone;
            TrainneToUpdate.Photo = photo;
            if (TrainneToUpdate.Save())
            {
               return  clsTraineeDataAccess.UpdateTraineeSubscription(PlayerID, enrollmentStartDate,
                    enrollmentEndDate, totalAmount, paidAmount);
            }
            return false;
        }


        public static clsTrainee Find(int ID)
        {
            string Name = "", Phone = "", Photo = "";
            DateTime enrollmentStartDate = DateTime.MinValue,
                enrollmentEndDate = DateTime.MinValue;

            if (clsTraineeDataAccess.GetTraineeInfoByID
                (ID, ref Name, ref Phone, ref Photo,
               ref enrollmentStartDate, ref enrollmentEndDate))

                return new clsTrainee(ID, Name, Phone, Photo,
                    enrollmentStartDate, enrollmentEndDate);
            else
                return null;

        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTrainee())
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
        

    }
}
