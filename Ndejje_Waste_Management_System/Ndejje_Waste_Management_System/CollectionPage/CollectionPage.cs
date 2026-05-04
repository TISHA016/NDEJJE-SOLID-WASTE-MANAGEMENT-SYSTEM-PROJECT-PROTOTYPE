using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Ndejje_Waste_Management_System
{
    public class CollectionPage : Panel
    {
        public CollectionPage()
        {
            this.Dock = DockStyle.Fill;
            Label lblArea = new Label { Text = "Area Name:", Location = new Point(20, 20) };
            TextBox txtArea = new TextBox { Location = new Point(20, 45), Width = 200 };

            Label lblWeight = new Label { Text = "Weight (kg):", Location = new Point(20, 80) };
            TextBox txtWeight = new TextBox { Location = new Point(20, 105), Width = 200 };

            Button btnSave = new Button
            {
                Text = "Save Entry",
                Location = new Point(20, 150),
                BackColor = Color.FromArgb(15, 107, 116),
                ForeColor = Color.White
            };

            btnSave.Click += (s, e) =>
            {
                var area = txtArea.Text?.Trim();
                var weightText = txtWeight.Text?.Trim();

                if (string.IsNullOrWhiteSpace(area))
                {
                    MessageBox.Show("Please enter the area name.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtArea.Focus();
                    return;
                }

                if (!double.TryParse(weightText, NumberStyles.Float | NumberStyles.AllowThousands, CultureInfo.CurrentCulture, out double weight))
                {
                    MessageBox.Show("Please enter a valid weight (e.g. 12.5).", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtWeight.Focus();
                    return;
                }

                DataStore.History.Add(new WasteEntry
                {
                    Area = area,
                    Weight = weight,
                    Date = DateTime.Now
                });

                MessageBox.Show("Collection Logged!");
            };

            this.Controls.AddRange(new Control[] { lblArea, txtArea, lblWeight, txtWeight, btnSave });
        }
    }
}