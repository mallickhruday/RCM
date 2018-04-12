﻿namespace RCM.Domain.Models.ChequeModels.ChequeStates
{
    public class ChequeBloqueado : EstadoCheque
    {
        public override void Bloquear(Cheque cheque)
        {
        }

        public override void Compensar(Cheque cheque)
        {
            cheque.MudarEstado(new ChequeCompensado());
        }

        public override void Devolvido(Cheque cheque)
        {
            cheque.MudarEstado(new ChequeDevolvido());
        }

        public override void Repassar(Cheque cheque)
        {
            cheque.MudarEstado(new ChequeRepassado());
        }

        public override void Sustar(Cheque cheque)
        {
            cheque.MudarEstado(new ChequeSustado());
        }
    }
}