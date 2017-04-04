using MongoDB.Driver;
using System;


namespace Csharp7
{
    class LocalFunctions
    {
        public IMongoCollection<T> GetCollection<T>(IMongoDatabase db)
        {

            var collectionName = NormalizeTypeName(typeof(T));
            return db.GetCollection<T>(collectionName);


            // inner function that is only used here
            string NormalizeTypeName (Type type)
            {
                var name = type.Name.ToLowerInvariant();

                //todo: normalize generic type names here from Deleted`1 to deleted-user
                
                return name;
            }
        }
    }
}
