using MySql.Data.MySqlClient;
using System;

class ConexaoDB{

    public static MySqlConnection CreateDataBaseConnection()
    {
        string connectionString = "server=sql.freedb.tech;userid=freedb_iago_silva;password=!&5vwQ2Q9D$5F6@;database=freedb_iago_db";
        MySqlConnection dataBaseConnection = new MySqlConnection(connectionString);
        return dataBaseConnection;
    }

    public void ExecutarConsulta(MySqlCommand comando)
    {
        using (MySqlConnection conexao = CreateDataBaseConnection())
        {
            try
            {
                conexao.Open();
                comando.Connection = conexao;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao executar a consulta: " + ex.Message);
            }
        }
    }
}