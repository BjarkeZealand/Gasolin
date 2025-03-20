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
        members[0] = new Member("Kim Larsen", "kim-larsen.jpg", "Forsanger, Guitarist", 1945, 2018, "KimLarsen");
        members[1] = new Member("Franz Beckerlee", "nyfranz-beckerlee.jpg", "Guitarist", 1942, 0, "FranzBeckerlee");
        members[2] = new Member("Wili J�nsson", "wili-j�nsson.jpg", "Bassist", 1942, 0, "WiliJoensson");
        members[3] = new Member("Bj�rn Uglebjerg", "bj�rn-uglebjerg.jpg", "Trommeslager", 1948, 1994, "BjoernUglebjerg");
        members[4] = new Member("S�ren Berlev", "nysoeren-berlev.jpg", "Trommeslager", 1950, 0, "SoerenBerlev");

        members[0].Bio = "Kim Mellius Flyvholm Larsen (f�dt 23. oktober 1945 i K�benhavn, d�d 30. september 2018 i Odense) var en dansk sanger, sangskriver, folkeskolel�rer, forfatter og guitarist. Han begyndte sin musikalske karriere i 1968 efter en kort periode som folkeskolel�rer og blev fra 1969 kendt som medlem af rockgruppen Gasolin. I sin tid med Gasolin (varede indtil 1978) udgav Larsen dog ogs� s�vel soloplader og plader med sit fritidsband, der blev kendt under flere navne, og efter Gasolins opl�sning fortsatte Larsen som solist og bandleder.\r\n\r\nHan var fra 1970'erne en af Danmarks mest popul�re musikere og omtaltes ofte som \"Danmarks nationalskjald\", selv foretrak han dog blot at v�re \"spillemand\".\r\n\r\nHan fors�gte sig i starten af 1980'erne med et gennembrud i USA, og da dette ikke lykkedes, vendte han hjem til Danmark, hvor han blev medforfatter p� filmen Midt om Natten, havde den ene af hovedrollerne, en pr�station han blev anerkendt med en Robert for, og skrev og indspillede det meste af musikken til filmen.\r\n\r\nFra 1980'erne og frem indgik Kim Larsen i forskellige bands og grupper. I 1980'erne Kim Larsen & Bellami, i en periode af 1990'erne Kim Larsen & Bell*Star og fra midten af 1990'erne og i mere end tyve �r frem til Larsens d�d Kim Larsen & Kjukken.\r\n\r\nHan skrev ikke kun sange til eget brug, men ogs� adskillige sange, som andre kunstnere fremf�rte, ligesom Larsen ogs� kom med sine egne fortolkninger af danske og udenlandske evergreens og melodier samt en r�kke af de mest popul�re danske salmer.\r\n\r\nSom solist solgte han flere end tre millioner plader og samlet set over fem millioner eksemplarer.";
        members[1].Bio = "Franz Beckerlee (f�dt 15. august 1942) er en dansk musiker, der var guitarist i rockgruppen Gasolin. Han har desuden spillet jazz.\r\n\r\nBeckerlee spiller guitar og saxofon. Han begyndte at spille saxofon som 12-�rig. Sammen med Hugh Steinmetz, Niels Harrit, Steffen Andersen og Bo Thrige Andersen dannede han The Contemporary Jazz Quintet, som spillede avantgardejazz. Kvintetten fik megen ros af kritikere og presse, men fik ingen st�rre succes hos publikum. Franz fik tildelt �rets jazzlegat i 1964 og 1968. Derefter kom Franz Beckerlee med i Gasolin', hvor han spiller guitar a la Jimi Hendrix. Efter Gasolin' var Franz Beckerlee med i Christianshavns Bluesband sammen med S�ren Berlev og Lone Kellermann. ";
        members[2].Bio = "Wili J�nsson (f�dt 27. marts 1942 p� Amager) er dansk bassist, keyboardspiller og korsanger, der is�r er kendt for tiden som bassist med Gasolin', hvor han af is�r Kim Larsen blev kaldt \"den skel�jede halvsvensker\". Han har ogs� spillet i mange andre konstellationer, blandt andet med Sort Sol (band), Sanne Salomonsen og med Peter Belli. Modtog i 2008 Ken Gudman Prisen for sin fem �rtier lange musiske karriere. I 2009 deltog Wili J�nsson i TV2 programmet Allstars, som en del af kollegaen � tidligere forsanger fra Sort Sol � Steen J�rgensens kor. ";
        members[3].Bio = "Bj�rn Uglebjerg (21. marts 1948 i K�benhavn � 21. juni 1994) var en dansk trommeslager.\r\n\r\nSom 15-�rig i 1963 dannede Bj�rn Uglebjerg sammen med Peer Frost gruppen The Foottappers som senere blev til Les Rivals. Uglebjerg var f�rste trommeslager i Gasolin'. I 1971 blev han udskiftet med S�ren Berlev, og medvirkede senere som trommeslager og percussionist p� Skousen & Ingemanns Herfra hvor vi st�r (1971) og Lone Kellermann og Rockbandets F�r Natten Bli'r til dag (1978) og Tilf�ldigt Forbi (1979). Desuden var Uglebjerg fast medlem af Frede Norbrinks gruppe Frede Fup.\r\n\r\nUglebjerg var en flittigt benyttet studiemusiker og trommeslager i diverse konstellationer. Han var meget aktiv musikpolitisk herhjemme, og var en vellidt person i musiske kredse.[kilde mangler]\r\n\r\nHan dannede privat par med Susanne Mertz, som var en af grundene til han forlod Gasolin' i 1971. Han valgte at tilbringe tiden med hende, frem for de store tiltagende diskussioner som pr�gede bandet dengang. Susanne Mertz, datter af kunstmaler Albert Mertz, var og er stadigv�k fotograf, hvorfor mange af Bj�rns koncerter er foreviget af Susanne Mertz.\r\n\r\nFrem mod sin d�d spillede han flittigt i bandet \"All Stars\", som var et band der blev dannet som husorkester til en programr�kke i tv. I \"All Stars\" var der ogs� s� prominente musikere som Billy Cross, Flemming Ostermann og Jens Rugsted. Tv-udsendelserne gav efterf�lgende bandet en masse livejobs.\r\n\r\nBj�rn Uglebjerg bosatte sig de sidste �r af sit liv i Svendborg, og var ogs� her meget aktiv i musikforeningslivet. ";
        members[4].Bio = "S�ren \"Charlie\" Berlev (f�dt 4. maj 1950 i Skt. Nikolai sogn, Nakskov) er en dansk musiker, der blev kendt som trommeslager i Gasolin'. F�r Gasolin medlem af Dig og mig og solskin fra 1967-1969. Siden har han blandt andet v�re medlem af bandet Midnight Blues.\r\n\r\nS�ren Berlev er s�n af cand.mag. Finn Berlev (fra 1961 lektor i fysik og matematik p� Jonstrup Statsseminarium) og hustru Kirsten Marie Bahnson. S�ren Berlev er ikke d�bt.\r\n\r\nSom 19-�rig rejste S�ren hjemmefra og ind til slumstormermilj�et p� N�rrebro i K�benhavn. Han blaffede i 1970 til Thylejren, hvor han for f�rste gang h�rte Gasolin'.\r\n\r\nEfter Gasolin's opl�sning i 1978 flyttede S�ren Berlev til USA og boede der til 1984, hvor han i perioden indgik i forskellige bands, blandt andet rock/reggae-trioen Wild Remain der udsendte en enkelt single p� CBS i 1980, og ogs� turnerede i Danmark.\r\n\r\nI 1989 var han en del af den gendannede gruppe The Lollipops, der n�ede at udsende et enkelt album inden de gik fra hinanden igen.\r\n\r\nFra 1987 til 1992 spillede han desuden i Christianshavns Bluesband med blandt andre Franz Beckerlee, Lone Kellermann, Sten Hax�, Peter Mandorf m.fl. Bandet var flittig turnerende og fejrede store triumfer p� landets livescener, hvor de blandt andet spillede p� b�de Midtfyns Festival og Skanderborg Festival og desuden ogs� turnerede p� F�r�erne.\r\n\r\nI 1997-98 spillede Berlev i bandet Superhead, til hvilket han ogs� bidrog som sangskriver.\r\n\r\nHan blev i �r 2000 trommeslager i syretrioen Dream City med guitaristen T�mrerClaus og bassisten og sangeren Peter Ingemann.\r\n\r\nI 2007 p�begyndte S�ren Berlev arbejdet med en soloplade, med planlagt udgivelse i for�ret 2008, p� Sony Music. Resultatet forel� i marts 2008 med cd'en Timeless Choice.\r\n\r\nS�ren Berlev blev senere trommeslager i det gendannede Young Flowers med Peer Frost og Peter Ingemann. Han dannede i 10'erne ogs� bandet Berlev's Rock 'N' Roll Hotel, der udsendte pladerne You Can Make It (2018) og Close To The Line (2019). ";
    }
}
