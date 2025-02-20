using System; 

namespace WithdrawLimit.Entities.Exceptions {
    class DomainException : ApplicationException {
        public DomainException(string message) : base(message) {
        }
    }
}
