using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//adicionando namespace
using Projeto_BancoDados_TurmaB.Model_DTO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_BancoDados_TurmaB.Controller_DAO
{
    internal class DAO_Usuario
    {
        ConexaoMySQL conexao = new ConexaoMySQL();

        #region Método de Login do App
        public DTO_Usuario Login (DTO_Usuario usu)
        {
            MySqlConnection cn = conexao.String_Conexao();
            try
            {
                string comando = "select * from tb_usuario where email_usu = @email and senha_usu = @senha";

                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@email", usu.Email_usu);
                cmd.Parameters.AddWithValue("@senha", usu.Senha_usu);
                cn.Open();

                MySqlDataAdapter ad = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                ad.Fill(dt);

                foreach (DataRow linha in dt.Rows)
                {
                    usu.Id_usu = Convert.ToInt32(linha["id_usu"]);
                    usu.Email_usu = linha["email_usu"].ToString();
                    usu.Nome_usu = linha["nome_usu"].ToString();
                    usu.Senha_usu = linha["senha_usu"].ToString();
                }
                return usu;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cn.Close();
            }
        }
        #endregion

        #region Metodo para inserir usuario

        public object Inserir (DTO_Usuario usuario)
        {
            MySqlConnection cn = conexao.String_Conexao();
            try
            {
                string comando = "sp_Inserir";
                MySqlCommand cmd = new MySqlCommand(comando, cn);
                cmd.Parameters.AddWithValue("@nome", usuario.Nome_usu);
                cmd.Parameters.AddWithValue("@senha", usuario.Senha_usu);
                cmd.Parameters.AddWithValue("email", usuario.Email_usu);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();

                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { cn.Close(); }
        }

        #endregion
    }
}
