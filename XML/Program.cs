using System.Data.SqlClient;

namespace XML
{
    internal static class Program
    {
        public static string connetionString = "";
        public static SqlConnection? cnn;

        [STAThread]
        static void Main()
        {
            connetionString = @"Data Source=LAPTOP-2PI3677V;Initial Catalog=QLVT;User ID=sa;Password=kc";
            cnn = new SqlConnection(connetionString);
            cnn.Open();


            ApplicationConfiguration.Initialize();
            Application.Run(new FormMenu());

            cnn.Close();
        }
    }
}