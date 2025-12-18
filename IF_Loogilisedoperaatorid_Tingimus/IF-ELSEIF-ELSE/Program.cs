namespace IF_ELSEIF_ELSE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Küsi kasutajalt tema pikkust
            Console.WriteLine("Palun sisesta oma pikkus (m)");
            decimal Pikkus = decimal.Parse(Console.ReadLine());
            if (Pikkus < 0)
            {
                Console.WriteLine("Võimatu pikkus");
            }
            else if (Pikkus < 1)
            {
                Console.WriteLine("Juntsu");
            }
            else if (Pikkus < 2)
            {
                Console.WriteLine("Tavaline kogle oled");
            }
            else if (Pikkus > 2)
            {
                Console.WriteLine("Oled hiiglane");
            }

            //kui ta on lühem kui 0cm, ütle võimatu pikkus
            //kui ta on lühem kui 1m, ütle juntsu
            //kui ta on lühem kui 2m, ütle tavaline kolge
            //kui ta on pikem kui 2m, ütle hiiglane

            Console.WriteLine("Kui vana sa oled?");
            int kasutajavanus = int.Parse(Console.ReadLine());
            Console.WriteLine("Mis on praegune aasta?");
            int praeguneAasta = int.Parse(Console.ReadLine());
            int arvuta_aasta = praeguneAasta - kasutajavanus;
            if (arvuta_aasta > 2020 && arvuta_aasta < 2025)
            {
                Console.WriteLine("Kes sulle arvuti juba andis??");
            }
            if (arvuta_aasta < 2015 && arvuta_aasta > 2020)
            {

            }

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

        }
    }
}
