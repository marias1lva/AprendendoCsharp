using System;
using System.Collections.Generic;

namespace ComparandoClientes.Entities {
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj) { // Sobrescreve o método Equals para comparar clientes com base no e-mail.
            if (!(obj is Client)) { // Verifica se o objeto passado é do tipo Client.
                return false;
            }
            Client other = obj as Client; // Faz o casting do objeto para Client.
            return Email.Equals(other.Email); // Compara os e-mails; se forem iguais, retorna true.
        }

        public override int GetHashCode() { // Sobrescreve o método GetHashCode, que gera um código baseado no e-mail.
            return Email.GetHashCode(); // Gera um hash code usando o e-mail. Objetos com o mesmo e-mail terão o mesmo hash.
        }
    }
}
