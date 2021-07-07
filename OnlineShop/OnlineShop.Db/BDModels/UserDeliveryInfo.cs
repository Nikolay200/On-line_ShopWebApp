using System;
using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Db.Models
{
    public class UserDeliveryInfo
    {  
        public Guid Id { get; set; }
        public string LastName { get; set; }       
        public string FirstName { get; set; }        
        public string PatronymicName { get; set; }       
        public string Phone { get; set; }        
        public string Town { get; set; }       
        public string Street { get; set; }        
        public int House { get; set; }        
        public int Flat { get; set; }        
        public string Email { get; set; }        
        public int Index { get; set; }
    }
}
