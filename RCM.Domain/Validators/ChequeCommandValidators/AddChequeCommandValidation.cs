﻿using RCM.Domain.Commands.ChequeCommands;

namespace RCM.Domain.Validators.ChequeCommandValidators
{
    public class AddChequeCommandValidation : ChequeCommandValidator<AddChequeCommand>
    {
        public AddChequeCommandValidation()
        {
            ValidateBancoId();
            ValidateAgencia();
            ValidateConta();
            ValidateNumeroCheque();
            ValidateObservacao();
            ValidateClienteId();
            ValidateDataEmissao();
            ValidateDataVencimento();
            ValidateValor();
        }
    }
}
