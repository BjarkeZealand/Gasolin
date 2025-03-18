using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Gasolin.Model;

namespace Gasolin.Pages;

public class IndexModel : PageModel
{
    // slet??? private readonly ILogger<IndexModel> _logger;

    public Member[] members = new Member[5];

    /* slet ??? public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }*/

    public void OnGet()
    {
        members[0] = new Member("Kim Larsen", "pictures/kim-larsen.jpg", "Forsanger, Guitarist", 1945, 2018);
        members[1] = new Member("Franz Beckerlee", "franz-beckerlee.jpg", "Guitarist", 1942, 0);
        members[2] = new Member("Wili Jønsson", "wili-jønsson.jpg", "Bassist", 1942, 0);
        members[3] = new Member("Bjørn Uglebjerg", "bjørn-uglebjerg.jpg", "Trommeslager", 1948, 1994);
        members[4] = new Member("Søren Berlev", "søren-berlev.jpg", "Trommeslager", 1950, 0);
    }
}
