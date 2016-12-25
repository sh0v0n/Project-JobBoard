using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobBoard.Core
{
    class profileQuery
    {
       
        string query;
        public void recruiter(User currentUser)
        {
            query="SELECT * FROM job_info WHERE recruiter_id='"+ User.currentUser.UserId +"'";
               
                
        }
    }
}
