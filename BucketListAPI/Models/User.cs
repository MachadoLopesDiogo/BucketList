
using System;
using System.Collections.Generic;

namespace BucketListAPI.Models;


public partial class User
{
   
    
        public int UserId { get; set; }
        public string UserName { get; set; } = "";

        public bool IsLoggedIn => UserId > 0;

    

    public virtual ICollection<Personalbucketlist> Personalbucketlists { get; set; } = new List<Personalbucketlist>();
}
