using System;
using System.Collections.Generic;
using System.Reflection;
using WeContractLib.Diagnostics;
using WeContractLib.Misc;

namespace WeContractLib.Customer
{
    public class Customer : IThing, IDisplayable
    {
        public Customer()
        {
            DateCreated = DateTime.Now;
            CID = Guid.NewGuid();
            Contracts = new List<Guid>();
        }

        public Customer(string name) : this()
        {
            Name = name;
        }

        public Customer(string name, IEnumerable<Guid> contracts, uint phoneNumber, string emailAddress,
            short countryCode = 47, string note = default) : this(name)
        {
            PhoneNumber = Convert.ToUInt32(phoneNumber).ToString();
            CountryCode = Convert.ToInt16(countryCode);
            EmailAddress = emailAddress;
            Note = note;

            foreach (var contract in contracts)
            {
                AddContract(contract);
            }
        }

        public Customer(string name, string address, uint phoneNumber, short zipCode, string email,
        short countryCode, string note) : this(name)
        {
            PhoneNumber = Convert.ToUInt32(phoneNumber).ToString();
            ZipCode = Convert.ToInt16(zipCode);
            DeliveringAddress = address;
            EmailAddress = email;
            CountryCode = countryCode;
            Note = note;
        }

        public List<object> GetColumnIndexes()
        {
            var dateCreated = "Nha";
            var address = "Nha";
            var zipCode = "Nha";
            var phone = "Nha";
            var email = "Nha";
            var note = "Nha";
            var countryCode = "Nha";

            if (DateCreated != new DateTime())
            {
                dateCreated = DateCreated.ToShortDateString();
            }

            if (DeliveringAddress != string.Empty)
            {
                address = DeliveringAddress;
            }

            if (ZipCode != new short())
            {
                zipCode = ZipCode.ToString();
            }

            if (PhoneNumber != string.Empty)
            {
                phone = TextFormatting.PhoneNumberFormat(Convert.ToUInt32(PhoneNumber));
            }

            if (!string.IsNullOrEmpty(EmailAddress))
            {
                email = EmailAddress;
            }

            if (!string.IsNullOrEmpty(Note))
            {
                note = Note;
            }

            if (CountryCode != new short())
            {
                countryCode = "+" + CountryCode.ToString();
            }

            return new List<object>
            {
                Name,
                phone,
                address,
                zipCode,
                dateCreated,
                email,
                note,
                countryCode
            };
        }

        public bool AddContract(Guid entity)
        {
            if (Contracts == null)
            {
                Contracts = new List<Guid>();
            }

            if (Contracts.Contains(entity))
            {
                Log.Warning($"Contract:{entity} is already added to customer:{Name}");
                return false;
            }

            Contracts.Add(entity);
            return true;
        }

        public bool RemoveContract(Guid entity)
        {
            if (Contracts.Remove(entity))
            {
                return true;
            }

            Log.Warning($"Contract:{entity} is not attached to customer:{Name}");
            return false;
        }

        public int ID { get; set; }
        public Guid CID { get; set; }

        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public List<Guid> Contracts { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public short CountryCode { get; set; }
        public short ZipCode { get; set; }
        public string DeliveringAddress { get; set; }
        public string Note { get; set; }

        public override string ToString()
        {
            return $"ID: {ID} CID:{CID} Name: {Name} Created: {DateCreated.ToShortDateString()}";
        }

        public bool AttachEntity(IThing entity)
        {
            return AddContract(entity.CID);
        }

        public bool DeattachEntity(IThing entity)
        {
            return RemoveContract(entity.CID);
        }
    }
}
