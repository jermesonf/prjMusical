using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjMusical
{
    public partial class Form1 : Form
    {
        ClasseConexao conexao;
        DataTable dataTable;

        int ponteiro = -1;


        int quantidade = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void consultarDados(String sql)
        {
            conexao = new ClasseConexao();
            dataTable = new DataTable();
            dataTable = conexao.executarSQL(sql);
            quantidade = dataTable.Rows.Count;
            mostrarDados(0);

        }
        private void mostrarDados(int pos)
        {
            txtId.Text = dataTable.Rows[pos][0].ToString();
            txtNome.Text = dataTable.Rows[pos][1].ToString();
            txtLoc.Text = dataTable.Rows[pos][2].ToString();
        }


        private void btnAvancar_Click(object sender, EventArgs e)
        {
            //Insatanciamento
            conexao = new ClasseConexao();
            dataTable = new DataTable();

            //Executando comandos SQL
            dataTable = conexao.executarSQL("SELECT * FROM musica");

            //MessageBox.Show(dataTable.Rows[4]["descricao"].ToString());

            ponteiro++;
            try
            {
                if (ponteiro > 4)
                {
                    MessageBox.Show("Fim");
                }
                else
                {
                    txtLoc.Text = dataTable.Rows[ponteiro]["localizacao_do_album"].ToString();
                    txtNome.Text = dataTable.Rows[ponteiro]["descricao"].ToString();
                }
            }
            catch(Exception erro)
            {
                
            }



        }

        private void btnRetroceder_Click(object sender, EventArgs e)
        {
            //Insatanciamento
            conexao = new ClasseConexao();
            dataTable = new DataTable();

            //Executando comandos SQL
            dataTable = conexao.executarSQL("SELECT * FROM musica");

            //MessageBox.Show(dataTable.Rows[4]["descricao"].ToString());

            ponteiro--;
            try
            {
                if (ponteiro < 0)
                {
                    MessageBox.Show("Fim");
                }
                else
                {
                    txtLoc.Text = dataTable.Rows[ponteiro]["localizacao_do_album"].ToString();
                    txtNome.Text = dataTable.Rows[ponteiro]["descricao"].ToString();
                }
            }
            catch (Exception erro)
            {

            }
        }

        private void btnAvancarFim_Click(object sender, EventArgs e)
        {
            //Insatanciamento
            conexao = new ClasseConexao();
            dataTable = new DataTable();

            //Executando comandos SQL
            dataTable = conexao.executarSQL("SELECT * FROM musica");

            //MessageBox.Show(dataTable.Rows[4]["descricao"].ToString());

            ponteiro = 4;
            try
            {
                if (ponteiro > 4)
                {
                    MessageBox.Show("Fim");
                }
                else
                {
                    txtLoc.Text = dataTable.Rows[ponteiro]["localizacao_do_album"].ToString();
                    txtNome.Text = dataTable.Rows[ponteiro]["descricao"].ToString();
                }
            }
            catch (Exception erro)
            {

            }
        }

        private void btnRetrocederFim_Click(object sender, EventArgs e)
        {
            //Insatanciamento
            conexao = new ClasseConexao();
            dataTable = new DataTable();

            //Executando comandos SQL
            dataTable = conexao.executarSQL("SELECT * FROM musica");

            //MessageBox.Show(dataTable.Rows[4]["descricao"].ToString());

            ponteiro = 0;
            try
            {
                if (ponteiro < 0)
                {
                    MessageBox.Show("Fim");
                }
                else
                {
                    txtLoc.Text = dataTable.Rows[ponteiro]["localizacao_do_album"].ToString();
                    txtNome.Text = dataTable.Rows[ponteiro]["descricao"].ToString();
                }
            }
            catch (Exception erro)
            {

            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            String texto1 = txtNome.Text;
            String texto2 = txtLoc.Text;

            //Para usar o insert e somente necessario instanciar a classe conexao pois para realizar a insercao nao e necessario a criacao de um dataTable 
            //obs e instanciado sempre, para que apague a antiga instancia e insira uma nova instancia 

            conexao = new ClasseConexao();
            conexao.executarSQL("INSERT INTO musica (descricao, localizacao_do_album) VALUES ('"+texto1+"', '"+texto2+"') ");
            MessageBox.Show("Incluido com sucesso");

            consultarDados("SELECT * FROM musica");
            mostrarDados(0);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            String texto1 = txtNome.Text;
            String texto2 = txtLoc.Text;

            conexao = new ClasseConexao();
            conexao.executarSQL("DELETE FROM musica WHERE (descricao = '" + texto1 + "' and localizacao_do_album = '" + texto2 + "') ");
            MessageBox.Show("Deletado com sucesso");

            consultarDados("SELECT * FROM musica");
            mostrarDados(0);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            String texto1 = txtNome.Text;
            String texto2 = txtLoc.Text;
            String texto3 = txtId.Text;

            conexao = new ClasseConexao();
            conexao.executarSQL("UPDATE musica SET descricao = '" + texto1 + "', localizacao_do_album = '" + texto2 + "' WHERE  id = '" + texto3 + "' ");
            MessageBox.Show("Atualizado com sucesso");

            consultarDados("SELECT * FROM musica");
            mostrarDados(0);
        }
    }
}
