using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Text.RegularExpressions;


public partial class Triggers
{
    // Enter existing table or view for the target and uncomment the attribute line
    [Microsoft.SqlServer.Server.SqlTrigger(Name = "InsertPersonalDetailsTrg", Target = "PersonalDetails_TB1", Event = "FOR INSERT")]
    public static void InsertPersonalDetailsTrg()
    {
        SqlTriggerContext triggContext = SqlContext.TriggerContext;
        if (triggContext.TriggerAction == TriggerAction.Insert)
        {
            var conn = new SqlConnection("Context Connection=true");
            var cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT UserName FROM INSERTED";
            conn.Open();
            string uname = (string)cmd.ExecuteScalar();
            conn.Close();
            if (!Regex.IsMatch(uname, @"([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"))
            {
                throw new FormatException("Invalid user name");
            }
            else
                SqlContext.Pipe.Send("Trigger FIRED");
        }   

    }
}
