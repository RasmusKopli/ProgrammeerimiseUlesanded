namespace IF_ELSEIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Küsi kasutajalt tema pikkust
            //Console.WriteLine("Palun sisesta oma pikkus (m)");
            //decimal Pikkus = decimal.Parse(Console.ReadLine());
            //if (Pikkus < 0)
            //{
            //    Console.WriteLine("Võimatu pikkus");
            //}
            //else if (Pikkus < 1)
            //{
            //    Console.WriteLine("Juntsu");
            //}
            //else if (Pikkus < 2)
            //{
            //    Console.WriteLine("Tavaline kogle oled");
            //}
            //else if (Pikkus > 2)
            //{
            //    Console.WriteLine("Oled hiiglane");
            //}

            //kui ta on lühem kui 0cm, ütle võimatu pikkus
            //kui ta on lühem kui 1m, ütle juntsu
            //kui ta on lühem kui 2m, ütle tavaline kolge
            //kui ta on pikem kui 2m, ütle hiiglane

            //Console.WriteLine("Kui vana sa oled?");
            //int kasutajavanus = int.Parse(Console.ReadLine());
            //Console.WriteLine("Mis on praegune aasta?");
            //int praeguneAasta = int.Parse(Console.ReadLine());
            //int arvuta_aasta = praeguneAasta - kasutajavanus;
            //if (arvuta_aasta > 2020 && arvuta_aasta < 2025)
            //{
            //    Console.WriteLine("Kes sulle arvuti juba andis??");
            //}
            //if (arvuta_aasta < 2015 && arvuta_aasta > 2020)
            //{

            //}

            //Küsi kasutajalt kui vana ta on
            //küsi kasutajalt praegust aastaarvu
            //lahuta aasta kasutaja vanus
            //kui kasutaja on sündinud 2025-2020, ütle talle, kes sulle arvuti juba andis
            //kui kasutaja on sündinud 2020-2015, ütle talle, skibidi sigmaless
            //kui kasutaja on sündinud 2015-2010, ütle talt, kas ta tahab saada programmeerijaks
            //   Kui jah, ütle tubli
            //   kui ei, ütle kahju
            //kui kasutaja on sündinud enne 2010, küsi mitu rage comicsit oma redditi lugemise ajal leidis

            //küsi kasutajalt tema elukoha suunakoodi
            //kui suunakood on väiksem kui 5 tähe, ütle talle 1 täht on puudu
            //kui suunakood on suurem kui 5 tähe, ütle talle 1 täht on üle
            //kui suunakoodis on 5 tähta, ütle "Ahha nüüd tean kus elad"

            //Küsi kasutajalt kas ta töötab
            //kui kasutaja vastab jah, siis ütle tubli
            //kui kasutaja vastab ei, siis ütle kahju, miks sa siis töökohta ei otsi?
            //Kui kasutaja vastab otsisin, siis ütle, loodan et saad varsti tööle :)

            //küsi kasutjalat tema parooli
            //seejärel küsi kasutajalt tema 2FA koodi
            //kui parool on vale, ütle sissepääs on keelatud
            //kui parool on õige, kontrolli 2FA koodi
            //   Kui 2FA kood on lühem kui 6 tähte, ütle sissepääs keelatud, kood on liiga lühike
            //   Kui 2FA kood on pikem kui 6 tähte, ütle sissepääs keelatud, kood on liiga pikk
            //   Kui 2FA kood pn 6 tähte, siis lase sisse,
            //NB: 2FA kood ei pea matchima ekisteeriva näitega nagu parool


            //bool pliiatsid = false;
            //bool paber = false;
            //bool saag = false;
            //bool lauad = false;
            //string sisestus = "";
            //int i = 0;
            //while (i < 4)
            //{
            //    switch (i)
            //    {
            //        case 0:
            //            Console.WriteLine("Kas sul on pliitatsid");
            //            break;                    
            //        case 1:
            //            Console.WriteLine("Kas sul on paber?");
            //            break;
            //        case 2:
            //            Console.WriteLine("Kas sul on saag");
            //            break;
            //        case 3:
            //            Console.WriteLine("Kas sul on lauad?");
            //            break;
            //        default:
            //            break;
            //    }
            //    while (sisestus == "")
            //    {
            //        sisestus = Console.ReadLine();
            //    }
            //    if (sisestus == "ei")
            //    {
            //        switch (i)
            //        {
            //            case 0:
            //                pliiatsid = false;
            //                break;
            //            case 1:
            //                paber = false;
            //                break;
            //            case 2:
            //                saag = false;
            //                break;
            //            case 3:
            //                lauad = false;
            //                break;
            //        }
            //    }
            //    else if (sisestus == "jah")
            //    {
            //        switch (i)
            //        {
            //            case 0:
            //                pliiatsid = true;
            //                break;
            //            case 1:
            //                paber = true;
            //                break;
            //            case 2:
            //                saag = true;
            //                break;
            //            case 3:
            //                lauad = true;
            //                break;
            //        }
            //    }
            //    i++;
            //    sisestus = "";
            //}
            //if (!pliiatsid && !paber && lauad && saag)
            //{
            //    Console.WriteLine("Võiksid õppida tisleriks");
            //}
            //else if (pliiatsid && paber && !lauad && !saag)
            //{
            //    Console.WriteLine("Võid õppida arhitektiks");
            //}
            //else if (pliiatsid && paber && lauad && saag)
            //{
            //    Console.WriteLine("Võiksid õppida arhitektiks ja tisleriks, sul on kõik uksed avatud");
            //}
            //else if (pliiatsid && !paber && !lauad && saag)
            //{
            //    Console.WriteLine("Sul on tööriistad, aga materjali mitte, ma ei oska õelda");
            //}
            //else if (!pliiatsid && paber && lauad && !saag)
            //{
            //    Console.WriteLine("Sul on materjal, aga pole tööriistu, mine k-rauta");
            //}
            //else
            //{
            //    Console.WriteLine("Tühjade kätega ei tee midagi :(");
            //}

            //Console.WriteLine("Kas sul on pliiatsid?");
            //sisestus = Console.ReadLine();
            //if (sisestus == "jah")
            //{
            //    pliiatsid = true;
            //}
            //else if (sisestus == "ei")
            //{
            //    pliiatsid = false;
            //}
            //Console.WriteLine("Kas sul on paber?");
            //sisestus = Console.ReadLine();
            //if (sisestus == "jah")
            //{
            //    paber = true;
            //}
            //else if (sisestus == "ei")
            //{
            //    paber = false;
            //}
            //Console.WriteLine("Kas sul on saag?");
            //sisestus = Console.ReadLine();
            //if (sisestus == "jah")
            //{
            //    saag = true;
            //}
            //else if (sisestus == "ei")
            //{
            //    saag = false;
            //}
            //Console.WriteLine("Kas sul on lauad?");
            //sisestus = Console.ReadLine();
            //if (sisestus == "jah")
            //{
            //    lauad = true;
            //}
            //else if (sisestus == "ei")
            //{
            //    lauad = false;
            //}
        }
    }
}
