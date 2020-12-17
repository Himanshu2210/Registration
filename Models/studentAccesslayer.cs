using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class studentAccesslayer
    {
        SqlConnection con = new SqlConnection("");
        public string AddstudentRecord(student_model studentmodel)
        {
            try
            {
                sqlCommand cmd = new SqlCommand("sp_InsertStudent", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddwithValue("@firstname", studentmodel.firstname);
                cmd.Parameters.AddWithValue("@lastname", studentmodel.lastname);
                cmd.Parameters.AddWithValue("@city",studentmodel.)
            }
        }
    }
}