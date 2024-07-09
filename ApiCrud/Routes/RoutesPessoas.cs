using ApiCrud.Models;

namespace ApiCrud.Routes
{
    public static class RoutesPessoas
    {
        public static List<Pessoa> Pessoas = new List<Pessoa>()
        {
            new Pessoa(Guid.NewGuid(), "Maria"),
            new Pessoa(Guid.NewGuid(), "Pedro"),
            new Pessoa(Guid.NewGuid(), "Carlos")
        };

        public static void MapRoutePessoa(this WebApplication app)
        {
            app.MapGet("/pessoas", () => Pessoas);

            app.MapGet("/pessoas/{nome}", (string nome) => Pessoas.Find(x => x.Nome == nome));

            app.MapPost("/pessoas", (HttpContext request,Pessoa pessoa) =>
            {
                var nome = request.Request.Query["name"];

                Pessoas.Add(pessoa);
                return pessoa;
            });

            app.MapPut("/pessoas/{id:guid}", (Guid id, Pessoa pessoa) =>
            {
                var encontrado = Pessoas.Find(x => x.Id == id);

                if (encontrado == null)
                {
                    return Results.NotFound();
                }

                encontrado.Nome = pessoa.Nome;
                return Results.Ok();
            });
        }
    }
}
