namespace EmbaralhandoNomes;

public class Pessoa
{
    public Pessoa(int i, string n)
    {
        this.Id = i;
        this.Nome = n;
    }

    public int Id { get; set; }

    public string Nome { get; set; }

    public override string ToString()
    {
        return $"{Id} - {Nome}";
    }
}