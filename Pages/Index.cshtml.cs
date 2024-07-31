using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class Index : PageModel
    {
        public void OnGet() 
        { 
        }
        //public List<Category> Categories { get; set; } = new(); //inicialização anónima . já sabe qual é o tipo da 1ª parte

        ////public async Task<IActionResult> OnGet() //ao pedir informação - renderização
        //public async Task OnGet() //ao pedir informação - renderização
        //{
        //    //var categories = new List<Category>(); não vamos por aqui pq não tenho como acessar. Não tenho metodo get. Preciso de uma propriedade.
        //    await Task.Delay(5000); //Espera 5 segundos enquanto está a ser processado do lado do servidor
        //    for (var i = 0; i <= 100; i++)
        //    {
        //        Categories.Add(
        //            item: new Category(i, Title: $"Categoria {i}", Price: i * 18.95M));
        //    }
        //}

        //public void OnPost()
        //{ //ao enviar informação
        //}
    }
}


