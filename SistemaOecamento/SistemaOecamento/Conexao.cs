using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaOecamento
{
    public class Conexao
    {
        string conexao = "SERVER=localhost; DATABASE=orcamento; UID=root; PWD=;";

        public MySqlConnection con = null;

        public void AbrirConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Open();
            }
            catch (Exception ex)
            {

                MessageBox.Show("erro ao conectat" + ex.Message);
            }
        }
        public void FecharConexao()
        {
            try
            {
                con = new MySqlConnection(conexao);
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("erro ao disconectar" + ex.Message);
            }
        }
    }

}
