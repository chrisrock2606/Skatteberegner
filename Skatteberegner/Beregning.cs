namespace Skatteberegner
{
    public class Beregning
    {
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave)
        {
            double gaveÅrTotal = julegave + andenGave;
            double beskatningAfGave = 0;
            if (gaveÅrTotal > 1200)
            {
                beskatningAfGave += andenGave;
                if (julegave > 900)
                {
                    beskatningAfGave += julegave;
                }
            }

            return beskatningAfGave;
        }
    }
}
