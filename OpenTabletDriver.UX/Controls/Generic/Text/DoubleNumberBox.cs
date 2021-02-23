using Eto.Forms;
using OpenTabletDriver.UX.Controls.Generic.Text.Providers;
using System.Globalization;

namespace OpenTabletDriver.UX.Controls.Generic.Text
{
    public class DoubleNumberBox : MaskedTextBox<double>
    {
        private class DoubleTextProvider : NumberTextProvider<double>
        {
            public override double Value
            {
                set => Text = value.ToString(CultureInfo.InvariantCulture);
                get => double.TryParse(Text, NumberStyles.Any, CultureInfo.InvariantCulture, out var val) ? val : default(double);
            }
        }
    }
}