using System.Text;

namespace EmbaralhandoNomes;

internal class Program
{
    static void Main(string[] args)
    {
        string path = Directory.GetParent("./").Parent.Parent.Parent.FullName;
        const string fileNomes = "nomes.txt";

        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        var encode = Encoding.GetEncoding(1252);

        string fileBase = Path.Combine(path, fileNomes);

        List<Pessoa> names = new List<Pessoa>();
        if (File.Exists(fileBase))
        {
            names = ReadFile(fileBase, encode);
            Console.WriteLine("Arquivo lido com sucesso");
        }
        else
            Console.WriteLine("Arquivo não encontrado na pasta");

        List<Pessoa> random = new List<Pessoa>();



        const string fileEmbaralhado = "embaralhado.txt";
        string fileFinal = Path.Combine(path, fileEmbaralhado);

        if (File.Exists(fileFinal))
        {
            WriteFile(fileFinal, random);
            Console.WriteLine("Arquivo escrito com sucesso");
        }
        else
            Console.WriteLine("Arquivo não encontrado na pasta");
    }

    private static void WriteFile(string f, List<Pessoa> nomes)
    {
        try
        {
            StreamWriter sw = new(f);
            foreach (var item in nomes)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Close();
        }
        catch (Exception)
        {
            throw;
        }
    }

    private static List<Pessoa> ReadFile(string f, Encoding encode)
    {
        int id = 0;
        List<Pessoa> update = new List<Pessoa>();
        Pessoa insert;

        try
        {
            var verify = "";
            StreamReader sr = new(f, encode);

            while (verify != null)
            {
                verify = sr.ReadLine();
                if (verify == null)
                {
                    sr.Close();
                    return update;
                }
                else
                {
                    id++;
                    insert = new(id, verify);
                    update.Add(insert);
                }
            }
            sr.Close();
        }
        catch (Exception)
        {
            throw;
        }
        return update;
    }

    static List<Pessoa> FisherYates(List<Pessoa> nomes)
    {

        int n = nomes.Count;
        Random r = new Random();
        List<Pessoa> embaralhado = new List<Pessoa>();

        return embaralhado;
    }
}
