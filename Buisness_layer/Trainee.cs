using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;
using GymDataAccesLayer;

namespace GymBussniesLayer
{
    public class clsTrainee : Person
    {
        public enum enMode { AddNew = 1 , Update = 2 }
        public enMode Mode  = enMode.AddNew;

        DateTime EnrollmentStartDate { get; set; }
        DateTime EnrollmentEndDate { get; set; }


        private bool _AddNewTrainee()
        {
            this.ID = clsTraineeDataAccess.AddNewTrainee(this.Name,
                this.Phone, this.Photo, this.EnrollmentStartDate, this.EnrollmentEndDate);
            return (this.ID != -1);
        }

        private bool _UpdateTrainee()
        {
            return clsTraineeDataAccess.UpdateTrainee(this.ID, this.Name,
                this.Phone,this.Photo);
        }

        public clsTrainee() : base( -1 , "", "", "")
        {
            this.EnrollmentStartDate = DateTime.MinValue;
            this.EnrollmentEndDate = DateTime.MinValue;

            Mode = enMode.AddNew;
        }


        private clsTrainee
            (int id,string name,  string phone,
            string photo , DateTime enrollmentStartDate, DateTime enrollmentEndDate)
            : base( id,  name,  phone,  photo)
        {

            this.EnrollmentStartDate = enrollmentStartDate;
            this.EnrollmentEndDate = enrollmentEndDate;
            Mode = enMode.Update;
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


        public static DataTable GetAllTrainees()
        {
            return clsTraineeDataAccess.GetAllTrainees();
        }
        public bool DeleteTrainee(int ID)
        {
            return clsTraineeDataAccess.DeleteTrainee(ID);
        }

        public static bool IsTraineeExist(int ID)
        {
            return clsTraineeDataAccess.IsTraineeExisit(ID);
        }
        public static List<clsTrainee> GetTraineesBetweenAge(int From, int To)
        {
            DataTable dt = clsTraineeDataAccess.GetTraineesBetweenAge(From, To);
            List<clsTrainee> TraineesList = new List<clsTrainee>();
            return new List<clsTrainee>();
        }
      
    }
}
