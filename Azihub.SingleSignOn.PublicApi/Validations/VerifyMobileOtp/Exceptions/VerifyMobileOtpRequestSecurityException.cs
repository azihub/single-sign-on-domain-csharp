﻿using Azihub.AppConsole.Base.Exceptions;
using Azihub.SingleSignOn.PublicApi.Locales;
using System;

namespace Azihub.SingleSignOn.PublicApi.Validations.VerifyMobileOtp.Exceptions
{
    public class VerifyMobileOtpRequestSecurityException : SecurityException
    {
        public VerifyMobileOtpRequestSecurityException()
        {

        }
        public VerifyMobileOtpRequestSecurityException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        public override int Code { get; } = (int)ErrorCodes.VerifyMobileOtpFailed;
        public override string LocaleConst => LocaleConsts.VERIFY_MOBILE_OTP_FAILED;
    }
}
