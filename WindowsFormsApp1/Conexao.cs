using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public static class Conexao
    {
        #region Métodos públicos

            public static bool Testar(string strConexao)
            {
                return TestarConSQL(strConexao);
            }

        public static List<String> GetTabelas(string strConexao)
        {
            List<String> ret = new List<String>();

            DataTable dt;
            String getSchemaTableText = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_TYPE";

            SqlDataAdapter da = new SqlDataAdapter(getSchemaTableText, strConexao);
            dt = new DataTable();
            da.Fill(dt);

            DataTableReader dr = dt.CreateDataReader();

            while (dr.Read())
            {
                string aux = dr["TABLE_NAME"].ToString();
                if (aux.Substring(0, 3).ToLower() != "sys")
                {
                    ret.Add(aux);
                }

            }

            return ret;
        }

        //public List<Coluna> GetColunas(string tabela)
        //{
        //    List<Coluna> ret = new List<Coluna>();

        //    if (this.TipoBanco == Conexao.TiposDeBanco.SQLServer)
        //    {
        //        ret = GetColunasSQL(tabela);
        //    }

        //    return ret;
        //}

        #endregion

        #region métodos privados


        //private DataTable GetTabelasSQL(String stringCon, String strCon)
        //{
        //    DataTable dt;
        //    String getSchemaTableText = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_TYPE";

        //    SqlDataAdapter da = new SqlDataAdapter(getSchemaTableText, strCon);
        //    dt = new DataTable();
        //    da.Fill(dt);

        //    return dt;
        //}

        private static Boolean TestarConSQL(String stringCon)
        {
            SqlConnection con = new SqlConnection();
            Boolean ret = false;

            try
            {
                con.ConnectionString = stringCon;
                con.Open();

                ret = true;
            }
            catch (System.Exception ex)
            {
                ret = false;
            }
            finally
            {
                con.Close();
            }

            return ret;

        }



            //private List<Coluna> GetColunasSQL(String tabela)
            //{
            //    DataTable dt;
            //    List<Coluna> ret = new List<Coluna>();
            //    String sqlNomesCampos = "SELECT column_name 'nome', data_type 'tipo', CHARacter_maximum_length 'tamanho' FROM information_schema.columns WHERE table_name = '" + tabela + "' ORDER BY ORDINAL_POSITION;";

            //    SqlDataAdapter da = new SqlDataAdapter(sqlNomesCampos, this.strConexao);
            //    dt = new DataTable();
            //    da.Fill(dt);

            //    DataTableReader dr = dt.CreateDataReader();

            //    while (dr.Read())
            //    {
            //        string nome = dr["nome"].ToString();
            //        IList<Coluna.TiposDeColuna> ListaTipo = Generic.ConverterTipoSqlParaTipoDotNet(dr["tipo"].ToString(), this.TipoBanco);
            //        string tipoDB = Convert.ToString(dr["tipo"]);
            //        int tamanho = (!(dr["tamanho"] is DBNull) ? Convert.ToInt32(dr["tamanho"]) : 0);

            //        Coluna aux = new Coluna(nome, isPK(tabela, nome), ListaTipo, tipoDB, tamanho);
            //        ret.Add(aux);

            //    }

            //    return ret;

            //}

            //private Boolean isPK(string tabela, string nomeColuna)
            //{
            //    String query = "SELECT ColumnName = col.column_name FROM information_schema.table_constraints tc " +
            //                    "INNER JOIN information_schema.key_column_usage col ON col.Constraint_Name = tc.Constraint_Name " +
            //                    "AND col.Constraint_schema = tc.Constraint_schema " +
            //                    "WHERE tc.Constraint_Type = 'Primary Key' AND col.Table_name=@tabela and " +
            //                    "col.COLUMN_NAME=@nomeColuna ";

            //    //SqlConnection connection = new SqlConnection(this.strConexao);
                



            //    using (SqlConnection con = new SqlConnection(this.strConexao))
            //    {
            //        con.Open();

            //        SqlCommand command = new SqlCommand(query, con);
            //        command.Parameters.AddWithValue("@tabela", tabela);
            //        command.Parameters.AddWithValue("@nomeColuna", nomeColuna);

            //        using (SqlDataReader dr = command.ExecuteReader())
            //        {                       
            //            return dr.HasRows;
            //        }

            //    }
            //}


        #endregion

    }
}
