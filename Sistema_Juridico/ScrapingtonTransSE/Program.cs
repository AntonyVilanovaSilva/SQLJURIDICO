// See https://aka.ms/new-console-template for more information

using HtmlAgilityPack;
int totalPessoas = 0;
int valoresMaiores = 0;
int numeroMes = 1;
for (int i = 1; i < 12; i++)
{
    var html = @"https://www.transparencia.se.gov.br/Pessoal/VencimentoCargo.xhtml?codigo=4&ano=2022&mes=" +ano+i.ToString();
HtmlWeb web = new HtmlWeb();
    var htmlDoc = web.Load(html);
    var valorMes = 0;
    var tableComossionados = htmlDoc.GetElementbyId("frmPrincipal:Tabela5_data");
    var linhas = tableComossionados.SelectNodes(".//td");

    foreach (var item in linhas)
    {
        var colunas = item.SelectNodes(".//td");
        totalPessoas = totalPessoas + Convert.ToInt32(colunas[1].InnerText);
        valorMes = valorMes + Convert.ToInt32(colunas[1].InnerText);    
    }
    Console.WriteLine("Quantidade no mes {0} é de: {1} ", i, valorMes);
    if (valorMes > valoresMaiores)
    {
        numeroMes = i;
        valoresMaiores = valorMes;
    }
}

Console.WriteLine("O total Preenchido é: {0} ", totalPessoas/12);
Console.WriteLine("O mes com maior numero de pessoas é: {0} ", numeroMes);
Console.WriteLine("Total de pessoas no maior mes é: {0} ", valoresMaiores);

Console.ReadKey();