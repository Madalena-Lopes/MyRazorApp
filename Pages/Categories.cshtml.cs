using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new(); //inicializa��o an�nima . j� sabe qual � o tipo da 1� parte

        //public async Task<IActionResult> OnGet() //ao pedir informa��o - renderiza��o
        public void OnGet(int skip = 0, int take = 25) //ao pedir informa��o - renderiza��o
        {
            //var categories = new List<Category>(); n�o vamos por aqui pq n�o tenho como acessar. N�o tenho metodo get. Preciso de uma propriedade.
            //await Task.Delay(5000); //Espera 5 segundos enquanto est� a ser processado do lado do servidor
            
            var temp = new List<Category>(); //Balta diz q isto � c�digo porco. Q h� c�digo melhor q este na curso entity framework
            for (var i = 0; i <= 1787; i++)
            {
                temp.Add(
                    item: new Category(i, Title: $"Categoria {i}", Price: i * 18.95M));
            }

            Categories = temp.Skip(skip).Take(take).ToList(); //pular 0 e pegar 25. Pega sempre 25 em 25 - paginar
        }

    }

    //record para criar uma class sem comportamento - representa uma class de forma mt simples
    public record Category(
        int Id, 
        string Title,
        decimal Price);
}
