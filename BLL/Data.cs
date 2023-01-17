namespace BLL;
using BOL;
using connection;
public class Data{

        public bool insert(TrainerD trainer)
        {
            bool status = DBManager.Insert(trainer);
            return status;
        }
       }

    
