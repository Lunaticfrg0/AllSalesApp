using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSalesApp.Entities
{
    class LogInVendedor
    {
        //fields

        private string _login_id;

        private string _pass_word;

        //constructores

        public LogInVendedor() { }

        public LogInVendedor(string logID, string password)
        {
            this._login_id = logID;

            this._pass_word = password;


        }

        //properties

        public string Login { get { return this._login_id; } set { this._login_id = value; } }

        public string Password { get { return this._pass_word; } set { this._pass_word = value; } }
    }
}
         
    

