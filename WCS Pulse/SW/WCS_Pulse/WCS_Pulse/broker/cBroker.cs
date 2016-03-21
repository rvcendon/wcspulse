using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WCS_Pulse
{
    class cBroker
    {
        private System.Data.Odbc.OdbcConnection sqlConn;
        private System.Data.Odbc.OdbcCommand sqlCmd;
        private System.Data.Odbc.OdbcDataAdapter sqlAdapter;
        private System.Data.DataSet sqlDataSet;
        private string connString;
        
        public cBroker(){
            connString = "Driver={Microsoft Access Driver (*.mdb)};DBQ=wcs_pulse_db.mdb;Uid=Admin;Pwd=rodzinfo";
        }

        public int ListarPessoas(cPessoa obj, ref string [][]array){
            string sql;
            try{
                if (obj.sNome == String.Empty)
                    sql = "SELECT ID, nome FROM pessoa";
                else
                    sql = "SELECT ID, nome FROM pessoa WHERE nome like '%" + obj.sNome + "%'";

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();

                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);
                sqlAdapter = new System.Data.Odbc.OdbcDataAdapter();

                sqlAdapter.SelectCommand = sqlCmd;
                

                sqlDataSet = new System.Data.DataSet();
                sqlAdapter.Fill(sqlDataSet, "pessoa");

                System.Data.DataTable dt = sqlDataSet.Tables["pessoa"];
                                
                if (dt.Rows.Count > 0)
                {
                    array = new string[dt.Rows.Count][];
                    int i = 0;
                    foreach(System.Data.DataRow row in dt.Rows){
                        array[i] = new string[2];
                        array[i][0] = row[0].ToString();
                        array[i][1] = row[1].ToString();
                        i++;
                    }
                }

                sqlConn.Close();

                return dt.Rows.Count;
            }catch(Exception Ex){
                return -1;
            }              
        }

        public bool MaterializaPessoa(cPessoa objPessoa) {


            string sql;
            try
            {
                sql = "SELECT ID, nome, sexo, dt_nascimento FROM pessoa where ID = " + objPessoa.ID.ToString();

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();

                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);
                sqlAdapter = new System.Data.Odbc.OdbcDataAdapter();

                sqlAdapter.SelectCommand = sqlCmd;

                sqlDataSet = new System.Data.DataSet();
                sqlAdapter.Fill(sqlDataSet, "pessoa");

                System.Data.DataTable dt = sqlDataSet.Tables["pessoa"];

                if (dt.Rows.Count > 0)
                {
                    System.Data.DataRow linha = dt.Rows[0];
                    objPessoa.ID = int.Parse(linha["ID"].ToString());
                    objPessoa.sNome = linha["nome"].ToString();
                    objPessoa.sSexo = linha["sexo"].ToString();
                    objPessoa.dtDataNasc = DateTime.Parse(linha["dt_nascimento"].ToString());
                }

                sqlConn.Close();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public bool DesmaterializaPessoa(cPessoa objPessoa)
        {
            string sql;
            try
            {
                sql = "INSERT INTO pessoa(nome, sexo, dt_nascimento) values (?, ?, ?)";

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();

                    
                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);

                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.VarChar, 255).Value = objPessoa.sNome;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.VarChar, 1).Value = objPessoa.sSexo;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Date).Value = objPessoa.dtDataNasc;


                if (sqlCmd.ExecuteNonQuery() > 0)
                {
                    sqlConn.Close();
                    return true;
                }
                else
                {
                    sqlConn.Close();
                    return false;
                }

            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public bool DesmaterializaDado(cDados dado)
        {
            string sql;
            try
            {
                sql = "INSERT INTO dados(id_avaliacao, data_hora, freq_cardiaca) values (?, ?, ?)";

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();


                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);

                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value = dado.id_avaliacao;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.DateTime).Value = dado.data;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value = dado.fc;


                if (sqlCmd.ExecuteNonQuery() > 0)
                {
                    sqlConn.Close();
                    return true;
                }
                else
                {
                    sqlConn.Close();
                    return false;
                }

            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public int DesmaterializaAvaliacao(cAvaliacao obj)
        {
            string sql;
            try
            {
                sql = "INSERT INTO avaliacao(id_pessoa, data, idade, peso, altura, nivel_atividade, gordura, vo2, ";
                sql += " desc_atividade, observacoes, fc_max_obtida, fc_min_obtida, fc_media_obtida, fc_basal, tmb) ";
                sql += " values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();


                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);

                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.id_pessoa;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.DateTime).Value     = obj.data_hora;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.idade;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Double).Value       = obj.peso;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Double).Value       = obj.altura;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.nivel_atividade;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Double).Value       = obj.gordura;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Double).Value       = obj.vo2;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.VarChar, 255).Value = obj.atividade;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Text).Value         = obj.observacoes;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.fc_max;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.fc_min;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.fc_med;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.fc_basal;
                sqlCmd.Parameters.Add("", System.Data.Odbc.OdbcType.Int).Value          = obj.tmb;

                
                if (sqlCmd.ExecuteNonQuery() > 0)
                {
                    sql = "select @@identity";
                    sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);
                    int id = (int) sqlCmd.ExecuteScalar();
                    sqlConn.Close();
                    return id;
                }
                else
                {
                    sqlConn.Close();
                    return -1;
                }

            }
            catch (Exception Ex)
            {
                return -1;
            }
        }

        public bool MaterializaAvaliacao(cAvaliacao obj)
        {


            string sql;
            try
            {
                sql = "SELECT a.id as id, ";
                sql += " a.data as data, ";
                sql += " a.idade as idade, ";
                sql += " a.peso as peso, ";
                sql += " a.altura as altura, ";
                sql += " a.nivel_atividade as nivel_atividade, ";
                sql += " a.gordura as gordura, ";
                sql += " a.vo2 as vo2, ";
                sql += " a.desc_atividade as desc_atividade, ";
                sql += " a.observacoes as observacoes, ";
                sql += " a.fc_max_obtida as fc_max_obtida, ";
                sql += " a.fc_min_obtida as fc_min_obtida, ";
                sql += " a.fc_media_obtida as fc_media_obtida, ";
                sql += " a.tmb as tmb, ";
                sql += " a.fc_basal as fc_basal, ";
                sql += " p.nome as x_nome ";
                sql += " FROM avaliacao AS a LEFT JOIN pessoa AS p ON p.id = a.id_pessoa WHERE a.id = " + obj.id.ToString();

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();

                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);
                sqlAdapter = new System.Data.Odbc.OdbcDataAdapter();

                sqlAdapter.SelectCommand = sqlCmd;

                sqlDataSet = new System.Data.DataSet();
                sqlAdapter.Fill(sqlDataSet);

                System.Data.DataTable dt = sqlDataSet.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    System.Data.DataRow linha = dt.Rows[0];
                    obj.id = int.Parse(linha["id"].ToString());
                    obj.idade = int.Parse(linha["idade"].ToString());
                    obj.peso = float.Parse(linha["peso"].ToString());
                    obj.data_hora = DateTime.Parse(linha["data"].ToString());
                    obj.x_nome = linha["x_nome"].ToString();
                    obj.altura = float.Parse(linha["altura"].ToString());
                    obj.nivel_atividade = int.Parse(linha["altura"].ToString());
                }

                sqlConn.Close();
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

        public int ListarAvaliacoes(cAvaliacao obj, ref string[][] array)
        {
            string sql;
            try
            {
                sql = "SELECT a.id as id, a.data as data, p.nome as nome FROM avaliacao AS a LEFT JOIN pessoa AS p ON p.id = a.id_pessoa WHERE 1 = 1 ";

                if (obj.x_nome != String.Empty)
                    sql += " AND p.nome LIKE '%" + obj.x_nome + "%'";

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();

                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);
                sqlAdapter = new System.Data.Odbc.OdbcDataAdapter();

                sqlAdapter.SelectCommand = sqlCmd;


                sqlDataSet = new System.Data.DataSet();
                sqlAdapter.Fill(sqlDataSet);

                System.Data.DataTable dt = sqlDataSet.Tables[0];

                if (dt.Rows.Count > 0)
                {
                    array = new string[dt.Rows.Count][];
                    int i = 0;
                    foreach (System.Data.DataRow row in dt.Rows)
                    {
                        array[i] = new string[3];
                        array[i][0] = row[0].ToString();
                        array[i][1] = row[1].ToString();
                        array[i][2] = row[2].ToString();
                        i++;
                    }
                }

                sqlConn.Close();

                return dt.Rows.Count;
            }
            catch (Exception Ex)
            {
                return -1;
            }
        }

        public int ListarDados(cDados obj, ref cDados[] array)
        {
            string sql;
            try
            {
                sql = "SELECT ID, id_avaliacao, data_hora, freq_cardiaca FROM dados WHERE id_avaliacao = " + obj.id_avaliacao.ToString();

                sqlConn = new System.Data.Odbc.OdbcConnection(connString);
                sqlConn.Open();

                sqlCmd = new System.Data.Odbc.OdbcCommand(sql, sqlConn);
                sqlAdapter = new System.Data.Odbc.OdbcDataAdapter();

                sqlAdapter.SelectCommand = sqlCmd;


                sqlDataSet = new System.Data.DataSet();
                sqlAdapter.Fill(sqlDataSet);

                System.Data.DataTable dt = sqlDataSet.Tables[0];

                foreach (System.Data.DataRow row in dt.Rows)
                {
                    Array.Resize(ref array, array.Length + 1);
                    System.Data.DataRow linha = row;
                    array[array.Length-1] = new cDados();
                    array[array.Length-1].id = int.Parse(linha["id"].ToString());
                    array[array.Length-1].fc = int.Parse(linha["freq_cardiaca"].ToString());
                    array[array.Length-1].data = DateTime.Parse(linha["data_hora"].ToString());
                }

                sqlConn.Close();

                return dt.Rows.Count;
            }
            catch (Exception Ex)
            {
                return -1;
            }
        }

    }
}
