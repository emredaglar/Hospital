﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Hospital.Patient.Entities
{
    public class PatientAdult
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int PatientAdultId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
