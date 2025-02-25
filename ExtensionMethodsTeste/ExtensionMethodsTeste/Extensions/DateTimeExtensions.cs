using System.Globalization;

namespace System { // Extensão diretamente no namespace System, para adicionar funcionalidades ao tipo DateTime
    static class DateTimeExtensions { // Define uma classe estática que contém métodos de extensão
        public static string ElapsedTime(this DateTime thisObj) { // Método de extensão que calcula o tempo decorrido desde a data fornecida

            // Calcula a diferença de tempo entre o momento atual (DateTime.Now) e o objeto DateTime fornecido (thisObj)
            TimeSpan duration = DateTime.Now.Subtract(thisObj);
            if (duration.TotalHours < 24.0) { // Verifica se o tempo decorrido é menor que 24 horas
                // Retorna o tempo em horas, formatado com uma casa decimal (ex.: 5.2 hours)
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours"; 
            }
            else {
                // Retorna o tempo em dias, formatado com uma casa decimal (ex.: 3.7 days)
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
        }
    }
}