using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Security.Authentication;

namespace HostelNET.Models
{
    public class Service_NoSQL
    {
        #region Variables
        private string name;
        public string Name
        {
            get
            {
                if (name == null)
                {
                    name = "null";
                }
                return name;
            }
            set
            {
                name = value;
            }
        }

        private string email;
        public string Email
        {
            get
            {
                if (email == null)
                {
                    email = "null";
                }
                return email;
            }
            set
            {
                email = value;
            }
        }

        private string type;
        public string Type
        {
            get
            {
                if (type == null)
                {
                    type = "null";
                }
                return type;
            }
            set
            {
                type = value;
            }
        }

        private string description;
        public string Description
        {
            get
            {
                if (description == null)
                {
                    description = "null";
                }
                return description;
            }
            set
            {
                description = value;
            }
        }
        #endregion


        public void Service_InsertInto()
        {
            try
            {
                BsonDocument newDocument = new BsonDocument
                {
                    {"name", Name },
                    {"email", Email },
                    {"type", Type },
                    {"description", Description }
                };
                Console.WriteLine(newDocument);
                string connectionString = new Connection().connectionString_NoSQL;
                MongoClientSettings settings = MongoClientSettings.FromUrl
                (
                  new MongoUrl(connectionString)
                );

                settings.SslSettings = new SslSettings()
                {
                    EnabledSslProtocols = SslProtocols.Tls12
                };
                var mongoClient = new MongoClient(settings);
                var mongoDataBase = mongoClient.GetDatabase("hostel-db");
                var mongoCollection = mongoDataBase.GetCollection<BsonDocument>("hostel-collection");

                mongoCollection.InsertOne(newDocument);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
