namespace FichaInscricoes
{     
    public partial class Form1 : Form
    {
        CursoSelecionado cursos= new CursoSelecionado();
       
        
        public Form1()
        {
            InitializeComponent();
             
        }
        private void dtDataDeNascimento_Leave(object sender, EventArgs e)
        {
            FichaInscricao idadeFicha = new FichaInscricao(dtDataDeNascimento.Value);

            txtIdade.Text = Convert.ToString(idadeFicha.Idade);

        }
        private void btnCadastrar_Click(object sender, EventArgs e)

        {
            var curso = cursos.Cursos;

            FichaInscricao fichaLista = new FichaInscricao(txtNome.Text, txtCurso.Text, txtEscolaridade.Text, dtDataDeNascimento.Value, float.Parse(txtValorCurso.Text), float.Parse(txtValorDesconto.Text), float.Parse(txtValorMulta.Text));

            CobrarCurso custoLista = new CobrarCurso();

            custoLista.RetornaValorResultado(float.Parse(txtValorCurso.Text), float.Parse(txtValorMulta.Text), float.Parse(txtValorDesconto.Text));

            if (fichaLista.ValorDoDesconto == 0)
                curso.Add(FormatacaoTexto.FichaFormatacao(fichaLista.Nome, fichaLista.Curso, fichaLista.ValorCurso, custoLista.Resultado));
            else if (fichaLista.ValorDoDesconto > 0)
                curso.Add(FormatacaoTexto.FichaFormatacao(fichaLista.Nome, fichaLista.Curso, fichaLista.ValorCurso, fichaLista.ValorDoDesconto, custoLista.Resultado));
            else if (fichaLista.ValorDoDesconto > 0 && fichaLista.Idade < 18)
            {
                curso.Add(FormatacaoTexto.FichaFormatacao(fichaLista.Nome, fichaLista.Curso, fichaLista.ValorCurso, fichaLista.ValorDoDesconto, fichaLista.Idade, custoLista.Resultado));
            }
            listCadastro.DataSource = null;
            listCadastro.DataSource = curso;



            FichaInscricao ficha = new FichaInscricao(txtNome.Text, txtCurso.Text, txtEscolaridade.Text, dtDataDeNascimento.Value, float.Parse(txtValorCurso.Text), float.Parse(txtValorDesconto.Text), float.Parse(txtValorMulta.Text));
            
           CobrarCurso custo = new CobrarCurso();

            custo.RetornaValorResultado(float.Parse(txtValorCurso.Text), float.Parse(txtValorMulta.Text), float.Parse(txtValorDesconto.Text));

            if (ficha.ValorDoDesconto == 0)
                txtCadastro.Text =  FormatacaoTexto.FichaFormatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso, custo.Resultado);
            else if (ficha.ValorDoDesconto > 0)
                txtCadastro.Text = FormatacaoTexto.FichaFormatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso, ficha.ValorDoDesconto, custo.Resultado);
            else if (ficha.ValorDoDesconto > 0 && ficha.Idade < 18)
            {
                txtCadastro.Text = FormatacaoTexto.FichaFormatacao(ficha.Nome, ficha.Curso, ficha.ValorCurso, ficha.ValorDoDesconto, ficha.Idade, custo.Resultado);
            }

            txtNome.Text = "";
            txtCurso.Text = "";
            txtEscolaridade.Text = "";
            dtDataDeNascimento.Text = "";
            txtIdade.Text = "";
            txtValorCurso.Text = "";
            txtValorDesconto.Text = "";
            txtValorMulta.Text = "";
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCurso.Text = "";
            txtEscolaridade.Text = "";
            dtDataDeNascimento.Text = "";
            txtIdade.Text = "";
            txtValorCurso.Text = "";
            txtValorDesconto.Text = "";
            txtValorMulta.Text = "";

        }
    }
}