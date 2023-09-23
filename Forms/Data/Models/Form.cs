namespace Forms.Data.Models
{
    public class Form
    {
        //Para simplificar el problema supondre que todos los formularios contienen 3 preguntas y 3 respuestas
        public int Id { get; set; }
        public string pregunta1 { get; set; }
        public string pregunta2 { get; set; }
        public string pregunta3 { get; set; }


        public Form(string pregunta1, string pregunta2, string pregunta3)
        {
            this.pregunta1 = pregunta1;
            this.pregunta2 = pregunta2;
            this.pregunta3 = pregunta3;
        }
    }
}
