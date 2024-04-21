using MySql.Data.MySqlClient;
using TrabalhoDesignPatternUMC.domain;

namespace TrabalhoDesignPatternUMC.Service;

public class RegistrarDAO
{
    
        internal void InserirRegistroDAO(Registros registros)
        {
            try
            {
                ConexaoDB conexao = new ConexaoDB();
                string consulta = $"INSERT INTO timeout(tipo_calculo, tempo_requisicao, tempo_limite) " +
                                $"VALUES('{registros.getCalculo()}', {registros.getRequisicao()}, {registros.getTempoLimite()})";
                using (MySqlConnection conexaoMySQL = ConexaoDB.CreateDataBaseConnection())
                {
                    conexaoMySQL.Open(); 
                    MySqlCommand comando = new MySqlCommand(consulta, conexaoMySQL); 
                    comando.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao inserir livro: " + ex.Message);
            }
        }
}