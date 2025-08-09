string ad, soyad, cinsiyet, seviye;
int dogum;
Console.Write("Adınız:");
ad = Convert.ToString(Console.ReadLine());
Console.Write("Soyadınız:");
soyad = Convert.ToString(Console.ReadLine());
Console.Write("Cinsiyetiniz: (erkek,kadın) ");
cinsiyet = Convert.ToString(Console.ReadLine());
Console.Write("Doğduğunuz yıl: ");
dogum = Convert.ToInt16(Console.ReadLine());
int yas = 2025 - dogum;
Console.Write("Spor Seviyeniz; (başlangıç, orta, ileri) ");
seviye = Convert.ToString(Console.ReadLine());
if (cinsiyet == "erkek")
{
    string hitap = "bey";
    Console.WriteLine("Haftada 7 gün program uygulanacaktır ");
    if (0 < yas && yas<30)
    {
        Console.WriteLine("Haftada 4 gün antrenman günü olacaktır. ");
        if (seviye == "başlangıç")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Kardiyo", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Kardiyo", "Dinlenme" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4} gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i-1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "orta")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Kardiyo", "Dinlenme" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman:{5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "ileri")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Dinlenme" };
            int i = gun % 7;
            if(i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman:{5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else
            Console.Write("Seviye düzgün yazılmadığı için program çalışamayacaktır tekrar denemek için çıkın ve tekrar giriş yapınız ");
    }
    else if (30 < yas && yas< 100)
    {
        Console.WriteLine("Haftada 3gün antrenman günü olacaktır. ");
        if (seviye == "başlangıç")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Dinlenme", "Dinlenme", "Güç Antrenmaı", "Dinlenme", "Kardiyo", "Dinlenme" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "orta")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Dinlenme", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Dinlenme" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "ileri")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Güç Antrenmanı", "Dinlenme", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Dinlenme" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else
            Console.Write("Seviye düzgün yazılmadığı için program çalışamayacaktır tekrar denemek için çıkın ve tekrar giriş yapınız ");
    }
    else
        Console.WriteLine("Doğum yılı düzgün yazılmadığı için program çalışamayacaktır tekrar denemek için çıkın ve tekrar giriş yapınız ");
}
else if (cinsiyet == "kadın")
{
    string hitap = "hanım";
    Console.Write("Haftada 6gün program uygulanacaktır.");
    if (0 < yas && yas < 30)
    {
        Console.WriteLine("Haftada 4gün antrenman günü olacaktır. ");
        if (seviye == "başlangıç")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Kardiyo", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Kardiyo", "Tatil" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "orta")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Kardiyo", "Tatil" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "ileri")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Tatil" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else
            Console.Write("Seviye düzgün yazılmadığı için program çalışamayacaktır tekrar denemek için çıkın ve tekrar giriş yapınız ");
    }
    else if (30 < yas && yas < 100)
    {
        Console.WriteLine("Haftada 3gün antreanman günü olacaktır. ");
        if (seviye == "başlangıç")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Dinlenme", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Kardiyo", "Tatil" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "orta")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Kardiyo", "Dinlenme", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Tatil" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else if (seviye == "ileri")
        {
            Console.Write("Kaç gün sonra spora başlayacaksınız? ");
            int gun = Convert.ToInt16(Console.ReadLine());
            string[] program = { "Güç Antrenmanı", "Dinlenme", "Dinlenme", "Güç Antrenmanı", "Dinlenme", "Güç Antrenmanı", "Tatil" };
            int i = gun % 7;
            if (i == 0)
                i = i + 1;
            Console.WriteLine("\nSayın {0} {1} {2} {3} yaşındasınız. {4}gün\r\n sonrası için planlanan antrenman: {5} olacaktır. \n", ad, soyad, hitap, yas, gun, program[i - 1]);
            Console.WriteLine("Haftalık programınız bu şekildedir;");
            foreach (string s in program)
                Console.WriteLine("{0}", s);
        }
        else
            Console.Write("Seviye düzgün yazılmadığı için program çalışamayacaktır tekrar denemek için çıkın ve tekrar giriş yapınız ");
    }
    else
        Console.WriteLine("Doğum yılı düzgün yazılmadığı için program çalışamayacaktır tekrar denemek için çıkın ve tekrar giriş yapınız ");
}
else
{
    Console.Write("Cinsiyet düzgün yazılmadığı için program çalışamayacaktır tekrar denemek için çıkın ve tekrar giriş yapınız ");
    return;
}
