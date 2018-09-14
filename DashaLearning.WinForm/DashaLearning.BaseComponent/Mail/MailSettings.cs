using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DashaLearning.BaseComponent.Mail
{
    public class MailSettings
    {
        public string EmailHost { get; set; }
        public int EmailPort { get; set; }
        public string EmailUserName { get; set; }
        public string EmailPassword { get; set; }
        public bool EmailSSLEnabled { get; set; }
    }
}
