﻿namespace Azihub.SingleSignOn.Domain.Validations.Exceptions.VerifyMobileOtpExceptions
{
    public class MobileOtpIsNullException: MobileOtpException
    {
        public override int Code { get; } = (int)ErrorCodes.MobileOtpIsNull;
    }
}
