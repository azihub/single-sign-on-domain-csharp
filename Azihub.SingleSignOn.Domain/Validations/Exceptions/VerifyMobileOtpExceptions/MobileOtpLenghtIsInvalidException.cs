﻿namespace Azihub.SingleSignOn.Domain.Validations.Exceptions.VerifyMobileOtpExceptions
{
    public class MobileOtpLenghtIsInvalidException: MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileOtpLenghtIsInvalid;
    }
}
