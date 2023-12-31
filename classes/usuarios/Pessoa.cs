namespace trabalho_oop.classes.usuarios
{
    public class Pessoa
    {
        private string nome;
        private Endereco endereco;

        public Pessoa (
            string nome,
            Endereco endereco
        ) {
            this.nome = nome;
            this.endereco = endereco;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public Endereco Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public override string ToString()
        {
            return $"Nome: {nome}, " +
                   $"Endereço: {endereco.Rua}, {endereco.Numero}, ({endereco.Complemento}) - " +
                   $"{endereco.Cidade}, {endereco.Uf}";
        }
    }
}