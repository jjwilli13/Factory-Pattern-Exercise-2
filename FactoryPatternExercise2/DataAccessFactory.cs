using System;
using System.Collections.Generic;

namespace FactoryPatternExercise2
{
    public static class DataAccessFactory
    {

        public static IDataAccess GetDataAccessType(string databaseType)
        {

            switch (databaseType.ToLower())
            {
                case "list":
                        return new ListDataAccess();
                case "mongo":
                    return new MongoDataAccess();
                case "sql":
                        return new SQLDataAccess();
                default:
                        return new ListDataAccess();


            }

               
     
            
        }


    }
}

