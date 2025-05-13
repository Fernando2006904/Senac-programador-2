using GestãoRH;
using GestaoRH.BancoDados.Dominio;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Drawing;

namespace GestaoRH
{
    internal class Repositorio
    {
        public static string _conexao = "server=localhost;user=root;password=;database=gestaorh;";



        public static int InserirFuncionario(Funcionario funcionario)
        {
            using (var con = new MySqlConnection(_conexao))
            {
                con.Open();
                string sql = @"INSERT INTO Funcionario (NomeCompleto, Cpf, Rg, DataNascimento, Genero, EstadoCivil, Situacao)
                        VALUES (@nome, @cpf, @rg, @dataNascimento, @genero, @estadoCivil, @Situacao)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@nome", funcionario.NomeCompleto);
                    cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
                    cmd.Parameters.AddWithValue("@rg", funcionario.RG);
                    cmd.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@genero", funcionario.Genero);
                    cmd.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
                    cmd.Parameters.AddWithValue("@Situacao", funcionario.Situacao);
                    cmd.ExecuteNonQuery();
                }

                var selectId =  @"select id from funcionario 
                                  where NomeCompleto = @nome 
                                    and Cpf = @cpf 
                                    and Rg = @rg 
                                    and DataNascimento = @dataNascimento 
                                    and Genero = @genero
                                    and EstadoCivil = @estadoCivil";
                using (var cmd = new MySqlCommand(selectId, con))
                {
                    cmd.Parameters.AddWithValue("@nome", funcionario.NomeCompleto);
                    cmd.Parameters.AddWithValue("@cpf", funcionario.CPF);
                    cmd.Parameters.AddWithValue("@rg", funcionario.RG);
                    cmd.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@genero", funcionario.Genero);
                    cmd.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
                    cmd.Parameters.AddWithValue("@Situacao", funcionario.Situacao);
                    using (var reader = cmd.ExecuteReader())
                    {
                        return reader.Read() ? reader.GetInt32("id") : 0;
                    }
                }
            }

        }

        public static void InserirDependente(Dependente dependente, int idFuncionario)
        {
            using (var con = new MySqlConnection(_conexao))
            {
                con.Open();
                string sql = @"INSERT INTO dependentes (FuncionarioId, NomeCompleto, Cpf, Rg, DataNascimento, Genero, Parentesco)
                        VALUES (@funcionarioId, @nome, @cpf, @rg, @dataNascimento, @genero, @Parentesco)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@funcionarioId", idFuncionario);
                    cmd.Parameters.AddWithValue("@nome", dependente.NomeCompleto);
                    cmd.Parameters.AddWithValue("@cpf", dependente.CPF);
                    cmd.Parameters.AddWithValue("@rg", dependente.RG);
                    cmd.Parameters.AddWithValue("@dataNascimento", dependente.DataNascimentoDependente);
                    cmd.Parameters.AddWithValue("@genero", dependente.GeneroDependente);
                    cmd.Parameters.AddWithValue("@Parentesco", dependente.Parentesco);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InserirEndereco(Endereco Endereco, int idFuncionario)
        {
            using (var con = new MySqlConnection(_conexao))
            {
                con.Open();
                string sql = @"INSERT INTO Endereco (FuncionarioId, cep, Logradouro, Numero, Complemento, Bairro, cidade, estado)
                        VALUES (@funcionarioId, @cep, @Logradouro, @Numero, @Complemento, @Bairro, @cidade, @estado)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@funcionarioId", idFuncionario);
                    cmd.Parameters.AddWithValue("@cep", Endereco.CEP);
                    cmd.Parameters.AddWithValue("@logradouro", Endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", Endereco.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", Endereco.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", Endereco.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", Endereco.Cidade);
                    cmd.Parameters.AddWithValue("@estado", Endereco.Estado);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Tudo Certo");
            }

        }

        public static void InserirFuncao(Funcao funcao, int idFuncionario)
        {
            using (var con = new MySqlConnection(_conexao))

            {
                con.Open();
                string sql = @"INSERT INTO funcao (FuncionarioId, cargo, departamento, DataAdmissao, Salario)
                        VALUES (@funcionarioId, @cargo, @departamento, @DataAdmissao, @Salario)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@funcionarioId", idFuncionario);
                    cmd.Parameters.AddWithValue("@cargo", funcao.Cargo);
                    cmd.Parameters.AddWithValue("@departamento", funcao.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcao.DataAdmissao);
                    cmd.Parameters.AddWithValue("@Salario", funcao.Salario);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void AtualizarFuncionario(Funcionario  funcionario, Endereco endereco, Funcao funcao)
        {
            using(var con = new MySqlConnection(_conexao))
            {
                con.Open();

                string sqlFuncionario = @"
                            UPDATE funcionario 
                            SET 
                                Nomecompleto = @NomeCompleto,
                                Cpf = @Cpf,
                                Rg = @Rg,
                                DataNascimento = @DataNascimento,
                                Genero = @Genero,
                                EstadoCivil = @EstadoCivil,
                                Situacao = @Situacao 
                            WHERE Id = @Id";

                using (var cmd = new MySqlCommand( sqlFuncionario, con))
                {
                    
                    cmd.Parameters.AddWithValue("@NomeCompleto", funcionario.NomeCompleto);
                    cmd.Parameters.AddWithValue("@Cpf", funcionario.CPF);
                    cmd.Parameters.AddWithValue("@Rg", funcionario.RG);
                    cmd.Parameters.AddWithValue("@DataNascimento", funcionario.DataNascimento);
                    cmd.Parameters.AddWithValue("@Genero", funcionario.Genero);
                    cmd.Parameters.AddWithValue("@EstadoCivil", funcionario.EstadoCivil);
                    cmd.Parameters.AddWithValue("@Situacao", funcionario.Situacao);
                    cmd.Parameters.AddWithValue("@Id", funcionario.Id);
                    cmd.ExecuteNonQuery();
                }
                string SqlEndereco = "UPDATE endereco" +
                    " SET" +
                    "     Cep = @Cep,   Logradouro = @Logradouro,    Numero = @Numero,    " +
                    "Complemento = @Complemento,    Bairro = @Bairro,    Cidade = @Cidade,   " +
                    "Estado = @Estado WHERE Id = @Id";


                using (var cmd = new MySqlCommand(SqlEndereco, con))
                {
                    cmd.Parameters.AddWithValue("@cep", endereco.CEP);
                    cmd.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
                    cmd.Parameters.AddWithValue("@Numero", endereco.Numero);
                    cmd.Parameters.AddWithValue("@Complemento", endereco.Complemento);
                    cmd.Parameters.AddWithValue("@Bairro", endereco.Bairro);
                    cmd.Parameters.AddWithValue("@Cidade", endereco.Cidade);
                    cmd.Parameters.AddWithValue("@estado", endereco.Estado);
                    cmd.Parameters.AddWithValue("@Id", endereco.Id);
                    cmd.ExecuteNonQuery();
                }

                string sqlFuncao = "UPDATE funcao" +
                    " SET     Cargo = @Cargo,   Departamento = @Departamento,    DataAdmissao = " +
                    "@DataAdmissao,    Salario " +
                    "= @Salario WHERE Id = @Id";
                using (var cmd = new MySqlCommand(sqlFuncao, con))
                {
                    cmd.Parameters.AddWithValue("@cargo", funcao.Cargo);
                    cmd.Parameters.AddWithValue("@departamento", funcao.Departamento);
                    cmd.Parameters.AddWithValue("@DataAdmissao", funcao.DataAdmissao);
                    cmd.Parameters.AddWithValue("@Salario", funcao.Salario);
                    cmd.Parameters.AddWithValue("@Id", funcao.Id);
                    cmd.ExecuteNonQuery();
                }
            }

            

                
            
        }

        

        




        public static List<Funcionario> ObterTodos()
        {
            var lista = new List<Funcionario>();

            using (var con = new MySqlConnection(_conexao))

            {

                con.Open();

                string sql = "SELECT * FROM Funcionario";

                using (var cmd = new MySqlCommand(sql, con))

                using (var reader = cmd.ExecuteReader())

                {

                    while (reader.Read())

                    {

                        var funcionario = new Funcionario

                        {

                            Id = Convert.ToInt32(reader["Id"]),

                            NomeCompleto = reader["NomeCompleto"].ToString(),

                            CPF = reader["Cpf"].ToString(),

                            RG = reader["Rg"].ToString(),

                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),

                            Genero = reader["Genero"].ToString(),

                            EstadoCivil = reader["EstadoCivil"].ToString()

                        };

                        lista.Add(funcionario);

                    }

                }
            }


            return lista;

        }

        public static Funcionario ObterPorId(int id)

        {

            using (var con = new MySqlConnection(_conexao))

            {

                con.Open();

                string sql = "SELECT * FROM Funcionario WHERE Id = @id";

                using (var cmd = new MySqlCommand(sql, con))

                {

                    cmd.Parameters.AddWithValue("@id", id);

                    using (var reader = cmd.ExecuteReader())

                    {

                        if (reader.Read())

                        {

                            return new Funcionario

                            {

                                Id = Convert.ToInt32(reader["Id"]),

                                NomeCompleto = reader["NomeCompleto"].ToString(),

                                CPF = reader["Cpf"].ToString(),

                                RG = reader["Rg"].ToString(),

                                DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),

                                Genero = reader["Genero"].ToString(),

                                EstadoCivil = reader["EstadoCivil"].ToString()

                            };

                        }

                    }

                }

            }

            return null;

        }

        public static Funcionario CarregarFuncionario()
        {
            using (var con = new MySqlConnection(_conexao))
            {
                con.Open();
                string sql = "SELECT\r\n    f.Id,\r\n    f.NomeCompleto,\r\n    f.Cpf,\r\n    f.Rg,\r\n    f.DataNascimento,\r\n    f.Genero,\r\n    f.EstadoCivil,\r\n    e.Cep,\r\n    e.Logradouro,\r\n    e.Numero,\r\n    e.Complemento,\r\n    e.Bairro,\r\n    e.Cidade,\r\n    e.Estado\r\nFROM funcionario f\r\nINNER JOIN endereco e ON f.Id = e.FuncionarioId;\r\n";
                using (var cmd = new MySqlCommand(sql, con))

                using (var reader = cmd.ExecuteReader())

                {

                    while (reader.Read())

                    {

                        var funcionario = new Funcionario

                        {

                            Id = Convert.ToInt32(reader["id"]),

                            NomeCompleto = reader["NomeCompleto"].ToString(),

                            CPF = reader["Cpf"].ToString(),

                            RG = reader["Rg"].ToString(),

                            DataNascimento = Convert.ToDateTime(reader["DataNascimento"]),

                            Genero = reader["Genero"].ToString(),

                            EstadoCivil = reader["EstadoCivil"].ToString()

                        };

                        var Endereco = new Endereco
                        {
                            CEP = reader["Cep"].ToString(),
                            Logradouro = reader["Logradouro"].ToString(),
                            Numero = reader["Numero"].ToString(),
                            Bairro = reader["Bairro"].ToString(),
                            Cidade = reader["Cidade"].ToString(),
                            Estado = reader["Estado"].ToString(),

                        };



                    }

                }

            }

            return new Funcionario
            {

            };
        }

        public static bool CpfExisteNoBanco(string cpf)
        {
            string conexao = "server=localhost;database=gestaorh;uid=root;pwd=;";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                string query = "SELECT COUNT(*) FROM Clientes WHERE CPF = @cpf";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    conn.Open();
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }




        internal static void Inserir(Form1 form1)
        {
            throw new NotImplementedException();
        }


    }
    
}
