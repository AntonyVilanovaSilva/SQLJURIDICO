using HtmlAgilityPack;
using Raspagem_Web_Scraping.D_ataA_ccessI_ayer.Base;
using Raspagem_Web_Scraping.Models;

namespace Raspagem_Web_Scraping.D_ataA_ccessI_ayer
{
    
        namespace Raspagem.D_ata
    {
        public class DAL_Curso : DAL_Base
        {
            private List<CursoViewModel> _cursos;
            private string _html = null!;
            public DAL_Curso() : base("https://www.udemy.com/pt/")
            {
                _cursos = new();
            }
            public List<CursoViewModel> Cursos() => _cursos;
            public void Limpar_Cursos() => _cursos.Clear();
            public async Task Preparar_Cursos()
            {
                _html = await this.Pegar_Html();
                List<CursoViewModel> cursos = this.Pegar_Cursos();
                _cursos.AddRange(cursos);
            }
            public async Task Preparar_Novamente_Cursos()
            {
                this.Limpar_Cursos();
                await this.Preparar_Cursos();
            }
            public List<CursoViewModel> Pegar_Cursos()
            {
                HtmlDocument doc = new();
                doc.LoadHtml(_html);

                doc.DocumentNode.SelectNodes("//*[@class='ud-text-xs']");

                return new(); //Troque pelo resultado
            }
            public CursoViewModel? Pegar_Curso(string instrutor)
            {
                //Implemente o código aqui

                return new(); //Troque pelo resultado
            }

        }
    }


}

