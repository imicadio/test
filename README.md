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
        
        
        
        
        
        COMBOBOX
        
            <ComboBox x:Name="Nazwa" HorizontalAlignment="Left" Margin="89,25,0,0" VerticalAlignment="Top" Width="120">
                <ComboBoxItem Content="Mleko" HorizontalAlignment="Left" Width="118"/>
                <ComboBoxItem Content="Sok" HorizontalAlignment="Left" Width="118"/>
                <ComboBoxItem Content="Chleb" HorizontalAlignment="Left" Width="118"/>
                <ComboBoxItem Content="Jabłko" HorizontalAlignment="Left" Width="118"/>
            </ComboBox>
