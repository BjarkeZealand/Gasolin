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
        members[0] = new Member("Kim Larsen", "pictures/kim-larsen.jpg", "Forsanger, Guitarist", 1945, 2018, "KimLarsen");
        members[1] = new Member("Franz Beckerlee", "pictures/nyfranz-beckerlee.jpg", "Guitarist", 1942, 0, "FranzBeckerlee");
        members[2] = new Member("Wili J�nsson", "pictures/wili-j�nsson.jpg", "Bassist", 1942, 0, "WiliJ�nsson");
        members[3] = new Member("Bj�rn Uglebjerg", "pictures/bj�rn-uglebjerg.jpg", "Trommeslager", 1948, 1994, "Bj�rnUglebjerg");
        members[4] = new Member("S�ren Berlev", "pictures/nysoeren-berlev.jpg", "Trommeslager", 1950, 0, "S�renBerlev");
    }
}
