using System ;

public class pesawat {
    public string Nama;
    public int JumlahRoda;
    public string Ketinggian;
    public string JumlahPenumpang;

    public void terbang()
        {
            Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada diketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
        }
}

class pesawat_tempur:pesawat //ini merupakan inheritance dari class pesawat
    {
        public void terbangtinggi()
        {
            Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada diketinggian {2} dengan membawa jumlah penumpang sebanyak {3} akan meledakan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
        }
    }