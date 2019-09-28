using AllSalesApp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllSalesApp.Services
{
    class LogInServices : Repository
    {
        public bool ValidaLogIn(LogInVendedor logIn)
        {
            bool rs = false;
            SqlConnection oConnection = new SqlConnection(@"Server=localhost;Data Source=DESKTOP-US09U7O\SQLEXPRESS;Database=AllSalesApp;Integrated Security=SSPI");

            if (oConnection.State != System.Data.ConnectionState.Open)
            {
                oConnection.Open();
            }
            SqlParameter paramCedula= new SqlParameter("@Cedula", logIn.Login);

            SqlParameter paramPass = new SqlParameter("@password", logIn.Password);

            string sql = "SELECT Cedula, Password FROM tblVendedor WHERE(Cedula = @Cedula) AND(Password = @password)";

            SqlCommand oCommand = new SqlCommand();
            oCommand.Connection = oConnection;
            oCommand.CommandType = System.Data.CommandType.Text;
            oCommand.CommandText = sql;
            oCommand.Parameters.Add(paramCedula);
            oCommand.Parameters.Add(paramPass);

            SqlDataReader sqlDataReader = oCommand.ExecuteReader();

            if (sqlDataReader.HasRows == true)
            {
                while (sqlDataReader.Read())
                {
                    if (sqlDataReader["Cedula"] != DBNull.Value)
                    {
                        rs = true;
                    }
                    if (sqlDataReader["Password"] != DBNull.Value)
                    {
                        rs = true;
                    }
                }
            }
            else
            {
                rs = false;
            }
            return rs;
        }

        public void CreateObj(object obj)
        {
            throw new NotImplementedException();
        }

        public void DeleteObj(object obj)
        {
            throw new NotImplementedException();
        }

        public void UpdateObj(object obj)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~LogInServices() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }
        #endregion

    }
}
