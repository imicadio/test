https://www.dotnetperls.com/icomparable sortowanie w kolejości

http://forum.pasja-informatyki.pl/30804/c%23-zapis-tekstu-w-pliku-txt-w-nowej-linii-po-ponownym-otworzeniu-programu zapis tekstu do .txt


public void GenerujRaport()


        {
            //string nazwa = "Raport" + DateTime.Now.ToString("ddMMyyyyHHmm") + ".txt";
            string nazwa = DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

            using (StreamWriter sw = new StreamWriter(nazwa))
            {
                sw.Write(Oczekujacy());
            }
        }
