﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CoreMailer.Models;

namespace CoreMailer.Interfaces
{
    public interface ICoreMailer
    {
        void Send(MailerModel model);
        Task SendAsyn(MailerModel model);
    }
}
