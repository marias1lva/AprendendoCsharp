namespace System {
    static class StringExtensions {
        public static string Cut(this string thisObj, int count) { // Método de extensão que "corta" uma string até um determinado número de caracteres
            if (thisObj.Length <= count) { // Verifica se o comprimento da string original é menor ou igual ao número de caracteres solicitado
                return thisObj; // Se for, retorna a string original sem alterações
            }else {
                return thisObj.Substring(0, count) + "..."; // Caso contrário, retorna uma substring da string original, cortada até o comprimento especificado
            }
        }
    }
}
