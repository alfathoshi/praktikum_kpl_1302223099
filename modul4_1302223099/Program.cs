using static Program.KodeBuah;
using static Program.PosisiKarakterGame;

public class Program
{
    public class KodeBuah
    {
        public enum Buah { Apel, Aprikot, Alpukat, Pisang, Paprika, Blackberry, Ceri, Kelapa, Jagung, Kurma, Durian, Anggur, Melon, Semangka }
        public static string getKodeBuah(Buah buah)
        {
            string[] kodeBuah = { "A00", "B00", "C00", "D00", "E00", "F00", "G00", "H00", "I00", "J00", "K00", "L00", "M00", "N00", "O00", };
            return kodeBuah[(int)buah];
        }
    }

    public class PosisiKarakterGame
    {
        public enum CharState { Jongkok, Berdiri, Tengkurap, Terbang }

        public enum Trigger { TombolW, TombolS, TombolX }

        public class Transition
        {
            public CharState stateAwal;
            public CharState stateAkhir;
            public Trigger trigger;
            public Transition(CharState stateAwal, CharState stateAkhir, Trigger trigger)
            {
                this.stateAwal = stateAwal;
                this.stateAkhir = stateAkhir;
                this.trigger = trigger;
            }
        }
        Transition[] transisi =
        {
            new Transition(CharState.Berdiri, CharState.Jongkok, Trigger.TombolS),
            new Transition(CharState.Berdiri, CharState.Terbang, Trigger.TombolW),
            new Transition(CharState.Jongkok, CharState.Berdiri, Trigger.TombolW),
            new Transition(CharState.Jongkok, CharState.Tengkurap, Trigger.TombolS),
            new Transition(CharState.Tengkurap, CharState.Jongkok, Trigger.TombolW),
            new Transition(CharState.Terbang, CharState.Jongkok, Trigger.TombolX),
            new Transition(CharState.Terbang, CharState.Berdiri, Trigger.TombolS),
        };

        public CharState currentState = CharState.Berdiri;

        public CharState getNextState(CharState stateAwal, Trigger trigger)
        {
            CharState stateAkhir = stateAwal;
            for (int i = 0; i < transisi.Length; i++)
            {
                Transition transition = transisi[i];
                if (stateAwal == transition.stateAwal && trigger == transition.trigger)
                {
                    stateAkhir = transition.stateAkhir;
                }
            }
            return stateAkhir;
        }

        public void ActiveTrigger(Trigger trigger)
        {
            if (trigger == Trigger.TombolS)
            {
                Console.WriteLine("tombol arah bawah ditekan");
            }
            else if (trigger == Trigger.TombolW)
            {
                Console.WriteLine("tombol arah atas ditekan");

            }
            currentState = getNextState(currentState, trigger);
            Console.WriteLine("State anda sekarang: " + currentState);
        }
    }

    public static void Main(string[] args)
    {

        Buah buah = Buah.Blackberry;
        string kodeBuah = getKodeBuah(buah);
        Console.WriteLine("Kode Buah");
        Console.WriteLine("Buah " + buah + " memiliki kode buah: " + kodeBuah);
        Console.WriteLine();

        Console.WriteLine("Posisi Karakter Game");
        PosisiKarakterGame objKarakter = new PosisiKarakterGame();
        Console.WriteLine("State Awal: " + objKarakter.currentState);
        Console.WriteLine();

        objKarakter.ActiveTrigger(Trigger.TombolS);
        Console.WriteLine();
        objKarakter.ActiveTrigger(Trigger.TombolW);
    }

}