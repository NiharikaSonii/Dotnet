namespace connection;
using MySql.Data.MySqlClient;
using BOL;
public class DBManager{

    public static string conString="host=localhost; user=root; password=root12345; port=3306; database=Trainer";

    public static bool Insert(TrainerD inst){
        bool status=false;
        string query = "INSERT INTO TrainerDetails(id,name,address,doj)" +
                            "VALUES("+ inst.id +",'" + inst.name + "','" + inst.address + "','" + inst.doj + "')";

        MySqlConnection con = new MySqlConnection();
        con.ConnectionString = conString;
        try{
            con.Open();
            MySqlCommand command = new MySqlCommand(query, con);
            command.ExecuteNonQuery();  
            status = true;
        } 
        catch (Exception e)
        {
            throw e;
        }
        finally
        {
            con.Close();
        }               
        return status;
     }
}
