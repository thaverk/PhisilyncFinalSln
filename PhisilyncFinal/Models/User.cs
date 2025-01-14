﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhisilyncFinal.Tabs;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PhisilyncFinal.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int userID { get; set; }

        public string userName { get; set; }
        public string userSurname { get; set; }
        public string userGender { get; set; }
        public string userEmail { get; set; }
        public string userPhoneNumber { get; set; }
        public DateTime userDateOfBirth { get; set; }
        public string userPassword { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Sport>? userSports { get; set; }

        public User() { userSports = new(); }

        [ForeignKey(typeof(UserType))]
        public int userType { get; set; }

        [ForeignKey(typeof(Club))]
        public int userClub { get; set; }

    }
}
