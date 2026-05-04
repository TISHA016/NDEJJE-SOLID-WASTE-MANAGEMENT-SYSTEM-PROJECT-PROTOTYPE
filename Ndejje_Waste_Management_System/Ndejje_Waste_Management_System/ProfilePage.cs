using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ndejje_Waste_Management_System
{
    public class ProfilePage : Panel
    {
        public ProfilePage()
        {
            this.Dock = DockStyle.Fill;
            this.BackColor = Color.FromArgb(244, 244, 242); // Light Gray Background

            // ── Title ──
            Label lblHeader = new Label
            {
                Text = "Account Profile",
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                ForeColor = Color.FromArgb(27, 58, 107),
                Bounds = new Rectangle(30, 20, 300, 40)
            };

            // ── Profile Card (White Box) ──
            Panel profileCard = new Panel
            {
                BackColor = Color.White,
                Bounds = new Rectangle(30, 70, 450, 400),
                BorderStyle = BorderStyle.None
            };

            // User Image Placeholder (Circle)
            Panel pnlAvatar = new Panel
            {
                BackColor = Color.FromArgb(15, 107, 116), // Teal
                Bounds = new Rectangle(175, 30, 100, 100)
            };
            // Logic to make it a circle
            pnlAvatar.Paint += (s, e) => {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillEllipse(new SolidBrush(pnlAvatar.BackColor), 0, 0, 99, 99);
            };

            // Display Name & Role
            Label lblName = new Label
            {
                Text = DataStore.CurrentUser.FullName,
                Font = new Font("Segoe UI", 12f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Bounds = new Rectangle(0, 140, 450, 30)
            };

            Label lblRoleBadge = new Label
            {
                Text = DataStore.CurrentUser.Role,
                BackColor = Color.FromArgb(230, 245, 236),
                ForeColor = Color.FromArgb(26, 122, 64),
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                Bounds = new Rectangle(150, 175, 150, 25)
            };

            // Detail List (HTML Table equivalent)
            int startY = 230;
            AddDetail(profileCard, "User ID:", DataStore.CurrentUser.UserID, startY);
            AddDetail(profileCard, "Phone:", DataStore.CurrentUser.Phone, startY + 40);
            AddDetail(profileCard, "Primary Zone:", DataStore.CurrentUser.AssignedZone, startY + 80);

            // Edit Profile Button
            Button btnEdit = new Button
            {
                Text = "Edit Account Details",
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(27, 58, 107),
                ForeColor = Color.White,
                Bounds = new Rectangle(100, 340, 250, 40)
            };

            profileCard.Controls.AddRange(new Control[] { pnlAvatar, lblName, lblRoleBadge, btnEdit });
            this.Controls.Add(lblHeader);
            this.Controls.Add(profileCard);
        }

        private void AddDetail(Panel p, string label, string value, int y)
        {
            Label lblL = new Label { Text = label, Font = new Font("Segoe UI", 9f, FontStyle.Bold), Bounds = new Rectangle(50, y, 100, 20), ForeColor = Color.Gray };
            Label lblV = new Label { Text = value, Font = new Font("Segoe UI", 9f), Bounds = new Rectangle(160, y, 250, 20) };
            p.Controls.Add(lblL);
            p.Controls.Add(lblV);
        }
    }
}