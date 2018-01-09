using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using Jenzabar.Portal.Framework.Web.UI;

namespace SandPortlet
{
    public class Sand : PortletBase
    {
        protected override PortletViewBase GetCurrentScreen()
        {
            PortletViewBase screen = null;

            switch (this.CurrentPortletScreenName)
            {
                default:
                    screen = this.LoadPortletView("ICS/SandPortlet/Default_View.ascx");
                    break;
            }

            return screen;
        }
    }
}
