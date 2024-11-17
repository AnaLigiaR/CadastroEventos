namespace CadastroEventos.Models
{
    public class Evento
    {
        public string NomeEvento {  get; set; }
        public string Local { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFinal {  get; set; }
        public double ValorParticipante { get; set; }
        public int NumeroParticipantes { get; set; }       

        public int Estadia
        {
            get => DataFinal.Subtract(DataInicio).Days;
        }

        public double ValorTotal
        {
            get
            {
                double valor_participantes = NumeroParticipantes * ValorParticipante;

                double total = valor_participantes * Estadia;

                return total;
            }
        }

    }
}
