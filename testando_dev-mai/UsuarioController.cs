﻿using Microsoft.Win32;
using Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuarioController
    {//instanciei o objeto conexao
        Conexao con = new Conexao();
        //criando o metodo de cadastrar usuário
        public bool cadastrar(UsuarioModelo usuario)//passo o objeto usuario
        {//declaro a variavel da resposta da query
            bool resultado = false;
            string sql = "insert into usuario(nome,senha,id_perfil) " +
                "values('" + usuario.nome + "','" + usuario.senha + "'," + usuario.idperfil + ")";
            //chamando minha conexao
            MySqlConnection sqlCon = con.getConexao();
            sqlCon.Open();//abrindo o banco
            MySqlCommand cmd = new MySqlCommand(sql, sqlCon);
            if (cmd.ExecuteNonQuery() >= 1)//executar o seu sql
                resultado = true;
            sqlCon.Close();//fecho a conexao
            return resultado;//retorno o valor
        }

        public DataTable ObterDados(string sql)
        {
            //crio uma nova tabela de dados
            DataTable dt = new DataTable();
            //conn é a conexão com o banco de dados
            MySqlConnection conn = con.getConexao();
            conn.Open();//Abre o Banco de Dados
                        //Preparo o comando sql
            MySqlCommand sqlCon = new MySqlCommand(sql, conn);
            //tipo de instrução de texto
            sqlCon.CommandType = System.Data.CommandType.Text;
            sqlCon.CommandText = sql;
            //Irá montar as informações da consulta
            MySqlDataAdapter dados = new MySqlDataAdapter(sqlCon);
            dados.Fill(dt);//Montar a tabela de dados
            conn.Close();//fecho a conexao
            return dt;//retorna as informações da tabela
        }

        public bool Excluir(int codigo)
        {
            bool resultado = false;
            MySqlConnection sqlcon = con.getConexao();
            string sql = "delete from usuario where id_usuario=" + codigo;
            sqlcon.Open();
            MySqlCommand mySqlCommand = new MySqlCommand(sql, sqlcon);
            mySqlCommand.CommandType = System.Data.CommandType.Text;
            mySqlCommand.CommandText = sql;
            if (mySqlCommand.ExecuteNonQuery() >= 1)
            {
                resultado = true;
            }
            return resultado;

        }


        public UsuarioModelo CarregaUsuario(int codigo)
        {
            UsuarioModelo us = new UsuarioModelo();
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            string sql = "SELECT * from usuario where idusuario=@id";
            MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
            cmd.Parameters.AddWithValue("@id", codigo);
            MySqlDataReader registro=cmd.ExecuteReader();
            if(registro.HasRows)
            {
                registro.Read();

                us.nome = registro["nome"].ToString();
                us.senha = registro["senha"].ToString();
                us.idusuario = Convert.ToInt32(registro["idusuario"]);
                us.idperfil = Convert.ToInt32(registro["id_perfil"]);
            }
            sqlcon.Close();
            return us;
        }


        public bool editar(UsuarioModelo us)
        {
            bool resultado = false;
            string sql = "update usuario set nome=@nome, senha=@senha,id_perfil=@perfil where id_usuario=@id";
            MySqlConnection sqlcon = con.getConexao();
            sqlcon.Open();
            MySqlCommand command = new MySqlCommand(sql, sqlcon);
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;

            //substituindo a variavel @____ pelo conteúdo do objeto.
            command.Parameters.AddWithValue("@nome", us.nome);
            command.Parameters.AddWithValue("@senha", us.senha);
            command.Parameters.AddWithValue("@idperfil", us.idperfil);
            command.Parameters.AddWithValue("@id", us.idusuario);
            if (command.ExecuteNonQuery() >= 1)
                return true;

            sqlcon.Close();
            return resultado;
        }
        public bool logar(UsuarioModelo us)
        {
            try {
                bool resultado = false;
                int registro;
                string sql = "SELECT count(idusuario) from usuario where nome=@usuario and senha=@senha";
                MySqlConnection sqlcon = con.getConexao();
                sqlcon.Open();
                MySqlCommand cmd = new MySqlCommand(sql, sqlcon);
                cmd.Parameters.AddWithValue("@usuario", us.nome);
                cmd.Parameters.AddWithValue("@senha", us.senha);
                registro = Convert.ToInt32(cmd.ExecuteScalar());
                if (registro == 1)
                    resultado = true;

                return resultado;
            }catch(Exception ex)
               {
                throw new Exception(ex.Message);
            }
        }
    }
}
   
    

