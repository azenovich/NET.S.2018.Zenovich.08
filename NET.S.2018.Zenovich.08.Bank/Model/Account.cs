﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2018.Zenovich._08.Bank.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    public class Account
    {
        protected Account(AccountType type, string firstName, string lastName)
        {
            Id = Guid.NewGuid();
            CreationDate = DateTime.Now;
            Type = type;
            Amount = 0;
            IsClosed = false;

            FirstName = firstName;
            LastName = lastName;
        }

        public Guid Id
        {
            get; private set;
        }

        public string FirstName
        {
            get; set;
        }

        public string LastName
        {
            get; set;
        }

        public DateTime CreationDate
        {
            get; set;
        }

        public AccountType Type
        {
            get; set;
        }

        public decimal Amount
        {
            get; set;
        }

        public long Bonus
        {
            get; set;
        }

        public bool IsClosed
        {
            get; set;
        }
    }
}
