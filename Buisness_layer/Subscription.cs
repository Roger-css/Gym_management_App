//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Runtime.InteropServices.ComTypes;
//using System.Xml.Linq;
//using GymDataAccesLayer;

//namespace GymBussniesLayer
//{
//    public class clsSubscription 
//    {
//        public enum enMode { AddNew = 1, Update = 2 }
//        public enMode Mode = enMode.AddNew;

//        public int ID { get;}
//        public int PlayerID { get; set; }
//        public   DateTime StartDate { get; }
//        public DateTime EndDate { get; }
//        public int TotalAmount { get; }
//        public   float  PaidAmount { get; set; }
//        public float RemainingAmount { get; set; }
//        public int DaysTillSubscribtionEnds { get; set; }



//        private bool _AddNewSubscribtion()
//        {
//            this.ID = clsTraineeDataAccess.AddNewTrainee(this.Name,
//                this.Phone, this.Photo, this.EnrollmentStartDate, this.EnrollmentEndDate);
//            return (this.ID != -1);
//        }

//        private bool _UpdateTrainee()
//        {
//            return clsTraineeDataAccess.UpdateTrainee(this.ID, this.Name,
//                this.Phone, this.Photo);
//        }

//        public clsSubscription()
//        {
//            this.ID = -1;
//            this.PlayerID = -1;
//            this.StartDate = DateTime.MinValue;
//            this.EndDate = DateTime.MinValue;
//            this.TotalAmount = -1;
//            this.PaidAmount = -1;
//            this.RemainingAmount = -1;
//            this.DaysTillSubscribtionEnds = -1;

//            Mode = enMode.AddNew;
//        }




//        private clsSubscription(int ID, int playerID, DateTime startDate, DateTime endDate,
//            int totalAmount, float paidAmount, float remainingAmount,
//            int daysTillSubscribtionEnds)
//        {
//            this.ID = ID;
//            this.PlayerID = playerID;
//            this.StartDate = startDate;
//            this.EndDate = endDate;
//            this.TotalAmount = totalAmount;
//            this.PaidAmount = paidAmount;
//            this.RemainingAmount = remainingAmount;
//            this.DaysTillSubscribtionEnds = daysTillSubscribtionEnds;
            
//            Mode = enMode.Update;
//        }
     

//        public static clsTrainee Find(int ID)
//        {
//            string Name = "", Phone = "", Photo = "";
//            DateTime enrollmentStartDate = DateTime.MinValue,
//                enrollmentEndDate = DateTime.MinValue;

//            if (clsTraineeDataAccess.GetTraineeInfoByID
//                (ID, ref Name, ref Phone, ref Photo,
//               ref enrollmentStartDate, ref enrollmentEndDate))

//                return new clsSubscription(ID, Name, Phone, Photo,
//                    enrollmentStartDate, enrollmentEndDate);
//            else
//                return null;

//        }

//        public bool Save()
//        {
//            switch (Mode)
//            {
//                case enMode.AddNew:
//                    if (_AddNewTrainee())
//                    {
//                        Mode = enMode.Update;
//                        return true;
//                    }
//                    break;
//                case enMode.Update:
//                    return _UpdateTrainee();
//            }
//            return false;
//        }


//        public static DataTable GetAllTrainees()
//        {
//            return clsTraineeDataAccess.GetAllTrainees();
//        }
//        public bool DeleteTrainee(int ID)
//        {
//            return clsTraineeDataAccess.DeleteTrainee(ID);
//        }

//        public static bool IsTraineeExist(int ID)
//        {
//            return clsTraineeDataAccess.IsTraineeExisit(ID);
//        }
//        public static List<clsTrainee> GetTraineesBetweenAge(int From, int To)
//        {
//            DataTable dt = clsTraineeDataAccess.GetTraineesBetweenAge(From, To);
//            List<clsTrainee> TraineesList = new List<clsTrainee>();
//            return new List<clsTrainee>();
//        }

//    }
//}
