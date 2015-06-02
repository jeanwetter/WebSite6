using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        // Instanciando o DataContext
        trab_marquimDataContext db = new trab_marquimDataContext();

        PESSOA pessoa = new PESSOA();
        pessoa.NOME = txtNome.Text;
        pessoa.RUA = txtRua.Text;
        pessoa.BAIRRO = txtBairro.Text;
        pessoa.CIDADE = txtCidade.Text;
        pessoa.ESTADO = txtEstado.Text;
        pessoa.DATA_ENTRADA = Convert.ToDateTime(txtDtEntrada.Text);
        pessoa.DATA_SAIDA = Convert.ToDateTime(txtDtSaida.Text);
        pessoa.QUARTO = txtQuarto.Text;

        // Adicionando o objeto customer criado para ser
        // incluindo no banco de dados quando o DataContext
        // enviar as atualizaçoes para o banco de dados.
        db.PESSOAs.InsertOnSubmit(pessoa);
        // Enviar as modificaçoes para o banco de dados e inclui o registro na tabela
        db.SubmitChanges();
        Response.Write("<BR> Registro <B>" + pessoa.NOME + "<BR> </B> inserido com sucesso.");
        GridView1.DataBind();
        txtNome.Text = "";
        txtRua.Text = "";
        txtBairro.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtDtEntrada.Text = "";
        txtDtSaida.Text = "";
        txtQuarto.Text = "";


        // Observe que nao existe nenhum comando SQL na aplicação.
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        // Instanciando o DataContext
        trab_marquimDataContext db = new trab_marquimDataContext();

        // Obtendo o registro que queremos alterar
        var pessoa = (from c in db.PESSOAs
                        where c.ID.Equals(lbID.Text)
                        select c).Single();

        // Alterando os dados do objeto que representa o registro que vamos alterar
        pessoa.NOME = txtNome.Text;
        pessoa.RUA = txtRua.Text;
        pessoa.BAIRRO = txtBairro.Text;
        pessoa.CIDADE = txtCidade.Text;
        pessoa.ESTADO = txtEstado.Text;
        pessoa.DATA_ENTRADA = Convert.ToDateTime(txtDtEntrada.Text);
        pessoa.DATA_SAIDA = Convert.ToDateTime(txtDtSaida.Text);
        pessoa.QUARTO = txtQuarto.Text;
        // Enviando as alteraçoes para o banco de dados.
        db.SubmitChanges();

        Response.Write("<BR>  Registro <B>" + pessoa.NOME + "<BR> </B> alterado com sucesso.");
        GridView1.DataBind();
        txtNome.Text = "";
        txtRua.Text = "";
        txtBairro.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtDtEntrada.Text = "";
        txtDtSaida.Text = "";
        txtQuarto.Text = "";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        // Instanciando o DataContext
        trab_marquimDataContext db = new trab_marquimDataContext();

        // Obtendo o registro que queremos alterar
        var pessoa = (from c in db.PESSOAs
                      where c.ID.Equals(lbID.Text)
                      select c).Single();

        db.PESSOAs.DeleteOnSubmit(pessoa);

        // Enviando as alteraçoes para o banco de dados.
        db.SubmitChanges();

        Response.Write("<BR>  Registro <B>" + pessoa.NOME + "<BR> </B> excluido com sucesso.");
        GridView1.DataBind();
        txtNome.Text = "";
        txtRua.Text = "";
        txtBairro.Text = "";
        txtCidade.Text = "";
        txtEstado.Text = "";
        txtDtEntrada.Text = "";
        txtDtSaida.Text = "";
        txtQuarto.Text = "";
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        lbID.Text = GridView1.SelectedRow.Cells[1].Text;
        txtNome.Text = GridView1.SelectedRow.Cells[2].Text;
        txtRua.Text = GridView1.SelectedRow.Cells[3].Text;
        txtBairro.Text = GridView1.SelectedRow.Cells[4].Text;
        txtCidade.Text = GridView1.SelectedRow.Cells[5].Text;
        txtEstado.Text = GridView1.SelectedRow.Cells[6].Text;
        txtDtEntrada.Text = GridView1.SelectedRow.Cells[7].Text;
        txtDtSaida.Text = GridView1.SelectedRow.Cells[8].Text;
        txtQuarto.Text = GridView1.SelectedRow.Cells[9].Text;
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        // Instanciando o DataContext
        trab_marquimDataContext db = new trab_marquimDataContext();

        // Obtendo o registro que queremos alterar
        var pessoa = (from c in db.PESSOAs
                      where c.NOME.Equals(txtFiltro.Text)
                      select c).AsEnumerable();
        GridView2.DataSource = pessoa;
        GridView2.DataBind();
    }
}