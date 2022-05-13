using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ElenStore
{
    class EntryValidation : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            int number;
            if (!Int32.TryParse(sender.Text, out number))
                sender.BackgroundColor = Color.Red;
            else
                sender.BackgroundColor = Color.Default;
        }
    }
}
