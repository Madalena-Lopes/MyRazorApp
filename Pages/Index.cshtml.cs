using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyRazorApp.Pages
{
    public class Index : PageModel
    {
        public void OnGet() 
        { 
        }
        //public List<Category> Categories { get; set; } = new(); //inicializa��o an�nima . j� sabe qual � o tipo da 1� parte

        ////public async Task<IActionResult> OnGet() //ao pedir informa��o - renderiza��o
        //public async Task OnGet() //ao pedir informa��o - renderiza��o
        //{
        //    //var categories = new List<Category>(); n�o vamos por aqui pq n�o tenho como acessar. N�o tenho metodo get. Preciso de uma propriedade.
        //    await Task.Delay(5000); //Espera 5 segundos enquanto est� a ser processado do lado do servidor
        //    for (var i = 0; i <= 100; i++)
        //    {
        //        Categories.Add(
        //            item: new Category(i, Title: $"Categoria {i}", Price: i * 18.95M));
        //    }
        //}

        //public void OnPost()
        //{ //ao enviar informa��o
        //}
    }
}


