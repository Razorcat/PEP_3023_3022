using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja_Service.Util
{
    public class ExceptionHandler
    {
        public static void HandleException(EntityException e)
        {
            SqlException error = (SqlException)e.InnerException;

            switch (error.Number)
            {
                case 2627:
                    throw throwConstraintException(error);
                default:
                    throw new Exception(e.Message + " (" + error.Number + ") ");

            }
        
        }

        private static ConstraintException throwConstraintException(SqlException error)
        {
            int begin = error.Message.IndexOf("'");
            int end = error.Message.IndexOf("'", begin + 1);

            string newMessage = error.Message;

            if (begin > 0 && end > 0)
            {
                string constraintName = error.Message.Substring(begin + 1, end - begin - 1);

                if (constraintName == "CS_KorisnickoIme")
                    newMessage = "username_con";
                else if (constraintName == "CS_Email")
                    newMessage = "email_con";
            }

            return new ConstraintException(newMessage);
        }
    }
}
