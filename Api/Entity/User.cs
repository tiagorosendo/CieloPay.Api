using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string OauthToken { get; set; }
        public List<Card> Cards { get; set; } 
        public List<Address> Addresses { get; set; } 
    }

    public class Card
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string MaskedCard { get; set; }
        public string Brand { get; set; }
        public Guid Token { get; set; }
        public bool Favorite { get; set; }
    }

    public class Address
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string ZipCode { get; set; }
        public string Neighborhood { get; set; }
        public string State { get; set; }
    }
}