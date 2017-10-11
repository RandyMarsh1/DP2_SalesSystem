using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesSystemV3
{

    /// <summary>
    /// I Coordinate everything
    /// 
    /// </summary>
    class Controller
    {
        // Controller is singleton
        private static Controller _instance = new Controller();

        public Inventory Inv { get; }
        public FileHandler File { get; } 
        public Database Data { get; }
        
        //public Predicition Predict;

        
        // Constructor
        private Controller()
        {
            Inv = new Inventory();
            Data = new Database();
            File = new FileHandler();

           

        }

        // Returns this intance of the controller
        public static Controller GetController()
        {
            return _instance;
        }
 


    }
}
