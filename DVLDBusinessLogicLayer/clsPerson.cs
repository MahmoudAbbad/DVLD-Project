using DVLDDataAccessLayer.Person;
using System.Data;
using System.Diagnostics;
namespace DVLDBusinessLogicLayer
{
    public class clsPerson
    {
        public enum _enMode { AddPerson = 1, UpdatePerson = 2 };

        public clsPersonEntity personInfo;
        public _enMode Mode;

        public clsPerson()
        {
            personInfo = new clsPersonEntity();
            Mode = _enMode.AddPerson;
        }
        public clsPerson(clsPersonEntity person)
        {
           personInfo = person;
            Mode = _enMode.UpdatePerson;
        }

        private int _AddPerson()
        {
            return clsPeopleDataAccess.AddPerson(personInfo);
        }

        private bool _UpdatePerson()
        {
            return clsPeopleDataAccess.UpdatePerson(personInfo);
        }

        public static DataTable GetPeople()
        {
            return clsPeopleDataAccess.GetAllPeople();
        }

        private void _CopyImageIntoDestinationFile(string oldImage)
        {

             string SourcePath = personInfo.ImagePath;
    
            if (!string.IsNullOrEmpty(SourcePath) && File.Exists(SourcePath))
            {
                if (oldImage == SourcePath)
                    return;

                string extension = Path.GetExtension(SourcePath);
                string DestinationPath = @"M:\Dvld images\DestenationImges\" + Guid.NewGuid().ToString() + extension;
    
                File.Copy(SourcePath, DestinationPath);
                personInfo.ImagePath = DestinationPath;
                if(!string.IsNullOrEmpty(oldImage)){
                    if (Path.GetDirectoryName(oldImage) == Path.GetDirectoryName(DestinationPath))
                        try
                        {
                            File.Delete(oldImage);
                        } catch(Exception ex) {
                            System.Diagnostics.Debug.WriteLine(ex.Message);
                        }
                }
            }
        }
        public bool Save(string oldImage)
        {
            _CopyImageIntoDestinationFile(oldImage);

            bool IsSaved = false;

            if (Mode == _enMode.AddPerson)
            {
                personInfo.PersonID = _AddPerson();

                if (personInfo.PersonID != -1)
                {
                    Mode = _enMode.UpdatePerson;
                    IsSaved = true;
                }
            }
            else
            {
                IsSaved = _UpdatePerson();
            }
           
            return IsSaved;
        }

        public static clsPersonEntity FindById(int PersonID)
        {
            if(PersonID <= 0|| PersonID == null)
            {
                throw new Exception("Invalid Person ID.");
            }

            clsPersonEntity personInfo = new();            
            personInfo = clsPeopleDataAccess.GetPersonById(PersonID);

            if (personInfo == null)
            {
                throw new Exception("Person not found.");

            }

            if (personInfo.Gendor == "0")
            {
                personInfo.Gendor = "Male";
            }
            else
            {
                personInfo.Gendor = "Female";
            }

                return personInfo;
        }
        public bool DeletePerson(int PersonId)
        {
            return clsPeopleDataAccess.DeletePerson(PersonId);
        }

        public static bool IsNationalNoValid(string NationalNo)
        {
            return clsPeopleDataAccess.IsNationalityNoValid(NationalNo);
        }
    }
}